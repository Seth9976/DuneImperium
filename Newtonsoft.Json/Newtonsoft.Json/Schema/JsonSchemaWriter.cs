using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x020000AE RID: 174
	public class JsonSchemaWriter : Object
	{
		// Token: 0x06000FB9 RID: 4025 RVA: 0x00058AEC File Offset: 0x00056CEC
		// Note: this type is marked as 'beforefieldinit'.
		static JsonSchemaWriter()
		{
			Il2CppClassPointerStore<JsonSchemaWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Schema", "JsonSchemaWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSchemaWriter>.NativeClassPtr);
			JsonSchemaWriter.NativeFieldInfoPtr__writer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaWriter>.NativeClassPtr, "_writer");
			JsonSchemaWriter.NativeFieldInfoPtr__resolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaWriter>.NativeClassPtr, "_resolver");
			JsonSchemaWriter.NativeMethodInfoPtr__ctor_Public_Void_JsonWriter_JsonSchemaResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaWriter>.NativeClassPtr, 100666063);
			JsonSchemaWriter.NativeMethodInfoPtr_ReferenceOrWriteSchema_Private_Void_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaWriter>.NativeClassPtr, 100666064);
			JsonSchemaWriter.NativeMethodInfoPtr_WriteSchema_Public_Void_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaWriter>.NativeClassPtr, 100666065);
			JsonSchemaWriter.NativeMethodInfoPtr_WriteSchemaDictionaryIfNotNull_Private_Void_JsonWriter_String_IDictionary_2_String_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaWriter>.NativeClassPtr, 100666066);
			JsonSchemaWriter.NativeMethodInfoPtr_WriteItems_Private_Void_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaWriter>.NativeClassPtr, 100666067);
			JsonSchemaWriter.NativeMethodInfoPtr_WriteType_Private_Void_String_JsonWriter_JsonSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaWriter>.NativeClassPtr, 100666068);
			JsonSchemaWriter.NativeMethodInfoPtr_WritePropertyIfNotNull_Private_Void_JsonWriter_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaWriter>.NativeClassPtr, 100666069);
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x00058BD0 File Offset: 0x00056DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755689, XrefRangeEnd = 755695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSchemaWriter(JsonWriter writer, JsonSchemaResolver resolver)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSchemaWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaWriter.NativeMethodInfoPtr__ctor_Public_Void_JsonWriter_JsonSchemaResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x00058C30 File Offset: 0x00056E30
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 755699, RefRangeEnd = 755705, XrefRangeStart = 755695, XrefRangeEnd = 755699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReferenceOrWriteSchema(JsonSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaWriter.NativeMethodInfoPtr_ReferenceOrWriteSchema_Private_Void_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x00058C74 File Offset: 0x00056E74
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 755860, RefRangeEnd = 755864, XrefRangeStart = 755705, XrefRangeEnd = 755860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteSchema(JsonSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaWriter.NativeMethodInfoPtr_WriteSchema_Public_Void_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x00058CB8 File Offset: 0x00056EB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 755884, RefRangeEnd = 755886, XrefRangeStart = 755864, XrefRangeEnd = 755884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteSchemaDictionaryIfNotNull(JsonWriter writer, string propertyName, IDictionary<string, JsonSchema> properties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaWriter.NativeMethodInfoPtr_WriteSchemaDictionaryIfNotNull_Private_Void_JsonWriter_String_IDictionary_2_String_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x00058D20 File Offset: 0x00056F20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 755907, RefRangeEnd = 755908, XrefRangeStart = 755886, XrefRangeEnd = 755907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteItems(JsonSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaWriter.NativeMethodInfoPtr_WriteItems_Private_Void_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x00058D64 File Offset: 0x00056F64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 755962, RefRangeEnd = 755964, XrefRangeStart = 755908, XrefRangeEnd = 755962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteType(string propertyName, JsonWriter writer, JsonSchemaType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaWriter.NativeMethodInfoPtr_WriteType_Private_Void_String_JsonWriter_JsonSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x00058DC8 File Offset: 0x00056FC8
		[CallerCount(0)]
		public unsafe void WritePropertyIfNotNull(JsonWriter writer, string propertyName, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaWriter.NativeMethodInfoPtr_WritePropertyIfNotNull_Private_Void_JsonWriter_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x00007528 File Offset: 0x00005728
		public JsonSchemaWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x00058E30 File Offset: 0x00057030
		// (set) Token: 0x06000FC3 RID: 4035 RVA: 0x00007531 File Offset: 0x00005731
		public unsafe JsonWriter _writer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaWriter.NativeFieldInfoPtr__writer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaWriter.NativeFieldInfoPtr__writer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000FC4 RID: 4036 RVA: 0x00058E60 File Offset: 0x00057060
		// (set) Token: 0x06000FC5 RID: 4037 RVA: 0x00007550 File Offset: 0x00005750
		public unsafe JsonSchemaResolver _resolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaWriter.NativeFieldInfoPtr__resolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSchemaResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaWriter.NativeFieldInfoPtr__resolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C91 RID: 3217
		private static readonly IntPtr NativeFieldInfoPtr__writer;

		// Token: 0x04000C92 RID: 3218
		private static readonly IntPtr NativeFieldInfoPtr__resolver;

		// Token: 0x04000C93 RID: 3219
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_JsonWriter_JsonSchemaResolver_0;

		// Token: 0x04000C94 RID: 3220
		private static readonly IntPtr NativeMethodInfoPtr_ReferenceOrWriteSchema_Private_Void_JsonSchema_0;

		// Token: 0x04000C95 RID: 3221
		private static readonly IntPtr NativeMethodInfoPtr_WriteSchema_Public_Void_JsonSchema_0;

		// Token: 0x04000C96 RID: 3222
		private static readonly IntPtr NativeMethodInfoPtr_WriteSchemaDictionaryIfNotNull_Private_Void_JsonWriter_String_IDictionary_2_String_JsonSchema_0;

		// Token: 0x04000C97 RID: 3223
		private static readonly IntPtr NativeMethodInfoPtr_WriteItems_Private_Void_JsonSchema_0;

		// Token: 0x04000C98 RID: 3224
		private static readonly IntPtr NativeMethodInfoPtr_WriteType_Private_Void_String_JsonWriter_JsonSchemaType_0;

		// Token: 0x04000C99 RID: 3225
		private static readonly IntPtr NativeMethodInfoPtr_WritePropertyIfNotNull_Private_Void_JsonWriter_String_Object_0;

		// Token: 0x020001E1 RID: 481
		[ObfuscatedName("Newtonsoft.Json.Schema.JsonSchemaWriter+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001F05 RID: 7941 RVA: 0x0008E488 File Offset: 0x0008C688
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<JsonSchemaWriter.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonSchemaWriter>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSchemaWriter.__c>.NativeClassPtr);
				JsonSchemaWriter.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaWriter.__c>.NativeClassPtr, "<>9");
				JsonSchemaWriter.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaWriter.__c>.NativeClassPtr, "<>9__7_0");
				JsonSchemaWriter.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaWriter.__c>.NativeClassPtr, 100666071);
				JsonSchemaWriter.__c.NativeMethodInfoPtr__WriteType_b__7_0_Internal_Boolean_JsonSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaWriter.__c>.NativeClassPtr, 100666072);
			}

			// Token: 0x06001F06 RID: 7942 RVA: 0x0008E504 File Offset: 0x0008C704
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSchemaWriter.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaWriter.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F07 RID: 7943 RVA: 0x0008E540 File Offset: 0x0008C740
			[CallerCount(0)]
			public unsafe bool _WriteType_b__7_0(JsonSchemaType v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaWriter.__c.NativeMethodInfoPtr__WriteType_b__7_0_Internal_Boolean_JsonSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001F08 RID: 7944 RVA: 0x0000F4CB File Offset: 0x0000D6CB
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008B0 RID: 2224
			// (get) Token: 0x06001F09 RID: 7945 RVA: 0x0008E58C File Offset: 0x0008C78C
			// (set) Token: 0x06001F0A RID: 7946 RVA: 0x0000F4D4 File Offset: 0x0000D6D4
			public unsafe static JsonSchemaWriter.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(JsonSchemaWriter.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSchemaWriter.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(JsonSchemaWriter.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008B1 RID: 2225
			// (get) Token: 0x06001F0B RID: 7947 RVA: 0x0008E5B4 File Offset: 0x0008C7B4
			// (set) Token: 0x06001F0C RID: 7948 RVA: 0x0000F4E6 File Offset: 0x0000D6E6
			public unsafe static Func<JsonSchemaType, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(JsonSchemaWriter.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<JsonSchemaType, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(JsonSchemaWriter.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001691 RID: 5777
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001692 RID: 5778
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04001693 RID: 5779
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001694 RID: 5780
			private static readonly IntPtr NativeMethodInfoPtr__WriteType_b__7_0_Internal_Boolean_JsonSchemaType_0;
		}
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using JsonFx.Model;
using JsonFx.Serialization;

namespace JsonFx.Json
{
	// Token: 0x02000025 RID: 37
	public class JsonWriter : ModelWriter
	{
		// Token: 0x060001C1 RID: 449 RVA: 0x0000A390 File Offset: 0x00008590
		// Note: this type is marked as 'beforefieldinit'.
		static JsonWriter()
		{
			Il2CppClassPointerStore<JsonWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Json", "JsonWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr);
			JsonWriter.NativeFieldInfoPtr_ErrorUnexpectedToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, "ErrorUnexpectedToken");
			JsonWriter.NativeFieldInfoPtr_ContentTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, "ContentTypes");
			JsonWriter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100663538);
			JsonWriter.NativeMethodInfoPtr__ctor_Public_Void_DataWriterSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100663539);
			JsonWriter.NativeMethodInfoPtr__ctor_Public_Void_DataWriterSettings_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100663540);
			JsonWriter.NativeMethodInfoPtr_get_ContentType_Public_Virtual_get_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100663541);
			JsonWriter.NativeMethodInfoPtr_get_FileExtension_Public_Virtual_get_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100663542);
			JsonWriter.NativeMethodInfoPtr_GetFormatter_Protected_Virtual_ITextFormatter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100663543);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000A460 File Offset: 0x00008660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192555, XrefRangeEnd = 1192567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonWriter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000A49C File Offset: 0x0000869C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1192581, RefRangeEnd = 1192583, XrefRangeStart = 1192567, XrefRangeEnd = 1192581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonWriter(DataWriterSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr__ctor_Public_Void_DataWriterSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000A4E8 File Offset: 0x000086E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1192608, RefRangeEnd = 1192611, XrefRangeStart = 1192583, XrefRangeEnd = 1192608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonWriter(DataWriterSettings settings, [Optional] Il2CppStringArray contentTypes)
		{
			if (contentTypes == null)
			{
				contentTypes = new Il2CppStringArray(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contentTypes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr__ctor_Public_Void_DataWriterSettings_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x0000A554 File Offset: 0x00008754
		public unsafe override IEnumerable<string> ContentType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192611, XrefRangeEnd = 1192617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_get_ContentType_Public_Virtual_get_IEnumerable_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x0000A5A0 File Offset: 0x000087A0
		public unsafe override IEnumerable<string> FileExtension
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192617, XrefRangeEnd = 1192622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_get_FileExtension_Public_Virtual_get_IEnumerable_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000A5EC File Offset: 0x000087EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192622, XrefRangeEnd = 1192627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ITextFormatter GetFormatter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_GetFormatter_Protected_Virtual_ITextFormatter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITextFormatter>(intPtr3) : null;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00002B23 File Offset: 0x00000D23
		public JsonWriter(DataWriterSettings settings, params string[] contentTypes)
			: this(settings, new Il2CppStringArray(contentTypes))
		{
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00002B32 File Offset: 0x00000D32
		public JsonWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001CA RID: 458 RVA: 0x0000A638 File Offset: 0x00008838
		// (set) Token: 0x060001CB RID: 459 RVA: 0x00002B3B File Offset: 0x00000D3B
		public unsafe static string ErrorUnexpectedToken
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonWriter.NativeFieldInfoPtr_ErrorUnexpectedToken, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonWriter.NativeFieldInfoPtr_ErrorUnexpectedToken, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001CC RID: 460 RVA: 0x0000A658 File Offset: 0x00008858
		// (set) Token: 0x060001CD RID: 461 RVA: 0x00002B4D File Offset: 0x00000D4D
		public unsafe Il2CppStringArray ContentTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.NativeFieldInfoPtr_ContentTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.NativeFieldInfoPtr_ContentTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeFieldInfoPtr_ErrorUnexpectedToken;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeFieldInfoPtr_ContentTypes;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataWriterSettings_0;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataWriterSettings_Il2CppStringArray_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentType_Public_Virtual_get_IEnumerable_1_String_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_get_FileExtension_Public_Virtual_get_IEnumerable_1_String_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_GetFormatter_Protected_Virtual_ITextFormatter_0;

		// Token: 0x02000046 RID: 70
		public class JsonFormatter : Object
		{
			// Token: 0x060003C7 RID: 967 RVA: 0x000113EC File Offset: 0x0000F5EC
			// Note: this type is marked as 'beforefieldinit'.
			static JsonFormatter()
			{
				Il2CppClassPointerStore<JsonWriter.JsonFormatter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, "JsonFormatter");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonWriter.JsonFormatter>.NativeClassPtr);
				JsonWriter.JsonFormatter.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter.JsonFormatter>.NativeClassPtr, "Settings");
				JsonWriter.JsonFormatter.NativeFieldInfoPtr_encodeLessThan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter.JsonFormatter>.NativeClassPtr, "encodeLessThan");
				JsonWriter.JsonFormatter.NativeMethodInfoPtr__ctor_Public_Void_DataWriterSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter.JsonFormatter>.NativeClassPtr, 100663544);
				JsonWriter.JsonFormatter.NativeMethodInfoPtr_get_EncodeLessThan_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter.JsonFormatter>.NativeClassPtr, 100663545);
				JsonWriter.JsonFormatter.NativeMethodInfoPtr_set_EncodeLessThan_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter.JsonFormatter>.NativeClassPtr, 100663546);
				JsonWriter.JsonFormatter.NativeMethodInfoPtr_Format_Public_Virtual_Final_New_String_IEnumerable_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter.JsonFormatter>.NativeClassPtr, 100663547);
				JsonWriter.JsonFormatter.NativeMethodInfoPtr_Format_Public_Virtual_Final_New_Void_IEnumerable_1_Token_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter.JsonFormatter>.NativeClassPtr, 100663548);
				JsonWriter.JsonFormatter.NativeMethodInfoPtr_WritePrimitive_Protected_Virtual_New_Void_TextWriter_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter.JsonFormatter>.NativeClassPtr, 100663549);
				JsonWriter.JsonFormatter.NativeMethodInfoPtr_WritePropertyName_Protected_Virtual_New_Void_TextWriter_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter.JsonFormatter>.NativeClassPtr, 100663550);
				JsonWriter.JsonFormatter.NativeMethodInfoPtr_WriteNumber_Protected_Virtual_New_Void_TextWriter_Object_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter.JsonFormatter>.NativeClassPtr, 100663551);
				JsonWriter.JsonFormatter.NativeMethodInfoPtr_WriteNegativeInfinity_Protected_Virtual_New_Void_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter.JsonFormatter>.NativeClassPtr, 100663552);
				JsonWriter.JsonFormatter.NativeMethodInfoPtr_WritePositiveInfinity_Protected_Virtual_New_Void_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter.JsonFormatter>.NativeClassPtr, 100663553);
				JsonWriter.JsonFormatter.NativeMethodInfoPtr_WriteNaN_Protected_Virtual_New_Void_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter.JsonFormatter>.NativeClassPtr, 100663554);
				JsonWriter.JsonFormatter.NativeMethodInfoPtr_WriteString_Protected_Virtual_New_Void_TextWriter_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter.JsonFormatter>.NativeClassPtr, 100663555);
				JsonWriter.JsonFormatter.NativeMethodInfoPtr_WriteLine_Private_Void_TextWriter_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter.JsonFormatter>.NativeClassPtr, 100663556);
				JsonWriter.JsonFormatter.NativeMethodInfoPtr_FormatString_Protected_Virtual_New_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter.JsonFormatter>.NativeClassPtr, 100663557);
				JsonWriter.JsonFormatter.NativeMethodInfoPtr_FormatEnum_Private_String_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter.JsonFormatter>.NativeClassPtr, 100663558);
				JsonWriter.JsonFormatter.NativeMethodInfoPtr_GetFlagList_Private_Static_Il2CppStructArray_1_Enum_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter.JsonFormatter>.NativeClassPtr, 100663559);
				JsonWriter.JsonFormatter.NativeMethodInfoPtr_InvalidIEEE754_Protected_Virtual_New_Boolean_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter.JsonFormatter>.NativeClassPtr, 100663560);
			}

			// Token: 0x060003C8 RID: 968 RVA: 0x00011594 File Offset: 0x0000F794
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192175, XrefRangeEnd = 1192183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe JsonFormatter(DataWriterSettings settings)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonWriter.JsonFormatter>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.JsonFormatter.NativeMethodInfoPtr__ctor_Public_Void_DataWriterSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000115 RID: 277
			// (get) Token: 0x060003C9 RID: 969 RVA: 0x000115E0 File Offset: 0x0000F7E0
			// (set) Token: 0x060003CA RID: 970 RVA: 0x0001161C File Offset: 0x0000F81C
			public unsafe bool EncodeLessThan
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.JsonFormatter.NativeMethodInfoPtr_get_EncodeLessThan_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.JsonFormatter.NativeMethodInfoPtr_set_EncodeLessThan_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060003CB RID: 971 RVA: 0x0001165C File Offset: 0x0000F85C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192183, XrefRangeEnd = 1192194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual string Format(IEnumerable<Token> tokens)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.JsonFormatter.NativeMethodInfoPtr_Format_Public_Virtual_Final_New_String_IEnumerable_1_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060003CC RID: 972 RVA: 0x000116A4 File Offset: 0x0000F8A4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1192258, RefRangeEnd = 1192259, XrefRangeStart = 1192194, XrefRangeEnd = 1192258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Format(IEnumerable<Token> tokens, TextWriter writer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.JsonFormatter.NativeMethodInfoPtr_Format_Public_Virtual_Final_New_Void_IEnumerable_1_Token_TextWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003CD RID: 973 RVA: 0x000116F8 File Offset: 0x0000F8F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192259, XrefRangeEnd = 1192267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void WritePrimitive(TextWriter writer, Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.JsonFormatter.NativeMethodInfoPtr_WritePrimitive_Protected_Virtual_New_Void_TextWriter_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003CE RID: 974 RVA: 0x00011758 File Offset: 0x0000F958
			[CallerCount(0)]
			public unsafe virtual void WritePropertyName(TextWriter writer, string propertyName)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.JsonFormatter.NativeMethodInfoPtr_WritePropertyName_Protected_Virtual_New_Void_TextWriter_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003CF RID: 975 RVA: 0x000117B8 File Offset: 0x0000F9B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192267, XrefRangeEnd = 1192372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void WriteNumber(TextWriter writer, Object value, TypeCode typeCode)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref typeCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.JsonFormatter.NativeMethodInfoPtr_WriteNumber_Protected_Virtual_New_Void_TextWriter_Object_TypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003D0 RID: 976 RVA: 0x00011828 File Offset: 0x0000FA28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192372, XrefRangeEnd = 1192375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void WriteNegativeInfinity(TextWriter writer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.JsonFormatter.NativeMethodInfoPtr_WriteNegativeInfinity_Protected_Virtual_New_Void_TextWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003D1 RID: 977 RVA: 0x00011878 File Offset: 0x0000FA78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192375, XrefRangeEnd = 1192378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void WritePositiveInfinity(TextWriter writer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.JsonFormatter.NativeMethodInfoPtr_WritePositiveInfinity_Protected_Virtual_New_Void_TextWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003D2 RID: 978 RVA: 0x000118C8 File Offset: 0x0000FAC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192378, XrefRangeEnd = 1192381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void WriteNaN(TextWriter writer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.JsonFormatter.NativeMethodInfoPtr_WriteNaN_Protected_Virtual_New_Void_TextWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003D3 RID: 979 RVA: 0x00011918 File Offset: 0x0000FB18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192381, XrefRangeEnd = 1192406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void WriteString(TextWriter writer, string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.JsonFormatter.NativeMethodInfoPtr_WriteString_Protected_Virtual_New_Void_TextWriter_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003D4 RID: 980 RVA: 0x00011978 File Offset: 0x0000FB78
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1192406, RefRangeEnd = 1192412, XrefRangeStart = 1192406, XrefRangeEnd = 1192406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void WriteLine(TextWriter writer, int depth)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.JsonFormatter.NativeMethodInfoPtr_WriteLine_Private_Void_TextWriter_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003D5 RID: 981 RVA: 0x000119C8 File Offset: 0x0000FBC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192412, XrefRangeEnd = 1192417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual string FormatString(Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.JsonFormatter.NativeMethodInfoPtr_FormatString_Protected_Virtual_New_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060003D6 RID: 982 RVA: 0x00011A1C File Offset: 0x0000FC1C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1192454, RefRangeEnd = 1192455, XrefRangeStart = 1192417, XrefRangeEnd = 1192454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string FormatEnum(Enum value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.JsonFormatter.NativeMethodInfoPtr_FormatEnum_Private_String_Enum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060003D7 RID: 983 RVA: 0x00011A60 File Offset: 0x0000FC60
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1192526, RefRangeEnd = 1192527, XrefRangeStart = 1192455, XrefRangeEnd = 1192526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Il2CppStructArray<Enum> GetFlagList(Type enumType, Object value)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.JsonFormatter.NativeMethodInfoPtr_GetFlagList_Private_Static_Il2CppStructArray_1_Enum_Type_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Enum>>(intPtr3) : null;
			}

			// Token: 0x060003D8 RID: 984 RVA: 0x00011AB8 File Offset: 0x0000FCB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192527, XrefRangeEnd = 1192534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool InvalidIEEE754(Decimal value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.JsonFormatter.NativeMethodInfoPtr_InvalidIEEE754_Protected_Virtual_New_Boolean_Decimal_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060003D9 RID: 985 RVA: 0x00003876 File Offset: 0x00001A76
			public JsonFormatter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000113 RID: 275
			// (get) Token: 0x060003DA RID: 986 RVA: 0x00011B0C File Offset: 0x0000FD0C
			// (set) Token: 0x060003DB RID: 987 RVA: 0x0000387F File Offset: 0x00001A7F
			public unsafe DataWriterSettings Settings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.JsonFormatter.NativeFieldInfoPtr_Settings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataWriterSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.JsonFormatter.NativeFieldInfoPtr_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000114 RID: 276
			// (get) Token: 0x060003DC RID: 988 RVA: 0x00011B3C File Offset: 0x0000FD3C
			// (set) Token: 0x060003DD RID: 989 RVA: 0x0000389E File Offset: 0x00001A9E
			public unsafe bool encodeLessThan
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.JsonFormatter.NativeFieldInfoPtr_encodeLessThan);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.JsonFormatter.NativeFieldInfoPtr_encodeLessThan)) = value;
				}
			}

			// Token: 0x04000278 RID: 632
			private static readonly IntPtr NativeFieldInfoPtr_Settings;

			// Token: 0x04000279 RID: 633
			private static readonly IntPtr NativeFieldInfoPtr_encodeLessThan;

			// Token: 0x0400027A RID: 634
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataWriterSettings_0;

			// Token: 0x0400027B RID: 635
			private static readonly IntPtr NativeMethodInfoPtr_get_EncodeLessThan_Public_get_Boolean_0;

			// Token: 0x0400027C RID: 636
			private static readonly IntPtr NativeMethodInfoPtr_set_EncodeLessThan_Public_set_Void_Boolean_0;

			// Token: 0x0400027D RID: 637
			private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Virtual_Final_New_String_IEnumerable_1_Token_0;

			// Token: 0x0400027E RID: 638
			private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Virtual_Final_New_Void_IEnumerable_1_Token_TextWriter_0;

			// Token: 0x0400027F RID: 639
			private static readonly IntPtr NativeMethodInfoPtr_WritePrimitive_Protected_Virtual_New_Void_TextWriter_Object_0;

			// Token: 0x04000280 RID: 640
			private static readonly IntPtr NativeMethodInfoPtr_WritePropertyName_Protected_Virtual_New_Void_TextWriter_String_0;

			// Token: 0x04000281 RID: 641
			private static readonly IntPtr NativeMethodInfoPtr_WriteNumber_Protected_Virtual_New_Void_TextWriter_Object_TypeCode_0;

			// Token: 0x04000282 RID: 642
			private static readonly IntPtr NativeMethodInfoPtr_WriteNegativeInfinity_Protected_Virtual_New_Void_TextWriter_0;

			// Token: 0x04000283 RID: 643
			private static readonly IntPtr NativeMethodInfoPtr_WritePositiveInfinity_Protected_Virtual_New_Void_TextWriter_0;

			// Token: 0x04000284 RID: 644
			private static readonly IntPtr NativeMethodInfoPtr_WriteNaN_Protected_Virtual_New_Void_TextWriter_0;

			// Token: 0x04000285 RID: 645
			private static readonly IntPtr NativeMethodInfoPtr_WriteString_Protected_Virtual_New_Void_TextWriter_String_0;

			// Token: 0x04000286 RID: 646
			private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Private_Void_TextWriter_Int32_0;

			// Token: 0x04000287 RID: 647
			private static readonly IntPtr NativeMethodInfoPtr_FormatString_Protected_Virtual_New_String_Object_0;

			// Token: 0x04000288 RID: 648
			private static readonly IntPtr NativeMethodInfoPtr_FormatEnum_Private_String_Enum_0;

			// Token: 0x04000289 RID: 649
			private static readonly IntPtr NativeMethodInfoPtr_GetFlagList_Private_Static_Il2CppStructArray_1_Enum_Type_Object_0;

			// Token: 0x0400028A RID: 650
			private static readonly IntPtr NativeMethodInfoPtr_InvalidIEEE754_Protected_Virtual_New_Boolean_Decimal_0;
		}

		// Token: 0x02000047 RID: 71
		[ObfuscatedName("JsonFx.Json.JsonWriter+<get_ContentType>d__7")]
		public sealed class _get_ContentType_d__7 : Object
		{
			// Token: 0x060003DE RID: 990 RVA: 0x00011B64 File Offset: 0x0000FD64
			// Note: this type is marked as 'beforefieldinit'.
			static _get_ContentType_d__7()
			{
				Il2CppClassPointerStore<JsonWriter._get_ContentType_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, "<get_ContentType>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonWriter._get_ContentType_d__7>.NativeClassPtr);
				JsonWriter._get_ContentType_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._get_ContentType_d__7>.NativeClassPtr, "<>1__state");
				JsonWriter._get_ContentType_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._get_ContentType_d__7>.NativeClassPtr, "<>2__current");
				JsonWriter._get_ContentType_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._get_ContentType_d__7>.NativeClassPtr, "<>l__initialThreadId");
				JsonWriter._get_ContentType_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._get_ContentType_d__7>.NativeClassPtr, "<>4__this");
				JsonWriter._get_ContentType_d__7.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._get_ContentType_d__7>.NativeClassPtr, "<>7__wrap1");
				JsonWriter._get_ContentType_d__7.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._get_ContentType_d__7>.NativeClassPtr, "<>7__wrap2");
				JsonWriter._get_ContentType_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter._get_ContentType_d__7>.NativeClassPtr, 100663561);
				JsonWriter._get_ContentType_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter._get_ContentType_d__7>.NativeClassPtr, 100663562);
				JsonWriter._get_ContentType_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter._get_ContentType_d__7>.NativeClassPtr, 100663563);
				JsonWriter._get_ContentType_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter._get_ContentType_d__7>.NativeClassPtr, 100663564);
				JsonWriter._get_ContentType_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter._get_ContentType_d__7>.NativeClassPtr, 100663565);
				JsonWriter._get_ContentType_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter._get_ContentType_d__7>.NativeClassPtr, 100663566);
				JsonWriter._get_ContentType_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter._get_ContentType_d__7>.NativeClassPtr, 100663567);
				JsonWriter._get_ContentType_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter._get_ContentType_d__7>.NativeClassPtr, 100663568);
			}

			// Token: 0x060003DF RID: 991 RVA: 0x00011CA8 File Offset: 0x0000FEA8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_ContentType_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonWriter._get_ContentType_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter._get_ContentType_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003E0 RID: 992 RVA: 0x00011CF0 File Offset: 0x0000FEF0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter._get_ContentType_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003E1 RID: 993 RVA: 0x00011D24 File Offset: 0x0000FF24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192534, XrefRangeEnd = 1192537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter._get_ContentType_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700011C RID: 284
			// (get) Token: 0x060003E2 RID: 994 RVA: 0x00011D60 File Offset: 0x0000FF60
			public unsafe string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter._get_ContentType_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060003E3 RID: 995 RVA: 0x00011D98 File Offset: 0x0000FF98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192537, XrefRangeEnd = 1192542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter._get_ContentType_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700011D RID: 285
			// (get) Token: 0x060003E4 RID: 996 RVA: 0x00011DCC File Offset: 0x0000FFCC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter._get_ContentType_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060003E5 RID: 997 RVA: 0x00011E0C File Offset: 0x0001000C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192542, XrefRangeEnd = 1192544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<string> System_Collections_Generic_IEnumerable_System_String__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter._get_ContentType_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<string>>(intPtr3) : null;
			}

			// Token: 0x060003E6 RID: 998 RVA: 0x00011E4C File Offset: 0x0001004C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter._get_ContentType_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060003E7 RID: 999 RVA: 0x000038B9 File Offset: 0x00001AB9
			public _get_ContentType_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000116 RID: 278
			// (get) Token: 0x060003E8 RID: 1000 RVA: 0x00011E8C File Offset: 0x0001008C
			// (set) Token: 0x060003E9 RID: 1001 RVA: 0x000038C2 File Offset: 0x00001AC2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._get_ContentType_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._get_ContentType_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000117 RID: 279
			// (get) Token: 0x060003EA RID: 1002 RVA: 0x00011EB4 File Offset: 0x000100B4
			// (set) Token: 0x060003EB RID: 1003 RVA: 0x000038DD File Offset: 0x00001ADD
			public unsafe string __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._get_ContentType_d__7.NativeFieldInfoPtr___2__current);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._get_ContentType_d__7.NativeFieldInfoPtr___2__current), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000118 RID: 280
			// (get) Token: 0x060003EC RID: 1004 RVA: 0x00011EDC File Offset: 0x000100DC
			// (set) Token: 0x060003ED RID: 1005 RVA: 0x000038FC File Offset: 0x00001AFC
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._get_ContentType_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._get_ContentType_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000119 RID: 281
			// (get) Token: 0x060003EE RID: 1006 RVA: 0x00011F04 File Offset: 0x00010104
			// (set) Token: 0x060003EF RID: 1007 RVA: 0x00003917 File Offset: 0x00001B17
			public unsafe JsonWriter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._get_ContentType_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonWriter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._get_ContentType_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700011A RID: 282
			// (get) Token: 0x060003F0 RID: 1008 RVA: 0x00011F34 File Offset: 0x00010134
			// (set) Token: 0x060003F1 RID: 1009 RVA: 0x00003936 File Offset: 0x00001B36
			public unsafe Il2CppStringArray __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._get_ContentType_d__7.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._get_ContentType_d__7.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700011B RID: 283
			// (get) Token: 0x060003F2 RID: 1010 RVA: 0x00011F64 File Offset: 0x00010164
			// (set) Token: 0x060003F3 RID: 1011 RVA: 0x00003955 File Offset: 0x00001B55
			public unsafe int __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._get_ContentType_d__7.NativeFieldInfoPtr___7__wrap2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._get_ContentType_d__7.NativeFieldInfoPtr___7__wrap2)) = value;
				}
			}

			// Token: 0x0400028B RID: 651
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400028C RID: 652
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400028D RID: 653
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400028E RID: 654
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400028F RID: 655
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04000290 RID: 656
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04000291 RID: 657
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000292 RID: 658
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000293 RID: 659
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000294 RID: 660
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0;

			// Token: 0x04000295 RID: 661
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000296 RID: 662
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000297 RID: 663
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0;

			// Token: 0x04000298 RID: 664
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000048 RID: 72
		[ObfuscatedName("JsonFx.Json.JsonWriter+<get_FileExtension>d__9")]
		public sealed class _get_FileExtension_d__9 : Object
		{
			// Token: 0x060003F4 RID: 1012 RVA: 0x00011F8C File Offset: 0x0001018C
			// Note: this type is marked as 'beforefieldinit'.
			static _get_FileExtension_d__9()
			{
				Il2CppClassPointerStore<JsonWriter._get_FileExtension_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, "<get_FileExtension>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonWriter._get_FileExtension_d__9>.NativeClassPtr);
				JsonWriter._get_FileExtension_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._get_FileExtension_d__9>.NativeClassPtr, "<>1__state");
				JsonWriter._get_FileExtension_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._get_FileExtension_d__9>.NativeClassPtr, "<>2__current");
				JsonWriter._get_FileExtension_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._get_FileExtension_d__9>.NativeClassPtr, "<>l__initialThreadId");
				JsonWriter._get_FileExtension_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter._get_FileExtension_d__9>.NativeClassPtr, 100663569);
				JsonWriter._get_FileExtension_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter._get_FileExtension_d__9>.NativeClassPtr, 100663570);
				JsonWriter._get_FileExtension_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter._get_FileExtension_d__9>.NativeClassPtr, 100663571);
				JsonWriter._get_FileExtension_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter._get_FileExtension_d__9>.NativeClassPtr, 100663572);
				JsonWriter._get_FileExtension_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter._get_FileExtension_d__9>.NativeClassPtr, 100663573);
				JsonWriter._get_FileExtension_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter._get_FileExtension_d__9>.NativeClassPtr, 100663574);
				JsonWriter._get_FileExtension_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter._get_FileExtension_d__9>.NativeClassPtr, 100663575);
				JsonWriter._get_FileExtension_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter._get_FileExtension_d__9>.NativeClassPtr, 100663576);
			}

			// Token: 0x060003F5 RID: 1013 RVA: 0x00012094 File Offset: 0x00010294
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_FileExtension_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonWriter._get_FileExtension_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter._get_FileExtension_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003F6 RID: 1014 RVA: 0x000120DC File Offset: 0x000102DC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter._get_FileExtension_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003F7 RID: 1015 RVA: 0x00012110 File Offset: 0x00010310
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192544, XrefRangeEnd = 1192548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter._get_FileExtension_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000121 RID: 289
			// (get) Token: 0x060003F8 RID: 1016 RVA: 0x0001214C File Offset: 0x0001034C
			public unsafe string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter._get_FileExtension_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060003F9 RID: 1017 RVA: 0x00012184 File Offset: 0x00010384
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192548, XrefRangeEnd = 1192553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter._get_FileExtension_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000122 RID: 290
			// (get) Token: 0x060003FA RID: 1018 RVA: 0x000121B8 File Offset: 0x000103B8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter._get_FileExtension_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060003FB RID: 1019 RVA: 0x000121F8 File Offset: 0x000103F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192553, XrefRangeEnd = 1192555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<string> System_Collections_Generic_IEnumerable_System_String__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter._get_FileExtension_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<string>>(intPtr3) : null;
			}

			// Token: 0x060003FC RID: 1020 RVA: 0x00012238 File Offset: 0x00010438
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter._get_FileExtension_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060003FD RID: 1021 RVA: 0x00003970 File Offset: 0x00001B70
			public _get_FileExtension_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700011E RID: 286
			// (get) Token: 0x060003FE RID: 1022 RVA: 0x00012278 File Offset: 0x00010478
			// (set) Token: 0x060003FF RID: 1023 RVA: 0x00003979 File Offset: 0x00001B79
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._get_FileExtension_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._get_FileExtension_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700011F RID: 287
			// (get) Token: 0x06000400 RID: 1024 RVA: 0x000122A0 File Offset: 0x000104A0
			// (set) Token: 0x06000401 RID: 1025 RVA: 0x00003994 File Offset: 0x00001B94
			public unsafe string __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._get_FileExtension_d__9.NativeFieldInfoPtr___2__current);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._get_FileExtension_d__9.NativeFieldInfoPtr___2__current), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000120 RID: 288
			// (get) Token: 0x06000402 RID: 1026 RVA: 0x000122C8 File Offset: 0x000104C8
			// (set) Token: 0x06000403 RID: 1027 RVA: 0x000039B3 File Offset: 0x00001BB3
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._get_FileExtension_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._get_FileExtension_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x04000299 RID: 665
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400029A RID: 666
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400029B RID: 667
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400029C RID: 668
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400029D RID: 669
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400029E RID: 670
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400029F RID: 671
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0;

			// Token: 0x040002A0 RID: 672
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002A1 RID: 673
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040002A2 RID: 674
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0;

			// Token: 0x040002A3 RID: 675
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

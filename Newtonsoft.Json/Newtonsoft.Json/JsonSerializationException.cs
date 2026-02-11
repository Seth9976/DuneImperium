using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.Serialization;

namespace Newtonsoft.Json
{
	// Token: 0x0200002A RID: 42
	[Serializable]
	public class JsonSerializationException : JsonException
	{
		// Token: 0x0600020D RID: 525 RVA: 0x0001A444 File Offset: 0x00018644
		// Note: this type is marked as 'beforefieldinit'.
		static JsonSerializationException()
		{
			Il2CppClassPointerStore<JsonSerializationException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json", "JsonSerializationException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSerializationException>.NativeClassPtr);
			JsonSerializationException.NativeFieldInfoPtr__LineNumber_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializationException>.NativeClassPtr, "<LineNumber>k__BackingField");
			JsonSerializationException.NativeFieldInfoPtr__LinePosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializationException>.NativeClassPtr, "<LinePosition>k__BackingField");
			JsonSerializationException.NativeFieldInfoPtr__Path_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializationException>.NativeClassPtr, "<Path>k__BackingField");
			JsonSerializationException.NativeMethodInfoPtr_get_LineNumber_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializationException>.NativeClassPtr, 100663615);
			JsonSerializationException.NativeMethodInfoPtr_get_LinePosition_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializationException>.NativeClassPtr, 100663616);
			JsonSerializationException.NativeMethodInfoPtr_get_Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializationException>.NativeClassPtr, 100663617);
			JsonSerializationException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializationException>.NativeClassPtr, 100663618);
			JsonSerializationException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializationException>.NativeClassPtr, 100663619);
			JsonSerializationException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializationException>.NativeClassPtr, 100663620);
			JsonSerializationException.NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializationException>.NativeClassPtr, 100663621);
			JsonSerializationException.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_Int32_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializationException>.NativeClassPtr, 100663622);
			JsonSerializationException.NativeMethodInfoPtr_Create_Internal_Static_JsonSerializationException_JsonReader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializationException>.NativeClassPtr, 100663623);
			JsonSerializationException.NativeMethodInfoPtr_Create_Internal_Static_JsonSerializationException_JsonReader_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializationException>.NativeClassPtr, 100663624);
			JsonSerializationException.NativeMethodInfoPtr_Create_Internal_Static_JsonSerializationException_IJsonLineInfo_String_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializationException>.NativeClassPtr, 100663625);
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600020E RID: 526 RVA: 0x0001A58C File Offset: 0x0001878C
		public unsafe int LineNumber
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 311826, RefRangeEnd = 311839, XrefRangeStart = 311826, XrefRangeEnd = 311839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializationException.NativeMethodInfoPtr_get_LineNumber_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600020F RID: 527 RVA: 0x0001A5C8 File Offset: 0x000187C8
		public unsafe int LinePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializationException.NativeMethodInfoPtr_get_LinePosition_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000210 RID: 528 RVA: 0x0001A604 File Offset: 0x00018804
		public unsafe string Path
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializationException.NativeMethodInfoPtr_get_Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0001A63C File Offset: 0x0001883C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 727946, RefRangeEnd = 727948, XrefRangeStart = 727946, XrefRangeEnd = 727948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSerializationException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSerializationException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializationException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0001A678 File Offset: 0x00018878
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 727952, RefRangeEnd = 727964, XrefRangeStart = 727952, XrefRangeEnd = 727964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSerializationException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSerializationException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializationException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0001A6C4 File Offset: 0x000188C4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 727968, RefRangeEnd = 727974, XrefRangeStart = 727968, XrefRangeEnd = 727974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSerializationException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSerializationException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializationException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0001A724 File Offset: 0x00018924
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 727978, RefRangeEnd = 727980, XrefRangeStart = 727978, XrefRangeEnd = 727980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSerializationException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSerializationException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializationException.NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0001A788 File Offset: 0x00018988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSerializationException(string message, string path, int lineNumber, int linePosition, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSerializationException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializationException.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_Int32_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0001A814 File Offset: 0x00018A14
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 729279, RefRangeEnd = 729288, XrefRangeStart = 729256, XrefRangeEnd = 729279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JsonSerializationException Create(JsonReader reader, string message)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializationException.NativeMethodInfoPtr_Create_Internal_Static_JsonSerializationException_JsonReader_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSerializationException>(intPtr3) : null;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0001A86C File Offset: 0x00018A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729288, XrefRangeEnd = 729311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JsonSerializationException Create(JsonReader reader, string message, Exception ex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializationException.NativeMethodInfoPtr_Create_Internal_Static_JsonSerializationException_JsonReader_String_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSerializationException>(intPtr3) : null;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0001A8D4 File Offset: 0x00018AD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 729331, RefRangeEnd = 729332, XrefRangeStart = 729311, XrefRangeEnd = 729331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JsonSerializationException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lineInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializationException.NativeMethodInfoPtr_Create_Internal_Static_JsonSerializationException_IJsonLineInfo_String_String_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSerializationException>(intPtr3) : null;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002D41 File Offset: 0x00000F41
		public JsonSerializationException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600021A RID: 538 RVA: 0x0001A950 File Offset: 0x00018B50
		// (set) Token: 0x0600021B RID: 539 RVA: 0x00002D4A File Offset: 0x00000F4A
		public unsafe int _LineNumber_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializationException.NativeFieldInfoPtr__LineNumber_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializationException.NativeFieldInfoPtr__LineNumber_k__BackingField)) = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600021C RID: 540 RVA: 0x0001A978 File Offset: 0x00018B78
		// (set) Token: 0x0600021D RID: 541 RVA: 0x00002D65 File Offset: 0x00000F65
		public unsafe int _LinePosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializationException.NativeFieldInfoPtr__LinePosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializationException.NativeFieldInfoPtr__LinePosition_k__BackingField)) = value;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600021E RID: 542 RVA: 0x0001A9A0 File Offset: 0x00018BA0
		// (set) Token: 0x0600021F RID: 543 RVA: 0x00002D80 File Offset: 0x00000F80
		public unsafe string _Path_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializationException.NativeFieldInfoPtr__Path_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializationException.NativeFieldInfoPtr__Path_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeFieldInfoPtr__LineNumber_k__BackingField;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeFieldInfoPtr__LinePosition_k__BackingField;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeFieldInfoPtr__Path_k__BackingField;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNumber_Public_get_Int32_0;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePosition_Public_get_Int32_0;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr_get_Path_Public_get_String_0;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_Int32_Exception_0;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_JsonSerializationException_JsonReader_String_0;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_JsonSerializationException_JsonReader_String_Exception_0;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_JsonSerializationException_IJsonLineInfo_String_String_Exception_0;
	}
}

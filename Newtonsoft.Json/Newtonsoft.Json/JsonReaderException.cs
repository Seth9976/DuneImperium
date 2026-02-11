using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.Serialization;

namespace Newtonsoft.Json
{
	// Token: 0x02000028 RID: 40
	[Serializable]
	public class JsonReaderException : JsonException
	{
		// Token: 0x060001F7 RID: 503 RVA: 0x00019E84 File Offset: 0x00018084
		// Note: this type is marked as 'beforefieldinit'.
		static JsonReaderException()
		{
			Il2CppClassPointerStore<JsonReaderException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json", "JsonReaderException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonReaderException>.NativeClassPtr);
			JsonReaderException.NativeFieldInfoPtr__LineNumber_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReaderException>.NativeClassPtr, "<LineNumber>k__BackingField");
			JsonReaderException.NativeFieldInfoPtr__LinePosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReaderException>.NativeClassPtr, "<LinePosition>k__BackingField");
			JsonReaderException.NativeFieldInfoPtr__Path_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReaderException>.NativeClassPtr, "<Path>k__BackingField");
			JsonReaderException.NativeMethodInfoPtr_get_LineNumber_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReaderException>.NativeClassPtr, 100663603);
			JsonReaderException.NativeMethodInfoPtr_get_LinePosition_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReaderException>.NativeClassPtr, 100663604);
			JsonReaderException.NativeMethodInfoPtr_get_Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReaderException>.NativeClassPtr, 100663605);
			JsonReaderException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReaderException>.NativeClassPtr, 100663606);
			JsonReaderException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReaderException>.NativeClassPtr, 100663607);
			JsonReaderException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReaderException>.NativeClassPtr, 100663608);
			JsonReaderException.NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReaderException>.NativeClassPtr, 100663609);
			JsonReaderException.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_Int32_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReaderException>.NativeClassPtr, 100663610);
			JsonReaderException.NativeMethodInfoPtr_Create_Internal_Static_JsonReaderException_JsonReader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReaderException>.NativeClassPtr, 100663611);
			JsonReaderException.NativeMethodInfoPtr_Create_Internal_Static_JsonReaderException_JsonReader_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReaderException>.NativeClassPtr, 100663612);
			JsonReaderException.NativeMethodInfoPtr_Create_Internal_Static_JsonReaderException_IJsonLineInfo_String_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReaderException>.NativeClassPtr, 100663613);
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00019FCC File Offset: 0x000181CC
		public unsafe int LineNumber
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 311826, RefRangeEnd = 311839, XrefRangeStart = 311826, XrefRangeEnd = 311839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReaderException.NativeMethodInfoPtr_get_LineNumber_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x0001A008 File Offset: 0x00018208
		public unsafe int LinePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReaderException.NativeMethodInfoPtr_get_LinePosition_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001FA RID: 506 RVA: 0x0001A044 File Offset: 0x00018244
		public unsafe string Path
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReaderException.NativeMethodInfoPtr_get_Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0001A07C File Offset: 0x0001827C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 727946, RefRangeEnd = 727948, XrefRangeStart = 727946, XrefRangeEnd = 727948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonReaderException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonReaderException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReaderException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0001A0B8 File Offset: 0x000182B8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 727952, RefRangeEnd = 727964, XrefRangeStart = 727952, XrefRangeEnd = 727964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonReaderException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonReaderException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReaderException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0001A104 File Offset: 0x00018304
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 727968, RefRangeEnd = 727974, XrefRangeStart = 727968, XrefRangeEnd = 727974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonReaderException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonReaderException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReaderException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0001A164 File Offset: 0x00018364
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 727978, RefRangeEnd = 727980, XrefRangeStart = 727978, XrefRangeEnd = 727980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonReaderException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonReaderException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReaderException.NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0001A1C8 File Offset: 0x000183C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729203, XrefRangeEnd = 729208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonReaderException(string message, string path, int lineNumber, int linePosition, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonReaderException>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReaderException.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_Int32_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0001A254 File Offset: 0x00018454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729208, XrefRangeEnd = 729209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JsonReaderException Create(JsonReader reader, string message)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReaderException.NativeMethodInfoPtr_Create_Internal_Static_JsonReaderException_JsonReader_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonReaderException>(intPtr3) : null;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0001A2AC File Offset: 0x000184AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 729232, RefRangeEnd = 729236, XrefRangeStart = 729209, XrefRangeEnd = 729232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JsonReaderException Create(JsonReader reader, string message, Exception ex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReaderException.NativeMethodInfoPtr_Create_Internal_Static_JsonReaderException_JsonReader_String_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonReaderException>(intPtr3) : null;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0001A314 File Offset: 0x00018514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729236, XrefRangeEnd = 729256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JsonReaderException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReaderException.NativeMethodInfoPtr_Create_Internal_Static_JsonReaderException_IJsonLineInfo_String_String_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonReaderException>(intPtr3) : null;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002CA1 File Offset: 0x00000EA1
		public JsonReaderException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000204 RID: 516 RVA: 0x0001A390 File Offset: 0x00018590
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00002CAA File Offset: 0x00000EAA
		public unsafe int _LineNumber_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReaderException.NativeFieldInfoPtr__LineNumber_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReaderException.NativeFieldInfoPtr__LineNumber_k__BackingField)) = value;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000206 RID: 518 RVA: 0x0001A3B8 File Offset: 0x000185B8
		// (set) Token: 0x06000207 RID: 519 RVA: 0x00002CC5 File Offset: 0x00000EC5
		public unsafe int _LinePosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReaderException.NativeFieldInfoPtr__LinePosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReaderException.NativeFieldInfoPtr__LinePosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000208 RID: 520 RVA: 0x0001A3E0 File Offset: 0x000185E0
		// (set) Token: 0x06000209 RID: 521 RVA: 0x00002CE0 File Offset: 0x00000EE0
		public unsafe string _Path_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReaderException.NativeFieldInfoPtr__Path_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReaderException.NativeFieldInfoPtr__Path_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeFieldInfoPtr__LineNumber_k__BackingField;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeFieldInfoPtr__LinePosition_k__BackingField;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeFieldInfoPtr__Path_k__BackingField;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNumber_Public_get_Int32_0;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePosition_Public_get_Int32_0;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr_get_Path_Public_get_String_0;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_Int32_Exception_0;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_JsonReaderException_JsonReader_String_0;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_JsonReaderException_JsonReader_String_Exception_0;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_JsonReaderException_IJsonLineInfo_String_String_Exception_0;
	}
}

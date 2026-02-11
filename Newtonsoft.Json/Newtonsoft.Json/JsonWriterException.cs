using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.Serialization;

namespace Newtonsoft.Json
{
	// Token: 0x02000033 RID: 51
	[Serializable]
	public class JsonWriterException : JsonException
	{
		// Token: 0x06000608 RID: 1544 RVA: 0x0002F0FC File Offset: 0x0002D2FC
		// Note: this type is marked as 'beforefieldinit'.
		static JsonWriterException()
		{
			Il2CppClassPointerStore<JsonWriterException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json", "JsonWriterException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonWriterException>.NativeClassPtr);
			JsonWriterException.NativeFieldInfoPtr__Path_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriterException>.NativeClassPtr, "<Path>k__BackingField");
			JsonWriterException.NativeMethodInfoPtr_get_Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriterException>.NativeClassPtr, 100664517);
			JsonWriterException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriterException>.NativeClassPtr, 100664518);
			JsonWriterException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriterException>.NativeClassPtr, 100664519);
			JsonWriterException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriterException>.NativeClassPtr, 100664520);
			JsonWriterException.NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriterException>.NativeClassPtr, 100664521);
			JsonWriterException.NativeMethodInfoPtr__ctor_Public_Void_String_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriterException>.NativeClassPtr, 100664522);
			JsonWriterException.NativeMethodInfoPtr_Create_Internal_Static_JsonWriterException_JsonWriter_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriterException>.NativeClassPtr, 100664523);
			JsonWriterException.NativeMethodInfoPtr_Create_Internal_Static_JsonWriterException_String_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriterException>.NativeClassPtr, 100664524);
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x0002F1E0 File Offset: 0x0002D3E0
		public unsafe string Path
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriterException.NativeMethodInfoPtr_get_Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x0002F218 File Offset: 0x0002D418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738900, XrefRangeEnd = 738901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonWriterException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonWriterException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriterException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0002F254 File Offset: 0x0002D454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738901, XrefRangeEnd = 738902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonWriterException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonWriterException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriterException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x0002F2A0 File Offset: 0x0002D4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738902, XrefRangeEnd = 738903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonWriterException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonWriterException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriterException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0002F300 File Offset: 0x0002D500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738903, XrefRangeEnd = 738904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonWriterException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonWriterException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriterException.NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x0002F364 File Offset: 0x0002D564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738904, XrefRangeEnd = 738906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonWriterException(string message, string path, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonWriterException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriterException.NativeMethodInfoPtr__ctor_Public_Void_String_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0002F3D4 File Offset: 0x0002D5D4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 738916, RefRangeEnd = 738928, XrefRangeStart = 738906, XrefRangeEnd = 738916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JsonWriterException Create(JsonWriter writer, string message, Exception ex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriterException.NativeMethodInfoPtr_Create_Internal_Static_JsonWriterException_JsonWriter_String_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonWriterException>(intPtr3) : null;
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0002F43C File Offset: 0x0002D63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738928, XrefRangeEnd = 738937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JsonWriterException Create(string path, string message, Exception ex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriterException.NativeMethodInfoPtr_Create_Internal_Static_JsonWriterException_String_String_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonWriterException>(intPtr3) : null;
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00003D6C File Offset: 0x00001F6C
		public JsonWriterException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x0002F4A4 File Offset: 0x0002D6A4
		// (set) Token: 0x06000613 RID: 1555 RVA: 0x00003D75 File Offset: 0x00001F75
		public unsafe string _Path_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriterException.NativeFieldInfoPtr__Path_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriterException.NativeFieldInfoPtr__Path_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000524 RID: 1316
		private static readonly IntPtr NativeFieldInfoPtr__Path_k__BackingField;

		// Token: 0x04000525 RID: 1317
		private static readonly IntPtr NativeMethodInfoPtr_get_Path_Public_get_String_0;

		// Token: 0x04000526 RID: 1318
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000527 RID: 1319
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000528 RID: 1320
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x04000529 RID: 1321
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400052A RID: 1322
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Exception_0;

		// Token: 0x0400052B RID: 1323
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_JsonWriterException_JsonWriter_String_Exception_0;

		// Token: 0x0400052C RID: 1324
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_JsonWriterException_String_String_Exception_0;
	}
}

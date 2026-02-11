using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.Serialization;

namespace Newtonsoft.Json
{
	// Token: 0x0200001F RID: 31
	[Serializable]
	public class JsonException : Exception
	{
		// Token: 0x060000FF RID: 255 RVA: 0x00015F24 File Offset: 0x00014124
		// Note: this type is marked as 'beforefieldinit'.
		static JsonException()
		{
			Il2CppClassPointerStore<JsonException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json", "JsonException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonException>.NativeClassPtr);
			JsonException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonException>.NativeClassPtr, 100663445);
			JsonException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonException>.NativeClassPtr, 100663446);
			JsonException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonException>.NativeClassPtr, 100663447);
			JsonException.NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonException>.NativeClassPtr, 100663448);
			JsonException.NativeMethodInfoPtr_Create_Internal_Static_JsonException_IJsonLineInfo_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonException>.NativeClassPtr, 100663449);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00015FB8 File Offset: 0x000141B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 727946, RefRangeEnd = 727948, XrefRangeStart = 727942, XrefRangeEnd = 727946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00015FF4 File Offset: 0x000141F4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 727952, RefRangeEnd = 727964, XrefRangeStart = 727948, XrefRangeEnd = 727952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00016040 File Offset: 0x00014240
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 727968, RefRangeEnd = 727974, XrefRangeStart = 727964, XrefRangeEnd = 727968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000160A0 File Offset: 0x000142A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 727978, RefRangeEnd = 727980, XrefRangeStart = 727974, XrefRangeEnd = 727978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonException.NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00016104 File Offset: 0x00014304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727980, XrefRangeEnd = 727991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JsonException Create(IJsonLineInfo lineInfo, string path, string message)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lineInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonException.NativeMethodInfoPtr_Create_Internal_Static_JsonException_IJsonLineInfo_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonException>(intPtr3) : null;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002651 File Offset: 0x00000851
		public JsonException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_JsonException_IJsonLineInfo_String_String_0;
	}
}

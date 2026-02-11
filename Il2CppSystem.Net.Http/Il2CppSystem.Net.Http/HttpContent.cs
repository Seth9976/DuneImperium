using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Http.Headers;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Text;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net.Http
{
	// Token: 0x0200000D RID: 13
	public class HttpContent : Object
	{
		// Token: 0x060000AA RID: 170 RVA: 0x00006AD0 File Offset: 0x00004CD0
		// Note: this type is marked as 'beforefieldinit'.
		static HttpContent()
		{
			Il2CppClassPointerStore<HttpContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http", "HttpContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpContent>.NativeClassPtr);
			HttpContent.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpContent>.NativeClassPtr, "buffer");
			HttpContent.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpContent>.NativeClassPtr, "stream");
			HttpContent.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpContent>.NativeClassPtr, "disposed");
			HttpContent.NativeFieldInfoPtr_headers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpContent>.NativeClassPtr, "headers");
			HttpContent.NativeMethodInfoPtr_get_Headers_Public_get_HttpContentHeaders_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContent>.NativeClassPtr, 100663385);
			HttpContent.NativeMethodInfoPtr_get_LoadedBufferLength_Internal_get_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContent>.NativeClassPtr, 100663386);
			HttpContent.NativeMethodInfoPtr_CopyToAsync_Public_Task_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContent>.NativeClassPtr, 100663387);
			HttpContent.NativeMethodInfoPtr_CopyToAsync_Public_Task_Stream_TransportContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContent>.NativeClassPtr, 100663388);
			HttpContent.NativeMethodInfoPtr_CreateContentReadStreamAsync_Protected_Virtual_New_Task_1_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContent>.NativeClassPtr, 100663389);
			HttpContent.NativeMethodInfoPtr_CreateFixedMemoryStream_Private_Static_FixedMemoryStream_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContent>.NativeClassPtr, 100663390);
			HttpContent.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContent>.NativeClassPtr, 100663391);
			HttpContent.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContent>.NativeClassPtr, 100663392);
			HttpContent.NativeMethodInfoPtr_LoadIntoBufferAsync_Public_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContent>.NativeClassPtr, 100663393);
			HttpContent.NativeMethodInfoPtr_LoadIntoBufferAsync_Public_Task_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContent>.NativeClassPtr, 100663394);
			HttpContent.NativeMethodInfoPtr_ReadAsStreamAsync_Public_Task_1_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContent>.NativeClassPtr, 100663395);
			HttpContent.NativeMethodInfoPtr_ReadAsByteArrayAsync_Public_Task_1_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContent>.NativeClassPtr, 100663396);
			HttpContent.NativeMethodInfoPtr_ReadAsStringAsync_Public_Task_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContent>.NativeClassPtr, 100663397);
			HttpContent.NativeMethodInfoPtr_GetEncodingFromBuffer_Private_Static_Encoding_Il2CppStructArray_1_Byte_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContent>.NativeClassPtr, 100663398);
			HttpContent.NativeMethodInfoPtr_StartsWith_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContent>.NativeClassPtr, 100663399);
			HttpContent.NativeMethodInfoPtr_SerializeToStreamAsync_internal_Internal_Task_Stream_TransportContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContent>.NativeClassPtr, 100663400);
			HttpContent.NativeMethodInfoPtr_SerializeToStreamAsync_Protected_Abstract_Virtual_New_Task_Stream_TransportContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContent>.NativeClassPtr, 100663401);
			HttpContent.NativeMethodInfoPtr_TryComputeLength_FamOrAssem_Abstract_Virtual_New_Boolean_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContent>.NativeClassPtr, 100663402);
			HttpContent.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContent>.NativeClassPtr, 100663403);
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00006CCC File Offset: 0x00004ECC
		public unsafe HttpContentHeaders Headers
		{
			[CallerCount(31)]
			[CachedScanResults(RefRangeStart = 1171571, RefRangeEnd = 1171602, XrefRangeStart = 1171562, XrefRangeEnd = 1171571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContent.NativeMethodInfoPtr_get_Headers_Public_get_HttpContentHeaders_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpContentHeaders>(intPtr3) : null;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00006D0C File Offset: 0x00004F0C
		public unsafe Nullable<long> LoadedBufferLength
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171602, XrefRangeEnd = 1171603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContent.NativeMethodInfoPtr_get_LoadedBufferLength_Internal_get_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<long>(intPtr);
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00006D44 File Offset: 0x00004F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171603, XrefRangeEnd = 1171611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task CopyToAsync(Stream stream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContent.NativeMethodInfoPtr_CopyToAsync_Public_Task_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00006D94 File Offset: 0x00004F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171611, XrefRangeEnd = 1171619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task CopyToAsync(Stream stream, TransportContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContent.NativeMethodInfoPtr_CopyToAsync_Public_Task_Stream_TransportContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00006DF8 File Offset: 0x00004FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171619, XrefRangeEnd = 1171633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<Stream> CreateContentReadStreamAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpContent.NativeMethodInfoPtr_CreateContentReadStreamAsync_Protected_Virtual_New_Task_1_Stream_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Stream>>(intPtr3) : null;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00006E44 File Offset: 0x00005044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171633, XrefRangeEnd = 1171637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HttpContent.FixedMemoryStream CreateFixedMemoryStream(long maxBufferSize)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxBufferSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContent.NativeMethodInfoPtr_CreateFixedMemoryStream_Private_Static_FixedMemoryStream_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpContent.FixedMemoryStream>(intPtr3) : null;
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00006E84 File Offset: 0x00005084
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 1171637, RefRangeEnd = 1171657, XrefRangeStart = 1171637, XrefRangeEnd = 1171637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContent.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00006EB8 File Offset: 0x000050B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171657, XrefRangeEnd = 1171658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpContent.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00006F04 File Offset: 0x00005104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171658, XrefRangeEnd = 1171659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task LoadIntoBufferAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContent.NativeMethodInfoPtr_LoadIntoBufferAsync_Public_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00006F44 File Offset: 0x00005144
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1171669, RefRangeEnd = 1171675, XrefRangeStart = 1171659, XrefRangeEnd = 1171669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task LoadIntoBufferAsync(long maxBufferSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxBufferSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContent.NativeMethodInfoPtr_LoadIntoBufferAsync_Public_Task_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00006F90 File Offset: 0x00005190
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1171689, RefRangeEnd = 1171694, XrefRangeStart = 1171675, XrefRangeEnd = 1171689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Stream> ReadAsStreamAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContent.NativeMethodInfoPtr_ReadAsStreamAsync_Public_Task_1_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Stream>>(intPtr3) : null;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00006FD0 File Offset: 0x000051D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1171708, RefRangeEnd = 1171709, XrefRangeStart = 1171694, XrefRangeEnd = 1171708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Il2CppStructArray<byte>> ReadAsByteArrayAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContent.NativeMethodInfoPtr_ReadAsByteArrayAsync_Public_Task_1_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Il2CppStructArray<byte>>>(intPtr3) : null;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00007010 File Offset: 0x00005210
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1171723, RefRangeEnd = 1171731, XrefRangeStart = 1171709, XrefRangeEnd = 1171723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<string> ReadAsStringAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContent.NativeMethodInfoPtr_ReadAsStringAsync_Public_Task_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<string>>(intPtr3) : null;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00007050 File Offset: 0x00005250
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1171744, RefRangeEnd = 1171745, XrefRangeStart = 1171731, XrefRangeEnd = 1171744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Encoding GetEncodingFromBuffer(Il2CppStructArray<byte> buffer, int length, ref int preambleLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &preambleLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContent.NativeMethodInfoPtr_GetEncodingFromBuffer_Private_Static_Encoding_Il2CppStructArray_1_Byte_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000070B0 File Offset: 0x000052B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171745, XrefRangeEnd = 1171746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int StartsWith(Il2CppStructArray<byte> array, int length, Il2CppStructArray<byte> value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContent.NativeMethodInfoPtr_StartsWith_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00007114 File Offset: 0x00005314
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 436553, RefRangeEnd = 436554, XrefRangeStart = 436553, XrefRangeEnd = 436554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task SerializeToStreamAsync_internal(Stream stream, TransportContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContent.NativeMethodInfoPtr_SerializeToStreamAsync_internal_Internal_Task_Stream_TransportContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00007178 File Offset: 0x00005378
		[CallerCount(0)]
		public unsafe virtual Task SerializeToStreamAsync(Stream stream, TransportContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpContent.NativeMethodInfoPtr_SerializeToStreamAsync_Protected_Abstract_Virtual_New_Task_Stream_TransportContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000071E8 File Offset: 0x000053E8
		[CallerCount(0)]
		public unsafe virtual bool TryComputeLength(out long length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpContent.NativeMethodInfoPtr_TryComputeLength_FamOrAssem_Abstract_Virtual_New_Boolean_byref_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000723C File Offset: 0x0000543C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpContent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpContent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContent.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000024EB File Offset: 0x000006EB
		public HttpContent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00007278 File Offset: 0x00005478
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x000024F4 File Offset: 0x000006F4
		public unsafe HttpContent.FixedMemoryStream buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent.NativeFieldInfoPtr_buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpContent.FixedMemoryStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x000072A8 File Offset: 0x000054A8
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x00002513 File Offset: 0x00000713
		public unsafe Stream stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent.NativeFieldInfoPtr_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x000072D8 File Offset: 0x000054D8
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x00002532 File Offset: 0x00000732
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00007300 File Offset: 0x00005500
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x0000254D File Offset: 0x0000074D
		public unsafe HttpContentHeaders headers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent.NativeFieldInfoPtr_headers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpContentHeaders>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent.NativeFieldInfoPtr_headers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeFieldInfoPtr_buffer;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeFieldInfoPtr_stream;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeFieldInfoPtr_headers;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_get_Headers_Public_get_HttpContentHeaders_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadedBufferLength_Internal_get_Nullable_1_Int64_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_CopyToAsync_Public_Task_Stream_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_CopyToAsync_Public_Task_Stream_TransportContext_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_CreateContentReadStreamAsync_Protected_Virtual_New_Task_1_Stream_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_CreateFixedMemoryStream_Private_Static_FixedMemoryStream_Int64_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_LoadIntoBufferAsync_Public_Task_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_LoadIntoBufferAsync_Public_Task_Int64_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsStreamAsync_Public_Task_1_Stream_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsByteArrayAsync_Public_Task_1_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsStringAsync_Public_Task_1_String_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_GetEncodingFromBuffer_Private_Static_Encoding_Il2CppStructArray_1_Byte_Int32_byref_Int32_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_StartsWith_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_SerializeToStreamAsync_internal_Internal_Task_Stream_TransportContext_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_SerializeToStreamAsync_Protected_Abstract_Virtual_New_Task_Stream_TransportContext_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_TryComputeLength_FamOrAssem_Abstract_Virtual_New_Boolean_byref_Int64_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000041 RID: 65
		public sealed class FixedMemoryStream : MemoryStream
		{
			// Token: 0x06000424 RID: 1060 RVA: 0x00014E2C File Offset: 0x0001302C
			// Note: this type is marked as 'beforefieldinit'.
			static FixedMemoryStream()
			{
				Il2CppClassPointerStore<HttpContent.FixedMemoryStream>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpContent>.NativeClassPtr, "FixedMemoryStream");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpContent.FixedMemoryStream>.NativeClassPtr);
				HttpContent.FixedMemoryStream.NativeFieldInfoPtr_maxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpContent.FixedMemoryStream>.NativeClassPtr, "maxSize");
				HttpContent.FixedMemoryStream.NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContent.FixedMemoryStream>.NativeClassPtr, 100663404);
				HttpContent.FixedMemoryStream.NativeMethodInfoPtr_CheckOverflow_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContent.FixedMemoryStream>.NativeClassPtr, 100663405);
				HttpContent.FixedMemoryStream.NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContent.FixedMemoryStream>.NativeClassPtr, 100663406);
				HttpContent.FixedMemoryStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContent.FixedMemoryStream>.NativeClassPtr, 100663407);
			}

			// Token: 0x06000425 RID: 1061 RVA: 0x00014EBC File Offset: 0x000130BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171429, XrefRangeEnd = 1171430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FixedMemoryStream(long maxSize)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpContent.FixedMemoryStream>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref maxSize;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContent.FixedMemoryStream.NativeMethodInfoPtr__ctor_Public_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000426 RID: 1062 RVA: 0x00014F04 File Offset: 0x00013104
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1171430, RefRangeEnd = 1171432, XrefRangeStart = 1171430, XrefRangeEnd = 1171430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CheckOverflow(int count)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref count;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContent.FixedMemoryStream.NativeMethodInfoPtr_CheckOverflow_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000427 RID: 1063 RVA: 0x00014F44 File Offset: 0x00013144
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171432, XrefRangeEnd = 1171434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void WriteByte(byte value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContent.FixedMemoryStream.NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000428 RID: 1064 RVA: 0x00014F84 File Offset: 0x00013184
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171434, XrefRangeEnd = 1171436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Write(Il2CppStructArray<byte> buffer, int offset, int count)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContent.FixedMemoryStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000429 RID: 1065 RVA: 0x000039FC File Offset: 0x00001BFC
			public FixedMemoryStream(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000140 RID: 320
			// (get) Token: 0x0600042A RID: 1066 RVA: 0x00014FE4 File Offset: 0x000131E4
			// (set) Token: 0x0600042B RID: 1067 RVA: 0x00003A05 File Offset: 0x00001C05
			public unsafe long maxSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent.FixedMemoryStream.NativeFieldInfoPtr_maxSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent.FixedMemoryStream.NativeFieldInfoPtr_maxSize)) = value;
				}
			}

			// Token: 0x040002FC RID: 764
			private static readonly IntPtr NativeFieldInfoPtr_maxSize;

			// Token: 0x040002FD RID: 765
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

			// Token: 0x040002FE RID: 766
			private static readonly IntPtr NativeMethodInfoPtr_CheckOverflow_Private_Void_Int32_0;

			// Token: 0x040002FF RID: 767
			private static readonly IntPtr NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0;

			// Token: 0x04000300 RID: 768
			private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;
		}

		// Token: 0x02000042 RID: 66
		[ObfuscatedName("System.Net.Http.HttpContent+<CreateContentReadStreamAsync>d__12")]
		public sealed class _CreateContentReadStreamAsync_d__12 : ValueType
		{
			// Token: 0x0600042C RID: 1068 RVA: 0x0001500C File Offset: 0x0001320C
			// Note: this type is marked as 'beforefieldinit'.
			static _CreateContentReadStreamAsync_d__12()
			{
				Il2CppClassPointerStore<HttpContent._CreateContentReadStreamAsync_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpContent>.NativeClassPtr, "<CreateContentReadStreamAsync>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpContent._CreateContentReadStreamAsync_d__12>.NativeClassPtr);
				HttpContent._CreateContentReadStreamAsync_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpContent._CreateContentReadStreamAsync_d__12>.NativeClassPtr, "<>1__state");
				HttpContent._CreateContentReadStreamAsync_d__12.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpContent._CreateContentReadStreamAsync_d__12>.NativeClassPtr, "<>t__builder");
				HttpContent._CreateContentReadStreamAsync_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpContent._CreateContentReadStreamAsync_d__12>.NativeClassPtr, "<>4__this");
				HttpContent._CreateContentReadStreamAsync_d__12.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpContent._CreateContentReadStreamAsync_d__12>.NativeClassPtr, "<>u__1");
				HttpContent._CreateContentReadStreamAsync_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContent._CreateContentReadStreamAsync_d__12>.NativeClassPtr, 100663408);
				HttpContent._CreateContentReadStreamAsync_d__12.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContent._CreateContentReadStreamAsync_d__12>.NativeClassPtr, 100663409);
			}

			// Token: 0x0600042D RID: 1069 RVA: 0x000150B0 File Offset: 0x000132B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171436, XrefRangeEnd = 1171448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContent._CreateContentReadStreamAsync_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600042E RID: 1070 RVA: 0x000150E8 File Offset: 0x000132E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171448, XrefRangeEnd = 1171454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContent._CreateContentReadStreamAsync_d__12.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600042F RID: 1071 RVA: 0x00003A20 File Offset: 0x00001C20
			public _CreateContentReadStreamAsync_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000430 RID: 1072 RVA: 0x00003A29 File Offset: 0x00001C29
			public _CreateContentReadStreamAsync_d__12()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpContent._CreateContentReadStreamAsync_d__12>.NativeClassPtr))
			{
			}

			// Token: 0x17000141 RID: 321
			// (get) Token: 0x06000431 RID: 1073 RVA: 0x00015130 File Offset: 0x00013330
			// (set) Token: 0x06000432 RID: 1074 RVA: 0x00003A3B File Offset: 0x00001C3B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._CreateContentReadStreamAsync_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._CreateContentReadStreamAsync_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000142 RID: 322
			// (get) Token: 0x06000433 RID: 1075 RVA: 0x00015158 File Offset: 0x00013358
			// (set) Token: 0x06000434 RID: 1076 RVA: 0x00003A56 File Offset: 0x00001C56
			public AsyncTaskMethodBuilder<Stream> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._CreateContentReadStreamAsync_d__12.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Stream>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Stream>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._CreateContentReadStreamAsync_d__12.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Stream>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000143 RID: 323
			// (get) Token: 0x06000435 RID: 1077 RVA: 0x00015188 File Offset: 0x00013388
			// (set) Token: 0x06000436 RID: 1078 RVA: 0x00003A84 File Offset: 0x00001C84
			public unsafe HttpContent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._CreateContentReadStreamAsync_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpContent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._CreateContentReadStreamAsync_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000144 RID: 324
			// (get) Token: 0x06000437 RID: 1079 RVA: 0x000151B8 File Offset: 0x000133B8
			// (set) Token: 0x06000438 RID: 1080 RVA: 0x00003AA3 File Offset: 0x00001CA3
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._CreateContentReadStreamAsync_d__12.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._CreateContentReadStreamAsync_d__12.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000301 RID: 769
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000302 RID: 770
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000303 RID: 771
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000304 RID: 772
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000305 RID: 773
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000306 RID: 774
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000043 RID: 67
		[ObfuscatedName("System.Net.Http.HttpContent+<LoadIntoBufferAsync>d__17")]
		public sealed class _LoadIntoBufferAsync_d__17 : ValueType
		{
			// Token: 0x06000439 RID: 1081 RVA: 0x000151E8 File Offset: 0x000133E8
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadIntoBufferAsync_d__17()
			{
				Il2CppClassPointerStore<HttpContent._LoadIntoBufferAsync_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpContent>.NativeClassPtr, "<LoadIntoBufferAsync>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpContent._LoadIntoBufferAsync_d__17>.NativeClassPtr);
				HttpContent._LoadIntoBufferAsync_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpContent._LoadIntoBufferAsync_d__17>.NativeClassPtr, "<>1__state");
				HttpContent._LoadIntoBufferAsync_d__17.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpContent._LoadIntoBufferAsync_d__17>.NativeClassPtr, "<>t__builder");
				HttpContent._LoadIntoBufferAsync_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpContent._LoadIntoBufferAsync_d__17>.NativeClassPtr, "<>4__this");
				HttpContent._LoadIntoBufferAsync_d__17.NativeFieldInfoPtr_maxBufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpContent._LoadIntoBufferAsync_d__17>.NativeClassPtr, "maxBufferSize");
				HttpContent._LoadIntoBufferAsync_d__17.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpContent._LoadIntoBufferAsync_d__17>.NativeClassPtr, "<>u__1");
				HttpContent._LoadIntoBufferAsync_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContent._LoadIntoBufferAsync_d__17>.NativeClassPtr, 100663410);
				HttpContent._LoadIntoBufferAsync_d__17.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContent._LoadIntoBufferAsync_d__17>.NativeClassPtr, 100663411);
			}

			// Token: 0x0600043A RID: 1082 RVA: 0x000152A0 File Offset: 0x000134A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171454, XrefRangeEnd = 1171475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContent._LoadIntoBufferAsync_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600043B RID: 1083 RVA: 0x000152D8 File Offset: 0x000134D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171475, XrefRangeEnd = 1171479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContent._LoadIntoBufferAsync_d__17.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600043C RID: 1084 RVA: 0x00003AD1 File Offset: 0x00001CD1
			public _LoadIntoBufferAsync_d__17(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600043D RID: 1085 RVA: 0x00003ADA File Offset: 0x00001CDA
			public _LoadIntoBufferAsync_d__17()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpContent._LoadIntoBufferAsync_d__17>.NativeClassPtr))
			{
			}

			// Token: 0x17000145 RID: 325
			// (get) Token: 0x0600043E RID: 1086 RVA: 0x00015320 File Offset: 0x00013520
			// (set) Token: 0x0600043F RID: 1087 RVA: 0x00003AEC File Offset: 0x00001CEC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._LoadIntoBufferAsync_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._LoadIntoBufferAsync_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000146 RID: 326
			// (get) Token: 0x06000440 RID: 1088 RVA: 0x00015348 File Offset: 0x00013548
			// (set) Token: 0x06000441 RID: 1089 RVA: 0x00003B07 File Offset: 0x00001D07
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._LoadIntoBufferAsync_d__17.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._LoadIntoBufferAsync_d__17.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000147 RID: 327
			// (get) Token: 0x06000442 RID: 1090 RVA: 0x00015378 File Offset: 0x00013578
			// (set) Token: 0x06000443 RID: 1091 RVA: 0x00003B35 File Offset: 0x00001D35
			public unsafe HttpContent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._LoadIntoBufferAsync_d__17.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpContent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._LoadIntoBufferAsync_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000148 RID: 328
			// (get) Token: 0x06000444 RID: 1092 RVA: 0x000153A8 File Offset: 0x000135A8
			// (set) Token: 0x06000445 RID: 1093 RVA: 0x00003B54 File Offset: 0x00001D54
			public unsafe long maxBufferSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._LoadIntoBufferAsync_d__17.NativeFieldInfoPtr_maxBufferSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._LoadIntoBufferAsync_d__17.NativeFieldInfoPtr_maxBufferSize)) = value;
				}
			}

			// Token: 0x17000149 RID: 329
			// (get) Token: 0x06000446 RID: 1094 RVA: 0x000153D0 File Offset: 0x000135D0
			// (set) Token: 0x06000447 RID: 1095 RVA: 0x00003B6F File Offset: 0x00001D6F
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._LoadIntoBufferAsync_d__17.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._LoadIntoBufferAsync_d__17.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000307 RID: 775
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000308 RID: 776
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000309 RID: 777
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400030A RID: 778
			private static readonly IntPtr NativeFieldInfoPtr_maxBufferSize;

			// Token: 0x0400030B RID: 779
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400030C RID: 780
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400030D RID: 781
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000044 RID: 68
		[ObfuscatedName("System.Net.Http.HttpContent+<ReadAsStreamAsync>d__18")]
		public sealed class _ReadAsStreamAsync_d__18 : ValueType
		{
			// Token: 0x06000448 RID: 1096 RVA: 0x00015400 File Offset: 0x00013600
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadAsStreamAsync_d__18()
			{
				Il2CppClassPointerStore<HttpContent._ReadAsStreamAsync_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpContent>.NativeClassPtr, "<ReadAsStreamAsync>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpContent._ReadAsStreamAsync_d__18>.NativeClassPtr);
				HttpContent._ReadAsStreamAsync_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpContent._ReadAsStreamAsync_d__18>.NativeClassPtr, "<>1__state");
				HttpContent._ReadAsStreamAsync_d__18.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpContent._ReadAsStreamAsync_d__18>.NativeClassPtr, "<>t__builder");
				HttpContent._ReadAsStreamAsync_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpContent._ReadAsStreamAsync_d__18>.NativeClassPtr, "<>4__this");
				HttpContent._ReadAsStreamAsync_d__18.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpContent._ReadAsStreamAsync_d__18>.NativeClassPtr, "<>u__1");
				HttpContent._ReadAsStreamAsync_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContent._ReadAsStreamAsync_d__18>.NativeClassPtr, 100663412);
				HttpContent._ReadAsStreamAsync_d__18.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContent._ReadAsStreamAsync_d__18>.NativeClassPtr, 100663413);
			}

			// Token: 0x06000449 RID: 1097 RVA: 0x000154A4 File Offset: 0x000136A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171479, XrefRangeEnd = 1171503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContent._ReadAsStreamAsync_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600044A RID: 1098 RVA: 0x000154DC File Offset: 0x000136DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171503, XrefRangeEnd = 1171509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContent._ReadAsStreamAsync_d__18.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600044B RID: 1099 RVA: 0x00003B9D File Offset: 0x00001D9D
			public _ReadAsStreamAsync_d__18(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600044C RID: 1100 RVA: 0x00003BA6 File Offset: 0x00001DA6
			public _ReadAsStreamAsync_d__18()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpContent._ReadAsStreamAsync_d__18>.NativeClassPtr))
			{
			}

			// Token: 0x1700014A RID: 330
			// (get) Token: 0x0600044D RID: 1101 RVA: 0x00015524 File Offset: 0x00013724
			// (set) Token: 0x0600044E RID: 1102 RVA: 0x00003BB8 File Offset: 0x00001DB8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._ReadAsStreamAsync_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._ReadAsStreamAsync_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700014B RID: 331
			// (get) Token: 0x0600044F RID: 1103 RVA: 0x0001554C File Offset: 0x0001374C
			// (set) Token: 0x06000450 RID: 1104 RVA: 0x00003BD3 File Offset: 0x00001DD3
			public AsyncTaskMethodBuilder<Stream> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._ReadAsStreamAsync_d__18.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Stream>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Stream>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._ReadAsStreamAsync_d__18.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Stream>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700014C RID: 332
			// (get) Token: 0x06000451 RID: 1105 RVA: 0x0001557C File Offset: 0x0001377C
			// (set) Token: 0x06000452 RID: 1106 RVA: 0x00003C01 File Offset: 0x00001E01
			public unsafe HttpContent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._ReadAsStreamAsync_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpContent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._ReadAsStreamAsync_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700014D RID: 333
			// (get) Token: 0x06000453 RID: 1107 RVA: 0x000155AC File Offset: 0x000137AC
			// (set) Token: 0x06000454 RID: 1108 RVA: 0x00003C20 File Offset: 0x00001E20
			public ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._ReadAsStreamAsync_d__18.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._ReadAsStreamAsync_d__18.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400030E RID: 782
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400030F RID: 783
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000310 RID: 784
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000311 RID: 785
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000312 RID: 786
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000313 RID: 787
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000045 RID: 69
		[ObfuscatedName("System.Net.Http.HttpContent+<ReadAsByteArrayAsync>d__19")]
		public sealed class _ReadAsByteArrayAsync_d__19 : ValueType
		{
			// Token: 0x06000455 RID: 1109 RVA: 0x000155DC File Offset: 0x000137DC
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadAsByteArrayAsync_d__19()
			{
				Il2CppClassPointerStore<HttpContent._ReadAsByteArrayAsync_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpContent>.NativeClassPtr, "<ReadAsByteArrayAsync>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpContent._ReadAsByteArrayAsync_d__19>.NativeClassPtr);
				HttpContent._ReadAsByteArrayAsync_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpContent._ReadAsByteArrayAsync_d__19>.NativeClassPtr, "<>1__state");
				HttpContent._ReadAsByteArrayAsync_d__19.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpContent._ReadAsByteArrayAsync_d__19>.NativeClassPtr, "<>t__builder");
				HttpContent._ReadAsByteArrayAsync_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpContent._ReadAsByteArrayAsync_d__19>.NativeClassPtr, "<>4__this");
				HttpContent._ReadAsByteArrayAsync_d__19.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpContent._ReadAsByteArrayAsync_d__19>.NativeClassPtr, "<>u__1");
				HttpContent._ReadAsByteArrayAsync_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContent._ReadAsByteArrayAsync_d__19>.NativeClassPtr, 100663414);
				HttpContent._ReadAsByteArrayAsync_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContent._ReadAsByteArrayAsync_d__19>.NativeClassPtr, 100663415);
			}

			// Token: 0x06000456 RID: 1110 RVA: 0x00015680 File Offset: 0x00013880
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171509, XrefRangeEnd = 1171521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContent._ReadAsByteArrayAsync_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000457 RID: 1111 RVA: 0x000156B8 File Offset: 0x000138B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171521, XrefRangeEnd = 1171527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContent._ReadAsByteArrayAsync_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000458 RID: 1112 RVA: 0x00003C4E File Offset: 0x00001E4E
			public _ReadAsByteArrayAsync_d__19(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000459 RID: 1113 RVA: 0x00003C57 File Offset: 0x00001E57
			public _ReadAsByteArrayAsync_d__19()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpContent._ReadAsByteArrayAsync_d__19>.NativeClassPtr))
			{
			}

			// Token: 0x1700014E RID: 334
			// (get) Token: 0x0600045A RID: 1114 RVA: 0x00015700 File Offset: 0x00013900
			// (set) Token: 0x0600045B RID: 1115 RVA: 0x00003C69 File Offset: 0x00001E69
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._ReadAsByteArrayAsync_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._ReadAsByteArrayAsync_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700014F RID: 335
			// (get) Token: 0x0600045C RID: 1116 RVA: 0x00015728 File Offset: 0x00013928
			// (set) Token: 0x0600045D RID: 1117 RVA: 0x00003C84 File Offset: 0x00001E84
			public AsyncTaskMethodBuilder<Il2CppStructArray<byte>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._ReadAsByteArrayAsync_d__19.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Il2CppStructArray<byte>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppStructArray<byte>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._ReadAsByteArrayAsync_d__19.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppStructArray<byte>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000150 RID: 336
			// (get) Token: 0x0600045E RID: 1118 RVA: 0x00015758 File Offset: 0x00013958
			// (set) Token: 0x0600045F RID: 1119 RVA: 0x00003CB2 File Offset: 0x00001EB2
			public unsafe HttpContent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._ReadAsByteArrayAsync_d__19.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpContent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._ReadAsByteArrayAsync_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000151 RID: 337
			// (get) Token: 0x06000460 RID: 1120 RVA: 0x00015788 File Offset: 0x00013988
			// (set) Token: 0x06000461 RID: 1121 RVA: 0x00003CD1 File Offset: 0x00001ED1
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._ReadAsByteArrayAsync_d__19.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._ReadAsByteArrayAsync_d__19.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000314 RID: 788
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000315 RID: 789
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000316 RID: 790
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000317 RID: 791
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000318 RID: 792
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000319 RID: 793
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000046 RID: 70
		[ObfuscatedName("System.Net.Http.HttpContent+<ReadAsStringAsync>d__20")]
		public sealed class _ReadAsStringAsync_d__20 : ValueType
		{
			// Token: 0x06000462 RID: 1122 RVA: 0x000157B8 File Offset: 0x000139B8
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadAsStringAsync_d__20()
			{
				Il2CppClassPointerStore<HttpContent._ReadAsStringAsync_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpContent>.NativeClassPtr, "<ReadAsStringAsync>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpContent._ReadAsStringAsync_d__20>.NativeClassPtr);
				HttpContent._ReadAsStringAsync_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpContent._ReadAsStringAsync_d__20>.NativeClassPtr, "<>1__state");
				HttpContent._ReadAsStringAsync_d__20.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpContent._ReadAsStringAsync_d__20>.NativeClassPtr, "<>t__builder");
				HttpContent._ReadAsStringAsync_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpContent._ReadAsStringAsync_d__20>.NativeClassPtr, "<>4__this");
				HttpContent._ReadAsStringAsync_d__20.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpContent._ReadAsStringAsync_d__20>.NativeClassPtr, "<>u__1");
				HttpContent._ReadAsStringAsync_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContent._ReadAsStringAsync_d__20>.NativeClassPtr, 100663416);
				HttpContent._ReadAsStringAsync_d__20.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContent._ReadAsStringAsync_d__20>.NativeClassPtr, 100663417);
			}

			// Token: 0x06000463 RID: 1123 RVA: 0x0001585C File Offset: 0x00013A5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171527, XrefRangeEnd = 1171556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContent._ReadAsStringAsync_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000464 RID: 1124 RVA: 0x00015894 File Offset: 0x00013A94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171556, XrefRangeEnd = 1171562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContent._ReadAsStringAsync_d__20.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000465 RID: 1125 RVA: 0x00003CFF File Offset: 0x00001EFF
			public _ReadAsStringAsync_d__20(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000466 RID: 1126 RVA: 0x00003D08 File Offset: 0x00001F08
			public _ReadAsStringAsync_d__20()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpContent._ReadAsStringAsync_d__20>.NativeClassPtr))
			{
			}

			// Token: 0x17000152 RID: 338
			// (get) Token: 0x06000467 RID: 1127 RVA: 0x000158DC File Offset: 0x00013ADC
			// (set) Token: 0x06000468 RID: 1128 RVA: 0x00003D1A File Offset: 0x00001F1A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._ReadAsStringAsync_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._ReadAsStringAsync_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000153 RID: 339
			// (get) Token: 0x06000469 RID: 1129 RVA: 0x00015904 File Offset: 0x00013B04
			// (set) Token: 0x0600046A RID: 1130 RVA: 0x00003D35 File Offset: 0x00001F35
			public AsyncTaskMethodBuilder<string> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._ReadAsStringAsync_d__20.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<string>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<string>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._ReadAsStringAsync_d__20.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<string>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000154 RID: 340
			// (get) Token: 0x0600046B RID: 1131 RVA: 0x00015934 File Offset: 0x00013B34
			// (set) Token: 0x0600046C RID: 1132 RVA: 0x00003D63 File Offset: 0x00001F63
			public unsafe HttpContent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._ReadAsStringAsync_d__20.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpContent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._ReadAsStringAsync_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000155 RID: 341
			// (get) Token: 0x0600046D RID: 1133 RVA: 0x00015964 File Offset: 0x00013B64
			// (set) Token: 0x0600046E RID: 1134 RVA: 0x00003D82 File Offset: 0x00001F82
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._ReadAsStringAsync_d__20.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContent._ReadAsStringAsync_d__20.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400031A RID: 794
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400031B RID: 795
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400031C RID: 796
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400031D RID: 797
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400031E RID: 798
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400031F RID: 799
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}

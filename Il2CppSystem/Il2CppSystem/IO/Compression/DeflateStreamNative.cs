using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppSystem.IO.Compression
{
	// Token: 0x0200018C RID: 396
	public class DeflateStreamNative : Object
	{
		// Token: 0x0600181C RID: 6172 RVA: 0x0007AAFC File Offset: 0x00078CFC
		// Note: this type is marked as 'beforefieldinit'.
		static DeflateStreamNative()
		{
			Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.IO.Compression", "DeflateStreamNative");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr);
			DeflateStreamNative.NativeFieldInfoPtr_feeder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, "feeder");
			DeflateStreamNative.NativeFieldInfoPtr_base_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, "base_stream");
			DeflateStreamNative.NativeFieldInfoPtr_z_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, "z_stream");
			DeflateStreamNative.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, "data");
			DeflateStreamNative.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, "disposed");
			DeflateStreamNative.NativeFieldInfoPtr_io_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, "io_buffer");
			DeflateStreamNative.NativeFieldInfoPtr_last_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, "last_error");
			DeflateStreamNative.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100667101);
			DeflateStreamNative.NativeMethodInfoPtr_Create_Public_Static_DeflateStreamNative_Stream_CompressionMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100667102);
			DeflateStreamNative.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100667103);
			DeflateStreamNative.NativeMethodInfoPtr_Dispose_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100667104);
			DeflateStreamNative.NativeMethodInfoPtr_Flush_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100667105);
			DeflateStreamNative.NativeMethodInfoPtr_ReadZStream_Public_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100667106);
			DeflateStreamNative.NativeMethodInfoPtr_WriteZStream_Public_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100667107);
			DeflateStreamNative.NativeMethodInfoPtr_UnmanagedRead_Private_Static_Int32_IntPtr_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100667108);
			DeflateStreamNative.NativeMethodInfoPtr_UnmanagedRead_Private_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100667109);
			DeflateStreamNative.NativeMethodInfoPtr_UnmanagedWrite_Private_Static_Int32_IntPtr_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100667110);
			DeflateStreamNative.NativeMethodInfoPtr_UnmanagedWrite_Private_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100667111);
			DeflateStreamNative.NativeMethodInfoPtr_CheckResult_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100667112);
			DeflateStreamNative.NativeMethodInfoPtr_CreateZStream_Private_Static_SafeDeflateStreamHandle_CompressionMode_Boolean_UnmanagedReadOrWrite_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100667113);
			DeflateStreamNative.NativeMethodInfoPtr_CloseZStream_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100667114);
			DeflateStreamNative.NativeMethodInfoPtr_Flush_Private_Static_Int32_SafeDeflateStreamHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100667115);
			DeflateStreamNative.NativeMethodInfoPtr_ReadZStream_Private_Static_Int32_SafeDeflateStreamHandle_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100667116);
			DeflateStreamNative.NativeMethodInfoPtr_WriteZStream_Private_Static_Int32_SafeDeflateStreamHandle_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100667117);
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x0007AD0C File Offset: 0x00078F0C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeflateStreamNative()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x0007AD48 File Offset: 0x00078F48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 470474, RefRangeEnd = 470475, XrefRangeStart = 470446, XrefRangeEnd = 470474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DeflateStreamNative Create(Stream compressedStream, CompressionMode mode, bool gzip)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(compressedStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gzip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_Create_Public_Static_DeflateStreamNative_Stream_CompressionMode_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeflateStreamNative>(intPtr3) : null;
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x0007ADA8 File Offset: 0x00078FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 470475, XrefRangeEnd = 470479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeflateStreamNative.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x0007ADE4 File Offset: 0x00078FE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 470493, RefRangeEnd = 470495, XrefRangeStart = 470479, XrefRangeEnd = 470493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_Dispose_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x0007AE24 File Offset: 0x00079024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 470495, XrefRangeEnd = 470503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_Flush_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x0007AE58 File Offset: 0x00079058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 470503, XrefRangeEnd = 470509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadZStream(IntPtr buffer, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_ReadZStream_Public_Int32_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x0007AEB0 File Offset: 0x000790B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 470509, XrefRangeEnd = 470517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteZStream(IntPtr buffer, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_WriteZStream_Public_Void_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x0007AEFC File Offset: 0x000790FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 470517, XrefRangeEnd = 470523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int UnmanagedRead(IntPtr buffer, int length, IntPtr data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_UnmanagedRead_Private_Static_Int32_IntPtr_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x0007AF58 File Offset: 0x00079158
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 470535, RefRangeEnd = 470536, XrefRangeStart = 470523, XrefRangeEnd = 470535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int UnmanagedRead(IntPtr buffer, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_UnmanagedRead_Private_Int32_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x0007AFB0 File Offset: 0x000791B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 470536, XrefRangeEnd = 470542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int UnmanagedWrite(IntPtr buffer, int length, IntPtr data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_UnmanagedWrite_Private_Static_Int32_IntPtr_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x0007B00C File Offset: 0x0007920C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 470558, RefRangeEnd = 470559, XrefRangeStart = 470542, XrefRangeEnd = 470558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int UnmanagedWrite(IntPtr buffer, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_UnmanagedWrite_Private_Int32_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x0007B064 File Offset: 0x00079264
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 470561, RefRangeEnd = 470569, XrefRangeStart = 470559, XrefRangeEnd = 470561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckResult(int result, string where)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref result;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(where);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_CheckResult_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x0007B0B4 File Offset: 0x000792B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 470569, XrefRangeEnd = 470575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DeflateStreamNative.SafeDeflateStreamHandle CreateZStream(CompressionMode compress, bool gzip, DeflateStreamNative.UnmanagedReadOrWrite feeder, IntPtr data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref compress;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gzip;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(feeder);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_CreateZStream_Private_Static_SafeDeflateStreamHandle_CompressionMode_Boolean_UnmanagedReadOrWrite_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeflateStreamNative.SafeDeflateStreamHandle>(intPtr3) : null;
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x0007B124 File Offset: 0x00079324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 470575, XrefRangeEnd = 470576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CloseZStream(IntPtr stream)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stream;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_CloseZStream_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x0007B164 File Offset: 0x00079364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 470576, XrefRangeEnd = 470579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Flush(DeflateStreamNative.SafeDeflateStreamHandle stream)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_Flush_Private_Static_Int32_SafeDeflateStreamHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x0007B1A8 File Offset: 0x000793A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 470579, XrefRangeEnd = 470582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ReadZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_ReadZStream_Private_Static_Int32_SafeDeflateStreamHandle_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x0007B208 File Offset: 0x00079408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 470582, XrefRangeEnd = 470585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int WriteZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_WriteZStream_Private_Static_Int32_SafeDeflateStreamHandle_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x0000A63C File Offset: 0x0000883C
		public DeflateStreamNative(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x0600182F RID: 6191 RVA: 0x0007B268 File Offset: 0x00079468
		// (set) Token: 0x06001830 RID: 6192 RVA: 0x0000A645 File Offset: 0x00008845
		public unsafe DeflateStreamNative.UnmanagedReadOrWrite feeder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_feeder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeflateStreamNative.UnmanagedReadOrWrite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_feeder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06001831 RID: 6193 RVA: 0x0007B298 File Offset: 0x00079498
		// (set) Token: 0x06001832 RID: 6194 RVA: 0x0000A664 File Offset: 0x00008864
		public unsafe Stream base_stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_base_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_base_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06001833 RID: 6195 RVA: 0x0007B2C8 File Offset: 0x000794C8
		// (set) Token: 0x06001834 RID: 6196 RVA: 0x0000A683 File Offset: 0x00008883
		public unsafe DeflateStreamNative.SafeDeflateStreamHandle z_stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_z_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeflateStreamNative.SafeDeflateStreamHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_z_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06001835 RID: 6197 RVA: 0x0007B2F8 File Offset: 0x000794F8
		// (set) Token: 0x06001836 RID: 6198 RVA: 0x0000A6A2 File Offset: 0x000088A2
		public unsafe GCHandle data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_data);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_data)) = value;
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06001837 RID: 6199 RVA: 0x0007B320 File Offset: 0x00079520
		// (set) Token: 0x06001838 RID: 6200 RVA: 0x0000A6BD File Offset: 0x000088BD
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06001839 RID: 6201 RVA: 0x0007B348 File Offset: 0x00079548
		// (set) Token: 0x0600183A RID: 6202 RVA: 0x0000A6D8 File Offset: 0x000088D8
		public unsafe Il2CppStructArray<byte> io_buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_io_buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_io_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x0600183B RID: 6203 RVA: 0x0007B378 File Offset: 0x00079578
		// (set) Token: 0x0600183C RID: 6204 RVA: 0x0000A6F7 File Offset: 0x000088F7
		public unsafe Exception last_error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_last_error);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_last_error), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012C5 RID: 4805
		private static readonly IntPtr NativeFieldInfoPtr_feeder;

		// Token: 0x040012C6 RID: 4806
		private static readonly IntPtr NativeFieldInfoPtr_base_stream;

		// Token: 0x040012C7 RID: 4807
		private static readonly IntPtr NativeFieldInfoPtr_z_stream;

		// Token: 0x040012C8 RID: 4808
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040012C9 RID: 4809
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x040012CA RID: 4810
		private static readonly IntPtr NativeFieldInfoPtr_io_buffer;

		// Token: 0x040012CB RID: 4811
		private static readonly IntPtr NativeFieldInfoPtr_last_error;

		// Token: 0x040012CC RID: 4812
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040012CD RID: 4813
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_DeflateStreamNative_Stream_CompressionMode_Boolean_0;

		// Token: 0x040012CE RID: 4814
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040012CF RID: 4815
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_Boolean_0;

		// Token: 0x040012D0 RID: 4816
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Void_0;

		// Token: 0x040012D1 RID: 4817
		private static readonly IntPtr NativeMethodInfoPtr_ReadZStream_Public_Int32_IntPtr_Int32_0;

		// Token: 0x040012D2 RID: 4818
		private static readonly IntPtr NativeMethodInfoPtr_WriteZStream_Public_Void_IntPtr_Int32_0;

		// Token: 0x040012D3 RID: 4819
		private static readonly IntPtr NativeMethodInfoPtr_UnmanagedRead_Private_Static_Int32_IntPtr_Int32_IntPtr_0;

		// Token: 0x040012D4 RID: 4820
		private static readonly IntPtr NativeMethodInfoPtr_UnmanagedRead_Private_Int32_IntPtr_Int32_0;

		// Token: 0x040012D5 RID: 4821
		private static readonly IntPtr NativeMethodInfoPtr_UnmanagedWrite_Private_Static_Int32_IntPtr_Int32_IntPtr_0;

		// Token: 0x040012D6 RID: 4822
		private static readonly IntPtr NativeMethodInfoPtr_UnmanagedWrite_Private_Int32_IntPtr_Int32_0;

		// Token: 0x040012D7 RID: 4823
		private static readonly IntPtr NativeMethodInfoPtr_CheckResult_Private_Void_Int32_String_0;

		// Token: 0x040012D8 RID: 4824
		private static readonly IntPtr NativeMethodInfoPtr_CreateZStream_Private_Static_SafeDeflateStreamHandle_CompressionMode_Boolean_UnmanagedReadOrWrite_IntPtr_0;

		// Token: 0x040012D9 RID: 4825
		private static readonly IntPtr NativeMethodInfoPtr_CloseZStream_Private_Static_Int32_IntPtr_0;

		// Token: 0x040012DA RID: 4826
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Private_Static_Int32_SafeDeflateStreamHandle_0;

		// Token: 0x040012DB RID: 4827
		private static readonly IntPtr NativeMethodInfoPtr_ReadZStream_Private_Static_Int32_SafeDeflateStreamHandle_IntPtr_Int32_0;

		// Token: 0x040012DC RID: 4828
		private static readonly IntPtr NativeMethodInfoPtr_WriteZStream_Private_Static_Int32_SafeDeflateStreamHandle_IntPtr_Int32_0;

		// Token: 0x0200030D RID: 781
		public sealed class UnmanagedReadOrWrite : MulticastDelegate
		{
			// Token: 0x06002E74 RID: 11892 RVA: 0x00014BD9 File Offset: 0x00012DD9
			// Note: this type is marked as 'beforefieldinit'.
			static UnmanagedReadOrWrite()
			{
				Il2CppClassPointerStore<DeflateStreamNative.UnmanagedReadOrWrite>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, "UnmanagedReadOrWrite");
				DeflateStreamNative.UnmanagedReadOrWrite.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative.UnmanagedReadOrWrite>.NativeClassPtr, 100667118);
				DeflateStreamNative.UnmanagedReadOrWrite.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative.UnmanagedReadOrWrite>.NativeClassPtr, 100667119);
			}

			// Token: 0x06002E75 RID: 11893 RVA: 0x000CBD98 File Offset: 0x000C9F98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UnmanagedReadOrWrite(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeflateStreamNative.UnmanagedReadOrWrite>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.UnmanagedReadOrWrite.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E76 RID: 11894 RVA: 0x000CBDF4 File Offset: 0x000C9FF4
			[CallerCount(0)]
			public unsafe int Invoke(IntPtr buffer, int length, IntPtr data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref buffer;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.UnmanagedReadOrWrite.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002E77 RID: 11895 RVA: 0x00014C17 File Offset: 0x00012E17
			public UnmanagedReadOrWrite(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002E78 RID: 11896 RVA: 0x00014C20 File Offset: 0x00012E20
			public static implicit operator DeflateStreamNative.UnmanagedReadOrWrite(Func<IntPtr, int, IntPtr, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<DeflateStreamNative.UnmanagedReadOrWrite>(A_0);
			}

			// Token: 0x06002E79 RID: 11897 RVA: 0x00014C28 File Offset: 0x00012E28
			public static DeflateStreamNative.UnmanagedReadOrWrite operator +(DeflateStreamNative.UnmanagedReadOrWrite A_0, DeflateStreamNative.UnmanagedReadOrWrite A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<DeflateStreamNative.UnmanagedReadOrWrite>();
			}

			// Token: 0x06002E7A RID: 11898 RVA: 0x00014C36 File Offset: 0x00012E36
			public static DeflateStreamNative.UnmanagedReadOrWrite operator -(DeflateStreamNative.UnmanagedReadOrWrite A_0, DeflateStreamNative.UnmanagedReadOrWrite A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<DeflateStreamNative.UnmanagedReadOrWrite>();
				}
				return delegate2;
			}

			// Token: 0x04002471 RID: 9329
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002472 RID: 9330
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_Int32_IntPtr_0;
		}

		// Token: 0x0200030E RID: 782
		public sealed class SafeDeflateStreamHandle : SafeHandle
		{
			// Token: 0x06002E7B RID: 11899 RVA: 0x000CBE5C File Offset: 0x000CA05C
			// Note: this type is marked as 'beforefieldinit'.
			static SafeDeflateStreamHandle()
			{
				Il2CppClassPointerStore<DeflateStreamNative.SafeDeflateStreamHandle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, "SafeDeflateStreamHandle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeflateStreamNative.SafeDeflateStreamHandle>.NativeClassPtr);
				DeflateStreamNative.SafeDeflateStreamHandle.NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative.SafeDeflateStreamHandle>.NativeClassPtr, 100667120);
				DeflateStreamNative.SafeDeflateStreamHandle.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative.SafeDeflateStreamHandle>.NativeClassPtr, 100667121);
				DeflateStreamNative.SafeDeflateStreamHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative.SafeDeflateStreamHandle>.NativeClassPtr, 100667122);
			}

			// Token: 0x17000E90 RID: 3728
			// (get) Token: 0x06002E7C RID: 11900 RVA: 0x000CBEC4 File Offset: 0x000CA0C4
			public unsafe override bool IsInvalid
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.SafeDeflateStreamHandle.NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002E7D RID: 11901 RVA: 0x000CBF00 File Offset: 0x000CA100
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 470438, RefRangeEnd = 470444, XrefRangeStart = 470437, XrefRangeEnd = 470438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SafeDeflateStreamHandle()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeflateStreamNative.SafeDeflateStreamHandle>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.SafeDeflateStreamHandle.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E7E RID: 11902 RVA: 0x000CBF3C File Offset: 0x000CA13C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 470444, XrefRangeEnd = 470446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool ReleaseHandle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.SafeDeflateStreamHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002E7F RID: 11903 RVA: 0x00014C47 File Offset: 0x00012E47
			public SafeDeflateStreamHandle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002473 RID: 9331
			private static readonly IntPtr NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0;

			// Token: 0x04002474 RID: 9332
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

			// Token: 0x04002475 RID: 9333
			private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;

namespace dwd.core.networking.downloadHandlers
{
	// Token: 0x02000127 RID: 295
	public class DwdDownloadHandlerFile : DwdDownloadHandler
	{
		// Token: 0x0600109C RID: 4252 RVA: 0x0005591C File Offset: 0x00053B1C
		// Note: this type is marked as 'beforefieldinit'.
		static DwdDownloadHandlerFile()
		{
			Il2CppClassPointerStore<DwdDownloadHandlerFile>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.networking.downloadHandlers", "DwdDownloadHandlerFile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DwdDownloadHandlerFile>.NativeClassPtr);
			DwdDownloadHandlerFile.NativeFieldInfoPtr_fileStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdDownloadHandlerFile>.NativeClassPtr, "fileStream");
			DwdDownloadHandlerFile.NativeFieldInfoPtr_maximumFileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdDownloadHandlerFile>.NativeClassPtr, "maximumFileSize");
			DwdDownloadHandlerFile.NativeFieldInfoPtr_initialBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdDownloadHandlerFile>.NativeClassPtr, "initialBytes");
			DwdDownloadHandlerFile.NativeFieldInfoPtr_internalStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdDownloadHandlerFile>.NativeClassPtr, "internalStatus");
			DwdDownloadHandlerFile.NativeMethodInfoPtr_get_Status_Public_Virtual_get_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdDownloadHandlerFile>.NativeClassPtr, 100665719);
			DwdDownloadHandlerFile.NativeMethodInfoPtr_get_HasData_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdDownloadHandlerFile>.NativeClassPtr, 100665720);
			DwdDownloadHandlerFile.NativeMethodInfoPtr__ctor_Public_Void_FileStream_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdDownloadHandlerFile>.NativeClassPtr, 100665721);
			DwdDownloadHandlerFile.NativeMethodInfoPtr_GetProgress_Protected_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdDownloadHandlerFile>.NativeClassPtr, 100665722);
			DwdDownloadHandlerFile.NativeMethodInfoPtr_getData_Protected_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdDownloadHandlerFile>.NativeClassPtr, 100665723);
			DwdDownloadHandlerFile.NativeMethodInfoPtr_ReceiveContentLength_Protected_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdDownloadHandlerFile>.NativeClassPtr, 100665724);
			DwdDownloadHandlerFile.NativeMethodInfoPtr_receiveData_Protected_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdDownloadHandlerFile>.NativeClassPtr, 100665725);
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x0600109D RID: 4253 RVA: 0x00055A28 File Offset: 0x00053C28
		public unsafe override ErrorInfo Status
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DwdDownloadHandlerFile.NativeMethodInfoPtr_get_Status_Public_Virtual_get_ErrorInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ErrorInfo(intPtr);
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x0600109E RID: 4254 RVA: 0x00055A6C File Offset: 0x00053C6C
		public unsafe override bool HasData
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DwdDownloadHandlerFile.NativeMethodInfoPtr_get_HasData_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x00055AB4 File Offset: 0x00053CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869878, XrefRangeEnd = 869895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DwdDownloadHandlerFile(FileStream fileStream, long maximumFileSize = -1L)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DwdDownloadHandlerFile>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fileStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maximumFileSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdDownloadHandlerFile.NativeMethodInfoPtr__ctor_Public_Void_FileStream_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x00055B10 File Offset: 0x00053D10
		[CallerCount(0)]
		public unsafe override float GetProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DwdDownloadHandlerFile.NativeMethodInfoPtr_GetProgress_Protected_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x00055B58 File Offset: 0x00053D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869895, XrefRangeEnd = 869901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> getData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DwdDownloadHandlerFile.NativeMethodInfoPtr_getData_Protected_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x00055BA4 File Offset: 0x00053DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869901, XrefRangeEnd = 869907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ReceiveContentLength(int contentLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref contentLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DwdDownloadHandlerFile.NativeMethodInfoPtr_ReceiveContentLength_Protected_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x00055BF0 File Offset: 0x00053DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869907, XrefRangeEnd = 869914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool receiveData(Il2CppStructArray<byte> newData, int dataLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DwdDownloadHandlerFile.NativeMethodInfoPtr_receiveData_Protected_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x00007BC3 File Offset: 0x00005DC3
		public DwdDownloadHandlerFile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x060010A5 RID: 4261 RVA: 0x00055C58 File Offset: 0x00053E58
		// (set) Token: 0x060010A6 RID: 4262 RVA: 0x00007BCC File Offset: 0x00005DCC
		public unsafe FileStream fileStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdDownloadHandlerFile.NativeFieldInfoPtr_fileStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FileStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdDownloadHandlerFile.NativeFieldInfoPtr_fileStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060010A7 RID: 4263 RVA: 0x00055C88 File Offset: 0x00053E88
		// (set) Token: 0x060010A8 RID: 4264 RVA: 0x00007BEB File Offset: 0x00005DEB
		public unsafe long maximumFileSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdDownloadHandlerFile.NativeFieldInfoPtr_maximumFileSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdDownloadHandlerFile.NativeFieldInfoPtr_maximumFileSize)) = value;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060010A9 RID: 4265 RVA: 0x00055CB0 File Offset: 0x00053EB0
		// (set) Token: 0x060010AA RID: 4266 RVA: 0x00007C06 File Offset: 0x00005E06
		public unsafe long initialBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdDownloadHandlerFile.NativeFieldInfoPtr_initialBytes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdDownloadHandlerFile.NativeFieldInfoPtr_initialBytes)) = value;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060010AB RID: 4267 RVA: 0x00055CD8 File Offset: 0x00053ED8
		// (set) Token: 0x060010AC RID: 4268 RVA: 0x00007C21 File Offset: 0x00005E21
		public ErrorInfo internalStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdDownloadHandlerFile.NativeFieldInfoPtr_internalStatus);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdDownloadHandlerFile.NativeFieldInfoPtr_internalStatus), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000BD0 RID: 3024
		private static readonly IntPtr NativeFieldInfoPtr_fileStream;

		// Token: 0x04000BD1 RID: 3025
		private static readonly IntPtr NativeFieldInfoPtr_maximumFileSize;

		// Token: 0x04000BD2 RID: 3026
		private static readonly IntPtr NativeFieldInfoPtr_initialBytes;

		// Token: 0x04000BD3 RID: 3027
		private static readonly IntPtr NativeFieldInfoPtr_internalStatus;

		// Token: 0x04000BD4 RID: 3028
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_Virtual_get_ErrorInfo_0;

		// Token: 0x04000BD5 RID: 3029
		private static readonly IntPtr NativeMethodInfoPtr_get_HasData_Public_Virtual_get_Boolean_0;

		// Token: 0x04000BD6 RID: 3030
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FileStream_Int64_0;

		// Token: 0x04000BD7 RID: 3031
		private static readonly IntPtr NativeMethodInfoPtr_GetProgress_Protected_Virtual_Single_0;

		// Token: 0x04000BD8 RID: 3032
		private static readonly IntPtr NativeMethodInfoPtr_getData_Protected_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000BD9 RID: 3033
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveContentLength_Protected_Virtual_Void_Int32_0;

		// Token: 0x04000BDA RID: 3034
		private static readonly IntPtr NativeMethodInfoPtr_receiveData_Protected_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x020002CA RID: 714
		public enum ErrorCodes
		{
			// Token: 0x0400171D RID: 5917
			ContentTooLarge = 800851
		}
	}
}

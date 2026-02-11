using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200022E RID: 558
	public class CryptoStream : Stream
	{
		// Token: 0x060024F2 RID: 9458 RVA: 0x000CCC68 File Offset: 0x000CAE68
		// Note: this type is marked as 'beforefieldinit'.
		static CryptoStream()
		{
			Il2CppClassPointerStore<CryptoStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "CryptoStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr);
			CryptoStream.NativeFieldInfoPtr__stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_stream");
			CryptoStream.NativeFieldInfoPtr__transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_transform");
			CryptoStream.NativeFieldInfoPtr__transformMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_transformMode");
			CryptoStream.NativeFieldInfoPtr__inputBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_inputBuffer");
			CryptoStream.NativeFieldInfoPtr__inputBufferIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_inputBufferIndex");
			CryptoStream.NativeFieldInfoPtr__inputBlockSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_inputBlockSize");
			CryptoStream.NativeFieldInfoPtr__outputBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_outputBuffer");
			CryptoStream.NativeFieldInfoPtr__outputBufferIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_outputBufferIndex");
			CryptoStream.NativeFieldInfoPtr__outputBlockSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_outputBlockSize");
			CryptoStream.NativeFieldInfoPtr__canRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_canRead");
			CryptoStream.NativeFieldInfoPtr__canWrite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_canWrite");
			CryptoStream.NativeFieldInfoPtr__finalBlockTransformed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_finalBlockTransformed");
			CryptoStream.NativeFieldInfoPtr__lazyAsyncActiveSemaphore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_lazyAsyncActiveSemaphore");
			CryptoStream.NativeFieldInfoPtr__leaveOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "_leaveOpen");
			CryptoStream.NativeMethodInfoPtr__ctor_Public_Void_Stream_ICryptoTransform_CryptoStreamMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100669488);
			CryptoStream.NativeMethodInfoPtr__ctor_Public_Void_Stream_ICryptoTransform_CryptoStreamMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100669489);
			CryptoStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100669490);
			CryptoStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100669491);
			CryptoStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100669492);
			CryptoStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100669493);
			CryptoStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100669494);
			CryptoStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100669495);
			CryptoStream.NativeMethodInfoPtr_get_HasFlushedFinalBlock_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100669496);
			CryptoStream.NativeMethodInfoPtr_FlushFinalBlock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100669497);
			CryptoStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100669498);
			CryptoStream.NativeMethodInfoPtr_FlushAsync_Public_Virtual_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100669499);
			CryptoStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100669500);
			CryptoStream.NativeMethodInfoPtr_SetLength_Public_Virtual_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100669501);
			CryptoStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100669502);
			CryptoStream.NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100669503);
			CryptoStream.NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100669504);
			CryptoStream.NativeMethodInfoPtr_ReadAsyncInternal_Private_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100669505);
			CryptoStream.NativeMethodInfoPtr_ReadByte_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100669506);
			CryptoStream.NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100669507);
			CryptoStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100669508);
			CryptoStream.NativeMethodInfoPtr_CheckReadArguments_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100669509);
			CryptoStream.NativeMethodInfoPtr_ReadAsyncCore_Private_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100669510);
			CryptoStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100669511);
			CryptoStream.NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100669512);
			CryptoStream.NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100669513);
			CryptoStream.NativeMethodInfoPtr_WriteAsyncInternal_Private_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100669514);
			CryptoStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100669515);
			CryptoStream.NativeMethodInfoPtr_CheckWriteArguments_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100669516);
			CryptoStream.NativeMethodInfoPtr_WriteAsyncCore_Private_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100669517);
			CryptoStream.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100669518);
			CryptoStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100669519);
			CryptoStream.NativeMethodInfoPtr_InitializeBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100669520);
			CryptoStream.NativeMethodInfoPtr_get_AsyncActiveSemaphore_Private_get_SemaphoreSlim_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, 100669521);
		}

		// Token: 0x060024F3 RID: 9459 RVA: 0x000CD058 File Offset: 0x000CB258
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1371034, RefRangeEnd = 1371039, XrefRangeStart = 1371033, XrefRangeEnd = 1371034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CryptoStream(Stream stream, ICryptoTransform transform, CryptoStreamMode mode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transform);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.NativeMethodInfoPtr__ctor_Public_Void_Stream_ICryptoTransform_CryptoStreamMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024F4 RID: 9460 RVA: 0x000CD0C4 File Offset: 0x000CB2C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1371062, RefRangeEnd = 1371063, XrefRangeStart = 1371039, XrefRangeEnd = 1371062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CryptoStream(Stream stream, ICryptoTransform transform, CryptoStreamMode mode, bool leaveOpen)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transform);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveOpen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.NativeMethodInfoPtr__ctor_Public_Void_Stream_ICryptoTransform_CryptoStreamMode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x060024F5 RID: 9461 RVA: 0x000CD140 File Offset: 0x000CB340
		public unsafe override bool CanRead
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x060024F6 RID: 9462 RVA: 0x000CD188 File Offset: 0x000CB388
		public unsafe override bool CanSeek
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x060024F7 RID: 9463 RVA: 0x000CD1D0 File Offset: 0x000CB3D0
		public unsafe override bool CanWrite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x060024F8 RID: 9464 RVA: 0x000CD218 File Offset: 0x000CB418
		public unsafe override long Length
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371063, XrefRangeEnd = 1371069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x060024F9 RID: 9465 RVA: 0x000CD260 File Offset: 0x000CB460
		// (set) Token: 0x060024FA RID: 9466 RVA: 0x000CD2A8 File Offset: 0x000CB4A8
		public unsafe override long Position
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371069, XrefRangeEnd = 1371075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371075, XrefRangeEnd = 1371081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x060024FB RID: 9467 RVA: 0x000CD2F4 File Offset: 0x000CB4F4
		public unsafe bool HasFlushedFinalBlock
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.NativeMethodInfoPtr_get_HasFlushedFinalBlock_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060024FC RID: 9468 RVA: 0x000CD330 File Offset: 0x000CB530
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1371092, RefRangeEnd = 1371096, XrefRangeStart = 1371081, XrefRangeEnd = 1371092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FlushFinalBlock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.NativeMethodInfoPtr_FlushFinalBlock_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024FD RID: 9469 RVA: 0x000CD364 File Offset: 0x000CB564
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x000CD3A0 File Offset: 0x000CB5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371096, XrefRangeEnd = 1371112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task FlushAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_FlushAsync_Public_Virtual_Task_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x060024FF RID: 9471 RVA: 0x000CD400 File Offset: 0x000CB600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371112, XrefRangeEnd = 1371118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long Seek(long offset, SeekOrigin origin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002500 RID: 9472 RVA: 0x000CD464 File Offset: 0x000CB664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371118, XrefRangeEnd = 1371124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetLength(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_SetLength_Public_Virtual_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002501 RID: 9473 RVA: 0x000CD4B0 File Offset: 0x000CB6B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371124, XrefRangeEnd = 1371141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<int> ReadAsync(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x06002502 RID: 9474 RVA: 0x000CD540 File Offset: 0x000CB740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371141, XrefRangeEnd = 1371146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IAsyncResult BeginRead(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002503 RID: 9475 RVA: 0x000CD5E0 File Offset: 0x000CB7E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371146, XrefRangeEnd = 1371149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int EndRead(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002504 RID: 9476 RVA: 0x000CD638 File Offset: 0x000CB838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371149, XrefRangeEnd = 1371165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<int> ReadAsyncInternal(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.NativeMethodInfoPtr_ReadAsyncInternal_Private_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x06002505 RID: 9477 RVA: 0x000CD6BC File Offset: 0x000CB8BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371165, XrefRangeEnd = 1371167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ReadByte()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_ReadByte_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002506 RID: 9478 RVA: 0x000CD704 File Offset: 0x000CB904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371167, XrefRangeEnd = 1371168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteByte(byte value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002507 RID: 9479 RVA: 0x000CD750 File Offset: 0x000CB950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371168, XrefRangeEnd = 1371191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read(Il2CppStructArray<byte> buffer, int offset, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x000CD7C4 File Offset: 0x000CB9C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1371191, RefRangeEnd = 1371193, XrefRangeStart = 1371191, XrefRangeEnd = 1371191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckReadArguments(Il2CppStructArray<byte> buffer, int offset, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.NativeMethodInfoPtr_CheckReadArguments_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002509 RID: 9481 RVA: 0x000CD824 File Offset: 0x000CBA24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1371209, RefRangeEnd = 1371210, XrefRangeStart = 1371193, XrefRangeEnd = 1371209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<int> ReadAsyncCore(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken, bool useAsync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useAsync;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.NativeMethodInfoPtr_ReadAsyncCore_Private_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x0600250A RID: 9482 RVA: 0x000CD8B8 File Offset: 0x000CBAB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371210, XrefRangeEnd = 1371223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task WriteAsync(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600250B RID: 9483 RVA: 0x000CD948 File Offset: 0x000CBB48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371223, XrefRangeEnd = 1371228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IAsyncResult BeginWrite(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600250C RID: 9484 RVA: 0x000CD9E8 File Offset: 0x000CBBE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EndWrite(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600250D RID: 9485 RVA: 0x000CDA38 File Offset: 0x000CBC38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371228, XrefRangeEnd = 1371240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task WriteAsyncInternal(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.NativeMethodInfoPtr_WriteAsyncInternal_Private_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600250E RID: 9486 RVA: 0x000CDABC File Offset: 0x000CBCBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371240, XrefRangeEnd = 1371255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600250F RID: 9487 RVA: 0x000CDB28 File Offset: 0x000CBD28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1371255, RefRangeEnd = 1371257, XrefRangeStart = 1371255, XrefRangeEnd = 1371255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckWriteArguments(Il2CppStructArray<byte> buffer, int offset, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.NativeMethodInfoPtr_CheckWriteArguments_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002510 RID: 9488 RVA: 0x000CDB88 File Offset: 0x000CBD88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1371269, RefRangeEnd = 1371270, XrefRangeStart = 1371257, XrefRangeEnd = 1371269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task WriteAsyncCore(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken, bool useAsync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useAsync;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.NativeMethodInfoPtr_WriteAsyncCore_Private_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002511 RID: 9489 RVA: 0x000CDC1C File Offset: 0x000CBE1C
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 873163, RefRangeEnd = 873182, XrefRangeStart = 873163, XrefRangeEnd = 873182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002512 RID: 9490 RVA: 0x000CDC50 File Offset: 0x000CBE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371270, XrefRangeEnd = 1371275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CryptoStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002513 RID: 9491 RVA: 0x000CDC9C File Offset: 0x000CBE9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371275, XrefRangeEnd = 1371287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.NativeMethodInfoPtr_InitializeBuffer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06002514 RID: 9492 RVA: 0x000CDCD0 File Offset: 0x000CBED0
		public unsafe SemaphoreSlim AsyncActiveSemaphore
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1371305, RefRangeEnd = 1371307, XrefRangeStart = 1371287, XrefRangeEnd = 1371305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.NativeMethodInfoPtr_get_AsyncActiveSemaphore_Private_get_SemaphoreSlim_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim>(intPtr3) : null;
			}
		}

		// Token: 0x06002515 RID: 9493 RVA: 0x0000BEF7 File Offset: 0x0000A0F7
		public CryptoStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06002516 RID: 9494 RVA: 0x000CDD10 File Offset: 0x000CBF10
		// (set) Token: 0x06002517 RID: 9495 RVA: 0x0000BF00 File Offset: 0x0000A100
		public unsafe Stream _stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06002518 RID: 9496 RVA: 0x000CDD40 File Offset: 0x000CBF40
		// (set) Token: 0x06002519 RID: 9497 RVA: 0x0000BF1F File Offset: 0x0000A11F
		public unsafe ICryptoTransform _transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICryptoTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x0600251A RID: 9498 RVA: 0x000CDD70 File Offset: 0x000CBF70
		// (set) Token: 0x0600251B RID: 9499 RVA: 0x0000BF3E File Offset: 0x0000A13E
		public unsafe CryptoStreamMode _transformMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__transformMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__transformMode)) = value;
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x0600251C RID: 9500 RVA: 0x000CDD98 File Offset: 0x000CBF98
		// (set) Token: 0x0600251D RID: 9501 RVA: 0x0000BF59 File Offset: 0x0000A159
		public unsafe Il2CppStructArray<byte> _inputBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__inputBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__inputBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x0600251E RID: 9502 RVA: 0x000CDDC8 File Offset: 0x000CBFC8
		// (set) Token: 0x0600251F RID: 9503 RVA: 0x0000BF78 File Offset: 0x0000A178
		public unsafe int _inputBufferIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__inputBufferIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__inputBufferIndex)) = value;
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06002520 RID: 9504 RVA: 0x000CDDF0 File Offset: 0x000CBFF0
		// (set) Token: 0x06002521 RID: 9505 RVA: 0x0000BF93 File Offset: 0x0000A193
		public unsafe int _inputBlockSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__inputBlockSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__inputBlockSize)) = value;
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06002522 RID: 9506 RVA: 0x000CDE18 File Offset: 0x000CC018
		// (set) Token: 0x06002523 RID: 9507 RVA: 0x0000BFAE File Offset: 0x0000A1AE
		public unsafe Il2CppStructArray<byte> _outputBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__outputBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__outputBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06002524 RID: 9508 RVA: 0x000CDE48 File Offset: 0x000CC048
		// (set) Token: 0x06002525 RID: 9509 RVA: 0x0000BFCD File Offset: 0x0000A1CD
		public unsafe int _outputBufferIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__outputBufferIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__outputBufferIndex)) = value;
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06002526 RID: 9510 RVA: 0x000CDE70 File Offset: 0x000CC070
		// (set) Token: 0x06002527 RID: 9511 RVA: 0x0000BFE8 File Offset: 0x0000A1E8
		public unsafe int _outputBlockSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__outputBlockSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__outputBlockSize)) = value;
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06002528 RID: 9512 RVA: 0x000CDE98 File Offset: 0x000CC098
		// (set) Token: 0x06002529 RID: 9513 RVA: 0x0000C003 File Offset: 0x0000A203
		public unsafe bool _canRead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__canRead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__canRead)) = value;
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x0600252A RID: 9514 RVA: 0x000CDEC0 File Offset: 0x000CC0C0
		// (set) Token: 0x0600252B RID: 9515 RVA: 0x0000C01E File Offset: 0x0000A21E
		public unsafe bool _canWrite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__canWrite);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__canWrite)) = value;
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x0600252C RID: 9516 RVA: 0x000CDEE8 File Offset: 0x000CC0E8
		// (set) Token: 0x0600252D RID: 9517 RVA: 0x0000C039 File Offset: 0x0000A239
		public unsafe bool _finalBlockTransformed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__finalBlockTransformed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__finalBlockTransformed)) = value;
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x0600252E RID: 9518 RVA: 0x000CDF10 File Offset: 0x000CC110
		// (set) Token: 0x0600252F RID: 9519 RVA: 0x0000C054 File Offset: 0x0000A254
		public unsafe SemaphoreSlim _lazyAsyncActiveSemaphore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__lazyAsyncActiveSemaphore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__lazyAsyncActiveSemaphore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06002530 RID: 9520 RVA: 0x000CDF40 File Offset: 0x000CC140
		// (set) Token: 0x06002531 RID: 9521 RVA: 0x0000C073 File Offset: 0x0000A273
		public unsafe bool _leaveOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__leaveOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream.NativeFieldInfoPtr__leaveOpen)) = value;
			}
		}

		// Token: 0x0400202C RID: 8236
		private static readonly IntPtr NativeFieldInfoPtr__stream;

		// Token: 0x0400202D RID: 8237
		private static readonly IntPtr NativeFieldInfoPtr__transform;

		// Token: 0x0400202E RID: 8238
		private static readonly IntPtr NativeFieldInfoPtr__transformMode;

		// Token: 0x0400202F RID: 8239
		private static readonly IntPtr NativeFieldInfoPtr__inputBuffer;

		// Token: 0x04002030 RID: 8240
		private static readonly IntPtr NativeFieldInfoPtr__inputBufferIndex;

		// Token: 0x04002031 RID: 8241
		private static readonly IntPtr NativeFieldInfoPtr__inputBlockSize;

		// Token: 0x04002032 RID: 8242
		private static readonly IntPtr NativeFieldInfoPtr__outputBuffer;

		// Token: 0x04002033 RID: 8243
		private static readonly IntPtr NativeFieldInfoPtr__outputBufferIndex;

		// Token: 0x04002034 RID: 8244
		private static readonly IntPtr NativeFieldInfoPtr__outputBlockSize;

		// Token: 0x04002035 RID: 8245
		private static readonly IntPtr NativeFieldInfoPtr__canRead;

		// Token: 0x04002036 RID: 8246
		private static readonly IntPtr NativeFieldInfoPtr__canWrite;

		// Token: 0x04002037 RID: 8247
		private static readonly IntPtr NativeFieldInfoPtr__finalBlockTransformed;

		// Token: 0x04002038 RID: 8248
		private static readonly IntPtr NativeFieldInfoPtr__lazyAsyncActiveSemaphore;

		// Token: 0x04002039 RID: 8249
		private static readonly IntPtr NativeFieldInfoPtr__leaveOpen;

		// Token: 0x0400203A RID: 8250
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_ICryptoTransform_CryptoStreamMode_0;

		// Token: 0x0400203B RID: 8251
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_ICryptoTransform_CryptoStreamMode_Boolean_0;

		// Token: 0x0400203C RID: 8252
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0;

		// Token: 0x0400203D RID: 8253
		private static readonly IntPtr NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0;

		// Token: 0x0400203E RID: 8254
		private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0;

		// Token: 0x0400203F RID: 8255
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0;

		// Token: 0x04002040 RID: 8256
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0;

		// Token: 0x04002041 RID: 8257
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0;

		// Token: 0x04002042 RID: 8258
		private static readonly IntPtr NativeMethodInfoPtr_get_HasFlushedFinalBlock_Public_get_Boolean_0;

		// Token: 0x04002043 RID: 8259
		private static readonly IntPtr NativeMethodInfoPtr_FlushFinalBlock_Public_Void_0;

		// Token: 0x04002044 RID: 8260
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

		// Token: 0x04002045 RID: 8261
		private static readonly IntPtr NativeMethodInfoPtr_FlushAsync_Public_Virtual_Task_CancellationToken_0;

		// Token: 0x04002046 RID: 8262
		private static readonly IntPtr NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0;

		// Token: 0x04002047 RID: 8263
		private static readonly IntPtr NativeMethodInfoPtr_SetLength_Public_Virtual_Void_Int64_0;

		// Token: 0x04002048 RID: 8264
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04002049 RID: 8265
		private static readonly IntPtr NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x0400204A RID: 8266
		private static readonly IntPtr NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0;

		// Token: 0x0400204B RID: 8267
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsyncInternal_Private_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x0400204C RID: 8268
		private static readonly IntPtr NativeMethodInfoPtr_ReadByte_Public_Virtual_Int32_0;

		// Token: 0x0400204D RID: 8269
		private static readonly IntPtr NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0;

		// Token: 0x0400204E RID: 8270
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400204F RID: 8271
		private static readonly IntPtr NativeMethodInfoPtr_CheckReadArguments_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002050 RID: 8272
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsyncCore_Private_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_Boolean_0;

		// Token: 0x04002051 RID: 8273
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04002052 RID: 8274
		private static readonly IntPtr NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x04002053 RID: 8275
		private static readonly IntPtr NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0;

		// Token: 0x04002054 RID: 8276
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsyncInternal_Private_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04002055 RID: 8277
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002056 RID: 8278
		private static readonly IntPtr NativeMethodInfoPtr_CheckWriteArguments_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002057 RID: 8279
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsyncCore_Private_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_Boolean_0;

		// Token: 0x04002058 RID: 8280
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04002059 RID: 8281
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x0400205A RID: 8282
		private static readonly IntPtr NativeMethodInfoPtr_InitializeBuffer_Private_Void_0;

		// Token: 0x0400205B RID: 8283
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncActiveSemaphore_Private_get_SemaphoreSlim_0;

		// Token: 0x02000660 RID: 1632
		[ObfuscatedName("System.Security.Cryptography.CryptoStream+<ReadAsyncInternal>d__37")]
		public sealed class _ReadAsyncInternal_d__37 : ValueType
		{
			// Token: 0x06005A84 RID: 23172 RVA: 0x0019D994 File Offset: 0x0019BB94
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadAsyncInternal_d__37()
			{
				Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__37>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "<ReadAsyncInternal>d__37");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__37>.NativeClassPtr);
				CryptoStream._ReadAsyncInternal_d__37.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__37>.NativeClassPtr, "<>1__state");
				CryptoStream._ReadAsyncInternal_d__37.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__37>.NativeClassPtr, "<>t__builder");
				CryptoStream._ReadAsyncInternal_d__37.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__37>.NativeClassPtr, "<>4__this");
				CryptoStream._ReadAsyncInternal_d__37.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__37>.NativeClassPtr, "buffer");
				CryptoStream._ReadAsyncInternal_d__37.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__37>.NativeClassPtr, "offset");
				CryptoStream._ReadAsyncInternal_d__37.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__37>.NativeClassPtr, "count");
				CryptoStream._ReadAsyncInternal_d__37.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__37>.NativeClassPtr, "cancellationToken");
				CryptoStream._ReadAsyncInternal_d__37.NativeFieldInfoPtr__semaphore_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__37>.NativeClassPtr, "<semaphore>5__2");
				CryptoStream._ReadAsyncInternal_d__37.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__37>.NativeClassPtr, "<>u__1");
				CryptoStream._ReadAsyncInternal_d__37.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__37>.NativeClassPtr, "<>u__2");
				CryptoStream._ReadAsyncInternal_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__37>.NativeClassPtr, 100669522);
				CryptoStream._ReadAsyncInternal_d__37.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__37>.NativeClassPtr, 100669523);
			}

			// Token: 0x06005A85 RID: 23173 RVA: 0x0019DAB0 File Offset: 0x0019BCB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370688, XrefRangeEnd = 1370723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream._ReadAsyncInternal_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005A86 RID: 23174 RVA: 0x0019DAE8 File Offset: 0x0019BCE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370723, XrefRangeEnd = 1370729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream._ReadAsyncInternal_d__37.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005A87 RID: 23175 RVA: 0x000207FA File Offset: 0x0001E9FA
			public _ReadAsyncInternal_d__37(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005A88 RID: 23176 RVA: 0x00020803 File Offset: 0x0001EA03
			public _ReadAsyncInternal_d__37()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CryptoStream._ReadAsyncInternal_d__37>.NativeClassPtr))
			{
			}

			// Token: 0x1700171D RID: 5917
			// (get) Token: 0x06005A89 RID: 23177 RVA: 0x0019DB30 File Offset: 0x0019BD30
			// (set) Token: 0x06005A8A RID: 23178 RVA: 0x00020815 File Offset: 0x0001EA15
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__37.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__37.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700171E RID: 5918
			// (get) Token: 0x06005A8B RID: 23179 RVA: 0x0019DB58 File Offset: 0x0019BD58
			// (set) Token: 0x06005A8C RID: 23180 RVA: 0x00020830 File Offset: 0x0001EA30
			public AsyncTaskMethodBuilder<int> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__37.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__37.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700171F RID: 5919
			// (get) Token: 0x06005A8D RID: 23181 RVA: 0x0019DB88 File Offset: 0x0019BD88
			// (set) Token: 0x06005A8E RID: 23182 RVA: 0x0002085E File Offset: 0x0001EA5E
			public unsafe CryptoStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__37.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CryptoStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__37.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001720 RID: 5920
			// (get) Token: 0x06005A8F RID: 23183 RVA: 0x0019DBB8 File Offset: 0x0019BDB8
			// (set) Token: 0x06005A90 RID: 23184 RVA: 0x0002087D File Offset: 0x0001EA7D
			public unsafe Il2CppStructArray<byte> buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__37.NativeFieldInfoPtr_buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__37.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001721 RID: 5921
			// (get) Token: 0x06005A91 RID: 23185 RVA: 0x0019DBE8 File Offset: 0x0019BDE8
			// (set) Token: 0x06005A92 RID: 23186 RVA: 0x0002089C File Offset: 0x0001EA9C
			public unsafe int offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__37.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__37.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x17001722 RID: 5922
			// (get) Token: 0x06005A93 RID: 23187 RVA: 0x0019DC10 File Offset: 0x0019BE10
			// (set) Token: 0x06005A94 RID: 23188 RVA: 0x000208B7 File Offset: 0x0001EAB7
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__37.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__37.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x17001723 RID: 5923
			// (get) Token: 0x06005A95 RID: 23189 RVA: 0x0019DC38 File Offset: 0x0019BE38
			// (set) Token: 0x06005A96 RID: 23190 RVA: 0x000208D2 File Offset: 0x0001EAD2
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__37.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__37.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001724 RID: 5924
			// (get) Token: 0x06005A97 RID: 23191 RVA: 0x0019DC68 File Offset: 0x0019BE68
			// (set) Token: 0x06005A98 RID: 23192 RVA: 0x00020900 File Offset: 0x0001EB00
			public unsafe SemaphoreSlim _semaphore_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__37.NativeFieldInfoPtr__semaphore_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__37.NativeFieldInfoPtr__semaphore_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001725 RID: 5925
			// (get) Token: 0x06005A99 RID: 23193 RVA: 0x0019DC98 File Offset: 0x0019BE98
			// (set) Token: 0x06005A9A RID: 23194 RVA: 0x0002091F File Offset: 0x0001EB1F
			public ForceAsyncAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__37.NativeFieldInfoPtr___u__1);
					return new ForceAsyncAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForceAsyncAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__37.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ForceAsyncAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001726 RID: 5926
			// (get) Token: 0x06005A9B RID: 23195 RVA: 0x0019DCC8 File Offset: 0x0019BEC8
			// (set) Token: 0x06005A9C RID: 23196 RVA: 0x0002094D File Offset: 0x0001EB4D
			public TaskAwaiter<int> __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__37.NativeFieldInfoPtr___u__2);
					return new TaskAwaiter<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncInternal_d__37.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04004A04 RID: 18948
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004A05 RID: 18949
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04004A06 RID: 18950
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004A07 RID: 18951
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x04004A08 RID: 18952
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x04004A09 RID: 18953
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x04004A0A RID: 18954
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04004A0B RID: 18955
			private static readonly IntPtr NativeFieldInfoPtr__semaphore_5__2;

			// Token: 0x04004A0C RID: 18956
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04004A0D RID: 18957
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04004A0E RID: 18958
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004A0F RID: 18959
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000661 RID: 1633
		[ObfuscatedName("System.Security.Cryptography.CryptoStream+<ReadAsyncCore>d__42")]
		public sealed class _ReadAsyncCore_d__42 : ValueType
		{
			// Token: 0x06005A9D RID: 23197 RVA: 0x0019DCF8 File Offset: 0x0019BEF8
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadAsyncCore_d__42()
			{
				Il2CppClassPointerStore<CryptoStream._ReadAsyncCore_d__42>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "<ReadAsyncCore>d__42");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CryptoStream._ReadAsyncCore_d__42>.NativeClassPtr);
				CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncCore_d__42>.NativeClassPtr, "<>1__state");
				CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncCore_d__42>.NativeClassPtr, "<>t__builder");
				CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncCore_d__42>.NativeClassPtr, "count");
				CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncCore_d__42>.NativeClassPtr, "offset");
				CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncCore_d__42>.NativeClassPtr, "<>4__this");
				CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncCore_d__42>.NativeClassPtr, "buffer");
				CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr_useAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncCore_d__42>.NativeClassPtr, "useAsync");
				CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncCore_d__42>.NativeClassPtr, "cancellationToken");
				CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr__bytesToDeliver_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncCore_d__42>.NativeClassPtr, "<bytesToDeliver>5__2");
				CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr__currentOutputIndex_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncCore_d__42>.NativeClassPtr, "<currentOutputIndex>5__3");
				CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr__numWholeBlocksInBytes_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncCore_d__42>.NativeClassPtr, "<numWholeBlocksInBytes>5__4");
				CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr__tempInputBuffer_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncCore_d__42>.NativeClassPtr, "<tempInputBuffer>5__5");
				CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr__tempOutputBuffer_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncCore_d__42>.NativeClassPtr, "<tempOutputBuffer>5__6");
				CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._ReadAsyncCore_d__42>.NativeClassPtr, "<>u__1");
				CryptoStream._ReadAsyncCore_d__42.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream._ReadAsyncCore_d__42>.NativeClassPtr, 100669524);
				CryptoStream._ReadAsyncCore_d__42.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream._ReadAsyncCore_d__42>.NativeClassPtr, 100669525);
			}

			// Token: 0x06005A9E RID: 23198 RVA: 0x0019DE64 File Offset: 0x0019C064
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370729, XrefRangeEnd = 1370858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream._ReadAsyncCore_d__42.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005A9F RID: 23199 RVA: 0x0019DE9C File Offset: 0x0019C09C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370858, XrefRangeEnd = 1370864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream._ReadAsyncCore_d__42.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005AA0 RID: 23200 RVA: 0x0002097B File Offset: 0x0001EB7B
			public _ReadAsyncCore_d__42(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005AA1 RID: 23201 RVA: 0x00020984 File Offset: 0x0001EB84
			public _ReadAsyncCore_d__42()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CryptoStream._ReadAsyncCore_d__42>.NativeClassPtr))
			{
			}

			// Token: 0x17001727 RID: 5927
			// (get) Token: 0x06005AA2 RID: 23202 RVA: 0x0019DEE4 File Offset: 0x0019C0E4
			// (set) Token: 0x06005AA3 RID: 23203 RVA: 0x00020996 File Offset: 0x0001EB96
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001728 RID: 5928
			// (get) Token: 0x06005AA4 RID: 23204 RVA: 0x0019DF0C File Offset: 0x0019C10C
			// (set) Token: 0x06005AA5 RID: 23205 RVA: 0x000209B1 File Offset: 0x0001EBB1
			public AsyncTaskMethodBuilder<int> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001729 RID: 5929
			// (get) Token: 0x06005AA6 RID: 23206 RVA: 0x0019DF3C File Offset: 0x0019C13C
			// (set) Token: 0x06005AA7 RID: 23207 RVA: 0x000209DF File Offset: 0x0001EBDF
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x1700172A RID: 5930
			// (get) Token: 0x06005AA8 RID: 23208 RVA: 0x0019DF64 File Offset: 0x0019C164
			// (set) Token: 0x06005AA9 RID: 23209 RVA: 0x000209FA File Offset: 0x0001EBFA
			public unsafe int offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x1700172B RID: 5931
			// (get) Token: 0x06005AAA RID: 23210 RVA: 0x0019DF8C File Offset: 0x0019C18C
			// (set) Token: 0x06005AAB RID: 23211 RVA: 0x00020A15 File Offset: 0x0001EC15
			public unsafe CryptoStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CryptoStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700172C RID: 5932
			// (get) Token: 0x06005AAC RID: 23212 RVA: 0x0019DFBC File Offset: 0x0019C1BC
			// (set) Token: 0x06005AAD RID: 23213 RVA: 0x00020A34 File Offset: 0x0001EC34
			public unsafe Il2CppStructArray<byte> buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr_buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700172D RID: 5933
			// (get) Token: 0x06005AAE RID: 23214 RVA: 0x0019DFEC File Offset: 0x0019C1EC
			// (set) Token: 0x06005AAF RID: 23215 RVA: 0x00020A53 File Offset: 0x0001EC53
			public unsafe bool useAsync
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr_useAsync);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr_useAsync)) = value;
				}
			}

			// Token: 0x1700172E RID: 5934
			// (get) Token: 0x06005AB0 RID: 23216 RVA: 0x0019E014 File Offset: 0x0019C214
			// (set) Token: 0x06005AB1 RID: 23217 RVA: 0x00020A6E File Offset: 0x0001EC6E
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700172F RID: 5935
			// (get) Token: 0x06005AB2 RID: 23218 RVA: 0x0019E044 File Offset: 0x0019C244
			// (set) Token: 0x06005AB3 RID: 23219 RVA: 0x00020A9C File Offset: 0x0001EC9C
			public unsafe int _bytesToDeliver_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr__bytesToDeliver_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr__bytesToDeliver_5__2)) = value;
				}
			}

			// Token: 0x17001730 RID: 5936
			// (get) Token: 0x06005AB4 RID: 23220 RVA: 0x0019E06C File Offset: 0x0019C26C
			// (set) Token: 0x06005AB5 RID: 23221 RVA: 0x00020AB7 File Offset: 0x0001ECB7
			public unsafe int _currentOutputIndex_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr__currentOutputIndex_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr__currentOutputIndex_5__3)) = value;
				}
			}

			// Token: 0x17001731 RID: 5937
			// (get) Token: 0x06005AB6 RID: 23222 RVA: 0x0019E094 File Offset: 0x0019C294
			// (set) Token: 0x06005AB7 RID: 23223 RVA: 0x00020AD2 File Offset: 0x0001ECD2
			public unsafe int _numWholeBlocksInBytes_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr__numWholeBlocksInBytes_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr__numWholeBlocksInBytes_5__4)) = value;
				}
			}

			// Token: 0x17001732 RID: 5938
			// (get) Token: 0x06005AB8 RID: 23224 RVA: 0x0019E0BC File Offset: 0x0019C2BC
			// (set) Token: 0x06005AB9 RID: 23225 RVA: 0x00020AED File Offset: 0x0001ECED
			public unsafe Il2CppStructArray<byte> _tempInputBuffer_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr__tempInputBuffer_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr__tempInputBuffer_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001733 RID: 5939
			// (get) Token: 0x06005ABA RID: 23226 RVA: 0x0019E0EC File Offset: 0x0019C2EC
			// (set) Token: 0x06005ABB RID: 23227 RVA: 0x00020B0C File Offset: 0x0001ED0C
			public unsafe Il2CppStructArray<byte> _tempOutputBuffer_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr__tempOutputBuffer_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr__tempOutputBuffer_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001734 RID: 5940
			// (get) Token: 0x06005ABC RID: 23228 RVA: 0x0019E11C File Offset: 0x0019C31C
			// (set) Token: 0x06005ABD RID: 23229 RVA: 0x00020B2B File Offset: 0x0001ED2B
			public ValueTaskAwaiter<int> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr___u__1);
					return new ValueTaskAwaiter<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTaskAwaiter<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._ReadAsyncCore_d__42.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTaskAwaiter<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04004A10 RID: 18960
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004A11 RID: 18961
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04004A12 RID: 18962
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x04004A13 RID: 18963
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x04004A14 RID: 18964
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004A15 RID: 18965
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x04004A16 RID: 18966
			private static readonly IntPtr NativeFieldInfoPtr_useAsync;

			// Token: 0x04004A17 RID: 18967
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04004A18 RID: 18968
			private static readonly IntPtr NativeFieldInfoPtr__bytesToDeliver_5__2;

			// Token: 0x04004A19 RID: 18969
			private static readonly IntPtr NativeFieldInfoPtr__currentOutputIndex_5__3;

			// Token: 0x04004A1A RID: 18970
			private static readonly IntPtr NativeFieldInfoPtr__numWholeBlocksInBytes_5__4;

			// Token: 0x04004A1B RID: 18971
			private static readonly IntPtr NativeFieldInfoPtr__tempInputBuffer_5__5;

			// Token: 0x04004A1C RID: 18972
			private static readonly IntPtr NativeFieldInfoPtr__tempOutputBuffer_5__6;

			// Token: 0x04004A1D RID: 18973
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04004A1E RID: 18974
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004A1F RID: 18975
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000662 RID: 1634
		[ObfuscatedName("System.Security.Cryptography.CryptoStream+<WriteAsyncInternal>d__46")]
		public sealed class _WriteAsyncInternal_d__46 : ValueType
		{
			// Token: 0x06005ABE RID: 23230 RVA: 0x0019E14C File Offset: 0x0019C34C
			// Note: this type is marked as 'beforefieldinit'.
			static _WriteAsyncInternal_d__46()
			{
				Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__46>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "<WriteAsyncInternal>d__46");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__46>.NativeClassPtr);
				CryptoStream._WriteAsyncInternal_d__46.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__46>.NativeClassPtr, "<>1__state");
				CryptoStream._WriteAsyncInternal_d__46.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__46>.NativeClassPtr, "<>t__builder");
				CryptoStream._WriteAsyncInternal_d__46.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__46>.NativeClassPtr, "<>4__this");
				CryptoStream._WriteAsyncInternal_d__46.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__46>.NativeClassPtr, "buffer");
				CryptoStream._WriteAsyncInternal_d__46.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__46>.NativeClassPtr, "offset");
				CryptoStream._WriteAsyncInternal_d__46.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__46>.NativeClassPtr, "count");
				CryptoStream._WriteAsyncInternal_d__46.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__46>.NativeClassPtr, "cancellationToken");
				CryptoStream._WriteAsyncInternal_d__46.NativeFieldInfoPtr__semaphore_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__46>.NativeClassPtr, "<semaphore>5__2");
				CryptoStream._WriteAsyncInternal_d__46.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__46>.NativeClassPtr, "<>u__1");
				CryptoStream._WriteAsyncInternal_d__46.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__46>.NativeClassPtr, "<>u__2");
				CryptoStream._WriteAsyncInternal_d__46.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__46>.NativeClassPtr, 100669526);
				CryptoStream._WriteAsyncInternal_d__46.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__46>.NativeClassPtr, 100669527);
			}

			// Token: 0x06005ABF RID: 23231 RVA: 0x0019E268 File Offset: 0x0019C468
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370864, XrefRangeEnd = 1370900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream._WriteAsyncInternal_d__46.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005AC0 RID: 23232 RVA: 0x0019E2A0 File Offset: 0x0019C4A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370900, XrefRangeEnd = 1370904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream._WriteAsyncInternal_d__46.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005AC1 RID: 23233 RVA: 0x00020B59 File Offset: 0x0001ED59
			public _WriteAsyncInternal_d__46(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005AC2 RID: 23234 RVA: 0x00020B62 File Offset: 0x0001ED62
			public _WriteAsyncInternal_d__46()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CryptoStream._WriteAsyncInternal_d__46>.NativeClassPtr))
			{
			}

			// Token: 0x17001735 RID: 5941
			// (get) Token: 0x06005AC3 RID: 23235 RVA: 0x0019E2E8 File Offset: 0x0019C4E8
			// (set) Token: 0x06005AC4 RID: 23236 RVA: 0x00020B74 File Offset: 0x0001ED74
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__46.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__46.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001736 RID: 5942
			// (get) Token: 0x06005AC5 RID: 23237 RVA: 0x0019E310 File Offset: 0x0019C510
			// (set) Token: 0x06005AC6 RID: 23238 RVA: 0x00020B8F File Offset: 0x0001ED8F
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__46.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__46.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001737 RID: 5943
			// (get) Token: 0x06005AC7 RID: 23239 RVA: 0x0019E340 File Offset: 0x0019C540
			// (set) Token: 0x06005AC8 RID: 23240 RVA: 0x00020BBD File Offset: 0x0001EDBD
			public unsafe CryptoStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__46.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CryptoStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__46.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001738 RID: 5944
			// (get) Token: 0x06005AC9 RID: 23241 RVA: 0x0019E370 File Offset: 0x0019C570
			// (set) Token: 0x06005ACA RID: 23242 RVA: 0x00020BDC File Offset: 0x0001EDDC
			public unsafe Il2CppStructArray<byte> buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__46.NativeFieldInfoPtr_buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__46.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001739 RID: 5945
			// (get) Token: 0x06005ACB RID: 23243 RVA: 0x0019E3A0 File Offset: 0x0019C5A0
			// (set) Token: 0x06005ACC RID: 23244 RVA: 0x00020BFB File Offset: 0x0001EDFB
			public unsafe int offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__46.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__46.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x1700173A RID: 5946
			// (get) Token: 0x06005ACD RID: 23245 RVA: 0x0019E3C8 File Offset: 0x0019C5C8
			// (set) Token: 0x06005ACE RID: 23246 RVA: 0x00020C16 File Offset: 0x0001EE16
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__46.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__46.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x1700173B RID: 5947
			// (get) Token: 0x06005ACF RID: 23247 RVA: 0x0019E3F0 File Offset: 0x0019C5F0
			// (set) Token: 0x06005AD0 RID: 23248 RVA: 0x00020C31 File Offset: 0x0001EE31
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__46.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__46.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700173C RID: 5948
			// (get) Token: 0x06005AD1 RID: 23249 RVA: 0x0019E420 File Offset: 0x0019C620
			// (set) Token: 0x06005AD2 RID: 23250 RVA: 0x00020C5F File Offset: 0x0001EE5F
			public unsafe SemaphoreSlim _semaphore_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__46.NativeFieldInfoPtr__semaphore_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__46.NativeFieldInfoPtr__semaphore_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700173D RID: 5949
			// (get) Token: 0x06005AD3 RID: 23251 RVA: 0x0019E450 File Offset: 0x0019C650
			// (set) Token: 0x06005AD4 RID: 23252 RVA: 0x00020C7E File Offset: 0x0001EE7E
			public ForceAsyncAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__46.NativeFieldInfoPtr___u__1);
					return new ForceAsyncAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForceAsyncAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__46.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ForceAsyncAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700173E RID: 5950
			// (get) Token: 0x06005AD5 RID: 23253 RVA: 0x0019E480 File Offset: 0x0019C680
			// (set) Token: 0x06005AD6 RID: 23254 RVA: 0x00020CAC File Offset: 0x0001EEAC
			public TaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__46.NativeFieldInfoPtr___u__2);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncInternal_d__46.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04004A20 RID: 18976
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004A21 RID: 18977
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04004A22 RID: 18978
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004A23 RID: 18979
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x04004A24 RID: 18980
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x04004A25 RID: 18981
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x04004A26 RID: 18982
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04004A27 RID: 18983
			private static readonly IntPtr NativeFieldInfoPtr__semaphore_5__2;

			// Token: 0x04004A28 RID: 18984
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04004A29 RID: 18985
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04004A2A RID: 18986
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004A2B RID: 18987
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000663 RID: 1635
		[ObfuscatedName("System.Security.Cryptography.CryptoStream+<WriteAsyncCore>d__49")]
		public sealed class _WriteAsyncCore_d__49 : ValueType
		{
			// Token: 0x06005AD7 RID: 23255 RVA: 0x0019E4B0 File Offset: 0x0019C6B0
			// Note: this type is marked as 'beforefieldinit'.
			static _WriteAsyncCore_d__49()
			{
				Il2CppClassPointerStore<CryptoStream._WriteAsyncCore_d__49>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "<WriteAsyncCore>d__49");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CryptoStream._WriteAsyncCore_d__49>.NativeClassPtr);
				CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncCore_d__49>.NativeClassPtr, "<>1__state");
				CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncCore_d__49>.NativeClassPtr, "<>t__builder");
				CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncCore_d__49>.NativeClassPtr, "count");
				CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncCore_d__49>.NativeClassPtr, "offset");
				CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncCore_d__49>.NativeClassPtr, "<>4__this");
				CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncCore_d__49>.NativeClassPtr, "buffer");
				CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr_useAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncCore_d__49>.NativeClassPtr, "useAsync");
				CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncCore_d__49>.NativeClassPtr, "cancellationToken");
				CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr__bytesToWrite_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncCore_d__49>.NativeClassPtr, "<bytesToWrite>5__2");
				CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr__currentInputIndex_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncCore_d__49>.NativeClassPtr, "<currentInputIndex>5__3");
				CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr__numOutputBytes_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncCore_d__49>.NativeClassPtr, "<numOutputBytes>5__4");
				CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncCore_d__49>.NativeClassPtr, "<>u__1");
				CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr__numWholeBlocksInBytes_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncCore_d__49>.NativeClassPtr, "<numWholeBlocksInBytes>5__5");
				CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr__tempOutputBuffer_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream._WriteAsyncCore_d__49>.NativeClassPtr, "<tempOutputBuffer>5__6");
				CryptoStream._WriteAsyncCore_d__49.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream._WriteAsyncCore_d__49>.NativeClassPtr, 100669528);
				CryptoStream._WriteAsyncCore_d__49.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream._WriteAsyncCore_d__49>.NativeClassPtr, 100669529);
			}

			// Token: 0x06005AD8 RID: 23256 RVA: 0x0019E61C File Offset: 0x0019C81C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370904, XrefRangeEnd = 1371025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream._WriteAsyncCore_d__49.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005AD9 RID: 23257 RVA: 0x0019E654 File Offset: 0x0019C854
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371025, XrefRangeEnd = 1371029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream._WriteAsyncCore_d__49.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005ADA RID: 23258 RVA: 0x00020CDA File Offset: 0x0001EEDA
			public _WriteAsyncCore_d__49(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005ADB RID: 23259 RVA: 0x00020CE3 File Offset: 0x0001EEE3
			public _WriteAsyncCore_d__49()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CryptoStream._WriteAsyncCore_d__49>.NativeClassPtr))
			{
			}

			// Token: 0x1700173F RID: 5951
			// (get) Token: 0x06005ADC RID: 23260 RVA: 0x0019E69C File Offset: 0x0019C89C
			// (set) Token: 0x06005ADD RID: 23261 RVA: 0x00020CF5 File Offset: 0x0001EEF5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001740 RID: 5952
			// (get) Token: 0x06005ADE RID: 23262 RVA: 0x0019E6C4 File Offset: 0x0019C8C4
			// (set) Token: 0x06005ADF RID: 23263 RVA: 0x00020D10 File Offset: 0x0001EF10
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001741 RID: 5953
			// (get) Token: 0x06005AE0 RID: 23264 RVA: 0x0019E6F4 File Offset: 0x0019C8F4
			// (set) Token: 0x06005AE1 RID: 23265 RVA: 0x00020D3E File Offset: 0x0001EF3E
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x17001742 RID: 5954
			// (get) Token: 0x06005AE2 RID: 23266 RVA: 0x0019E71C File Offset: 0x0019C91C
			// (set) Token: 0x06005AE3 RID: 23267 RVA: 0x00020D59 File Offset: 0x0001EF59
			public unsafe int offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x17001743 RID: 5955
			// (get) Token: 0x06005AE4 RID: 23268 RVA: 0x0019E744 File Offset: 0x0019C944
			// (set) Token: 0x06005AE5 RID: 23269 RVA: 0x00020D74 File Offset: 0x0001EF74
			public unsafe CryptoStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CryptoStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001744 RID: 5956
			// (get) Token: 0x06005AE6 RID: 23270 RVA: 0x0019E774 File Offset: 0x0019C974
			// (set) Token: 0x06005AE7 RID: 23271 RVA: 0x00020D93 File Offset: 0x0001EF93
			public unsafe Il2CppStructArray<byte> buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr_buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001745 RID: 5957
			// (get) Token: 0x06005AE8 RID: 23272 RVA: 0x0019E7A4 File Offset: 0x0019C9A4
			// (set) Token: 0x06005AE9 RID: 23273 RVA: 0x00020DB2 File Offset: 0x0001EFB2
			public unsafe bool useAsync
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr_useAsync);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr_useAsync)) = value;
				}
			}

			// Token: 0x17001746 RID: 5958
			// (get) Token: 0x06005AEA RID: 23274 RVA: 0x0019E7CC File Offset: 0x0019C9CC
			// (set) Token: 0x06005AEB RID: 23275 RVA: 0x00020DCD File Offset: 0x0001EFCD
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001747 RID: 5959
			// (get) Token: 0x06005AEC RID: 23276 RVA: 0x0019E7FC File Offset: 0x0019C9FC
			// (set) Token: 0x06005AED RID: 23277 RVA: 0x00020DFB File Offset: 0x0001EFFB
			public unsafe int _bytesToWrite_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr__bytesToWrite_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr__bytesToWrite_5__2)) = value;
				}
			}

			// Token: 0x17001748 RID: 5960
			// (get) Token: 0x06005AEE RID: 23278 RVA: 0x0019E824 File Offset: 0x0019CA24
			// (set) Token: 0x06005AEF RID: 23279 RVA: 0x00020E16 File Offset: 0x0001F016
			public unsafe int _currentInputIndex_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr__currentInputIndex_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr__currentInputIndex_5__3)) = value;
				}
			}

			// Token: 0x17001749 RID: 5961
			// (get) Token: 0x06005AF0 RID: 23280 RVA: 0x0019E84C File Offset: 0x0019CA4C
			// (set) Token: 0x06005AF1 RID: 23281 RVA: 0x00020E31 File Offset: 0x0001F031
			public unsafe int _numOutputBytes_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr__numOutputBytes_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr__numOutputBytes_5__4)) = value;
				}
			}

			// Token: 0x1700174A RID: 5962
			// (get) Token: 0x06005AF2 RID: 23282 RVA: 0x0019E874 File Offset: 0x0019CA74
			// (set) Token: 0x06005AF3 RID: 23283 RVA: 0x00020E4C File Offset: 0x0001F04C
			public ValueTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr___u__1);
					return new ValueTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700174B RID: 5963
			// (get) Token: 0x06005AF4 RID: 23284 RVA: 0x0019E8A4 File Offset: 0x0019CAA4
			// (set) Token: 0x06005AF5 RID: 23285 RVA: 0x00020E7A File Offset: 0x0001F07A
			public unsafe int _numWholeBlocksInBytes_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr__numWholeBlocksInBytes_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr__numWholeBlocksInBytes_5__5)) = value;
				}
			}

			// Token: 0x1700174C RID: 5964
			// (get) Token: 0x06005AF6 RID: 23286 RVA: 0x0019E8CC File Offset: 0x0019CACC
			// (set) Token: 0x06005AF7 RID: 23287 RVA: 0x00020E95 File Offset: 0x0001F095
			public unsafe Il2CppStructArray<byte> _tempOutputBuffer_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr__tempOutputBuffer_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CryptoStream._WriteAsyncCore_d__49.NativeFieldInfoPtr__tempOutputBuffer_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004A2C RID: 18988
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004A2D RID: 18989
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04004A2E RID: 18990
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x04004A2F RID: 18991
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x04004A30 RID: 18992
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004A31 RID: 18993
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x04004A32 RID: 18994
			private static readonly IntPtr NativeFieldInfoPtr_useAsync;

			// Token: 0x04004A33 RID: 18995
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04004A34 RID: 18996
			private static readonly IntPtr NativeFieldInfoPtr__bytesToWrite_5__2;

			// Token: 0x04004A35 RID: 18997
			private static readonly IntPtr NativeFieldInfoPtr__currentInputIndex_5__3;

			// Token: 0x04004A36 RID: 18998
			private static readonly IntPtr NativeFieldInfoPtr__numOutputBytes_5__4;

			// Token: 0x04004A37 RID: 18999
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04004A38 RID: 19000
			private static readonly IntPtr NativeFieldInfoPtr__numWholeBlocksInBytes_5__5;

			// Token: 0x04004A39 RID: 19001
			private static readonly IntPtr NativeFieldInfoPtr__tempOutputBuffer_5__6;

			// Token: 0x04004A3A RID: 19002
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004A3B RID: 19003
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000664 RID: 1636
		[ObfuscatedName("System.Security.Cryptography.CryptoStream+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06005AF8 RID: 23288 RVA: 0x0019E8FC File Offset: 0x0019CAFC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CryptoStream.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CryptoStream>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CryptoStream.__c>.NativeClassPtr);
				CryptoStream.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream.__c>.NativeClassPtr, "<>9");
				CryptoStream.__c.NativeFieldInfoPtr___9__54_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoStream.__c>.NativeClassPtr, "<>9__54_0");
				CryptoStream.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream.__c>.NativeClassPtr, 100669531);
				CryptoStream.__c.NativeMethodInfoPtr__get_AsyncActiveSemaphore_b__54_0_Internal_SemaphoreSlim_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoStream.__c>.NativeClassPtr, 100669532);
			}

			// Token: 0x06005AF9 RID: 23289 RVA: 0x0019E978 File Offset: 0x0019CB78
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CryptoStream.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005AFA RID: 23290 RVA: 0x0019E9B4 File Offset: 0x0019CBB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371029, XrefRangeEnd = 1371033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SemaphoreSlim _get_AsyncActiveSemaphore_b__54_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoStream.__c.NativeMethodInfoPtr__get_AsyncActiveSemaphore_b__54_0_Internal_SemaphoreSlim_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim>(intPtr3) : null;
			}

			// Token: 0x06005AFB RID: 23291 RVA: 0x00020EB4 File Offset: 0x0001F0B4
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700174D RID: 5965
			// (get) Token: 0x06005AFC RID: 23292 RVA: 0x0019E9F4 File Offset: 0x0019CBF4
			// (set) Token: 0x06005AFD RID: 23293 RVA: 0x00020EBD File Offset: 0x0001F0BD
			public unsafe static CryptoStream.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CryptoStream.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CryptoStream.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CryptoStream.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700174E RID: 5966
			// (get) Token: 0x06005AFE RID: 23294 RVA: 0x0019EA1C File Offset: 0x0019CC1C
			// (set) Token: 0x06005AFF RID: 23295 RVA: 0x00020ECF File Offset: 0x0001F0CF
			public unsafe static Func<SemaphoreSlim> __9__54_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CryptoStream.__c.NativeFieldInfoPtr___9__54_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SemaphoreSlim>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CryptoStream.__c.NativeFieldInfoPtr___9__54_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004A3C RID: 19004
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004A3D RID: 19005
			private static readonly IntPtr NativeFieldInfoPtr___9__54_0;

			// Token: 0x04004A3E RID: 19006
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004A3F RID: 19007
			private static readonly IntPtr NativeMethodInfoPtr__get_AsyncActiveSemaphore_b__54_0_Internal_SemaphoreSlim_0;
		}
	}
}

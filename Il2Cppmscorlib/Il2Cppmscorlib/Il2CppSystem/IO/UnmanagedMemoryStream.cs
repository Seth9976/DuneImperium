using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.InteropServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.IO
{
	// Token: 0x02000530 RID: 1328
	public class UnmanagedMemoryStream : Stream
	{
		// Token: 0x06005146 RID: 20806 RVA: 0x0017A474 File Offset: 0x00178674
		// Note: this type is marked as 'beforefieldinit'.
		static UnmanagedMemoryStream()
		{
			Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "UnmanagedMemoryStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr);
			UnmanagedMemoryStream.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, "_buffer");
			UnmanagedMemoryStream.NativeFieldInfoPtr__mem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, "_mem");
			UnmanagedMemoryStream.NativeFieldInfoPtr__length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, "_length");
			UnmanagedMemoryStream.NativeFieldInfoPtr__capacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, "_capacity");
			UnmanagedMemoryStream.NativeFieldInfoPtr__position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, "_position");
			UnmanagedMemoryStream.NativeFieldInfoPtr__offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, "_offset");
			UnmanagedMemoryStream.NativeFieldInfoPtr__access = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, "_access");
			UnmanagedMemoryStream.NativeFieldInfoPtr__isOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, "_isOpen");
			UnmanagedMemoryStream.NativeFieldInfoPtr__lastReadTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, "_lastReadTask");
			UnmanagedMemoryStream.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100675662);
			UnmanagedMemoryStream.NativeMethodInfoPtr__ctor_Public_Void_ptr_Byte_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100675663);
			UnmanagedMemoryStream.NativeMethodInfoPtr__ctor_Public_Void_ptr_Byte_Int64_Int64_FileAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100675664);
			UnmanagedMemoryStream.NativeMethodInfoPtr_Initialize_Protected_Void_ptr_Byte_Int64_Int64_FileAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100675665);
			UnmanagedMemoryStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100675666);
			UnmanagedMemoryStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100675667);
			UnmanagedMemoryStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100675668);
			UnmanagedMemoryStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100675669);
			UnmanagedMemoryStream.NativeMethodInfoPtr_EnsureNotClosed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100675670);
			UnmanagedMemoryStream.NativeMethodInfoPtr_EnsureReadable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100675671);
			UnmanagedMemoryStream.NativeMethodInfoPtr_EnsureWriteable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100675672);
			UnmanagedMemoryStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100675673);
			UnmanagedMemoryStream.NativeMethodInfoPtr_FlushAsync_Public_Virtual_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100675674);
			UnmanagedMemoryStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100675675);
			UnmanagedMemoryStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100675676);
			UnmanagedMemoryStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100675677);
			UnmanagedMemoryStream.NativeMethodInfoPtr_get_PositionPointer_Public_get_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100675678);
			UnmanagedMemoryStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100675679);
			UnmanagedMemoryStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Span_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100675680);
			UnmanagedMemoryStream.NativeMethodInfoPtr_ReadCore_Internal_Int32_Span_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100675681);
			UnmanagedMemoryStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100675682);
			UnmanagedMemoryStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_ValueTask_1_Int32_Memory_1_Byte_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100675683);
			UnmanagedMemoryStream.NativeMethodInfoPtr_ReadByte_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100675684);
			UnmanagedMemoryStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100675685);
			UnmanagedMemoryStream.NativeMethodInfoPtr_SetLength_Public_Virtual_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100675686);
			UnmanagedMemoryStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100675687);
			UnmanagedMemoryStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_ReadOnlySpan_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100675688);
			UnmanagedMemoryStream.NativeMethodInfoPtr_WriteCore_Internal_Void_ReadOnlySpan_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100675689);
			UnmanagedMemoryStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100675690);
			UnmanagedMemoryStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_ValueTask_ReadOnlyMemory_1_Byte_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100675691);
			UnmanagedMemoryStream.NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100675692);
		}

		// Token: 0x06005147 RID: 20807 RVA: 0x0017A7C4 File Offset: 0x001789C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1429763, RefRangeEnd = 1429764, XrefRangeStart = 1429759, XrefRangeEnd = 1429763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnmanagedMemoryStream()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnmanagedMemoryStream.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005148 RID: 20808 RVA: 0x0017A800 File Offset: 0x00178A00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1429769, RefRangeEnd = 1429770, XrefRangeStart = 1429764, XrefRangeEnd = 1429769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnmanagedMemoryStream(byte* pointer, long length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pointer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnmanagedMemoryStream.NativeMethodInfoPtr__ctor_Public_Void_ptr_Byte_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005149 RID: 20809 RVA: 0x0017A854 File Offset: 0x00178A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429770, XrefRangeEnd = 1429775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnmanagedMemoryStream(byte* pointer, long length, long capacity, FileAccess access)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pointer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnmanagedMemoryStream.NativeMethodInfoPtr__ctor_Public_Void_ptr_Byte_Int64_Int64_FileAccess_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600514A RID: 20810 RVA: 0x0017A8C4 File Offset: 0x00178AC4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1429775, RefRangeEnd = 1429778, XrefRangeStart = 1429775, XrefRangeEnd = 1429775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(byte* pointer, long length, long capacity, FileAccess access)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pointer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnmanagedMemoryStream.NativeMethodInfoPtr_Initialize_Protected_Void_ptr_Byte_Int64_Int64_FileAccess_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170014B9 RID: 5305
		// (get) Token: 0x0600514B RID: 20811 RVA: 0x0017A92C File Offset: 0x00178B2C
		public unsafe override bool CanRead
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170014BA RID: 5306
		// (get) Token: 0x0600514C RID: 20812 RVA: 0x0017A974 File Offset: 0x00178B74
		public unsafe override bool CanSeek
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170014BB RID: 5307
		// (get) Token: 0x0600514D RID: 20813 RVA: 0x0017A9BC File Offset: 0x00178BBC
		public unsafe override bool CanWrite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600514E RID: 20814 RVA: 0x0017AA04 File Offset: 0x00178C04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1429778, RefRangeEnd = 1429780, XrefRangeStart = 1429778, XrefRangeEnd = 1429778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600514F RID: 20815 RVA: 0x0017AA50 File Offset: 0x00178C50
		[CallerCount(0)]
		public unsafe void EnsureNotClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnmanagedMemoryStream.NativeMethodInfoPtr_EnsureNotClosed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005150 RID: 20816 RVA: 0x0017AA84 File Offset: 0x00178C84
		[CallerCount(0)]
		public unsafe void EnsureReadable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnmanagedMemoryStream.NativeMethodInfoPtr_EnsureReadable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005151 RID: 20817 RVA: 0x0017AAB8 File Offset: 0x00178CB8
		[CallerCount(0)]
		public unsafe void EnsureWriteable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnmanagedMemoryStream.NativeMethodInfoPtr_EnsureWriteable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005152 RID: 20818 RVA: 0x0017AAEC File Offset: 0x00178CEC
		[CallerCount(0)]
		public unsafe override void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005153 RID: 20819 RVA: 0x0017AB28 File Offset: 0x00178D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429780, XrefRangeEnd = 1429795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task FlushAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_FlushAsync_Public_Virtual_Task_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x170014BC RID: 5308
		// (get) Token: 0x06005154 RID: 20820 RVA: 0x0017AB88 File Offset: 0x00178D88
		public unsafe override long Length
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429795, XrefRangeEnd = 1429799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170014BD RID: 5309
		// (get) Token: 0x06005155 RID: 20821 RVA: 0x0017ABD0 File Offset: 0x00178DD0
		// (set) Token: 0x06005156 RID: 20822 RVA: 0x0017AC18 File Offset: 0x00178E18
		public unsafe override long Position
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429799, XrefRangeEnd = 1429803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429803, XrefRangeEnd = 1429814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014BE RID: 5310
		// (get) Token: 0x06005157 RID: 20823 RVA: 0x0017AC64 File Offset: 0x00178E64
		public unsafe byte* PositionPointer
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1429815, RefRangeEnd = 1429820, XrefRangeStart = 1429814, XrefRangeEnd = 1429815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnmanagedMemoryStream.NativeMethodInfoPtr_get_PositionPointer_Public_get_ptr_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x06005158 RID: 20824 RVA: 0x0017AC98 File Offset: 0x00178E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429820, XrefRangeEnd = 1429823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005159 RID: 20825 RVA: 0x0017AD0C File Offset: 0x00178F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429823, XrefRangeEnd = 1429834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read(Span<byte> buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Span_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600515A RID: 20826 RVA: 0x0017AD6C File Offset: 0x00178F6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1429852, RefRangeEnd = 1429855, XrefRangeStart = 1429834, XrefRangeEnd = 1429852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadCore(Span<byte> buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnmanagedMemoryStream.NativeMethodInfoPtr_ReadCore_Internal_Int32_Span_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600515B RID: 20827 RVA: 0x0017ADC0 File Offset: 0x00178FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429855, XrefRangeEnd = 1429876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x0600515C RID: 20828 RVA: 0x0017AE50 File Offset: 0x00179050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429876, XrefRangeEnd = 1429916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_ValueTask_1_Int32_Memory_1_Byte_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTask<int>(intPtr);
		}

		// Token: 0x0600515D RID: 20829 RVA: 0x0017AEC0 File Offset: 0x001790C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429916, XrefRangeEnd = 1429924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ReadByte()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_ReadByte_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600515E RID: 20830 RVA: 0x0017AF08 File Offset: 0x00179108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429924, XrefRangeEnd = 1429957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long Seek(long offset, SeekOrigin loc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600515F RID: 20831 RVA: 0x0017AF6C File Offset: 0x0017916C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429957, XrefRangeEnd = 1429962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetLength(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_SetLength_Public_Virtual_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005160 RID: 20832 RVA: 0x0017AFB8 File Offset: 0x001791B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429962, XrefRangeEnd = 1429968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005161 RID: 20833 RVA: 0x0017B024 File Offset: 0x00179224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429968, XrefRangeEnd = 1429979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(ReadOnlySpan<byte> buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_ReadOnlySpan_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005162 RID: 20834 RVA: 0x0017B078 File Offset: 0x00179278
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1429995, RefRangeEnd = 1429998, XrefRangeStart = 1429979, XrefRangeEnd = 1429995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteCore(ReadOnlySpan<byte> buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnmanagedMemoryStream.NativeMethodInfoPtr_WriteCore_Internal_Void_ReadOnlySpan_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005163 RID: 20835 RVA: 0x0017B0C0 File Offset: 0x001792C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429998, XrefRangeEnd = 1430011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06005164 RID: 20836 RVA: 0x0017B150 File Offset: 0x00179350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430011, XrefRangeEnd = 1430041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_ValueTask_ReadOnlyMemory_1_Byte_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTask(intPtr);
		}

		// Token: 0x06005165 RID: 20837 RVA: 0x0017B1C0 File Offset: 0x001793C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430041, XrefRangeEnd = 1430051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteByte(byte value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005166 RID: 20838 RVA: 0x0001D039 File Offset: 0x0001B239
		public UnmanagedMemoryStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170014B0 RID: 5296
		// (get) Token: 0x06005167 RID: 20839 RVA: 0x0017B20C File Offset: 0x0017940C
		// (set) Token: 0x06005168 RID: 20840 RVA: 0x0001D042 File Offset: 0x0001B242
		public unsafe SafeBuffer _buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SafeBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014B1 RID: 5297
		// (get) Token: 0x06005169 RID: 20841 RVA: 0x0017B23C File Offset: 0x0017943C
		// (set) Token: 0x0600516A RID: 20842 RVA: 0x0001D061 File Offset: 0x0001B261
		public unsafe byte* _mem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__mem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__mem)) = value;
			}
		}

		// Token: 0x170014B2 RID: 5298
		// (get) Token: 0x0600516B RID: 20843 RVA: 0x0017B260 File Offset: 0x00179460
		// (set) Token: 0x0600516C RID: 20844 RVA: 0x0001D07C File Offset: 0x0001B27C
		public unsafe long _length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__length)) = value;
			}
		}

		// Token: 0x170014B3 RID: 5299
		// (get) Token: 0x0600516D RID: 20845 RVA: 0x0017B288 File Offset: 0x00179488
		// (set) Token: 0x0600516E RID: 20846 RVA: 0x0001D097 File Offset: 0x0001B297
		public unsafe long _capacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__capacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__capacity)) = value;
			}
		}

		// Token: 0x170014B4 RID: 5300
		// (get) Token: 0x0600516F RID: 20847 RVA: 0x0017B2B0 File Offset: 0x001794B0
		// (set) Token: 0x06005170 RID: 20848 RVA: 0x0001D0B2 File Offset: 0x0001B2B2
		public unsafe long _position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__position)) = value;
			}
		}

		// Token: 0x170014B5 RID: 5301
		// (get) Token: 0x06005171 RID: 20849 RVA: 0x0017B2D8 File Offset: 0x001794D8
		// (set) Token: 0x06005172 RID: 20850 RVA: 0x0001D0CD File Offset: 0x0001B2CD
		public unsafe long _offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__offset)) = value;
			}
		}

		// Token: 0x170014B6 RID: 5302
		// (get) Token: 0x06005173 RID: 20851 RVA: 0x0017B300 File Offset: 0x00179500
		// (set) Token: 0x06005174 RID: 20852 RVA: 0x0001D0E8 File Offset: 0x0001B2E8
		public unsafe FileAccess _access
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__access);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__access)) = value;
			}
		}

		// Token: 0x170014B7 RID: 5303
		// (get) Token: 0x06005175 RID: 20853 RVA: 0x0017B328 File Offset: 0x00179528
		// (set) Token: 0x06005176 RID: 20854 RVA: 0x0001D103 File Offset: 0x0001B303
		public unsafe bool _isOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__isOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__isOpen)) = value;
			}
		}

		// Token: 0x170014B8 RID: 5304
		// (get) Token: 0x06005177 RID: 20855 RVA: 0x0017B350 File Offset: 0x00179550
		// (set) Token: 0x06005178 RID: 20856 RVA: 0x0001D11E File Offset: 0x0001B31E
		public unsafe Task<int> _lastReadTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__lastReadTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__lastReadTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400424B RID: 16971
		private static readonly IntPtr NativeFieldInfoPtr__buffer;

		// Token: 0x0400424C RID: 16972
		private static readonly IntPtr NativeFieldInfoPtr__mem;

		// Token: 0x0400424D RID: 16973
		private static readonly IntPtr NativeFieldInfoPtr__length;

		// Token: 0x0400424E RID: 16974
		private static readonly IntPtr NativeFieldInfoPtr__capacity;

		// Token: 0x0400424F RID: 16975
		private static readonly IntPtr NativeFieldInfoPtr__position;

		// Token: 0x04004250 RID: 16976
		private static readonly IntPtr NativeFieldInfoPtr__offset;

		// Token: 0x04004251 RID: 16977
		private static readonly IntPtr NativeFieldInfoPtr__access;

		// Token: 0x04004252 RID: 16978
		private static readonly IntPtr NativeFieldInfoPtr__isOpen;

		// Token: 0x04004253 RID: 16979
		private static readonly IntPtr NativeFieldInfoPtr__lastReadTask;

		// Token: 0x04004254 RID: 16980
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04004255 RID: 16981
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Byte_Int64_0;

		// Token: 0x04004256 RID: 16982
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Byte_Int64_Int64_FileAccess_0;

		// Token: 0x04004257 RID: 16983
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Protected_Void_ptr_Byte_Int64_Int64_FileAccess_0;

		// Token: 0x04004258 RID: 16984
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0;

		// Token: 0x04004259 RID: 16985
		private static readonly IntPtr NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0;

		// Token: 0x0400425A RID: 16986
		private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0;

		// Token: 0x0400425B RID: 16987
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x0400425C RID: 16988
		private static readonly IntPtr NativeMethodInfoPtr_EnsureNotClosed_Private_Void_0;

		// Token: 0x0400425D RID: 16989
		private static readonly IntPtr NativeMethodInfoPtr_EnsureReadable_Private_Void_0;

		// Token: 0x0400425E RID: 16990
		private static readonly IntPtr NativeMethodInfoPtr_EnsureWriteable_Private_Void_0;

		// Token: 0x0400425F RID: 16991
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

		// Token: 0x04004260 RID: 16992
		private static readonly IntPtr NativeMethodInfoPtr_FlushAsync_Public_Virtual_Task_CancellationToken_0;

		// Token: 0x04004261 RID: 16993
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0;

		// Token: 0x04004262 RID: 16994
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0;

		// Token: 0x04004263 RID: 16995
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0;

		// Token: 0x04004264 RID: 16996
		private static readonly IntPtr NativeMethodInfoPtr_get_PositionPointer_Public_get_ptr_Byte_0;

		// Token: 0x04004265 RID: 16997
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04004266 RID: 16998
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Span_1_Byte_0;

		// Token: 0x04004267 RID: 16999
		private static readonly IntPtr NativeMethodInfoPtr_ReadCore_Internal_Int32_Span_1_Byte_0;

		// Token: 0x04004268 RID: 17000
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04004269 RID: 17001
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Virtual_ValueTask_1_Int32_Memory_1_Byte_CancellationToken_0;

		// Token: 0x0400426A RID: 17002
		private static readonly IntPtr NativeMethodInfoPtr_ReadByte_Public_Virtual_Int32_0;

		// Token: 0x0400426B RID: 17003
		private static readonly IntPtr NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0;

		// Token: 0x0400426C RID: 17004
		private static readonly IntPtr NativeMethodInfoPtr_SetLength_Public_Virtual_Void_Int64_0;

		// Token: 0x0400426D RID: 17005
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400426E RID: 17006
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_ReadOnlySpan_1_Byte_0;

		// Token: 0x0400426F RID: 17007
		private static readonly IntPtr NativeMethodInfoPtr_WriteCore_Internal_Void_ReadOnlySpan_1_Byte_0;

		// Token: 0x04004270 RID: 17008
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04004271 RID: 17009
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_ValueTask_ReadOnlyMemory_1_Byte_CancellationToken_0;

		// Token: 0x04004272 RID: 17010
		private static readonly IntPtr NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0;
	}
}

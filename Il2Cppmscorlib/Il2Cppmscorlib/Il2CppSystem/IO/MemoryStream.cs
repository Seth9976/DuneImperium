using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.IO
{
	// Token: 0x02000526 RID: 1318
	[Serializable]
	public class MemoryStream : Stream
	{
		// Token: 0x0600501E RID: 20510 RVA: 0x00174D00 File Offset: 0x00172F00
		// Note: this type is marked as 'beforefieldinit'.
		static MemoryStream()
		{
			Il2CppClassPointerStore<MemoryStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "MemoryStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr);
			MemoryStream.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, "_buffer");
			MemoryStream.NativeFieldInfoPtr__origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, "_origin");
			MemoryStream.NativeFieldInfoPtr__position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, "_position");
			MemoryStream.NativeFieldInfoPtr__length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, "_length");
			MemoryStream.NativeFieldInfoPtr__capacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, "_capacity");
			MemoryStream.NativeFieldInfoPtr__expandable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, "_expandable");
			MemoryStream.NativeFieldInfoPtr__writable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, "_writable");
			MemoryStream.NativeFieldInfoPtr__exposable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, "_exposable");
			MemoryStream.NativeFieldInfoPtr__isOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, "_isOpen");
			MemoryStream.NativeFieldInfoPtr__lastReadTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, "_lastReadTask");
			MemoryStream.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675401);
			MemoryStream.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675402);
			MemoryStream.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675403);
			MemoryStream.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675404);
			MemoryStream.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675405);
			MemoryStream.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675406);
			MemoryStream.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675407);
			MemoryStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675408);
			MemoryStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675409);
			MemoryStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675410);
			MemoryStream.NativeMethodInfoPtr_EnsureNotClosed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675411);
			MemoryStream.NativeMethodInfoPtr_EnsureWriteable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675412);
			MemoryStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675413);
			MemoryStream.NativeMethodInfoPtr_EnsureCapacity_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675414);
			MemoryStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675415);
			MemoryStream.NativeMethodInfoPtr_FlushAsync_Public_Virtual_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675416);
			MemoryStream.NativeMethodInfoPtr_GetBuffer_Public_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675417);
			MemoryStream.NativeMethodInfoPtr_InternalGetBuffer_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675418);
			MemoryStream.NativeMethodInfoPtr_InternalGetPosition_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675419);
			MemoryStream.NativeMethodInfoPtr_InternalReadInt32_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675420);
			MemoryStream.NativeMethodInfoPtr_InternalEmulateRead_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675421);
			MemoryStream.NativeMethodInfoPtr_get_Capacity_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675422);
			MemoryStream.NativeMethodInfoPtr_set_Capacity_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675423);
			MemoryStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675424);
			MemoryStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675425);
			MemoryStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675426);
			MemoryStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675427);
			MemoryStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Span_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675428);
			MemoryStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675429);
			MemoryStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_ValueTask_1_Int32_Memory_1_Byte_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675430);
			MemoryStream.NativeMethodInfoPtr_ReadByte_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675431);
			MemoryStream.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Stream_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675432);
			MemoryStream.NativeMethodInfoPtr_CopyToAsync_Public_Virtual_Task_Stream_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675433);
			MemoryStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675434);
			MemoryStream.NativeMethodInfoPtr_SetLength_Public_Virtual_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675435);
			MemoryStream.NativeMethodInfoPtr_ToArray_Public_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675436);
			MemoryStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675437);
			MemoryStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_ReadOnlySpan_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675438);
			MemoryStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675439);
			MemoryStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_ValueTask_ReadOnlyMemory_1_Byte_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675440);
			MemoryStream.NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100675441);
		}

		// Token: 0x0600501F RID: 20511 RVA: 0x0017512C File Offset: 0x0017332C
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 1427389, RefRangeEnd = 1427423, XrefRangeStart = 1427380, XrefRangeEnd = 1427389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemoryStream()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryStream.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005020 RID: 20512 RVA: 0x00175168 File Offset: 0x00173368
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1427435, RefRangeEnd = 1427438, XrefRangeStart = 1427423, XrefRangeEnd = 1427435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemoryStream(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryStream.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005021 RID: 20513 RVA: 0x001751B0 File Offset: 0x001733B0
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 1427443, RefRangeEnd = 1427465, XrefRangeStart = 1427438, XrefRangeEnd = 1427443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemoryStream(Il2CppStructArray<byte> buffer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryStream.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005022 RID: 20514 RVA: 0x001751FC File Offset: 0x001733FC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1427470, RefRangeEnd = 1427474, XrefRangeStart = 1427465, XrefRangeEnd = 1427470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemoryStream(Il2CppStructArray<byte> buffer, bool writable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryStream.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005023 RID: 20515 RVA: 0x00175258 File Offset: 0x00173458
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1427475, RefRangeEnd = 1427476, XrefRangeStart = 1427474, XrefRangeEnd = 1427475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemoryStream(Il2CppStructArray<byte> buffer, int index, int count)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryStream.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005024 RID: 20516 RVA: 0x001752C0 File Offset: 0x001734C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1427477, RefRangeEnd = 1427478, XrefRangeStart = 1427476, XrefRangeEnd = 1427477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemoryStream(Il2CppStructArray<byte> buffer, int index, int count, bool writable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryStream.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005025 RID: 20517 RVA: 0x00175338 File Offset: 0x00173538
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1427483, RefRangeEnd = 1427485, XrefRangeStart = 1427478, XrefRangeEnd = 1427483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemoryStream(Il2CppStructArray<byte> buffer, int index, int count, bool writable, bool publiclyVisible)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writable;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref publiclyVisible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryStream.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001477 RID: 5239
		// (get) Token: 0x06005026 RID: 20518 RVA: 0x001753BC File Offset: 0x001735BC
		public unsafe override bool CanRead
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001478 RID: 5240
		// (get) Token: 0x06005027 RID: 20519 RVA: 0x00175404 File Offset: 0x00173604
		public unsafe override bool CanSeek
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001479 RID: 5241
		// (get) Token: 0x06005028 RID: 20520 RVA: 0x0017544C File Offset: 0x0017364C
		public unsafe override bool CanWrite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005029 RID: 20521 RVA: 0x00175494 File Offset: 0x00173694
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1427485, RefRangeEnd = 1427487, XrefRangeStart = 1427485, XrefRangeEnd = 1427485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureNotClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryStream.NativeMethodInfoPtr_EnsureNotClosed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600502A RID: 20522 RVA: 0x001754C8 File Offset: 0x001736C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1427487, RefRangeEnd = 1427488, XrefRangeStart = 1427487, XrefRangeEnd = 1427487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureWriteable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryStream.NativeMethodInfoPtr_EnsureWriteable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600502B RID: 20523 RVA: 0x001754FC File Offset: 0x001736FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427488, XrefRangeEnd = 1427492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600502C RID: 20524 RVA: 0x00175548 File Offset: 0x00173748
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1427492, RefRangeEnd = 1427496, XrefRangeStart = 1427492, XrefRangeEnd = 1427492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EnsureCapacity(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryStream.NativeMethodInfoPtr_EnsureCapacity_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600502D RID: 20525 RVA: 0x00175594 File Offset: 0x00173794
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600502E RID: 20526 RVA: 0x001755D0 File Offset: 0x001737D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427496, XrefRangeEnd = 1427511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task FlushAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_FlushAsync_Public_Virtual_Task_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x0600502F RID: 20527 RVA: 0x00175630 File Offset: 0x00173830
		[CallerCount(0)]
		public unsafe virtual Il2CppStructArray<byte> GetBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_GetBuffer_Public_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06005030 RID: 20528 RVA: 0x0017567C File Offset: 0x0017387C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> InternalGetBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryStream.NativeMethodInfoPtr_InternalGetBuffer_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06005031 RID: 20529 RVA: 0x001756BC File Offset: 0x001738BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 134006, RefRangeEnd = 134007, XrefRangeStart = 134006, XrefRangeEnd = 134007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalGetPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryStream.NativeMethodInfoPtr_InternalGetPosition_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005032 RID: 20530 RVA: 0x001756F8 File Offset: 0x001738F8
		[CallerCount(0)]
		public unsafe int InternalReadInt32()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryStream.NativeMethodInfoPtr_InternalReadInt32_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005033 RID: 20531 RVA: 0x00175734 File Offset: 0x00173934
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1427511, RefRangeEnd = 1427512, XrefRangeStart = 1427511, XrefRangeEnd = 1427511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalEmulateRead(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryStream.NativeMethodInfoPtr_InternalEmulateRead_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700147A RID: 5242
		// (get) Token: 0x06005034 RID: 20532 RVA: 0x00175780 File Offset: 0x00173980
		// (set) Token: 0x06005035 RID: 20533 RVA: 0x001757C8 File Offset: 0x001739C8
		public unsafe virtual int Capacity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_get_Capacity_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427512, XrefRangeEnd = 1427518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_set_Capacity_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700147B RID: 5243
		// (get) Token: 0x06005036 RID: 20534 RVA: 0x00175814 File Offset: 0x00173A14
		public unsafe override long Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700147C RID: 5244
		// (get) Token: 0x06005037 RID: 20535 RVA: 0x0017585C File Offset: 0x00173A5C
		// (set) Token: 0x06005038 RID: 20536 RVA: 0x001758A4 File Offset: 0x00173AA4
		public unsafe override long Position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1427518, RefRangeEnd = 1427519, XrefRangeStart = 1427518, XrefRangeEnd = 1427518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06005039 RID: 20537 RVA: 0x001758F0 File Offset: 0x00173AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427519, XrefRangeEnd = 1427521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600503A RID: 20538 RVA: 0x00175964 File Offset: 0x00173B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427521, XrefRangeEnd = 1427541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read(Span<byte> buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Span_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600503B RID: 20539 RVA: 0x001759C4 File Offset: 0x00173BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427541, XrefRangeEnd = 1427567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x0600503C RID: 20540 RVA: 0x00175A54 File Offset: 0x00173C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427567, XrefRangeEnd = 1427612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_ValueTask_1_Int32_Memory_1_Byte_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTask<int>(intPtr);
		}

		// Token: 0x0600503D RID: 20541 RVA: 0x00175AC4 File Offset: 0x00173CC4
		[CallerCount(0)]
		public unsafe override int ReadByte()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_ReadByte_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600503E RID: 20542 RVA: 0x00175B0C File Offset: 0x00173D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427612, XrefRangeEnd = 1427623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyTo(Stream destination, int bufferSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Stream_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600503F RID: 20543 RVA: 0x00175B68 File Offset: 0x00173D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427623, XrefRangeEnd = 1427659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_CopyToAsync_Public_Virtual_Task_Stream_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06005040 RID: 20544 RVA: 0x00175BE8 File Offset: 0x00173DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427659, XrefRangeEnd = 1427661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005041 RID: 20545 RVA: 0x00175C4C File Offset: 0x00173E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427661, XrefRangeEnd = 1427663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetLength(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_SetLength_Public_Virtual_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005042 RID: 20546 RVA: 0x00175C98 File Offset: 0x00173E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427663, XrefRangeEnd = 1427668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> ToArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_ToArray_Public_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06005043 RID: 20547 RVA: 0x00175CE4 File Offset: 0x00173EE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1427674, RefRangeEnd = 1427675, XrefRangeStart = 1427668, XrefRangeEnd = 1427674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005044 RID: 20548 RVA: 0x00175D50 File Offset: 0x00173F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427675, XrefRangeEnd = 1427693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(ReadOnlySpan<byte> buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_ReadOnlySpan_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005045 RID: 20549 RVA: 0x00175DA4 File Offset: 0x00173FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427693, XrefRangeEnd = 1427711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06005046 RID: 20550 RVA: 0x00175E34 File Offset: 0x00174034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427711, XrefRangeEnd = 1427746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_ValueTask_ReadOnlyMemory_1_Byte_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTask(intPtr);
		}

		// Token: 0x06005047 RID: 20551 RVA: 0x00175EA4 File Offset: 0x001740A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1427748, RefRangeEnd = 1427749, XrefRangeStart = 1427746, XrefRangeEnd = 1427748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteByte(byte value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005048 RID: 20552 RVA: 0x0001CAAC File Offset: 0x0001ACAC
		public MemoryStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700146D RID: 5229
		// (get) Token: 0x06005049 RID: 20553 RVA: 0x00175EF0 File Offset: 0x001740F0
		// (set) Token: 0x0600504A RID: 20554 RVA: 0x0001CAB5 File Offset: 0x0001ACB5
		public unsafe Il2CppStructArray<byte> _buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700146E RID: 5230
		// (get) Token: 0x0600504B RID: 20555 RVA: 0x00175F20 File Offset: 0x00174120
		// (set) Token: 0x0600504C RID: 20556 RVA: 0x0001CAD4 File Offset: 0x0001ACD4
		public unsafe int _origin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__origin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__origin)) = value;
			}
		}

		// Token: 0x1700146F RID: 5231
		// (get) Token: 0x0600504D RID: 20557 RVA: 0x00175F48 File Offset: 0x00174148
		// (set) Token: 0x0600504E RID: 20558 RVA: 0x0001CAEF File Offset: 0x0001ACEF
		public unsafe int _position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__position)) = value;
			}
		}

		// Token: 0x17001470 RID: 5232
		// (get) Token: 0x0600504F RID: 20559 RVA: 0x00175F70 File Offset: 0x00174170
		// (set) Token: 0x06005050 RID: 20560 RVA: 0x0001CB0A File Offset: 0x0001AD0A
		public unsafe int _length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__length)) = value;
			}
		}

		// Token: 0x17001471 RID: 5233
		// (get) Token: 0x06005051 RID: 20561 RVA: 0x00175F98 File Offset: 0x00174198
		// (set) Token: 0x06005052 RID: 20562 RVA: 0x0001CB25 File Offset: 0x0001AD25
		public unsafe int _capacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__capacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__capacity)) = value;
			}
		}

		// Token: 0x17001472 RID: 5234
		// (get) Token: 0x06005053 RID: 20563 RVA: 0x00175FC0 File Offset: 0x001741C0
		// (set) Token: 0x06005054 RID: 20564 RVA: 0x0001CB40 File Offset: 0x0001AD40
		public unsafe bool _expandable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__expandable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__expandable)) = value;
			}
		}

		// Token: 0x17001473 RID: 5235
		// (get) Token: 0x06005055 RID: 20565 RVA: 0x00175FE8 File Offset: 0x001741E8
		// (set) Token: 0x06005056 RID: 20566 RVA: 0x0001CB5B File Offset: 0x0001AD5B
		public unsafe bool _writable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__writable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__writable)) = value;
			}
		}

		// Token: 0x17001474 RID: 5236
		// (get) Token: 0x06005057 RID: 20567 RVA: 0x00176010 File Offset: 0x00174210
		// (set) Token: 0x06005058 RID: 20568 RVA: 0x0001CB76 File Offset: 0x0001AD76
		public unsafe bool _exposable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__exposable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__exposable)) = value;
			}
		}

		// Token: 0x17001475 RID: 5237
		// (get) Token: 0x06005059 RID: 20569 RVA: 0x00176038 File Offset: 0x00174238
		// (set) Token: 0x0600505A RID: 20570 RVA: 0x0001CB91 File Offset: 0x0001AD91
		public unsafe bool _isOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__isOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__isOpen)) = value;
			}
		}

		// Token: 0x17001476 RID: 5238
		// (get) Token: 0x0600505B RID: 20571 RVA: 0x00176060 File Offset: 0x00174260
		// (set) Token: 0x0600505C RID: 20572 RVA: 0x0001CBAC File Offset: 0x0001ADAC
		public unsafe Task<int> _lastReadTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__lastReadTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__lastReadTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004160 RID: 16736
		private static readonly IntPtr NativeFieldInfoPtr__buffer;

		// Token: 0x04004161 RID: 16737
		private static readonly IntPtr NativeFieldInfoPtr__origin;

		// Token: 0x04004162 RID: 16738
		private static readonly IntPtr NativeFieldInfoPtr__position;

		// Token: 0x04004163 RID: 16739
		private static readonly IntPtr NativeFieldInfoPtr__length;

		// Token: 0x04004164 RID: 16740
		private static readonly IntPtr NativeFieldInfoPtr__capacity;

		// Token: 0x04004165 RID: 16741
		private static readonly IntPtr NativeFieldInfoPtr__expandable;

		// Token: 0x04004166 RID: 16742
		private static readonly IntPtr NativeFieldInfoPtr__writable;

		// Token: 0x04004167 RID: 16743
		private static readonly IntPtr NativeFieldInfoPtr__exposable;

		// Token: 0x04004168 RID: 16744
		private static readonly IntPtr NativeFieldInfoPtr__isOpen;

		// Token: 0x04004169 RID: 16745
		private static readonly IntPtr NativeFieldInfoPtr__lastReadTask;

		// Token: 0x0400416A RID: 16746
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400416B RID: 16747
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400416C RID: 16748
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400416D RID: 16749
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Boolean_0;

		// Token: 0x0400416E RID: 16750
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400416F RID: 16751
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0;

		// Token: 0x04004170 RID: 16752
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_Boolean_0;

		// Token: 0x04004171 RID: 16753
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0;

		// Token: 0x04004172 RID: 16754
		private static readonly IntPtr NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0;

		// Token: 0x04004173 RID: 16755
		private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0;

		// Token: 0x04004174 RID: 16756
		private static readonly IntPtr NativeMethodInfoPtr_EnsureNotClosed_Private_Void_0;

		// Token: 0x04004175 RID: 16757
		private static readonly IntPtr NativeMethodInfoPtr_EnsureWriteable_Private_Void_0;

		// Token: 0x04004176 RID: 16758
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04004177 RID: 16759
		private static readonly IntPtr NativeMethodInfoPtr_EnsureCapacity_Private_Boolean_Int32_0;

		// Token: 0x04004178 RID: 16760
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

		// Token: 0x04004179 RID: 16761
		private static readonly IntPtr NativeMethodInfoPtr_FlushAsync_Public_Virtual_Task_CancellationToken_0;

		// Token: 0x0400417A RID: 16762
		private static readonly IntPtr NativeMethodInfoPtr_GetBuffer_Public_Virtual_New_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400417B RID: 16763
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetBuffer_Internal_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400417C RID: 16764
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetPosition_Internal_Int32_0;

		// Token: 0x0400417D RID: 16765
		private static readonly IntPtr NativeMethodInfoPtr_InternalReadInt32_Internal_Int32_0;

		// Token: 0x0400417E RID: 16766
		private static readonly IntPtr NativeMethodInfoPtr_InternalEmulateRead_Internal_Int32_Int32_0;

		// Token: 0x0400417F RID: 16767
		private static readonly IntPtr NativeMethodInfoPtr_get_Capacity_Public_Virtual_New_get_Int32_0;

		// Token: 0x04004180 RID: 16768
		private static readonly IntPtr NativeMethodInfoPtr_set_Capacity_Public_Virtual_New_set_Void_Int32_0;

		// Token: 0x04004181 RID: 16769
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0;

		// Token: 0x04004182 RID: 16770
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0;

		// Token: 0x04004183 RID: 16771
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0;

		// Token: 0x04004184 RID: 16772
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04004185 RID: 16773
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Span_1_Byte_0;

		// Token: 0x04004186 RID: 16774
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04004187 RID: 16775
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Virtual_ValueTask_1_Int32_Memory_1_Byte_CancellationToken_0;

		// Token: 0x04004188 RID: 16776
		private static readonly IntPtr NativeMethodInfoPtr_ReadByte_Public_Virtual_Int32_0;

		// Token: 0x04004189 RID: 16777
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Stream_Int32_0;

		// Token: 0x0400418A RID: 16778
		private static readonly IntPtr NativeMethodInfoPtr_CopyToAsync_Public_Virtual_Task_Stream_Int32_CancellationToken_0;

		// Token: 0x0400418B RID: 16779
		private static readonly IntPtr NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0;

		// Token: 0x0400418C RID: 16780
		private static readonly IntPtr NativeMethodInfoPtr_SetLength_Public_Virtual_Void_Int64_0;

		// Token: 0x0400418D RID: 16781
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Virtual_New_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400418E RID: 16782
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400418F RID: 16783
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_ReadOnlySpan_1_Byte_0;

		// Token: 0x04004190 RID: 16784
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04004191 RID: 16785
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_ValueTask_ReadOnlyMemory_1_Byte_CancellationToken_0;

		// Token: 0x04004192 RID: 16786
		private static readonly IntPtr NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0;
	}
}

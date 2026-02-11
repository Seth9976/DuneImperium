using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppSystem.IO
{
	// Token: 0x02000529 RID: 1321
	public sealed class PinnedBufferMemoryStream : UnmanagedMemoryStream
	{
		// Token: 0x0600507B RID: 20603 RVA: 0x001769B8 File Offset: 0x00174BB8
		// Note: this type is marked as 'beforefieldinit'.
		static PinnedBufferMemoryStream()
		{
			Il2CppClassPointerStore<PinnedBufferMemoryStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "PinnedBufferMemoryStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PinnedBufferMemoryStream>.NativeClassPtr);
			PinnedBufferMemoryStream.NativeFieldInfoPtr__array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PinnedBufferMemoryStream>.NativeClassPtr, "_array");
			PinnedBufferMemoryStream.NativeFieldInfoPtr__pinningHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PinnedBufferMemoryStream>.NativeClassPtr, "_pinningHandle");
			PinnedBufferMemoryStream.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinnedBufferMemoryStream>.NativeClassPtr, 100675467);
			PinnedBufferMemoryStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Span_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinnedBufferMemoryStream>.NativeClassPtr, 100675468);
			PinnedBufferMemoryStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_ReadOnlySpan_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinnedBufferMemoryStream>.NativeClassPtr, 100675469);
			PinnedBufferMemoryStream.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinnedBufferMemoryStream>.NativeClassPtr, 100675470);
			PinnedBufferMemoryStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinnedBufferMemoryStream>.NativeClassPtr, 100675471);
		}

		// Token: 0x0600507C RID: 20604 RVA: 0x00176A74 File Offset: 0x00174C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427987, XrefRangeEnd = 1427997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PinnedBufferMemoryStream(Il2CppStructArray<byte> array)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PinnedBufferMemoryStream>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PinnedBufferMemoryStream.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600507D RID: 20605 RVA: 0x00176AC0 File Offset: 0x00174CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427997, XrefRangeEnd = 1427998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read(Span<byte> buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PinnedBufferMemoryStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Span_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600507E RID: 20606 RVA: 0x00176B14 File Offset: 0x00174D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427998, XrefRangeEnd = 1427999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(ReadOnlySpan<byte> buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PinnedBufferMemoryStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_ReadOnlySpan_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600507F RID: 20607 RVA: 0x00176B5C File Offset: 0x00174D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PinnedBufferMemoryStream.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005080 RID: 20608 RVA: 0x00176B90 File Offset: 0x00174D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427999, XrefRangeEnd = 1428002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PinnedBufferMemoryStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005081 RID: 20609 RVA: 0x0001CBEB File Offset: 0x0001ADEB
		public PinnedBufferMemoryStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700147F RID: 5247
		// (get) Token: 0x06005082 RID: 20610 RVA: 0x00176BD0 File Offset: 0x00174DD0
		// (set) Token: 0x06005083 RID: 20611 RVA: 0x0001CBF4 File Offset: 0x0001ADF4
		public unsafe Il2CppStructArray<byte> _array
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PinnedBufferMemoryStream.NativeFieldInfoPtr__array);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PinnedBufferMemoryStream.NativeFieldInfoPtr__array), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001480 RID: 5248
		// (get) Token: 0x06005084 RID: 20612 RVA: 0x00176C00 File Offset: 0x00174E00
		// (set) Token: 0x06005085 RID: 20613 RVA: 0x0001CC13 File Offset: 0x0001AE13
		public unsafe GCHandle _pinningHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PinnedBufferMemoryStream.NativeFieldInfoPtr__pinningHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PinnedBufferMemoryStream.NativeFieldInfoPtr__pinningHandle)) = value;
			}
		}

		// Token: 0x040041AC RID: 16812
		private static readonly IntPtr NativeFieldInfoPtr__array;

		// Token: 0x040041AD RID: 16813
		private static readonly IntPtr NativeFieldInfoPtr__pinningHandle;

		// Token: 0x040041AE RID: 16814
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x040041AF RID: 16815
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Span_1_Byte_0;

		// Token: 0x040041B0 RID: 16816
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_ReadOnlySpan_1_Byte_0;

		// Token: 0x040041B1 RID: 16817
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040041B2 RID: 16818
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;
	}
}

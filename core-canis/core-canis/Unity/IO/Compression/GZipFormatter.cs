using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.IO.Compression
{
	// Token: 0x02000073 RID: 115
	public class GZipFormatter : Object
	{
		// Token: 0x06000882 RID: 2178 RVA: 0x00035134 File Offset: 0x00033334
		// Note: this type is marked as 'beforefieldinit'.
		static GZipFormatter()
		{
			Il2CppClassPointerStore<GZipFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "Unity.IO.Compression", "GZipFormatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GZipFormatter>.NativeClassPtr);
			GZipFormatter.NativeFieldInfoPtr_headerBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GZipFormatter>.NativeClassPtr, "headerBytes");
			GZipFormatter.NativeFieldInfoPtr__crc32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GZipFormatter>.NativeClassPtr, "_crc32");
			GZipFormatter.NativeFieldInfoPtr__inputStreamSizeModulo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GZipFormatter>.NativeClassPtr, "_inputStreamSizeModulo");
			GZipFormatter.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GZipFormatter>.NativeClassPtr, 100664528);
			GZipFormatter.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GZipFormatter>.NativeClassPtr, 100664529);
			GZipFormatter.NativeMethodInfoPtr_GetHeader_Public_Virtual_Final_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GZipFormatter>.NativeClassPtr, 100664530);
			GZipFormatter.NativeMethodInfoPtr_UpdateWithBytesRead_Public_Virtual_Final_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GZipFormatter>.NativeClassPtr, 100664531);
			GZipFormatter.NativeMethodInfoPtr_GetFooter_Public_Virtual_Final_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GZipFormatter>.NativeClassPtr, 100664532);
			GZipFormatter.NativeMethodInfoPtr_WriteUInt32_Internal_Void_Il2CppStructArray_1_Byte_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GZipFormatter>.NativeClassPtr, 100664533);
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00035218 File Offset: 0x00033418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861487, XrefRangeEnd = 861495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GZipFormatter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GZipFormatter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GZipFormatter.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00035254 File Offset: 0x00033454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861495, XrefRangeEnd = 861503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GZipFormatter(int compressionLevel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GZipFormatter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref compressionLevel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GZipFormatter.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x0003529C File Offset: 0x0003349C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> GetHeader()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GZipFormatter.NativeMethodInfoPtr_GetHeader_Public_Virtual_Final_New_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x000352DC File Offset: 0x000334DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861503, XrefRangeEnd = 861511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateWithBytesRead(Il2CppStructArray<byte> buffer, int offset, int bytesToCopy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bytesToCopy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GZipFormatter.NativeMethodInfoPtr_UpdateWithBytesRead_Public_Virtual_Final_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x0003533C File Offset: 0x0003353C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861511, XrefRangeEnd = 861514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> GetFooter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GZipFormatter.NativeMethodInfoPtr_GetFooter_Public_Virtual_Final_New_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x0003537C File Offset: 0x0003357C
		[CallerCount(0)]
		public unsafe void WriteUInt32(Il2CppStructArray<byte> b, uint value, int startIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GZipFormatter.NativeMethodInfoPtr_WriteUInt32_Internal_Void_Il2CppStructArray_1_Byte_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00004D28 File Offset: 0x00002F28
		public GZipFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x0600088A RID: 2186 RVA: 0x000353DC File Offset: 0x000335DC
		// (set) Token: 0x0600088B RID: 2187 RVA: 0x00004D31 File Offset: 0x00002F31
		public unsafe Il2CppStructArray<byte> headerBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GZipFormatter.NativeFieldInfoPtr_headerBytes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GZipFormatter.NativeFieldInfoPtr_headerBytes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x0003540C File Offset: 0x0003360C
		// (set) Token: 0x0600088D RID: 2189 RVA: 0x00004D50 File Offset: 0x00002F50
		public unsafe uint _crc32
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GZipFormatter.NativeFieldInfoPtr__crc32);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GZipFormatter.NativeFieldInfoPtr__crc32)) = value;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x0600088E RID: 2190 RVA: 0x00035434 File Offset: 0x00033634
		// (set) Token: 0x0600088F RID: 2191 RVA: 0x00004D6B File Offset: 0x00002F6B
		public unsafe long _inputStreamSizeModulo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GZipFormatter.NativeFieldInfoPtr__inputStreamSizeModulo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GZipFormatter.NativeFieldInfoPtr__inputStreamSizeModulo)) = value;
			}
		}

		// Token: 0x04000656 RID: 1622
		private static readonly IntPtr NativeFieldInfoPtr_headerBytes;

		// Token: 0x04000657 RID: 1623
		private static readonly IntPtr NativeFieldInfoPtr__crc32;

		// Token: 0x04000658 RID: 1624
		private static readonly IntPtr NativeFieldInfoPtr__inputStreamSizeModulo;

		// Token: 0x04000659 RID: 1625
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x0400065A RID: 1626
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x0400065B RID: 1627
		private static readonly IntPtr NativeMethodInfoPtr_GetHeader_Public_Virtual_Final_New_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400065C RID: 1628
		private static readonly IntPtr NativeMethodInfoPtr_UpdateWithBytesRead_Public_Virtual_Final_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400065D RID: 1629
		private static readonly IntPtr NativeMethodInfoPtr_GetFooter_Public_Virtual_Final_New_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400065E RID: 1630
		private static readonly IntPtr NativeMethodInfoPtr_WriteUInt32_Internal_Void_Il2CppStructArray_1_Byte_UInt32_Int32_0;
	}
}

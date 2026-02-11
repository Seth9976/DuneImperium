using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.IO.Compression
{
	// Token: 0x0200007B RID: 123
	public class OutputBuffer : Object
	{
		// Token: 0x0600092F RID: 2351 RVA: 0x0003725C File Offset: 0x0003545C
		// Note: this type is marked as 'beforefieldinit'.
		static OutputBuffer()
		{
			Il2CppClassPointerStore<OutputBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "Unity.IO.Compression", "OutputBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutputBuffer>.NativeClassPtr);
			OutputBuffer.NativeFieldInfoPtr_byteBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputBuffer>.NativeClassPtr, "byteBuffer");
			OutputBuffer.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputBuffer>.NativeClassPtr, "pos");
			OutputBuffer.NativeFieldInfoPtr_bitBuf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputBuffer>.NativeClassPtr, "bitBuf");
			OutputBuffer.NativeFieldInfoPtr_bitCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputBuffer>.NativeClassPtr, "bitCount");
			OutputBuffer.NativeMethodInfoPtr_UpdateBuffer_Internal_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputBuffer>.NativeClassPtr, 100664585);
			OutputBuffer.NativeMethodInfoPtr_get_BytesWritten_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputBuffer>.NativeClassPtr, 100664586);
			OutputBuffer.NativeMethodInfoPtr_get_FreeBytes_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputBuffer>.NativeClassPtr, 100664587);
			OutputBuffer.NativeMethodInfoPtr_WriteUInt16_Internal_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputBuffer>.NativeClassPtr, 100664588);
			OutputBuffer.NativeMethodInfoPtr_WriteBits_Internal_Void_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputBuffer>.NativeClassPtr, 100664589);
			OutputBuffer.NativeMethodInfoPtr_FlushBits_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputBuffer>.NativeClassPtr, 100664590);
			OutputBuffer.NativeMethodInfoPtr_WriteBytes_Internal_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputBuffer>.NativeClassPtr, 100664591);
			OutputBuffer.NativeMethodInfoPtr_WriteBytesUnaligned_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputBuffer>.NativeClassPtr, 100664592);
			OutputBuffer.NativeMethodInfoPtr_WriteByteUnaligned_Private_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputBuffer>.NativeClassPtr, 100664593);
			OutputBuffer.NativeMethodInfoPtr_get_BitsInBuffer_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputBuffer>.NativeClassPtr, 100664594);
			OutputBuffer.NativeMethodInfoPtr_DumpState_Internal_BufferState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputBuffer>.NativeClassPtr, 100664595);
			OutputBuffer.NativeMethodInfoPtr_RestoreState_Internal_Void_BufferState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputBuffer>.NativeClassPtr, 100664596);
			OutputBuffer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputBuffer>.NativeClassPtr, 100664597);
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x000373E0 File Offset: 0x000355E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861716, XrefRangeEnd = 861717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBuffer(Il2CppStructArray<byte> output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(output);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputBuffer.NativeMethodInfoPtr_UpdateBuffer_Internal_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x00037424 File Offset: 0x00035624
		public unsafe int BytesWritten
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputBuffer.NativeMethodInfoPtr_get_BytesWritten_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000932 RID: 2354 RVA: 0x00037460 File Offset: 0x00035660
		public unsafe int FreeBytes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputBuffer.NativeMethodInfoPtr_get_FreeBytes_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x0003749C File Offset: 0x0003569C
		[CallerCount(0)]
		public unsafe void WriteUInt16(ushort value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputBuffer.NativeMethodInfoPtr_WriteUInt16_Internal_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x000374DC File Offset: 0x000356DC
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 861717, RefRangeEnd = 861733, XrefRangeStart = 861717, XrefRangeEnd = 861717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteBits(int n, uint bits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputBuffer.NativeMethodInfoPtr_WriteBits_Internal_Void_Int32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x00037528 File Offset: 0x00035728
		[CallerCount(0)]
		public unsafe void FlushBits()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputBuffer.NativeMethodInfoPtr_FlushBits_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x0003755C File Offset: 0x0003575C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861733, XrefRangeEnd = 861734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteBytes(Il2CppStructArray<byte> byteArray, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(byteArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputBuffer.NativeMethodInfoPtr_WriteBytes_Internal_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x000375BC File Offset: 0x000357BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861734, XrefRangeEnd = 861735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteBytesUnaligned(Il2CppStructArray<byte> byteArray, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(byteArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputBuffer.NativeMethodInfoPtr_WriteBytesUnaligned_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x0003761C File Offset: 0x0003581C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861735, XrefRangeEnd = 861736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteByteUnaligned(byte b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputBuffer.NativeMethodInfoPtr_WriteByteUnaligned_Private_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000939 RID: 2361 RVA: 0x0003765C File Offset: 0x0003585C
		public unsafe int BitsInBuffer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputBuffer.NativeMethodInfoPtr_get_BitsInBuffer_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00037698 File Offset: 0x00035898
		[CallerCount(0)]
		public unsafe OutputBuffer.BufferState DumpState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputBuffer.NativeMethodInfoPtr_DumpState_Internal_BufferState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x000376D4 File Offset: 0x000358D4
		[CallerCount(0)]
		public unsafe void RestoreState(OutputBuffer.BufferState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputBuffer.NativeMethodInfoPtr_RestoreState_Internal_Void_BufferState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00037714 File Offset: 0x00035914
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OutputBuffer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutputBuffer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputBuffer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x000052AC File Offset: 0x000034AC
		public OutputBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x0600093E RID: 2366 RVA: 0x00037750 File Offset: 0x00035950
		// (set) Token: 0x0600093F RID: 2367 RVA: 0x000052B5 File Offset: 0x000034B5
		public unsafe Il2CppStructArray<byte> byteBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputBuffer.NativeFieldInfoPtr_byteBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputBuffer.NativeFieldInfoPtr_byteBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000940 RID: 2368 RVA: 0x00037780 File Offset: 0x00035980
		// (set) Token: 0x06000941 RID: 2369 RVA: 0x000052D4 File Offset: 0x000034D4
		public unsafe int pos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputBuffer.NativeFieldInfoPtr_pos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputBuffer.NativeFieldInfoPtr_pos)) = value;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000942 RID: 2370 RVA: 0x000377A8 File Offset: 0x000359A8
		// (set) Token: 0x06000943 RID: 2371 RVA: 0x000052EF File Offset: 0x000034EF
		public unsafe uint bitBuf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputBuffer.NativeFieldInfoPtr_bitBuf);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputBuffer.NativeFieldInfoPtr_bitBuf)) = value;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x000377D0 File Offset: 0x000359D0
		// (set) Token: 0x06000945 RID: 2373 RVA: 0x0000530A File Offset: 0x0000350A
		public unsafe int bitCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputBuffer.NativeFieldInfoPtr_bitCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputBuffer.NativeFieldInfoPtr_bitCount)) = value;
			}
		}

		// Token: 0x040006D9 RID: 1753
		private static readonly IntPtr NativeFieldInfoPtr_byteBuffer;

		// Token: 0x040006DA RID: 1754
		private static readonly IntPtr NativeFieldInfoPtr_pos;

		// Token: 0x040006DB RID: 1755
		private static readonly IntPtr NativeFieldInfoPtr_bitBuf;

		// Token: 0x040006DC RID: 1756
		private static readonly IntPtr NativeFieldInfoPtr_bitCount;

		// Token: 0x040006DD RID: 1757
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBuffer_Internal_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x040006DE RID: 1758
		private static readonly IntPtr NativeMethodInfoPtr_get_BytesWritten_Internal_get_Int32_0;

		// Token: 0x040006DF RID: 1759
		private static readonly IntPtr NativeMethodInfoPtr_get_FreeBytes_Internal_get_Int32_0;

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeMethodInfoPtr_WriteUInt16_Internal_Void_UInt16_0;

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeMethodInfoPtr_WriteBits_Internal_Void_Int32_UInt32_0;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeMethodInfoPtr_FlushBits_Internal_Void_0;

		// Token: 0x040006E3 RID: 1763
		private static readonly IntPtr NativeMethodInfoPtr_WriteBytes_Internal_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040006E4 RID: 1764
		private static readonly IntPtr NativeMethodInfoPtr_WriteBytesUnaligned_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040006E5 RID: 1765
		private static readonly IntPtr NativeMethodInfoPtr_WriteByteUnaligned_Private_Void_Byte_0;

		// Token: 0x040006E6 RID: 1766
		private static readonly IntPtr NativeMethodInfoPtr_get_BitsInBuffer_Internal_get_Int32_0;

		// Token: 0x040006E7 RID: 1767
		private static readonly IntPtr NativeMethodInfoPtr_DumpState_Internal_BufferState_0;

		// Token: 0x040006E8 RID: 1768
		private static readonly IntPtr NativeMethodInfoPtr_RestoreState_Internal_Void_BufferState_0;

		// Token: 0x040006E9 RID: 1769
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000284 RID: 644
		[StructLayout(2)]
		public struct BufferState
		{
			// Token: 0x06001F13 RID: 7955 RVA: 0x0008DA28 File Offset: 0x0008BC28
			// Note: this type is marked as 'beforefieldinit'.
			static BufferState()
			{
				Il2CppClassPointerStore<OutputBuffer.BufferState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OutputBuffer>.NativeClassPtr, "BufferState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutputBuffer.BufferState>.NativeClassPtr);
				OutputBuffer.BufferState.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputBuffer.BufferState>.NativeClassPtr, "pos");
				OutputBuffer.BufferState.NativeFieldInfoPtr_bitBuf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputBuffer.BufferState>.NativeClassPtr, "bitBuf");
				OutputBuffer.BufferState.NativeFieldInfoPtr_bitCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputBuffer.BufferState>.NativeClassPtr, "bitCount");
			}

			// Token: 0x06001F14 RID: 7956 RVA: 0x0000D3C4 File Offset: 0x0000B5C4
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OutputBuffer.BufferState>.NativeClassPtr, ref this));
			}

			// Token: 0x040015D3 RID: 5587
			private static readonly IntPtr NativeFieldInfoPtr_pos;

			// Token: 0x040015D4 RID: 5588
			private static readonly IntPtr NativeFieldInfoPtr_bitBuf;

			// Token: 0x040015D5 RID: 5589
			private static readonly IntPtr NativeFieldInfoPtr_bitCount;

			// Token: 0x040015D6 RID: 5590
			[FieldOffset(0)]
			public int pos;

			// Token: 0x040015D7 RID: 5591
			[FieldOffset(4)]
			public uint bitBuf;

			// Token: 0x040015D8 RID: 5592
			[FieldOffset(8)]
			public int bitCount;
		}
	}
}

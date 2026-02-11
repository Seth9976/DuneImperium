using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.IO.Compression
{
	// Token: 0x02000078 RID: 120
	public class InputBuffer : Object
	{
		// Token: 0x060008FE RID: 2302 RVA: 0x000366EC File Offset: 0x000348EC
		// Note: this type is marked as 'beforefieldinit'.
		static InputBuffer()
		{
			Il2CppClassPointerStore<InputBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "Unity.IO.Compression", "InputBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputBuffer>.NativeClassPtr);
			InputBuffer.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBuffer>.NativeClassPtr, "buffer");
			InputBuffer.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBuffer>.NativeClassPtr, "start");
			InputBuffer.NativeFieldInfoPtr_end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBuffer>.NativeClassPtr, "end");
			InputBuffer.NativeFieldInfoPtr_bitBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBuffer>.NativeClassPtr, "bitBuffer");
			InputBuffer.NativeFieldInfoPtr_bitsInBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBuffer>.NativeClassPtr, "bitsInBuffer");
			InputBuffer.NativeMethodInfoPtr_get_AvailableBits_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBuffer>.NativeClassPtr, 100664560);
			InputBuffer.NativeMethodInfoPtr_get_AvailableBytes_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBuffer>.NativeClassPtr, 100664561);
			InputBuffer.NativeMethodInfoPtr_EnsureBitsAvailable_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBuffer>.NativeClassPtr, 100664562);
			InputBuffer.NativeMethodInfoPtr_TryLoad16Bits_Public_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBuffer>.NativeClassPtr, 100664563);
			InputBuffer.NativeMethodInfoPtr_GetBitMask_Private_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBuffer>.NativeClassPtr, 100664564);
			InputBuffer.NativeMethodInfoPtr_GetBits_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBuffer>.NativeClassPtr, 100664565);
			InputBuffer.NativeMethodInfoPtr_CopyTo_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBuffer>.NativeClassPtr, 100664566);
			InputBuffer.NativeMethodInfoPtr_NeedsInput_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBuffer>.NativeClassPtr, 100664567);
			InputBuffer.NativeMethodInfoPtr_SetInput_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBuffer>.NativeClassPtr, 100664568);
			InputBuffer.NativeMethodInfoPtr_SkipBits_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBuffer>.NativeClassPtr, 100664569);
			InputBuffer.NativeMethodInfoPtr_SkipToByteBoundary_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBuffer>.NativeClassPtr, 100664570);
			InputBuffer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBuffer>.NativeClassPtr, 100664571);
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060008FF RID: 2303 RVA: 0x00036870 File Offset: 0x00034A70
		public unsafe int AvailableBits
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBuffer.NativeMethodInfoPtr_get_AvailableBits_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000900 RID: 2304 RVA: 0x000368AC File Offset: 0x00034AAC
		public unsafe int AvailableBytes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBuffer.NativeMethodInfoPtr_get_AvailableBytes_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x000368E8 File Offset: 0x00034AE8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 861681, RefRangeEnd = 861691, XrefRangeStart = 861681, XrefRangeEnd = 861681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EnsureBitsAvailable(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBuffer.NativeMethodInfoPtr_EnsureBitsAvailable_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00036934 File Offset: 0x00034B34
		[CallerCount(0)]
		public unsafe uint TryLoad16Bits()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBuffer.NativeMethodInfoPtr_TryLoad16Bits_Public_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00036970 File Offset: 0x00034B70
		[CallerCount(0)]
		public unsafe uint GetBitMask(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBuffer.NativeMethodInfoPtr_GetBitMask_Private_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x000369BC File Offset: 0x00034BBC
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 861692, RefRangeEnd = 861711, XrefRangeStart = 861691, XrefRangeEnd = 861692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetBits(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBuffer.NativeMethodInfoPtr_GetBits_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x00036A08 File Offset: 0x00034C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861711, XrefRangeEnd = 861712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CopyTo(Il2CppStructArray<byte> output, int offset, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(output);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBuffer.NativeMethodInfoPtr_CopyTo_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x00036A74 File Offset: 0x00034C74
		[CallerCount(0)]
		public unsafe bool NeedsInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBuffer.NativeMethodInfoPtr_NeedsInput_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00036AB0 File Offset: 0x00034CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861712, XrefRangeEnd = 861713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInput(Il2CppStructArray<byte> buffer, int offset, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBuffer.NativeMethodInfoPtr_SetInput_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x00036B10 File Offset: 0x00034D10
		[CallerCount(0)]
		public unsafe void SkipBits(int n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBuffer.NativeMethodInfoPtr_SkipBits_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x00036B50 File Offset: 0x00034D50
		[CallerCount(0)]
		public unsafe void SkipToByteBoundary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBuffer.NativeMethodInfoPtr_SkipToByteBoundary_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x00036B84 File Offset: 0x00034D84
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputBuffer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputBuffer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBuffer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x0000519A File Offset: 0x0000339A
		public InputBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x00036BC0 File Offset: 0x00034DC0
		// (set) Token: 0x0600090D RID: 2317 RVA: 0x000051A3 File Offset: 0x000033A3
		public unsafe Il2CppStructArray<byte> buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBuffer.NativeFieldInfoPtr_buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBuffer.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x00036BF0 File Offset: 0x00034DF0
		// (set) Token: 0x0600090F RID: 2319 RVA: 0x000051C2 File Offset: 0x000033C2
		public unsafe int start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBuffer.NativeFieldInfoPtr_start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBuffer.NativeFieldInfoPtr_start)) = value;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000910 RID: 2320 RVA: 0x00036C18 File Offset: 0x00034E18
		// (set) Token: 0x06000911 RID: 2321 RVA: 0x000051DD File Offset: 0x000033DD
		public unsafe int end
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBuffer.NativeFieldInfoPtr_end);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBuffer.NativeFieldInfoPtr_end)) = value;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000912 RID: 2322 RVA: 0x00036C40 File Offset: 0x00034E40
		// (set) Token: 0x06000913 RID: 2323 RVA: 0x000051F8 File Offset: 0x000033F8
		public unsafe uint bitBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBuffer.NativeFieldInfoPtr_bitBuffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBuffer.NativeFieldInfoPtr_bitBuffer)) = value;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000914 RID: 2324 RVA: 0x00036C68 File Offset: 0x00034E68
		// (set) Token: 0x06000915 RID: 2325 RVA: 0x00005213 File Offset: 0x00003413
		public unsafe int bitsInBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBuffer.NativeFieldInfoPtr_bitsInBuffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBuffer.NativeFieldInfoPtr_bitsInBuffer)) = value;
			}
		}

		// Token: 0x040006B7 RID: 1719
		private static readonly IntPtr NativeFieldInfoPtr_buffer;

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeFieldInfoPtr_start;

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeFieldInfoPtr_end;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeFieldInfoPtr_bitBuffer;

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeFieldInfoPtr_bitsInBuffer;

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeMethodInfoPtr_get_AvailableBits_Public_get_Int32_0;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeMethodInfoPtr_get_AvailableBytes_Public_get_Int32_0;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeMethodInfoPtr_EnsureBitsAvailable_Public_Boolean_Int32_0;

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeMethodInfoPtr_TryLoad16Bits_Public_UInt32_0;

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeMethodInfoPtr_GetBitMask_Private_UInt32_Int32_0;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeMethodInfoPtr_GetBits_Public_Int32_Int32_0;

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeMethodInfoPtr_NeedsInput_Public_Boolean_0;

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeMethodInfoPtr_SetInput_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeMethodInfoPtr_SkipBits_Public_Void_Int32_0;

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeMethodInfoPtr_SkipToByteBoundary_Public_Void_0;

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

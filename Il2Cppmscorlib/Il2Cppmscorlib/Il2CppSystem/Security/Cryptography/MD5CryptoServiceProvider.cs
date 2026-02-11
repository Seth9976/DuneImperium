using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000273 RID: 627
	public sealed class MD5CryptoServiceProvider : MD5
	{
		// Token: 0x0600287B RID: 10363 RVA: 0x000DA1D8 File Offset: 0x000D83D8
		// Note: this type is marked as 'beforefieldinit'.
		static MD5CryptoServiceProvider()
		{
			Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "MD5CryptoServiceProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr);
			MD5CryptoServiceProvider.NativeFieldInfoPtr__H = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, "_H");
			MD5CryptoServiceProvider.NativeFieldInfoPtr_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, "buff");
			MD5CryptoServiceProvider.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, "count");
			MD5CryptoServiceProvider.NativeFieldInfoPtr__ProcessingBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, "_ProcessingBuffer");
			MD5CryptoServiceProvider.NativeFieldInfoPtr__ProcessingBufferCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, "_ProcessingBufferCount");
			MD5CryptoServiceProvider.NativeFieldInfoPtr_K = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, "K");
			MD5CryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, 100669942);
			MD5CryptoServiceProvider.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, 100669943);
			MD5CryptoServiceProvider.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, 100669944);
			MD5CryptoServiceProvider.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, 100669945);
			MD5CryptoServiceProvider.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, 100669946);
			MD5CryptoServiceProvider.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, 100669947);
			MD5CryptoServiceProvider.NativeMethodInfoPtr_ProcessBlock_Private_Void_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, 100669948);
			MD5CryptoServiceProvider.NativeMethodInfoPtr_ProcessFinalBlock_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, 100669949);
			MD5CryptoServiceProvider.NativeMethodInfoPtr_AddLength_Internal_Void_UInt64_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, 100669950);
		}

		// Token: 0x0600287C RID: 10364 RVA: 0x000DA334 File Offset: 0x000D8534
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1374834, RefRangeEnd = 1374839, XrefRangeStart = 1374822, XrefRangeEnd = 1374834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MD5CryptoServiceProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD5CryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600287D RID: 10365 RVA: 0x000DA370 File Offset: 0x000D8570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD5CryptoServiceProvider.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600287E RID: 10366 RVA: 0x000DA3A4 File Offset: 0x000D85A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1374839, XrefRangeEnd = 1374843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD5CryptoServiceProvider.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600287F RID: 10367 RVA: 0x000DA3E4 File Offset: 0x000D85E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1374843, XrefRangeEnd = 1374847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HashCore(Il2CppStructArray<byte> rgb, int ibStart, int cbSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ibStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD5CryptoServiceProvider.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002880 RID: 10368 RVA: 0x000DA444 File Offset: 0x000D8644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1374847, XrefRangeEnd = 1374851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> HashFinal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD5CryptoServiceProvider.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06002881 RID: 10369 RVA: 0x000DA484 File Offset: 0x000D8684
		[CallerCount(0)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD5CryptoServiceProvider.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002882 RID: 10370 RVA: 0x000DA4B8 File Offset: 0x000D86B8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1374855, RefRangeEnd = 1374859, XrefRangeStart = 1374851, XrefRangeEnd = 1374855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessBlock(Il2CppStructArray<byte> inputBuffer, int inputOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD5CryptoServiceProvider.NativeMethodInfoPtr_ProcessBlock_Private_Void_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002883 RID: 10371 RVA: 0x000DA508 File Offset: 0x000D8708
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1374865, RefRangeEnd = 1374866, XrefRangeStart = 1374859, XrefRangeEnd = 1374865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessFinalBlock(Il2CppStructArray<byte> inputBuffer, int inputOffset, int inputCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD5CryptoServiceProvider.NativeMethodInfoPtr_ProcessFinalBlock_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002884 RID: 10372 RVA: 0x000DA568 File Offset: 0x000D8768
		[CallerCount(0)]
		public unsafe void AddLength(ulong length, Il2CppStructArray<byte> buffer, int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD5CryptoServiceProvider.NativeMethodInfoPtr_AddLength_Internal_Void_UInt64_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x0000D4F8 File Offset: 0x0000B6F8
		public MD5CryptoServiceProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06002886 RID: 10374 RVA: 0x000DA5C8 File Offset: 0x000D87C8
		// (set) Token: 0x06002887 RID: 10375 RVA: 0x0000D501 File Offset: 0x0000B701
		public unsafe Il2CppStructArray<uint> _H
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD5CryptoServiceProvider.NativeFieldInfoPtr__H);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD5CryptoServiceProvider.NativeFieldInfoPtr__H), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06002888 RID: 10376 RVA: 0x000DA5F8 File Offset: 0x000D87F8
		// (set) Token: 0x06002889 RID: 10377 RVA: 0x0000D520 File Offset: 0x0000B720
		public unsafe Il2CppStructArray<uint> buff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD5CryptoServiceProvider.NativeFieldInfoPtr_buff);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD5CryptoServiceProvider.NativeFieldInfoPtr_buff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x0600288A RID: 10378 RVA: 0x000DA628 File Offset: 0x000D8828
		// (set) Token: 0x0600288B RID: 10379 RVA: 0x0000D53F File Offset: 0x0000B73F
		public unsafe ulong count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD5CryptoServiceProvider.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD5CryptoServiceProvider.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x0600288C RID: 10380 RVA: 0x000DA650 File Offset: 0x000D8850
		// (set) Token: 0x0600288D RID: 10381 RVA: 0x0000D55A File Offset: 0x0000B75A
		public unsafe Il2CppStructArray<byte> _ProcessingBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD5CryptoServiceProvider.NativeFieldInfoPtr__ProcessingBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD5CryptoServiceProvider.NativeFieldInfoPtr__ProcessingBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x0600288E RID: 10382 RVA: 0x000DA680 File Offset: 0x000D8880
		// (set) Token: 0x0600288F RID: 10383 RVA: 0x0000D579 File Offset: 0x0000B779
		public unsafe int _ProcessingBufferCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD5CryptoServiceProvider.NativeFieldInfoPtr__ProcessingBufferCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD5CryptoServiceProvider.NativeFieldInfoPtr__ProcessingBufferCount)) = value;
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06002890 RID: 10384 RVA: 0x000DA6A8 File Offset: 0x000D88A8
		// (set) Token: 0x06002891 RID: 10385 RVA: 0x0000D594 File Offset: 0x0000B794
		public unsafe static Il2CppStructArray<uint> K
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MD5CryptoServiceProvider.NativeFieldInfoPtr_K, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MD5CryptoServiceProvider.NativeFieldInfoPtr_K, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040022A2 RID: 8866
		private static readonly IntPtr NativeFieldInfoPtr__H;

		// Token: 0x040022A3 RID: 8867
		private static readonly IntPtr NativeFieldInfoPtr_buff;

		// Token: 0x040022A4 RID: 8868
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x040022A5 RID: 8869
		private static readonly IntPtr NativeFieldInfoPtr__ProcessingBuffer;

		// Token: 0x040022A6 RID: 8870
		private static readonly IntPtr NativeFieldInfoPtr__ProcessingBufferCount;

		// Token: 0x040022A7 RID: 8871
		private static readonly IntPtr NativeFieldInfoPtr_K;

		// Token: 0x040022A8 RID: 8872
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040022A9 RID: 8873
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040022AA RID: 8874
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x040022AB RID: 8875
		private static readonly IntPtr NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040022AC RID: 8876
		private static readonly IntPtr NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x040022AD RID: 8877
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x040022AE RID: 8878
		private static readonly IntPtr NativeMethodInfoPtr_ProcessBlock_Private_Void_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040022AF RID: 8879
		private static readonly IntPtr NativeMethodInfoPtr_ProcessFinalBlock_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040022B0 RID: 8880
		private static readonly IntPtr NativeMethodInfoPtr_AddLength_Internal_Void_UInt64_Il2CppStructArray_1_Byte_Int32_0;
	}
}

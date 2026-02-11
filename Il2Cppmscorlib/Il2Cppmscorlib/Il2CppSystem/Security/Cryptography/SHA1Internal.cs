using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000278 RID: 632
	public class SHA1Internal : Object
	{
		// Token: 0x060028C1 RID: 10433 RVA: 0x000DB01C File Offset: 0x000D921C
		// Note: this type is marked as 'beforefieldinit'.
		static SHA1Internal()
		{
			Il2CppClassPointerStore<SHA1Internal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "SHA1Internal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SHA1Internal>.NativeClassPtr);
			SHA1Internal.NativeFieldInfoPtr__H = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA1Internal>.NativeClassPtr, "_H");
			SHA1Internal.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA1Internal>.NativeClassPtr, "count");
			SHA1Internal.NativeFieldInfoPtr__ProcessingBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA1Internal>.NativeClassPtr, "_ProcessingBuffer");
			SHA1Internal.NativeFieldInfoPtr__ProcessingBufferCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA1Internal>.NativeClassPtr, "_ProcessingBufferCount");
			SHA1Internal.NativeFieldInfoPtr_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA1Internal>.NativeClassPtr, "buff");
			SHA1Internal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Internal>.NativeClassPtr, 100669971);
			SHA1Internal.NativeMethodInfoPtr_HashCore_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Internal>.NativeClassPtr, 100669972);
			SHA1Internal.NativeMethodInfoPtr_HashFinal_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Internal>.NativeClassPtr, 100669973);
			SHA1Internal.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Internal>.NativeClassPtr, 100669974);
			SHA1Internal.NativeMethodInfoPtr_ProcessBlock_Private_Void_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Internal>.NativeClassPtr, 100669975);
			SHA1Internal.NativeMethodInfoPtr_InitialiseBuff_Private_Static_Void_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Internal>.NativeClassPtr, 100669976);
			SHA1Internal.NativeMethodInfoPtr_FillBuff_Private_Static_Void_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Internal>.NativeClassPtr, 100669977);
			SHA1Internal.NativeMethodInfoPtr_ProcessFinalBlock_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Internal>.NativeClassPtr, 100669978);
			SHA1Internal.NativeMethodInfoPtr_AddLength_Internal_Void_UInt64_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Internal>.NativeClassPtr, 100669979);
		}

		// Token: 0x060028C2 RID: 10434 RVA: 0x000DB164 File Offset: 0x000D9364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1374968, XrefRangeEnd = 1374981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SHA1Internal()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SHA1Internal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1Internal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x000DB1A0 File Offset: 0x000D93A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1374981, XrefRangeEnd = 1374985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HashCore(Il2CppStructArray<byte> rgb, int ibStart, int cbSize)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1Internal.NativeMethodInfoPtr_HashCore_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028C4 RID: 10436 RVA: 0x000DB200 File Offset: 0x000D9400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1374985, XrefRangeEnd = 1374989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> HashFinal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1Internal.NativeMethodInfoPtr_HashFinal_Public_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060028C5 RID: 10437 RVA: 0x000DB240 File Offset: 0x000D9440
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1374989, RefRangeEnd = 1374992, XrefRangeStart = 1374989, XrefRangeEnd = 1374989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1Internal.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028C6 RID: 10438 RVA: 0x000DB274 File Offset: 0x000D9474
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1374994, RefRangeEnd = 1375000, XrefRangeStart = 1374992, XrefRangeEnd = 1374994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessBlock(Il2CppStructArray<byte> inputBuffer, uint inputOffset)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1Internal.NativeMethodInfoPtr_ProcessBlock_Private_Void_Il2CppStructArray_1_Byte_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028C7 RID: 10439 RVA: 0x000DB2C4 File Offset: 0x000D94C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1375000, RefRangeEnd = 1375001, XrefRangeStart = 1375000, XrefRangeEnd = 1375000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitialiseBuff(Il2CppStructArray<uint> buff, Il2CppStructArray<byte> input, uint inputOffset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buff);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(input);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1Internal.NativeMethodInfoPtr_InitialiseBuff_Private_Static_Void_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x000DB31C File Offset: 0x000D951C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1375001, RefRangeEnd = 1375002, XrefRangeStart = 1375001, XrefRangeEnd = 1375001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FillBuff(Il2CppStructArray<uint> buff)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buff);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1Internal.NativeMethodInfoPtr_FillBuff_Private_Static_Void_Il2CppStructArray_1_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x000DB354 File Offset: 0x000D9554
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1375009, RefRangeEnd = 1375011, XrefRangeStart = 1375002, XrefRangeEnd = 1375009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1Internal.NativeMethodInfoPtr_ProcessFinalBlock_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028CA RID: 10442 RVA: 0x000DB3B4 File Offset: 0x000D95B4
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1Internal.NativeMethodInfoPtr_AddLength_Internal_Void_UInt64_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028CB RID: 10443 RVA: 0x0000D726 File Offset: 0x0000B926
		public SHA1Internal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x060028CC RID: 10444 RVA: 0x000DB414 File Offset: 0x000D9614
		// (set) Token: 0x060028CD RID: 10445 RVA: 0x0000D72F File Offset: 0x0000B92F
		public unsafe Il2CppStructArray<uint> _H
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Internal.NativeFieldInfoPtr__H);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Internal.NativeFieldInfoPtr__H), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x060028CE RID: 10446 RVA: 0x000DB444 File Offset: 0x000D9644
		// (set) Token: 0x060028CF RID: 10447 RVA: 0x0000D74E File Offset: 0x0000B94E
		public unsafe ulong count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Internal.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Internal.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x060028D0 RID: 10448 RVA: 0x000DB46C File Offset: 0x000D966C
		// (set) Token: 0x060028D1 RID: 10449 RVA: 0x0000D769 File Offset: 0x0000B969
		public unsafe Il2CppStructArray<byte> _ProcessingBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Internal.NativeFieldInfoPtr__ProcessingBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Internal.NativeFieldInfoPtr__ProcessingBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x060028D2 RID: 10450 RVA: 0x000DB49C File Offset: 0x000D969C
		// (set) Token: 0x060028D3 RID: 10451 RVA: 0x0000D788 File Offset: 0x0000B988
		public unsafe int _ProcessingBufferCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Internal.NativeFieldInfoPtr__ProcessingBufferCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Internal.NativeFieldInfoPtr__ProcessingBufferCount)) = value;
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x060028D4 RID: 10452 RVA: 0x000DB4C4 File Offset: 0x000D96C4
		// (set) Token: 0x060028D5 RID: 10453 RVA: 0x0000D7A3 File Offset: 0x0000B9A3
		public unsafe Il2CppStructArray<uint> buff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Internal.NativeFieldInfoPtr_buff);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Internal.NativeFieldInfoPtr_buff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040022CD RID: 8909
		private static readonly IntPtr NativeFieldInfoPtr__H;

		// Token: 0x040022CE RID: 8910
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x040022CF RID: 8911
		private static readonly IntPtr NativeFieldInfoPtr__ProcessingBuffer;

		// Token: 0x040022D0 RID: 8912
		private static readonly IntPtr NativeFieldInfoPtr__ProcessingBufferCount;

		// Token: 0x040022D1 RID: 8913
		private static readonly IntPtr NativeFieldInfoPtr_buff;

		// Token: 0x040022D2 RID: 8914
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040022D3 RID: 8915
		private static readonly IntPtr NativeMethodInfoPtr_HashCore_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040022D4 RID: 8916
		private static readonly IntPtr NativeMethodInfoPtr_HashFinal_Public_Il2CppStructArray_1_Byte_0;

		// Token: 0x040022D5 RID: 8917
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

		// Token: 0x040022D6 RID: 8918
		private static readonly IntPtr NativeMethodInfoPtr_ProcessBlock_Private_Void_Il2CppStructArray_1_Byte_UInt32_0;

		// Token: 0x040022D7 RID: 8919
		private static readonly IntPtr NativeMethodInfoPtr_InitialiseBuff_Private_Static_Void_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_Byte_UInt32_0;

		// Token: 0x040022D8 RID: 8920
		private static readonly IntPtr NativeMethodInfoPtr_FillBuff_Private_Static_Void_Il2CppStructArray_1_UInt32_0;

		// Token: 0x040022D9 RID: 8921
		private static readonly IntPtr NativeMethodInfoPtr_ProcessFinalBlock_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040022DA RID: 8922
		private static readonly IntPtr NativeMethodInfoPtr_AddLength_Internal_Void_UInt64_Il2CppStructArray_1_Byte_Int32_0;
	}
}

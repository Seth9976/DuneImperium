using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200025E RID: 606
	public class SHA1Managed : SHA1
	{
		// Token: 0x06002744 RID: 10052 RVA: 0x000D5AAC File Offset: 0x000D3CAC
		// Note: this type is marked as 'beforefieldinit'.
		static SHA1Managed()
		{
			Il2CppClassPointerStore<SHA1Managed>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "SHA1Managed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SHA1Managed>.NativeClassPtr);
			SHA1Managed.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA1Managed>.NativeClassPtr, "_buffer");
			SHA1Managed.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA1Managed>.NativeClassPtr, "_count");
			SHA1Managed.NativeFieldInfoPtr__stateSHA1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA1Managed>.NativeClassPtr, "_stateSHA1");
			SHA1Managed.NativeFieldInfoPtr__expandedBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA1Managed>.NativeClassPtr, "_expandedBuffer");
			SHA1Managed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Managed>.NativeClassPtr, 100669784);
			SHA1Managed.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Managed>.NativeClassPtr, 100669785);
			SHA1Managed.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Managed>.NativeClassPtr, 100669786);
			SHA1Managed.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Managed>.NativeClassPtr, 100669787);
			SHA1Managed.NativeMethodInfoPtr_InitializeState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Managed>.NativeClassPtr, 100669788);
			SHA1Managed.NativeMethodInfoPtr__HashData_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Managed>.NativeClassPtr, 100669789);
			SHA1Managed.NativeMethodInfoPtr__EndHash_Private_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Managed>.NativeClassPtr, 100669790);
			SHA1Managed.NativeMethodInfoPtr_SHATransform_Private_Static_Void_ptr_UInt32_ptr_UInt32_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Managed>.NativeClassPtr, 100669791);
			SHA1Managed.NativeMethodInfoPtr_SHAExpand_Private_Static_Void_ptr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Managed>.NativeClassPtr, 100669792);
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x000D5BE0 File Offset: 0x000D3DE0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1373290, RefRangeEnd = 1373298, XrefRangeStart = 1373274, XrefRangeEnd = 1373290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SHA1Managed()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SHA1Managed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1Managed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002746 RID: 10054 RVA: 0x000D5C1C File Offset: 0x000D3E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373298, XrefRangeEnd = 1373302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SHA1Managed.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x000D5C58 File Offset: 0x000D3E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373302, XrefRangeEnd = 1373303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SHA1Managed.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x000D5CC4 File Offset: 0x000D3EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373303, XrefRangeEnd = 1373304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> HashFinal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SHA1Managed.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x000D5D10 File Offset: 0x000D3F10
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1372885, RefRangeEnd = 1372889, XrefRangeStart = 1372885, XrefRangeEnd = 1372889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1Managed.NativeMethodInfoPtr_InitializeState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x000D5D44 File Offset: 0x000D3F44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1373312, RefRangeEnd = 1373314, XrefRangeStart = 1373304, XrefRangeEnd = 1373312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _HashData(Il2CppStructArray<byte> partIn, int ibStart, int cbSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(partIn);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ibStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1Managed.NativeMethodInfoPtr__HashData_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600274B RID: 10059 RVA: 0x000D5DA4 File Offset: 0x000D3FA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1373321, RefRangeEnd = 1373322, XrefRangeStart = 1373314, XrefRangeEnd = 1373321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> _EndHash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1Managed.NativeMethodInfoPtr__EndHash_Private_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600274C RID: 10060 RVA: 0x000D5DE4 File Offset: 0x000D3FE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1373322, RefRangeEnd = 1373324, XrefRangeStart = 1373322, XrefRangeEnd = 1373322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SHATransform(uint* expandedBuffer, uint* state, byte* block)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = expandedBuffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = block;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1Managed.NativeMethodInfoPtr_SHATransform_Private_Static_Void_ptr_UInt32_ptr_UInt32_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600274D RID: 10061 RVA: 0x000D5E30 File Offset: 0x000D4030
		[CallerCount(0)]
		public unsafe static void SHAExpand(uint* x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1Managed.NativeMethodInfoPtr_SHAExpand_Private_Static_Void_ptr_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600274E RID: 10062 RVA: 0x0000CD49 File Offset: 0x0000AF49
		public SHA1Managed(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x0600274F RID: 10063 RVA: 0x000D5E64 File Offset: 0x000D4064
		// (set) Token: 0x06002750 RID: 10064 RVA: 0x0000CD52 File Offset: 0x0000AF52
		public unsafe Il2CppStructArray<byte> _buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Managed.NativeFieldInfoPtr__buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Managed.NativeFieldInfoPtr__buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06002751 RID: 10065 RVA: 0x000D5E94 File Offset: 0x000D4094
		// (set) Token: 0x06002752 RID: 10066 RVA: 0x0000CD71 File Offset: 0x0000AF71
		public unsafe long _count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Managed.NativeFieldInfoPtr__count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Managed.NativeFieldInfoPtr__count)) = value;
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06002753 RID: 10067 RVA: 0x000D5EBC File Offset: 0x000D40BC
		// (set) Token: 0x06002754 RID: 10068 RVA: 0x0000CD8C File Offset: 0x0000AF8C
		public unsafe Il2CppStructArray<uint> _stateSHA1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Managed.NativeFieldInfoPtr__stateSHA1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Managed.NativeFieldInfoPtr__stateSHA1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06002755 RID: 10069 RVA: 0x000D5EEC File Offset: 0x000D40EC
		// (set) Token: 0x06002756 RID: 10070 RVA: 0x0000CDAB File Offset: 0x0000AFAB
		public unsafe Il2CppStructArray<uint> _expandedBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Managed.NativeFieldInfoPtr__expandedBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Managed.NativeFieldInfoPtr__expandedBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040021D0 RID: 8656
		private static readonly IntPtr NativeFieldInfoPtr__buffer;

		// Token: 0x040021D1 RID: 8657
		private static readonly IntPtr NativeFieldInfoPtr__count;

		// Token: 0x040021D2 RID: 8658
		private static readonly IntPtr NativeFieldInfoPtr__stateSHA1;

		// Token: 0x040021D3 RID: 8659
		private static readonly IntPtr NativeFieldInfoPtr__expandedBuffer;

		// Token: 0x040021D4 RID: 8660
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040021D5 RID: 8661
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x040021D6 RID: 8662
		private static readonly IntPtr NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040021D7 RID: 8663
		private static readonly IntPtr NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x040021D8 RID: 8664
		private static readonly IntPtr NativeMethodInfoPtr_InitializeState_Private_Void_0;

		// Token: 0x040021D9 RID: 8665
		private static readonly IntPtr NativeMethodInfoPtr__HashData_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040021DA RID: 8666
		private static readonly IntPtr NativeMethodInfoPtr__EndHash_Private_Il2CppStructArray_1_Byte_0;

		// Token: 0x040021DB RID: 8667
		private static readonly IntPtr NativeMethodInfoPtr_SHATransform_Private_Static_Void_ptr_UInt32_ptr_UInt32_ptr_Byte_0;

		// Token: 0x040021DC RID: 8668
		private static readonly IntPtr NativeMethodInfoPtr_SHAExpand_Private_Static_Void_ptr_UInt32_0;
	}
}

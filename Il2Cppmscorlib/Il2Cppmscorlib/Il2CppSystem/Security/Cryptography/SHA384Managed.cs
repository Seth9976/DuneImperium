using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000262 RID: 610
	public class SHA384Managed : SHA384
	{
		// Token: 0x0600277B RID: 10107 RVA: 0x000D67E8 File Offset: 0x000D49E8
		// Note: this type is marked as 'beforefieldinit'.
		static SHA384Managed()
		{
			Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "SHA384Managed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr);
			SHA384Managed.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, "_buffer");
			SHA384Managed.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, "_count");
			SHA384Managed.NativeFieldInfoPtr__stateSHA384 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, "_stateSHA384");
			SHA384Managed.NativeFieldInfoPtr__W = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, "_W");
			SHA384Managed.NativeFieldInfoPtr__K = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, "_K");
			SHA384Managed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, 100669814);
			SHA384Managed.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, 100669815);
			SHA384Managed.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, 100669816);
			SHA384Managed.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, 100669817);
			SHA384Managed.NativeMethodInfoPtr_InitializeState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, 100669818);
			SHA384Managed.NativeMethodInfoPtr__HashData_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, 100669819);
			SHA384Managed.NativeMethodInfoPtr__EndHash_Private_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, 100669820);
			SHA384Managed.NativeMethodInfoPtr_SHATransform_Private_Static_Void_ptr_UInt64_ptr_UInt64_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, 100669821);
			SHA384Managed.NativeMethodInfoPtr_RotateRight_Private_Static_UInt64_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, 100669822);
			SHA384Managed.NativeMethodInfoPtr_Ch_Private_Static_UInt64_UInt64_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, 100669823);
			SHA384Managed.NativeMethodInfoPtr_Maj_Private_Static_UInt64_UInt64_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, 100669824);
			SHA384Managed.NativeMethodInfoPtr_Sigma_0_Private_Static_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, 100669825);
			SHA384Managed.NativeMethodInfoPtr_Sigma_1_Private_Static_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, 100669826);
			SHA384Managed.NativeMethodInfoPtr_sigma_0_Private_Static_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, 100669827);
			SHA384Managed.NativeMethodInfoPtr_sigma_1_Private_Static_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, 100669828);
			SHA384Managed.NativeMethodInfoPtr_SHA384Expand_Private_Static_Void_ptr_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr, 100669829);
		}

		// Token: 0x0600277C RID: 10108 RVA: 0x000D69BC File Offset: 0x000D4BBC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1373504, RefRangeEnd = 1373509, XrefRangeStart = 1373488, XrefRangeEnd = 1373504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SHA384Managed()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SHA384Managed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA384Managed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600277D RID: 10109 RVA: 0x000D69F8 File Offset: 0x000D4BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373509, XrefRangeEnd = 1373513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SHA384Managed.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600277E RID: 10110 RVA: 0x000D6A34 File Offset: 0x000D4C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373513, XrefRangeEnd = 1373514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SHA384Managed.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x000D6AA0 File Offset: 0x000D4CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373514, XrefRangeEnd = 1373515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> HashFinal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SHA384Managed.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x000D6AEC File Offset: 0x000D4CEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1373515, RefRangeEnd = 1373517, XrefRangeStart = 1373515, XrefRangeEnd = 1373515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA384Managed.NativeMethodInfoPtr_InitializeState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002781 RID: 10113 RVA: 0x000D6B20 File Offset: 0x000D4D20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1373530, RefRangeEnd = 1373532, XrefRangeStart = 1373517, XrefRangeEnd = 1373530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA384Managed.NativeMethodInfoPtr__HashData_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x000D6B80 File Offset: 0x000D4D80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1373540, RefRangeEnd = 1373541, XrefRangeStart = 1373532, XrefRangeEnd = 1373540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> _EndHash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA384Managed.NativeMethodInfoPtr__EndHash_Private_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06002783 RID: 10115 RVA: 0x000D6BC0 File Offset: 0x000D4DC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1373611, RefRangeEnd = 1373613, XrefRangeStart = 1373541, XrefRangeEnd = 1373611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA384Managed.NativeMethodInfoPtr_SHATransform_Private_Static_Void_ptr_UInt64_ptr_UInt64_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002784 RID: 10116 RVA: 0x000D6C0C File Offset: 0x000D4E0C
		[CallerCount(0)]
		public unsafe static ulong RotateRight(ulong x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA384Managed.NativeMethodInfoPtr_RotateRight_Private_Static_UInt64_UInt64_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002785 RID: 10117 RVA: 0x000D6C58 File Offset: 0x000D4E58
		[CallerCount(0)]
		public unsafe static ulong Ch(ulong x, ulong y, ulong z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA384Managed.NativeMethodInfoPtr_Ch_Private_Static_UInt64_UInt64_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x000D6CB4 File Offset: 0x000D4EB4
		[CallerCount(0)]
		public unsafe static ulong Maj(ulong x, ulong y, ulong z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA384Managed.NativeMethodInfoPtr_Maj_Private_Static_UInt64_UInt64_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002787 RID: 10119 RVA: 0x000D6D10 File Offset: 0x000D4F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373613, XrefRangeEnd = 1373616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong Sigma_0(ulong x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA384Managed.NativeMethodInfoPtr_Sigma_0_Private_Static_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002788 RID: 10120 RVA: 0x000D6D50 File Offset: 0x000D4F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373616, XrefRangeEnd = 1373619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong Sigma_1(ulong x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA384Managed.NativeMethodInfoPtr_Sigma_1_Private_Static_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x000D6D90 File Offset: 0x000D4F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373619, XrefRangeEnd = 1373622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong sigma_0(ulong x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA384Managed.NativeMethodInfoPtr_sigma_0_Private_Static_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600278A RID: 10122 RVA: 0x000D6DD0 File Offset: 0x000D4FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373622, XrefRangeEnd = 1373625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong sigma_1(ulong x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA384Managed.NativeMethodInfoPtr_sigma_1_Private_Static_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600278B RID: 10123 RVA: 0x000D6E10 File Offset: 0x000D5010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373625, XrefRangeEnd = 1373634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SHA384Expand(ulong* x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA384Managed.NativeMethodInfoPtr_SHA384Expand_Private_Static_Void_ptr_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600278C RID: 10124 RVA: 0x0000CE6F File Offset: 0x0000B06F
		public SHA384Managed(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x0600278D RID: 10125 RVA: 0x000D6E44 File Offset: 0x000D5044
		// (set) Token: 0x0600278E RID: 10126 RVA: 0x0000CE78 File Offset: 0x0000B078
		public unsafe Il2CppStructArray<byte> _buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA384Managed.NativeFieldInfoPtr__buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA384Managed.NativeFieldInfoPtr__buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x0600278F RID: 10127 RVA: 0x000D6E74 File Offset: 0x000D5074
		// (set) Token: 0x06002790 RID: 10128 RVA: 0x0000CE97 File Offset: 0x0000B097
		public unsafe ulong _count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA384Managed.NativeFieldInfoPtr__count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA384Managed.NativeFieldInfoPtr__count)) = value;
			}
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06002791 RID: 10129 RVA: 0x000D6E9C File Offset: 0x000D509C
		// (set) Token: 0x06002792 RID: 10130 RVA: 0x0000CEB2 File Offset: 0x0000B0B2
		public unsafe Il2CppStructArray<ulong> _stateSHA384
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA384Managed.NativeFieldInfoPtr__stateSHA384);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA384Managed.NativeFieldInfoPtr__stateSHA384), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06002793 RID: 10131 RVA: 0x000D6ECC File Offset: 0x000D50CC
		// (set) Token: 0x06002794 RID: 10132 RVA: 0x0000CED1 File Offset: 0x0000B0D1
		public unsafe Il2CppStructArray<ulong> _W
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA384Managed.NativeFieldInfoPtr__W);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA384Managed.NativeFieldInfoPtr__W), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06002795 RID: 10133 RVA: 0x000D6EFC File Offset: 0x000D50FC
		// (set) Token: 0x06002796 RID: 10134 RVA: 0x0000CEF0 File Offset: 0x0000B0F0
		public unsafe static Il2CppStructArray<ulong> _K
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SHA384Managed.NativeFieldInfoPtr__K, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SHA384Managed.NativeFieldInfoPtr__K, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040021F6 RID: 8694
		private static readonly IntPtr NativeFieldInfoPtr__buffer;

		// Token: 0x040021F7 RID: 8695
		private static readonly IntPtr NativeFieldInfoPtr__count;

		// Token: 0x040021F8 RID: 8696
		private static readonly IntPtr NativeFieldInfoPtr__stateSHA384;

		// Token: 0x040021F9 RID: 8697
		private static readonly IntPtr NativeFieldInfoPtr__W;

		// Token: 0x040021FA RID: 8698
		private static readonly IntPtr NativeFieldInfoPtr__K;

		// Token: 0x040021FB RID: 8699
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040021FC RID: 8700
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x040021FD RID: 8701
		private static readonly IntPtr NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040021FE RID: 8702
		private static readonly IntPtr NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x040021FF RID: 8703
		private static readonly IntPtr NativeMethodInfoPtr_InitializeState_Private_Void_0;

		// Token: 0x04002200 RID: 8704
		private static readonly IntPtr NativeMethodInfoPtr__HashData_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002201 RID: 8705
		private static readonly IntPtr NativeMethodInfoPtr__EndHash_Private_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002202 RID: 8706
		private static readonly IntPtr NativeMethodInfoPtr_SHATransform_Private_Static_Void_ptr_UInt64_ptr_UInt64_ptr_Byte_0;

		// Token: 0x04002203 RID: 8707
		private static readonly IntPtr NativeMethodInfoPtr_RotateRight_Private_Static_UInt64_UInt64_Int32_0;

		// Token: 0x04002204 RID: 8708
		private static readonly IntPtr NativeMethodInfoPtr_Ch_Private_Static_UInt64_UInt64_UInt64_UInt64_0;

		// Token: 0x04002205 RID: 8709
		private static readonly IntPtr NativeMethodInfoPtr_Maj_Private_Static_UInt64_UInt64_UInt64_UInt64_0;

		// Token: 0x04002206 RID: 8710
		private static readonly IntPtr NativeMethodInfoPtr_Sigma_0_Private_Static_UInt64_UInt64_0;

		// Token: 0x04002207 RID: 8711
		private static readonly IntPtr NativeMethodInfoPtr_Sigma_1_Private_Static_UInt64_UInt64_0;

		// Token: 0x04002208 RID: 8712
		private static readonly IntPtr NativeMethodInfoPtr_sigma_0_Private_Static_UInt64_UInt64_0;

		// Token: 0x04002209 RID: 8713
		private static readonly IntPtr NativeMethodInfoPtr_sigma_1_Private_Static_UInt64_UInt64_0;

		// Token: 0x0400220A RID: 8714
		private static readonly IntPtr NativeMethodInfoPtr_SHA384Expand_Private_Static_Void_ptr_UInt64_0;
	}
}

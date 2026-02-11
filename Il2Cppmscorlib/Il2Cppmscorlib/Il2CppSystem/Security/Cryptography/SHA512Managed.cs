using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000264 RID: 612
	public class SHA512Managed : SHA512
	{
		// Token: 0x0600279B RID: 10139 RVA: 0x000D6FEC File Offset: 0x000D51EC
		// Note: this type is marked as 'beforefieldinit'.
		static SHA512Managed()
		{
			Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "SHA512Managed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr);
			SHA512Managed.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, "_buffer");
			SHA512Managed.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, "_count");
			SHA512Managed.NativeFieldInfoPtr__stateSHA512 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, "_stateSHA512");
			SHA512Managed.NativeFieldInfoPtr__W = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, "_W");
			SHA512Managed.NativeFieldInfoPtr__K = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, "_K");
			SHA512Managed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, 100669833);
			SHA512Managed.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, 100669834);
			SHA512Managed.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, 100669835);
			SHA512Managed.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, 100669836);
			SHA512Managed.NativeMethodInfoPtr_InitializeState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, 100669837);
			SHA512Managed.NativeMethodInfoPtr__HashData_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, 100669838);
			SHA512Managed.NativeMethodInfoPtr__EndHash_Private_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, 100669839);
			SHA512Managed.NativeMethodInfoPtr_SHATransform_Private_Static_Void_ptr_UInt64_ptr_UInt64_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, 100669840);
			SHA512Managed.NativeMethodInfoPtr_RotateRight_Private_Static_UInt64_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, 100669841);
			SHA512Managed.NativeMethodInfoPtr_Ch_Private_Static_UInt64_UInt64_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, 100669842);
			SHA512Managed.NativeMethodInfoPtr_Maj_Private_Static_UInt64_UInt64_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, 100669843);
			SHA512Managed.NativeMethodInfoPtr_Sigma_0_Private_Static_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, 100669844);
			SHA512Managed.NativeMethodInfoPtr_Sigma_1_Private_Static_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, 100669845);
			SHA512Managed.NativeMethodInfoPtr_sigma_0_Private_Static_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, 100669846);
			SHA512Managed.NativeMethodInfoPtr_sigma_1_Private_Static_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, 100669847);
			SHA512Managed.NativeMethodInfoPtr_SHA512Expand_Private_Static_Void_ptr_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr, 100669848);
		}

		// Token: 0x0600279C RID: 10140 RVA: 0x000D71C0 File Offset: 0x000D53C0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1373658, RefRangeEnd = 1373663, XrefRangeStart = 1373642, XrefRangeEnd = 1373658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SHA512Managed()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SHA512Managed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA512Managed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600279D RID: 10141 RVA: 0x000D71FC File Offset: 0x000D53FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373663, XrefRangeEnd = 1373667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SHA512Managed.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600279E RID: 10142 RVA: 0x000D7238 File Offset: 0x000D5438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373667, XrefRangeEnd = 1373668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SHA512Managed.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600279F RID: 10143 RVA: 0x000D72A4 File Offset: 0x000D54A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373668, XrefRangeEnd = 1373669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> HashFinal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SHA512Managed.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060027A0 RID: 10144 RVA: 0x000D72F0 File Offset: 0x000D54F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1373669, RefRangeEnd = 1373671, XrefRangeStart = 1373669, XrefRangeEnd = 1373669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA512Managed.NativeMethodInfoPtr_InitializeState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027A1 RID: 10145 RVA: 0x000D7324 File Offset: 0x000D5524
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1373684, RefRangeEnd = 1373686, XrefRangeStart = 1373671, XrefRangeEnd = 1373684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA512Managed.NativeMethodInfoPtr__HashData_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027A2 RID: 10146 RVA: 0x000D7384 File Offset: 0x000D5584
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1373694, RefRangeEnd = 1373695, XrefRangeStart = 1373686, XrefRangeEnd = 1373694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> _EndHash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA512Managed.NativeMethodInfoPtr__EndHash_Private_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060027A3 RID: 10147 RVA: 0x000D73C4 File Offset: 0x000D55C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1373765, RefRangeEnd = 1373767, XrefRangeStart = 1373695, XrefRangeEnd = 1373765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA512Managed.NativeMethodInfoPtr_SHATransform_Private_Static_Void_ptr_UInt64_ptr_UInt64_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x000D7410 File Offset: 0x000D5610
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA512Managed.NativeMethodInfoPtr_RotateRight_Private_Static_UInt64_UInt64_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027A5 RID: 10149 RVA: 0x000D745C File Offset: 0x000D565C
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA512Managed.NativeMethodInfoPtr_Ch_Private_Static_UInt64_UInt64_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027A6 RID: 10150 RVA: 0x000D74B8 File Offset: 0x000D56B8
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA512Managed.NativeMethodInfoPtr_Maj_Private_Static_UInt64_UInt64_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x000D7514 File Offset: 0x000D5714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373767, XrefRangeEnd = 1373770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong Sigma_0(ulong x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA512Managed.NativeMethodInfoPtr_Sigma_0_Private_Static_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060027A8 RID: 10152 RVA: 0x000D7554 File Offset: 0x000D5754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373770, XrefRangeEnd = 1373773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong Sigma_1(ulong x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA512Managed.NativeMethodInfoPtr_Sigma_1_Private_Static_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060027A9 RID: 10153 RVA: 0x000D7594 File Offset: 0x000D5794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373773, XrefRangeEnd = 1373776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong sigma_0(ulong x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA512Managed.NativeMethodInfoPtr_sigma_0_Private_Static_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060027AA RID: 10154 RVA: 0x000D75D4 File Offset: 0x000D57D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373776, XrefRangeEnd = 1373779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong sigma_1(ulong x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA512Managed.NativeMethodInfoPtr_sigma_1_Private_Static_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060027AB RID: 10155 RVA: 0x000D7614 File Offset: 0x000D5814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373779, XrefRangeEnd = 1373788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SHA512Expand(ulong* x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA512Managed.NativeMethodInfoPtr_SHA512Expand_Private_Static_Void_ptr_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027AC RID: 10156 RVA: 0x0000CF0B File Offset: 0x0000B10B
		public SHA512Managed(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x060027AD RID: 10157 RVA: 0x000D7648 File Offset: 0x000D5848
		// (set) Token: 0x060027AE RID: 10158 RVA: 0x0000CF14 File Offset: 0x0000B114
		public unsafe Il2CppStructArray<byte> _buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA512Managed.NativeFieldInfoPtr__buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA512Managed.NativeFieldInfoPtr__buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x060027AF RID: 10159 RVA: 0x000D7678 File Offset: 0x000D5878
		// (set) Token: 0x060027B0 RID: 10160 RVA: 0x0000CF33 File Offset: 0x0000B133
		public unsafe ulong _count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA512Managed.NativeFieldInfoPtr__count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA512Managed.NativeFieldInfoPtr__count)) = value;
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x060027B1 RID: 10161 RVA: 0x000D76A0 File Offset: 0x000D58A0
		// (set) Token: 0x060027B2 RID: 10162 RVA: 0x0000CF4E File Offset: 0x0000B14E
		public unsafe Il2CppStructArray<ulong> _stateSHA512
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA512Managed.NativeFieldInfoPtr__stateSHA512);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA512Managed.NativeFieldInfoPtr__stateSHA512), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x060027B3 RID: 10163 RVA: 0x000D76D0 File Offset: 0x000D58D0
		// (set) Token: 0x060027B4 RID: 10164 RVA: 0x0000CF6D File Offset: 0x0000B16D
		public unsafe Il2CppStructArray<ulong> _W
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA512Managed.NativeFieldInfoPtr__W);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA512Managed.NativeFieldInfoPtr__W), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x060027B5 RID: 10165 RVA: 0x000D7700 File Offset: 0x000D5900
		// (set) Token: 0x060027B6 RID: 10166 RVA: 0x0000CF8C File Offset: 0x0000B18C
		public unsafe static Il2CppStructArray<ulong> _K
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SHA512Managed.NativeFieldInfoPtr__K, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SHA512Managed.NativeFieldInfoPtr__K, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400220D RID: 8717
		private static readonly IntPtr NativeFieldInfoPtr__buffer;

		// Token: 0x0400220E RID: 8718
		private static readonly IntPtr NativeFieldInfoPtr__count;

		// Token: 0x0400220F RID: 8719
		private static readonly IntPtr NativeFieldInfoPtr__stateSHA512;

		// Token: 0x04002210 RID: 8720
		private static readonly IntPtr NativeFieldInfoPtr__W;

		// Token: 0x04002211 RID: 8721
		private static readonly IntPtr NativeFieldInfoPtr__K;

		// Token: 0x04002212 RID: 8722
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002213 RID: 8723
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x04002214 RID: 8724
		private static readonly IntPtr NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002215 RID: 8725
		private static readonly IntPtr NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002216 RID: 8726
		private static readonly IntPtr NativeMethodInfoPtr_InitializeState_Private_Void_0;

		// Token: 0x04002217 RID: 8727
		private static readonly IntPtr NativeMethodInfoPtr__HashData_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002218 RID: 8728
		private static readonly IntPtr NativeMethodInfoPtr__EndHash_Private_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002219 RID: 8729
		private static readonly IntPtr NativeMethodInfoPtr_SHATransform_Private_Static_Void_ptr_UInt64_ptr_UInt64_ptr_Byte_0;

		// Token: 0x0400221A RID: 8730
		private static readonly IntPtr NativeMethodInfoPtr_RotateRight_Private_Static_UInt64_UInt64_Int32_0;

		// Token: 0x0400221B RID: 8731
		private static readonly IntPtr NativeMethodInfoPtr_Ch_Private_Static_UInt64_UInt64_UInt64_UInt64_0;

		// Token: 0x0400221C RID: 8732
		private static readonly IntPtr NativeMethodInfoPtr_Maj_Private_Static_UInt64_UInt64_UInt64_UInt64_0;

		// Token: 0x0400221D RID: 8733
		private static readonly IntPtr NativeMethodInfoPtr_Sigma_0_Private_Static_UInt64_UInt64_0;

		// Token: 0x0400221E RID: 8734
		private static readonly IntPtr NativeMethodInfoPtr_Sigma_1_Private_Static_UInt64_UInt64_0;

		// Token: 0x0400221F RID: 8735
		private static readonly IntPtr NativeMethodInfoPtr_sigma_0_Private_Static_UInt64_UInt64_0;

		// Token: 0x04002220 RID: 8736
		private static readonly IntPtr NativeMethodInfoPtr_sigma_1_Private_Static_UInt64_UInt64_0;

		// Token: 0x04002221 RID: 8737
		private static readonly IntPtr NativeMethodInfoPtr_SHA512Expand_Private_Static_Void_ptr_UInt64_0;
	}
}

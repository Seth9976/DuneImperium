using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000260 RID: 608
	public class SHA256Managed : SHA256
	{
		// Token: 0x0600275B RID: 10075 RVA: 0x000D5FE4 File Offset: 0x000D41E4
		// Note: this type is marked as 'beforefieldinit'.
		static SHA256Managed()
		{
			Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "SHA256Managed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr);
			SHA256Managed.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, "_buffer");
			SHA256Managed.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, "_count");
			SHA256Managed.NativeFieldInfoPtr__stateSHA256 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, "_stateSHA256");
			SHA256Managed.NativeFieldInfoPtr__W = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, "_W");
			SHA256Managed.NativeFieldInfoPtr__K = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, "_K");
			SHA256Managed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100669795);
			SHA256Managed.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100669796);
			SHA256Managed.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100669797);
			SHA256Managed.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100669798);
			SHA256Managed.NativeMethodInfoPtr_InitializeState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100669799);
			SHA256Managed.NativeMethodInfoPtr__HashData_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100669800);
			SHA256Managed.NativeMethodInfoPtr__EndHash_Private_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100669801);
			SHA256Managed.NativeMethodInfoPtr_SHATransform_Private_Static_Void_ptr_UInt32_ptr_UInt32_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100669802);
			SHA256Managed.NativeMethodInfoPtr_RotateRight_Private_Static_UInt32_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100669803);
			SHA256Managed.NativeMethodInfoPtr_Ch_Private_Static_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100669804);
			SHA256Managed.NativeMethodInfoPtr_Maj_Private_Static_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100669805);
			SHA256Managed.NativeMethodInfoPtr_sigma_0_Private_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100669806);
			SHA256Managed.NativeMethodInfoPtr_sigma_1_Private_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100669807);
			SHA256Managed.NativeMethodInfoPtr_Sigma_0_Private_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100669808);
			SHA256Managed.NativeMethodInfoPtr_Sigma_1_Private_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100669809);
			SHA256Managed.NativeMethodInfoPtr_SHA256Expand_Private_Static_Void_ptr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100669810);
		}

		// Token: 0x0600275C RID: 10076 RVA: 0x000D61B8 File Offset: 0x000D43B8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1373352, RefRangeEnd = 1373357, XrefRangeStart = 1373336, XrefRangeEnd = 1373352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SHA256Managed()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600275D RID: 10077 RVA: 0x000D61F4 File Offset: 0x000D43F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373357, XrefRangeEnd = 1373361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SHA256Managed.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600275E RID: 10078 RVA: 0x000D6230 File Offset: 0x000D4430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373361, XrefRangeEnd = 1373362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SHA256Managed.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600275F RID: 10079 RVA: 0x000D629C File Offset: 0x000D449C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373362, XrefRangeEnd = 1373363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> HashFinal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SHA256Managed.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06002760 RID: 10080 RVA: 0x000D62E8 File Offset: 0x000D44E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1373363, RefRangeEnd = 1373365, XrefRangeStart = 1373363, XrefRangeEnd = 1373363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr_InitializeState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x000D631C File Offset: 0x000D451C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1373378, RefRangeEnd = 1373380, XrefRangeStart = 1373365, XrefRangeEnd = 1373378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr__HashData_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002762 RID: 10082 RVA: 0x000D637C File Offset: 0x000D457C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1373387, RefRangeEnd = 1373388, XrefRangeStart = 1373380, XrefRangeEnd = 1373387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> _EndHash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr__EndHash_Private_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06002763 RID: 10083 RVA: 0x000D63BC File Offset: 0x000D45BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1373458, RefRangeEnd = 1373460, XrefRangeStart = 1373388, XrefRangeEnd = 1373458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr_SHATransform_Private_Static_Void_ptr_UInt32_ptr_UInt32_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002764 RID: 10084 RVA: 0x000D6408 File Offset: 0x000D4608
		[CallerCount(0)]
		public unsafe static uint RotateRight(uint x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr_RotateRight_Private_Static_UInt32_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x000D6454 File Offset: 0x000D4654
		[CallerCount(0)]
		public unsafe static uint Ch(uint x, uint y, uint z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr_Ch_Private_Static_UInt32_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002766 RID: 10086 RVA: 0x000D64B0 File Offset: 0x000D46B0
		[CallerCount(0)]
		public unsafe static uint Maj(uint x, uint y, uint z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr_Maj_Private_Static_UInt32_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x000D650C File Offset: 0x000D470C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373460, XrefRangeEnd = 1373463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint sigma_0(uint x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr_sigma_0_Private_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002768 RID: 10088 RVA: 0x000D654C File Offset: 0x000D474C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373463, XrefRangeEnd = 1373466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint sigma_1(uint x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr_sigma_1_Private_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002769 RID: 10089 RVA: 0x000D658C File Offset: 0x000D478C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373466, XrefRangeEnd = 1373469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint Sigma_0(uint x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr_Sigma_0_Private_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600276A RID: 10090 RVA: 0x000D65CC File Offset: 0x000D47CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373469, XrefRangeEnd = 1373472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint Sigma_1(uint x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr_Sigma_1_Private_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600276B RID: 10091 RVA: 0x000D660C File Offset: 0x000D480C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373472, XrefRangeEnd = 1373481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SHA256Expand(uint* x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr_SHA256Expand_Private_Static_Void_ptr_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600276C RID: 10092 RVA: 0x0000CDD3 File Offset: 0x0000AFD3
		public SHA256Managed(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x0600276D RID: 10093 RVA: 0x000D6640 File Offset: 0x000D4840
		// (set) Token: 0x0600276E RID: 10094 RVA: 0x0000CDDC File Offset: 0x0000AFDC
		public unsafe Il2CppStructArray<byte> _buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA256Managed.NativeFieldInfoPtr__buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA256Managed.NativeFieldInfoPtr__buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x0600276F RID: 10095 RVA: 0x000D6670 File Offset: 0x000D4870
		// (set) Token: 0x06002770 RID: 10096 RVA: 0x0000CDFB File Offset: 0x0000AFFB
		public unsafe long _count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA256Managed.NativeFieldInfoPtr__count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA256Managed.NativeFieldInfoPtr__count)) = value;
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06002771 RID: 10097 RVA: 0x000D6698 File Offset: 0x000D4898
		// (set) Token: 0x06002772 RID: 10098 RVA: 0x0000CE16 File Offset: 0x0000B016
		public unsafe Il2CppStructArray<uint> _stateSHA256
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA256Managed.NativeFieldInfoPtr__stateSHA256);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA256Managed.NativeFieldInfoPtr__stateSHA256), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06002773 RID: 10099 RVA: 0x000D66C8 File Offset: 0x000D48C8
		// (set) Token: 0x06002774 RID: 10100 RVA: 0x0000CE35 File Offset: 0x0000B035
		public unsafe Il2CppStructArray<uint> _W
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA256Managed.NativeFieldInfoPtr__W);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA256Managed.NativeFieldInfoPtr__W), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06002775 RID: 10101 RVA: 0x000D66F8 File Offset: 0x000D48F8
		// (set) Token: 0x06002776 RID: 10102 RVA: 0x0000CE54 File Offset: 0x0000B054
		public unsafe static Il2CppStructArray<uint> _K
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SHA256Managed.NativeFieldInfoPtr__K, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SHA256Managed.NativeFieldInfoPtr__K, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040021DF RID: 8671
		private static readonly IntPtr NativeFieldInfoPtr__buffer;

		// Token: 0x040021E0 RID: 8672
		private static readonly IntPtr NativeFieldInfoPtr__count;

		// Token: 0x040021E1 RID: 8673
		private static readonly IntPtr NativeFieldInfoPtr__stateSHA256;

		// Token: 0x040021E2 RID: 8674
		private static readonly IntPtr NativeFieldInfoPtr__W;

		// Token: 0x040021E3 RID: 8675
		private static readonly IntPtr NativeFieldInfoPtr__K;

		// Token: 0x040021E4 RID: 8676
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040021E5 RID: 8677
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x040021E6 RID: 8678
		private static readonly IntPtr NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040021E7 RID: 8679
		private static readonly IntPtr NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x040021E8 RID: 8680
		private static readonly IntPtr NativeMethodInfoPtr_InitializeState_Private_Void_0;

		// Token: 0x040021E9 RID: 8681
		private static readonly IntPtr NativeMethodInfoPtr__HashData_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040021EA RID: 8682
		private static readonly IntPtr NativeMethodInfoPtr__EndHash_Private_Il2CppStructArray_1_Byte_0;

		// Token: 0x040021EB RID: 8683
		private static readonly IntPtr NativeMethodInfoPtr_SHATransform_Private_Static_Void_ptr_UInt32_ptr_UInt32_ptr_Byte_0;

		// Token: 0x040021EC RID: 8684
		private static readonly IntPtr NativeMethodInfoPtr_RotateRight_Private_Static_UInt32_UInt32_Int32_0;

		// Token: 0x040021ED RID: 8685
		private static readonly IntPtr NativeMethodInfoPtr_Ch_Private_Static_UInt32_UInt32_UInt32_UInt32_0;

		// Token: 0x040021EE RID: 8686
		private static readonly IntPtr NativeMethodInfoPtr_Maj_Private_Static_UInt32_UInt32_UInt32_UInt32_0;

		// Token: 0x040021EF RID: 8687
		private static readonly IntPtr NativeMethodInfoPtr_sigma_0_Private_Static_UInt32_UInt32_0;

		// Token: 0x040021F0 RID: 8688
		private static readonly IntPtr NativeMethodInfoPtr_sigma_1_Private_Static_UInt32_UInt32_0;

		// Token: 0x040021F1 RID: 8689
		private static readonly IntPtr NativeMethodInfoPtr_Sigma_0_Private_Static_UInt32_UInt32_0;

		// Token: 0x040021F2 RID: 8690
		private static readonly IntPtr NativeMethodInfoPtr_Sigma_1_Private_Static_UInt32_UInt32_0;

		// Token: 0x040021F3 RID: 8691
		private static readonly IntPtr NativeMethodInfoPtr_SHA256Expand_Private_Static_Void_ptr_UInt32_0;
	}
}

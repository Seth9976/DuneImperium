using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Cryptography;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000271 RID: 625
	public class DESTransform : SymmetricTransform
	{
		// Token: 0x0600283C RID: 10300 RVA: 0x000D95C0 File Offset: 0x000D77C0
		// Note: this type is marked as 'beforefieldinit'.
		static DESTransform()
		{
			Il2CppClassPointerStore<DESTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "DESTransform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DESTransform>.NativeClassPtr);
			DESTransform.NativeFieldInfoPtr_KEY_BIT_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "KEY_BIT_SIZE");
			DESTransform.NativeFieldInfoPtr_KEY_BYTE_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "KEY_BYTE_SIZE");
			DESTransform.NativeFieldInfoPtr_BLOCK_BIT_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "BLOCK_BIT_SIZE");
			DESTransform.NativeFieldInfoPtr_BLOCK_BYTE_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "BLOCK_BYTE_SIZE");
			DESTransform.NativeFieldInfoPtr_keySchedule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "keySchedule");
			DESTransform.NativeFieldInfoPtr_byteBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "byteBuff");
			DESTransform.NativeFieldInfoPtr_dwordBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "dwordBuff");
			DESTransform.NativeFieldInfoPtr_spBoxes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "spBoxes");
			DESTransform.NativeFieldInfoPtr_PC1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "PC1");
			DESTransform.NativeFieldInfoPtr_leftRotTotal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "leftRotTotal");
			DESTransform.NativeFieldInfoPtr_PC2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "PC2");
			DESTransform.NativeFieldInfoPtr_ipTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "ipTab");
			DESTransform.NativeFieldInfoPtr_fpTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "fpTab");
			DESTransform.NativeMethodInfoPtr__ctor_Internal_Void_SymmetricAlgorithm_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, 100669922);
			DESTransform.NativeMethodInfoPtr_CipherFunct_Private_UInt32_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, 100669923);
			DESTransform.NativeMethodInfoPtr_Permutation_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, 100669924);
			DESTransform.NativeMethodInfoPtr_BSwap_Private_Static_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, 100669925);
			DESTransform.NativeMethodInfoPtr_SetKey_Internal_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, 100669926);
			DESTransform.NativeMethodInfoPtr_ProcessBlock_Public_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, 100669927);
			DESTransform.NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, 100669928);
			DESTransform.NativeMethodInfoPtr_GetStrongKey_Internal_Static_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, 100669929);
		}

		// Token: 0x0600283D RID: 10301 RVA: 0x000D9794 File Offset: 0x000D7994
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1374623, RefRangeEnd = 1374631, XrefRangeStart = 1374568, XrefRangeEnd = 1374623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DESTransform(SymmetricAlgorithm symmAlgo, bool encryption, Il2CppStructArray<byte> key, Il2CppStructArray<byte> iv)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DESTransform>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(symmAlgo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref encryption;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(iv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DESTransform.NativeMethodInfoPtr__ctor_Internal_Void_SymmetricAlgorithm_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600283E RID: 10302 RVA: 0x000D9814 File Offset: 0x000D7A14
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 1374635, RefRangeEnd = 1374666, XrefRangeStart = 1374631, XrefRangeEnd = 1374635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint CipherFunct(uint r, int n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref r;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DESTransform.NativeMethodInfoPtr_CipherFunct_Private_UInt32_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600283F RID: 10303 RVA: 0x000D986C File Offset: 0x000D7A6C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1374673, RefRangeEnd = 1374677, XrefRangeStart = 1374666, XrefRangeEnd = 1374673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Permutation(Il2CppStructArray<byte> input, Il2CppStructArray<byte> output, Il2CppStructArray<uint> permTab, bool preSwap)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(permTab);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preSwap;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DESTransform.NativeMethodInfoPtr_Permutation_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002840 RID: 10304 RVA: 0x000D98D4 File Offset: 0x000D7AD4
		[CallerCount(0)]
		public unsafe static void BSwap(Il2CppStructArray<byte> byteBuff)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(byteBuff);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DESTransform.NativeMethodInfoPtr_BSwap_Private_Static_Void_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002841 RID: 10305 RVA: 0x000D990C File Offset: 0x000D7B0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1374702, RefRangeEnd = 1374703, XrefRangeStart = 1374677, XrefRangeEnd = 1374702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetKey(Il2CppStructArray<byte> key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DESTransform.NativeMethodInfoPtr_SetKey_Internal_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002842 RID: 10306 RVA: 0x000D9950 File Offset: 0x000D7B50
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1374744, RefRangeEnd = 1374750, XrefRangeStart = 1374703, XrefRangeEnd = 1374744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessBlock(Il2CppStructArray<byte> input, Il2CppStructArray<byte> output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DESTransform.NativeMethodInfoPtr_ProcessBlock_Public_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002843 RID: 10307 RVA: 0x000D99A4 File Offset: 0x000D7BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1374750, XrefRangeEnd = 1374758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ECB(Il2CppStructArray<byte> input, Il2CppStructArray<byte> output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DESTransform.NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002844 RID: 10308 RVA: 0x000D9A04 File Offset: 0x000D7C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1374758, XrefRangeEnd = 1374770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetStrongKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DESTransform.NativeMethodInfoPtr_GetStrongKey_Internal_Static_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06002845 RID: 10309 RVA: 0x0000D32D File Offset: 0x0000B52D
		public DESTransform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06002846 RID: 10310 RVA: 0x000D9A38 File Offset: 0x000D7C38
		// (set) Token: 0x06002847 RID: 10311 RVA: 0x0000D336 File Offset: 0x0000B536
		public unsafe static int KEY_BIT_SIZE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DESTransform.NativeFieldInfoPtr_KEY_BIT_SIZE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DESTransform.NativeFieldInfoPtr_KEY_BIT_SIZE, (void*)(&value));
			}
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06002848 RID: 10312 RVA: 0x000D9A54 File Offset: 0x000D7C54
		// (set) Token: 0x06002849 RID: 10313 RVA: 0x0000D344 File Offset: 0x0000B544
		public unsafe static int KEY_BYTE_SIZE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DESTransform.NativeFieldInfoPtr_KEY_BYTE_SIZE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DESTransform.NativeFieldInfoPtr_KEY_BYTE_SIZE, (void*)(&value));
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x0600284A RID: 10314 RVA: 0x000D9A70 File Offset: 0x000D7C70
		// (set) Token: 0x0600284B RID: 10315 RVA: 0x0000D352 File Offset: 0x0000B552
		public unsafe static int BLOCK_BIT_SIZE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DESTransform.NativeFieldInfoPtr_BLOCK_BIT_SIZE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DESTransform.NativeFieldInfoPtr_BLOCK_BIT_SIZE, (void*)(&value));
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x0600284C RID: 10316 RVA: 0x000D9A8C File Offset: 0x000D7C8C
		// (set) Token: 0x0600284D RID: 10317 RVA: 0x0000D360 File Offset: 0x0000B560
		public unsafe static int BLOCK_BYTE_SIZE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DESTransform.NativeFieldInfoPtr_BLOCK_BYTE_SIZE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DESTransform.NativeFieldInfoPtr_BLOCK_BYTE_SIZE, (void*)(&value));
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x0600284E RID: 10318 RVA: 0x000D9AA8 File Offset: 0x000D7CA8
		// (set) Token: 0x0600284F RID: 10319 RVA: 0x0000D36E File Offset: 0x0000B56E
		public unsafe Il2CppStructArray<byte> keySchedule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DESTransform.NativeFieldInfoPtr_keySchedule);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DESTransform.NativeFieldInfoPtr_keySchedule), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06002850 RID: 10320 RVA: 0x000D9AD8 File Offset: 0x000D7CD8
		// (set) Token: 0x06002851 RID: 10321 RVA: 0x0000D38D File Offset: 0x0000B58D
		public unsafe Il2CppStructArray<byte> byteBuff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DESTransform.NativeFieldInfoPtr_byteBuff);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DESTransform.NativeFieldInfoPtr_byteBuff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06002852 RID: 10322 RVA: 0x000D9B08 File Offset: 0x000D7D08
		// (set) Token: 0x06002853 RID: 10323 RVA: 0x0000D3AC File Offset: 0x0000B5AC
		public unsafe Il2CppStructArray<uint> dwordBuff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DESTransform.NativeFieldInfoPtr_dwordBuff);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DESTransform.NativeFieldInfoPtr_dwordBuff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06002854 RID: 10324 RVA: 0x000D9B38 File Offset: 0x000D7D38
		// (set) Token: 0x06002855 RID: 10325 RVA: 0x0000D3CB File Offset: 0x0000B5CB
		public unsafe static Il2CppStructArray<uint> spBoxes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DESTransform.NativeFieldInfoPtr_spBoxes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DESTransform.NativeFieldInfoPtr_spBoxes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06002856 RID: 10326 RVA: 0x000D9B60 File Offset: 0x000D7D60
		// (set) Token: 0x06002857 RID: 10327 RVA: 0x0000D3DD File Offset: 0x0000B5DD
		public unsafe static Il2CppStructArray<byte> PC1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DESTransform.NativeFieldInfoPtr_PC1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DESTransform.NativeFieldInfoPtr_PC1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06002858 RID: 10328 RVA: 0x000D9B88 File Offset: 0x000D7D88
		// (set) Token: 0x06002859 RID: 10329 RVA: 0x0000D3EF File Offset: 0x0000B5EF
		public unsafe static Il2CppStructArray<byte> leftRotTotal
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DESTransform.NativeFieldInfoPtr_leftRotTotal, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DESTransform.NativeFieldInfoPtr_leftRotTotal, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x0600285A RID: 10330 RVA: 0x000D9BB0 File Offset: 0x000D7DB0
		// (set) Token: 0x0600285B RID: 10331 RVA: 0x0000D401 File Offset: 0x0000B601
		public unsafe static Il2CppStructArray<byte> PC2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DESTransform.NativeFieldInfoPtr_PC2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DESTransform.NativeFieldInfoPtr_PC2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x0600285C RID: 10332 RVA: 0x000D9BD8 File Offset: 0x000D7DD8
		// (set) Token: 0x0600285D RID: 10333 RVA: 0x0000D413 File Offset: 0x0000B613
		public unsafe static Il2CppStructArray<uint> ipTab
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DESTransform.NativeFieldInfoPtr_ipTab, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DESTransform.NativeFieldInfoPtr_ipTab, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x0600285E RID: 10334 RVA: 0x000D9C00 File Offset: 0x000D7E00
		// (set) Token: 0x0600285F RID: 10335 RVA: 0x0000D425 File Offset: 0x0000B625
		public unsafe static Il2CppStructArray<uint> fpTab
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DESTransform.NativeFieldInfoPtr_fpTab, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DESTransform.NativeFieldInfoPtr_fpTab, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400227B RID: 8827
		private static readonly IntPtr NativeFieldInfoPtr_KEY_BIT_SIZE;

		// Token: 0x0400227C RID: 8828
		private static readonly IntPtr NativeFieldInfoPtr_KEY_BYTE_SIZE;

		// Token: 0x0400227D RID: 8829
		private static readonly IntPtr NativeFieldInfoPtr_BLOCK_BIT_SIZE;

		// Token: 0x0400227E RID: 8830
		private static readonly IntPtr NativeFieldInfoPtr_BLOCK_BYTE_SIZE;

		// Token: 0x0400227F RID: 8831
		private static readonly IntPtr NativeFieldInfoPtr_keySchedule;

		// Token: 0x04002280 RID: 8832
		private static readonly IntPtr NativeFieldInfoPtr_byteBuff;

		// Token: 0x04002281 RID: 8833
		private static readonly IntPtr NativeFieldInfoPtr_dwordBuff;

		// Token: 0x04002282 RID: 8834
		private static readonly IntPtr NativeFieldInfoPtr_spBoxes;

		// Token: 0x04002283 RID: 8835
		private static readonly IntPtr NativeFieldInfoPtr_PC1;

		// Token: 0x04002284 RID: 8836
		private static readonly IntPtr NativeFieldInfoPtr_leftRotTotal;

		// Token: 0x04002285 RID: 8837
		private static readonly IntPtr NativeFieldInfoPtr_PC2;

		// Token: 0x04002286 RID: 8838
		private static readonly IntPtr NativeFieldInfoPtr_ipTab;

		// Token: 0x04002287 RID: 8839
		private static readonly IntPtr NativeFieldInfoPtr_fpTab;

		// Token: 0x04002288 RID: 8840
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SymmetricAlgorithm_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002289 RID: 8841
		private static readonly IntPtr NativeMethodInfoPtr_CipherFunct_Private_UInt32_UInt32_Int32_0;

		// Token: 0x0400228A RID: 8842
		private static readonly IntPtr NativeMethodInfoPtr_Permutation_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_Boolean_0;

		// Token: 0x0400228B RID: 8843
		private static readonly IntPtr NativeMethodInfoPtr_BSwap_Private_Static_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400228C RID: 8844
		private static readonly IntPtr NativeMethodInfoPtr_SetKey_Internal_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400228D RID: 8845
		private static readonly IntPtr NativeMethodInfoPtr_ProcessBlock_Public_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400228E RID: 8846
		private static readonly IntPtr NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400228F RID: 8847
		private static readonly IntPtr NativeMethodInfoPtr_GetStrongKey_Internal_Static_Il2CppStructArray_1_Byte_0;
	}
}

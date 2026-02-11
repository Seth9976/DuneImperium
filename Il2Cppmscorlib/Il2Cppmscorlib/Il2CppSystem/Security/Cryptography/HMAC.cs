using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000245 RID: 581
	public class HMAC : KeyedHashAlgorithm
	{
		// Token: 0x060025F7 RID: 9719 RVA: 0x000D0E64 File Offset: 0x000CF064
		// Note: this type is marked as 'beforefieldinit'.
		static HMAC()
		{
			Il2CppClassPointerStore<HMAC>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "HMAC");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HMAC>.NativeClassPtr);
			HMAC.NativeFieldInfoPtr_blockSizeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HMAC>.NativeClassPtr, "blockSizeValue");
			HMAC.NativeFieldInfoPtr_m_hashName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HMAC>.NativeClassPtr, "m_hashName");
			HMAC.NativeFieldInfoPtr_m_hash1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HMAC>.NativeClassPtr, "m_hash1");
			HMAC.NativeFieldInfoPtr_m_hash2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HMAC>.NativeClassPtr, "m_hash2");
			HMAC.NativeFieldInfoPtr_m_inner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HMAC>.NativeClassPtr, "m_inner");
			HMAC.NativeFieldInfoPtr_m_outer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HMAC>.NativeClassPtr, "m_outer");
			HMAC.NativeFieldInfoPtr_m_hashing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HMAC>.NativeClassPtr, "m_hashing");
			HMAC.NativeMethodInfoPtr_get_BlockSizeValue_Protected_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100669634);
			HMAC.NativeMethodInfoPtr_set_BlockSizeValue_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100669635);
			HMAC.NativeMethodInfoPtr_UpdateIOPadBuffers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100669636);
			HMAC.NativeMethodInfoPtr_InitializeKey_Internal_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100669637);
			HMAC.NativeMethodInfoPtr_get_Key_Public_Virtual_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100669638);
			HMAC.NativeMethodInfoPtr_set_Key_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100669639);
			HMAC.NativeMethodInfoPtr_Create_Public_Static_HMAC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100669640);
			HMAC.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100669641);
			HMAC.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100669642);
			HMAC.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100669643);
			HMAC.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100669644);
			HMAC.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100669645);
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x060025F8 RID: 9720 RVA: 0x000D1010 File Offset: 0x000CF210
		// (set) Token: 0x060025F9 RID: 9721 RVA: 0x000D104C File Offset: 0x000CF24C
		public unsafe int BlockSizeValue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMAC.NativeMethodInfoPtr_get_BlockSizeValue_Protected_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137951, RefRangeEnd = 137952, XrefRangeStart = 137951, XrefRangeEnd = 137952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMAC.NativeMethodInfoPtr_set_BlockSizeValue_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060025FA RID: 9722 RVA: 0x000D108C File Offset: 0x000CF28C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1372053, RefRangeEnd = 1372054, XrefRangeStart = 1372045, XrefRangeEnd = 1372053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateIOPadBuffers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMAC.NativeMethodInfoPtr_UpdateIOPadBuffers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025FB RID: 9723 RVA: 0x000D10C0 File Offset: 0x000CF2C0
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1372075, RefRangeEnd = 1372090, XrefRangeStart = 1372054, XrefRangeEnd = 1372075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeKey(Il2CppStructArray<byte> key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMAC.NativeMethodInfoPtr_InitializeKey_Internal_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x060025FC RID: 9724 RVA: 0x000D1104 File Offset: 0x000CF304
		// (set) Token: 0x060025FD RID: 9725 RVA: 0x000D1150 File Offset: 0x000CF350
		public unsafe override Il2CppStructArray<byte> Key
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372090, XrefRangeEnd = 1372093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HMAC.NativeMethodInfoPtr_get_Key_Public_Virtual_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372093, XrefRangeEnd = 1372101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HMAC.NativeMethodInfoPtr_set_Key_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060025FE RID: 9726 RVA: 0x000D11A0 File Offset: 0x000CF3A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1372120, RefRangeEnd = 1372121, XrefRangeStart = 1372101, XrefRangeEnd = 1372120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HMAC Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMAC.NativeMethodInfoPtr_Create_Public_Static_HMAC_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HMAC>(intPtr3) : null;
		}

		// Token: 0x060025FF RID: 9727 RVA: 0x000D11D4 File Offset: 0x000CF3D4
		[CallerCount(0)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HMAC.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002600 RID: 9728 RVA: 0x000D1210 File Offset: 0x000CF410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372121, XrefRangeEnd = 1372123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HashCore(Il2CppStructArray<byte> rgb, int ib, int cb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ib;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cb;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HMAC.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002601 RID: 9729 RVA: 0x000D127C File Offset: 0x000CF47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372123, XrefRangeEnd = 1372133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> HashFinal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HMAC.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06002602 RID: 9730 RVA: 0x000D12C8 File Offset: 0x000CF4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372133, XrefRangeEnd = 1372142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HMAC.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002603 RID: 9731 RVA: 0x000D1314 File Offset: 0x000CF514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372142, XrefRangeEnd = 1372143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HMAC()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HMAC>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMAC.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002604 RID: 9732 RVA: 0x0000C508 File Offset: 0x0000A708
		public HMAC(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06002605 RID: 9733 RVA: 0x000D1350 File Offset: 0x000CF550
		// (set) Token: 0x06002606 RID: 9734 RVA: 0x0000C511 File Offset: 0x0000A711
		public unsafe int blockSizeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_blockSizeValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_blockSizeValue)) = value;
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06002607 RID: 9735 RVA: 0x000D1378 File Offset: 0x000CF578
		// (set) Token: 0x06002608 RID: 9736 RVA: 0x0000C52C File Offset: 0x0000A72C
		public unsafe string m_hashName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_hashName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_hashName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06002609 RID: 9737 RVA: 0x000D13A0 File Offset: 0x000CF5A0
		// (set) Token: 0x0600260A RID: 9738 RVA: 0x0000C54B File Offset: 0x0000A74B
		public unsafe HashAlgorithm m_hash1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_hash1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashAlgorithm>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_hash1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x0600260B RID: 9739 RVA: 0x000D13D0 File Offset: 0x000CF5D0
		// (set) Token: 0x0600260C RID: 9740 RVA: 0x0000C56A File Offset: 0x0000A76A
		public unsafe HashAlgorithm m_hash2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_hash2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashAlgorithm>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_hash2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x0600260D RID: 9741 RVA: 0x000D1400 File Offset: 0x000CF600
		// (set) Token: 0x0600260E RID: 9742 RVA: 0x0000C589 File Offset: 0x0000A789
		public unsafe Il2CppStructArray<byte> m_inner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_inner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_inner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x0600260F RID: 9743 RVA: 0x000D1430 File Offset: 0x000CF630
		// (set) Token: 0x06002610 RID: 9744 RVA: 0x0000C5A8 File Offset: 0x0000A7A8
		public unsafe Il2CppStructArray<byte> m_outer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_outer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_outer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06002611 RID: 9745 RVA: 0x000D1460 File Offset: 0x000CF660
		// (set) Token: 0x06002612 RID: 9746 RVA: 0x0000C5C7 File Offset: 0x0000A7C7
		public unsafe bool m_hashing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_hashing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_hashing)) = value;
			}
		}

		// Token: 0x040020F6 RID: 8438
		private static readonly IntPtr NativeFieldInfoPtr_blockSizeValue;

		// Token: 0x040020F7 RID: 8439
		private static readonly IntPtr NativeFieldInfoPtr_m_hashName;

		// Token: 0x040020F8 RID: 8440
		private static readonly IntPtr NativeFieldInfoPtr_m_hash1;

		// Token: 0x040020F9 RID: 8441
		private static readonly IntPtr NativeFieldInfoPtr_m_hash2;

		// Token: 0x040020FA RID: 8442
		private static readonly IntPtr NativeFieldInfoPtr_m_inner;

		// Token: 0x040020FB RID: 8443
		private static readonly IntPtr NativeFieldInfoPtr_m_outer;

		// Token: 0x040020FC RID: 8444
		private static readonly IntPtr NativeFieldInfoPtr_m_hashing;

		// Token: 0x040020FD RID: 8445
		private static readonly IntPtr NativeMethodInfoPtr_get_BlockSizeValue_Protected_get_Int32_0;

		// Token: 0x040020FE RID: 8446
		private static readonly IntPtr NativeMethodInfoPtr_set_BlockSizeValue_Protected_set_Void_Int32_0;

		// Token: 0x040020FF RID: 8447
		private static readonly IntPtr NativeMethodInfoPtr_UpdateIOPadBuffers_Private_Void_0;

		// Token: 0x04002100 RID: 8448
		private static readonly IntPtr NativeMethodInfoPtr_InitializeKey_Internal_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002101 RID: 8449
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002102 RID: 8450
		private static readonly IntPtr NativeMethodInfoPtr_set_Key_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002103 RID: 8451
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_HMAC_0;

		// Token: 0x04002104 RID: 8452
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x04002105 RID: 8453
		private static readonly IntPtr NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002106 RID: 8454
		private static readonly IntPtr NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002107 RID: 8455
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04002108 RID: 8456
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

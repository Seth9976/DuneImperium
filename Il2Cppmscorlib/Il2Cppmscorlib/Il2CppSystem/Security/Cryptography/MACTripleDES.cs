using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200024E RID: 590
	public class MACTripleDES : KeyedHashAlgorithm
	{
		// Token: 0x06002641 RID: 9793 RVA: 0x000D1FAC File Offset: 0x000D01AC
		// Note: this type is marked as 'beforefieldinit'.
		static MACTripleDES()
		{
			Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "MACTripleDES");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr);
			MACTripleDES.NativeFieldInfoPtr_m_encryptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr, "m_encryptor");
			MACTripleDES.NativeFieldInfoPtr__cs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr, "_cs");
			MACTripleDES.NativeFieldInfoPtr__ts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr, "_ts");
			MACTripleDES.NativeFieldInfoPtr_m_bytesPerBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr, "m_bytesPerBlock");
			MACTripleDES.NativeFieldInfoPtr_des = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr, "des");
			MACTripleDES.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr, 100669670);
			MACTripleDES.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr, 100669671);
			MACTripleDES.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr, 100669672);
			MACTripleDES.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr, 100669673);
			MACTripleDES.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr, 100669674);
		}

		// Token: 0x06002642 RID: 9794 RVA: 0x000D20A4 File Offset: 0x000D02A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372360, XrefRangeEnd = 1372375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MACTripleDES()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MACTripleDES.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002643 RID: 9795 RVA: 0x000D20E0 File Offset: 0x000D02E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MACTripleDES.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002644 RID: 9796 RVA: 0x000D211C File Offset: 0x000D031C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372375, XrefRangeEnd = 1372387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HashCore(Il2CppStructArray<byte> rgbData, int ibStart, int cbSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgbData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ibStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MACTripleDES.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002645 RID: 9797 RVA: 0x000D2188 File Offset: 0x000D0388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372387, XrefRangeEnd = 1372403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> HashFinal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MACTripleDES.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06002646 RID: 9798 RVA: 0x000D21D4 File Offset: 0x000D03D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372403, XrefRangeEnd = 1372410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MACTripleDES.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002647 RID: 9799 RVA: 0x0000C67F File Offset: 0x0000A87F
		public MACTripleDES(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06002648 RID: 9800 RVA: 0x000D2220 File Offset: 0x000D0420
		// (set) Token: 0x06002649 RID: 9801 RVA: 0x0000C688 File Offset: 0x0000A888
		public unsafe ICryptoTransform m_encryptor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MACTripleDES.NativeFieldInfoPtr_m_encryptor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICryptoTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MACTripleDES.NativeFieldInfoPtr_m_encryptor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x0600264A RID: 9802 RVA: 0x000D2250 File Offset: 0x000D0450
		// (set) Token: 0x0600264B RID: 9803 RVA: 0x0000C6A7 File Offset: 0x0000A8A7
		public unsafe CryptoStream _cs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MACTripleDES.NativeFieldInfoPtr__cs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CryptoStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MACTripleDES.NativeFieldInfoPtr__cs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x0600264C RID: 9804 RVA: 0x000D2280 File Offset: 0x000D0480
		// (set) Token: 0x0600264D RID: 9805 RVA: 0x0000C6C6 File Offset: 0x0000A8C6
		public unsafe TailStream _ts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MACTripleDES.NativeFieldInfoPtr__ts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TailStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MACTripleDES.NativeFieldInfoPtr__ts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x0600264E RID: 9806 RVA: 0x000D22B0 File Offset: 0x000D04B0
		// (set) Token: 0x0600264F RID: 9807 RVA: 0x0000C6E5 File Offset: 0x0000A8E5
		public unsafe int m_bytesPerBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MACTripleDES.NativeFieldInfoPtr_m_bytesPerBlock);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MACTripleDES.NativeFieldInfoPtr_m_bytesPerBlock)) = value;
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06002650 RID: 9808 RVA: 0x000D22D8 File Offset: 0x000D04D8
		// (set) Token: 0x06002651 RID: 9809 RVA: 0x0000C700 File Offset: 0x0000A900
		public unsafe TripleDES des
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MACTripleDES.NativeFieldInfoPtr_des);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TripleDES>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MACTripleDES.NativeFieldInfoPtr_des), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002124 RID: 8484
		private static readonly IntPtr NativeFieldInfoPtr_m_encryptor;

		// Token: 0x04002125 RID: 8485
		private static readonly IntPtr NativeFieldInfoPtr__cs;

		// Token: 0x04002126 RID: 8486
		private static readonly IntPtr NativeFieldInfoPtr__ts;

		// Token: 0x04002127 RID: 8487
		private static readonly IntPtr NativeFieldInfoPtr_m_bytesPerBlock;

		// Token: 0x04002128 RID: 8488
		private static readonly IntPtr NativeFieldInfoPtr_des;

		// Token: 0x04002129 RID: 8489
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400212A RID: 8490
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x0400212B RID: 8491
		private static readonly IntPtr NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400212C RID: 8492
		private static readonly IntPtr NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400212D RID: 8493
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x02000039 RID: 57
	public class RC4 : SymmetricAlgorithm
	{
		// Token: 0x0600031E RID: 798 RVA: 0x0000FFFC File Offset: 0x0000E1FC
		// Note: this type is marked as 'beforefieldinit'.
		static RC4()
		{
			Il2CppClassPointerStore<RC4>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Cryptography", "RC4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RC4>.NativeClassPtr);
			RC4.NativeFieldInfoPtr_s_legalBlockSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC4>.NativeClassPtr, "s_legalBlockSizes");
			RC4.NativeFieldInfoPtr_s_legalKeySizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC4>.NativeClassPtr, "s_legalKeySizes");
			RC4.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RC4>.NativeClassPtr, 100663769);
			RC4.NativeMethodInfoPtr_get_IV_Public_Virtual_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RC4>.NativeClassPtr, 100663770);
			RC4.NativeMethodInfoPtr_set_IV_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RC4>.NativeClassPtr, 100663771);
			RC4.NativeMethodInfoPtr_Create_Public_Static_RC4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RC4>.NativeClassPtr, 100663772);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x000100A4 File Offset: 0x0000E2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150296, XrefRangeEnd = 1150304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RC4()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RC4>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RC4.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000320 RID: 800 RVA: 0x000100E0 File Offset: 0x0000E2E0
		// (set) Token: 0x06000321 RID: 801 RVA: 0x0001012C File Offset: 0x0000E32C
		public unsafe override Il2CppStructArray<byte> IV
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150304, XrefRangeEnd = 1150307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RC4.NativeMethodInfoPtr_get_IV_Public_Virtual_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RC4.NativeMethodInfoPtr_set_IV_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0001017C File Offset: 0x0000E37C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1150325, RefRangeEnd = 1150327, XrefRangeStart = 1150307, XrefRangeEnd = 1150325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RC4 Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RC4.NativeMethodInfoPtr_Create_Public_Static_RC4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RC4>(intPtr3) : null;
		}

		// Token: 0x06000323 RID: 803 RVA: 0x000034F5 File Offset: 0x000016F5
		public RC4(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000324 RID: 804 RVA: 0x000101B0 File Offset: 0x0000E3B0
		// (set) Token: 0x06000325 RID: 805 RVA: 0x000034FE File Offset: 0x000016FE
		public unsafe static Il2CppReferenceArray<KeySizes> s_legalBlockSizes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RC4.NativeFieldInfoPtr_s_legalBlockSizes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RC4.NativeFieldInfoPtr_s_legalBlockSizes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000326 RID: 806 RVA: 0x000101D8 File Offset: 0x0000E3D8
		// (set) Token: 0x06000327 RID: 807 RVA: 0x00003510 File Offset: 0x00001710
		public unsafe static Il2CppReferenceArray<KeySizes> s_legalKeySizes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RC4.NativeFieldInfoPtr_s_legalKeySizes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RC4.NativeFieldInfoPtr_s_legalKeySizes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeFieldInfoPtr_s_legalBlockSizes;

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeFieldInfoPtr_s_legalKeySizes;

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeMethodInfoPtr_get_IV_Public_Virtual_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeMethodInfoPtr_set_IV_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_RC4_0;
	}
}

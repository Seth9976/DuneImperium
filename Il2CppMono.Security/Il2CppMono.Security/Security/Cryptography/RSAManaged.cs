using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Math;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x0200003A RID: 58
	public class RSAManaged : RSA
	{
		// Token: 0x06000328 RID: 808 RVA: 0x00010200 File Offset: 0x0000E400
		// Note: this type is marked as 'beforefieldinit'.
		static RSAManaged()
		{
			Il2CppClassPointerStore<RSAManaged>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Cryptography", "RSAManaged");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr);
			RSAManaged.NativeFieldInfoPtr_isCRTpossible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, "isCRTpossible");
			RSAManaged.NativeFieldInfoPtr_keyBlinding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, "keyBlinding");
			RSAManaged.NativeFieldInfoPtr_keypairGenerated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, "keypairGenerated");
			RSAManaged.NativeFieldInfoPtr_m_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, "m_disposed");
			RSAManaged.NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, "d");
			RSAManaged.NativeFieldInfoPtr_p = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, "p");
			RSAManaged.NativeFieldInfoPtr_q = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, "q");
			RSAManaged.NativeFieldInfoPtr_dp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, "dp");
			RSAManaged.NativeFieldInfoPtr_dq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, "dq");
			RSAManaged.NativeFieldInfoPtr_qInv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, "qInv");
			RSAManaged.NativeFieldInfoPtr_n = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, "n");
			RSAManaged.NativeFieldInfoPtr_e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, "e");
			RSAManaged.NativeFieldInfoPtr_KeyGenerated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, "KeyGenerated");
			RSAManaged.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663774);
			RSAManaged.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663775);
			RSAManaged.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663776);
			RSAManaged.NativeMethodInfoPtr_GenerateKeyPair_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663777);
			RSAManaged.NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663778);
			RSAManaged.NativeMethodInfoPtr_get_PublicOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663779);
			RSAManaged.NativeMethodInfoPtr_DecryptValue_Public_Virtual_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663780);
			RSAManaged.NativeMethodInfoPtr_EncryptValue_Public_Virtual_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663781);
			RSAManaged.NativeMethodInfoPtr_ExportParameters_Public_Virtual_RSAParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663782);
			RSAManaged.NativeMethodInfoPtr_ImportParameters_Public_Virtual_Void_RSAParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663783);
			RSAManaged.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663784);
			RSAManaged.NativeMethodInfoPtr_ToXmlString_Public_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663785);
			RSAManaged.NativeMethodInfoPtr_GetPaddedValue_Private_Il2CppStructArray_1_Byte_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663786);
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00010438 File Offset: 0x0000E638
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1150340, RefRangeEnd = 1150342, XrefRangeStart = 1150327, XrefRangeEnd = 1150340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RSAManaged()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAManaged.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00010474 File Offset: 0x0000E674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150342, XrefRangeEnd = 1150355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RSAManaged(int keySize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keySize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAManaged.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600032B RID: 811 RVA: 0x000104BC File Offset: 0x0000E6BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RSAManaged.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032C RID: 812 RVA: 0x000104F8 File Offset: 0x0000E6F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1150410, RefRangeEnd = 1150413, XrefRangeStart = 1150355, XrefRangeEnd = 1150410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateKeyPair()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAManaged.NativeMethodInfoPtr_GenerateKeyPair_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600032D RID: 813 RVA: 0x0001052C File Offset: 0x0000E72C
		public unsafe override int KeySize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RSAManaged.NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600032E RID: 814 RVA: 0x00010574 File Offset: 0x0000E774
		public unsafe bool PublicOnly
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1150414, RefRangeEnd = 1150415, XrefRangeStart = 1150413, XrefRangeEnd = 1150414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAManaged.NativeMethodInfoPtr_get_PublicOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600032F RID: 815 RVA: 0x000105B0 File Offset: 0x0000E7B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150415, XrefRangeEnd = 1150460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> DecryptValue(Il2CppStructArray<byte> rgb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RSAManaged.NativeMethodInfoPtr_DecryptValue_Public_Virtual_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0001060C File Offset: 0x0000E80C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150460, XrefRangeEnd = 1150467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> EncryptValue(Il2CppStructArray<byte> rgb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RSAManaged.NativeMethodInfoPtr_EncryptValue_Public_Virtual_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00010668 File Offset: 0x0000E868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150467, XrefRangeEnd = 1150508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override RSAParameters ExportParameters(bool includePrivateParameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includePrivateParameters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RSAManaged.NativeMethodInfoPtr_ExportParameters_Public_Virtual_RSAParameters_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new RSAParameters(intPtr);
			}
		}

		// Token: 0x06000332 RID: 818 RVA: 0x000106B8 File Offset: 0x0000E8B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150508, XrefRangeEnd = 1150607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ImportParameters(RSAParameters parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parameters));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RSAManaged.NativeMethodInfoPtr_ImportParameters_Public_Virtual_Void_RSAParameters_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0001070C File Offset: 0x0000E90C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150607, XrefRangeEnd = 1150640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RSAManaged.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00010758 File Offset: 0x0000E958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150640, XrefRangeEnd = 1150744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToXmlString(bool includePrivateParameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includePrivateParameters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RSAManaged.NativeMethodInfoPtr_ToXmlString_Public_Virtual_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000335 RID: 821 RVA: 0x000107A8 File Offset: 0x0000E9A8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1150750, RefRangeEnd = 1150757, XrefRangeStart = 1150744, XrefRangeEnd = 1150750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetPaddedValue(Il2CppMono.Math.BigInteger value, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAManaged.NativeMethodInfoPtr_GetPaddedValue_Private_Il2CppStructArray_1_Byte_BigInteger_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00003522 File Offset: 0x00001722
		public RSAManaged(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000337 RID: 823 RVA: 0x00010808 File Offset: 0x0000EA08
		// (set) Token: 0x06000338 RID: 824 RVA: 0x0000352B File Offset: 0x0000172B
		public unsafe bool isCRTpossible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_isCRTpossible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_isCRTpossible)) = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000339 RID: 825 RVA: 0x00010830 File Offset: 0x0000EA30
		// (set) Token: 0x0600033A RID: 826 RVA: 0x00003546 File Offset: 0x00001746
		public unsafe bool keyBlinding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_keyBlinding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_keyBlinding)) = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600033B RID: 827 RVA: 0x00010858 File Offset: 0x0000EA58
		// (set) Token: 0x0600033C RID: 828 RVA: 0x00003561 File Offset: 0x00001761
		public unsafe bool keypairGenerated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_keypairGenerated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_keypairGenerated)) = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600033D RID: 829 RVA: 0x00010880 File Offset: 0x0000EA80
		// (set) Token: 0x0600033E RID: 830 RVA: 0x0000357C File Offset: 0x0000177C
		public unsafe bool m_disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_m_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_m_disposed)) = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600033F RID: 831 RVA: 0x000108A8 File Offset: 0x0000EAA8
		// (set) Token: 0x06000340 RID: 832 RVA: 0x00003597 File Offset: 0x00001797
		public unsafe Il2CppMono.Math.BigInteger d
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_d);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppMono.Math.BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_d), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000341 RID: 833 RVA: 0x000108D8 File Offset: 0x0000EAD8
		// (set) Token: 0x06000342 RID: 834 RVA: 0x000035B6 File Offset: 0x000017B6
		public unsafe Il2CppMono.Math.BigInteger p
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_p);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppMono.Math.BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_p), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000343 RID: 835 RVA: 0x00010908 File Offset: 0x0000EB08
		// (set) Token: 0x06000344 RID: 836 RVA: 0x000035D5 File Offset: 0x000017D5
		public unsafe Il2CppMono.Math.BigInteger q
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_q);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppMono.Math.BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_q), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000345 RID: 837 RVA: 0x00010938 File Offset: 0x0000EB38
		// (set) Token: 0x06000346 RID: 838 RVA: 0x000035F4 File Offset: 0x000017F4
		public unsafe Il2CppMono.Math.BigInteger dp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_dp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppMono.Math.BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_dp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000347 RID: 839 RVA: 0x00010968 File Offset: 0x0000EB68
		// (set) Token: 0x06000348 RID: 840 RVA: 0x00003613 File Offset: 0x00001813
		public unsafe Il2CppMono.Math.BigInteger dq
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_dq);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppMono.Math.BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_dq), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000349 RID: 841 RVA: 0x00010998 File Offset: 0x0000EB98
		// (set) Token: 0x0600034A RID: 842 RVA: 0x00003632 File Offset: 0x00001832
		public unsafe Il2CppMono.Math.BigInteger qInv
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_qInv);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppMono.Math.BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_qInv), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600034B RID: 843 RVA: 0x000109C8 File Offset: 0x0000EBC8
		// (set) Token: 0x0600034C RID: 844 RVA: 0x00003651 File Offset: 0x00001851
		public unsafe Il2CppMono.Math.BigInteger n
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_n);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppMono.Math.BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_n), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600034D RID: 845 RVA: 0x000109F8 File Offset: 0x0000EBF8
		// (set) Token: 0x0600034E RID: 846 RVA: 0x00003670 File Offset: 0x00001870
		public unsafe Il2CppMono.Math.BigInteger e
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_e);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppMono.Math.BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_e), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600034F RID: 847 RVA: 0x00010A28 File Offset: 0x0000EC28
		// (set) Token: 0x06000350 RID: 848 RVA: 0x0000368F File Offset: 0x0000188F
		public unsafe RSAManaged.KeyGeneratedEventHandler KeyGenerated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_KeyGenerated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RSAManaged.KeyGeneratedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_KeyGenerated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeFieldInfoPtr_isCRTpossible;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeFieldInfoPtr_keyBlinding;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeFieldInfoPtr_keypairGenerated;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeFieldInfoPtr_m_disposed;

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeFieldInfoPtr_d;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeFieldInfoPtr_p;

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeFieldInfoPtr_q;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeFieldInfoPtr_dp;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeFieldInfoPtr_dq;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeFieldInfoPtr_qInv;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeFieldInfoPtr_n;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeFieldInfoPtr_e;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeFieldInfoPtr_KeyGenerated;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeMethodInfoPtr_GenerateKeyPair_Private_Void_0;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeMethodInfoPtr_get_PublicOnly_Public_get_Boolean_0;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeMethodInfoPtr_DecryptValue_Public_Virtual_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeMethodInfoPtr_EncryptValue_Public_Virtual_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeMethodInfoPtr_ExportParameters_Public_Virtual_RSAParameters_Boolean_0;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeMethodInfoPtr_ImportParameters_Public_Virtual_Void_RSAParameters_0;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeMethodInfoPtr_ToXmlString_Public_Virtual_String_Boolean_0;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeMethodInfoPtr_GetPaddedValue_Private_Il2CppStructArray_1_Byte_BigInteger_Int32_0;

		// Token: 0x0200005F RID: 95
		public sealed class KeyGeneratedEventHandler : MulticastDelegate
		{
			// Token: 0x0600051C RID: 1308 RVA: 0x00004537 File Offset: 0x00002737
			// Note: this type is marked as 'beforefieldinit'.
			static KeyGeneratedEventHandler()
			{
				Il2CppClassPointerStore<RSAManaged.KeyGeneratedEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, "KeyGeneratedEventHandler");
				RSAManaged.KeyGeneratedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged.KeyGeneratedEventHandler>.NativeClassPtr, 100663787);
				RSAManaged.KeyGeneratedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged.KeyGeneratedEventHandler>.NativeClassPtr, 100663788);
			}

			// Token: 0x0600051D RID: 1309 RVA: 0x000164A0 File Offset: 0x000146A0
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyGeneratedEventHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSAManaged.KeyGeneratedEventHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAManaged.KeyGeneratedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600051E RID: 1310 RVA: 0x000164FC File Offset: 0x000146FC
			[CallerCount(0)]
			public unsafe void Invoke(Object sender, EventArgs e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAManaged.KeyGeneratedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_EventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600051F RID: 1311 RVA: 0x00004575 File Offset: 0x00002775
			public KeyGeneratedEventHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000520 RID: 1312 RVA: 0x0000457E File Offset: 0x0000277E
			public static implicit operator RSAManaged.KeyGeneratedEventHandler(Action<Object, EventArgs> A_0)
			{
				return DelegateSupport.ConvertDelegate<RSAManaged.KeyGeneratedEventHandler>(A_0);
			}

			// Token: 0x06000521 RID: 1313 RVA: 0x00004586 File Offset: 0x00002786
			public static RSAManaged.KeyGeneratedEventHandler operator +(RSAManaged.KeyGeneratedEventHandler A_0, RSAManaged.KeyGeneratedEventHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<RSAManaged.KeyGeneratedEventHandler>();
			}

			// Token: 0x06000522 RID: 1314 RVA: 0x00004594 File Offset: 0x00002794
			public static RSAManaged.KeyGeneratedEventHandler operator -(RSAManaged.KeyGeneratedEventHandler A_0, RSAManaged.KeyGeneratedEventHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<RSAManaged.KeyGeneratedEventHandler>();
				}
				return delegate2;
			}

			// Token: 0x040004AC RID: 1196
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040004AD RID: 1197
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_EventArgs_0;
		}
	}
}

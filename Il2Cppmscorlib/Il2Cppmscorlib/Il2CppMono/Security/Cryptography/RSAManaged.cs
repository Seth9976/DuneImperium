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
	// Token: 0x02000033 RID: 51
	public class RSAManaged : RSA
	{
		// Token: 0x0600029F RID: 671 RVA: 0x0002FCFC File Offset: 0x0002DEFC
		// Note: this type is marked as 'beforefieldinit'.
		static RSAManaged()
		{
			Il2CppClassPointerStore<RSAManaged>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security.Cryptography", "RSAManaged");
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
			RSAManaged.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663683);
			RSAManaged.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663684);
			RSAManaged.NativeMethodInfoPtr_GenerateKeyPair_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663685);
			RSAManaged.NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663686);
			RSAManaged.NativeMethodInfoPtr_get_PublicOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663687);
			RSAManaged.NativeMethodInfoPtr_DecryptValue_Public_Virtual_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663688);
			RSAManaged.NativeMethodInfoPtr_EncryptValue_Public_Virtual_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663689);
			RSAManaged.NativeMethodInfoPtr_ExportParameters_Public_Virtual_RSAParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663690);
			RSAManaged.NativeMethodInfoPtr_ImportParameters_Public_Virtual_Void_RSAParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663691);
			RSAManaged.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663692);
			RSAManaged.NativeMethodInfoPtr_add_KeyGenerated_Public_add_Void_KeyGeneratedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663693);
			RSAManaged.NativeMethodInfoPtr_remove_KeyGenerated_Public_rem_Void_KeyGeneratedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663694);
			RSAManaged.NativeMethodInfoPtr_ToXmlString_Public_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663695);
			RSAManaged.NativeMethodInfoPtr_get_IsCrtPossible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663696);
			RSAManaged.NativeMethodInfoPtr_GetPaddedValue_Private_Il2CppStructArray_1_Byte_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, 100663697);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0002FF5C File Offset: 0x0002E15C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1278498, RefRangeEnd = 1278499, XrefRangeStart = 1278485, XrefRangeEnd = 1278498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060002A1 RID: 673 RVA: 0x0002FFA4 File Offset: 0x0002E1A4
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

		// Token: 0x060002A2 RID: 674 RVA: 0x0002FFE0 File Offset: 0x0002E1E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1278554, RefRangeEnd = 1278557, XrefRangeStart = 1278499, XrefRangeEnd = 1278554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateKeyPair()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAManaged.NativeMethodInfoPtr_GenerateKeyPair_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x00030014 File Offset: 0x0002E214
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

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x0003005C File Offset: 0x0002E25C
		public unsafe bool PublicOnly
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1278558, RefRangeEnd = 1278561, XrefRangeStart = 1278557, XrefRangeEnd = 1278558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060002A5 RID: 677 RVA: 0x00030098 File Offset: 0x0002E298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278561, XrefRangeEnd = 1278610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060002A6 RID: 678 RVA: 0x000300F4 File Offset: 0x0002E2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278610, XrefRangeEnd = 1278617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060002A7 RID: 679 RVA: 0x00030150 File Offset: 0x0002E350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278617, XrefRangeEnd = 1278658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060002A8 RID: 680 RVA: 0x000301A0 File Offset: 0x0002E3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278658, XrefRangeEnd = 1278757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060002A9 RID: 681 RVA: 0x000301F4 File Offset: 0x0002E3F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278757, XrefRangeEnd = 1278790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060002AA RID: 682 RVA: 0x00030240 File Offset: 0x0002E440
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1278794, RefRangeEnd = 1278795, XrefRangeStart = 1278790, XrefRangeEnd = 1278794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_KeyGenerated(RSAManaged.KeyGeneratedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAManaged.NativeMethodInfoPtr_add_KeyGenerated_Public_add_Void_KeyGeneratedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00030284 File Offset: 0x0002E484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278795, XrefRangeEnd = 1278799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_KeyGenerated(RSAManaged.KeyGeneratedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAManaged.NativeMethodInfoPtr_remove_KeyGenerated_Public_rem_Void_KeyGeneratedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002AC RID: 684 RVA: 0x000302C8 File Offset: 0x0002E4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278799, XrefRangeEnd = 1278903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002AD RID: 685 RVA: 0x00030318 File Offset: 0x0002E518
		public unsafe bool IsCrtPossible
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1278903, RefRangeEnd = 1278904, XrefRangeStart = 1278903, XrefRangeEnd = 1278903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAManaged.NativeMethodInfoPtr_get_IsCrtPossible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00030354 File Offset: 0x0002E554
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1278910, RefRangeEnd = 1278917, XrefRangeStart = 1278904, XrefRangeEnd = 1278910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetPaddedValue(BigInteger value, int length)
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

		// Token: 0x060002AF RID: 687 RVA: 0x0000308B File Offset: 0x0000128B
		public RSAManaged(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x000303B4 File Offset: 0x0002E5B4
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x00003094 File Offset: 0x00001294
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

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x000303DC File Offset: 0x0002E5DC
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x000030AF File Offset: 0x000012AF
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

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x00030404 File Offset: 0x0002E604
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x000030CA File Offset: 0x000012CA
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

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x0003042C File Offset: 0x0002E62C
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x000030E5 File Offset: 0x000012E5
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

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x00030454 File Offset: 0x0002E654
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x00003100 File Offset: 0x00001300
		public unsafe BigInteger d
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_d);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_d), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060002BA RID: 698 RVA: 0x00030484 File Offset: 0x0002E684
		// (set) Token: 0x060002BB RID: 699 RVA: 0x0000311F File Offset: 0x0000131F
		public unsafe BigInteger p
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_p);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_p), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060002BC RID: 700 RVA: 0x000304B4 File Offset: 0x0002E6B4
		// (set) Token: 0x060002BD RID: 701 RVA: 0x0000313E File Offset: 0x0000133E
		public unsafe BigInteger q
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_q);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_q), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002BE RID: 702 RVA: 0x000304E4 File Offset: 0x0002E6E4
		// (set) Token: 0x060002BF RID: 703 RVA: 0x0000315D File Offset: 0x0000135D
		public unsafe BigInteger dp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_dp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_dp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x00030514 File Offset: 0x0002E714
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x0000317C File Offset: 0x0000137C
		public unsafe BigInteger dq
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_dq);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_dq), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x00030544 File Offset: 0x0002E744
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x0000319B File Offset: 0x0000139B
		public unsafe BigInteger qInv
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_qInv);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_qInv), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x00030574 File Offset: 0x0002E774
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x000031BA File Offset: 0x000013BA
		public unsafe BigInteger n
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_n);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_n), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x000305A4 File Offset: 0x0002E7A4
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x000031D9 File Offset: 0x000013D9
		public unsafe BigInteger e
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_e);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAManaged.NativeFieldInfoPtr_e), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x000305D4 File Offset: 0x0002E7D4
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x000031F8 File Offset: 0x000013F8
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

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeFieldInfoPtr_isCRTpossible;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeFieldInfoPtr_keyBlinding;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeFieldInfoPtr_keypairGenerated;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeFieldInfoPtr_m_disposed;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeFieldInfoPtr_d;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeFieldInfoPtr_p;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeFieldInfoPtr_q;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeFieldInfoPtr_dp;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeFieldInfoPtr_dq;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeFieldInfoPtr_qInv;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeFieldInfoPtr_n;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeFieldInfoPtr_e;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeFieldInfoPtr_KeyGenerated;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr_GenerateKeyPair_Private_Void_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr_get_PublicOnly_Public_get_Boolean_0;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr_DecryptValue_Public_Virtual_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeMethodInfoPtr_EncryptValue_Public_Virtual_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeMethodInfoPtr_ExportParameters_Public_Virtual_RSAParameters_Boolean_0;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeMethodInfoPtr_ImportParameters_Public_Virtual_Void_RSAParameters_0;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeMethodInfoPtr_add_KeyGenerated_Public_add_Void_KeyGeneratedEventHandler_0;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr_remove_KeyGenerated_Public_rem_Void_KeyGeneratedEventHandler_0;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr_ToXmlString_Public_Virtual_String_Boolean_0;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCrtPossible_Public_get_Boolean_0;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr_GetPaddedValue_Private_Il2CppStructArray_1_Byte_BigInteger_Int32_0;

		// Token: 0x0200056E RID: 1390
		public sealed class KeyGeneratedEventHandler : MulticastDelegate
		{
			// Token: 0x060055D6 RID: 21974 RVA: 0x0001E7C5 File Offset: 0x0001C9C5
			// Note: this type is marked as 'beforefieldinit'.
			static KeyGeneratedEventHandler()
			{
				Il2CppClassPointerStore<RSAManaged.KeyGeneratedEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RSAManaged>.NativeClassPtr, "KeyGeneratedEventHandler");
				RSAManaged.KeyGeneratedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged.KeyGeneratedEventHandler>.NativeClassPtr, 100663698);
				RSAManaged.KeyGeneratedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAManaged.KeyGeneratedEventHandler>.NativeClassPtr, 100663699);
			}

			// Token: 0x060055D7 RID: 21975 RVA: 0x0018CB34 File Offset: 0x0018AD34
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 313218, RefRangeEnd = 313223, XrefRangeStart = 313218, XrefRangeEnd = 313223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x060055D8 RID: 21976 RVA: 0x0018CB90 File Offset: 0x0018AD90
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

			// Token: 0x060055D9 RID: 21977 RVA: 0x0001E803 File Offset: 0x0001CA03
			public KeyGeneratedEventHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060055DA RID: 21978 RVA: 0x0001E80C File Offset: 0x0001CA0C
			public static implicit operator RSAManaged.KeyGeneratedEventHandler(Action<Object, EventArgs> A_0)
			{
				return DelegateSupport.ConvertDelegate<RSAManaged.KeyGeneratedEventHandler>(A_0);
			}

			// Token: 0x060055DB RID: 21979 RVA: 0x0001E814 File Offset: 0x0001CA14
			public static RSAManaged.KeyGeneratedEventHandler operator +(RSAManaged.KeyGeneratedEventHandler A_0, RSAManaged.KeyGeneratedEventHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<RSAManaged.KeyGeneratedEventHandler>();
			}

			// Token: 0x060055DC RID: 21980 RVA: 0x0001E822 File Offset: 0x0001CA22
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

			// Token: 0x0400460C RID: 17932
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400460D RID: 17933
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_EventArgs_0;
		}
	}
}

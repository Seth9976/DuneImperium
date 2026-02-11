using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Cryptography;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200025C RID: 604
	public sealed class RSACryptoServiceProvider : RSA
	{
		// Token: 0x0600271B RID: 10011 RVA: 0x000D5060 File Offset: 0x000D3260
		// Note: this type is marked as 'beforefieldinit'.
		static RSACryptoServiceProvider()
		{
			Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RSACryptoServiceProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr);
			RSACryptoServiceProvider.NativeFieldInfoPtr_s_UseMachineKeyStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, "s_UseMachineKeyStore");
			RSACryptoServiceProvider.NativeFieldInfoPtr_store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, "store");
			RSACryptoServiceProvider.NativeFieldInfoPtr_persistKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, "persistKey");
			RSACryptoServiceProvider.NativeFieldInfoPtr_persisted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, "persisted");
			RSACryptoServiceProvider.NativeFieldInfoPtr_privateKeyExportable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, "privateKeyExportable");
			RSACryptoServiceProvider.NativeFieldInfoPtr_m_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, "m_disposed");
			RSACryptoServiceProvider.NativeFieldInfoPtr_rsa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, "rsa");
			RSACryptoServiceProvider.NativeMethodInfoPtr_get_UseMachineKeyStore_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100669761);
			RSACryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100669762);
			RSACryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_CspParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100669763);
			RSACryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100669764);
			RSACryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_Int32_CspParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100669765);
			RSACryptoServiceProvider.NativeMethodInfoPtr_Common_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100669766);
			RSACryptoServiceProvider.NativeMethodInfoPtr_Common_Private_Void_CspParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100669767);
			RSACryptoServiceProvider.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100669768);
			RSACryptoServiceProvider.NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100669769);
			RSACryptoServiceProvider.NativeMethodInfoPtr_get_PublicOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100669770);
			RSACryptoServiceProvider.NativeMethodInfoPtr_DecryptValue_Public_Virtual_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100669771);
			RSACryptoServiceProvider.NativeMethodInfoPtr_EncryptValue_Public_Virtual_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100669772);
			RSACryptoServiceProvider.NativeMethodInfoPtr_ExportParameters_Public_Virtual_RSAParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100669773);
			RSACryptoServiceProvider.NativeMethodInfoPtr_ImportParameters_Public_Virtual_Void_RSAParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100669774);
			RSACryptoServiceProvider.NativeMethodInfoPtr_GetHashNameFromOID_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100669775);
			RSACryptoServiceProvider.NativeMethodInfoPtr_SignHash_Public_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100669776);
			RSACryptoServiceProvider.NativeMethodInfoPtr_VerifyHash_Public_Boolean_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100669777);
			RSACryptoServiceProvider.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100669778);
			RSACryptoServiceProvider.NativeMethodInfoPtr_OnKeyGenerated_Private_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100669779);
			RSACryptoServiceProvider.NativeMethodInfoPtr_ExportCspBlob_Public_Virtual_Final_New_Il2CppStructArray_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100669780);
			RSACryptoServiceProvider.NativeMethodInfoPtr_ImportCspBlob_Public_Virtual_Final_New_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100669781);
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x0600271C RID: 10012 RVA: 0x000D52C0 File Offset: 0x000D34C0
		public unsafe static bool UseMachineKeyStore
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373080, XrefRangeEnd = 1373083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr_get_UseMachineKeyStore_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x000D52F0 File Offset: 0x000D34F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1373085, RefRangeEnd = 1373087, XrefRangeStart = 1373083, XrefRangeEnd = 1373085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RSACryptoServiceProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x000D532C File Offset: 0x000D352C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1373095, RefRangeEnd = 1373097, XrefRangeStart = 1373087, XrefRangeEnd = 1373095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RSACryptoServiceProvider(CspParameters parameters)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameters);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_CspParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x000D5378 File Offset: 0x000D3578
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1373099, RefRangeEnd = 1373101, XrefRangeStart = 1373097, XrefRangeEnd = 1373099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RSACryptoServiceProvider(int dwKeySize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dwKeySize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x000D53C0 File Offset: 0x000D35C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373101, XrefRangeEnd = 1373109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RSACryptoServiceProvider(int dwKeySize, CspParameters parameters)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dwKeySize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_Int32_CspParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002721 RID: 10017 RVA: 0x000D541C File Offset: 0x000D361C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1373144, RefRangeEnd = 1373149, XrefRangeStart = 1373109, XrefRangeEnd = 1373144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Common(int dwKeySize, bool parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dwKeySize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr_Common_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002722 RID: 10018 RVA: 0x000D5468 File Offset: 0x000D3668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373149, XrefRangeEnd = 1373155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Common(CspParameters p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr_Common_Private_Void_CspParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002723 RID: 10019 RVA: 0x000D54AC File Offset: 0x000D36AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06002724 RID: 10020 RVA: 0x000D54E0 File Offset: 0x000D36E0
		public unsafe override int KeySize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06002725 RID: 10021 RVA: 0x000D551C File Offset: 0x000D371C
		public unsafe bool PublicOnly
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1373157, RefRangeEnd = 1373158, XrefRangeStart = 1373155, XrefRangeEnd = 1373157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr_get_PublicOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002726 RID: 10022 RVA: 0x000D5558 File Offset: 0x000D3758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373158, XrefRangeEnd = 1373166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> DecryptValue(Il2CppStructArray<byte> rgb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr_DecryptValue_Public_Virtual_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06002727 RID: 10023 RVA: 0x000D55A8 File Offset: 0x000D37A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> EncryptValue(Il2CppStructArray<byte> rgb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr_EncryptValue_Public_Virtual_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06002728 RID: 10024 RVA: 0x000D55F8 File Offset: 0x000D37F8
		[CallerCount(0)]
		public unsafe override RSAParameters ExportParameters(bool includePrivateParameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includePrivateParameters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr_ExportParameters_Public_Virtual_RSAParameters_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new RSAParameters(intPtr);
			}
		}

		// Token: 0x06002729 RID: 10025 RVA: 0x000D563C File Offset: 0x000D383C
		[CallerCount(0)]
		public unsafe override void ImportParameters(RSAParameters parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parameters));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr_ImportParameters_Public_Virtual_Void_RSAParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600272A RID: 10026 RVA: 0x000D5684 File Offset: 0x000D3884
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1373179, RefRangeEnd = 1373181, XrefRangeStart = 1373166, XrefRangeEnd = 1373179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetHashNameFromOID(string oid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr_GetHashNameFromOID_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x000D56CC File Offset: 0x000D38CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1373196, RefRangeEnd = 1373197, XrefRangeStart = 1373181, XrefRangeEnd = 1373196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> SignHash(Il2CppStructArray<byte> rgbHash, string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgbHash);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr_SignHash_Public_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x000D5730 File Offset: 0x000D3930
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1373218, RefRangeEnd = 1373220, XrefRangeStart = 1373197, XrefRangeEnd = 1373218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool VerifyHash(Il2CppStructArray<byte> rgbHash, string str, Il2CppStructArray<byte> rgbSignature)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgbHash);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rgbSignature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr_VerifyHash_Public_Boolean_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600272D RID: 10029 RVA: 0x000D57A4 File Offset: 0x000D39A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373220, XrefRangeEnd = 1373222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600272E RID: 10030 RVA: 0x000D57E4 File Offset: 0x000D39E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373222, XrefRangeEnd = 1373225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnKeyGenerated(Object sender, EventArgs e)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr_OnKeyGenerated_Private_Void_Object_EventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x000D5838 File Offset: 0x000D3A38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1373229, RefRangeEnd = 1373230, XrefRangeStart = 1373225, XrefRangeEnd = 1373229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> ExportCspBlob(bool includePrivateParameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includePrivateParameters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr_ExportCspBlob_Public_Virtual_Final_New_Il2CppStructArray_1_Byte_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x000D5884 File Offset: 0x000D3A84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1373258, RefRangeEnd = 1373259, XrefRangeStart = 1373230, XrefRangeEnd = 1373258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImportCspBlob(Il2CppStructArray<byte> keyBlob)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keyBlob);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr_ImportCspBlob_Public_Virtual_Final_New_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x0000CC7F File Offset: 0x0000AE7F
		public RSACryptoServiceProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06002732 RID: 10034 RVA: 0x000D58C8 File Offset: 0x000D3AC8
		// (set) Token: 0x06002733 RID: 10035 RVA: 0x0000CC88 File Offset: 0x0000AE88
		public unsafe static CspProviderFlags s_UseMachineKeyStore
		{
			get
			{
				CspProviderFlags cspProviderFlags;
				IL2CPP.il2cpp_field_static_get_value(RSACryptoServiceProvider.NativeFieldInfoPtr_s_UseMachineKeyStore, (void*)(&cspProviderFlags));
				return cspProviderFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RSACryptoServiceProvider.NativeFieldInfoPtr_s_UseMachineKeyStore, (void*)(&value));
			}
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06002734 RID: 10036 RVA: 0x000D58E4 File Offset: 0x000D3AE4
		// (set) Token: 0x06002735 RID: 10037 RVA: 0x0000CC96 File Offset: 0x0000AE96
		public unsafe KeyPairPersistence store
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSACryptoServiceProvider.NativeFieldInfoPtr_store);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KeyPairPersistence>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSACryptoServiceProvider.NativeFieldInfoPtr_store), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06002736 RID: 10038 RVA: 0x000D5914 File Offset: 0x000D3B14
		// (set) Token: 0x06002737 RID: 10039 RVA: 0x0000CCB5 File Offset: 0x0000AEB5
		public unsafe bool persistKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSACryptoServiceProvider.NativeFieldInfoPtr_persistKey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSACryptoServiceProvider.NativeFieldInfoPtr_persistKey)) = value;
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06002738 RID: 10040 RVA: 0x000D593C File Offset: 0x000D3B3C
		// (set) Token: 0x06002739 RID: 10041 RVA: 0x0000CCD0 File Offset: 0x0000AED0
		public unsafe bool persisted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSACryptoServiceProvider.NativeFieldInfoPtr_persisted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSACryptoServiceProvider.NativeFieldInfoPtr_persisted)) = value;
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x0600273A RID: 10042 RVA: 0x000D5964 File Offset: 0x000D3B64
		// (set) Token: 0x0600273B RID: 10043 RVA: 0x0000CCEB File Offset: 0x0000AEEB
		public unsafe bool privateKeyExportable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSACryptoServiceProvider.NativeFieldInfoPtr_privateKeyExportable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSACryptoServiceProvider.NativeFieldInfoPtr_privateKeyExportable)) = value;
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x0600273C RID: 10044 RVA: 0x000D598C File Offset: 0x000D3B8C
		// (set) Token: 0x0600273D RID: 10045 RVA: 0x0000CD06 File Offset: 0x0000AF06
		public unsafe bool m_disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSACryptoServiceProvider.NativeFieldInfoPtr_m_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSACryptoServiceProvider.NativeFieldInfoPtr_m_disposed)) = value;
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x0600273E RID: 10046 RVA: 0x000D59B4 File Offset: 0x000D3BB4
		// (set) Token: 0x0600273F RID: 10047 RVA: 0x0000CD21 File Offset: 0x0000AF21
		public unsafe RSAManaged rsa
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSACryptoServiceProvider.NativeFieldInfoPtr_rsa);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RSAManaged>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSACryptoServiceProvider.NativeFieldInfoPtr_rsa), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040021B2 RID: 8626
		private static readonly IntPtr NativeFieldInfoPtr_s_UseMachineKeyStore;

		// Token: 0x040021B3 RID: 8627
		private static readonly IntPtr NativeFieldInfoPtr_store;

		// Token: 0x040021B4 RID: 8628
		private static readonly IntPtr NativeFieldInfoPtr_persistKey;

		// Token: 0x040021B5 RID: 8629
		private static readonly IntPtr NativeFieldInfoPtr_persisted;

		// Token: 0x040021B6 RID: 8630
		private static readonly IntPtr NativeFieldInfoPtr_privateKeyExportable;

		// Token: 0x040021B7 RID: 8631
		private static readonly IntPtr NativeFieldInfoPtr_m_disposed;

		// Token: 0x040021B8 RID: 8632
		private static readonly IntPtr NativeFieldInfoPtr_rsa;

		// Token: 0x040021B9 RID: 8633
		private static readonly IntPtr NativeMethodInfoPtr_get_UseMachineKeyStore_Public_Static_get_Boolean_0;

		// Token: 0x040021BA RID: 8634
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040021BB RID: 8635
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CspParameters_0;

		// Token: 0x040021BC RID: 8636
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040021BD RID: 8637
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_CspParameters_0;

		// Token: 0x040021BE RID: 8638
		private static readonly IntPtr NativeMethodInfoPtr_Common_Private_Void_Int32_Boolean_0;

		// Token: 0x040021BF RID: 8639
		private static readonly IntPtr NativeMethodInfoPtr_Common_Private_Void_CspParameters_0;

		// Token: 0x040021C0 RID: 8640
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040021C1 RID: 8641
		private static readonly IntPtr NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0;

		// Token: 0x040021C2 RID: 8642
		private static readonly IntPtr NativeMethodInfoPtr_get_PublicOnly_Public_get_Boolean_0;

		// Token: 0x040021C3 RID: 8643
		private static readonly IntPtr NativeMethodInfoPtr_DecryptValue_Public_Virtual_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x040021C4 RID: 8644
		private static readonly IntPtr NativeMethodInfoPtr_EncryptValue_Public_Virtual_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x040021C5 RID: 8645
		private static readonly IntPtr NativeMethodInfoPtr_ExportParameters_Public_Virtual_RSAParameters_Boolean_0;

		// Token: 0x040021C6 RID: 8646
		private static readonly IntPtr NativeMethodInfoPtr_ImportParameters_Public_Virtual_Void_RSAParameters_0;

		// Token: 0x040021C7 RID: 8647
		private static readonly IntPtr NativeMethodInfoPtr_GetHashNameFromOID_Private_String_String_0;

		// Token: 0x040021C8 RID: 8648
		private static readonly IntPtr NativeMethodInfoPtr_SignHash_Public_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x040021C9 RID: 8649
		private static readonly IntPtr NativeMethodInfoPtr_VerifyHash_Public_Boolean_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x040021CA RID: 8650
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x040021CB RID: 8651
		private static readonly IntPtr NativeMethodInfoPtr_OnKeyGenerated_Private_Void_Object_EventArgs_0;

		// Token: 0x040021CC RID: 8652
		private static readonly IntPtr NativeMethodInfoPtr_ExportCspBlob_Public_Virtual_Final_New_Il2CppStructArray_1_Byte_Boolean_0;

		// Token: 0x040021CD RID: 8653
		private static readonly IntPtr NativeMethodInfoPtr_ImportCspBlob_Public_Virtual_Final_New_Void_Il2CppStructArray_1_Byte_0;
	}
}

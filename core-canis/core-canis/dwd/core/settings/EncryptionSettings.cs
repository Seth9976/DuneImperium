using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;

namespace dwd.core.settings
{
	// Token: 0x020000A7 RID: 167
	public static class EncryptionSettings : Object
	{
		// Token: 0x06000B44 RID: 2884 RVA: 0x0003E614 File Offset: 0x0003C814
		// Note: this type is marked as 'beforefieldinit'.
		static EncryptionSettings()
		{
			Il2CppClassPointerStore<EncryptionSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings", "EncryptionSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncryptionSettings>.NativeClassPtr);
			EncryptionSettings.NativeMethodInfoPtr_Encrypt_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncryptionSettings>.NativeClassPtr, 100664866);
			EncryptionSettings.NativeMethodInfoPtr_Decrypt_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncryptionSettings>.NativeClassPtr, 100664867);
			EncryptionSettings.NativeMethodInfoPtr_modValueDecrypt_Private_Static_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncryptionSettings>.NativeClassPtr, 100664868);
			EncryptionSettings.NativeMethodInfoPtr_modValueEncrypt_Private_Static_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncryptionSettings>.NativeClassPtr, 100664869);
			EncryptionSettings.NativeMethodInfoPtr_readByteArray_Private_Static_Il2CppStructArray_1_Byte_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncryptionSettings>.NativeClassPtr, 100664870);
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x0003E6A8 File Offset: 0x0003C8A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 863536, RefRangeEnd = 863538, XrefRangeStart = 863533, XrefRangeEnd = 863536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Encrypt(this string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncryptionSettings.NativeMethodInfoPtr_Encrypt_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x0003E6E4 File Offset: 0x0003C8E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 863541, RefRangeEnd = 863542, XrefRangeStart = 863538, XrefRangeEnd = 863541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Decrypt(this string contents)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(contents);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncryptionSettings.NativeMethodInfoPtr_Decrypt_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x0003E720 File Offset: 0x0003C920
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 863594, RefRangeEnd = 863595, XrefRangeStart = 863542, XrefRangeEnd = 863594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string modValueDecrypt(string cipherText, string salt, string sharedSecret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cipherText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(salt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sharedSecret);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncryptionSettings.NativeMethodInfoPtr_modValueDecrypt_Private_Static_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x0003E780 File Offset: 0x0003C980
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 863643, RefRangeEnd = 863644, XrefRangeStart = 863595, XrefRangeEnd = 863643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string modValueEncrypt(string plainText, string salt, string sharedSecret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(plainText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(salt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sharedSecret);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncryptionSettings.NativeMethodInfoPtr_modValueEncrypt_Private_Static_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x0003E7E0 File Offset: 0x0003C9E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863644, XrefRangeEnd = 863650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> readByteArray(Stream stream)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncryptionSettings.NativeMethodInfoPtr_readByteArray_Private_Static_Il2CppStructArray_1_Byte_Stream_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x00005FEF File Offset: 0x000041EF
		public EncryptionSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000839 RID: 2105
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Static_String_String_0;

		// Token: 0x0400083A RID: 2106
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Static_String_String_0;

		// Token: 0x0400083B RID: 2107
		private static readonly IntPtr NativeMethodInfoPtr_modValueDecrypt_Private_Static_String_String_String_String_0;

		// Token: 0x0400083C RID: 2108
		private static readonly IntPtr NativeMethodInfoPtr_modValueEncrypt_Private_Static_String_String_String_String_0;

		// Token: 0x0400083D RID: 2109
		private static readonly IntPtr NativeMethodInfoPtr_readByteArray_Private_Static_Il2CppStructArray_1_Byte_Stream_0;
	}
}

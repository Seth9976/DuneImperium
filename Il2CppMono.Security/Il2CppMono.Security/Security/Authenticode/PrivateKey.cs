using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Authenticode
{
	// Token: 0x0200003D RID: 61
	public class PrivateKey : Object
	{
		// Token: 0x06000393 RID: 915 RVA: 0x00011690 File Offset: 0x0000F890
		// Note: this type is marked as 'beforefieldinit'.
		static PrivateKey()
		{
			Il2CppClassPointerStore<PrivateKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Authenticode", "PrivateKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrivateKey>.NativeClassPtr);
			PrivateKey.NativeFieldInfoPtr_encrypted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrivateKey>.NativeClassPtr, "encrypted");
			PrivateKey.NativeFieldInfoPtr_rsa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrivateKey>.NativeClassPtr, "rsa");
			PrivateKey.NativeFieldInfoPtr_weak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrivateKey>.NativeClassPtr, "weak");
			PrivateKey.NativeFieldInfoPtr_keyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrivateKey>.NativeClassPtr, "keyType");
			PrivateKey.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrivateKey>.NativeClassPtr, 100663807);
			PrivateKey.NativeMethodInfoPtr_get_RSA_Public_get_RSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrivateKey>.NativeClassPtr, 100663808);
			PrivateKey.NativeMethodInfoPtr_DeriveKey_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrivateKey>.NativeClassPtr, 100663809);
			PrivateKey.NativeMethodInfoPtr_Decode_Private_Boolean_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrivateKey>.NativeClassPtr, 100663810);
			PrivateKey.NativeMethodInfoPtr_CreateFromFile_Public_Static_PrivateKey_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrivateKey>.NativeClassPtr, 100663811);
			PrivateKey.NativeMethodInfoPtr_CreateFromFile_Public_Static_PrivateKey_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrivateKey>.NativeClassPtr, 100663812);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00011788 File Offset: 0x0000F988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151241, XrefRangeEnd = 1151243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrivateKey(Il2CppStructArray<byte> data, string password)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrivateKey>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrivateKey.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000395 RID: 917 RVA: 0x000117E8 File Offset: 0x0000F9E8
		public unsafe RSA RSA
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrivateKey.NativeMethodInfoPtr_get_RSA_Public_get_RSA_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RSA>(intPtr3) : null;
			}
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00011828 File Offset: 0x0000FA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151243, XrefRangeEnd = 1151253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> DeriveKey(Il2CppStructArray<byte> salt, string password)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(salt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrivateKey.NativeMethodInfoPtr_DeriveKey_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0001188C File Offset: 0x0000FA8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1151301, RefRangeEnd = 1151303, XrefRangeStart = 1151253, XrefRangeEnd = 1151301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Decode(Il2CppStructArray<byte> pvk, string password)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pvk);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrivateKey.NativeMethodInfoPtr_Decode_Private_Boolean_Il2CppStructArray_1_Byte_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x000118EC File Offset: 0x0000FAEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1151304, RefRangeEnd = 1151305, XrefRangeStart = 1151303, XrefRangeEnd = 1151304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PrivateKey CreateFromFile(string filename)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrivateKey.NativeMethodInfoPtr_CreateFromFile_Public_Static_PrivateKey_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PrivateKey>(intPtr3) : null;
			}
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00011930 File Offset: 0x0000FB30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1151324, RefRangeEnd = 1151325, XrefRangeStart = 1151305, XrefRangeEnd = 1151324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PrivateKey CreateFromFile(string filename, string password)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrivateKey.NativeMethodInfoPtr_CreateFromFile_Public_Static_PrivateKey_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PrivateKey>(intPtr3) : null;
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0000393E File Offset: 0x00001B3E
		public PrivateKey(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600039B RID: 923 RVA: 0x00011988 File Offset: 0x0000FB88
		// (set) Token: 0x0600039C RID: 924 RVA: 0x00003947 File Offset: 0x00001B47
		public unsafe bool encrypted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrivateKey.NativeFieldInfoPtr_encrypted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrivateKey.NativeFieldInfoPtr_encrypted)) = value;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600039D RID: 925 RVA: 0x000119B0 File Offset: 0x0000FBB0
		// (set) Token: 0x0600039E RID: 926 RVA: 0x00003962 File Offset: 0x00001B62
		public unsafe RSA rsa
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrivateKey.NativeFieldInfoPtr_rsa);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RSA>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrivateKey.NativeFieldInfoPtr_rsa), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600039F RID: 927 RVA: 0x000119E0 File Offset: 0x0000FBE0
		// (set) Token: 0x060003A0 RID: 928 RVA: 0x00003981 File Offset: 0x00001B81
		public unsafe bool weak
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrivateKey.NativeFieldInfoPtr_weak);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrivateKey.NativeFieldInfoPtr_weak)) = value;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x00011A08 File Offset: 0x0000FC08
		// (set) Token: 0x060003A2 RID: 930 RVA: 0x0000399C File Offset: 0x00001B9C
		public unsafe int keyType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrivateKey.NativeFieldInfoPtr_keyType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrivateKey.NativeFieldInfoPtr_keyType)) = value;
			}
		}

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeFieldInfoPtr_encrypted;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeFieldInfoPtr_rsa;

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeFieldInfoPtr_weak;

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeFieldInfoPtr_keyType;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeMethodInfoPtr_get_RSA_Public_get_RSA_0;

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeMethodInfoPtr_DeriveKey_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Private_Boolean_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeMethodInfoPtr_CreateFromFile_Public_Static_PrivateKey_String_0;

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeMethodInfoPtr_CreateFromFile_Public_Static_PrivateKey_String_String_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x02000032 RID: 50
	public sealed class PKCS1 : Object
	{
		// Token: 0x0600028A RID: 650 RVA: 0x0002F6DC File Offset: 0x0002D8DC
		// Note: this type is marked as 'beforefieldinit'.
		static PKCS1()
		{
			Il2CppClassPointerStore<PKCS1>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security.Cryptography", "PKCS1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS1>.NativeClassPtr);
			PKCS1.NativeFieldInfoPtr_emptySHA1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, "emptySHA1");
			PKCS1.NativeFieldInfoPtr_emptySHA256 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, "emptySHA256");
			PKCS1.NativeFieldInfoPtr_emptySHA384 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, "emptySHA384");
			PKCS1.NativeFieldInfoPtr_emptySHA512 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, "emptySHA512");
			PKCS1.NativeMethodInfoPtr_Compare_Private_Static_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, 100663671);
			PKCS1.NativeMethodInfoPtr_I2OSP_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, 100663672);
			PKCS1.NativeMethodInfoPtr_OS2IP_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, 100663673);
			PKCS1.NativeMethodInfoPtr_RSASP1_Public_Static_Il2CppStructArray_1_Byte_RSA_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, 100663674);
			PKCS1.NativeMethodInfoPtr_RSAVP1_Public_Static_Il2CppStructArray_1_Byte_RSA_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, 100663675);
			PKCS1.NativeMethodInfoPtr_Sign_v15_Public_Static_Il2CppStructArray_1_Byte_RSA_HashAlgorithm_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, 100663676);
			PKCS1.NativeMethodInfoPtr_Verify_v15_Public_Static_Boolean_RSA_HashAlgorithm_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, 100663677);
			PKCS1.NativeMethodInfoPtr_Verify_v15_Internal_Static_Boolean_RSA_String_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, 100663678);
			PKCS1.NativeMethodInfoPtr_Verify_v15_Public_Static_Boolean_RSA_HashAlgorithm_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, 100663679);
			PKCS1.NativeMethodInfoPtr_Encode_v15_Public_Static_Il2CppStructArray_1_Byte_HashAlgorithm_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, 100663680);
			PKCS1.NativeMethodInfoPtr_CreateFromName_Internal_Static_HashAlgorithm_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, 100663681);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0002F838 File Offset: 0x0002DA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Compare(Il2CppStructArray<byte> array1, Il2CppStructArray<byte> array2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(array2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS1.NativeMethodInfoPtr_Compare_Private_Static_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0002F88C File Offset: 0x0002DA8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278335, XrefRangeEnd = 1278339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> I2OSP(Il2CppStructArray<byte> x, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS1.NativeMethodInfoPtr_I2OSP_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0002F8E0 File Offset: 0x0002DAE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278339, XrefRangeEnd = 1278340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> OS2IP(Il2CppStructArray<byte> x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS1.NativeMethodInfoPtr_OS2IP_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0002F924 File Offset: 0x0002DB24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278340, XrefRangeEnd = 1278341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> RSASP1(RSA rsa, Il2CppStructArray<byte> m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rsa);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS1.NativeMethodInfoPtr_RSASP1_Public_Static_Il2CppStructArray_1_Byte_RSA_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0002F97C File Offset: 0x0002DB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> RSAVP1(RSA rsa, Il2CppStructArray<byte> s)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rsa);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS1.NativeMethodInfoPtr_RSAVP1_Public_Static_Il2CppStructArray_1_Byte_RSA_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0002F9D4 File Offset: 0x0002DBD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1278353, RefRangeEnd = 1278354, XrefRangeStart = 1278341, XrefRangeEnd = 1278353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> Sign_v15(RSA rsa, HashAlgorithm hash, Il2CppStructArray<byte> hashValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rsa);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hash);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hashValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS1.NativeMethodInfoPtr_Sign_v15_Public_Static_Il2CppStructArray_1_Byte_RSA_HashAlgorithm_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0002FA3C File Offset: 0x0002DC3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1278358, RefRangeEnd = 1278359, XrefRangeStart = 1278354, XrefRangeEnd = 1278358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Verify_v15(RSA rsa, HashAlgorithm hash, Il2CppStructArray<byte> hashValue, Il2CppStructArray<byte> signature)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rsa);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hash);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hashValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(signature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS1.NativeMethodInfoPtr_Verify_v15_Public_Static_Boolean_RSA_HashAlgorithm_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0002FAB4 File Offset: 0x0002DCB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1278372, RefRangeEnd = 1278373, XrefRangeStart = 1278359, XrefRangeEnd = 1278372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Verify_v15(RSA rsa, string hashName, Il2CppStructArray<byte> hashValue, Il2CppStructArray<byte> signature)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rsa);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(hashName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hashValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(signature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS1.NativeMethodInfoPtr_Verify_v15_Internal_Static_Boolean_RSA_String_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0002FB2C File Offset: 0x0002DD2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1278395, RefRangeEnd = 1278397, XrefRangeStart = 1278373, XrefRangeEnd = 1278395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Verify_v15(RSA rsa, HashAlgorithm hash, Il2CppStructArray<byte> hashValue, Il2CppStructArray<byte> signature, bool tryNonStandardEncoding)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rsa);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hash);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hashValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(signature);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tryNonStandardEncoding;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS1.NativeMethodInfoPtr_Verify_v15_Public_Static_Boolean_RSA_HashAlgorithm_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0002FBB4 File Offset: 0x0002DDB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1278434, RefRangeEnd = 1278436, XrefRangeStart = 1278397, XrefRangeEnd = 1278434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> Encode_v15(HashAlgorithm hash, Il2CppStructArray<byte> hashValue, int emLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hash);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hashValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref emLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS1.NativeMethodInfoPtr_Encode_v15_Public_Static_Il2CppStructArray_1_Byte_HashAlgorithm_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0002FC18 File Offset: 0x0002DE18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1278484, RefRangeEnd = 1278485, XrefRangeStart = 1278436, XrefRangeEnd = 1278484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HashAlgorithm CreateFromName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS1.NativeMethodInfoPtr_CreateFromName_Internal_Static_HashAlgorithm_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashAlgorithm>(intPtr3) : null;
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000303A File Offset: 0x0000123A
		public PKCS1(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000297 RID: 663 RVA: 0x0002FC5C File Offset: 0x0002DE5C
		// (set) Token: 0x06000298 RID: 664 RVA: 0x00003043 File Offset: 0x00001243
		public unsafe static Il2CppStructArray<byte> emptySHA1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PKCS1.NativeFieldInfoPtr_emptySHA1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PKCS1.NativeFieldInfoPtr_emptySHA1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000299 RID: 665 RVA: 0x0002FC84 File Offset: 0x0002DE84
		// (set) Token: 0x0600029A RID: 666 RVA: 0x00003055 File Offset: 0x00001255
		public unsafe static Il2CppStructArray<byte> emptySHA256
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PKCS1.NativeFieldInfoPtr_emptySHA256, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PKCS1.NativeFieldInfoPtr_emptySHA256, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600029B RID: 667 RVA: 0x0002FCAC File Offset: 0x0002DEAC
		// (set) Token: 0x0600029C RID: 668 RVA: 0x00003067 File Offset: 0x00001267
		public unsafe static Il2CppStructArray<byte> emptySHA384
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PKCS1.NativeFieldInfoPtr_emptySHA384, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PKCS1.NativeFieldInfoPtr_emptySHA384, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600029D RID: 669 RVA: 0x0002FCD4 File Offset: 0x0002DED4
		// (set) Token: 0x0600029E RID: 670 RVA: 0x00003079 File Offset: 0x00001279
		public unsafe static Il2CppStructArray<byte> emptySHA512
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PKCS1.NativeFieldInfoPtr_emptySHA512, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PKCS1.NativeFieldInfoPtr_emptySHA512, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeFieldInfoPtr_emptySHA1;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeFieldInfoPtr_emptySHA256;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeFieldInfoPtr_emptySHA384;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeFieldInfoPtr_emptySHA512;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Private_Static_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr_I2OSP_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr_OS2IP_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr_RSASP1_Public_Static_Il2CppStructArray_1_Byte_RSA_Il2CppStructArray_1_Byte_0;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeMethodInfoPtr_RSAVP1_Public_Static_Il2CppStructArray_1_Byte_RSA_Il2CppStructArray_1_Byte_0;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr_Sign_v15_Public_Static_Il2CppStructArray_1_Byte_RSA_HashAlgorithm_Il2CppStructArray_1_Byte_0;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr_Verify_v15_Public_Static_Boolean_RSA_HashAlgorithm_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr_Verify_v15_Internal_Static_Boolean_RSA_String_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr_Verify_v15_Public_Static_Boolean_RSA_HashAlgorithm_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_Encode_v15_Public_Static_Il2CppStructArray_1_Byte_HashAlgorithm_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr_CreateFromName_Internal_Static_HashAlgorithm_String_0;
	}
}

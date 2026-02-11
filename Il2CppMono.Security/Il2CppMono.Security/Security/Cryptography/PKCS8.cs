using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x02000038 RID: 56
	public sealed class PKCS8 : Object
	{
		// Token: 0x0600031C RID: 796 RVA: 0x000034C7 File Offset: 0x000016C7
		// Note: this type is marked as 'beforefieldinit'.
		static PKCS8()
		{
			Il2CppClassPointerStore<PKCS8>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Cryptography", "PKCS8");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS8>.NativeClassPtr);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x000034EC File Offset: 0x000016EC
		public PKCS8(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0200005D RID: 93
		public class PrivateKeyInfo : Object
		{
			// Token: 0x060004EE RID: 1262 RVA: 0x00015968 File Offset: 0x00013B68
			// Note: this type is marked as 'beforefieldinit'.
			static PrivateKeyInfo()
			{
				Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PKCS8>.NativeClassPtr, "PrivateKeyInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr);
				PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, "_version");
				PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__algorithm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, "_algorithm");
				PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, "_key");
				PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, "_list");
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663743);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663744);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_get_Algorithm_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663745);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_set_Algorithm_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663746);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_get_PrivateKey_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663747);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_set_PrivateKey_Public_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663748);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663749);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_GetBytes_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663750);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_RemoveLeadingZero_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663751);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_Normalize_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663752);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_DecodeRSA_Public_Static_RSA_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663753);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_Encode_Public_Static_Il2CppStructArray_1_Byte_RSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663754);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_DecodeDSA_Public_Static_DSA_Il2CppStructArray_1_Byte_DSAParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663755);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_Encode_Public_Static_Il2CppStructArray_1_Byte_DSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663756);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_Encode_Public_Static_Il2CppStructArray_1_Byte_AsymmetricAlgorithm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663757);
			}

			// Token: 0x060004EF RID: 1263 RVA: 0x00015B10 File Offset: 0x00013D10
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1149929, RefRangeEnd = 1149930, XrefRangeStart = 1149923, XrefRangeEnd = 1149929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PrivateKeyInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004F0 RID: 1264 RVA: 0x00015B4C File Offset: 0x00013D4C
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1149937, RefRangeEnd = 1149942, XrefRangeStart = 1149930, XrefRangeEnd = 1149937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PrivateKeyInfo(Il2CppStructArray<byte> data)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170001A4 RID: 420
			// (get) Token: 0x060004F1 RID: 1265 RVA: 0x00015B98 File Offset: 0x00013D98
			// (set) Token: 0x060004F2 RID: 1266 RVA: 0x00015BD0 File Offset: 0x00013DD0
			public unsafe string Algorithm
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_get_Algorithm_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_set_Algorithm_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170001A5 RID: 421
			// (get) Token: 0x060004F3 RID: 1267 RVA: 0x00015C14 File Offset: 0x00013E14
			// (set) Token: 0x060004F4 RID: 1268 RVA: 0x00015C54 File Offset: 0x00013E54
			public unsafe Il2CppStructArray<byte> PrivateKey
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 1149945, RefRangeEnd = 1149949, XrefRangeStart = 1149942, XrefRangeEnd = 1149945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_get_PrivateKey_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1149965, RefRangeEnd = 1149966, XrefRangeStart = 1149949, XrefRangeEnd = 1149965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_set_PrivateKey_Public_set_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060004F5 RID: 1269 RVA: 0x00015C98 File Offset: 0x00013E98
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1149984, RefRangeEnd = 1149985, XrefRangeStart = 1149966, XrefRangeEnd = 1149984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Decode(Il2CppStructArray<byte> data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060004F6 RID: 1270 RVA: 0x00015CDC File Offset: 0x00013EDC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1150031, RefRangeEnd = 1150032, XrefRangeStart = 1149985, XrefRangeEnd = 1150031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<byte> GetBytes()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_GetBytes_Public_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}

			// Token: 0x060004F7 RID: 1271 RVA: 0x00015D1C File Offset: 0x00013F1C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1150036, RefRangeEnd = 1150039, XrefRangeStart = 1150032, XrefRangeEnd = 1150036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Il2CppStructArray<byte> RemoveLeadingZero(Il2CppStructArray<byte> bigInt)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bigInt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_RemoveLeadingZero_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x060004F8 RID: 1272 RVA: 0x00015D60 File Offset: 0x00013F60
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1150043, RefRangeEnd = 1150049, XrefRangeStart = 1150039, XrefRangeEnd = 1150043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Il2CppStructArray<byte> Normalize(Il2CppStructArray<byte> bigInt, int length)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bigInt);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_Normalize_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}

			// Token: 0x060004F9 RID: 1273 RVA: 0x00015DB4 File Offset: 0x00013FB4
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1150096, RefRangeEnd = 1150102, XrefRangeStart = 1150049, XrefRangeEnd = 1150096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static RSA DecodeRSA(Il2CppStructArray<byte> keypair)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(keypair);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_DecodeRSA_Public_Static_RSA_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<RSA>(intPtr3) : null;
				}
			}

			// Token: 0x060004FA RID: 1274 RVA: 0x00015DF8 File Offset: 0x00013FF8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1150130, RefRangeEnd = 1150133, XrefRangeStart = 1150102, XrefRangeEnd = 1150130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Il2CppStructArray<byte> Encode(RSA rsa)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(rsa);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_Encode_Public_Static_Il2CppStructArray_1_Byte_RSA_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x060004FB RID: 1275 RVA: 0x00015E3C File Offset: 0x0001403C
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1150147, RefRangeEnd = 1150151, XrefRangeStart = 1150133, XrefRangeEnd = 1150147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DSA DecodeDSA(Il2CppStructArray<byte> privateKey, DSAParameters dsaParameters)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(privateKey);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dsaParameters));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_DecodeDSA_Public_Static_DSA_Il2CppStructArray_1_Byte_DSAParameters_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DSA>(intPtr3) : null;
			}

			// Token: 0x060004FC RID: 1276 RVA: 0x00015E98 File Offset: 0x00014098
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1150153, RefRangeEnd = 1150154, XrefRangeStart = 1150151, XrefRangeEnd = 1150153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Il2CppStructArray<byte> Encode(DSA dsa)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dsa);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_Encode_Public_Static_Il2CppStructArray_1_Byte_DSA_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x060004FD RID: 1277 RVA: 0x00015EDC File Offset: 0x000140DC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1150171, RefRangeEnd = 1150172, XrefRangeStart = 1150154, XrefRangeEnd = 1150171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Il2CppStructArray<byte> Encode(AsymmetricAlgorithm aa)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(aa);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_Encode_Public_Static_Il2CppStructArray_1_Byte_AsymmetricAlgorithm_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x060004FE RID: 1278 RVA: 0x00004435 File Offset: 0x00002635
			public PrivateKeyInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001A0 RID: 416
			// (get) Token: 0x060004FF RID: 1279 RVA: 0x00015F20 File Offset: 0x00014120
			// (set) Token: 0x06000500 RID: 1280 RVA: 0x0000443E File Offset: 0x0000263E
			public unsafe int _version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__version)) = value;
				}
			}

			// Token: 0x170001A1 RID: 417
			// (get) Token: 0x06000501 RID: 1281 RVA: 0x00015F48 File Offset: 0x00014148
			// (set) Token: 0x06000502 RID: 1282 RVA: 0x00004459 File Offset: 0x00002659
			public unsafe string _algorithm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__algorithm);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__algorithm), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170001A2 RID: 418
			// (get) Token: 0x06000503 RID: 1283 RVA: 0x00015F70 File Offset: 0x00014170
			// (set) Token: 0x06000504 RID: 1284 RVA: 0x00004478 File Offset: 0x00002678
			public unsafe Il2CppStructArray<byte> _key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__key);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__key), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001A3 RID: 419
			// (get) Token: 0x06000505 RID: 1285 RVA: 0x00015FA0 File Offset: 0x000141A0
			// (set) Token: 0x06000506 RID: 1286 RVA: 0x00004497 File Offset: 0x00002697
			public unsafe ArrayList _list
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__list);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__list), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400048A RID: 1162
			private static readonly IntPtr NativeFieldInfoPtr__version;

			// Token: 0x0400048B RID: 1163
			private static readonly IntPtr NativeFieldInfoPtr__algorithm;

			// Token: 0x0400048C RID: 1164
			private static readonly IntPtr NativeFieldInfoPtr__key;

			// Token: 0x0400048D RID: 1165
			private static readonly IntPtr NativeFieldInfoPtr__list;

			// Token: 0x0400048E RID: 1166
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400048F RID: 1167
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x04000490 RID: 1168
			private static readonly IntPtr NativeMethodInfoPtr_get_Algorithm_Public_get_String_0;

			// Token: 0x04000491 RID: 1169
			private static readonly IntPtr NativeMethodInfoPtr_set_Algorithm_Public_set_Void_String_0;

			// Token: 0x04000492 RID: 1170
			private static readonly IntPtr NativeMethodInfoPtr_get_PrivateKey_Public_get_Il2CppStructArray_1_Byte_0;

			// Token: 0x04000493 RID: 1171
			private static readonly IntPtr NativeMethodInfoPtr_set_PrivateKey_Public_set_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x04000494 RID: 1172
			private static readonly IntPtr NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x04000495 RID: 1173
			private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Il2CppStructArray_1_Byte_0;

			// Token: 0x04000496 RID: 1174
			private static readonly IntPtr NativeMethodInfoPtr_RemoveLeadingZero_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

			// Token: 0x04000497 RID: 1175
			private static readonly IntPtr NativeMethodInfoPtr_Normalize_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0;

			// Token: 0x04000498 RID: 1176
			private static readonly IntPtr NativeMethodInfoPtr_DecodeRSA_Public_Static_RSA_Il2CppStructArray_1_Byte_0;

			// Token: 0x04000499 RID: 1177
			private static readonly IntPtr NativeMethodInfoPtr_Encode_Public_Static_Il2CppStructArray_1_Byte_RSA_0;

			// Token: 0x0400049A RID: 1178
			private static readonly IntPtr NativeMethodInfoPtr_DecodeDSA_Public_Static_DSA_Il2CppStructArray_1_Byte_DSAParameters_0;

			// Token: 0x0400049B RID: 1179
			private static readonly IntPtr NativeMethodInfoPtr_Encode_Public_Static_Il2CppStructArray_1_Byte_DSA_0;

			// Token: 0x0400049C RID: 1180
			private static readonly IntPtr NativeMethodInfoPtr_Encode_Public_Static_Il2CppStructArray_1_Byte_AsymmetricAlgorithm_0;
		}

		// Token: 0x0200005E RID: 94
		public class EncryptedPrivateKeyInfo : Object
		{
			// Token: 0x06000507 RID: 1287 RVA: 0x00015FD0 File Offset: 0x000141D0
			// Note: this type is marked as 'beforefieldinit'.
			static EncryptedPrivateKeyInfo()
			{
				Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PKCS8>.NativeClassPtr, "EncryptedPrivateKeyInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr);
				PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__algorithm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, "_algorithm");
				PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__salt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, "_salt");
				PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__iterations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, "_iterations");
				PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, "_data");
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663758);
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663759);
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_get_Algorithm_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663760);
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_set_Algorithm_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663761);
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_get_EncryptedData_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663762);
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_set_EncryptedData_Public_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663763);
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_get_Salt_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663764);
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_get_IterationCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663765);
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_set_IterationCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663766);
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663767);
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_GetBytes_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663768);
			}

			// Token: 0x06000508 RID: 1288 RVA: 0x00016128 File Offset: 0x00014328
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EncryptedPrivateKeyInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000509 RID: 1289 RVA: 0x00016164 File Offset: 0x00014364
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1150174, RefRangeEnd = 1150177, XrefRangeStart = 1150172, XrefRangeEnd = 1150174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EncryptedPrivateKeyInfo(Il2CppStructArray<byte> data)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170001AA RID: 426
			// (get) Token: 0x0600050A RID: 1290 RVA: 0x000161B0 File Offset: 0x000143B0
			// (set) Token: 0x0600050B RID: 1291 RVA: 0x000161E8 File Offset: 0x000143E8
			public unsafe string Algorithm
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_get_Algorithm_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_set_Algorithm_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170001AB RID: 427
			// (get) Token: 0x0600050C RID: 1292 RVA: 0x0001622C File Offset: 0x0001442C
			// (set) Token: 0x0600050D RID: 1293 RVA: 0x0001626C File Offset: 0x0001446C
			public unsafe Il2CppStructArray<byte> EncryptedData
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 1150178, RefRangeEnd = 1150181, XrefRangeStart = 1150177, XrefRangeEnd = 1150178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_get_EncryptedData_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1150189, RefRangeEnd = 1150190, XrefRangeStart = 1150181, XrefRangeEnd = 1150189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_set_EncryptedData_Public_set_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170001AC RID: 428
			// (get) Token: 0x0600050E RID: 1294 RVA: 0x000162B0 File Offset: 0x000144B0
			public unsafe Il2CppStructArray<byte> Salt
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 1150197, RefRangeEnd = 1150201, XrefRangeStart = 1150190, XrefRangeEnd = 1150197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_get_Salt_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x170001AD RID: 429
			// (get) Token: 0x0600050F RID: 1295 RVA: 0x000162F0 File Offset: 0x000144F0
			// (set) Token: 0x06000510 RID: 1296 RVA: 0x0001632C File Offset: 0x0001452C
			public unsafe int IterationCount
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_get_IterationCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1150201, RefRangeEnd = 1150202, XrefRangeStart = 1150201, XrefRangeEnd = 1150201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_set_IterationCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000511 RID: 1297 RVA: 0x0001636C File Offset: 0x0001456C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1150263, RefRangeEnd = 1150264, XrefRangeStart = 1150202, XrefRangeEnd = 1150263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Decode(Il2CppStructArray<byte> data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000512 RID: 1298 RVA: 0x000163B0 File Offset: 0x000145B0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1150295, RefRangeEnd = 1150296, XrefRangeStart = 1150264, XrefRangeEnd = 1150295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<byte> GetBytes()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_GetBytes_Public_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}

			// Token: 0x06000513 RID: 1299 RVA: 0x000044B6 File Offset: 0x000026B6
			public EncryptedPrivateKeyInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001A6 RID: 422
			// (get) Token: 0x06000514 RID: 1300 RVA: 0x000163F0 File Offset: 0x000145F0
			// (set) Token: 0x06000515 RID: 1301 RVA: 0x000044BF File Offset: 0x000026BF
			public unsafe string _algorithm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__algorithm);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__algorithm), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170001A7 RID: 423
			// (get) Token: 0x06000516 RID: 1302 RVA: 0x00016418 File Offset: 0x00014618
			// (set) Token: 0x06000517 RID: 1303 RVA: 0x000044DE File Offset: 0x000026DE
			public unsafe Il2CppStructArray<byte> _salt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__salt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__salt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001A8 RID: 424
			// (get) Token: 0x06000518 RID: 1304 RVA: 0x00016448 File Offset: 0x00014648
			// (set) Token: 0x06000519 RID: 1305 RVA: 0x000044FD File Offset: 0x000026FD
			public unsafe int _iterations
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__iterations);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__iterations)) = value;
				}
			}

			// Token: 0x170001A9 RID: 425
			// (get) Token: 0x0600051A RID: 1306 RVA: 0x00016470 File Offset: 0x00014670
			// (set) Token: 0x0600051B RID: 1307 RVA: 0x00004518 File Offset: 0x00002718
			public unsafe Il2CppStructArray<byte> _data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400049D RID: 1181
			private static readonly IntPtr NativeFieldInfoPtr__algorithm;

			// Token: 0x0400049E RID: 1182
			private static readonly IntPtr NativeFieldInfoPtr__salt;

			// Token: 0x0400049F RID: 1183
			private static readonly IntPtr NativeFieldInfoPtr__iterations;

			// Token: 0x040004A0 RID: 1184
			private static readonly IntPtr NativeFieldInfoPtr__data;

			// Token: 0x040004A1 RID: 1185
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004A2 RID: 1186
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x040004A3 RID: 1187
			private static readonly IntPtr NativeMethodInfoPtr_get_Algorithm_Public_get_String_0;

			// Token: 0x040004A4 RID: 1188
			private static readonly IntPtr NativeMethodInfoPtr_set_Algorithm_Public_set_Void_String_0;

			// Token: 0x040004A5 RID: 1189
			private static readonly IntPtr NativeMethodInfoPtr_get_EncryptedData_Public_get_Il2CppStructArray_1_Byte_0;

			// Token: 0x040004A6 RID: 1190
			private static readonly IntPtr NativeMethodInfoPtr_set_EncryptedData_Public_set_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x040004A7 RID: 1191
			private static readonly IntPtr NativeMethodInfoPtr_get_Salt_Public_get_Il2CppStructArray_1_Byte_0;

			// Token: 0x040004A8 RID: 1192
			private static readonly IntPtr NativeMethodInfoPtr_get_IterationCount_Public_get_Int32_0;

			// Token: 0x040004A9 RID: 1193
			private static readonly IntPtr NativeMethodInfoPtr_set_IterationCount_Public_set_Void_Int32_0;

			// Token: 0x040004AA RID: 1194
			private static readonly IntPtr NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x040004AB RID: 1195
			private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Il2CppStructArray_1_Byte_0;
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography;

namespace Google.Apis.Auth.OAuth2
{
	// Token: 0x02000019 RID: 25
	public class Pkcs8 : Object
	{
		// Token: 0x0600012D RID: 301 RVA: 0x0000AF98 File Offset: 0x00009198
		// Note: this type is marked as 'beforefieldinit'.
		static Pkcs8()
		{
			Il2CppClassPointerStore<Pkcs8>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2", "Pkcs8");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pkcs8>.NativeClassPtr);
			Pkcs8.NativeMethodInfoPtr_DecodeRsaParameters_Public_Static_RSAParameters_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pkcs8>.NativeClassPtr, 100663586);
			Pkcs8.NativeMethodInfoPtr_TrimLeadingZeroes_Internal_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pkcs8>.NativeClassPtr, 100663587);
			Pkcs8.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pkcs8>.NativeClassPtr, 100663588);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000B004 File Offset: 0x00009204
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1155132, RefRangeEnd = 1155134, XrefRangeStart = 1155061, XrefRangeEnd = 1155132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RSAParameters DecodeRsaParameters(string pkcs8PrivateKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pkcs8PrivateKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pkcs8.NativeMethodInfoPtr_DecodeRsaParameters_Public_Static_RSAParameters_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new RSAParameters(intPtr);
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000B040 File Offset: 0x00009240
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1155140, RefRangeEnd = 1155148, XrefRangeStart = 1155134, XrefRangeEnd = 1155140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> TrimLeadingZeroes(Il2CppStructArray<byte> bs, bool alignTo8Bytes = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignTo8Bytes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pkcs8.NativeMethodInfoPtr_TrimLeadingZeroes_Internal_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000B094 File Offset: 0x00009294
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pkcs8()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pkcs8>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pkcs8.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002859 File Offset: 0x00000A59
		public Pkcs8(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_DecodeRsaParameters_Public_Static_RSAParameters_String_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_TrimLeadingZeroes_Internal_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000051 RID: 81
		public class Asn1 : Object
		{
			// Token: 0x06000518 RID: 1304 RVA: 0x00017898 File Offset: 0x00015A98
			// Note: this type is marked as 'beforefieldinit'.
			static Asn1()
			{
				Il2CppClassPointerStore<Pkcs8.Asn1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pkcs8>.NativeClassPtr, "Asn1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pkcs8.Asn1>.NativeClassPtr);
				Pkcs8.Asn1.NativeMethodInfoPtr_Decode_Public_Static_Object_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pkcs8.Asn1>.NativeClassPtr, 100663589);
				Pkcs8.Asn1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pkcs8.Asn1>.NativeClassPtr, 100663590);
			}

			// Token: 0x06000519 RID: 1305 RVA: 0x000178EC File Offset: 0x00015AEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155055, XrefRangeEnd = 1155061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Object Decode(Il2CppStructArray<byte> bs)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bs);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pkcs8.Asn1.NativeMethodInfoPtr_Decode_Public_Static_Object_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600051A RID: 1306 RVA: 0x00017930 File Offset: 0x00015B30
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Asn1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pkcs8.Asn1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pkcs8.Asn1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600051B RID: 1307 RVA: 0x00004C0C File Offset: 0x00002E0C
			public Asn1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000324 RID: 804
			private static readonly IntPtr NativeMethodInfoPtr_Decode_Public_Static_Object_Il2CppStructArray_1_Byte_0;

			// Token: 0x04000325 RID: 805
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0200007D RID: 125
			public enum Tag
			{
				// Token: 0x040004AC RID: 1196
				Integer = 2,
				// Token: 0x040004AD RID: 1197
				OctetString = 4,
				// Token: 0x040004AE RID: 1198
				Null,
				// Token: 0x040004AF RID: 1199
				ObjectIdentifier,
				// Token: 0x040004B0 RID: 1200
				Sequence = 16
			}

			// Token: 0x0200007E RID: 126
			public class Decoder : Object
			{
				// Token: 0x06000801 RID: 2049 RVA: 0x0001EEF8 File Offset: 0x0001D0F8
				// Note: this type is marked as 'beforefieldinit'.
				static Decoder()
				{
					Il2CppClassPointerStore<Pkcs8.Asn1.Decoder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pkcs8.Asn1>.NativeClassPtr, "Decoder");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pkcs8.Asn1.Decoder>.NativeClassPtr);
					Pkcs8.Asn1.Decoder.NativeFieldInfoPtr__bytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pkcs8.Asn1.Decoder>.NativeClassPtr, "_bytes");
					Pkcs8.Asn1.Decoder.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pkcs8.Asn1.Decoder>.NativeClassPtr, "_index");
					Pkcs8.Asn1.Decoder.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pkcs8.Asn1.Decoder>.NativeClassPtr, 100663591);
					Pkcs8.Asn1.Decoder.NativeMethodInfoPtr_Decode_Public_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pkcs8.Asn1.Decoder>.NativeClassPtr, 100663592);
					Pkcs8.Asn1.Decoder.NativeMethodInfoPtr_NextByte_Private_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pkcs8.Asn1.Decoder>.NativeClassPtr, 100663593);
					Pkcs8.Asn1.Decoder.NativeMethodInfoPtr_ReadLengthPrefixedBytes_Private_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pkcs8.Asn1.Decoder>.NativeClassPtr, 100663594);
					Pkcs8.Asn1.Decoder.NativeMethodInfoPtr_ReadInteger_Private_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pkcs8.Asn1.Decoder>.NativeClassPtr, 100663595);
					Pkcs8.Asn1.Decoder.NativeMethodInfoPtr_ReadOctetString_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pkcs8.Asn1.Decoder>.NativeClassPtr, 100663596);
					Pkcs8.Asn1.Decoder.NativeMethodInfoPtr_ReadNull_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pkcs8.Asn1.Decoder>.NativeClassPtr, 100663597);
					Pkcs8.Asn1.Decoder.NativeMethodInfoPtr_ReadOid_Private_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pkcs8.Asn1.Decoder>.NativeClassPtr, 100663598);
					Pkcs8.Asn1.Decoder.NativeMethodInfoPtr_ReadSequence_Private_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pkcs8.Asn1.Decoder>.NativeClassPtr, 100663599);
					Pkcs8.Asn1.Decoder.NativeMethodInfoPtr_ReadBytes_Private_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pkcs8.Asn1.Decoder>.NativeClassPtr, 100663600);
					Pkcs8.Asn1.Decoder.NativeMethodInfoPtr_ReadTag_Private_Tag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pkcs8.Asn1.Decoder>.NativeClassPtr, 100663601);
					Pkcs8.Asn1.Decoder.NativeMethodInfoPtr_ReadLength_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pkcs8.Asn1.Decoder>.NativeClassPtr, 100663602);
				}

				// Token: 0x06000802 RID: 2050 RVA: 0x0001F03C File Offset: 0x0001D23C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154969, XrefRangeEnd = 1154971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Decoder(Il2CppStructArray<byte> bytes)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pkcs8.Asn1.Decoder>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pkcs8.Asn1.Decoder.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06000803 RID: 2051 RVA: 0x0001F088 File Offset: 0x0001D288
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 1154974, RefRangeEnd = 1154978, XrefRangeStart = 1154971, XrefRangeEnd = 1154974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Object Decode()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pkcs8.Asn1.Decoder.NativeMethodInfoPtr_Decode_Public_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}

				// Token: 0x06000804 RID: 2052 RVA: 0x0001F0C8 File Offset: 0x0001D2C8
				[CallerCount(0)]
				public unsafe byte NextByte()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pkcs8.Asn1.Decoder.NativeMethodInfoPtr_NextByte_Private_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06000805 RID: 2053 RVA: 0x0001F104 File Offset: 0x0001D304
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 1154983, RefRangeEnd = 1154986, XrefRangeStart = 1154978, XrefRangeEnd = 1154983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Il2CppStructArray<byte> ReadLengthPrefixedBytes()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pkcs8.Asn1.Decoder.NativeMethodInfoPtr_ReadLengthPrefixedBytes_Private_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}

				// Token: 0x06000806 RID: 2054 RVA: 0x0001F144 File Offset: 0x0001D344
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154986, XrefRangeEnd = 1154987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Il2CppStructArray<byte> ReadInteger()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pkcs8.Asn1.Decoder.NativeMethodInfoPtr_ReadInteger_Private_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}

				// Token: 0x06000807 RID: 2055 RVA: 0x0001F184 File Offset: 0x0001D384
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154987, XrefRangeEnd = 1154994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Object ReadOctetString()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pkcs8.Asn1.Decoder.NativeMethodInfoPtr_ReadOctetString_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}

				// Token: 0x06000808 RID: 2056 RVA: 0x0001F1C4 File Offset: 0x0001D3C4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154994, XrefRangeEnd = 1154995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Object ReadNull()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pkcs8.Asn1.Decoder.NativeMethodInfoPtr_ReadNull_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}

				// Token: 0x06000809 RID: 2057 RVA: 0x0001F204 File Offset: 0x0001D404
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1155020, RefRangeEnd = 1155021, XrefRangeStart = 1154995, XrefRangeEnd = 1155020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Il2CppStructArray<int> ReadOid()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pkcs8.Asn1.Decoder.NativeMethodInfoPtr_ReadOid_Private_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
				}

				// Token: 0x0600080A RID: 2058 RVA: 0x0001F244 File Offset: 0x0001D444
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1155046, RefRangeEnd = 1155047, XrefRangeStart = 1155021, XrefRangeEnd = 1155046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Il2CppReferenceArray<Object> ReadSequence()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pkcs8.Asn1.Decoder.NativeMethodInfoPtr_ReadSequence_Private_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
				}

				// Token: 0x0600080B RID: 2059 RVA: 0x0001F284 File Offset: 0x0001D484
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155047, XrefRangeEnd = 1155051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Il2CppStructArray<byte> ReadBytes(int length)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref length;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pkcs8.Asn1.Decoder.NativeMethodInfoPtr_ReadBytes_Private_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
					}
				}

				// Token: 0x0600080C RID: 2060 RVA: 0x0001F2D0 File Offset: 0x0001D4D0
				[CallerCount(0)]
				public unsafe Pkcs8.Asn1.Tag ReadTag()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pkcs8.Asn1.Decoder.NativeMethodInfoPtr_ReadTag_Private_Tag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600080D RID: 2061 RVA: 0x0001F30C File Offset: 0x0001D50C
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 1155051, RefRangeEnd = 1155055, XrefRangeStart = 1155051, XrefRangeEnd = 1155051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int ReadLength()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pkcs8.Asn1.Decoder.NativeMethodInfoPtr_ReadLength_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600080E RID: 2062 RVA: 0x00007117 File Offset: 0x00005317
				public Decoder(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170002EC RID: 748
				// (get) Token: 0x0600080F RID: 2063 RVA: 0x0001F348 File Offset: 0x0001D548
				// (set) Token: 0x06000810 RID: 2064 RVA: 0x00007120 File Offset: 0x00005320
				public unsafe Il2CppStructArray<byte> _bytes
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pkcs8.Asn1.Decoder.NativeFieldInfoPtr__bytes);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pkcs8.Asn1.Decoder.NativeFieldInfoPtr__bytes), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170002ED RID: 749
				// (get) Token: 0x06000811 RID: 2065 RVA: 0x0001F378 File Offset: 0x0001D578
				// (set) Token: 0x06000812 RID: 2066 RVA: 0x0000713F File Offset: 0x0000533F
				public unsafe int _index
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pkcs8.Asn1.Decoder.NativeFieldInfoPtr__index);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pkcs8.Asn1.Decoder.NativeFieldInfoPtr__index)) = value;
					}
				}

				// Token: 0x040004B1 RID: 1201
				private static readonly IntPtr NativeFieldInfoPtr__bytes;

				// Token: 0x040004B2 RID: 1202
				private static readonly IntPtr NativeFieldInfoPtr__index;

				// Token: 0x040004B3 RID: 1203
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

				// Token: 0x040004B4 RID: 1204
				private static readonly IntPtr NativeMethodInfoPtr_Decode_Public_Object_0;

				// Token: 0x040004B5 RID: 1205
				private static readonly IntPtr NativeMethodInfoPtr_NextByte_Private_Byte_0;

				// Token: 0x040004B6 RID: 1206
				private static readonly IntPtr NativeMethodInfoPtr_ReadLengthPrefixedBytes_Private_Il2CppStructArray_1_Byte_0;

				// Token: 0x040004B7 RID: 1207
				private static readonly IntPtr NativeMethodInfoPtr_ReadInteger_Private_Il2CppStructArray_1_Byte_0;

				// Token: 0x040004B8 RID: 1208
				private static readonly IntPtr NativeMethodInfoPtr_ReadOctetString_Private_Object_0;

				// Token: 0x040004B9 RID: 1209
				private static readonly IntPtr NativeMethodInfoPtr_ReadNull_Private_Object_0;

				// Token: 0x040004BA RID: 1210
				private static readonly IntPtr NativeMethodInfoPtr_ReadOid_Private_Il2CppStructArray_1_Int32_0;

				// Token: 0x040004BB RID: 1211
				private static readonly IntPtr NativeMethodInfoPtr_ReadSequence_Private_Il2CppReferenceArray_1_Object_0;

				// Token: 0x040004BC RID: 1212
				private static readonly IntPtr NativeMethodInfoPtr_ReadBytes_Private_Il2CppStructArray_1_Byte_Int32_0;

				// Token: 0x040004BD RID: 1213
				private static readonly IntPtr NativeMethodInfoPtr_ReadTag_Private_Tag_0;

				// Token: 0x040004BE RID: 1214
				private static readonly IntPtr NativeMethodInfoPtr_ReadLength_Private_Int32_0;
			}
		}
	}
}

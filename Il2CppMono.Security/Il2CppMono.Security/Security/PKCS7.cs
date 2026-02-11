using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.X509;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2CppMono.Security
{
	// Token: 0x02000006 RID: 6
	public sealed class PKCS7 : Object
	{
		// Token: 0x06000032 RID: 50 RVA: 0x000020DB File Offset: 0x000002DB
		// Note: this type is marked as 'beforefieldinit'.
		static PKCS7()
		{
			Il2CppClassPointerStore<PKCS7>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security", "PKCS7");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS7>.NativeClassPtr);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002100 File Offset: 0x00000300
		public PKCS7(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x02000045 RID: 69
		public class ContentInfo : Object
		{
			// Token: 0x0600042E RID: 1070 RVA: 0x000137E0 File Offset: 0x000119E0
			// Note: this type is marked as 'beforefieldinit'.
			static ContentInfo()
			{
				Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PKCS7>.NativeClassPtr, "ContentInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr);
				PKCS7.ContentInfo.NativeFieldInfoPtr_contentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, "contentType");
				PKCS7.ContentInfo.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, "content");
				PKCS7.ContentInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663331);
				PKCS7.ContentInfo.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663332);
				PKCS7.ContentInfo.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663333);
				PKCS7.ContentInfo.NativeMethodInfoPtr__ctor_Public_Void_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663334);
				PKCS7.ContentInfo.NativeMethodInfoPtr_get_ASN1_Public_get_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663335);
				PKCS7.ContentInfo.NativeMethodInfoPtr_get_Content_Public_get_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663336);
				PKCS7.ContentInfo.NativeMethodInfoPtr_set_Content_Public_set_Void_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663337);
				PKCS7.ContentInfo.NativeMethodInfoPtr_get_ContentType_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663338);
				PKCS7.ContentInfo.NativeMethodInfoPtr_set_ContentType_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663339);
				PKCS7.ContentInfo.NativeMethodInfoPtr_GetASN1_Internal_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663340);
			}

			// Token: 0x0600042F RID: 1071 RVA: 0x000138FC File Offset: 0x00011AFC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1144674, RefRangeEnd = 1144681, XrefRangeStart = 1144667, XrefRangeEnd = 1144674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ContentInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.ContentInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000430 RID: 1072 RVA: 0x00013938 File Offset: 0x00011B38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144681, XrefRangeEnd = 1144683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ContentInfo(string oid)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(oid);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.ContentInfo.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000431 RID: 1073 RVA: 0x00013984 File Offset: 0x00011B84
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1144688, RefRangeEnd = 1144694, XrefRangeStart = 1144683, XrefRangeEnd = 1144688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ContentInfo(Il2CppStructArray<byte> data)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.ContentInfo.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000432 RID: 1074 RVA: 0x000139D0 File Offset: 0x00011BD0
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1144702, RefRangeEnd = 1144706, XrefRangeStart = 1144694, XrefRangeEnd = 1144702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ContentInfo(ASN1 asn1)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(asn1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.ContentInfo.NativeMethodInfoPtr__ctor_Public_Void_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000164 RID: 356
			// (get) Token: 0x06000433 RID: 1075 RVA: 0x00013A1C File Offset: 0x00011C1C
			public unsafe ASN1 ASN1
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144706, XrefRangeEnd = 1144707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.ContentInfo.NativeMethodInfoPtr_get_ASN1_Public_get_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr3) : null;
				}
			}

			// Token: 0x17000165 RID: 357
			// (get) Token: 0x06000434 RID: 1076 RVA: 0x00013A5C File Offset: 0x00011C5C
			// (set) Token: 0x06000435 RID: 1077 RVA: 0x00013A9C File Offset: 0x00011C9C
			public unsafe ASN1 Content
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.ContentInfo.NativeMethodInfoPtr_get_Content_Public_get_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.ContentInfo.NativeMethodInfoPtr_set_Content_Public_set_Void_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000166 RID: 358
			// (get) Token: 0x06000436 RID: 1078 RVA: 0x00013AE0 File Offset: 0x00011CE0
			// (set) Token: 0x06000437 RID: 1079 RVA: 0x00013B18 File Offset: 0x00011D18
			public unsafe string ContentType
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.ContentInfo.NativeMethodInfoPtr_get_ContentType_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.ContentInfo.NativeMethodInfoPtr_set_ContentType_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000438 RID: 1080 RVA: 0x00013B5C File Offset: 0x00011D5C
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1144726, RefRangeEnd = 1144732, XrefRangeStart = 1144707, XrefRangeEnd = 1144726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ASN1 GetASN1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.ContentInfo.NativeMethodInfoPtr_GetASN1_Internal_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr3) : null;
			}

			// Token: 0x06000439 RID: 1081 RVA: 0x00003C08 File Offset: 0x00001E08
			public ContentInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000162 RID: 354
			// (get) Token: 0x0600043A RID: 1082 RVA: 0x00013B9C File Offset: 0x00011D9C
			// (set) Token: 0x0600043B RID: 1083 RVA: 0x00003C11 File Offset: 0x00001E11
			public unsafe string contentType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.ContentInfo.NativeFieldInfoPtr_contentType);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.ContentInfo.NativeFieldInfoPtr_contentType), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000163 RID: 355
			// (get) Token: 0x0600043C RID: 1084 RVA: 0x00013BC4 File Offset: 0x00011DC4
			// (set) Token: 0x0600043D RID: 1085 RVA: 0x00003C30 File Offset: 0x00001E30
			public unsafe ASN1 content
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.ContentInfo.NativeFieldInfoPtr_content);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.ContentInfo.NativeFieldInfoPtr_content), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400041E RID: 1054
			private static readonly IntPtr NativeFieldInfoPtr_contentType;

			// Token: 0x0400041F RID: 1055
			private static readonly IntPtr NativeFieldInfoPtr_content;

			// Token: 0x04000420 RID: 1056
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000421 RID: 1057
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

			// Token: 0x04000422 RID: 1058
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x04000423 RID: 1059
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ASN1_0;

			// Token: 0x04000424 RID: 1060
			private static readonly IntPtr NativeMethodInfoPtr_get_ASN1_Public_get_ASN1_0;

			// Token: 0x04000425 RID: 1061
			private static readonly IntPtr NativeMethodInfoPtr_get_Content_Public_get_ASN1_0;

			// Token: 0x04000426 RID: 1062
			private static readonly IntPtr NativeMethodInfoPtr_set_Content_Public_set_Void_ASN1_0;

			// Token: 0x04000427 RID: 1063
			private static readonly IntPtr NativeMethodInfoPtr_get_ContentType_Public_get_String_0;

			// Token: 0x04000428 RID: 1064
			private static readonly IntPtr NativeMethodInfoPtr_set_ContentType_Public_set_Void_String_0;

			// Token: 0x04000429 RID: 1065
			private static readonly IntPtr NativeMethodInfoPtr_GetASN1_Internal_ASN1_0;
		}

		// Token: 0x02000046 RID: 70
		public class EncryptedData : Object
		{
			// Token: 0x0600043E RID: 1086 RVA: 0x00013BF4 File Offset: 0x00011DF4
			// Note: this type is marked as 'beforefieldinit'.
			static EncryptedData()
			{
				Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PKCS7>.NativeClassPtr, "EncryptedData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr);
				PKCS7.EncryptedData.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr, "_version");
				PKCS7.EncryptedData.NativeFieldInfoPtr__content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr, "_content");
				PKCS7.EncryptedData.NativeFieldInfoPtr__encryptionAlgorithm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr, "_encryptionAlgorithm");
				PKCS7.EncryptedData.NativeFieldInfoPtr__encrypted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr, "_encrypted");
				PKCS7.EncryptedData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr, 100663341);
				PKCS7.EncryptedData.NativeMethodInfoPtr__ctor_Public_Void_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr, 100663342);
				PKCS7.EncryptedData.NativeMethodInfoPtr_get_EncryptionAlgorithm_Public_get_ContentInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr, 100663343);
				PKCS7.EncryptedData.NativeMethodInfoPtr_get_EncryptedContent_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr, 100663344);
			}

			// Token: 0x0600043F RID: 1087 RVA: 0x00013CC0 File Offset: 0x00011EC0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 880491, RefRangeEnd = 880498, XrefRangeStart = 880491, XrefRangeEnd = 880498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EncryptedData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.EncryptedData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000440 RID: 1088 RVA: 0x00013CFC File Offset: 0x00011EFC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1144796, RefRangeEnd = 1144797, XrefRangeStart = 1144732, XrefRangeEnd = 1144796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EncryptedData(ASN1 asn1)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(asn1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.EncryptedData.NativeMethodInfoPtr__ctor_Public_Void_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x1700016B RID: 363
			// (get) Token: 0x06000441 RID: 1089 RVA: 0x00013D48 File Offset: 0x00011F48
			public unsafe PKCS7.ContentInfo EncryptionAlgorithm
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.EncryptedData.NativeMethodInfoPtr_get_EncryptionAlgorithm_Public_get_ContentInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PKCS7.ContentInfo>(intPtr3) : null;
				}
			}

			// Token: 0x1700016C RID: 364
			// (get) Token: 0x06000442 RID: 1090 RVA: 0x00013D88 File Offset: 0x00011F88
			public unsafe Il2CppStructArray<byte> EncryptedContent
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144797, XrefRangeEnd = 1144800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.EncryptedData.NativeMethodInfoPtr_get_EncryptedContent_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x06000443 RID: 1091 RVA: 0x00003C4F File Offset: 0x00001E4F
			public EncryptedData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000167 RID: 359
			// (get) Token: 0x06000444 RID: 1092 RVA: 0x00013DC8 File Offset: 0x00011FC8
			// (set) Token: 0x06000445 RID: 1093 RVA: 0x00003C58 File Offset: 0x00001E58
			public unsafe byte _version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.EncryptedData.NativeFieldInfoPtr__version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.EncryptedData.NativeFieldInfoPtr__version)) = value;
				}
			}

			// Token: 0x17000168 RID: 360
			// (get) Token: 0x06000446 RID: 1094 RVA: 0x00013DF0 File Offset: 0x00011FF0
			// (set) Token: 0x06000447 RID: 1095 RVA: 0x00003C73 File Offset: 0x00001E73
			public unsafe PKCS7.ContentInfo _content
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.EncryptedData.NativeFieldInfoPtr__content);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PKCS7.ContentInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.EncryptedData.NativeFieldInfoPtr__content), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000169 RID: 361
			// (get) Token: 0x06000448 RID: 1096 RVA: 0x00013E20 File Offset: 0x00012020
			// (set) Token: 0x06000449 RID: 1097 RVA: 0x00003C92 File Offset: 0x00001E92
			public unsafe PKCS7.ContentInfo _encryptionAlgorithm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.EncryptedData.NativeFieldInfoPtr__encryptionAlgorithm);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PKCS7.ContentInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.EncryptedData.NativeFieldInfoPtr__encryptionAlgorithm), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700016A RID: 362
			// (get) Token: 0x0600044A RID: 1098 RVA: 0x00013E50 File Offset: 0x00012050
			// (set) Token: 0x0600044B RID: 1099 RVA: 0x00003CB1 File Offset: 0x00001EB1
			public unsafe Il2CppStructArray<byte> _encrypted
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.EncryptedData.NativeFieldInfoPtr__encrypted);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.EncryptedData.NativeFieldInfoPtr__encrypted), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400042A RID: 1066
			private static readonly IntPtr NativeFieldInfoPtr__version;

			// Token: 0x0400042B RID: 1067
			private static readonly IntPtr NativeFieldInfoPtr__content;

			// Token: 0x0400042C RID: 1068
			private static readonly IntPtr NativeFieldInfoPtr__encryptionAlgorithm;

			// Token: 0x0400042D RID: 1069
			private static readonly IntPtr NativeFieldInfoPtr__encrypted;

			// Token: 0x0400042E RID: 1070
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400042F RID: 1071
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ASN1_0;

			// Token: 0x04000430 RID: 1072
			private static readonly IntPtr NativeMethodInfoPtr_get_EncryptionAlgorithm_Public_get_ContentInfo_0;

			// Token: 0x04000431 RID: 1073
			private static readonly IntPtr NativeMethodInfoPtr_get_EncryptedContent_Public_get_Il2CppStructArray_1_Byte_0;
		}

		// Token: 0x02000047 RID: 71
		public class SignedData : Object
		{
			// Token: 0x0600044C RID: 1100 RVA: 0x00013E80 File Offset: 0x00012080
			// Note: this type is marked as 'beforefieldinit'.
			static SignedData()
			{
				Il2CppClassPointerStore<PKCS7.SignedData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PKCS7>.NativeClassPtr, "SignedData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS7.SignedData>.NativeClassPtr);
				PKCS7.SignedData.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.SignedData>.NativeClassPtr, "version");
				PKCS7.SignedData.NativeFieldInfoPtr_hashAlgorithm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.SignedData>.NativeClassPtr, "hashAlgorithm");
				PKCS7.SignedData.NativeFieldInfoPtr_contentInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.SignedData>.NativeClassPtr, "contentInfo");
				PKCS7.SignedData.NativeFieldInfoPtr_certs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.SignedData>.NativeClassPtr, "certs");
				PKCS7.SignedData.NativeFieldInfoPtr_crls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.SignedData>.NativeClassPtr, "crls");
				PKCS7.SignedData.NativeFieldInfoPtr_signerInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.SignedData>.NativeClassPtr, "signerInfo");
				PKCS7.SignedData.NativeFieldInfoPtr_mda = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.SignedData>.NativeClassPtr, "mda");
				PKCS7.SignedData.NativeMethodInfoPtr__ctor_Public_Void_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.SignedData>.NativeClassPtr, 100663345);
				PKCS7.SignedData.NativeMethodInfoPtr_get_Certificates_Public_get_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.SignedData>.NativeClassPtr, 100663346);
				PKCS7.SignedData.NativeMethodInfoPtr_get_ContentInfo_Public_get_ContentInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.SignedData>.NativeClassPtr, 100663347);
				PKCS7.SignedData.NativeMethodInfoPtr_set_HashName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.SignedData>.NativeClassPtr, 100663348);
				PKCS7.SignedData.NativeMethodInfoPtr_get_SignerInfo_Public_get_SignerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.SignedData>.NativeClassPtr, 100663349);
				PKCS7.SignedData.NativeMethodInfoPtr_OidToName_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.SignedData>.NativeClassPtr, 100663350);
			}

			// Token: 0x0600044D RID: 1101 RVA: 0x00013FB0 File Offset: 0x000121B0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1144906, RefRangeEnd = 1144907, XrefRangeStart = 1144800, XrefRangeEnd = 1144906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SignedData(ASN1 asn1)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS7.SignedData>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(asn1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.SignedData.NativeMethodInfoPtr__ctor_Public_Void_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000174 RID: 372
			// (get) Token: 0x0600044E RID: 1102 RVA: 0x00013FFC File Offset: 0x000121FC
			public unsafe X509CertificateCollection Certificates
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.SignedData.NativeMethodInfoPtr_get_Certificates_Public_get_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr3) : null;
				}
			}

			// Token: 0x17000175 RID: 373
			// (get) Token: 0x0600044F RID: 1103 RVA: 0x0001403C File Offset: 0x0001223C
			public unsafe PKCS7.ContentInfo ContentInfo
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.SignedData.NativeMethodInfoPtr_get_ContentInfo_Public_get_ContentInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PKCS7.ContentInfo>(intPtr3) : null;
				}
			}

			// Token: 0x17000176 RID: 374
			// (set) Token: 0x06000450 RID: 1104 RVA: 0x0001407C File Offset: 0x0001227C
			public unsafe string HashName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144907, XrefRangeEnd = 1144910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.SignedData.NativeMethodInfoPtr_set_HashName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000177 RID: 375
			// (get) Token: 0x06000451 RID: 1105 RVA: 0x000140C0 File Offset: 0x000122C0
			public unsafe PKCS7.SignerInfo SignerInfo
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.SignedData.NativeMethodInfoPtr_get_SignerInfo_Public_get_SignerInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PKCS7.SignerInfo>(intPtr3) : null;
				}
			}

			// Token: 0x06000452 RID: 1106 RVA: 0x00014100 File Offset: 0x00012300
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144910, XrefRangeEnd = 1144925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string OidToName(string oid)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(oid);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.SignedData.NativeMethodInfoPtr_OidToName_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000453 RID: 1107 RVA: 0x00003CD0 File Offset: 0x00001ED0
			public SignedData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700016D RID: 365
			// (get) Token: 0x06000454 RID: 1108 RVA: 0x00014148 File Offset: 0x00012348
			// (set) Token: 0x06000455 RID: 1109 RVA: 0x00003CD9 File Offset: 0x00001ED9
			public unsafe byte version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.SignedData.NativeFieldInfoPtr_version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.SignedData.NativeFieldInfoPtr_version)) = value;
				}
			}

			// Token: 0x1700016E RID: 366
			// (get) Token: 0x06000456 RID: 1110 RVA: 0x00014170 File Offset: 0x00012370
			// (set) Token: 0x06000457 RID: 1111 RVA: 0x00003CF4 File Offset: 0x00001EF4
			public unsafe string hashAlgorithm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.SignedData.NativeFieldInfoPtr_hashAlgorithm);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.SignedData.NativeFieldInfoPtr_hashAlgorithm), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700016F RID: 367
			// (get) Token: 0x06000458 RID: 1112 RVA: 0x00014198 File Offset: 0x00012398
			// (set) Token: 0x06000459 RID: 1113 RVA: 0x00003D13 File Offset: 0x00001F13
			public unsafe PKCS7.ContentInfo contentInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.SignedData.NativeFieldInfoPtr_contentInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PKCS7.ContentInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.SignedData.NativeFieldInfoPtr_contentInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000170 RID: 368
			// (get) Token: 0x0600045A RID: 1114 RVA: 0x000141C8 File Offset: 0x000123C8
			// (set) Token: 0x0600045B RID: 1115 RVA: 0x00003D32 File Offset: 0x00001F32
			public unsafe X509CertificateCollection certs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.SignedData.NativeFieldInfoPtr_certs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.SignedData.NativeFieldInfoPtr_certs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000171 RID: 369
			// (get) Token: 0x0600045C RID: 1116 RVA: 0x000141F8 File Offset: 0x000123F8
			// (set) Token: 0x0600045D RID: 1117 RVA: 0x00003D51 File Offset: 0x00001F51
			public unsafe ArrayList crls
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.SignedData.NativeFieldInfoPtr_crls);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.SignedData.NativeFieldInfoPtr_crls), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000172 RID: 370
			// (get) Token: 0x0600045E RID: 1118 RVA: 0x00014228 File Offset: 0x00012428
			// (set) Token: 0x0600045F RID: 1119 RVA: 0x00003D70 File Offset: 0x00001F70
			public unsafe PKCS7.SignerInfo signerInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.SignedData.NativeFieldInfoPtr_signerInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PKCS7.SignerInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.SignedData.NativeFieldInfoPtr_signerInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000173 RID: 371
			// (get) Token: 0x06000460 RID: 1120 RVA: 0x00014258 File Offset: 0x00012458
			// (set) Token: 0x06000461 RID: 1121 RVA: 0x00003D8F File Offset: 0x00001F8F
			public unsafe bool mda
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.SignedData.NativeFieldInfoPtr_mda);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.SignedData.NativeFieldInfoPtr_mda)) = value;
				}
			}

			// Token: 0x04000432 RID: 1074
			private static readonly IntPtr NativeFieldInfoPtr_version;

			// Token: 0x04000433 RID: 1075
			private static readonly IntPtr NativeFieldInfoPtr_hashAlgorithm;

			// Token: 0x04000434 RID: 1076
			private static readonly IntPtr NativeFieldInfoPtr_contentInfo;

			// Token: 0x04000435 RID: 1077
			private static readonly IntPtr NativeFieldInfoPtr_certs;

			// Token: 0x04000436 RID: 1078
			private static readonly IntPtr NativeFieldInfoPtr_crls;

			// Token: 0x04000437 RID: 1079
			private static readonly IntPtr NativeFieldInfoPtr_signerInfo;

			// Token: 0x04000438 RID: 1080
			private static readonly IntPtr NativeFieldInfoPtr_mda;

			// Token: 0x04000439 RID: 1081
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ASN1_0;

			// Token: 0x0400043A RID: 1082
			private static readonly IntPtr NativeMethodInfoPtr_get_Certificates_Public_get_X509CertificateCollection_0;

			// Token: 0x0400043B RID: 1083
			private static readonly IntPtr NativeMethodInfoPtr_get_ContentInfo_Public_get_ContentInfo_0;

			// Token: 0x0400043C RID: 1084
			private static readonly IntPtr NativeMethodInfoPtr_set_HashName_Public_set_Void_String_0;

			// Token: 0x0400043D RID: 1085
			private static readonly IntPtr NativeMethodInfoPtr_get_SignerInfo_Public_get_SignerInfo_0;

			// Token: 0x0400043E RID: 1086
			private static readonly IntPtr NativeMethodInfoPtr_OidToName_Internal_String_String_0;
		}

		// Token: 0x02000048 RID: 72
		public class SignerInfo : Object
		{
			// Token: 0x06000462 RID: 1122 RVA: 0x00014280 File Offset: 0x00012480
			// Note: this type is marked as 'beforefieldinit'.
			static SignerInfo()
			{
				Il2CppClassPointerStore<PKCS7.SignerInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PKCS7>.NativeClassPtr, "SignerInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS7.SignerInfo>.NativeClassPtr);
				PKCS7.SignerInfo.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.SignerInfo>.NativeClassPtr, "version");
				PKCS7.SignerInfo.NativeFieldInfoPtr_hashAlgorithm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.SignerInfo>.NativeClassPtr, "hashAlgorithm");
				PKCS7.SignerInfo.NativeFieldInfoPtr_authenticatedAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.SignerInfo>.NativeClassPtr, "authenticatedAttributes");
				PKCS7.SignerInfo.NativeFieldInfoPtr_unauthenticatedAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.SignerInfo>.NativeClassPtr, "unauthenticatedAttributes");
				PKCS7.SignerInfo.NativeFieldInfoPtr_signature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.SignerInfo>.NativeClassPtr, "signature");
				PKCS7.SignerInfo.NativeFieldInfoPtr_issuer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.SignerInfo>.NativeClassPtr, "issuer");
				PKCS7.SignerInfo.NativeFieldInfoPtr_serial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.SignerInfo>.NativeClassPtr, "serial");
				PKCS7.SignerInfo.NativeFieldInfoPtr_ski = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.SignerInfo>.NativeClassPtr, "ski");
				PKCS7.SignerInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.SignerInfo>.NativeClassPtr, 100663351);
				PKCS7.SignerInfo.NativeMethodInfoPtr__ctor_Public_Void_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.SignerInfo>.NativeClassPtr, 100663352);
				PKCS7.SignerInfo.NativeMethodInfoPtr_get_IssuerName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.SignerInfo>.NativeClassPtr, 100663353);
				PKCS7.SignerInfo.NativeMethodInfoPtr_get_SerialNumber_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.SignerInfo>.NativeClassPtr, 100663354);
				PKCS7.SignerInfo.NativeMethodInfoPtr_get_AuthenticatedAttributes_Public_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.SignerInfo>.NativeClassPtr, 100663355);
				PKCS7.SignerInfo.NativeMethodInfoPtr_get_HashName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.SignerInfo>.NativeClassPtr, 100663356);
				PKCS7.SignerInfo.NativeMethodInfoPtr_set_HashName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.SignerInfo>.NativeClassPtr, 100663357);
				PKCS7.SignerInfo.NativeMethodInfoPtr_get_Signature_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.SignerInfo>.NativeClassPtr, 100663358);
				PKCS7.SignerInfo.NativeMethodInfoPtr_get_UnauthenticatedAttributes_Public_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.SignerInfo>.NativeClassPtr, 100663359);
				PKCS7.SignerInfo.NativeMethodInfoPtr_get_Version_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.SignerInfo>.NativeClassPtr, 100663360);
			}

			// Token: 0x06000463 RID: 1123 RVA: 0x00014414 File Offset: 0x00012614
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1144935, RefRangeEnd = 1144936, XrefRangeStart = 1144925, XrefRangeEnd = 1144935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SignerInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS7.SignerInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.SignerInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000464 RID: 1124 RVA: 0x00014450 File Offset: 0x00012650
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1144976, RefRangeEnd = 1144978, XrefRangeStart = 1144936, XrefRangeEnd = 1144976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SignerInfo(ASN1 asn1)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS7.SignerInfo>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(asn1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.SignerInfo.NativeMethodInfoPtr__ctor_Public_Void_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000180 RID: 384
			// (get) Token: 0x06000465 RID: 1125 RVA: 0x0001449C File Offset: 0x0001269C
			public unsafe string IssuerName
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.SignerInfo.NativeMethodInfoPtr_get_IssuerName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17000181 RID: 385
			// (get) Token: 0x06000466 RID: 1126 RVA: 0x000144D4 File Offset: 0x000126D4
			public unsafe Il2CppStructArray<byte> SerialNumber
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 1144981, RefRangeEnd = 1144983, XrefRangeStart = 1144978, XrefRangeEnd = 1144981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.SignerInfo.NativeMethodInfoPtr_get_SerialNumber_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x17000182 RID: 386
			// (get) Token: 0x06000467 RID: 1127 RVA: 0x00014514 File Offset: 0x00012714
			public unsafe ArrayList AuthenticatedAttributes
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.SignerInfo.NativeMethodInfoPtr_get_AuthenticatedAttributes_Public_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
				}
			}

			// Token: 0x17000183 RID: 387
			// (get) Token: 0x06000468 RID: 1128 RVA: 0x00014554 File Offset: 0x00012754
			// (set) Token: 0x06000469 RID: 1129 RVA: 0x0001458C File Offset: 0x0001278C
			public unsafe string HashName
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.SignerInfo.NativeMethodInfoPtr_get_HashName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.SignerInfo.NativeMethodInfoPtr_set_HashName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000184 RID: 388
			// (get) Token: 0x0600046A RID: 1130 RVA: 0x000145D0 File Offset: 0x000127D0
			public unsafe Il2CppStructArray<byte> Signature
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 1144986, RefRangeEnd = 1144988, XrefRangeStart = 1144983, XrefRangeEnd = 1144986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.SignerInfo.NativeMethodInfoPtr_get_Signature_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x17000185 RID: 389
			// (get) Token: 0x0600046B RID: 1131 RVA: 0x00014610 File Offset: 0x00012810
			public unsafe ArrayList UnauthenticatedAttributes
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.SignerInfo.NativeMethodInfoPtr_get_UnauthenticatedAttributes_Public_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
				}
			}

			// Token: 0x17000186 RID: 390
			// (get) Token: 0x0600046C RID: 1132 RVA: 0x00014650 File Offset: 0x00012850
			public unsafe byte Version
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.SignerInfo.NativeMethodInfoPtr_get_Version_Public_get_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600046D RID: 1133 RVA: 0x00003DAA File Offset: 0x00001FAA
			public SignerInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000178 RID: 376
			// (get) Token: 0x0600046E RID: 1134 RVA: 0x0001468C File Offset: 0x0001288C
			// (set) Token: 0x0600046F RID: 1135 RVA: 0x00003DB3 File Offset: 0x00001FB3
			public unsafe byte version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.SignerInfo.NativeFieldInfoPtr_version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.SignerInfo.NativeFieldInfoPtr_version)) = value;
				}
			}

			// Token: 0x17000179 RID: 377
			// (get) Token: 0x06000470 RID: 1136 RVA: 0x000146B4 File Offset: 0x000128B4
			// (set) Token: 0x06000471 RID: 1137 RVA: 0x00003DCE File Offset: 0x00001FCE
			public unsafe string hashAlgorithm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.SignerInfo.NativeFieldInfoPtr_hashAlgorithm);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.SignerInfo.NativeFieldInfoPtr_hashAlgorithm), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700017A RID: 378
			// (get) Token: 0x06000472 RID: 1138 RVA: 0x000146DC File Offset: 0x000128DC
			// (set) Token: 0x06000473 RID: 1139 RVA: 0x00003DED File Offset: 0x00001FED
			public unsafe ArrayList authenticatedAttributes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.SignerInfo.NativeFieldInfoPtr_authenticatedAttributes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.SignerInfo.NativeFieldInfoPtr_authenticatedAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700017B RID: 379
			// (get) Token: 0x06000474 RID: 1140 RVA: 0x0001470C File Offset: 0x0001290C
			// (set) Token: 0x06000475 RID: 1141 RVA: 0x00003E0C File Offset: 0x0000200C
			public unsafe ArrayList unauthenticatedAttributes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.SignerInfo.NativeFieldInfoPtr_unauthenticatedAttributes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.SignerInfo.NativeFieldInfoPtr_unauthenticatedAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700017C RID: 380
			// (get) Token: 0x06000476 RID: 1142 RVA: 0x0001473C File Offset: 0x0001293C
			// (set) Token: 0x06000477 RID: 1143 RVA: 0x00003E2B File Offset: 0x0000202B
			public unsafe Il2CppStructArray<byte> signature
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.SignerInfo.NativeFieldInfoPtr_signature);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.SignerInfo.NativeFieldInfoPtr_signature), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700017D RID: 381
			// (get) Token: 0x06000478 RID: 1144 RVA: 0x0001476C File Offset: 0x0001296C
			// (set) Token: 0x06000479 RID: 1145 RVA: 0x00003E4A File Offset: 0x0000204A
			public unsafe string issuer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.SignerInfo.NativeFieldInfoPtr_issuer);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.SignerInfo.NativeFieldInfoPtr_issuer), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700017E RID: 382
			// (get) Token: 0x0600047A RID: 1146 RVA: 0x00014794 File Offset: 0x00012994
			// (set) Token: 0x0600047B RID: 1147 RVA: 0x00003E69 File Offset: 0x00002069
			public unsafe Il2CppStructArray<byte> serial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.SignerInfo.NativeFieldInfoPtr_serial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.SignerInfo.NativeFieldInfoPtr_serial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700017F RID: 383
			// (get) Token: 0x0600047C RID: 1148 RVA: 0x000147C4 File Offset: 0x000129C4
			// (set) Token: 0x0600047D RID: 1149 RVA: 0x00003E88 File Offset: 0x00002088
			public unsafe Il2CppStructArray<byte> ski
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.SignerInfo.NativeFieldInfoPtr_ski);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.SignerInfo.NativeFieldInfoPtr_ski), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400043F RID: 1087
			private static readonly IntPtr NativeFieldInfoPtr_version;

			// Token: 0x04000440 RID: 1088
			private static readonly IntPtr NativeFieldInfoPtr_hashAlgorithm;

			// Token: 0x04000441 RID: 1089
			private static readonly IntPtr NativeFieldInfoPtr_authenticatedAttributes;

			// Token: 0x04000442 RID: 1090
			private static readonly IntPtr NativeFieldInfoPtr_unauthenticatedAttributes;

			// Token: 0x04000443 RID: 1091
			private static readonly IntPtr NativeFieldInfoPtr_signature;

			// Token: 0x04000444 RID: 1092
			private static readonly IntPtr NativeFieldInfoPtr_issuer;

			// Token: 0x04000445 RID: 1093
			private static readonly IntPtr NativeFieldInfoPtr_serial;

			// Token: 0x04000446 RID: 1094
			private static readonly IntPtr NativeFieldInfoPtr_ski;

			// Token: 0x04000447 RID: 1095
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000448 RID: 1096
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ASN1_0;

			// Token: 0x04000449 RID: 1097
			private static readonly IntPtr NativeMethodInfoPtr_get_IssuerName_Public_get_String_0;

			// Token: 0x0400044A RID: 1098
			private static readonly IntPtr NativeMethodInfoPtr_get_SerialNumber_Public_get_Il2CppStructArray_1_Byte_0;

			// Token: 0x0400044B RID: 1099
			private static readonly IntPtr NativeMethodInfoPtr_get_AuthenticatedAttributes_Public_get_ArrayList_0;

			// Token: 0x0400044C RID: 1100
			private static readonly IntPtr NativeMethodInfoPtr_get_HashName_Public_get_String_0;

			// Token: 0x0400044D RID: 1101
			private static readonly IntPtr NativeMethodInfoPtr_set_HashName_Public_set_Void_String_0;

			// Token: 0x0400044E RID: 1102
			private static readonly IntPtr NativeMethodInfoPtr_get_Signature_Public_get_Il2CppStructArray_1_Byte_0;

			// Token: 0x0400044F RID: 1103
			private static readonly IntPtr NativeMethodInfoPtr_get_UnauthenticatedAttributes_Public_get_ArrayList_0;

			// Token: 0x04000450 RID: 1104
			private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_Byte_0;
		}
	}
}

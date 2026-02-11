using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000C9 RID: 201
	[Serializable]
	public class X509Certificate2 : X509Certificate
	{
		// Token: 0x06000D32 RID: 3378 RVA: 0x0004D528 File Offset: 0x0004B728
		// Note: this type is marked as 'beforefieldinit'.
		static X509Certificate2()
		{
			Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509Certificate2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr);
			X509Certificate2.NativeFieldInfoPtr_lazyRawData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, "lazyRawData");
			X509Certificate2.NativeFieldInfoPtr_lazySignatureAlgorithm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, "lazySignatureAlgorithm");
			X509Certificate2.NativeFieldInfoPtr_lazyVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, "lazyVersion");
			X509Certificate2.NativeFieldInfoPtr_lazySubjectName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, "lazySubjectName");
			X509Certificate2.NativeFieldInfoPtr_lazyIssuerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, "lazyIssuerName");
			X509Certificate2.NativeFieldInfoPtr_lazyPublicKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, "lazyPublicKey");
			X509Certificate2.NativeFieldInfoPtr_lazyPrivateKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, "lazyPrivateKey");
			X509Certificate2.NativeFieldInfoPtr_lazyExtensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, "lazyExtensions");
			X509Certificate2.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100665189);
			X509Certificate2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100665190);
			X509Certificate2.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100665191);
			X509Certificate2.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100665192);
			X509Certificate2.NativeMethodInfoPtr__ctor_Internal_Void_X509Certificate2Impl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100665193);
			X509Certificate2.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100665194);
			X509Certificate2.NativeMethodInfoPtr__ctor_Public_Void_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100665195);
			X509Certificate2.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100665196);
			X509Certificate2.NativeMethodInfoPtr_get_Extensions_Public_get_X509ExtensionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100665197);
			X509Certificate2.NativeMethodInfoPtr_get_HasPrivateKey_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100665198);
			X509Certificate2.NativeMethodInfoPtr_get_PrivateKey_Public_get_AsymmetricAlgorithm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100665199);
			X509Certificate2.NativeMethodInfoPtr_get_IssuerName_Public_get_X500DistinguishedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100665200);
			X509Certificate2.NativeMethodInfoPtr_get_NotAfter_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100665201);
			X509Certificate2.NativeMethodInfoPtr_get_NotBefore_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100665202);
			X509Certificate2.NativeMethodInfoPtr_get_PublicKey_Public_get_PublicKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100665203);
			X509Certificate2.NativeMethodInfoPtr_get_RawData_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100665204);
			X509Certificate2.NativeMethodInfoPtr_get_SerialNumber_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100665205);
			X509Certificate2.NativeMethodInfoPtr_get_SignatureAlgorithm_Public_get_Oid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100665206);
			X509Certificate2.NativeMethodInfoPtr_get_SubjectName_Public_get_X500DistinguishedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100665207);
			X509Certificate2.NativeMethodInfoPtr_get_Thumbprint_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100665208);
			X509Certificate2.NativeMethodInfoPtr_get_Version_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100665209);
			X509Certificate2.NativeMethodInfoPtr_GetCertContentType_Public_Static_X509ContentType_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100665210);
			X509Certificate2.NativeMethodInfoPtr_GetNameInfo_Public_String_X509NameType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100665211);
			X509Certificate2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100665212);
			X509Certificate2.NativeMethodInfoPtr_ToString_Public_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100665213);
			X509Certificate2.NativeMethodInfoPtr_Verify_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100665214);
			X509Certificate2.NativeMethodInfoPtr_CreateCustomExtensionIfAny_Private_Static_X509Extension_Oid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100665215);
			X509Certificate2.NativeMethodInfoPtr_get_Impl_Internal_get_X509Certificate2Impl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100665216);
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x0004D828 File Offset: 0x0004BA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453217, XrefRangeEnd = 453233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x0004D864 File Offset: 0x0004BA64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453233, XrefRangeEnd = 453234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x0004D8A0 File Offset: 0x0004BAA0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 453247, RefRangeEnd = 453250, XrefRangeStart = 453234, XrefRangeEnd = 453247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate2(Il2CppStructArray<byte> rawData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x0004D8EC File Offset: 0x0004BAEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 453251, RefRangeEnd = 453252, XrefRangeStart = 453250, XrefRangeEnd = 453251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate2(Il2CppStructArray<byte> rawData, string password)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x0004D94C File Offset: 0x0004BB4C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 453253, RefRangeEnd = 453257, XrefRangeStart = 453252, XrefRangeEnd = 453253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate2(X509Certificate2Impl impl)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(impl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr__ctor_Internal_Void_X509Certificate2Impl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x0004D998 File Offset: 0x0004BB98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 453258, RefRangeEnd = 453259, XrefRangeStart = 453257, XrefRangeEnd = 453258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate2(string fileName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x0004D9E4 File Offset: 0x0004BBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453259, XrefRangeEnd = 453260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate2(X509Certificate certificate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr__ctor_Public_Void_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x0004DA30 File Offset: 0x0004BC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453260, XrefRangeEnd = 453266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate2(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000D3B RID: 3387 RVA: 0x0004DA94 File Offset: 0x0004BC94
		public unsafe X509ExtensionCollection Extensions
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 453299, RefRangeEnd = 453310, XrefRangeStart = 453266, XrefRangeEnd = 453299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr_get_Extensions_Public_get_X509ExtensionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509ExtensionCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000D3C RID: 3388 RVA: 0x0004DAD4 File Offset: 0x0004BCD4
		public unsafe bool HasPrivateKey
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 453313, RefRangeEnd = 453316, XrefRangeStart = 453310, XrefRangeEnd = 453313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr_get_HasPrivateKey_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000D3D RID: 3389 RVA: 0x0004DB10 File Offset: 0x0004BD10
		public unsafe AsymmetricAlgorithm PrivateKey
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 453328, RefRangeEnd = 453331, XrefRangeStart = 453316, XrefRangeEnd = 453328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr_get_PrivateKey_Public_get_AsymmetricAlgorithm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsymmetricAlgorithm>(intPtr3) : null;
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000D3E RID: 3390 RVA: 0x0004DB50 File Offset: 0x0004BD50
		public unsafe X500DistinguishedName IssuerName
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 453336, RefRangeEnd = 453340, XrefRangeStart = 453331, XrefRangeEnd = 453336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr_get_IssuerName_Public_get_X500DistinguishedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X500DistinguishedName>(intPtr3) : null;
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000D3F RID: 3391 RVA: 0x0004DB90 File Offset: 0x0004BD90
		public unsafe DateTime NotAfter
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453340, XrefRangeEnd = 453341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr_get_NotAfter_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000D40 RID: 3392 RVA: 0x0004DBCC File Offset: 0x0004BDCC
		public unsafe DateTime NotBefore
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453341, XrefRangeEnd = 453342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr_get_NotBefore_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000D41 RID: 3393 RVA: 0x0004DC08 File Offset: 0x0004BE08
		public unsafe PublicKey PublicKey
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 453361, RefRangeEnd = 453368, XrefRangeStart = 453342, XrefRangeEnd = 453361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr_get_PublicKey_Public_get_PublicKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PublicKey>(intPtr3) : null;
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000D42 RID: 3394 RVA: 0x0004DC48 File Offset: 0x0004BE48
		public unsafe Il2CppStructArray<byte> RawData
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 453375, RefRangeEnd = 453376, XrefRangeStart = 453368, XrefRangeEnd = 453375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr_get_RawData_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000D43 RID: 3395 RVA: 0x0004DC88 File Offset: 0x0004BE88
		public unsafe string SerialNumber
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 453376, RefRangeEnd = 453388, XrefRangeStart = 453376, XrefRangeEnd = 453376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr_get_SerialNumber_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000D44 RID: 3396 RVA: 0x0004DCC0 File Offset: 0x0004BEC0
		public unsafe Oid SignatureAlgorithm
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 453403, RefRangeEnd = 453405, XrefRangeStart = 453388, XrefRangeEnd = 453403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr_get_SignatureAlgorithm_Public_get_Oid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Oid>(intPtr3) : null;
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000D45 RID: 3397 RVA: 0x0004DD00 File Offset: 0x0004BF00
		public unsafe X500DistinguishedName SubjectName
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 453410, RefRangeEnd = 453415, XrefRangeStart = 453405, XrefRangeEnd = 453410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr_get_SubjectName_Public_get_X500DistinguishedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X500DistinguishedName>(intPtr3) : null;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000D46 RID: 3398 RVA: 0x0004DD40 File Offset: 0x0004BF40
		public unsafe string Thumbprint
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453415, XrefRangeEnd = 453416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr_get_Thumbprint_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000D47 RID: 3399 RVA: 0x0004DD78 File Offset: 0x0004BF78
		public unsafe int Version
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 453420, RefRangeEnd = 453421, XrefRangeStart = 453416, XrefRangeEnd = 453420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr_get_Version_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x0004DDB4 File Offset: 0x0004BFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453421, XrefRangeEnd = 453431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X509ContentType GetCertContentType(Il2CppStructArray<byte> rawData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr_GetCertContentType_Public_Static_X509ContentType_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x0004DDF8 File Offset: 0x0004BFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453431, XrefRangeEnd = 453433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetNameInfo(X509NameType nameType, bool forIssuer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forIssuer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr_GetNameInfo_Public_String_X509NameType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x0004DE4C File Offset: 0x0004C04C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453433, XrefRangeEnd = 453434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x0004DE90 File Offset: 0x0004C090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453434, XrefRangeEnd = 453648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(bool verbose)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref verbose;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2.NativeMethodInfoPtr_ToString_Public_Virtual_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x0004DEE0 File Offset: 0x0004C0E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 453650, RefRangeEnd = 453651, XrefRangeStart = 453648, XrefRangeEnd = 453650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Verify()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr_Verify_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x0004DF1C File Offset: 0x0004C11C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 453667, RefRangeEnd = 453668, XrefRangeStart = 453651, XrefRangeEnd = 453667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X509Extension CreateCustomExtensionIfAny(Oid oid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr_CreateCustomExtensionIfAny_Private_Static_X509Extension_Oid_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Extension>(intPtr3) : null;
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000D4E RID: 3406 RVA: 0x0004DF60 File Offset: 0x0004C160
		public new unsafe X509Certificate2Impl Impl
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 453673, RefRangeEnd = 453700, XrefRangeStart = 453668, XrefRangeEnd = 453673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr_get_Impl_Internal_get_X509Certificate2Impl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2Impl>(intPtr3) : null;
			}
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x00006E12 File Offset: 0x00005012
		public X509Certificate2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000D50 RID: 3408 RVA: 0x0004DFA0 File Offset: 0x0004C1A0
		// (set) Token: 0x06000D51 RID: 3409 RVA: 0x00006E1B File Offset: 0x0000501B
		public unsafe Il2CppStructArray<byte> lazyRawData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2.NativeFieldInfoPtr_lazyRawData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2.NativeFieldInfoPtr_lazyRawData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000D52 RID: 3410 RVA: 0x0004DFD0 File Offset: 0x0004C1D0
		// (set) Token: 0x06000D53 RID: 3411 RVA: 0x00006E3A File Offset: 0x0000503A
		public unsafe Oid lazySignatureAlgorithm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2.NativeFieldInfoPtr_lazySignatureAlgorithm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Oid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2.NativeFieldInfoPtr_lazySignatureAlgorithm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000D54 RID: 3412 RVA: 0x0004E000 File Offset: 0x0004C200
		// (set) Token: 0x06000D55 RID: 3413 RVA: 0x00006E59 File Offset: 0x00005059
		public unsafe int lazyVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2.NativeFieldInfoPtr_lazyVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2.NativeFieldInfoPtr_lazyVersion)) = value;
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000D56 RID: 3414 RVA: 0x0004E028 File Offset: 0x0004C228
		// (set) Token: 0x06000D57 RID: 3415 RVA: 0x00006E74 File Offset: 0x00005074
		public unsafe X500DistinguishedName lazySubjectName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2.NativeFieldInfoPtr_lazySubjectName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X500DistinguishedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2.NativeFieldInfoPtr_lazySubjectName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000D58 RID: 3416 RVA: 0x0004E058 File Offset: 0x0004C258
		// (set) Token: 0x06000D59 RID: 3417 RVA: 0x00006E93 File Offset: 0x00005093
		public unsafe X500DistinguishedName lazyIssuerName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2.NativeFieldInfoPtr_lazyIssuerName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X500DistinguishedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2.NativeFieldInfoPtr_lazyIssuerName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000D5A RID: 3418 RVA: 0x0004E088 File Offset: 0x0004C288
		// (set) Token: 0x06000D5B RID: 3419 RVA: 0x00006EB2 File Offset: 0x000050B2
		public new unsafe PublicKey lazyPublicKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2.NativeFieldInfoPtr_lazyPublicKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PublicKey>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2.NativeFieldInfoPtr_lazyPublicKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000D5C RID: 3420 RVA: 0x0004E0B8 File Offset: 0x0004C2B8
		// (set) Token: 0x06000D5D RID: 3421 RVA: 0x00006ED1 File Offset: 0x000050D1
		public unsafe AsymmetricAlgorithm lazyPrivateKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2.NativeFieldInfoPtr_lazyPrivateKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsymmetricAlgorithm>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2.NativeFieldInfoPtr_lazyPrivateKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000D5E RID: 3422 RVA: 0x0004E0E8 File Offset: 0x0004C2E8
		// (set) Token: 0x06000D5F RID: 3423 RVA: 0x00006EF0 File Offset: 0x000050F0
		public unsafe X509ExtensionCollection lazyExtensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2.NativeFieldInfoPtr_lazyExtensions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509ExtensionCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2.NativeFieldInfoPtr_lazyExtensions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AE8 RID: 2792
		private static readonly IntPtr NativeFieldInfoPtr_lazyRawData;

		// Token: 0x04000AE9 RID: 2793
		private static readonly IntPtr NativeFieldInfoPtr_lazySignatureAlgorithm;

		// Token: 0x04000AEA RID: 2794
		private static readonly IntPtr NativeFieldInfoPtr_lazyVersion;

		// Token: 0x04000AEB RID: 2795
		private static readonly IntPtr NativeFieldInfoPtr_lazySubjectName;

		// Token: 0x04000AEC RID: 2796
		private static readonly IntPtr NativeFieldInfoPtr_lazyIssuerName;

		// Token: 0x04000AED RID: 2797
		private static readonly IntPtr NativeFieldInfoPtr_lazyPublicKey;

		// Token: 0x04000AEE RID: 2798
		private static readonly IntPtr NativeFieldInfoPtr_lazyPrivateKey;

		// Token: 0x04000AEF RID: 2799
		private static readonly IntPtr NativeFieldInfoPtr_lazyExtensions;

		// Token: 0x04000AF0 RID: 2800
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x04000AF1 RID: 2801
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000AF2 RID: 2802
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000AF3 RID: 2803
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04000AF4 RID: 2804
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_X509Certificate2Impl_0;

		// Token: 0x04000AF5 RID: 2805
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000AF6 RID: 2806
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_X509Certificate_0;

		// Token: 0x04000AF7 RID: 2807
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000AF8 RID: 2808
		private static readonly IntPtr NativeMethodInfoPtr_get_Extensions_Public_get_X509ExtensionCollection_0;

		// Token: 0x04000AF9 RID: 2809
		private static readonly IntPtr NativeMethodInfoPtr_get_HasPrivateKey_Public_get_Boolean_0;

		// Token: 0x04000AFA RID: 2810
		private static readonly IntPtr NativeMethodInfoPtr_get_PrivateKey_Public_get_AsymmetricAlgorithm_0;

		// Token: 0x04000AFB RID: 2811
		private static readonly IntPtr NativeMethodInfoPtr_get_IssuerName_Public_get_X500DistinguishedName_0;

		// Token: 0x04000AFC RID: 2812
		private static readonly IntPtr NativeMethodInfoPtr_get_NotAfter_Public_get_DateTime_0;

		// Token: 0x04000AFD RID: 2813
		private static readonly IntPtr NativeMethodInfoPtr_get_NotBefore_Public_get_DateTime_0;

		// Token: 0x04000AFE RID: 2814
		private static readonly IntPtr NativeMethodInfoPtr_get_PublicKey_Public_get_PublicKey_0;

		// Token: 0x04000AFF RID: 2815
		private static readonly IntPtr NativeMethodInfoPtr_get_RawData_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000B00 RID: 2816
		private static readonly IntPtr NativeMethodInfoPtr_get_SerialNumber_Public_get_String_0;

		// Token: 0x04000B01 RID: 2817
		private static readonly IntPtr NativeMethodInfoPtr_get_SignatureAlgorithm_Public_get_Oid_0;

		// Token: 0x04000B02 RID: 2818
		private static readonly IntPtr NativeMethodInfoPtr_get_SubjectName_Public_get_X500DistinguishedName_0;

		// Token: 0x04000B03 RID: 2819
		private static readonly IntPtr NativeMethodInfoPtr_get_Thumbprint_Public_get_String_0;

		// Token: 0x04000B04 RID: 2820
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_Int32_0;

		// Token: 0x04000B05 RID: 2821
		private static readonly IntPtr NativeMethodInfoPtr_GetCertContentType_Public_Static_X509ContentType_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000B06 RID: 2822
		private static readonly IntPtr NativeMethodInfoPtr_GetNameInfo_Public_String_X509NameType_Boolean_0;

		// Token: 0x04000B07 RID: 2823
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000B08 RID: 2824
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Boolean_0;

		// Token: 0x04000B09 RID: 2825
		private static readonly IntPtr NativeMethodInfoPtr_Verify_Public_Boolean_0;

		// Token: 0x04000B0A RID: 2826
		private static readonly IntPtr NativeMethodInfoPtr_CreateCustomExtensionIfAny_Private_Static_X509Extension_Oid_0;

		// Token: 0x04000B0B RID: 2827
		private static readonly IntPtr NativeMethodInfoPtr_get_Impl_Internal_get_X509Certificate2Impl_0;
	}
}

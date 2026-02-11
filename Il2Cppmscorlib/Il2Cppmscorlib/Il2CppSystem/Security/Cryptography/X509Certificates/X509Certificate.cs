using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x0200027E RID: 638
	[Serializable]
	public class X509Certificate : Object
	{
		// Token: 0x060028F4 RID: 10484 RVA: 0x000DBAC0 File Offset: 0x000D9CC0
		// Note: this type is marked as 'beforefieldinit'.
		static X509Certificate()
		{
			Il2CppClassPointerStore<X509Certificate>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography.X509Certificates", "X509Certificate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr);
			X509Certificate.NativeFieldInfoPtr_impl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "impl");
			X509Certificate.NativeFieldInfoPtr_lazyCertHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "lazyCertHash");
			X509Certificate.NativeFieldInfoPtr_lazySerialNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "lazySerialNumber");
			X509Certificate.NativeFieldInfoPtr_lazyIssuer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "lazyIssuer");
			X509Certificate.NativeFieldInfoPtr_lazySubject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "lazySubject");
			X509Certificate.NativeFieldInfoPtr_lazyKeyAlgorithm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "lazyKeyAlgorithm");
			X509Certificate.NativeFieldInfoPtr_lazyKeyAlgorithmParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "lazyKeyAlgorithmParameters");
			X509Certificate.NativeFieldInfoPtr_lazyPublicKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "lazyPublicKey");
			X509Certificate.NativeFieldInfoPtr_lazyNotBefore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "lazyNotBefore");
			X509Certificate.NativeFieldInfoPtr_lazyNotAfter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "lazyNotAfter");
			X509Certificate.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100669990);
			X509Certificate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100669991);
			X509Certificate.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100669992);
			X509Certificate.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100669993);
			X509Certificate.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_String_X509KeyStorageFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100669994);
			X509Certificate.NativeMethodInfoPtr__ctor_Internal_Void_X509CertificateImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100669995);
			X509Certificate.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100669996);
			X509Certificate.NativeMethodInfoPtr__ctor_Public_Void_String_String_X509KeyStorageFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100669997);
			X509Certificate.NativeMethodInfoPtr__ctor_Public_Void_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100669998);
			X509Certificate.NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100669999);
			X509Certificate.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100670000);
			X509Certificate.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100670001);
			X509Certificate.NativeMethodInfoPtr_get_Issuer_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100670002);
			X509Certificate.NativeMethodInfoPtr_get_Subject_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100670003);
			X509Certificate.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100670004);
			X509Certificate.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100670005);
			X509Certificate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100670006);
			X509Certificate.NativeMethodInfoPtr_Equals_Public_Virtual_New_Boolean_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100670007);
			X509Certificate.NativeMethodInfoPtr_Export_Public_Virtual_New_Il2CppStructArray_1_Byte_X509ContentType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100670008);
			X509Certificate.NativeMethodInfoPtr_GetCertHash_Public_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100670009);
			X509Certificate.NativeMethodInfoPtr_GetCertHashString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100670010);
			X509Certificate.NativeMethodInfoPtr_GetRawCertHash_Private_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100670011);
			X509Certificate.NativeMethodInfoPtr_GetRawCertData_Public_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100670012);
			X509Certificate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100670013);
			X509Certificate.NativeMethodInfoPtr_GetKeyAlgorithm_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100670014);
			X509Certificate.NativeMethodInfoPtr_GetKeyAlgorithmParameters_Public_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100670015);
			X509Certificate.NativeMethodInfoPtr_GetPublicKey_Public_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100670016);
			X509Certificate.NativeMethodInfoPtr_GetSerialNumber_Public_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100670017);
			X509Certificate.NativeMethodInfoPtr_GetSerialNumberString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100670018);
			X509Certificate.NativeMethodInfoPtr_GetRawSerialNumber_Private_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100670019);
			X509Certificate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100670020);
			X509Certificate.NativeMethodInfoPtr_ToString_Public_Virtual_New_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100670021);
			X509Certificate.NativeMethodInfoPtr_GetNotAfter_Internal_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100670022);
			X509Certificate.NativeMethodInfoPtr_GetNotBefore_Internal_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100670023);
			X509Certificate.NativeMethodInfoPtr_FormatDate_Protected_Static_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100670024);
			X509Certificate.NativeMethodInfoPtr_ValidateKeyStorageFlags_Internal_Static_Void_X509KeyStorageFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100670025);
			X509Certificate.NativeMethodInfoPtr_VerifyContentType_Private_Void_X509ContentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100670026);
			X509Certificate.NativeMethodInfoPtr_ImportHandle_Internal_Void_X509CertificateImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100670027);
			X509Certificate.NativeMethodInfoPtr_get_Impl_Internal_get_X509CertificateImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100670028);
			X509Certificate.NativeMethodInfoPtr_get_IsValid_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100670029);
			X509Certificate.NativeMethodInfoPtr_ThrowIfInvalid_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100670030);
		}

		// Token: 0x060028F5 RID: 10485 RVA: 0x000DBEEC File Offset: 0x000DA0EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1375157, RefRangeEnd = 1375158, XrefRangeStart = 1375133, XrefRangeEnd = 1375157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028F6 RID: 10486 RVA: 0x000DBF28 File Offset: 0x000DA128
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1375164, RefRangeEnd = 1375166, XrefRangeStart = 1375158, XrefRangeEnd = 1375164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x000DBF64 File Offset: 0x000DA164
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1375177, RefRangeEnd = 1375178, XrefRangeStart = 1375166, XrefRangeEnd = 1375177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate(Il2CppStructArray<byte> data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028F8 RID: 10488 RVA: 0x000DBFB0 File Offset: 0x000DA1B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1375179, RefRangeEnd = 1375180, XrefRangeStart = 1375178, XrefRangeEnd = 1375179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate(Il2CppStructArray<byte> rawData, string password)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028F9 RID: 10489 RVA: 0x000DC010 File Offset: 0x000DA210
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1375199, RefRangeEnd = 1375200, XrefRangeStart = 1375180, XrefRangeEnd = 1375199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate(Il2CppStructArray<byte> rawData, string password, X509KeyStorageFlags keyStorageFlags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyStorageFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_String_X509KeyStorageFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x000DC07C File Offset: 0x000DA27C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1375208, RefRangeEnd = 1375211, XrefRangeStart = 1375200, XrefRangeEnd = 1375208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate(X509CertificateImpl impl)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(impl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr__ctor_Internal_Void_X509CertificateImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028FB RID: 10491 RVA: 0x000DC0C8 File Offset: 0x000DA2C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1375212, RefRangeEnd = 1375213, XrefRangeStart = 1375211, XrefRangeEnd = 1375212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate(string fileName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028FC RID: 10492 RVA: 0x000DC114 File Offset: 0x000DA314
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1375233, RefRangeEnd = 1375234, XrefRangeStart = 1375213, XrefRangeEnd = 1375233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate(string fileName, string password, X509KeyStorageFlags keyStorageFlags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyStorageFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr__ctor_Public_Void_String_String_X509KeyStorageFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028FD RID: 10493 RVA: 0x000DC180 File Offset: 0x000DA380
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1375253, RefRangeEnd = 1375255, XrefRangeStart = 1375234, XrefRangeEnd = 1375253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate(X509Certificate cert)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cert);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr__ctor_Public_Void_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028FE RID: 10494 RVA: 0x000DC1CC File Offset: 0x000DA3CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1375261, RefRangeEnd = 1375262, XrefRangeStart = 1375255, XrefRangeEnd = 1375261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028FF RID: 10495 RVA: 0x000DC230 File Offset: 0x000DA430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375262, XrefRangeEnd = 1375267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002900 RID: 10496 RVA: 0x000DC28C File Offset: 0x000DA48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375267, XrefRangeEnd = 1375272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06002901 RID: 10497 RVA: 0x000DC2D0 File Offset: 0x000DA4D0
		public unsafe string Issuer
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 1375275, RefRangeEnd = 1375292, XrefRangeStart = 1375272, XrefRangeEnd = 1375275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_get_Issuer_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06002902 RID: 10498 RVA: 0x000DC308 File Offset: 0x000DA508
		public unsafe string Subject
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 1375295, RefRangeEnd = 1375307, XrefRangeStart = 1375292, XrefRangeEnd = 1375295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_get_Subject_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002903 RID: 10499 RVA: 0x000DC340 File Offset: 0x000DA540
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 862874, RefRangeEnd = 862879, XrefRangeStart = 862874, XrefRangeEnd = 862879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002904 RID: 10500 RVA: 0x000DC374 File Offset: 0x000DA574
		[CallerCount(0)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002905 RID: 10501 RVA: 0x000DC3C0 File Offset: 0x000DA5C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375307, XrefRangeEnd = 1375310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002906 RID: 10502 RVA: 0x000DC418 File Offset: 0x000DA618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375310, XrefRangeEnd = 1375316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(X509Certificate other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_Equals_Public_Virtual_New_Boolean_X509Certificate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002907 RID: 10503 RVA: 0x000DC470 File Offset: 0x000DA670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375316, XrefRangeEnd = 1375326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> Export(X509ContentType contentType, string password)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref contentType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_Export_Public_Virtual_New_Il2CppStructArray_1_Byte_X509ContentType_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06002908 RID: 10504 RVA: 0x000DC4DC File Offset: 0x000DA6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375326, XrefRangeEnd = 1375334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> GetCertHash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_GetCertHash_Public_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06002909 RID: 10505 RVA: 0x000DC528 File Offset: 0x000DA728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375334, XrefRangeEnd = 1375342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetCertHashString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_GetCertHashString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600290A RID: 10506 RVA: 0x000DC56C File Offset: 0x000DA76C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1375345, RefRangeEnd = 1375346, XrefRangeStart = 1375342, XrefRangeEnd = 1375345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetRawCertHash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_GetRawCertHash_Private_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600290B RID: 10507 RVA: 0x000DC5AC File Offset: 0x000DA7AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375346, XrefRangeEnd = 1375351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> GetRawCertData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_GetRawCertData_Public_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600290C RID: 10508 RVA: 0x000DC5F8 File Offset: 0x000DA7F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375351, XrefRangeEnd = 1375356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600290D RID: 10509 RVA: 0x000DC640 File Offset: 0x000DA840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375356, XrefRangeEnd = 1375359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetKeyAlgorithm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_GetKeyAlgorithm_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600290E RID: 10510 RVA: 0x000DC684 File Offset: 0x000DA884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375359, XrefRangeEnd = 1375367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> GetKeyAlgorithmParameters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_GetKeyAlgorithmParameters_Public_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x000DC6D0 File Offset: 0x000DA8D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375367, XrefRangeEnd = 1375375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> GetPublicKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_GetPublicKey_Public_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06002910 RID: 10512 RVA: 0x000DC71C File Offset: 0x000DA91C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375375, XrefRangeEnd = 1375382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> GetSerialNumber()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_GetSerialNumber_Public_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06002911 RID: 10513 RVA: 0x000DC768 File Offset: 0x000DA968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375382, XrefRangeEnd = 1375390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSerialNumberString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_GetSerialNumberString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x000DC7AC File Offset: 0x000DA9AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1375393, RefRangeEnd = 1375395, XrefRangeStart = 1375390, XrefRangeEnd = 1375393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetRawSerialNumber()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_GetRawSerialNumber_Private_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x000DC7EC File Offset: 0x000DA9EC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1375395, RefRangeEnd = 1375399, XrefRangeStart = 1375395, XrefRangeEnd = 1375395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x000DC830 File Offset: 0x000DAA30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1375480, RefRangeEnd = 1375481, XrefRangeStart = 1375399, XrefRangeEnd = 1375480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ToString(bool fVerbose)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fVerbose;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_ToString_Public_Virtual_New_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x000DC880 File Offset: 0x000DAA80
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1375486, RefRangeEnd = 1375491, XrefRangeStart = 1375481, XrefRangeEnd = 1375486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime GetNotAfter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_GetNotAfter_Internal_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x000DC8BC File Offset: 0x000DAABC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1375496, RefRangeEnd = 1375501, XrefRangeStart = 1375491, XrefRangeEnd = 1375496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime GetNotBefore()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_GetNotBefore_Internal_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002917 RID: 10519 RVA: 0x000DC8F8 File Offset: 0x000DAAF8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1375517, RefRangeEnd = 1375521, XrefRangeStart = 1375501, XrefRangeEnd = 1375517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatDate(DateTime date)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref date;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_FormatDate_Protected_Static_String_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x000DC930 File Offset: 0x000DAB30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1375521, RefRangeEnd = 1375523, XrefRangeStart = 1375521, XrefRangeEnd = 1375521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateKeyStorageFlags(X509KeyStorageFlags keyStorageFlags)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyStorageFlags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_ValidateKeyStorageFlags_Internal_Static_Void_X509KeyStorageFlags_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002919 RID: 10521 RVA: 0x000DC964 File Offset: 0x000DAB64
		[CallerCount(0)]
		public unsafe void VerifyContentType(X509ContentType contentType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref contentType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_VerifyContentType_Private_Void_X509ContentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600291A RID: 10522 RVA: 0x000DC9A4 File Offset: 0x000DABA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1375524, RefRangeEnd = 1375525, XrefRangeStart = 1375523, XrefRangeEnd = 1375524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImportHandle(X509CertificateImpl impl)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(impl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_ImportHandle_Internal_Void_X509CertificateImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x0600291B RID: 10523 RVA: 0x000DC9E8 File Offset: 0x000DABE8
		public unsafe X509CertificateImpl Impl
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_get_Impl_Internal_get_X509CertificateImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr3) : null;
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x0600291C RID: 10524 RVA: 0x000DCA28 File Offset: 0x000DAC28
		public unsafe bool IsValid
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1375525, RefRangeEnd = 1375526, XrefRangeStart = 1375525, XrefRangeEnd = 1375525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_get_IsValid_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x000DCA64 File Offset: 0x000DAC64
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1375526, RefRangeEnd = 1375539, XrefRangeStart = 1375526, XrefRangeEnd = 1375526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfInvalid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_ThrowIfInvalid_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x0000D8EF File Offset: 0x0000BAEF
		public X509Certificate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x0600291F RID: 10527 RVA: 0x000DCA98 File Offset: 0x000DAC98
		// (set) Token: 0x06002920 RID: 10528 RVA: 0x0000D8F8 File Offset: 0x0000BAF8
		public unsafe X509CertificateImpl impl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_impl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_impl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06002921 RID: 10529 RVA: 0x000DCAC8 File Offset: 0x000DACC8
		// (set) Token: 0x06002922 RID: 10530 RVA: 0x0000D917 File Offset: 0x0000BB17
		public unsafe Il2CppStructArray<byte> lazyCertHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_lazyCertHash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_lazyCertHash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06002923 RID: 10531 RVA: 0x000DCAF8 File Offset: 0x000DACF8
		// (set) Token: 0x06002924 RID: 10532 RVA: 0x0000D936 File Offset: 0x0000BB36
		public unsafe Il2CppStructArray<byte> lazySerialNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_lazySerialNumber);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_lazySerialNumber), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06002925 RID: 10533 RVA: 0x000DCB28 File Offset: 0x000DAD28
		// (set) Token: 0x06002926 RID: 10534 RVA: 0x0000D955 File Offset: 0x0000BB55
		public unsafe string lazyIssuer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_lazyIssuer);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_lazyIssuer), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06002927 RID: 10535 RVA: 0x000DCB50 File Offset: 0x000DAD50
		// (set) Token: 0x06002928 RID: 10536 RVA: 0x0000D974 File Offset: 0x0000BB74
		public unsafe string lazySubject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_lazySubject);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_lazySubject), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06002929 RID: 10537 RVA: 0x000DCB78 File Offset: 0x000DAD78
		// (set) Token: 0x0600292A RID: 10538 RVA: 0x0000D993 File Offset: 0x0000BB93
		public unsafe string lazyKeyAlgorithm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_lazyKeyAlgorithm);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_lazyKeyAlgorithm), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x0600292B RID: 10539 RVA: 0x000DCBA0 File Offset: 0x000DADA0
		// (set) Token: 0x0600292C RID: 10540 RVA: 0x0000D9B2 File Offset: 0x0000BBB2
		public unsafe Il2CppStructArray<byte> lazyKeyAlgorithmParameters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_lazyKeyAlgorithmParameters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_lazyKeyAlgorithmParameters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x0600292D RID: 10541 RVA: 0x000DCBD0 File Offset: 0x000DADD0
		// (set) Token: 0x0600292E RID: 10542 RVA: 0x0000D9D1 File Offset: 0x0000BBD1
		public unsafe Il2CppStructArray<byte> lazyPublicKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_lazyPublicKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_lazyPublicKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x0600292F RID: 10543 RVA: 0x000DCC00 File Offset: 0x000DAE00
		// (set) Token: 0x06002930 RID: 10544 RVA: 0x0000D9F0 File Offset: 0x0000BBF0
		public unsafe DateTime lazyNotBefore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_lazyNotBefore);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_lazyNotBefore)) = value;
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06002931 RID: 10545 RVA: 0x000DCC28 File Offset: 0x000DAE28
		// (set) Token: 0x06002932 RID: 10546 RVA: 0x0000DA0B File Offset: 0x0000BC0B
		public unsafe DateTime lazyNotAfter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_lazyNotAfter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_lazyNotAfter)) = value;
			}
		}

		// Token: 0x040022FD RID: 8957
		private static readonly IntPtr NativeFieldInfoPtr_impl;

		// Token: 0x040022FE RID: 8958
		private static readonly IntPtr NativeFieldInfoPtr_lazyCertHash;

		// Token: 0x040022FF RID: 8959
		private static readonly IntPtr NativeFieldInfoPtr_lazySerialNumber;

		// Token: 0x04002300 RID: 8960
		private static readonly IntPtr NativeFieldInfoPtr_lazyIssuer;

		// Token: 0x04002301 RID: 8961
		private static readonly IntPtr NativeFieldInfoPtr_lazySubject;

		// Token: 0x04002302 RID: 8962
		private static readonly IntPtr NativeFieldInfoPtr_lazyKeyAlgorithm;

		// Token: 0x04002303 RID: 8963
		private static readonly IntPtr NativeFieldInfoPtr_lazyKeyAlgorithmParameters;

		// Token: 0x04002304 RID: 8964
		private static readonly IntPtr NativeFieldInfoPtr_lazyPublicKey;

		// Token: 0x04002305 RID: 8965
		private static readonly IntPtr NativeFieldInfoPtr_lazyNotBefore;

		// Token: 0x04002306 RID: 8966
		private static readonly IntPtr NativeFieldInfoPtr_lazyNotAfter;

		// Token: 0x04002307 RID: 8967
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0;

		// Token: 0x04002308 RID: 8968
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002309 RID: 8969
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400230A RID: 8970
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x0400230B RID: 8971
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_String_X509KeyStorageFlags_0;

		// Token: 0x0400230C RID: 8972
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_X509CertificateImpl_0;

		// Token: 0x0400230D RID: 8973
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400230E RID: 8974
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_X509KeyStorageFlags_0;

		// Token: 0x0400230F RID: 8975
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_X509Certificate_0;

		// Token: 0x04002310 RID: 8976
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04002311 RID: 8977
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04002312 RID: 8978
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x04002313 RID: 8979
		private static readonly IntPtr NativeMethodInfoPtr_get_Issuer_Public_get_String_0;

		// Token: 0x04002314 RID: 8980
		private static readonly IntPtr NativeMethodInfoPtr_get_Subject_Public_get_String_0;

		// Token: 0x04002315 RID: 8981
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002316 RID: 8982
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04002317 RID: 8983
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002318 RID: 8984
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_New_Boolean_X509Certificate_0;

		// Token: 0x04002319 RID: 8985
		private static readonly IntPtr NativeMethodInfoPtr_Export_Public_Virtual_New_Il2CppStructArray_1_Byte_X509ContentType_String_0;

		// Token: 0x0400231A RID: 8986
		private static readonly IntPtr NativeMethodInfoPtr_GetCertHash_Public_Virtual_New_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400231B RID: 8987
		private static readonly IntPtr NativeMethodInfoPtr_GetCertHashString_Public_Virtual_New_String_0;

		// Token: 0x0400231C RID: 8988
		private static readonly IntPtr NativeMethodInfoPtr_GetRawCertHash_Private_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400231D RID: 8989
		private static readonly IntPtr NativeMethodInfoPtr_GetRawCertData_Public_Virtual_New_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400231E RID: 8990
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400231F RID: 8991
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyAlgorithm_Public_Virtual_New_String_0;

		// Token: 0x04002320 RID: 8992
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyAlgorithmParameters_Public_Virtual_New_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002321 RID: 8993
		private static readonly IntPtr NativeMethodInfoPtr_GetPublicKey_Public_Virtual_New_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002322 RID: 8994
		private static readonly IntPtr NativeMethodInfoPtr_GetSerialNumber_Public_Virtual_New_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002323 RID: 8995
		private static readonly IntPtr NativeMethodInfoPtr_GetSerialNumberString_Public_Virtual_New_String_0;

		// Token: 0x04002324 RID: 8996
		private static readonly IntPtr NativeMethodInfoPtr_GetRawSerialNumber_Private_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002325 RID: 8997
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002326 RID: 8998
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_New_String_Boolean_0;

		// Token: 0x04002327 RID: 8999
		private static readonly IntPtr NativeMethodInfoPtr_GetNotAfter_Internal_DateTime_0;

		// Token: 0x04002328 RID: 9000
		private static readonly IntPtr NativeMethodInfoPtr_GetNotBefore_Internal_DateTime_0;

		// Token: 0x04002329 RID: 9001
		private static readonly IntPtr NativeMethodInfoPtr_FormatDate_Protected_Static_String_DateTime_0;

		// Token: 0x0400232A RID: 9002
		private static readonly IntPtr NativeMethodInfoPtr_ValidateKeyStorageFlags_Internal_Static_Void_X509KeyStorageFlags_0;

		// Token: 0x0400232B RID: 9003
		private static readonly IntPtr NativeMethodInfoPtr_VerifyContentType_Private_Void_X509ContentType_0;

		// Token: 0x0400232C RID: 9004
		private static readonly IntPtr NativeMethodInfoPtr_ImportHandle_Internal_Void_X509CertificateImpl_0;

		// Token: 0x0400232D RID: 9005
		private static readonly IntPtr NativeMethodInfoPtr_get_Impl_Internal_get_X509CertificateImpl_0;

		// Token: 0x0400232E RID: 9006
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Internal_get_Boolean_0;

		// Token: 0x0400232F RID: 9007
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfInvalid_Internal_Void_0;
	}
}

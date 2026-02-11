using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x0200027F RID: 639
	public class X509CertificateImpl : Object
	{
		// Token: 0x06002933 RID: 10547 RVA: 0x000DCC50 File Offset: 0x000DAE50
		// Note: this type is marked as 'beforefieldinit'.
		static X509CertificateImpl()
		{
			Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography.X509Certificates", "X509CertificateImpl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr);
			X509CertificateImpl.NativeMethodInfoPtr_get_IsValid_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100670031);
			X509CertificateImpl.NativeMethodInfoPtr_ThrowIfContextInvalid_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100670032);
			X509CertificateImpl.NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_X509CertificateImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100670033);
			X509CertificateImpl.NativeMethodInfoPtr_get_Issuer_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100670034);
			X509CertificateImpl.NativeMethodInfoPtr_get_Subject_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100670035);
			X509CertificateImpl.NativeMethodInfoPtr_get_RawData_Public_Abstract_Virtual_New_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100670036);
			X509CertificateImpl.NativeMethodInfoPtr_get_NotAfter_Public_Abstract_Virtual_New_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100670037);
			X509CertificateImpl.NativeMethodInfoPtr_get_NotBefore_Public_Abstract_Virtual_New_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100670038);
			X509CertificateImpl.NativeMethodInfoPtr_get_Thumbprint_Public_Abstract_Virtual_New_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100670039);
			X509CertificateImpl.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100670040);
			X509CertificateImpl.NativeMethodInfoPtr_get_KeyAlgorithm_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100670041);
			X509CertificateImpl.NativeMethodInfoPtr_get_KeyAlgorithmParameters_Public_Abstract_Virtual_New_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100670042);
			X509CertificateImpl.NativeMethodInfoPtr_get_PublicKeyValue_Public_Abstract_Virtual_New_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100670043);
			X509CertificateImpl.NativeMethodInfoPtr_get_SerialNumber_Public_Abstract_Virtual_New_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100670044);
			X509CertificateImpl.NativeMethodInfoPtr_get_HasPrivateKey_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100670045);
			X509CertificateImpl.NativeMethodInfoPtr_GetRSAPrivateKey_Public_Abstract_Virtual_New_RSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100670046);
			X509CertificateImpl.NativeMethodInfoPtr_GetDSAPrivateKey_Public_Abstract_Virtual_New_DSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100670047);
			X509CertificateImpl.NativeMethodInfoPtr_Export_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_X509ContentType_SafePasswordHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100670048);
			X509CertificateImpl.NativeMethodInfoPtr_CopyWithPrivateKey_Public_Abstract_Virtual_New_X509CertificateImpl_RSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100670049);
			X509CertificateImpl.NativeMethodInfoPtr_Equals_Public_Virtual_Final_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100670050);
			X509CertificateImpl.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100670051);
			X509CertificateImpl.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100670052);
			X509CertificateImpl.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100670053);
			X509CertificateImpl.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100670054);
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06002934 RID: 10548 RVA: 0x000DCE60 File Offset: 0x000DB060
		public unsafe virtual bool IsValid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImpl.NativeMethodInfoPtr_get_IsValid_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002935 RID: 10549 RVA: 0x000DCEA8 File Offset: 0x000DB0A8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1375539, RefRangeEnd = 1375550, XrefRangeStart = 1375539, XrefRangeEnd = 1375539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfContextInvalid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImpl.NativeMethodInfoPtr_ThrowIfContextInvalid_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002936 RID: 10550 RVA: 0x000DCEDC File Offset: 0x000DB0DC
		[CallerCount(0)]
		public unsafe virtual X509CertificateImpl Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImpl.NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_X509CertificateImpl_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr3) : null;
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06002937 RID: 10551 RVA: 0x000DCF28 File Offset: 0x000DB128
		public unsafe virtual string Issuer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImpl.NativeMethodInfoPtr_get_Issuer_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06002938 RID: 10552 RVA: 0x000DCF6C File Offset: 0x000DB16C
		public unsafe virtual string Subject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImpl.NativeMethodInfoPtr_get_Subject_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06002939 RID: 10553 RVA: 0x000DCFB0 File Offset: 0x000DB1B0
		public unsafe virtual Il2CppStructArray<byte> RawData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImpl.NativeMethodInfoPtr_get_RawData_Public_Abstract_Virtual_New_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x0600293A RID: 10554 RVA: 0x000DCFFC File Offset: 0x000DB1FC
		public unsafe virtual DateTime NotAfter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImpl.NativeMethodInfoPtr_get_NotAfter_Public_Abstract_Virtual_New_get_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x0600293B RID: 10555 RVA: 0x000DD044 File Offset: 0x000DB244
		public unsafe virtual DateTime NotBefore
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImpl.NativeMethodInfoPtr_get_NotBefore_Public_Abstract_Virtual_New_get_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x0600293C RID: 10556 RVA: 0x000DD08C File Offset: 0x000DB28C
		public unsafe virtual Il2CppStructArray<byte> Thumbprint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImpl.NativeMethodInfoPtr_get_Thumbprint_Public_Abstract_Virtual_New_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600293D RID: 10557 RVA: 0x000DD0D8 File Offset: 0x000DB2D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375550, XrefRangeEnd = 1375551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImpl.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x0600293E RID: 10558 RVA: 0x000DD114 File Offset: 0x000DB314
		public unsafe virtual string KeyAlgorithm
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImpl.NativeMethodInfoPtr_get_KeyAlgorithm_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x0600293F RID: 10559 RVA: 0x000DD158 File Offset: 0x000DB358
		public unsafe virtual Il2CppStructArray<byte> KeyAlgorithmParameters
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImpl.NativeMethodInfoPtr_get_KeyAlgorithmParameters_Public_Abstract_Virtual_New_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06002940 RID: 10560 RVA: 0x000DD1A4 File Offset: 0x000DB3A4
		public unsafe virtual Il2CppStructArray<byte> PublicKeyValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImpl.NativeMethodInfoPtr_get_PublicKeyValue_Public_Abstract_Virtual_New_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06002941 RID: 10561 RVA: 0x000DD1F0 File Offset: 0x000DB3F0
		public unsafe virtual Il2CppStructArray<byte> SerialNumber
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImpl.NativeMethodInfoPtr_get_SerialNumber_Public_Abstract_Virtual_New_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06002942 RID: 10562 RVA: 0x000DD23C File Offset: 0x000DB43C
		public unsafe virtual bool HasPrivateKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImpl.NativeMethodInfoPtr_get_HasPrivateKey_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002943 RID: 10563 RVA: 0x000DD284 File Offset: 0x000DB484
		[CallerCount(0)]
		public unsafe virtual RSA GetRSAPrivateKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImpl.NativeMethodInfoPtr_GetRSAPrivateKey_Public_Abstract_Virtual_New_RSA_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RSA>(intPtr3) : null;
		}

		// Token: 0x06002944 RID: 10564 RVA: 0x000DD2D0 File Offset: 0x000DB4D0
		[CallerCount(0)]
		public unsafe virtual DSA GetDSAPrivateKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImpl.NativeMethodInfoPtr_GetDSAPrivateKey_Public_Abstract_Virtual_New_DSA_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DSA>(intPtr3) : null;
		}

		// Token: 0x06002945 RID: 10565 RVA: 0x000DD31C File Offset: 0x000DB51C
		[CallerCount(0)]
		public unsafe virtual Il2CppStructArray<byte> Export(X509ContentType contentType, SafePasswordHandle password)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref contentType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(password);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImpl.NativeMethodInfoPtr_Export_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_X509ContentType_SafePasswordHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06002946 RID: 10566 RVA: 0x000DD388 File Offset: 0x000DB588
		[CallerCount(0)]
		public unsafe virtual X509CertificateImpl CopyWithPrivateKey(RSA privateKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(privateKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImpl.NativeMethodInfoPtr_CopyWithPrivateKey_Public_Abstract_Virtual_New_X509CertificateImpl_RSA_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr3) : null;
			}
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x000DD3E4 File Offset: 0x000DB5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375551, XrefRangeEnd = 1375557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImpl.NativeMethodInfoPtr_Equals_Public_Virtual_Final_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002948 RID: 10568 RVA: 0x000DD434 File Offset: 0x000DB634
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1375561, RefRangeEnd = 1375562, XrefRangeStart = 1375557, XrefRangeEnd = 1375561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImpl.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x000DD468 File Offset: 0x000DB668
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImpl.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x000DD4B4 File Offset: 0x000DB6B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImpl.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x000DD4F0 File Offset: 0x000DB6F0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509CertificateImpl()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImpl.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600294C RID: 10572 RVA: 0x0000DA26 File Offset: 0x0000BC26
		public X509CertificateImpl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002330 RID: 9008
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04002331 RID: 9009
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfContextInvalid_Protected_Void_0;

		// Token: 0x04002332 RID: 9010
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_X509CertificateImpl_0;

		// Token: 0x04002333 RID: 9011
		private static readonly IntPtr NativeMethodInfoPtr_get_Issuer_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04002334 RID: 9012
		private static readonly IntPtr NativeMethodInfoPtr_get_Subject_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04002335 RID: 9013
		private static readonly IntPtr NativeMethodInfoPtr_get_RawData_Public_Abstract_Virtual_New_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002336 RID: 9014
		private static readonly IntPtr NativeMethodInfoPtr_get_NotAfter_Public_Abstract_Virtual_New_get_DateTime_0;

		// Token: 0x04002337 RID: 9015
		private static readonly IntPtr NativeMethodInfoPtr_get_NotBefore_Public_Abstract_Virtual_New_get_DateTime_0;

		// Token: 0x04002338 RID: 9016
		private static readonly IntPtr NativeMethodInfoPtr_get_Thumbprint_Public_Abstract_Virtual_New_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002339 RID: 9017
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_Int32_0;

		// Token: 0x0400233A RID: 9018
		private static readonly IntPtr NativeMethodInfoPtr_get_KeyAlgorithm_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400233B RID: 9019
		private static readonly IntPtr NativeMethodInfoPtr_get_KeyAlgorithmParameters_Public_Abstract_Virtual_New_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400233C RID: 9020
		private static readonly IntPtr NativeMethodInfoPtr_get_PublicKeyValue_Public_Abstract_Virtual_New_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400233D RID: 9021
		private static readonly IntPtr NativeMethodInfoPtr_get_SerialNumber_Public_Abstract_Virtual_New_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400233E RID: 9022
		private static readonly IntPtr NativeMethodInfoPtr_get_HasPrivateKey_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400233F RID: 9023
		private static readonly IntPtr NativeMethodInfoPtr_GetRSAPrivateKey_Public_Abstract_Virtual_New_RSA_0;

		// Token: 0x04002340 RID: 9024
		private static readonly IntPtr NativeMethodInfoPtr_GetDSAPrivateKey_Public_Abstract_Virtual_New_DSA_0;

		// Token: 0x04002341 RID: 9025
		private static readonly IntPtr NativeMethodInfoPtr_Export_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_X509ContentType_SafePasswordHandle_0;

		// Token: 0x04002342 RID: 9026
		private static readonly IntPtr NativeMethodInfoPtr_CopyWithPrivateKey_Public_Abstract_Virtual_New_X509CertificateImpl_RSA_0;

		// Token: 0x04002343 RID: 9027
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_Boolean_Object_0;

		// Token: 0x04002344 RID: 9028
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002345 RID: 9029
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04002346 RID: 9030
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04002347 RID: 9031
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

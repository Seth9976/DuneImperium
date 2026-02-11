using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Btls
{
	// Token: 0x0200004B RID: 75
	public class MonoBtlsX509VerifyParam : MonoBtlsObject
	{
		// Token: 0x0600044C RID: 1100 RVA: 0x0002C70C File Offset: 0x0002A90C
		// Note: this type is marked as 'beforefieldinit'.
		static MonoBtlsX509VerifyParam()
		{
			Il2CppClassPointerStore<MonoBtlsX509VerifyParam>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsX509VerifyParam");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsX509VerifyParam>.NativeClassPtr);
			MonoBtlsX509VerifyParam.NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509VerifyParamHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509VerifyParam>.NativeClassPtr, 100664075);
			MonoBtlsX509VerifyParam.NativeMethodInfoPtr_mono_btls_x509_verify_param_copy_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509VerifyParam>.NativeClassPtr, 100664076);
			MonoBtlsX509VerifyParam.NativeMethodInfoPtr_mono_btls_x509_verify_param_lookup_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509VerifyParam>.NativeClassPtr, 100664077);
			MonoBtlsX509VerifyParam.NativeMethodInfoPtr_mono_btls_x509_verify_param_can_modify_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509VerifyParam>.NativeClassPtr, 100664078);
			MonoBtlsX509VerifyParam.NativeMethodInfoPtr_mono_btls_x509_verify_param_set_host_Private_Static_Int32_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509VerifyParam>.NativeClassPtr, 100664079);
			MonoBtlsX509VerifyParam.NativeMethodInfoPtr_mono_btls_x509_verify_param_set_time_Private_Static_Int32_IntPtr_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509VerifyParam>.NativeClassPtr, 100664080);
			MonoBtlsX509VerifyParam.NativeMethodInfoPtr_mono_btls_x509_verify_param_free_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509VerifyParam>.NativeClassPtr, 100664081);
			MonoBtlsX509VerifyParam.NativeMethodInfoPtr__ctor_Internal_Void_BoringX509VerifyParamHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509VerifyParam>.NativeClassPtr, 100664082);
			MonoBtlsX509VerifyParam.NativeMethodInfoPtr_Copy_Public_MonoBtlsX509VerifyParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509VerifyParam>.NativeClassPtr, 100664083);
			MonoBtlsX509VerifyParam.NativeMethodInfoPtr_GetSslClient_Public_Static_MonoBtlsX509VerifyParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509VerifyParam>.NativeClassPtr, 100664084);
			MonoBtlsX509VerifyParam.NativeMethodInfoPtr_GetSslServer_Public_Static_MonoBtlsX509VerifyParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509VerifyParam>.NativeClassPtr, 100664085);
			MonoBtlsX509VerifyParam.NativeMethodInfoPtr_Lookup_Public_Static_MonoBtlsX509VerifyParam_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509VerifyParam>.NativeClassPtr, 100664086);
			MonoBtlsX509VerifyParam.NativeMethodInfoPtr_get_CanModify_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509VerifyParam>.NativeClassPtr, 100664087);
			MonoBtlsX509VerifyParam.NativeMethodInfoPtr_WantToModify_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509VerifyParam>.NativeClassPtr, 100664088);
			MonoBtlsX509VerifyParam.NativeMethodInfoPtr_SetHost_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509VerifyParam>.NativeClassPtr, 100664089);
			MonoBtlsX509VerifyParam.NativeMethodInfoPtr_SetTime_Public_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509VerifyParam>.NativeClassPtr, 100664090);
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x0002C87C File Offset: 0x0002AA7C
		public new unsafe MonoBtlsX509VerifyParam.BoringX509VerifyParamHandle Handle
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 432526, RefRangeEnd = 432533, XrefRangeStart = 432523, XrefRangeEnd = 432526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509VerifyParam.NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509VerifyParamHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509VerifyParam.BoringX509VerifyParamHandle>(intPtr3) : null;
			}
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0002C8BC File Offset: 0x0002AABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432533, XrefRangeEnd = 432535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr mono_btls_x509_verify_param_copy(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509VerifyParam.NativeMethodInfoPtr_mono_btls_x509_verify_param_copy_Private_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0002C8FC File Offset: 0x0002AAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432535, XrefRangeEnd = 432537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr mono_btls_x509_verify_param_lookup(IntPtr name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509VerifyParam.NativeMethodInfoPtr_mono_btls_x509_verify_param_lookup_Private_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0002C93C File Offset: 0x0002AB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432537, XrefRangeEnd = 432539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_x509_verify_param_can_modify(IntPtr param)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref param;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509VerifyParam.NativeMethodInfoPtr_mono_btls_x509_verify_param_can_modify_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0002C97C File Offset: 0x0002AB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432539, XrefRangeEnd = 432541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_x509_verify_param_set_host(IntPtr handle, IntPtr name, int namelen)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref name;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref namelen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509VerifyParam.NativeMethodInfoPtr_mono_btls_x509_verify_param_set_host_Private_Static_Int32_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0002C9D8 File Offset: 0x0002ABD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432541, XrefRangeEnd = 432543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_x509_verify_param_set_time(IntPtr handle, long time)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509VerifyParam.NativeMethodInfoPtr_mono_btls_x509_verify_param_set_time_Private_Static_Int32_IntPtr_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0002CA24 File Offset: 0x0002AC24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432543, XrefRangeEnd = 432545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void mono_btls_x509_verify_param_free(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509VerifyParam.NativeMethodInfoPtr_mono_btls_x509_verify_param_free_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0002CA58 File Offset: 0x0002AC58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 373450, RefRangeEnd = 373451, XrefRangeStart = 373450, XrefRangeEnd = 373451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsX509VerifyParam(MonoBtlsX509VerifyParam.BoringX509VerifyParamHandle handle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsX509VerifyParam>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509VerifyParam.NativeMethodInfoPtr__ctor_Internal_Void_BoringX509VerifyParamHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0002CAA4 File Offset: 0x0002ACA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432545, XrefRangeEnd = 432560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsX509VerifyParam Copy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509VerifyParam.NativeMethodInfoPtr_Copy_Public_MonoBtlsX509VerifyParam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509VerifyParam>(intPtr3) : null;
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x0002CAE4 File Offset: 0x0002ACE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 432563, RefRangeEnd = 432564, XrefRangeStart = 432560, XrefRangeEnd = 432563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoBtlsX509VerifyParam GetSslClient()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509VerifyParam.NativeMethodInfoPtr_GetSslClient_Public_Static_MonoBtlsX509VerifyParam_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509VerifyParam>(intPtr3) : null;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0002CB18 File Offset: 0x0002AD18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 432567, RefRangeEnd = 432568, XrefRangeStart = 432564, XrefRangeEnd = 432567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoBtlsX509VerifyParam GetSslServer()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509VerifyParam.NativeMethodInfoPtr_GetSslServer_Public_Static_MonoBtlsX509VerifyParam_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509VerifyParam>(intPtr3) : null;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0002CB4C File Offset: 0x0002AD4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 432594, RefRangeEnd = 432596, XrefRangeStart = 432568, XrefRangeEnd = 432594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoBtlsX509VerifyParam Lookup(string name, bool fail = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fail;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509VerifyParam.NativeMethodInfoPtr_Lookup_Public_Static_MonoBtlsX509VerifyParam_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509VerifyParam>(intPtr3) : null;
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x0002CBA0 File Offset: 0x0002ADA0
		public unsafe bool CanModify
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432596, XrefRangeEnd = 432599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509VerifyParam.NativeMethodInfoPtr_get_CanModify_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0002CBDC File Offset: 0x0002ADDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 432602, RefRangeEnd = 432604, XrefRangeStart = 432599, XrefRangeEnd = 432602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WantToModify()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509VerifyParam.NativeMethodInfoPtr_WantToModify_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0002CC10 File Offset: 0x0002AE10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432604, XrefRangeEnd = 432621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHost(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509VerifyParam.NativeMethodInfoPtr_SetHost_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0002CC54 File Offset: 0x0002AE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432621, XrefRangeEnd = 432637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTime(DateTime time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509VerifyParam.NativeMethodInfoPtr_SetTime_Public_Void_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x000035B4 File Offset: 0x000017B4
		public MonoBtlsX509VerifyParam(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509VerifyParamHandle_0;

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_verify_param_copy_Private_Static_IntPtr_IntPtr_0;

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_verify_param_lookup_Private_Static_IntPtr_IntPtr_0;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_verify_param_can_modify_Private_Static_Int32_IntPtr_0;

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_verify_param_set_host_Private_Static_Int32_IntPtr_IntPtr_Int32_0;

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_verify_param_set_time_Private_Static_Int32_IntPtr_Int64_0;

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_verify_param_free_Private_Static_Void_IntPtr_0;

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BoringX509VerifyParamHandle_0;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_MonoBtlsX509VerifyParam_0;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeMethodInfoPtr_GetSslClient_Public_Static_MonoBtlsX509VerifyParam_0;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeMethodInfoPtr_GetSslServer_Public_Static_MonoBtlsX509VerifyParam_0;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeMethodInfoPtr_Lookup_Public_Static_MonoBtlsX509VerifyParam_String_Boolean_0;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeMethodInfoPtr_get_CanModify_Public_get_Boolean_0;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeMethodInfoPtr_WantToModify_Private_Void_0;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeMethodInfoPtr_SetHost_Public_Void_String_0;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeMethodInfoPtr_SetTime_Public_Void_DateTime_0;

		// Token: 0x020002BD RID: 701
		public class BoringX509VerifyParamHandle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x06002B2D RID: 11053 RVA: 0x00013545 File Offset: 0x00011745
			// Note: this type is marked as 'beforefieldinit'.
			static BoringX509VerifyParamHandle()
			{
				Il2CppClassPointerStore<MonoBtlsX509VerifyParam.BoringX509VerifyParamHandle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoBtlsX509VerifyParam>.NativeClassPtr, "BoringX509VerifyParamHandle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsX509VerifyParam.BoringX509VerifyParamHandle>.NativeClassPtr);
				MonoBtlsX509VerifyParam.BoringX509VerifyParamHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509VerifyParam.BoringX509VerifyParamHandle>.NativeClassPtr, 100664092);
			}

			// Token: 0x06002B2E RID: 11054 RVA: 0x000BFDAC File Offset: 0x000BDFAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432521, XrefRangeEnd = 432523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool ReleaseHandle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsX509VerifyParam.BoringX509VerifyParamHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002B2F RID: 11055 RVA: 0x00013579 File Offset: 0x00011779
			public BoringX509VerifyParamHandle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040021E3 RID: 8675
			private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;
		}
	}
}

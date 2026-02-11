using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;

namespace Il2CppMono.Btls
{
	// Token: 0x02000030 RID: 48
	public class MonoBtlsPkcs12 : MonoBtlsObject
	{
		// Token: 0x060002E0 RID: 736 RVA: 0x0002629C File Offset: 0x0002449C
		// Note: this type is marked as 'beforefieldinit'.
		static MonoBtlsPkcs12()
		{
			Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsPkcs12");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr);
			MonoBtlsPkcs12.NativeFieldInfoPtr_privateKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr, "privateKey");
			MonoBtlsPkcs12.NativeMethodInfoPtr_get_Handle_Internal_get_BoringPkcs12Handle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr, 100663800);
			MonoBtlsPkcs12.NativeMethodInfoPtr_mono_btls_pkcs12_free_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr, 100663801);
			MonoBtlsPkcs12.NativeMethodInfoPtr_mono_btls_pkcs12_new_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr, 100663802);
			MonoBtlsPkcs12.NativeMethodInfoPtr_mono_btls_pkcs12_get_count_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr, 100663803);
			MonoBtlsPkcs12.NativeMethodInfoPtr_mono_btls_pkcs12_get_cert_Private_Static_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr, 100663804);
			MonoBtlsPkcs12.NativeMethodInfoPtr_mono_btls_pkcs12_import_Private_Static_Int32_IntPtr_ptr_Void_Int32_SafePasswordHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr, 100663805);
			MonoBtlsPkcs12.NativeMethodInfoPtr_mono_btls_pkcs12_has_private_key_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr, 100663806);
			MonoBtlsPkcs12.NativeMethodInfoPtr_mono_btls_pkcs12_get_private_key_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr, 100663807);
			MonoBtlsPkcs12.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr, 100663808);
			MonoBtlsPkcs12.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr, 100663809);
			MonoBtlsPkcs12.NativeMethodInfoPtr_GetCertificate_Public_MonoBtlsX509_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr, 100663810);
			MonoBtlsPkcs12.NativeMethodInfoPtr_Import_Public_Void_Il2CppStructArray_1_Byte_SafePasswordHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr, 100663811);
			MonoBtlsPkcs12.NativeMethodInfoPtr_get_HasPrivateKey_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr, 100663812);
			MonoBtlsPkcs12.NativeMethodInfoPtr_GetPrivateKey_Public_MonoBtlsKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr, 100663813);
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x000263F8 File Offset: 0x000245F8
		public new unsafe MonoBtlsPkcs12.BoringPkcs12Handle Handle
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 430263, RefRangeEnd = 430270, XrefRangeStart = 430260, XrefRangeEnd = 430263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsPkcs12.NativeMethodInfoPtr_get_Handle_Internal_get_BoringPkcs12Handle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsPkcs12.BoringPkcs12Handle>(intPtr3) : null;
			}
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00026438 File Offset: 0x00024638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430270, XrefRangeEnd = 430272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void mono_btls_pkcs12_free(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsPkcs12.NativeMethodInfoPtr_mono_btls_pkcs12_free_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0002646C File Offset: 0x0002466C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430272, XrefRangeEnd = 430274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr mono_btls_pkcs12_new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsPkcs12.NativeMethodInfoPtr_mono_btls_pkcs12_new_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0002649C File Offset: 0x0002469C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430274, XrefRangeEnd = 430276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_pkcs12_get_count(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsPkcs12.NativeMethodInfoPtr_mono_btls_pkcs12_get_count_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x000264DC File Offset: 0x000246DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430276, XrefRangeEnd = 430278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr mono_btls_pkcs12_get_cert(IntPtr Handle, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref Handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsPkcs12.NativeMethodInfoPtr_mono_btls_pkcs12_get_cert_Private_Static_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00026528 File Offset: 0x00024728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430278, XrefRangeEnd = 430281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_pkcs12_import(IntPtr chain, void* data, int len, SafePasswordHandle password)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref chain;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(password);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsPkcs12.NativeMethodInfoPtr_mono_btls_pkcs12_import_Private_Static_Int32_IntPtr_ptr_Void_Int32_SafePasswordHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00026594 File Offset: 0x00024794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430281, XrefRangeEnd = 430283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_pkcs12_has_private_key(IntPtr pkcs12)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pkcs12;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsPkcs12.NativeMethodInfoPtr_mono_btls_pkcs12_has_private_key_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x000265D4 File Offset: 0x000247D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430283, XrefRangeEnd = 430285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr mono_btls_pkcs12_get_private_key(IntPtr pkcs12)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pkcs12;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsPkcs12.NativeMethodInfoPtr_mono_btls_pkcs12_get_private_key_Private_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00026614 File Offset: 0x00024814
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430293, RefRangeEnd = 430294, XrefRangeStart = 430285, XrefRangeEnd = 430293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsPkcs12()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsPkcs12.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060002EA RID: 746 RVA: 0x00026650 File Offset: 0x00024850
		public unsafe int Count
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 430297, RefRangeEnd = 430299, XrefRangeStart = 430294, XrefRangeEnd = 430297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsPkcs12.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0002668C File Offset: 0x0002488C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 430317, RefRangeEnd = 430319, XrefRangeStart = 430299, XrefRangeEnd = 430317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsX509 GetCertificate(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsPkcs12.NativeMethodInfoPtr_GetCertificate_Public_MonoBtlsX509_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509>(intPtr3) : null;
			}
		}

		// Token: 0x060002EC RID: 748 RVA: 0x000266D8 File Offset: 0x000248D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 430331, RefRangeEnd = 430334, XrefRangeStart = 430319, XrefRangeEnd = 430331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Import(Il2CppStructArray<byte> buffer, SafePasswordHandle password)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(password);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsPkcs12.NativeMethodInfoPtr_Import_Public_Void_Il2CppStructArray_1_Byte_SafePasswordHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060002ED RID: 749 RVA: 0x0002672C File Offset: 0x0002492C
		public unsafe bool HasPrivateKey
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 430337, RefRangeEnd = 430338, XrefRangeStart = 430334, XrefRangeEnd = 430337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsPkcs12.NativeMethodInfoPtr_get_HasPrivateKey_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00026768 File Offset: 0x00024968
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430358, RefRangeEnd = 430359, XrefRangeStart = 430338, XrefRangeEnd = 430358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsKey GetPrivateKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsPkcs12.NativeMethodInfoPtr_GetPrivateKey_Public_MonoBtlsKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsKey>(intPtr3) : null;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000308C File Offset: 0x0000128C
		public MonoBtlsPkcs12(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x000267A8 File Offset: 0x000249A8
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x00003095 File Offset: 0x00001295
		public unsafe MonoBtlsKey privateKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsPkcs12.NativeFieldInfoPtr_privateKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBtlsKey>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsPkcs12.NativeFieldInfoPtr_privateKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeFieldInfoPtr_privateKey;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Internal_get_BoringPkcs12Handle_0;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_pkcs12_free_Private_Static_Void_IntPtr_0;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_pkcs12_new_Private_Static_IntPtr_0;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_pkcs12_get_count_Private_Static_Int32_IntPtr_0;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_pkcs12_get_cert_Private_Static_IntPtr_IntPtr_Int32_0;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_pkcs12_import_Private_Static_Int32_IntPtr_ptr_Void_Int32_SafePasswordHandle_0;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_pkcs12_has_private_key_Private_Static_Int32_IntPtr_0;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_pkcs12_get_private_key_Private_Static_IntPtr_IntPtr_0;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr_GetCertificate_Public_MonoBtlsX509_Int32_0;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Void_Il2CppStructArray_1_Byte_SafePasswordHandle_0;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeMethodInfoPtr_get_HasPrivateKey_Public_get_Boolean_0;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeMethodInfoPtr_GetPrivateKey_Public_MonoBtlsKey_0;

		// Token: 0x020002AE RID: 686
		public class BoringPkcs12Handle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x06002AE8 RID: 10984 RVA: 0x0001314A File Offset: 0x0001134A
			// Note: this type is marked as 'beforefieldinit'.
			static BoringPkcs12Handle()
			{
				Il2CppClassPointerStore<MonoBtlsPkcs12.BoringPkcs12Handle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr, "BoringPkcs12Handle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsPkcs12.BoringPkcs12Handle>.NativeClassPtr);
				MonoBtlsPkcs12.BoringPkcs12Handle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsPkcs12.BoringPkcs12Handle>.NativeClassPtr, 100663815);
			}

			// Token: 0x06002AE9 RID: 10985 RVA: 0x000BF4B8 File Offset: 0x000BD6B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430258, XrefRangeEnd = 430260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool ReleaseHandle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsPkcs12.BoringPkcs12Handle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002AEA RID: 10986 RVA: 0x0001317E File Offset: 0x0001137E
			public BoringPkcs12Handle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040021CA RID: 8650
			private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;
		}
	}
}

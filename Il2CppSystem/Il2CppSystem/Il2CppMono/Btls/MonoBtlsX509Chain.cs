using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppMono.Btls
{
	// Token: 0x0200003C RID: 60
	public class MonoBtlsX509Chain : MonoBtlsObject
	{
		// Token: 0x060003B1 RID: 945 RVA: 0x00029EDC File Offset: 0x000280DC
		// Note: this type is marked as 'beforefieldinit'.
		static MonoBtlsX509Chain()
		{
			Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsX509Chain");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr);
			MonoBtlsX509Chain.NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509ChainHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr, 100663964);
			MonoBtlsX509Chain.NativeMethodInfoPtr_mono_btls_x509_chain_new_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr, 100663965);
			MonoBtlsX509Chain.NativeMethodInfoPtr_mono_btls_x509_chain_get_count_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr, 100663966);
			MonoBtlsX509Chain.NativeMethodInfoPtr_mono_btls_x509_chain_get_cert_Private_Static_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr, 100663967);
			MonoBtlsX509Chain.NativeMethodInfoPtr_mono_btls_x509_chain_add_cert_Private_Static_Int32_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr, 100663968);
			MonoBtlsX509Chain.NativeMethodInfoPtr_mono_btls_x509_chain_up_ref_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr, 100663969);
			MonoBtlsX509Chain.NativeMethodInfoPtr_mono_btls_x509_chain_free_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr, 100663970);
			MonoBtlsX509Chain.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr, 100663971);
			MonoBtlsX509Chain.NativeMethodInfoPtr__ctor_Internal_Void_BoringX509ChainHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr, 100663972);
			MonoBtlsX509Chain.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr, 100663973);
			MonoBtlsX509Chain.NativeMethodInfoPtr_GetCertificate_Public_MonoBtlsX509_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr, 100663974);
			MonoBtlsX509Chain.NativeMethodInfoPtr_AddCertificate_Public_Void_MonoBtlsX509_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr, 100663975);
			MonoBtlsX509Chain.NativeMethodInfoPtr_Copy_Internal_MonoBtlsX509Chain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr, 100663976);
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x0002A010 File Offset: 0x00028210
		public new unsafe MonoBtlsX509Chain.BoringX509ChainHandle Handle
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 431650, RefRangeEnd = 431656, XrefRangeStart = 431647, XrefRangeEnd = 431650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Chain.NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509ChainHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509Chain.BoringX509ChainHandle>(intPtr3) : null;
			}
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0002A050 File Offset: 0x00028250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431656, XrefRangeEnd = 431658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr mono_btls_x509_chain_new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Chain.NativeMethodInfoPtr_mono_btls_x509_chain_new_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0002A080 File Offset: 0x00028280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431658, XrefRangeEnd = 431660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_x509_chain_get_count(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Chain.NativeMethodInfoPtr_mono_btls_x509_chain_get_count_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0002A0C0 File Offset: 0x000282C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431660, XrefRangeEnd = 431662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr mono_btls_x509_chain_get_cert(IntPtr Handle, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref Handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Chain.NativeMethodInfoPtr_mono_btls_x509_chain_get_cert_Private_Static_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0002A10C File Offset: 0x0002830C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431662, XrefRangeEnd = 431664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_x509_chain_add_cert(IntPtr chain, IntPtr x509)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref chain;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x509;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Chain.NativeMethodInfoPtr_mono_btls_x509_chain_add_cert_Private_Static_Int32_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0002A158 File Offset: 0x00028358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431664, XrefRangeEnd = 431666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr mono_btls_x509_chain_up_ref(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Chain.NativeMethodInfoPtr_mono_btls_x509_chain_up_ref_Private_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0002A198 File Offset: 0x00028398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431666, XrefRangeEnd = 431668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void mono_btls_x509_chain_free(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Chain.NativeMethodInfoPtr_mono_btls_x509_chain_free_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0002A1CC File Offset: 0x000283CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 431675, RefRangeEnd = 431676, XrefRangeStart = 431668, XrefRangeEnd = 431675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsX509Chain()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Chain.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0002A208 File Offset: 0x00028408
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 373450, RefRangeEnd = 373451, XrefRangeStart = 373450, XrefRangeEnd = 373451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsX509Chain(MonoBtlsX509Chain.BoringX509ChainHandle handle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Chain.NativeMethodInfoPtr__ctor_Internal_Void_BoringX509ChainHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060003BB RID: 955 RVA: 0x0002A254 File Offset: 0x00028454
		public unsafe int Count
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 431679, RefRangeEnd = 431682, XrefRangeStart = 431676, XrefRangeEnd = 431679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Chain.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0002A290 File Offset: 0x00028490
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 431698, RefRangeEnd = 431700, XrefRangeStart = 431682, XrefRangeEnd = 431698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsX509 GetCertificate(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Chain.NativeMethodInfoPtr_GetCertificate_Public_MonoBtlsX509_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509>(intPtr3) : null;
			}
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0002A2DC File Offset: 0x000284DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 431704, RefRangeEnd = 431707, XrefRangeStart = 431700, XrefRangeEnd = 431704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCertificate(MonoBtlsX509 x509)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x509);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Chain.NativeMethodInfoPtr_AddCertificate_Public_Void_MonoBtlsX509_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0002A320 File Offset: 0x00028520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431707, XrefRangeEnd = 431722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsX509Chain Copy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Chain.NativeMethodInfoPtr_Copy_Internal_MonoBtlsX509Chain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509Chain>(intPtr3) : null;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00003345 File Offset: 0x00001545
		public MonoBtlsX509Chain(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509ChainHandle_0;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_chain_new_Private_Static_IntPtr_0;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_chain_get_count_Private_Static_Int32_IntPtr_0;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_chain_get_cert_Private_Static_IntPtr_IntPtr_Int32_0;

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_chain_add_cert_Private_Static_Int32_IntPtr_IntPtr_0;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_chain_up_ref_Private_Static_IntPtr_IntPtr_0;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_chain_free_Private_Static_Void_IntPtr_0;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BoringX509ChainHandle_0;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeMethodInfoPtr_GetCertificate_Public_MonoBtlsX509_Int32_0;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeMethodInfoPtr_AddCertificate_Public_Void_MonoBtlsX509_0;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Internal_MonoBtlsX509Chain_0;

		// Token: 0x020002B6 RID: 694
		public class BoringX509ChainHandle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x06002B11 RID: 11025 RVA: 0x000133C2 File Offset: 0x000115C2
			// Note: this type is marked as 'beforefieldinit'.
			static BoringX509ChainHandle()
			{
				Il2CppClassPointerStore<MonoBtlsX509Chain.BoringX509ChainHandle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr, "BoringX509ChainHandle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsX509Chain.BoringX509ChainHandle>.NativeClassPtr);
				MonoBtlsX509Chain.BoringX509ChainHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Chain.BoringX509ChainHandle>.NativeClassPtr, 100663978);
			}

			// Token: 0x06002B12 RID: 11026 RVA: 0x000BF968 File Offset: 0x000BDB68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431645, XrefRangeEnd = 431647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool ReleaseHandle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsX509Chain.BoringX509ChainHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002B13 RID: 11027 RVA: 0x000133F6 File Offset: 0x000115F6
			public BoringX509ChainHandle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040021D7 RID: 8663
			private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;
		}
	}
}

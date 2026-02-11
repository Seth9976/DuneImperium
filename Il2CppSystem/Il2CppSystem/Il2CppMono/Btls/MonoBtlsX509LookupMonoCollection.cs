using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Btls
{
	// Token: 0x02000042 RID: 66
	public class MonoBtlsX509LookupMonoCollection : MonoBtlsX509LookupMono
	{
		// Token: 0x060003EB RID: 1003 RVA: 0x0002ADEC File Offset: 0x00028FEC
		// Note: this type is marked as 'beforefieldinit'.
		static MonoBtlsX509LookupMonoCollection()
		{
			Il2CppClassPointerStore<MonoBtlsX509LookupMonoCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsX509LookupMonoCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsX509LookupMonoCollection>.NativeClassPtr);
			MonoBtlsX509LookupMonoCollection.NativeFieldInfoPtr_hashes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsX509LookupMonoCollection>.NativeClassPtr, "hashes");
			MonoBtlsX509LookupMonoCollection.NativeFieldInfoPtr_certificates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsX509LookupMonoCollection>.NativeClassPtr, "certificates");
			MonoBtlsX509LookupMonoCollection.NativeFieldInfoPtr_collection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsX509LookupMonoCollection>.NativeClassPtr, "collection");
			MonoBtlsX509LookupMonoCollection.NativeFieldInfoPtr_trust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsX509LookupMonoCollection>.NativeClassPtr, "trust");
			MonoBtlsX509LookupMonoCollection.NativeMethodInfoPtr__ctor_Internal_Void_X509CertificateCollection_MonoBtlsX509TrustKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509LookupMonoCollection>.NativeClassPtr, 100664008);
			MonoBtlsX509LookupMonoCollection.NativeMethodInfoPtr_Initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509LookupMonoCollection>.NativeClassPtr, 100664009);
			MonoBtlsX509LookupMonoCollection.NativeMethodInfoPtr_OnGetBySubject_Protected_Virtual_MonoBtlsX509_MonoBtlsX509Name_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509LookupMonoCollection>.NativeClassPtr, 100664010);
			MonoBtlsX509LookupMonoCollection.NativeMethodInfoPtr_Close_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509LookupMonoCollection>.NativeClassPtr, 100664011);
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0002AEBC File Offset: 0x000290BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431930, XrefRangeEnd = 431932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsX509LookupMonoCollection(X509CertificateCollection collection, MonoBtlsX509TrustKind trust)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsX509LookupMonoCollection>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trust;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509LookupMonoCollection.NativeMethodInfoPtr__ctor_Internal_Void_X509CertificateCollection_MonoBtlsX509TrustKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0002AF18 File Offset: 0x00029118
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 431956, RefRangeEnd = 431957, XrefRangeStart = 431932, XrefRangeEnd = 431956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509LookupMonoCollection.NativeMethodInfoPtr_Initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0002AF4C File Offset: 0x0002914C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431957, XrefRangeEnd = 431961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MonoBtlsX509 OnGetBySubject(MonoBtlsX509Name name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsX509LookupMonoCollection.NativeMethodInfoPtr_OnGetBySubject_Protected_Virtual_MonoBtlsX509_MonoBtlsX509Name_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509>(intPtr3) : null;
			}
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0002AFA8 File Offset: 0x000291A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431961, XrefRangeEnd = 431969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsX509LookupMonoCollection.NativeMethodInfoPtr_Close_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00003448 File Offset: 0x00001648
		public MonoBtlsX509LookupMonoCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x0002AFE4 File Offset: 0x000291E4
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x00003451 File Offset: 0x00001651
		public unsafe Il2CppStructArray<long> hashes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsX509LookupMonoCollection.NativeFieldInfoPtr_hashes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsX509LookupMonoCollection.NativeFieldInfoPtr_hashes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x0002B014 File Offset: 0x00029214
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x00003470 File Offset: 0x00001670
		public unsafe Il2CppReferenceArray<MonoBtlsX509> certificates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsX509LookupMonoCollection.NativeFieldInfoPtr_certificates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MonoBtlsX509>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsX509LookupMonoCollection.NativeFieldInfoPtr_certificates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x0002B044 File Offset: 0x00029244
		// (set) Token: 0x060003F6 RID: 1014 RVA: 0x0000348F File Offset: 0x0000168F
		public unsafe X509CertificateCollection collection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsX509LookupMonoCollection.NativeFieldInfoPtr_collection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsX509LookupMonoCollection.NativeFieldInfoPtr_collection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x0002B074 File Offset: 0x00029274
		// (set) Token: 0x060003F8 RID: 1016 RVA: 0x000034AE File Offset: 0x000016AE
		public unsafe MonoBtlsX509TrustKind trust
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsX509LookupMonoCollection.NativeFieldInfoPtr_trust);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsX509LookupMonoCollection.NativeFieldInfoPtr_trust)) = value;
			}
		}

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeFieldInfoPtr_hashes;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeFieldInfoPtr_certificates;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeFieldInfoPtr_collection;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeFieldInfoPtr_trust;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_X509CertificateCollection_MonoBtlsX509TrustKind_0;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_0;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeMethodInfoPtr_OnGetBySubject_Protected_Virtual_MonoBtlsX509_MonoBtlsX509Name_0;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeMethodInfoPtr_Close_Protected_Virtual_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000D7 RID: 215
	public sealed class X509ChainPolicy : Object
	{
		// Token: 0x06000E64 RID: 3684 RVA: 0x00052814 File Offset: 0x00050A14
		// Note: this type is marked as 'beforefieldinit'.
		static X509ChainPolicy()
		{
			Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509ChainPolicy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr);
			X509ChainPolicy.NativeFieldInfoPtr_apps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "apps");
			X509ChainPolicy.NativeFieldInfoPtr_cert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "cert");
			X509ChainPolicy.NativeFieldInfoPtr_store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "store");
			X509ChainPolicy.NativeFieldInfoPtr_store2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "store2");
			X509ChainPolicy.NativeFieldInfoPtr_rflag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "rflag");
			X509ChainPolicy.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "mode");
			X509ChainPolicy.NativeFieldInfoPtr_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "timeout");
			X509ChainPolicy.NativeFieldInfoPtr_vflags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "vflags");
			X509ChainPolicy.NativeFieldInfoPtr_vtime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "vtime");
			X509ChainPolicy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, 100665397);
			X509ChainPolicy.NativeMethodInfoPtr_get_ExtraStore_Public_get_X509Certificate2Collection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, 100665398);
			X509ChainPolicy.NativeMethodInfoPtr_set_ExtraStore_Internal_set_Void_X509Certificate2Collection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, 100665399);
			X509ChainPolicy.NativeMethodInfoPtr_get_RevocationFlag_Public_get_X509RevocationFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, 100665400);
			X509ChainPolicy.NativeMethodInfoPtr_get_RevocationMode_Public_get_X509RevocationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, 100665401);
			X509ChainPolicy.NativeMethodInfoPtr_set_RevocationMode_Public_set_Void_X509RevocationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, 100665402);
			X509ChainPolicy.NativeMethodInfoPtr_get_VerificationFlags_Public_get_X509VerificationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, 100665403);
			X509ChainPolicy.NativeMethodInfoPtr_set_VerificationFlags_Public_set_Void_X509VerificationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, 100665404);
			X509ChainPolicy.NativeMethodInfoPtr_get_VerificationTime_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, 100665405);
			X509ChainPolicy.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, 100665406);
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x000529C0 File Offset: 0x00050BC0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 455235, RefRangeEnd = 455241, XrefRangeStart = 455216, XrefRangeEnd = 455235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509ChainPolicy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainPolicy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000E66 RID: 3686 RVA: 0x000529FC File Offset: 0x00050BFC
		// (set) Token: 0x06000E67 RID: 3687 RVA: 0x00052A3C File Offset: 0x00050C3C
		public unsafe X509Certificate2Collection ExtraStore
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 455274, RefRangeEnd = 455275, XrefRangeStart = 455241, XrefRangeEnd = 455274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainPolicy.NativeMethodInfoPtr_get_ExtraStore_Public_get_X509Certificate2Collection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2Collection>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainPolicy.NativeMethodInfoPtr_set_ExtraStore_Internal_set_Void_X509Certificate2Collection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x00052A80 File Offset: 0x00050C80
		public unsafe X509RevocationFlag RevocationFlag
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainPolicy.NativeMethodInfoPtr_get_RevocationFlag_Public_get_X509RevocationFlag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000E69 RID: 3689 RVA: 0x00052ABC File Offset: 0x00050CBC
		// (set) Token: 0x06000E6A RID: 3690 RVA: 0x00052AF8 File Offset: 0x00050CF8
		public unsafe X509RevocationMode RevocationMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 134006, RefRangeEnd = 134007, XrefRangeStart = 134006, XrefRangeEnd = 134007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainPolicy.NativeMethodInfoPtr_get_RevocationMode_Public_get_X509RevocationMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 455275, RefRangeEnd = 455276, XrefRangeStart = 455275, XrefRangeEnd = 455275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainPolicy.NativeMethodInfoPtr_set_RevocationMode_Public_set_Void_X509RevocationMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000E6B RID: 3691 RVA: 0x00052B38 File Offset: 0x00050D38
		// (set) Token: 0x06000E6C RID: 3692 RVA: 0x00052B74 File Offset: 0x00050D74
		public unsafe X509VerificationFlags VerificationFlags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainPolicy.NativeMethodInfoPtr_get_VerificationFlags_Public_get_X509VerificationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainPolicy.NativeMethodInfoPtr_set_VerificationFlags_Public_set_Void_X509VerificationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000E6D RID: 3693 RVA: 0x00052BB4 File Offset: 0x00050DB4
		public unsafe DateTime VerificationTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainPolicy.NativeMethodInfoPtr_get_VerificationTime_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x00052BF0 File Offset: 0x00050DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 455276, XrefRangeEnd = 455294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainPolicy.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x0000732F File Offset: 0x0000552F
		public X509ChainPolicy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000E70 RID: 3696 RVA: 0x00052C24 File Offset: 0x00050E24
		// (set) Token: 0x06000E71 RID: 3697 RVA: 0x00007338 File Offset: 0x00005538
		public unsafe OidCollection apps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_apps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OidCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_apps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000E72 RID: 3698 RVA: 0x00052C54 File Offset: 0x00050E54
		// (set) Token: 0x06000E73 RID: 3699 RVA: 0x00007357 File Offset: 0x00005557
		public unsafe OidCollection cert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_cert);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OidCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_cert), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000E74 RID: 3700 RVA: 0x00052C84 File Offset: 0x00050E84
		// (set) Token: 0x06000E75 RID: 3701 RVA: 0x00007376 File Offset: 0x00005576
		public unsafe X509CertificateCollection store
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_store);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_store), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000E76 RID: 3702 RVA: 0x00052CB4 File Offset: 0x00050EB4
		// (set) Token: 0x06000E77 RID: 3703 RVA: 0x00007395 File Offset: 0x00005595
		public unsafe X509Certificate2Collection store2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_store2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate2Collection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_store2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000E78 RID: 3704 RVA: 0x00052CE4 File Offset: 0x00050EE4
		// (set) Token: 0x06000E79 RID: 3705 RVA: 0x000073B4 File Offset: 0x000055B4
		public unsafe X509RevocationFlag rflag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_rflag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_rflag)) = value;
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000E7A RID: 3706 RVA: 0x00052D0C File Offset: 0x00050F0C
		// (set) Token: 0x06000E7B RID: 3707 RVA: 0x000073CF File Offset: 0x000055CF
		public unsafe X509RevocationMode mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_mode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_mode)) = value;
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000E7C RID: 3708 RVA: 0x00052D34 File Offset: 0x00050F34
		// (set) Token: 0x06000E7D RID: 3709 RVA: 0x000073EA File Offset: 0x000055EA
		public unsafe TimeSpan timeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_timeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_timeout)) = value;
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000E7E RID: 3710 RVA: 0x00052D5C File Offset: 0x00050F5C
		// (set) Token: 0x06000E7F RID: 3711 RVA: 0x00007405 File Offset: 0x00005605
		public unsafe X509VerificationFlags vflags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_vflags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_vflags)) = value;
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000E80 RID: 3712 RVA: 0x00052D84 File Offset: 0x00050F84
		// (set) Token: 0x06000E81 RID: 3713 RVA: 0x00007420 File Offset: 0x00005620
		public unsafe DateTime vtime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_vtime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_vtime)) = value;
			}
		}

		// Token: 0x04000BD6 RID: 3030
		private static readonly IntPtr NativeFieldInfoPtr_apps;

		// Token: 0x04000BD7 RID: 3031
		private static readonly IntPtr NativeFieldInfoPtr_cert;

		// Token: 0x04000BD8 RID: 3032
		private static readonly IntPtr NativeFieldInfoPtr_store;

		// Token: 0x04000BD9 RID: 3033
		private static readonly IntPtr NativeFieldInfoPtr_store2;

		// Token: 0x04000BDA RID: 3034
		private static readonly IntPtr NativeFieldInfoPtr_rflag;

		// Token: 0x04000BDB RID: 3035
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x04000BDC RID: 3036
		private static readonly IntPtr NativeFieldInfoPtr_timeout;

		// Token: 0x04000BDD RID: 3037
		private static readonly IntPtr NativeFieldInfoPtr_vflags;

		// Token: 0x04000BDE RID: 3038
		private static readonly IntPtr NativeFieldInfoPtr_vtime;

		// Token: 0x04000BDF RID: 3039
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000BE0 RID: 3040
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtraStore_Public_get_X509Certificate2Collection_0;

		// Token: 0x04000BE1 RID: 3041
		private static readonly IntPtr NativeMethodInfoPtr_set_ExtraStore_Internal_set_Void_X509Certificate2Collection_0;

		// Token: 0x04000BE2 RID: 3042
		private static readonly IntPtr NativeMethodInfoPtr_get_RevocationFlag_Public_get_X509RevocationFlag_0;

		// Token: 0x04000BE3 RID: 3043
		private static readonly IntPtr NativeMethodInfoPtr_get_RevocationMode_Public_get_X509RevocationMode_0;

		// Token: 0x04000BE4 RID: 3044
		private static readonly IntPtr NativeMethodInfoPtr_set_RevocationMode_Public_set_Void_X509RevocationMode_0;

		// Token: 0x04000BE5 RID: 3045
		private static readonly IntPtr NativeMethodInfoPtr_get_VerificationFlags_Public_get_X509VerificationFlags_0;

		// Token: 0x04000BE6 RID: 3046
		private static readonly IntPtr NativeMethodInfoPtr_set_VerificationFlags_Public_set_Void_X509VerificationFlags_0;

		// Token: 0x04000BE7 RID: 3047
		private static readonly IntPtr NativeMethodInfoPtr_get_VerificationTime_Public_get_DateTime_0;

		// Token: 0x04000BE8 RID: 3048
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;
	}
}

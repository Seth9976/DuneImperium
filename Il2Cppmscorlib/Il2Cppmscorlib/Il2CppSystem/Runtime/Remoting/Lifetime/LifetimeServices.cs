using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Lifetime
{
	// Token: 0x020002B8 RID: 696
	public sealed class LifetimeServices : Object
	{
		// Token: 0x06002C5D RID: 11357 RVA: 0x000E8E3C File Offset: 0x000E703C
		// Note: this type is marked as 'beforefieldinit'.
		static LifetimeServices()
		{
			Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Lifetime", "LifetimeServices");
			LifetimeServices.NativeFieldInfoPtr__leaseManagerPollTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, "_leaseManagerPollTime");
			LifetimeServices.NativeFieldInfoPtr__leaseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, "_leaseTime");
			LifetimeServices.NativeFieldInfoPtr__renewOnCallTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, "_renewOnCallTime");
			LifetimeServices.NativeFieldInfoPtr__sponsorshipTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, "_sponsorshipTimeout");
			LifetimeServices.NativeFieldInfoPtr__leaseManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, "_leaseManager");
			LifetimeServices.NativeMethodInfoPtr_get_LeaseManagerPollTime_Public_Static_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100670452);
			LifetimeServices.NativeMethodInfoPtr_set_LeaseManagerPollTime_Public_Static_set_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100670453);
			LifetimeServices.NativeMethodInfoPtr_get_LeaseTime_Public_Static_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100670454);
			LifetimeServices.NativeMethodInfoPtr_set_LeaseTime_Public_Static_set_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100670455);
			LifetimeServices.NativeMethodInfoPtr_get_RenewOnCallTime_Public_Static_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100670456);
			LifetimeServices.NativeMethodInfoPtr_set_RenewOnCallTime_Public_Static_set_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100670457);
			LifetimeServices.NativeMethodInfoPtr_get_SponsorshipTimeout_Public_Static_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100670458);
			LifetimeServices.NativeMethodInfoPtr_set_SponsorshipTimeout_Public_Static_set_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100670459);
			LifetimeServices.NativeMethodInfoPtr_TrackLifetime_Internal_Static_Void_ServerIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100670460);
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06002C5E RID: 11358 RVA: 0x000E8F7C File Offset: 0x000E717C
		// (set) Token: 0x06002C5F RID: 11359 RVA: 0x000E8FAC File Offset: 0x000E71AC
		public unsafe static TimeSpan LeaseManagerPollTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380338, XrefRangeEnd = 1380342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifetimeServices.NativeMethodInfoPtr_get_LeaseManagerPollTime_Public_Static_get_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1380349, RefRangeEnd = 1380350, XrefRangeStart = 1380342, XrefRangeEnd = 1380349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifetimeServices.NativeMethodInfoPtr_set_LeaseManagerPollTime_Public_Static_set_Void_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06002C60 RID: 11360 RVA: 0x000E8FE0 File Offset: 0x000E71E0
		// (set) Token: 0x06002C61 RID: 11361 RVA: 0x000E9010 File Offset: 0x000E7210
		public unsafe static TimeSpan LeaseTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380350, XrefRangeEnd = 1380354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifetimeServices.NativeMethodInfoPtr_get_LeaseTime_Public_Static_get_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380354, XrefRangeEnd = 1380358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifetimeServices.NativeMethodInfoPtr_set_LeaseTime_Public_Static_set_Void_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06002C62 RID: 11362 RVA: 0x000E9044 File Offset: 0x000E7244
		// (set) Token: 0x06002C63 RID: 11363 RVA: 0x000E9074 File Offset: 0x000E7274
		public unsafe static TimeSpan RenewOnCallTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380358, XrefRangeEnd = 1380362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifetimeServices.NativeMethodInfoPtr_get_RenewOnCallTime_Public_Static_get_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380362, XrefRangeEnd = 1380366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifetimeServices.NativeMethodInfoPtr_set_RenewOnCallTime_Public_Static_set_Void_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06002C64 RID: 11364 RVA: 0x000E90A8 File Offset: 0x000E72A8
		// (set) Token: 0x06002C65 RID: 11365 RVA: 0x000E90D8 File Offset: 0x000E72D8
		public unsafe static TimeSpan SponsorshipTimeout
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380366, XrefRangeEnd = 1380370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifetimeServices.NativeMethodInfoPtr_get_SponsorshipTimeout_Public_Static_get_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380370, XrefRangeEnd = 1380374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifetimeServices.NativeMethodInfoPtr_set_SponsorshipTimeout_Public_Static_set_Void_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002C66 RID: 11366 RVA: 0x000E910C File Offset: 0x000E730C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1380404, RefRangeEnd = 1380405, XrefRangeStart = 1380374, XrefRangeEnd = 1380404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TrackLifetime(ServerIdentity identity)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(identity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifetimeServices.NativeMethodInfoPtr_TrackLifetime_Internal_Static_Void_ServerIdentity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C67 RID: 11367 RVA: 0x0000ED84 File Offset: 0x0000CF84
		public LifetimeServices(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06002C68 RID: 11368 RVA: 0x000E9144 File Offset: 0x000E7344
		// (set) Token: 0x06002C69 RID: 11369 RVA: 0x0000ED8D File Offset: 0x0000CF8D
		public unsafe static TimeSpan _leaseManagerPollTime
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(LifetimeServices.NativeFieldInfoPtr__leaseManagerPollTime, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LifetimeServices.NativeFieldInfoPtr__leaseManagerPollTime, (void*)(&value));
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06002C6A RID: 11370 RVA: 0x000E9160 File Offset: 0x000E7360
		// (set) Token: 0x06002C6B RID: 11371 RVA: 0x0000ED9B File Offset: 0x0000CF9B
		public unsafe static TimeSpan _leaseTime
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(LifetimeServices.NativeFieldInfoPtr__leaseTime, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LifetimeServices.NativeFieldInfoPtr__leaseTime, (void*)(&value));
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06002C6C RID: 11372 RVA: 0x000E917C File Offset: 0x000E737C
		// (set) Token: 0x06002C6D RID: 11373 RVA: 0x0000EDA9 File Offset: 0x0000CFA9
		public unsafe static TimeSpan _renewOnCallTime
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(LifetimeServices.NativeFieldInfoPtr__renewOnCallTime, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LifetimeServices.NativeFieldInfoPtr__renewOnCallTime, (void*)(&value));
			}
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06002C6E RID: 11374 RVA: 0x000E9198 File Offset: 0x000E7398
		// (set) Token: 0x06002C6F RID: 11375 RVA: 0x0000EDB7 File Offset: 0x0000CFB7
		public unsafe static TimeSpan _sponsorshipTimeout
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(LifetimeServices.NativeFieldInfoPtr__sponsorshipTimeout, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LifetimeServices.NativeFieldInfoPtr__sponsorshipTimeout, (void*)(&value));
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06002C70 RID: 11376 RVA: 0x000E91B4 File Offset: 0x000E73B4
		// (set) Token: 0x06002C71 RID: 11377 RVA: 0x0000EDC5 File Offset: 0x0000CFC5
		public unsafe static LeaseManager _leaseManager
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LifetimeServices.NativeFieldInfoPtr__leaseManager, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LeaseManager>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LifetimeServices.NativeFieldInfoPtr__leaseManager, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400256E RID: 9582
		private static readonly IntPtr NativeFieldInfoPtr__leaseManagerPollTime;

		// Token: 0x0400256F RID: 9583
		private static readonly IntPtr NativeFieldInfoPtr__leaseTime;

		// Token: 0x04002570 RID: 9584
		private static readonly IntPtr NativeFieldInfoPtr__renewOnCallTime;

		// Token: 0x04002571 RID: 9585
		private static readonly IntPtr NativeFieldInfoPtr__sponsorshipTimeout;

		// Token: 0x04002572 RID: 9586
		private static readonly IntPtr NativeFieldInfoPtr__leaseManager;

		// Token: 0x04002573 RID: 9587
		private static readonly IntPtr NativeMethodInfoPtr_get_LeaseManagerPollTime_Public_Static_get_TimeSpan_0;

		// Token: 0x04002574 RID: 9588
		private static readonly IntPtr NativeMethodInfoPtr_set_LeaseManagerPollTime_Public_Static_set_Void_TimeSpan_0;

		// Token: 0x04002575 RID: 9589
		private static readonly IntPtr NativeMethodInfoPtr_get_LeaseTime_Public_Static_get_TimeSpan_0;

		// Token: 0x04002576 RID: 9590
		private static readonly IntPtr NativeMethodInfoPtr_set_LeaseTime_Public_Static_set_Void_TimeSpan_0;

		// Token: 0x04002577 RID: 9591
		private static readonly IntPtr NativeMethodInfoPtr_get_RenewOnCallTime_Public_Static_get_TimeSpan_0;

		// Token: 0x04002578 RID: 9592
		private static readonly IntPtr NativeMethodInfoPtr_set_RenewOnCallTime_Public_Static_set_Void_TimeSpan_0;

		// Token: 0x04002579 RID: 9593
		private static readonly IntPtr NativeMethodInfoPtr_get_SponsorshipTimeout_Public_Static_get_TimeSpan_0;

		// Token: 0x0400257A RID: 9594
		private static readonly IntPtr NativeMethodInfoPtr_set_SponsorshipTimeout_Public_Static_set_Void_TimeSpan_0;

		// Token: 0x0400257B RID: 9595
		private static readonly IntPtr NativeMethodInfoPtr_TrackLifetime_Internal_Static_Void_ServerIdentity_0;
	}
}

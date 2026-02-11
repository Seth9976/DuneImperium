using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting.Lifetime
{
	// Token: 0x020002B4 RID: 692
	public class Lease : MarshalByRefObject
	{
		// Token: 0x06002C2D RID: 11309 RVA: 0x000E843C File Offset: 0x000E663C
		// Note: this type is marked as 'beforefieldinit'.
		static Lease()
		{
			Il2CppClassPointerStore<Lease>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Lifetime", "Lease");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lease>.NativeClassPtr);
			Lease.NativeFieldInfoPtr__leaseExpireTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lease>.NativeClassPtr, "_leaseExpireTime");
			Lease.NativeFieldInfoPtr__currentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lease>.NativeClassPtr, "_currentState");
			Lease.NativeFieldInfoPtr__initialLeaseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lease>.NativeClassPtr, "_initialLeaseTime");
			Lease.NativeFieldInfoPtr__renewOnCallTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lease>.NativeClassPtr, "_renewOnCallTime");
			Lease.NativeFieldInfoPtr__sponsorshipTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lease>.NativeClassPtr, "_sponsorshipTimeout");
			Lease.NativeFieldInfoPtr__sponsors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lease>.NativeClassPtr, "_sponsors");
			Lease.NativeFieldInfoPtr__renewingSponsors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lease>.NativeClassPtr, "_renewingSponsors");
			Lease.NativeFieldInfoPtr__renewalDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lease>.NativeClassPtr, "_renewalDelegate");
			Lease.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease>.NativeClassPtr, 100670427);
			Lease.NativeMethodInfoPtr_get_CurrentLeaseTime_Public_Virtual_Final_New_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease>.NativeClassPtr, 100670428);
			Lease.NativeMethodInfoPtr_get_CurrentState_Public_Virtual_Final_New_get_LeaseState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease>.NativeClassPtr, 100670429);
			Lease.NativeMethodInfoPtr_Activate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease>.NativeClassPtr, 100670430);
			Lease.NativeMethodInfoPtr_get_RenewOnCallTime_Public_Virtual_Final_New_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease>.NativeClassPtr, 100670431);
			Lease.NativeMethodInfoPtr_Renew_Public_Virtual_Final_New_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease>.NativeClassPtr, 100670432);
			Lease.NativeMethodInfoPtr_Unregister_Public_Virtual_Final_New_Void_ISponsor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease>.NativeClassPtr, 100670433);
			Lease.NativeMethodInfoPtr_UpdateState_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease>.NativeClassPtr, 100670434);
			Lease.NativeMethodInfoPtr_CheckNextSponsor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease>.NativeClassPtr, 100670435);
			Lease.NativeMethodInfoPtr_ProcessSponsorResponse_Private_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease>.NativeClassPtr, 100670436);
		}

		// Token: 0x06002C2E RID: 11310 RVA: 0x000E85D4 File Offset: 0x000E67D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380081, XrefRangeEnd = 1380102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Lease()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lease>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06002C2F RID: 11311 RVA: 0x000E8610 File Offset: 0x000E6810
		public unsafe virtual TimeSpan CurrentLeaseTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380102, XrefRangeEnd = 1380107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.NativeMethodInfoPtr_get_CurrentLeaseTime_Public_Virtual_Final_New_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06002C30 RID: 11312 RVA: 0x000E864C File Offset: 0x000E684C
		public unsafe virtual LeaseState CurrentState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.NativeMethodInfoPtr_get_CurrentState_Public_Virtual_Final_New_get_LeaseState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C31 RID: 11313 RVA: 0x000E8688 File Offset: 0x000E6888
		[CallerCount(0)]
		public unsafe void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.NativeMethodInfoPtr_Activate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06002C32 RID: 11314 RVA: 0x000E86BC File Offset: 0x000E68BC
		public unsafe virtual TimeSpan RenewOnCallTime
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.NativeMethodInfoPtr_get_RenewOnCallTime_Public_Virtual_Final_New_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C33 RID: 11315 RVA: 0x000E86F8 File Offset: 0x000E68F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380107, XrefRangeEnd = 1380118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TimeSpan Renew(TimeSpan renewalTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref renewalTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.NativeMethodInfoPtr_Renew_Public_Virtual_Final_New_TimeSpan_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C34 RID: 11316 RVA: 0x000E8744 File Offset: 0x000E6944
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1380127, RefRangeEnd = 1380128, XrefRangeStart = 1380118, XrefRangeEnd = 1380127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Unregister(ISponsor obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.NativeMethodInfoPtr_Unregister_Public_Virtual_Final_New_Void_ISponsor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C35 RID: 11317 RVA: 0x000E8788 File Offset: 0x000E6988
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1380139, RefRangeEnd = 1380140, XrefRangeStart = 1380128, XrefRangeEnd = 1380139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.NativeMethodInfoPtr_UpdateState_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C36 RID: 11318 RVA: 0x000E87BC File Offset: 0x000E69BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380140, XrefRangeEnd = 1380172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckNextSponsor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.NativeMethodInfoPtr_CheckNextSponsor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C37 RID: 11319 RVA: 0x000E87F0 File Offset: 0x000E69F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380172, XrefRangeEnd = 1380234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessSponsorResponse(Object state, bool timedOut)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timedOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.NativeMethodInfoPtr_ProcessSponsorResponse_Private_Void_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C38 RID: 11320 RVA: 0x0000EC28 File Offset: 0x0000CE28
		public Lease(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06002C39 RID: 11321 RVA: 0x000E8840 File Offset: 0x000E6A40
		// (set) Token: 0x06002C3A RID: 11322 RVA: 0x0000EC31 File Offset: 0x0000CE31
		public unsafe DateTime _leaseExpireTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__leaseExpireTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__leaseExpireTime)) = value;
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06002C3B RID: 11323 RVA: 0x000E8868 File Offset: 0x000E6A68
		// (set) Token: 0x06002C3C RID: 11324 RVA: 0x0000EC4C File Offset: 0x0000CE4C
		public unsafe LeaseState _currentState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__currentState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__currentState)) = value;
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06002C3D RID: 11325 RVA: 0x000E8890 File Offset: 0x000E6A90
		// (set) Token: 0x06002C3E RID: 11326 RVA: 0x0000EC67 File Offset: 0x0000CE67
		public unsafe TimeSpan _initialLeaseTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__initialLeaseTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__initialLeaseTime)) = value;
			}
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06002C3F RID: 11327 RVA: 0x000E88B8 File Offset: 0x000E6AB8
		// (set) Token: 0x06002C40 RID: 11328 RVA: 0x0000EC82 File Offset: 0x0000CE82
		public unsafe TimeSpan _renewOnCallTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__renewOnCallTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__renewOnCallTime)) = value;
			}
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06002C41 RID: 11329 RVA: 0x000E88E0 File Offset: 0x000E6AE0
		// (set) Token: 0x06002C42 RID: 11330 RVA: 0x0000EC9D File Offset: 0x0000CE9D
		public unsafe TimeSpan _sponsorshipTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__sponsorshipTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__sponsorshipTimeout)) = value;
			}
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06002C43 RID: 11331 RVA: 0x000E8908 File Offset: 0x000E6B08
		// (set) Token: 0x06002C44 RID: 11332 RVA: 0x0000ECB8 File Offset: 0x0000CEB8
		public unsafe ArrayList _sponsors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__sponsors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__sponsors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06002C45 RID: 11333 RVA: 0x000E8938 File Offset: 0x000E6B38
		// (set) Token: 0x06002C46 RID: 11334 RVA: 0x0000ECD7 File Offset: 0x0000CED7
		public unsafe Queue _renewingSponsors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__renewingSponsors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__renewingSponsors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06002C47 RID: 11335 RVA: 0x000E8968 File Offset: 0x000E6B68
		// (set) Token: 0x06002C48 RID: 11336 RVA: 0x0000ECF6 File Offset: 0x0000CEF6
		public unsafe Lease.RenewalDelegate _renewalDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__renewalDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lease.RenewalDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__renewalDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002549 RID: 9545
		private static readonly IntPtr NativeFieldInfoPtr__leaseExpireTime;

		// Token: 0x0400254A RID: 9546
		private static readonly IntPtr NativeFieldInfoPtr__currentState;

		// Token: 0x0400254B RID: 9547
		private static readonly IntPtr NativeFieldInfoPtr__initialLeaseTime;

		// Token: 0x0400254C RID: 9548
		private static readonly IntPtr NativeFieldInfoPtr__renewOnCallTime;

		// Token: 0x0400254D RID: 9549
		private static readonly IntPtr NativeFieldInfoPtr__sponsorshipTimeout;

		// Token: 0x0400254E RID: 9550
		private static readonly IntPtr NativeFieldInfoPtr__sponsors;

		// Token: 0x0400254F RID: 9551
		private static readonly IntPtr NativeFieldInfoPtr__renewingSponsors;

		// Token: 0x04002550 RID: 9552
		private static readonly IntPtr NativeFieldInfoPtr__renewalDelegate;

		// Token: 0x04002551 RID: 9553
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002552 RID: 9554
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentLeaseTime_Public_Virtual_Final_New_get_TimeSpan_0;

		// Token: 0x04002553 RID: 9555
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentState_Public_Virtual_Final_New_get_LeaseState_0;

		// Token: 0x04002554 RID: 9556
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Void_0;

		// Token: 0x04002555 RID: 9557
		private static readonly IntPtr NativeMethodInfoPtr_get_RenewOnCallTime_Public_Virtual_Final_New_get_TimeSpan_0;

		// Token: 0x04002556 RID: 9558
		private static readonly IntPtr NativeMethodInfoPtr_Renew_Public_Virtual_Final_New_TimeSpan_TimeSpan_0;

		// Token: 0x04002557 RID: 9559
		private static readonly IntPtr NativeMethodInfoPtr_Unregister_Public_Virtual_Final_New_Void_ISponsor_0;

		// Token: 0x04002558 RID: 9560
		private static readonly IntPtr NativeMethodInfoPtr_UpdateState_Internal_Void_0;

		// Token: 0x04002559 RID: 9561
		private static readonly IntPtr NativeMethodInfoPtr_CheckNextSponsor_Private_Void_0;

		// Token: 0x0400255A RID: 9562
		private static readonly IntPtr NativeMethodInfoPtr_ProcessSponsorResponse_Private_Void_Object_Boolean_0;

		// Token: 0x02000668 RID: 1640
		public sealed class RenewalDelegate : MulticastDelegate
		{
			// Token: 0x06005B25 RID: 23333 RVA: 0x0019F0CC File Offset: 0x0019D2CC
			// Note: this type is marked as 'beforefieldinit'.
			static RenewalDelegate()
			{
				Il2CppClassPointerStore<Lease.RenewalDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Lease>.NativeClassPtr, "RenewalDelegate");
				Lease.RenewalDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease.RenewalDelegate>.NativeClassPtr, 100670437);
				Lease.RenewalDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TimeSpan_ILease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease.RenewalDelegate>.NativeClassPtr, 100670438);
				Lease.RenewalDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ILease_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease.RenewalDelegate>.NativeClassPtr, 100670439);
				Lease.RenewalDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_TimeSpan_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease.RenewalDelegate>.NativeClassPtr, 100670440);
			}

			// Token: 0x06005B26 RID: 23334 RVA: 0x0019F140 File Offset: 0x0019D340
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 554431, RefRangeEnd = 554456, XrefRangeStart = 554431, XrefRangeEnd = 554456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RenewalDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lease.RenewalDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.RenewalDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005B27 RID: 23335 RVA: 0x0019F19C File Offset: 0x0019D39C
			[CallerCount(0)]
			public unsafe TimeSpan Invoke(ILease lease)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(lease);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.RenewalDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TimeSpan_ILease_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005B28 RID: 23336 RVA: 0x0019F1EC File Offset: 0x0019D3EC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 479320, RefRangeEnd = 479322, XrefRangeStart = 479320, XrefRangeEnd = 479322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(ILease lease, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(lease);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.RenewalDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ILease_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06005B29 RID: 23337 RVA: 0x0019F260 File Offset: 0x0019D460
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TimeSpan EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.RenewalDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_TimeSpan_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005B2A RID: 23338 RVA: 0x00021026 File Offset: 0x0001F226
			public RenewalDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005B2B RID: 23339 RVA: 0x0002102F File Offset: 0x0001F22F
			public static implicit operator Lease.RenewalDelegate(Func<ILease, TimeSpan> A_0)
			{
				return DelegateSupport.ConvertDelegate<Lease.RenewalDelegate>(A_0);
			}

			// Token: 0x06005B2C RID: 23340 RVA: 0x00021037 File Offset: 0x0001F237
			public static Lease.RenewalDelegate operator +(Lease.RenewalDelegate A_0, Lease.RenewalDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Lease.RenewalDelegate>();
			}

			// Token: 0x06005B2D RID: 23341 RVA: 0x00021045 File Offset: 0x0001F245
			public static Lease.RenewalDelegate operator -(Lease.RenewalDelegate A_0, Lease.RenewalDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Lease.RenewalDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04004A55 RID: 19029
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04004A56 RID: 19030
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_TimeSpan_ILease_0;

			// Token: 0x04004A57 RID: 19031
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ILease_AsyncCallback_Object_0;

			// Token: 0x04004A58 RID: 19032
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_TimeSpan_IAsyncResult_0;
		}
	}
}

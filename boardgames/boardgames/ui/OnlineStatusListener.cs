using System;
using Canis.boardgames;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;

namespace boardgames.ui
{
	// Token: 0x02000123 RID: 291
	public class OnlineStatusListener : Observer
	{
		// Token: 0x06000EF2 RID: 3826 RVA: 0x0003E61C File Offset: 0x0003C81C
		// Note: this type is marked as 'beforefieldinit'.
		static OnlineStatusListener()
		{
			Il2CppClassPointerStore<OnlineStatusListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.ui", "OnlineStatusListener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnlineStatusListener>.NativeClassPtr);
			OnlineStatusListener.NativeFieldInfoPtr_statusIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineStatusListener>.NativeClassPtr, "statusIndicator");
			OnlineStatusListener.NativeFieldInfoPtr_statusMonitor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineStatusListener>.NativeClassPtr, "statusMonitor");
			OnlineStatusListener.NativeFieldInfoPtr_onlineMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineStatusListener>.NativeClassPtr, "onlineMatch");
			OnlineStatusListener.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineStatusListener>.NativeClassPtr, "initialized");
			OnlineStatusListener.NativeMethodInfoPtr_get_accountID_Private_get_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineStatusListener>.NativeClassPtr, 100665420);
			OnlineStatusListener.NativeMethodInfoPtr_get_isAI_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineStatusListener>.NativeClassPtr, 100665421);
			OnlineStatusListener.NativeMethodInfoPtr_get_isLiveMatch_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineStatusListener>.NativeClassPtr, 100665422);
			OnlineStatusListener.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineStatusListener>.NativeClassPtr, 100665423);
			OnlineStatusListener.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineStatusListener>.NativeClassPtr, 100665424);
			OnlineStatusListener.NativeMethodInfoPtr_SetInitialOnlineStatus_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineStatusListener>.NativeClassPtr, 100665425);
			OnlineStatusListener.NativeMethodInfoPtr_ShowPlayerOnline_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineStatusListener>.NativeClassPtr, 100665426);
			OnlineStatusListener.NativeMethodInfoPtr_ShowPlayerOffline_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineStatusListener>.NativeClassPtr, 100665427);
			OnlineStatusListener.NativeMethodInfoPtr_OnPlayerStatusChanged_Private_Void_AccountID_Status_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineStatusListener>.NativeClassPtr, 100665428);
			OnlineStatusListener.NativeMethodInfoPtr_SubscribeToMonitorUpdates_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineStatusListener>.NativeClassPtr, 100665429);
			OnlineStatusListener.NativeMethodInfoPtr_UnsubscribeFromMonitorUpdates_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineStatusListener>.NativeClassPtr, 100665430);
			OnlineStatusListener.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineStatusListener>.NativeClassPtr, 100665431);
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000EF3 RID: 3827 RVA: 0x0003E78C File Offset: 0x0003C98C
		public unsafe AccountID accountID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineStatusListener.NativeMethodInfoPtr_get_accountID_Private_get_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000EF4 RID: 3828 RVA: 0x0003E7CC File Offset: 0x0003C9CC
		public unsafe bool isAI
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 996857, RefRangeEnd = 996861, XrefRangeStart = 996847, XrefRangeEnd = 996857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineStatusListener.NativeMethodInfoPtr_get_isAI_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000EF5 RID: 3829 RVA: 0x0003E808 File Offset: 0x0003CA08
		public unsafe bool isLiveMatch
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996861, XrefRangeEnd = 996865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineStatusListener.NativeMethodInfoPtr_get_isLiveMatch_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x0003E844 File Offset: 0x0003CA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996865, XrefRangeEnd = 996876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineStatusListener.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x0003E878 File Offset: 0x0003CA78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996876, XrefRangeEnd = 996879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OnlineStatusListener.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x0003E8B4 File Offset: 0x0003CAB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 996943, RefRangeEnd = 996944, XrefRangeStart = 996879, XrefRangeEnd = 996943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInitialOnlineStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineStatusListener.NativeMethodInfoPtr_SetInitialOnlineStatus_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x0003E8E8 File Offset: 0x0003CAE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 996949, RefRangeEnd = 996951, XrefRangeStart = 996944, XrefRangeEnd = 996949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowPlayerOnline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineStatusListener.NativeMethodInfoPtr_ShowPlayerOnline_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x0003E91C File Offset: 0x0003CB1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996951, XrefRangeEnd = 996956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowPlayerOffline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineStatusListener.NativeMethodInfoPtr_ShowPlayerOffline_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x0003E950 File Offset: 0x0003CB50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996956, XrefRangeEnd = 996967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPlayerStatusChanged(AccountID id, PlayerOnlineStatusMonitor.Status newStatus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newStatus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineStatusListener.NativeMethodInfoPtr_OnPlayerStatusChanged_Private_Void_AccountID_Status_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x0003E9A0 File Offset: 0x0003CBA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996967, XrefRangeEnd = 996978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubscribeToMonitorUpdates()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineStatusListener.NativeMethodInfoPtr_SubscribeToMonitorUpdates_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x0003E9D4 File Offset: 0x0003CBD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnsubscribeFromMonitorUpdates()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineStatusListener.NativeMethodInfoPtr_UnsubscribeFromMonitorUpdates_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x0003EA08 File Offset: 0x0003CC08
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnlineStatusListener()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnlineStatusListener>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineStatusListener.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x00009001 File Offset: 0x00007201
		public OnlineStatusListener(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000F00 RID: 3840 RVA: 0x0003EA44 File Offset: 0x0003CC44
		// (set) Token: 0x06000F01 RID: 3841 RVA: 0x0000900A File Offset: 0x0000720A
		public unsafe OnlineStatusIndicator statusIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineStatusListener.NativeFieldInfoPtr_statusIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OnlineStatusIndicator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineStatusListener.NativeFieldInfoPtr_statusIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000F02 RID: 3842 RVA: 0x0003EA74 File Offset: 0x0003CC74
		// (set) Token: 0x06000F03 RID: 3843 RVA: 0x00009029 File Offset: 0x00007229
		public unsafe PlayerOnlineStatusMonitor statusMonitor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineStatusListener.NativeFieldInfoPtr_statusMonitor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerOnlineStatusMonitor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineStatusListener.NativeFieldInfoPtr_statusMonitor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000F04 RID: 3844 RVA: 0x0003EAA4 File Offset: 0x0003CCA4
		// (set) Token: 0x06000F05 RID: 3845 RVA: 0x00009048 File Offset: 0x00007248
		public unsafe CanisOnlineMatch onlineMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineStatusListener.NativeFieldInfoPtr_onlineMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanisOnlineMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineStatusListener.NativeFieldInfoPtr_onlineMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000F06 RID: 3846 RVA: 0x0003EAD4 File Offset: 0x0003CCD4
		// (set) Token: 0x06000F07 RID: 3847 RVA: 0x00009067 File Offset: 0x00007267
		public unsafe bool initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineStatusListener.NativeFieldInfoPtr_initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineStatusListener.NativeFieldInfoPtr_initialized)) = value;
			}
		}

		// Token: 0x04000905 RID: 2309
		private static readonly IntPtr NativeFieldInfoPtr_statusIndicator;

		// Token: 0x04000906 RID: 2310
		private static readonly IntPtr NativeFieldInfoPtr_statusMonitor;

		// Token: 0x04000907 RID: 2311
		private static readonly IntPtr NativeFieldInfoPtr_onlineMatch;

		// Token: 0x04000908 RID: 2312
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x04000909 RID: 2313
		private static readonly IntPtr NativeMethodInfoPtr_get_accountID_Private_get_AccountID_0;

		// Token: 0x0400090A RID: 2314
		private static readonly IntPtr NativeMethodInfoPtr_get_isAI_Private_get_Boolean_0;

		// Token: 0x0400090B RID: 2315
		private static readonly IntPtr NativeMethodInfoPtr_get_isLiveMatch_Private_get_Boolean_0;

		// Token: 0x0400090C RID: 2316
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400090D RID: 2317
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x0400090E RID: 2318
		private static readonly IntPtr NativeMethodInfoPtr_SetInitialOnlineStatus_Protected_Void_0;

		// Token: 0x0400090F RID: 2319
		private static readonly IntPtr NativeMethodInfoPtr_ShowPlayerOnline_Private_Void_0;

		// Token: 0x04000910 RID: 2320
		private static readonly IntPtr NativeMethodInfoPtr_ShowPlayerOffline_Private_Void_0;

		// Token: 0x04000911 RID: 2321
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayerStatusChanged_Private_Void_AccountID_Status_0;

		// Token: 0x04000912 RID: 2322
		private static readonly IntPtr NativeMethodInfoPtr_SubscribeToMonitorUpdates_Private_Void_0;

		// Token: 0x04000913 RID: 2323
		private static readonly IntPtr NativeMethodInfoPtr_UnsubscribeFromMonitorUpdates_Private_Void_0;

		// Token: 0x04000914 RID: 2324
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

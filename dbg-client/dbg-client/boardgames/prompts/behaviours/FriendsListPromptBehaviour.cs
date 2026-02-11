using System;
using boardgames.menus.prompts;
using dwd.core.data;
using dwd.core.data.composition;
using dwd.core.platform.providers;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.UI;

namespace boardgames.prompts.behaviours
{
	// Token: 0x02000100 RID: 256
	public class FriendsListPromptBehaviour : PromptBehaviour<FriendsListPrompt>
	{
		// Token: 0x06000ADF RID: 2783 RVA: 0x0004000C File Offset: 0x0003E20C
		// Note: this type is marked as 'beforefieldinit'.
		static FriendsListPromptBehaviour()
		{
			Il2CppClassPointerStore<FriendsListPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.prompts.behaviours", "FriendsListPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendsListPromptBehaviour>.NativeClassPtr);
			FriendsListPromptBehaviour.NativeFieldInfoPtr_savedScrollPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListPromptBehaviour>.NativeClassPtr, "savedScrollPosition");
			FriendsListPromptBehaviour.NativeFieldInfoPtr_mScrollFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListPromptBehaviour>.NativeClassPtr, "mScrollFrames");
			FriendsListPromptBehaviour.NativeFieldInfoPtr_invitesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListPromptBehaviour>.NativeClassPtr, "invitesProvider");
			FriendsListPromptBehaviour.NativeFieldInfoPtr_onlineFriendsProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListPromptBehaviour>.NativeClassPtr, "onlineFriendsProvider");
			FriendsListPromptBehaviour.NativeFieldInfoPtr_offlineFriendsProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListPromptBehaviour>.NativeClassPtr, "offlineFriendsProvider");
			FriendsListPromptBehaviour.NativeFieldInfoPtr_provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListPromptBehaviour>.NativeClassPtr, "provider");
			FriendsListPromptBehaviour.NativeFieldInfoPtr_selectedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListPromptBehaviour>.NativeClassPtr, "selectedData");
			FriendsListPromptBehaviour.NativeFieldInfoPtr_scrollData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListPromptBehaviour>.NativeClassPtr, "scrollData");
			FriendsListPromptBehaviour.NativeFieldInfoPtr_scrollView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListPromptBehaviour>.NativeClassPtr, "scrollView");
			FriendsListPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListPromptBehaviour>.NativeClassPtr, 100664886);
			FriendsListPromptBehaviour.NativeMethodInfoPtr_ScrollToPosition_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListPromptBehaviour>.NativeClassPtr, 100664887);
			FriendsListPromptBehaviour.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListPromptBehaviour>.NativeClassPtr, 100664888);
			FriendsListPromptBehaviour.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListPromptBehaviour>.NativeClassPtr, 100664889);
			FriendsListPromptBehaviour.NativeMethodInfoPtr_UpdateSelectedData_Public_Virtual_New_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListPromptBehaviour>.NativeClassPtr, 100664890);
			FriendsListPromptBehaviour.NativeMethodInfoPtr_Event_AddFriend_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListPromptBehaviour>.NativeClassPtr, 100664891);
			FriendsListPromptBehaviour.NativeMethodInfoPtr_Event_RemoveFriend_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListPromptBehaviour>.NativeClassPtr, 100664892);
			FriendsListPromptBehaviour.NativeMethodInfoPtr_Event_InviteFriend_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListPromptBehaviour>.NativeClassPtr, 100664893);
			FriendsListPromptBehaviour.NativeMethodInfoPtr_Event_OnScrolled_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListPromptBehaviour>.NativeClassPtr, 100664894);
			FriendsListPromptBehaviour.NativeMethodInfoPtr_updateFriendsData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListPromptBehaviour>.NativeClassPtr, 100664895);
			FriendsListPromptBehaviour.NativeMethodInfoPtr_updateInvitationsData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListPromptBehaviour>.NativeClassPtr, 100664896);
			FriendsListPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListPromptBehaviour>.NativeClassPtr, 100664897);
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x000401E0 File Offset: 0x0003E3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507325, XrefRangeEnd = 507435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendsListPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x0004021C File Offset: 0x0003E41C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507435, XrefRangeEnd = 507440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ScrollToPosition(float position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListPromptBehaviour.NativeMethodInfoPtr_ScrollToPosition_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x00040268 File Offset: 0x0003E468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507440, XrefRangeEnd = 507456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListPromptBehaviour.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x0004029C File Offset: 0x0003E49C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507456, XrefRangeEnd = 507473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListPromptBehaviour.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x000402D0 File Offset: 0x0003E4D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507473, XrefRangeEnd = 507479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateSelectedData(DataComposition data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendsListPromptBehaviour.NativeMethodInfoPtr_UpdateSelectedData_Public_Virtual_New_Void_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x00040320 File Offset: 0x0003E520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507479, XrefRangeEnd = 507484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_AddFriend()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListPromptBehaviour.NativeMethodInfoPtr_Event_AddFriend_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x00040354 File Offset: 0x0003E554
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 507489, RefRangeEnd = 507490, XrefRangeStart = 507484, XrefRangeEnd = 507489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_RemoveFriend()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListPromptBehaviour.NativeMethodInfoPtr_Event_RemoveFriend_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00040388 File Offset: 0x0003E588
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 507495, RefRangeEnd = 507496, XrefRangeStart = 507490, XrefRangeEnd = 507495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_InviteFriend()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListPromptBehaviour.NativeMethodInfoPtr_Event_InviteFriend_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x000403BC File Offset: 0x0003E5BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507496, XrefRangeEnd = 507501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_OnScrolled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListPromptBehaviour.NativeMethodInfoPtr_Event_OnScrolled_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x000403F0 File Offset: 0x0003E5F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 507565, RefRangeEnd = 507566, XrefRangeStart = 507501, XrefRangeEnd = 507565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updateFriendsData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListPromptBehaviour.NativeMethodInfoPtr_updateFriendsData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00040424 File Offset: 0x0003E624
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 507591, RefRangeEnd = 507592, XrefRangeStart = 507566, XrefRangeEnd = 507591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updateInvitationsData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListPromptBehaviour.NativeMethodInfoPtr_updateInvitationsData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x00040458 File Offset: 0x0003E658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507592, XrefRangeEnd = 507595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FriendsListPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendsListPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x000072B9 File Offset: 0x000054B9
		public FriendsListPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000AED RID: 2797 RVA: 0x00040494 File Offset: 0x0003E694
		// (set) Token: 0x06000AEE RID: 2798 RVA: 0x000072C2 File Offset: 0x000054C2
		public unsafe static float savedScrollPosition
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(FriendsListPromptBehaviour.NativeFieldInfoPtr_savedScrollPosition, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FriendsListPromptBehaviour.NativeFieldInfoPtr_savedScrollPosition, (void*)(&value));
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x000404B0 File Offset: 0x0003E6B0
		// (set) Token: 0x06000AF0 RID: 2800 RVA: 0x000072D0 File Offset: 0x000054D0
		public unsafe int mScrollFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListPromptBehaviour.NativeFieldInfoPtr_mScrollFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListPromptBehaviour.NativeFieldInfoPtr_mScrollFrames)) = value;
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x000404D8 File Offset: 0x0003E6D8
		// (set) Token: 0x06000AF2 RID: 2802 RVA: 0x000072EB File Offset: 0x000054EB
		public unsafe SubscriptionProvider invitesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListPromptBehaviour.NativeFieldInfoPtr_invitesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListPromptBehaviour.NativeFieldInfoPtr_invitesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x00040508 File Offset: 0x0003E708
		// (set) Token: 0x06000AF4 RID: 2804 RVA: 0x0000730A File Offset: 0x0000550A
		public unsafe SubscriptionProvider onlineFriendsProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListPromptBehaviour.NativeFieldInfoPtr_onlineFriendsProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListPromptBehaviour.NativeFieldInfoPtr_onlineFriendsProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x00040538 File Offset: 0x0003E738
		// (set) Token: 0x06000AF6 RID: 2806 RVA: 0x00007329 File Offset: 0x00005529
		public unsafe SubscriptionProvider offlineFriendsProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListPromptBehaviour.NativeFieldInfoPtr_offlineFriendsProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListPromptBehaviour.NativeFieldInfoPtr_offlineFriendsProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x00040568 File Offset: 0x0003E768
		// (set) Token: 0x06000AF8 RID: 2808 RVA: 0x00007348 File Offset: 0x00005548
		public unsafe PlatformProvider provider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListPromptBehaviour.NativeFieldInfoPtr_provider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListPromptBehaviour.NativeFieldInfoPtr_provider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x00040598 File Offset: 0x0003E798
		// (set) Token: 0x06000AFA RID: 2810 RVA: 0x00007367 File Offset: 0x00005567
		public unsafe SelectedData<DataComposition> selectedData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListPromptBehaviour.NativeFieldInfoPtr_selectedData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectedData<DataComposition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListPromptBehaviour.NativeFieldInfoPtr_selectedData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x000405C8 File Offset: 0x0003E7C8
		// (set) Token: 0x06000AFC RID: 2812 RVA: 0x00007386 File Offset: 0x00005586
		public unsafe ScrollPositionData scrollData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListPromptBehaviour.NativeFieldInfoPtr_scrollData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollPositionData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListPromptBehaviour.NativeFieldInfoPtr_scrollData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000AFD RID: 2813 RVA: 0x000405F8 File Offset: 0x0003E7F8
		// (set) Token: 0x06000AFE RID: 2814 RVA: 0x000073A5 File Offset: 0x000055A5
		public unsafe ScrollRect scrollView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListPromptBehaviour.NativeFieldInfoPtr_scrollView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListPromptBehaviour.NativeFieldInfoPtr_scrollView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006AD RID: 1709
		private static readonly IntPtr NativeFieldInfoPtr_savedScrollPosition;

		// Token: 0x040006AE RID: 1710
		private static readonly IntPtr NativeFieldInfoPtr_mScrollFrames;

		// Token: 0x040006AF RID: 1711
		private static readonly IntPtr NativeFieldInfoPtr_invitesProvider;

		// Token: 0x040006B0 RID: 1712
		private static readonly IntPtr NativeFieldInfoPtr_onlineFriendsProvider;

		// Token: 0x040006B1 RID: 1713
		private static readonly IntPtr NativeFieldInfoPtr_offlineFriendsProvider;

		// Token: 0x040006B2 RID: 1714
		private static readonly IntPtr NativeFieldInfoPtr_provider;

		// Token: 0x040006B3 RID: 1715
		private static readonly IntPtr NativeFieldInfoPtr_selectedData;

		// Token: 0x040006B4 RID: 1716
		private static readonly IntPtr NativeFieldInfoPtr_scrollData;

		// Token: 0x040006B5 RID: 1717
		private static readonly IntPtr NativeFieldInfoPtr_scrollView;

		// Token: 0x040006B6 RID: 1718
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x040006B7 RID: 1719
		private static readonly IntPtr NativeMethodInfoPtr_ScrollToPosition_Private_IEnumerator_Single_0;

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSelectedData_Public_Virtual_New_Void_DataComposition_0;

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeMethodInfoPtr_Event_AddFriend_Public_Void_0;

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeMethodInfoPtr_Event_RemoveFriend_Public_Void_0;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeMethodInfoPtr_Event_InviteFriend_Public_Void_0;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeMethodInfoPtr_Event_OnScrolled_Public_Void_0;

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeMethodInfoPtr_updateFriendsData_Private_Void_0;

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeMethodInfoPtr_updateInvitationsData_Private_Void_0;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200033E RID: 830
		[ObfuscatedName("boardgames.prompts.behaviours.FriendsListPromptBehaviour+<ScrollToPosition>d__10")]
		public sealed class _ScrollToPosition_d__10 : Object
		{
			// Token: 0x06002746 RID: 10054 RVA: 0x0009DF34 File Offset: 0x0009C134
			// Note: this type is marked as 'beforefieldinit'.
			static _ScrollToPosition_d__10()
			{
				Il2CppClassPointerStore<FriendsListPromptBehaviour._ScrollToPosition_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FriendsListPromptBehaviour>.NativeClassPtr, "<ScrollToPosition>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendsListPromptBehaviour._ScrollToPosition_d__10>.NativeClassPtr);
				FriendsListPromptBehaviour._ScrollToPosition_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListPromptBehaviour._ScrollToPosition_d__10>.NativeClassPtr, "<>1__state");
				FriendsListPromptBehaviour._ScrollToPosition_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListPromptBehaviour._ScrollToPosition_d__10>.NativeClassPtr, "<>2__current");
				FriendsListPromptBehaviour._ScrollToPosition_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListPromptBehaviour._ScrollToPosition_d__10>.NativeClassPtr, "<>4__this");
				FriendsListPromptBehaviour._ScrollToPosition_d__10.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListPromptBehaviour._ScrollToPosition_d__10>.NativeClassPtr, "position");
				FriendsListPromptBehaviour._ScrollToPosition_d__10.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListPromptBehaviour._ScrollToPosition_d__10>.NativeClassPtr, "<i>5__2");
				FriendsListPromptBehaviour._ScrollToPosition_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListPromptBehaviour._ScrollToPosition_d__10>.NativeClassPtr, 100664899);
				FriendsListPromptBehaviour._ScrollToPosition_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListPromptBehaviour._ScrollToPosition_d__10>.NativeClassPtr, 100664900);
				FriendsListPromptBehaviour._ScrollToPosition_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListPromptBehaviour._ScrollToPosition_d__10>.NativeClassPtr, 100664901);
				FriendsListPromptBehaviour._ScrollToPosition_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListPromptBehaviour._ScrollToPosition_d__10>.NativeClassPtr, 100664902);
				FriendsListPromptBehaviour._ScrollToPosition_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListPromptBehaviour._ScrollToPosition_d__10>.NativeClassPtr, 100664903);
				FriendsListPromptBehaviour._ScrollToPosition_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListPromptBehaviour._ScrollToPosition_d__10>.NativeClassPtr, 100664904);
			}

			// Token: 0x06002747 RID: 10055 RVA: 0x0009E03C File Offset: 0x0009C23C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ScrollToPosition_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendsListPromptBehaviour._ScrollToPosition_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListPromptBehaviour._ScrollToPosition_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002748 RID: 10056 RVA: 0x0009E084 File Offset: 0x0009C284
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListPromptBehaviour._ScrollToPosition_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002749 RID: 10057 RVA: 0x0009E0B8 File Offset: 0x0009C2B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507317, XrefRangeEnd = 507320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListPromptBehaviour._ScrollToPosition_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000AF8 RID: 2808
			// (get) Token: 0x0600274A RID: 10058 RVA: 0x0009E0F4 File Offset: 0x0009C2F4
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListPromptBehaviour._ScrollToPosition_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600274B RID: 10059 RVA: 0x0009E134 File Offset: 0x0009C334
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507320, XrefRangeEnd = 507325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListPromptBehaviour._ScrollToPosition_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AF9 RID: 2809
			// (get) Token: 0x0600274C RID: 10060 RVA: 0x0009E168 File Offset: 0x0009C368
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListPromptBehaviour._ScrollToPosition_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600274D RID: 10061 RVA: 0x00014629 File Offset: 0x00012829
			public _ScrollToPosition_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AF3 RID: 2803
			// (get) Token: 0x0600274E RID: 10062 RVA: 0x0009E1A8 File Offset: 0x0009C3A8
			// (set) Token: 0x0600274F RID: 10063 RVA: 0x00014632 File Offset: 0x00012832
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListPromptBehaviour._ScrollToPosition_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListPromptBehaviour._ScrollToPosition_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AF4 RID: 2804
			// (get) Token: 0x06002750 RID: 10064 RVA: 0x0009E1D0 File Offset: 0x0009C3D0
			// (set) Token: 0x06002751 RID: 10065 RVA: 0x0001464D File Offset: 0x0001284D
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListPromptBehaviour._ScrollToPosition_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListPromptBehaviour._ScrollToPosition_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AF5 RID: 2805
			// (get) Token: 0x06002752 RID: 10066 RVA: 0x0009E200 File Offset: 0x0009C400
			// (set) Token: 0x06002753 RID: 10067 RVA: 0x0001466C File Offset: 0x0001286C
			public unsafe FriendsListPromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListPromptBehaviour._ScrollToPosition_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FriendsListPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListPromptBehaviour._ScrollToPosition_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AF6 RID: 2806
			// (get) Token: 0x06002754 RID: 10068 RVA: 0x0009E230 File Offset: 0x0009C430
			// (set) Token: 0x06002755 RID: 10069 RVA: 0x0001468B File Offset: 0x0001288B
			public unsafe float position
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListPromptBehaviour._ScrollToPosition_d__10.NativeFieldInfoPtr_position);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListPromptBehaviour._ScrollToPosition_d__10.NativeFieldInfoPtr_position)) = value;
				}
			}

			// Token: 0x17000AF7 RID: 2807
			// (get) Token: 0x06002756 RID: 10070 RVA: 0x0009E258 File Offset: 0x0009C458
			// (set) Token: 0x06002757 RID: 10071 RVA: 0x000146A6 File Offset: 0x000128A6
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListPromptBehaviour._ScrollToPosition_d__10.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListPromptBehaviour._ScrollToPosition_d__10.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x040018A4 RID: 6308
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040018A5 RID: 6309
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040018A6 RID: 6310
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040018A7 RID: 6311
			private static readonly IntPtr NativeFieldInfoPtr_position;

			// Token: 0x040018A8 RID: 6312
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x040018A9 RID: 6313
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040018AA RID: 6314
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018AB RID: 6315
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040018AC RID: 6316
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040018AD RID: 6317
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018AE RID: 6318
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

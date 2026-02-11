using System;
using dwd.core.data;
using dwd.core.data.composition;
using dwd.core.platform.providers;
using dwd.core.platform.websocket.incoming;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.UI;

namespace dbgclient.prompts
{
	// Token: 0x02000091 RID: 145
	public class FriendGameInvitePromptBehaviour : PromptBehaviour<FriendGameInvitePrompt>
	{
		// Token: 0x060005A4 RID: 1444 RVA: 0x0002F8CC File Offset: 0x0002DACC
		// Note: this type is marked as 'beforefieldinit'.
		static FriendGameInvitePromptBehaviour()
		{
			Il2CppClassPointerStore<FriendGameInvitePromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.prompts", "FriendGameInvitePromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour>.NativeClassPtr);
			FriendGameInvitePromptBehaviour.NativeFieldInfoPtr_savedScrollPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour>.NativeClassPtr, "savedScrollPosition");
			FriendGameInvitePromptBehaviour.NativeFieldInfoPtr_mScrollFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour>.NativeClassPtr, "mScrollFrames");
			FriendGameInvitePromptBehaviour.NativeFieldInfoPtr_friendsProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour>.NativeClassPtr, "friendsProvider");
			FriendGameInvitePromptBehaviour.NativeFieldInfoPtr_provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour>.NativeClassPtr, "provider");
			FriendGameInvitePromptBehaviour.NativeFieldInfoPtr_selectedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour>.NativeClassPtr, "selectedData");
			FriendGameInvitePromptBehaviour.NativeFieldInfoPtr_scrollData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour>.NativeClassPtr, "scrollData");
			FriendGameInvitePromptBehaviour.NativeFieldInfoPtr_scrollView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour>.NativeClassPtr, "scrollView");
			FriendGameInvitePromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour>.NativeClassPtr, 100664176);
			FriendGameInvitePromptBehaviour.NativeMethodInfoPtr_ScrollToPosition_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour>.NativeClassPtr, 100664177);
			FriendGameInvitePromptBehaviour.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour>.NativeClassPtr, 100664178);
			FriendGameInvitePromptBehaviour.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour>.NativeClassPtr, 100664179);
			FriendGameInvitePromptBehaviour.NativeMethodInfoPtr_UpdateSelectedData_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour>.NativeClassPtr, 100664180);
			FriendGameInvitePromptBehaviour.NativeMethodInfoPtr_Event_Confirm_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour>.NativeClassPtr, 100664181);
			FriendGameInvitePromptBehaviour.NativeMethodInfoPtr_Event_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour>.NativeClassPtr, 100664182);
			FriendGameInvitePromptBehaviour.NativeMethodInfoPtr_Event_OnScrolled_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour>.NativeClassPtr, 100664183);
			FriendGameInvitePromptBehaviour.NativeMethodInfoPtr_updateFriendsData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour>.NativeClassPtr, 100664184);
			FriendGameInvitePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour>.NativeClassPtr, 100664185);
			FriendGameInvitePromptBehaviour.NativeMethodInfoPtr__updateFriendsData_b__15_1_Private_Boolean_RosterEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour>.NativeClassPtr, 100664186);
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0002FA64 File Offset: 0x0002DC64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502248, XrefRangeEnd = 502284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendGameInvitePromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0002FAA0 File Offset: 0x0002DCA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502284, XrefRangeEnd = 502289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ScrollToPosition(float position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameInvitePromptBehaviour.NativeMethodInfoPtr_ScrollToPosition_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0002FAEC File Offset: 0x0002DCEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502289, XrefRangeEnd = 502299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameInvitePromptBehaviour.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0002FB20 File Offset: 0x0002DD20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502299, XrefRangeEnd = 502310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameInvitePromptBehaviour.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0002FB54 File Offset: 0x0002DD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502310, XrefRangeEnd = 502314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSelectedData(DataComposition data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameInvitePromptBehaviour.NativeMethodInfoPtr_UpdateSelectedData_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0002FB98 File Offset: 0x0002DD98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502314, XrefRangeEnd = 502332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Confirm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameInvitePromptBehaviour.NativeMethodInfoPtr_Event_Confirm_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x0002FBCC File Offset: 0x0002DDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502332, XrefRangeEnd = 502349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameInvitePromptBehaviour.NativeMethodInfoPtr_Event_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0002FC00 File Offset: 0x0002DE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502349, XrefRangeEnd = 502352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_OnScrolled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameInvitePromptBehaviour.NativeMethodInfoPtr_Event_OnScrolled_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x0002FC34 File Offset: 0x0002DE34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 502388, RefRangeEnd = 502389, XrefRangeStart = 502352, XrefRangeEnd = 502388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updateFriendsData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameInvitePromptBehaviour.NativeMethodInfoPtr_updateFriendsData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0002FC68 File Offset: 0x0002DE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502389, XrefRangeEnd = 502392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FriendGameInvitePromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameInvitePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x0002FCA4 File Offset: 0x0002DEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502392, XrefRangeEnd = 502402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _updateFriendsData_b__15_1(RosterEntry f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameInvitePromptBehaviour.NativeMethodInfoPtr__updateFriendsData_b__15_1_Private_Boolean_RosterEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00004821 File Offset: 0x00002A21
		public FriendGameInvitePromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x0002FCF4 File Offset: 0x0002DEF4
		// (set) Token: 0x060005B2 RID: 1458 RVA: 0x0000482A File Offset: 0x00002A2A
		public unsafe static float savedScrollPosition
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(FriendGameInvitePromptBehaviour.NativeFieldInfoPtr_savedScrollPosition, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FriendGameInvitePromptBehaviour.NativeFieldInfoPtr_savedScrollPosition, (void*)(&value));
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x0002FD10 File Offset: 0x0002DF10
		// (set) Token: 0x060005B4 RID: 1460 RVA: 0x00004838 File Offset: 0x00002A38
		public unsafe int mScrollFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameInvitePromptBehaviour.NativeFieldInfoPtr_mScrollFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameInvitePromptBehaviour.NativeFieldInfoPtr_mScrollFrames)) = value;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x0002FD38 File Offset: 0x0002DF38
		// (set) Token: 0x060005B6 RID: 1462 RVA: 0x00004853 File Offset: 0x00002A53
		public unsafe SubscriptionProvider friendsProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameInvitePromptBehaviour.NativeFieldInfoPtr_friendsProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameInvitePromptBehaviour.NativeFieldInfoPtr_friendsProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x0002FD68 File Offset: 0x0002DF68
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x00004872 File Offset: 0x00002A72
		public unsafe PlatformProvider provider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameInvitePromptBehaviour.NativeFieldInfoPtr_provider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameInvitePromptBehaviour.NativeFieldInfoPtr_provider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x0002FD98 File Offset: 0x0002DF98
		// (set) Token: 0x060005BA RID: 1466 RVA: 0x00004891 File Offset: 0x00002A91
		public unsafe SelectedData<DataComposition> selectedData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameInvitePromptBehaviour.NativeFieldInfoPtr_selectedData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectedData<DataComposition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameInvitePromptBehaviour.NativeFieldInfoPtr_selectedData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x0002FDC8 File Offset: 0x0002DFC8
		// (set) Token: 0x060005BC RID: 1468 RVA: 0x000048B0 File Offset: 0x00002AB0
		public unsafe ScrollPositionData scrollData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameInvitePromptBehaviour.NativeFieldInfoPtr_scrollData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollPositionData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameInvitePromptBehaviour.NativeFieldInfoPtr_scrollData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x0002FDF8 File Offset: 0x0002DFF8
		// (set) Token: 0x060005BE RID: 1470 RVA: 0x000048CF File Offset: 0x00002ACF
		public unsafe ScrollRect scrollView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameInvitePromptBehaviour.NativeFieldInfoPtr_scrollView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameInvitePromptBehaviour.NativeFieldInfoPtr_scrollView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeFieldInfoPtr_savedScrollPosition;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeFieldInfoPtr_mScrollFrames;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeFieldInfoPtr_friendsProvider;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeFieldInfoPtr_provider;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeFieldInfoPtr_selectedData;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeFieldInfoPtr_scrollData;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeFieldInfoPtr_scrollView;

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeMethodInfoPtr_ScrollToPosition_Private_IEnumerator_Single_0;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSelectedData_Public_Void_DataComposition_0;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeMethodInfoPtr_Event_Confirm_Public_Void_0;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeMethodInfoPtr_Event_Cancel_Public_Void_0;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeMethodInfoPtr_Event_OnScrolled_Public_Void_0;

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeMethodInfoPtr_updateFriendsData_Private_Void_0;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeMethodInfoPtr__updateFriendsData_b__15_1_Private_Boolean_RosterEntry_0;

		// Token: 0x02000306 RID: 774
		[ObfuscatedName("dbgclient.prompts.FriendGameInvitePromptBehaviour+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060024A4 RID: 9380 RVA: 0x0009602C File Offset: 0x0009422C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FriendGameInvitePromptBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour.__c>.NativeClassPtr);
				FriendGameInvitePromptBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour.__c>.NativeClassPtr, "<>9");
				FriendGameInvitePromptBehaviour.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour.__c>.NativeClassPtr, "<>9__15_0");
				FriendGameInvitePromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour.__c>.NativeClassPtr, 100664188);
				FriendGameInvitePromptBehaviour.__c.NativeMethodInfoPtr__updateFriendsData_b__15_0_Internal_Boolean_RosterEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour.__c>.NativeClassPtr, 100664189);
			}

			// Token: 0x060024A5 RID: 9381 RVA: 0x000960A8 File Offset: 0x000942A8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameInvitePromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060024A6 RID: 9382 RVA: 0x000960E4 File Offset: 0x000942E4
			[CallerCount(0)]
			public unsafe bool _updateFriendsData_b__15_0(RosterEntry f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameInvitePromptBehaviour.__c.NativeMethodInfoPtr__updateFriendsData_b__15_0_Internal_Boolean_RosterEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060024A7 RID: 9383 RVA: 0x00013145 File Offset: 0x00011345
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A0B RID: 2571
			// (get) Token: 0x060024A8 RID: 9384 RVA: 0x00096134 File Offset: 0x00094334
			// (set) Token: 0x060024A9 RID: 9385 RVA: 0x0001314E File Offset: 0x0001134E
			public unsafe static FriendGameInvitePromptBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FriendGameInvitePromptBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FriendGameInvitePromptBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FriendGameInvitePromptBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A0C RID: 2572
			// (get) Token: 0x060024AA RID: 9386 RVA: 0x0009615C File Offset: 0x0009435C
			// (set) Token: 0x060024AB RID: 9387 RVA: 0x00013160 File Offset: 0x00011360
			public unsafe static Func<RosterEntry, bool> __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FriendGameInvitePromptBehaviour.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RosterEntry, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FriendGameInvitePromptBehaviour.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001702 RID: 5890
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001703 RID: 5891
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x04001704 RID: 5892
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001705 RID: 5893
			private static readonly IntPtr NativeMethodInfoPtr__updateFriendsData_b__15_0_Internal_Boolean_RosterEntry_0;
		}

		// Token: 0x02000307 RID: 775
		[ObfuscatedName("dbgclient.prompts.FriendGameInvitePromptBehaviour+<ScrollToPosition>d__8")]
		public sealed class _ScrollToPosition_d__8 : Object
		{
			// Token: 0x060024AC RID: 9388 RVA: 0x00096184 File Offset: 0x00094384
			// Note: this type is marked as 'beforefieldinit'.
			static _ScrollToPosition_d__8()
			{
				Il2CppClassPointerStore<FriendGameInvitePromptBehaviour._ScrollToPosition_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour>.NativeClassPtr, "<ScrollToPosition>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour._ScrollToPosition_d__8>.NativeClassPtr);
				FriendGameInvitePromptBehaviour._ScrollToPosition_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour._ScrollToPosition_d__8>.NativeClassPtr, "<>1__state");
				FriendGameInvitePromptBehaviour._ScrollToPosition_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour._ScrollToPosition_d__8>.NativeClassPtr, "<>2__current");
				FriendGameInvitePromptBehaviour._ScrollToPosition_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour._ScrollToPosition_d__8>.NativeClassPtr, "<>4__this");
				FriendGameInvitePromptBehaviour._ScrollToPosition_d__8.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour._ScrollToPosition_d__8>.NativeClassPtr, "position");
				FriendGameInvitePromptBehaviour._ScrollToPosition_d__8.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour._ScrollToPosition_d__8>.NativeClassPtr, "<i>5__2");
				FriendGameInvitePromptBehaviour._ScrollToPosition_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour._ScrollToPosition_d__8>.NativeClassPtr, 100664190);
				FriendGameInvitePromptBehaviour._ScrollToPosition_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour._ScrollToPosition_d__8>.NativeClassPtr, 100664191);
				FriendGameInvitePromptBehaviour._ScrollToPosition_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour._ScrollToPosition_d__8>.NativeClassPtr, 100664192);
				FriendGameInvitePromptBehaviour._ScrollToPosition_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour._ScrollToPosition_d__8>.NativeClassPtr, 100664193);
				FriendGameInvitePromptBehaviour._ScrollToPosition_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour._ScrollToPosition_d__8>.NativeClassPtr, 100664194);
				FriendGameInvitePromptBehaviour._ScrollToPosition_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour._ScrollToPosition_d__8>.NativeClassPtr, 100664195);
			}

			// Token: 0x060024AD RID: 9389 RVA: 0x0009628C File Offset: 0x0009448C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ScrollToPosition_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendGameInvitePromptBehaviour._ScrollToPosition_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameInvitePromptBehaviour._ScrollToPosition_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060024AE RID: 9390 RVA: 0x000962D4 File Offset: 0x000944D4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameInvitePromptBehaviour._ScrollToPosition_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060024AF RID: 9391 RVA: 0x00096308 File Offset: 0x00094508
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502240, XrefRangeEnd = 502243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameInvitePromptBehaviour._ScrollToPosition_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A12 RID: 2578
			// (get) Token: 0x060024B0 RID: 9392 RVA: 0x00096344 File Offset: 0x00094544
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameInvitePromptBehaviour._ScrollToPosition_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060024B1 RID: 9393 RVA: 0x00096384 File Offset: 0x00094584
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502243, XrefRangeEnd = 502248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameInvitePromptBehaviour._ScrollToPosition_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A13 RID: 2579
			// (get) Token: 0x060024B2 RID: 9394 RVA: 0x000963B8 File Offset: 0x000945B8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameInvitePromptBehaviour._ScrollToPosition_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060024B3 RID: 9395 RVA: 0x00013172 File Offset: 0x00011372
			public _ScrollToPosition_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A0D RID: 2573
			// (get) Token: 0x060024B4 RID: 9396 RVA: 0x000963F8 File Offset: 0x000945F8
			// (set) Token: 0x060024B5 RID: 9397 RVA: 0x0001317B File Offset: 0x0001137B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameInvitePromptBehaviour._ScrollToPosition_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameInvitePromptBehaviour._ScrollToPosition_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A0E RID: 2574
			// (get) Token: 0x060024B6 RID: 9398 RVA: 0x00096420 File Offset: 0x00094620
			// (set) Token: 0x060024B7 RID: 9399 RVA: 0x00013196 File Offset: 0x00011396
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameInvitePromptBehaviour._ScrollToPosition_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameInvitePromptBehaviour._ScrollToPosition_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A0F RID: 2575
			// (get) Token: 0x060024B8 RID: 9400 RVA: 0x00096450 File Offset: 0x00094650
			// (set) Token: 0x060024B9 RID: 9401 RVA: 0x000131B5 File Offset: 0x000113B5
			public unsafe FriendGameInvitePromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameInvitePromptBehaviour._ScrollToPosition_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FriendGameInvitePromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameInvitePromptBehaviour._ScrollToPosition_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A10 RID: 2576
			// (get) Token: 0x060024BA RID: 9402 RVA: 0x00096480 File Offset: 0x00094680
			// (set) Token: 0x060024BB RID: 9403 RVA: 0x000131D4 File Offset: 0x000113D4
			public unsafe float position
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameInvitePromptBehaviour._ScrollToPosition_d__8.NativeFieldInfoPtr_position);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameInvitePromptBehaviour._ScrollToPosition_d__8.NativeFieldInfoPtr_position)) = value;
				}
			}

			// Token: 0x17000A11 RID: 2577
			// (get) Token: 0x060024BC RID: 9404 RVA: 0x000964A8 File Offset: 0x000946A8
			// (set) Token: 0x060024BD RID: 9405 RVA: 0x000131EF File Offset: 0x000113EF
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameInvitePromptBehaviour._ScrollToPosition_d__8.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameInvitePromptBehaviour._ScrollToPosition_d__8.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x04001706 RID: 5894
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001707 RID: 5895
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001708 RID: 5896
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001709 RID: 5897
			private static readonly IntPtr NativeFieldInfoPtr_position;

			// Token: 0x0400170A RID: 5898
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x0400170B RID: 5899
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400170C RID: 5900
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400170D RID: 5901
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400170E RID: 5902
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400170F RID: 5903
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001710 RID: 5904
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

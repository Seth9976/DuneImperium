using System;
using boardgames.data;
using boardgames.menus.commands;
using boardgames.utils;
using Canis;
using dwd.core.commands;
using dwd.core.data.composition;
using dwd.core.ui.prompt.behaviours;
using dwd.iap.store;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace boardgames.menus.prompts
{
	// Token: 0x020001DD RID: 477
	public class TutorialSelectPromptBehaviour : PromptBehaviour<TutorialSelectPrompt>
	{
		// Token: 0x0600160A RID: 5642 RVA: 0x00064AE0 File Offset: 0x00062CE0
		// Note: this type is marked as 'beforefieldinit'.
		static TutorialSelectPromptBehaviour()
		{
			Il2CppClassPointerStore<TutorialSelectPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "TutorialSelectPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialSelectPromptBehaviour>.NativeClassPtr);
			TutorialSelectPromptBehaviour.NativeFieldInfoPtr_matchPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSelectPromptBehaviour>.NativeClassPtr, "matchPrefab");
			TutorialSelectPromptBehaviour.NativeFieldInfoPtr_matchSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSelectPromptBehaviour>.NativeClassPtr, "matchSeparator");
			TutorialSelectPromptBehaviour.NativeFieldInfoPtr_practiceScenarioKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSelectPromptBehaviour>.NativeClassPtr, "practiceScenarioKey");
			TutorialSelectPromptBehaviour.NativeFieldInfoPtr_lastTutorialScenarioKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSelectPromptBehaviour>.NativeClassPtr, "lastTutorialScenarioKey");
			TutorialSelectPromptBehaviour.NativeFieldInfoPtr_practicePromptScenarioKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSelectPromptBehaviour>.NativeClassPtr, "practicePromptScenarioKey");
			TutorialSelectPromptBehaviour.NativeFieldInfoPtr_matchInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSelectPromptBehaviour>.NativeClassPtr, "matchInstances");
			TutorialSelectPromptBehaviour.NativeFieldInfoPtr_iapStoreBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSelectPromptBehaviour>.NativeClassPtr, "iapStoreBehaviour");
			TutorialSelectPromptBehaviour.NativeFieldInfoPtr_productUtils = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSelectPromptBehaviour>.NativeClassPtr, "productUtils");
			TutorialSelectPromptBehaviour.NativeFieldInfoPtr_offlineMatchesManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSelectPromptBehaviour>.NativeClassPtr, "offlineMatchesManager");
			TutorialSelectPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectPromptBehaviour>.NativeClassPtr, 100666516);
			TutorialSelectPromptBehaviour.NativeMethodInfoPtr_SetupTutorials_Protected_Virtual_New_Void_List_1_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectPromptBehaviour>.NativeClassPtr, 100666517);
			TutorialSelectPromptBehaviour.NativeMethodInfoPtr_MeetOwnershipRequirements_Private_Boolean_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectPromptBehaviour>.NativeClassPtr, 100666518);
			TutorialSelectPromptBehaviour.NativeMethodInfoPtr_Event_Play_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectPromptBehaviour>.NativeClassPtr, 100666519);
			TutorialSelectPromptBehaviour.NativeMethodInfoPtr_play_Protected_IEnumerator_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectPromptBehaviour>.NativeClassPtr, 100666520);
			TutorialSelectPromptBehaviour.NativeMethodInfoPtr_Event_PlayPractice_Public_Void_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectPromptBehaviour>.NativeClassPtr, 100666521);
			TutorialSelectPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectPromptBehaviour>.NativeClassPtr, 100666522);
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x00064C50 File Offset: 0x00062E50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523508, XrefRangeEnd = 523575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TutorialSelectPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x00064C8C File Offset: 0x00062E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523575, XrefRangeEnd = 523677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetupTutorials(List<MatchInitData> tutorials)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tutorials);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TutorialSelectPromptBehaviour.NativeMethodInfoPtr_SetupTutorials_Protected_Virtual_New_Void_List_1_MatchInitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x00064CDC File Offset: 0x00062EDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 523703, RefRangeEnd = 523704, XrefRangeStart = 523677, XrefRangeEnd = 523703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MeetOwnershipRequirements(MatchInitData tutorial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tutorial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialSelectPromptBehaviour.NativeMethodInfoPtr_MeetOwnershipRequirements_Private_Boolean_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x00064D2C File Offset: 0x00062F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523704, XrefRangeEnd = 523714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Play(DataComposition composition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(composition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialSelectPromptBehaviour.NativeMethodInfoPtr_Event_Play_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x00064D70 File Offset: 0x00062F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523714, XrefRangeEnd = 523720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator play(DataComposition composition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(composition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialSelectPromptBehaviour.NativeMethodInfoPtr_play_Protected_IEnumerator_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x00064DC0 File Offset: 0x00062FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523720, XrefRangeEnd = 523789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_PlayPractice(MatchInitData matchData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialSelectPromptBehaviour.NativeMethodInfoPtr_Event_PlayPractice_Public_Void_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x00064E04 File Offset: 0x00063004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523789, XrefRangeEnd = 523810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialSelectPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialSelectPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialSelectPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x0000C793 File Offset: 0x0000A993
		public TutorialSelectPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06001613 RID: 5651 RVA: 0x00064E40 File Offset: 0x00063040
		// (set) Token: 0x06001614 RID: 5652 RVA: 0x0000C79C File Offset: 0x0000A99C
		public unsafe SubscriptionProvider matchPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour.NativeFieldInfoPtr_matchPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour.NativeFieldInfoPtr_matchPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06001615 RID: 5653 RVA: 0x00064E70 File Offset: 0x00063070
		// (set) Token: 0x06001616 RID: 5654 RVA: 0x0000C7BB File Offset: 0x0000A9BB
		public unsafe GameObject matchSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour.NativeFieldInfoPtr_matchSeparator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour.NativeFieldInfoPtr_matchSeparator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06001617 RID: 5655 RVA: 0x00064EA0 File Offset: 0x000630A0
		// (set) Token: 0x06001618 RID: 5656 RVA: 0x0000C7DA File Offset: 0x0000A9DA
		public unsafe string practiceScenarioKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour.NativeFieldInfoPtr_practiceScenarioKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour.NativeFieldInfoPtr_practiceScenarioKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06001619 RID: 5657 RVA: 0x00064EC8 File Offset: 0x000630C8
		// (set) Token: 0x0600161A RID: 5658 RVA: 0x0000C7F9 File Offset: 0x0000A9F9
		public unsafe string lastTutorialScenarioKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour.NativeFieldInfoPtr_lastTutorialScenarioKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour.NativeFieldInfoPtr_lastTutorialScenarioKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x0600161B RID: 5659 RVA: 0x00064EF0 File Offset: 0x000630F0
		// (set) Token: 0x0600161C RID: 5660 RVA: 0x0000C818 File Offset: 0x0000AA18
		public unsafe string practicePromptScenarioKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour.NativeFieldInfoPtr_practicePromptScenarioKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour.NativeFieldInfoPtr_practicePromptScenarioKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x0600161D RID: 5661 RVA: 0x00064F18 File Offset: 0x00063118
		// (set) Token: 0x0600161E RID: 5662 RVA: 0x0000C837 File Offset: 0x0000AA37
		public unsafe List<SubscriptionProvider> matchInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour.NativeFieldInfoPtr_matchInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SubscriptionProvider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour.NativeFieldInfoPtr_matchInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x0600161F RID: 5663 RVA: 0x00064F48 File Offset: 0x00063148
		// (set) Token: 0x06001620 RID: 5664 RVA: 0x0000C856 File Offset: 0x0000AA56
		public unsafe IAPStoreBehaviour iapStoreBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour.NativeFieldInfoPtr_iapStoreBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPStoreBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour.NativeFieldInfoPtr_iapStoreBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06001621 RID: 5665 RVA: 0x00064F78 File Offset: 0x00063178
		// (set) Token: 0x06001622 RID: 5666 RVA: 0x0000C875 File Offset: 0x0000AA75
		public unsafe ProductUtils productUtils
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour.NativeFieldInfoPtr_productUtils);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductUtils>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour.NativeFieldInfoPtr_productUtils), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06001623 RID: 5667 RVA: 0x00064FA8 File Offset: 0x000631A8
		// (set) Token: 0x06001624 RID: 5668 RVA: 0x0000C894 File Offset: 0x0000AA94
		public unsafe OfflineMatchesManager offlineMatchesManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour.NativeFieldInfoPtr_offlineMatchesManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OfflineMatchesManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour.NativeFieldInfoPtr_offlineMatchesManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DA6 RID: 3494
		private static readonly IntPtr NativeFieldInfoPtr_matchPrefab;

		// Token: 0x04000DA7 RID: 3495
		private static readonly IntPtr NativeFieldInfoPtr_matchSeparator;

		// Token: 0x04000DA8 RID: 3496
		private static readonly IntPtr NativeFieldInfoPtr_practiceScenarioKey;

		// Token: 0x04000DA9 RID: 3497
		private static readonly IntPtr NativeFieldInfoPtr_lastTutorialScenarioKey;

		// Token: 0x04000DAA RID: 3498
		private static readonly IntPtr NativeFieldInfoPtr_practicePromptScenarioKey;

		// Token: 0x04000DAB RID: 3499
		private static readonly IntPtr NativeFieldInfoPtr_matchInstances;

		// Token: 0x04000DAC RID: 3500
		private static readonly IntPtr NativeFieldInfoPtr_iapStoreBehaviour;

		// Token: 0x04000DAD RID: 3501
		private static readonly IntPtr NativeFieldInfoPtr_productUtils;

		// Token: 0x04000DAE RID: 3502
		private static readonly IntPtr NativeFieldInfoPtr_offlineMatchesManager;

		// Token: 0x04000DAF RID: 3503
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000DB0 RID: 3504
		private static readonly IntPtr NativeMethodInfoPtr_SetupTutorials_Protected_Virtual_New_Void_List_1_MatchInitData_0;

		// Token: 0x04000DB1 RID: 3505
		private static readonly IntPtr NativeMethodInfoPtr_MeetOwnershipRequirements_Private_Boolean_MatchInitData_0;

		// Token: 0x04000DB2 RID: 3506
		private static readonly IntPtr NativeMethodInfoPtr_Event_Play_Public_Void_DataComposition_0;

		// Token: 0x04000DB3 RID: 3507
		private static readonly IntPtr NativeMethodInfoPtr_play_Protected_IEnumerator_DataComposition_0;

		// Token: 0x04000DB4 RID: 3508
		private static readonly IntPtr NativeMethodInfoPtr_Event_PlayPractice_Public_Void_MatchInitData_0;

		// Token: 0x04000DB5 RID: 3509
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003CA RID: 970
		[ObfuscatedName("boardgames.menus.prompts.TutorialSelectPromptBehaviour+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06002D34 RID: 11572 RVA: 0x000AF820 File Offset: 0x000ADA20
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TutorialSelectPromptBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialSelectPromptBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialSelectPromptBehaviour.__c>.NativeClassPtr);
				TutorialSelectPromptBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSelectPromptBehaviour.__c>.NativeClassPtr, "<>9");
				TutorialSelectPromptBehaviour.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSelectPromptBehaviour.__c>.NativeClassPtr, "<>9__10_0");
				TutorialSelectPromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectPromptBehaviour.__c>.NativeClassPtr, 100666524);
				TutorialSelectPromptBehaviour.__c.NativeMethodInfoPtr__SetupTutorials_b__10_0_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectPromptBehaviour.__c>.NativeClassPtr, 100666525);
			}

			// Token: 0x06002D35 RID: 11573 RVA: 0x000AF89C File Offset: 0x000ADA9C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialSelectPromptBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialSelectPromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D36 RID: 11574 RVA: 0x000AF8D8 File Offset: 0x000ADAD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523383, XrefRangeEnd = 523384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetupTutorials_b__10_0(string scenarioName)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(scenarioName);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialSelectPromptBehaviour.__c.NativeMethodInfoPtr__SetupTutorials_b__10_0_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002D37 RID: 11575 RVA: 0x0001763A File Offset: 0x0001583A
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CD6 RID: 3286
			// (get) Token: 0x06002D38 RID: 11576 RVA: 0x000AF928 File Offset: 0x000ADB28
			// (set) Token: 0x06002D39 RID: 11577 RVA: 0x00017643 File Offset: 0x00015843
			public unsafe static TutorialSelectPromptBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TutorialSelectPromptBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialSelectPromptBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TutorialSelectPromptBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CD7 RID: 3287
			// (get) Token: 0x06002D3A RID: 11578 RVA: 0x000AF950 File Offset: 0x000ADB50
			// (set) Token: 0x06002D3B RID: 11579 RVA: 0x00017655 File Offset: 0x00015855
			public unsafe static Func<string, bool> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TutorialSelectPromptBehaviour.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TutorialSelectPromptBehaviour.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001C0A RID: 7178
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001C0B RID: 7179
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x04001C0C RID: 7180
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001C0D RID: 7181
			private static readonly IntPtr NativeMethodInfoPtr__SetupTutorials_b__10_0_Internal_Boolean_String_0;
		}

		// Token: 0x020003CB RID: 971
		[ObfuscatedName("boardgames.menus.prompts.TutorialSelectPromptBehaviour+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002D3C RID: 11580 RVA: 0x000AF978 File Offset: 0x000ADB78
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<TutorialSelectPromptBehaviour.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialSelectPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialSelectPromptBehaviour.__c__DisplayClass13_0>.NativeClassPtr);
				TutorialSelectPromptBehaviour.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSelectPromptBehaviour.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				TutorialSelectPromptBehaviour.__c__DisplayClass13_0.NativeFieldInfoPtr_composition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSelectPromptBehaviour.__c__DisplayClass13_0>.NativeClassPtr, "composition");
				TutorialSelectPromptBehaviour.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectPromptBehaviour.__c__DisplayClass13_0>.NativeClassPtr, 100666526);
				TutorialSelectPromptBehaviour.__c__DisplayClass13_0.NativeMethodInfoPtr__play_b__0_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectPromptBehaviour.__c__DisplayClass13_0>.NativeClassPtr, 100666527);
				TutorialSelectPromptBehaviour.__c__DisplayClass13_0.NativeMethodInfoPtr__play_b__1_Internal_IFailable_RunConfigureOfflineMatchFlow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectPromptBehaviour.__c__DisplayClass13_0>.NativeClassPtr, 100666528);
			}

			// Token: 0x06002D3D RID: 11581 RVA: 0x000AFA08 File Offset: 0x000ADC08
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialSelectPromptBehaviour.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialSelectPromptBehaviour.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D3E RID: 11582 RVA: 0x000AFA44 File Offset: 0x000ADC44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523384, XrefRangeEnd = 523385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _play_b__0(string product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(product);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialSelectPromptBehaviour.__c__DisplayClass13_0.NativeMethodInfoPtr__play_b__0_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002D3F RID: 11583 RVA: 0x000AFA94 File Offset: 0x000ADC94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523385, XrefRangeEnd = 523395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IFailable _play_b__1(RunConfigureOfflineMatchFlow f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialSelectPromptBehaviour.__c__DisplayClass13_0.NativeMethodInfoPtr__play_b__1_Internal_IFailable_RunConfigureOfflineMatchFlow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
				}
			}

			// Token: 0x06002D40 RID: 11584 RVA: 0x00017667 File Offset: 0x00015867
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CD8 RID: 3288
			// (get) Token: 0x06002D41 RID: 11585 RVA: 0x000AFAE4 File Offset: 0x000ADCE4
			// (set) Token: 0x06002D42 RID: 11586 RVA: 0x00017670 File Offset: 0x00015870
			public unsafe TutorialSelectPromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialSelectPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CD9 RID: 3289
			// (get) Token: 0x06002D43 RID: 11587 RVA: 0x000AFB14 File Offset: 0x000ADD14
			// (set) Token: 0x06002D44 RID: 11588 RVA: 0x0001768F File Offset: 0x0001588F
			public unsafe DataComposition composition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour.__c__DisplayClass13_0.NativeFieldInfoPtr_composition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour.__c__DisplayClass13_0.NativeFieldInfoPtr_composition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001C0E RID: 7182
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001C0F RID: 7183
			private static readonly IntPtr NativeFieldInfoPtr_composition;

			// Token: 0x04001C10 RID: 7184
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001C11 RID: 7185
			private static readonly IntPtr NativeMethodInfoPtr__play_b__0_Internal_Boolean_String_0;

			// Token: 0x04001C12 RID: 7186
			private static readonly IntPtr NativeMethodInfoPtr__play_b__1_Internal_IFailable_RunConfigureOfflineMatchFlow_0;
		}

		// Token: 0x020003CC RID: 972
		[ObfuscatedName("boardgames.menus.prompts.TutorialSelectPromptBehaviour+<play>d__13")]
		public sealed class _play_d__13 : global::Il2CppSystem.Object
		{
			// Token: 0x06002D45 RID: 11589 RVA: 0x000AFB44 File Offset: 0x000ADD44
			// Note: this type is marked as 'beforefieldinit'.
			static _play_d__13()
			{
				Il2CppClassPointerStore<TutorialSelectPromptBehaviour._play_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialSelectPromptBehaviour>.NativeClassPtr, "<play>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialSelectPromptBehaviour._play_d__13>.NativeClassPtr);
				TutorialSelectPromptBehaviour._play_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSelectPromptBehaviour._play_d__13>.NativeClassPtr, "<>1__state");
				TutorialSelectPromptBehaviour._play_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSelectPromptBehaviour._play_d__13>.NativeClassPtr, "<>2__current");
				TutorialSelectPromptBehaviour._play_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSelectPromptBehaviour._play_d__13>.NativeClassPtr, "<>4__this");
				TutorialSelectPromptBehaviour._play_d__13.NativeFieldInfoPtr_composition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSelectPromptBehaviour._play_d__13>.NativeClassPtr, "composition");
				TutorialSelectPromptBehaviour._play_d__13.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSelectPromptBehaviour._play_d__13>.NativeClassPtr, "<>8__1");
				TutorialSelectPromptBehaviour._play_d__13.NativeFieldInfoPtr__match_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSelectPromptBehaviour._play_d__13>.NativeClassPtr, "<match>5__2");
				TutorialSelectPromptBehaviour._play_d__13.NativeFieldInfoPtr__dlcPrompt_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSelectPromptBehaviour._play_d__13>.NativeClassPtr, "<dlcPrompt>5__3");
				TutorialSelectPromptBehaviour._play_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectPromptBehaviour._play_d__13>.NativeClassPtr, 100666529);
				TutorialSelectPromptBehaviour._play_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectPromptBehaviour._play_d__13>.NativeClassPtr, 100666530);
				TutorialSelectPromptBehaviour._play_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectPromptBehaviour._play_d__13>.NativeClassPtr, 100666531);
				TutorialSelectPromptBehaviour._play_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectPromptBehaviour._play_d__13>.NativeClassPtr, 100666532);
				TutorialSelectPromptBehaviour._play_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectPromptBehaviour._play_d__13>.NativeClassPtr, 100666533);
				TutorialSelectPromptBehaviour._play_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectPromptBehaviour._play_d__13>.NativeClassPtr, 100666534);
			}

			// Token: 0x06002D46 RID: 11590 RVA: 0x000AFC74 File Offset: 0x000ADE74
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _play_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialSelectPromptBehaviour._play_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialSelectPromptBehaviour._play_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002D47 RID: 11591 RVA: 0x000AFCBC File Offset: 0x000ADEBC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialSelectPromptBehaviour._play_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D48 RID: 11592 RVA: 0x000AFCF0 File Offset: 0x000ADEF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523395, XrefRangeEnd = 523503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialSelectPromptBehaviour._play_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000CE1 RID: 3297
			// (get) Token: 0x06002D49 RID: 11593 RVA: 0x000AFD2C File Offset: 0x000ADF2C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialSelectPromptBehaviour._play_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002D4A RID: 11594 RVA: 0x000AFD6C File Offset: 0x000ADF6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523503, XrefRangeEnd = 523508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialSelectPromptBehaviour._play_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000CE2 RID: 3298
			// (get) Token: 0x06002D4B RID: 11595 RVA: 0x000AFDA0 File Offset: 0x000ADFA0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialSelectPromptBehaviour._play_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002D4C RID: 11596 RVA: 0x000176AE File Offset: 0x000158AE
			public _play_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CDA RID: 3290
			// (get) Token: 0x06002D4D RID: 11597 RVA: 0x000AFDE0 File Offset: 0x000ADFE0
			// (set) Token: 0x06002D4E RID: 11598 RVA: 0x000176B7 File Offset: 0x000158B7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour._play_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour._play_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000CDB RID: 3291
			// (get) Token: 0x06002D4F RID: 11599 RVA: 0x000AFE08 File Offset: 0x000AE008
			// (set) Token: 0x06002D50 RID: 11600 RVA: 0x000176D2 File Offset: 0x000158D2
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour._play_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour._play_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CDC RID: 3292
			// (get) Token: 0x06002D51 RID: 11601 RVA: 0x000AFE38 File Offset: 0x000AE038
			// (set) Token: 0x06002D52 RID: 11602 RVA: 0x000176F1 File Offset: 0x000158F1
			public unsafe TutorialSelectPromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour._play_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialSelectPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour._play_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CDD RID: 3293
			// (get) Token: 0x06002D53 RID: 11603 RVA: 0x000AFE68 File Offset: 0x000AE068
			// (set) Token: 0x06002D54 RID: 11604 RVA: 0x00017710 File Offset: 0x00015910
			public unsafe DataComposition composition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour._play_d__13.NativeFieldInfoPtr_composition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour._play_d__13.NativeFieldInfoPtr_composition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CDE RID: 3294
			// (get) Token: 0x06002D55 RID: 11605 RVA: 0x000AFE98 File Offset: 0x000AE098
			// (set) Token: 0x06002D56 RID: 11606 RVA: 0x0001772F File Offset: 0x0001592F
			public unsafe TutorialSelectPromptBehaviour.__c__DisplayClass13_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour._play_d__13.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialSelectPromptBehaviour.__c__DisplayClass13_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour._play_d__13.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CDF RID: 3295
			// (get) Token: 0x06002D57 RID: 11607 RVA: 0x000AFEC8 File Offset: 0x000AE0C8
			// (set) Token: 0x06002D58 RID: 11608 RVA: 0x0001774E File Offset: 0x0001594E
			public unsafe SerializedMatchComponent _match_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour._play_d__13.NativeFieldInfoPtr__match_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedMatchComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour._play_d__13.NativeFieldInfoPtr__match_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CE0 RID: 3296
			// (get) Token: 0x06002D59 RID: 11609 RVA: 0x000AFEF8 File Offset: 0x000AE0F8
			// (set) Token: 0x06002D5A RID: 11610 RVA: 0x0001776D File Offset: 0x0001596D
			public unsafe TutorialRequiresDLCPrompt _dlcPrompt_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour._play_d__13.NativeFieldInfoPtr__dlcPrompt_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialRequiresDLCPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectPromptBehaviour._play_d__13.NativeFieldInfoPtr__dlcPrompt_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001C13 RID: 7187
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001C14 RID: 7188
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001C15 RID: 7189
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001C16 RID: 7190
			private static readonly IntPtr NativeFieldInfoPtr_composition;

			// Token: 0x04001C17 RID: 7191
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04001C18 RID: 7192
			private static readonly IntPtr NativeFieldInfoPtr__match_5__2;

			// Token: 0x04001C19 RID: 7193
			private static readonly IntPtr NativeFieldInfoPtr__dlcPrompt_5__3;

			// Token: 0x04001C1A RID: 7194
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001C1B RID: 7195
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001C1C RID: 7196
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001C1D RID: 7197
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001C1E RID: 7198
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001C1F RID: 7199
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

using System;
using Canis;
using Canis.actions;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.actions.phases
{
	// Token: 0x020002BF RID: 703
	public class PftSHeroicDraftDeckSetup : DraftDeckSetup
	{
		// Token: 0x06001D12 RID: 7442 RVA: 0x000CA048 File Offset: 0x000C8248
		// Note: this type is marked as 'beforefieldinit'.
		static PftSHeroicDraftDeckSetup()
		{
			Il2CppClassPointerStore<PftSHeroicDraftDeckSetup>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.phases", "PftSHeroicDraftDeckSetup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PftSHeroicDraftDeckSetup>.NativeClassPtr);
			PftSHeroicDraftDeckSetup.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PftSHeroicDraftDeckSetup>.NativeClassPtr, 100669502);
			PftSHeroicDraftDeckSetup.NativeMethodInfoPtr__ctor_Public_Void_SerializedPftSHeroicDraftDeckSetup_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PftSHeroicDraftDeckSetup>.NativeClassPtr, 100669503);
			PftSHeroicDraftDeckSetup.NativeMethodInfoPtr_get_ExcludedCards_Protected_Virtual_get_List_1_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PftSHeroicDraftDeckSetup>.NativeClassPtr, 100669504);
			PftSHeroicDraftDeckSetup.NativeMethodInfoPtr_get_DraftRoundCosts_Protected_Virtual_get_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PftSHeroicDraftDeckSetup>.NativeClassPtr, 100669505);
			PftSHeroicDraftDeckSetup.NativeMethodInfoPtr_get_AIDraftSets_Protected_Virtual_get_List_1_List_1_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PftSHeroicDraftDeckSetup>.NativeClassPtr, 100669506);
			PftSHeroicDraftDeckSetup.NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PftSHeroicDraftDeckSetup>.NativeClassPtr, 100669507);
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x000CA0F0 File Offset: 0x000C82F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 155920, RefRangeEnd = 155922, XrefRangeStart = 155920, XrefRangeEnd = 155922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PftSHeroicDraftDeckSetup(WormPlayer p, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PftSHeroicDraftDeckSetup>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PftSHeroicDraftDeckSetup.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x000CA150 File Offset: 0x000C8350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PftSHeroicDraftDeckSetup(SerializedPftSHeroicDraftDeckSetup serialized, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PftSHeroicDraftDeckSetup>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PftSHeroicDraftDeckSetup.NativeMethodInfoPtr__ctor_Public_Void_SerializedPftSHeroicDraftDeckSetup_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06001D15 RID: 7445 RVA: 0x000CA1B0 File Offset: 0x000C83B0
		public unsafe override List<ArchetypeID> ExcludedCards
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156193, XrefRangeEnd = 156199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PftSHeroicDraftDeckSetup.NativeMethodInfoPtr_get_ExcludedCards_Protected_Virtual_get_List_1_ArchetypeID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr3) : null;
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06001D16 RID: 7446 RVA: 0x000CA1FC File Offset: 0x000C83FC
		public unsafe override Dictionary<int, int> DraftRoundCosts
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156199, XrefRangeEnd = 156214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PftSHeroicDraftDeckSetup.NativeMethodInfoPtr_get_DraftRoundCosts_Protected_Virtual_get_Dictionary_2_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06001D17 RID: 7447 RVA: 0x000CA248 File Offset: 0x000C8448
		public unsafe override List<List<ArchetypeID>> AIDraftSets
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156214, XrefRangeEnd = 156501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PftSHeroicDraftDeckSetup.NativeMethodInfoPtr_get_AIDraftSets_Protected_Virtual_get_List_1_List_1_ArchetypeID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<List<ArchetypeID>>>(intPtr3) : null;
			}
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x000CA294 File Offset: 0x000C8494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156501, XrefRangeEnd = 156506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedStateMachineAction MakeSerializedStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PftSHeroicDraftDeckSetup.NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedStateMachineAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x0000C4B5 File Offset: 0x0000A6B5
		public PftSHeroicDraftDeckSetup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001211 RID: 4625
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_0;

		// Token: 0x04001212 RID: 4626
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedPftSHeroicDraftDeckSetup_WormMatch_0;

		// Token: 0x04001213 RID: 4627
		private static readonly IntPtr NativeMethodInfoPtr_get_ExcludedCards_Protected_Virtual_get_List_1_ArchetypeID_0;

		// Token: 0x04001214 RID: 4628
		private static readonly IntPtr NativeMethodInfoPtr_get_DraftRoundCosts_Protected_Virtual_get_Dictionary_2_Int32_Int32_0;

		// Token: 0x04001215 RID: 4629
		private static readonly IntPtr NativeMethodInfoPtr_get_AIDraftSets_Protected_Virtual_get_List_1_List_1_ArchetypeID_0;

		// Token: 0x04001216 RID: 4630
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0;
	}
}

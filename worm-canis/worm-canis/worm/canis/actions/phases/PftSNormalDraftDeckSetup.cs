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
	// Token: 0x020002BD RID: 701
	public class PftSNormalDraftDeckSetup : DraftDeckSetup
	{
		// Token: 0x06001D06 RID: 7430 RVA: 0x000C9CB0 File Offset: 0x000C7EB0
		// Note: this type is marked as 'beforefieldinit'.
		static PftSNormalDraftDeckSetup()
		{
			Il2CppClassPointerStore<PftSNormalDraftDeckSetup>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.phases", "PftSNormalDraftDeckSetup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PftSNormalDraftDeckSetup>.NativeClassPtr);
			PftSNormalDraftDeckSetup.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PftSNormalDraftDeckSetup>.NativeClassPtr, 100669494);
			PftSNormalDraftDeckSetup.NativeMethodInfoPtr__ctor_Public_Void_SerializedPftSNormalDraftDeckSetup_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PftSNormalDraftDeckSetup>.NativeClassPtr, 100669495);
			PftSNormalDraftDeckSetup.NativeMethodInfoPtr_get_ExcludedCards_Protected_Virtual_get_List_1_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PftSNormalDraftDeckSetup>.NativeClassPtr, 100669496);
			PftSNormalDraftDeckSetup.NativeMethodInfoPtr_get_DraftRoundCosts_Protected_Virtual_get_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PftSNormalDraftDeckSetup>.NativeClassPtr, 100669497);
			PftSNormalDraftDeckSetup.NativeMethodInfoPtr_get_AIDraftSets_Protected_Virtual_get_List_1_List_1_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PftSNormalDraftDeckSetup>.NativeClassPtr, 100669498);
			PftSNormalDraftDeckSetup.NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PftSNormalDraftDeckSetup>.NativeClassPtr, 100669499);
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x000C9D58 File Offset: 0x000C7F58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 155920, RefRangeEnd = 155922, XrefRangeStart = 155919, XrefRangeEnd = 155920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PftSNormalDraftDeckSetup(WormPlayer p, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PftSNormalDraftDeckSetup>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PftSNormalDraftDeckSetup.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x000C9DB8 File Offset: 0x000C7FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PftSNormalDraftDeckSetup(SerializedPftSNormalDraftDeckSetup serialized, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PftSNormalDraftDeckSetup>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PftSNormalDraftDeckSetup.NativeMethodInfoPtr__ctor_Public_Void_SerializedPftSNormalDraftDeckSetup_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06001D09 RID: 7433 RVA: 0x000C9E18 File Offset: 0x000C8018
		public unsafe override List<ArchetypeID> ExcludedCards
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155922, XrefRangeEnd = 155928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PftSNormalDraftDeckSetup.NativeMethodInfoPtr_get_ExcludedCards_Protected_Virtual_get_List_1_ArchetypeID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr3) : null;
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06001D0A RID: 7434 RVA: 0x000C9E64 File Offset: 0x000C8064
		public unsafe override Dictionary<int, int> DraftRoundCosts
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155928, XrefRangeEnd = 155943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PftSNormalDraftDeckSetup.NativeMethodInfoPtr_get_DraftRoundCosts_Protected_Virtual_get_Dictionary_2_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06001D0B RID: 7435 RVA: 0x000C9EB0 File Offset: 0x000C80B0
		public unsafe override List<List<ArchetypeID>> AIDraftSets
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155943, XrefRangeEnd = 156182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PftSNormalDraftDeckSetup.NativeMethodInfoPtr_get_AIDraftSets_Protected_Virtual_get_List_1_List_1_ArchetypeID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<List<ArchetypeID>>>(intPtr3) : null;
			}
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x000C9EFC File Offset: 0x000C80FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156182, XrefRangeEnd = 156187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedStateMachineAction MakeSerializedStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PftSNormalDraftDeckSetup.NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedStateMachineAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x0000C4A3 File Offset: 0x0000A6A3
		public PftSNormalDraftDeckSetup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001209 RID: 4617
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_0;

		// Token: 0x0400120A RID: 4618
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedPftSNormalDraftDeckSetup_WormMatch_0;

		// Token: 0x0400120B RID: 4619
		private static readonly IntPtr NativeMethodInfoPtr_get_ExcludedCards_Protected_Virtual_get_List_1_ArchetypeID_0;

		// Token: 0x0400120C RID: 4620
		private static readonly IntPtr NativeMethodInfoPtr_get_DraftRoundCosts_Protected_Virtual_get_Dictionary_2_Int32_Int32_0;

		// Token: 0x0400120D RID: 4621
		private static readonly IntPtr NativeMethodInfoPtr_get_AIDraftSets_Protected_Virtual_get_List_1_List_1_ArchetypeID_0;

		// Token: 0x0400120E RID: 4622
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0;
	}
}

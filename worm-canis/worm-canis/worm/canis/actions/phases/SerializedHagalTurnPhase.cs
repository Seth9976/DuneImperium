using System;
using Canis;
using Canis.actions;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.canis.actions.phases
{
	// Token: 0x020002CC RID: 716
	public class SerializedHagalTurnPhase : SerializedStateMachineAction
	{
		// Token: 0x06001D75 RID: 7541 RVA: 0x000CBB80 File Offset: 0x000C9D80
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedHagalTurnPhase()
		{
			Il2CppClassPointerStore<SerializedHagalTurnPhase>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.phases", "SerializedHagalTurnPhase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedHagalTurnPhase>.NativeClassPtr);
			SerializedHagalTurnPhase.NativeFieldInfoPtr_PlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedHagalTurnPhase>.NativeClassPtr, "PlayerID");
			SerializedHagalTurnPhase.NativeFieldInfoPtr_FoundOpenSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedHagalTurnPhase>.NativeClassPtr, "FoundOpenSpace");
			SerializedHagalTurnPhase.NativeFieldInfoPtr_RevealedHagalCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedHagalTurnPhase>.NativeClassPtr, "RevealedHagalCards");
			SerializedHagalTurnPhase.NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedHagalTurnPhase>.NativeClassPtr, 100669767);
			SerializedHagalTurnPhase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedHagalTurnPhase>.NativeClassPtr, 100669768);
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x000CBC14 File Offset: 0x000C9E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159810, XrefRangeEnd = 159816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override StateMachineAction GenStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedHagalTurnPhase.NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001D77 RID: 7543 RVA: 0x000CBC70 File Offset: 0x000C9E70
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedHagalTurnPhase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedHagalTurnPhase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedHagalTurnPhase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x0000C641 File Offset: 0x0000A841
		public SerializedHagalTurnPhase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06001D79 RID: 7545 RVA: 0x000CBCAC File Offset: 0x000C9EAC
		// (set) Token: 0x06001D7A RID: 7546 RVA: 0x0000C64A File Offset: 0x0000A84A
		public unsafe EntityID PlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedHagalTurnPhase.NativeFieldInfoPtr_PlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedHagalTurnPhase.NativeFieldInfoPtr_PlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06001D7B RID: 7547 RVA: 0x000CBCDC File Offset: 0x000C9EDC
		// (set) Token: 0x06001D7C RID: 7548 RVA: 0x0000C669 File Offset: 0x0000A869
		public unsafe bool FoundOpenSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedHagalTurnPhase.NativeFieldInfoPtr_FoundOpenSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedHagalTurnPhase.NativeFieldInfoPtr_FoundOpenSpace)) = value;
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06001D7D RID: 7549 RVA: 0x000CBD04 File Offset: 0x000C9F04
		// (set) Token: 0x06001D7E RID: 7550 RVA: 0x0000C684 File Offset: 0x0000A884
		public unsafe List<ArchetypeID> RevealedHagalCards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedHagalTurnPhase.NativeFieldInfoPtr_RevealedHagalCards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedHagalTurnPhase.NativeFieldInfoPtr_RevealedHagalCards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001266 RID: 4710
		private static readonly IntPtr NativeFieldInfoPtr_PlayerID;

		// Token: 0x04001267 RID: 4711
		private static readonly IntPtr NativeFieldInfoPtr_FoundOpenSpace;

		// Token: 0x04001268 RID: 4712
		private static readonly IntPtr NativeFieldInfoPtr_RevealedHagalCards;

		// Token: 0x04001269 RID: 4713
		private static readonly IntPtr NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0;

		// Token: 0x0400126A RID: 4714
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

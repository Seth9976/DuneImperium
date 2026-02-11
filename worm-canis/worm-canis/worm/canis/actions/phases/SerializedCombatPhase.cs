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
	// Token: 0x020002B8 RID: 696
	public class SerializedCombatPhase : SerializedStateMachineAction
	{
		// Token: 0x06001CDB RID: 7387 RVA: 0x000C913C File Offset: 0x000C733C
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedCombatPhase()
		{
			Il2CppClassPointerStore<SerializedCombatPhase>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.phases", "SerializedCombatPhase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedCombatPhase>.NativeClassPtr);
			SerializedCombatPhase.NativeFieldInfoPtr_SelectingPlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedCombatPhase>.NativeClassPtr, "SelectingPlayerID");
			SerializedCombatPhase.NativeFieldInfoPtr_PassedPlayerIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedCombatPhase>.NativeClassPtr, "PassedPlayerIDs");
			SerializedCombatPhase.NativeFieldInfoPtr_PlayerRewards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedCombatPhase>.NativeClassPtr, "PlayerRewards");
			SerializedCombatPhase.NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedCombatPhase>.NativeClassPtr, 100669427);
			SerializedCombatPhase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedCombatPhase>.NativeClassPtr, 100669428);
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x000C91D0 File Offset: 0x000C73D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155491, XrefRangeEnd = 155497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override StateMachineAction GenStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedCombatPhase.NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x000C922C File Offset: 0x000C742C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedCombatPhase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedCombatPhase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedCombatPhase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x0000C3C5 File Offset: 0x0000A5C5
		public SerializedCombatPhase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06001CDF RID: 7391 RVA: 0x000C9268 File Offset: 0x000C7468
		// (set) Token: 0x06001CE0 RID: 7392 RVA: 0x0000C3CE File Offset: 0x0000A5CE
		public unsafe EntityID SelectingPlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedCombatPhase.NativeFieldInfoPtr_SelectingPlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedCombatPhase.NativeFieldInfoPtr_SelectingPlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06001CE1 RID: 7393 RVA: 0x000C9298 File Offset: 0x000C7498
		// (set) Token: 0x06001CE2 RID: 7394 RVA: 0x0000C3ED File Offset: 0x0000A5ED
		public unsafe List<EntityID> PassedPlayerIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedCombatPhase.NativeFieldInfoPtr_PassedPlayerIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedCombatPhase.NativeFieldInfoPtr_PassedPlayerIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06001CE3 RID: 7395 RVA: 0x000C92C8 File Offset: 0x000C74C8
		// (set) Token: 0x06001CE4 RID: 7396 RVA: 0x0000C40C File Offset: 0x0000A60C
		public unsafe List<SerializedPlayerReward> PlayerRewards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedCombatPhase.NativeFieldInfoPtr_PlayerRewards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SerializedPlayerReward>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedCombatPhase.NativeFieldInfoPtr_PlayerRewards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011E8 RID: 4584
		private static readonly IntPtr NativeFieldInfoPtr_SelectingPlayerID;

		// Token: 0x040011E9 RID: 4585
		private static readonly IntPtr NativeFieldInfoPtr_PassedPlayerIDs;

		// Token: 0x040011EA RID: 4586
		private static readonly IntPtr NativeFieldInfoPtr_PlayerRewards;

		// Token: 0x040011EB RID: 4587
		private static readonly IntPtr NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0;

		// Token: 0x040011EC RID: 4588
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

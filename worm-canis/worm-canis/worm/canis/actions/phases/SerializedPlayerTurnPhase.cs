using System;
using Canis;
using Canis.actions;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions.phases
{
	// Token: 0x020002CF RID: 719
	public class SerializedPlayerTurnPhase : SerializedStateMachineAction
	{
		// Token: 0x06001D9C RID: 7580 RVA: 0x000CC644 File Offset: 0x000CA844
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedPlayerTurnPhase()
		{
			Il2CppClassPointerStore<SerializedPlayerTurnPhase>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.phases", "SerializedPlayerTurnPhase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedPlayerTurnPhase>.NativeClassPtr);
			SerializedPlayerTurnPhase.NativeFieldInfoPtr_PlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedPlayerTurnPhase>.NativeClassPtr, "PlayerID");
			SerializedPlayerTurnPhase.NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedPlayerTurnPhase>.NativeClassPtr, 100669899);
			SerializedPlayerTurnPhase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedPlayerTurnPhase>.NativeClassPtr, 100669900);
		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x000CC6B0 File Offset: 0x000CA8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163194, XrefRangeEnd = 163210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override StateMachineAction GenStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedPlayerTurnPhase.NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001D9E RID: 7582 RVA: 0x000CC70C File Offset: 0x000CA90C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedPlayerTurnPhase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedPlayerTurnPhase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedPlayerTurnPhase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D9F RID: 7583 RVA: 0x0000C709 File Offset: 0x0000A909
		public SerializedPlayerTurnPhase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06001DA0 RID: 7584 RVA: 0x000CC748 File Offset: 0x000CA948
		// (set) Token: 0x06001DA1 RID: 7585 RVA: 0x0000C712 File Offset: 0x0000A912
		public unsafe EntityID PlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedPlayerTurnPhase.NativeFieldInfoPtr_PlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedPlayerTurnPhase.NativeFieldInfoPtr_PlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400128B RID: 4747
		private static readonly IntPtr NativeFieldInfoPtr_PlayerID;

		// Token: 0x0400128C RID: 4748
		private static readonly IntPtr NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0;

		// Token: 0x0400128D RID: 4749
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

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
	// Token: 0x020002C6 RID: 710
	public class SerializedGenerateConflictPhase : SerializedStateMachineAction
	{
		// Token: 0x06001D42 RID: 7490 RVA: 0x000CAE60 File Offset: 0x000C9060
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedGenerateConflictPhase()
		{
			Il2CppClassPointerStore<SerializedGenerateConflictPhase>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.phases", "SerializedGenerateConflictPhase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedGenerateConflictPhase>.NativeClassPtr);
			SerializedGenerateConflictPhase.NativeFieldInfoPtr_ControlledSpaceIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGenerateConflictPhase>.NativeClassPtr, "ControlledSpaceIDs");
			SerializedGenerateConflictPhase.NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGenerateConflictPhase>.NativeClassPtr, 100669616);
			SerializedGenerateConflictPhase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGenerateConflictPhase>.NativeClassPtr, 100669617);
		}

		// Token: 0x06001D43 RID: 7491 RVA: 0x000CAECC File Offset: 0x000C90CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157728, XrefRangeEnd = 157759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override StateMachineAction GenStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedGenerateConflictPhase.NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001D44 RID: 7492 RVA: 0x000CAF28 File Offset: 0x000C9128
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedGenerateConflictPhase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedGenerateConflictPhase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGenerateConflictPhase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D45 RID: 7493 RVA: 0x0000C53F File Offset: 0x0000A73F
		public SerializedGenerateConflictPhase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06001D46 RID: 7494 RVA: 0x000CAF64 File Offset: 0x000C9164
		// (set) Token: 0x06001D47 RID: 7495 RVA: 0x0000C548 File Offset: 0x0000A748
		public unsafe List<EntityID> ControlledSpaceIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGenerateConflictPhase.NativeFieldInfoPtr_ControlledSpaceIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGenerateConflictPhase.NativeFieldInfoPtr_ControlledSpaceIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400123C RID: 4668
		private static readonly IntPtr NativeFieldInfoPtr_ControlledSpaceIDs;

		// Token: 0x0400123D RID: 4669
		private static readonly IntPtr NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0;

		// Token: 0x0400123E RID: 4670
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

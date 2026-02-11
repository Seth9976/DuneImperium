using System;
using Canis;
using Canis.actions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions.phases
{
	// Token: 0x020002C3 RID: 707
	public class SerializedEndgamePhase : SerializedStateMachineAction
	{
		// Token: 0x06001D30 RID: 7472 RVA: 0x000CA9A4 File Offset: 0x000C8BA4
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedEndgamePhase()
		{
			Il2CppClassPointerStore<SerializedEndgamePhase>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.phases", "SerializedEndgamePhase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedEndgamePhase>.NativeClassPtr);
			SerializedEndgamePhase.NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedEndgamePhase>.NativeClassPtr, 100669578);
			SerializedEndgamePhase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedEndgamePhase>.NativeClassPtr, 100669579);
		}

		// Token: 0x06001D31 RID: 7473 RVA: 0x000CA9FC File Offset: 0x000C8BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157377, XrefRangeEnd = 157389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override StateMachineAction GenStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedEndgamePhase.NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x000CAA58 File Offset: 0x000C8C58
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedEndgamePhase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedEndgamePhase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedEndgamePhase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x0000C4EF File Offset: 0x0000A6EF
		public SerializedEndgamePhase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400122C RID: 4652
		private static readonly IntPtr NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0;

		// Token: 0x0400122D RID: 4653
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

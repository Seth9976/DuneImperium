using System;
using Canis;
using Canis.actions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions.phases
{
	// Token: 0x020002C9 RID: 713
	public class SerializedHagalSetupPhase : SerializedSetupPhase
	{
		// Token: 0x06001D58 RID: 7512 RVA: 0x000CB3B4 File Offset: 0x000C95B4
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedHagalSetupPhase()
		{
			Il2CppClassPointerStore<SerializedHagalSetupPhase>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.phases", "SerializedHagalSetupPhase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedHagalSetupPhase>.NativeClassPtr);
			SerializedHagalSetupPhase.NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedHagalSetupPhase>.NativeClassPtr, 100669679);
			SerializedHagalSetupPhase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedHagalSetupPhase>.NativeClassPtr, 100669680);
		}

		// Token: 0x06001D59 RID: 7513 RVA: 0x000CB40C File Offset: 0x000C960C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158439, XrefRangeEnd = 158445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override StateMachineAction GenStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedHagalSetupPhase.NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001D5A RID: 7514 RVA: 0x000CB468 File Offset: 0x000C9668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158445, XrefRangeEnd = 158446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedHagalSetupPhase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedHagalSetupPhase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedHagalSetupPhase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D5B RID: 7515 RVA: 0x0000C5B7 File Offset: 0x0000A7B7
		public SerializedHagalSetupPhase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001249 RID: 4681
		private static readonly IntPtr NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0;

		// Token: 0x0400124A RID: 4682
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Canis;
using Canis.actions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions.phases
{
	// Token: 0x020002BE RID: 702
	public class SerializedPftSNormalDraftDeckSetup : SerializedDeckSetupPhase
	{
		// Token: 0x06001D0E RID: 7438 RVA: 0x000C9F58 File Offset: 0x000C8158
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedPftSNormalDraftDeckSetup()
		{
			Il2CppClassPointerStore<SerializedPftSNormalDraftDeckSetup>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.phases", "SerializedPftSNormalDraftDeckSetup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedPftSNormalDraftDeckSetup>.NativeClassPtr);
			SerializedPftSNormalDraftDeckSetup.NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedPftSNormalDraftDeckSetup>.NativeClassPtr, 100669500);
			SerializedPftSNormalDraftDeckSetup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedPftSNormalDraftDeckSetup>.NativeClassPtr, 100669501);
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x000C9FB0 File Offset: 0x000C81B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156187, XrefRangeEnd = 156193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override StateMachineAction GenStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedPftSNormalDraftDeckSetup.NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x000CA00C File Offset: 0x000C820C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedPftSNormalDraftDeckSetup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedPftSNormalDraftDeckSetup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedPftSNormalDraftDeckSetup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x0000C4AC File Offset: 0x0000A6AC
		public SerializedPftSNormalDraftDeckSetup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400120F RID: 4623
		private static readonly IntPtr NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0;

		// Token: 0x04001210 RID: 4624
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

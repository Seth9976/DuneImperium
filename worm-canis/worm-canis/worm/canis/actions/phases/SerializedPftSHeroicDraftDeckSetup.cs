using System;
using Canis;
using Canis.actions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions.phases
{
	// Token: 0x020002C0 RID: 704
	public class SerializedPftSHeroicDraftDeckSetup : SerializedDeckSetupPhase
	{
		// Token: 0x06001D1A RID: 7450 RVA: 0x000CA2F0 File Offset: 0x000C84F0
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedPftSHeroicDraftDeckSetup()
		{
			Il2CppClassPointerStore<SerializedPftSHeroicDraftDeckSetup>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.phases", "SerializedPftSHeroicDraftDeckSetup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedPftSHeroicDraftDeckSetup>.NativeClassPtr);
			SerializedPftSHeroicDraftDeckSetup.NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedPftSHeroicDraftDeckSetup>.NativeClassPtr, 100669508);
			SerializedPftSHeroicDraftDeckSetup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedPftSHeroicDraftDeckSetup>.NativeClassPtr, 100669509);
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x000CA348 File Offset: 0x000C8548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156506, XrefRangeEnd = 156512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override StateMachineAction GenStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedPftSHeroicDraftDeckSetup.NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x000CA3A4 File Offset: 0x000C85A4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedPftSHeroicDraftDeckSetup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedPftSHeroicDraftDeckSetup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedPftSHeroicDraftDeckSetup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x0000C4BE File Offset: 0x0000A6BE
		public SerializedPftSHeroicDraftDeckSetup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001217 RID: 4631
		private static readonly IntPtr NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0;

		// Token: 0x04001218 RID: 4632
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

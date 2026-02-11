using System;
using Canis;
using Canis.actions;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions.phases
{
	// Token: 0x020002BB RID: 699
	public class SerializedDeckSetupPhase : SerializedStateMachineAction
	{
		// Token: 0x06001CF3 RID: 7411 RVA: 0x000C96FC File Offset: 0x000C78FC
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedDeckSetupPhase()
		{
			Il2CppClassPointerStore<SerializedDeckSetupPhase>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.phases", "SerializedDeckSetupPhase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedDeckSetupPhase>.NativeClassPtr);
			SerializedDeckSetupPhase.NativeFieldInfoPtr_PlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedDeckSetupPhase>.NativeClassPtr, "PlayerID");
			SerializedDeckSetupPhase.NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedDeckSetupPhase>.NativeClassPtr, 100669461);
			SerializedDeckSetupPhase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedDeckSetupPhase>.NativeClassPtr, 100669462);
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x000C9768 File Offset: 0x000C7968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155585, XrefRangeEnd = 155591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override StateMachineAction GenStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedDeckSetupPhase.NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x000C97C4 File Offset: 0x000C79C4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedDeckSetupPhase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedDeckSetupPhase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedDeckSetupPhase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x0000C472 File Offset: 0x0000A672
		public SerializedDeckSetupPhase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06001CF7 RID: 7415 RVA: 0x000C9800 File Offset: 0x000C7A00
		// (set) Token: 0x06001CF8 RID: 7416 RVA: 0x0000C47B File Offset: 0x0000A67B
		public unsafe AccountID PlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedDeckSetupPhase.NativeFieldInfoPtr_PlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedDeckSetupPhase.NativeFieldInfoPtr_PlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011FB RID: 4603
		private static readonly IntPtr NativeFieldInfoPtr_PlayerID;

		// Token: 0x040011FC RID: 4604
		private static readonly IntPtr NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0;

		// Token: 0x040011FD RID: 4605
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

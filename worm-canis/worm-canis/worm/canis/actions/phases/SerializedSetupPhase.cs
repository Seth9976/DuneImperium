using System;
using Canis;
using Canis.actions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.canis.actions.phases
{
	// Token: 0x020002DA RID: 730
	public class SerializedSetupPhase : SerializedStateMachineAction
	{
		// Token: 0x06001E0B RID: 7691 RVA: 0x000CE394 File Offset: 0x000CC594
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedSetupPhase()
		{
			Il2CppClassPointerStore<SerializedSetupPhase>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.phases", "SerializedSetupPhase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedSetupPhase>.NativeClassPtr);
			SerializedSetupPhase.NativeFieldInfoPtr_AssignLeaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedSetupPhase>.NativeClassPtr, "AssignLeaders");
			SerializedSetupPhase.NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedSetupPhase>.NativeClassPtr, 100670289);
			SerializedSetupPhase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedSetupPhase>.NativeClassPtr, 100670290);
		}

		// Token: 0x06001E0C RID: 7692 RVA: 0x000CE400 File Offset: 0x000CC600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169801, XrefRangeEnd = 169807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override StateMachineAction GenStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedSetupPhase.NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x000CE45C File Offset: 0x000CC65C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedSetupPhase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedSetupPhase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedSetupPhase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x0000C957 File Offset: 0x0000AB57
		public SerializedSetupPhase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06001E0F RID: 7695 RVA: 0x000CE498 File Offset: 0x000CC698
		// (set) Token: 0x06001E10 RID: 7696 RVA: 0x0000C960 File Offset: 0x0000AB60
		public unsafe List<SerializedAssignLeader> AssignLeaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedSetupPhase.NativeFieldInfoPtr_AssignLeaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SerializedAssignLeader>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedSetupPhase.NativeFieldInfoPtr_AssignLeaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012F2 RID: 4850
		private static readonly IntPtr NativeFieldInfoPtr_AssignLeaders;

		// Token: 0x040012F3 RID: 4851
		private static readonly IntPtr NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0;

		// Token: 0x040012F4 RID: 4852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.tutorialScripts;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Networking.clientevents;

namespace lib.canis.Canis
{
	// Token: 0x02000019 RID: 25
	public class SerializedEmitInstallClientActionEvent : SerializedAction
	{
		// Token: 0x060000EC RID: 236 RVA: 0x0001CCA4 File Offset: 0x0001AEA4
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedEmitInstallClientActionEvent()
		{
			Il2CppClassPointerStore<SerializedEmitInstallClientActionEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "lib.canis.Canis", "SerializedEmitInstallClientActionEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedEmitInstallClientActionEvent>.NativeClassPtr);
			SerializedEmitInstallClientActionEvent.NativeFieldInfoPtr_TutorialActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedEmitInstallClientActionEvent>.NativeClassPtr, "TutorialActions");
			SerializedEmitInstallClientActionEvent.NativeFieldInfoPtr_PlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedEmitInstallClientActionEvent>.NativeClassPtr, "PlayerID");
			SerializedEmitInstallClientActionEvent.NativeFieldInfoPtr_ClientEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedEmitInstallClientActionEvent>.NativeClassPtr, "ClientEvent");
			SerializedEmitInstallClientActionEvent.NativeFieldInfoPtr_ResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedEmitInstallClientActionEvent>.NativeClassPtr, "ResponseID");
			SerializedEmitInstallClientActionEvent.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedEmitInstallClientActionEvent>.NativeClassPtr, 100663436);
			SerializedEmitInstallClientActionEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedEmitInstallClientActionEvent>.NativeClassPtr, 100663437);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0001CD4C File Offset: 0x0001AF4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543943, XrefRangeEnd = 543959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedEmitInstallClientActionEvent.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0001CDA8 File Offset: 0x0001AFA8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedEmitInstallClientActionEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedEmitInstallClientActionEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedEmitInstallClientActionEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000276D File Offset: 0x0000096D
		public SerializedEmitInstallClientActionEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x0001CDE4 File Offset: 0x0001AFE4
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x00002776 File Offset: 0x00000976
		public unsafe List<TutorialAction> TutorialActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEmitInstallClientActionEvent.NativeFieldInfoPtr_TutorialActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TutorialAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEmitInstallClientActionEvent.NativeFieldInfoPtr_TutorialActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x0001CE14 File Offset: 0x0001B014
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00002795 File Offset: 0x00000995
		public unsafe EntityID PlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEmitInstallClientActionEvent.NativeFieldInfoPtr_PlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEmitInstallClientActionEvent.NativeFieldInfoPtr_PlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x0001CE44 File Offset: 0x0001B044
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x000027B4 File Offset: 0x000009B4
		public unsafe ClientEvent ClientEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEmitInstallClientActionEvent.NativeFieldInfoPtr_ClientEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEmitInstallClientActionEvent.NativeFieldInfoPtr_ClientEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x0001CE74 File Offset: 0x0001B074
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x000027D3 File Offset: 0x000009D3
		public unsafe ClientEventResponseID ResponseID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEmitInstallClientActionEvent.NativeFieldInfoPtr_ResponseID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEmitInstallClientActionEvent.NativeFieldInfoPtr_ResponseID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeFieldInfoPtr_TutorialActions;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeFieldInfoPtr_PlayerID;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeFieldInfoPtr_ClientEvent;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeFieldInfoPtr_ResponseID;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

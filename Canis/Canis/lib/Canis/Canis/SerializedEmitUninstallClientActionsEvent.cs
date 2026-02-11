using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace lib.canis.Canis
{
	// Token: 0x0200001B RID: 27
	public class SerializedEmitUninstallClientActionsEvent : SerializedAction
	{
		// Token: 0x06000102 RID: 258 RVA: 0x0001D124 File Offset: 0x0001B324
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedEmitUninstallClientActionsEvent()
		{
			Il2CppClassPointerStore<SerializedEmitUninstallClientActionsEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "lib.canis.Canis", "SerializedEmitUninstallClientActionsEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedEmitUninstallClientActionsEvent>.NativeClassPtr);
			SerializedEmitUninstallClientActionsEvent.NativeFieldInfoPtr_ResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedEmitUninstallClientActionsEvent>.NativeClassPtr, "ResponseID");
			SerializedEmitUninstallClientActionsEvent.NativeFieldInfoPtr_PlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedEmitUninstallClientActionsEvent>.NativeClassPtr, "PlayerID");
			SerializedEmitUninstallClientActionsEvent.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedEmitUninstallClientActionsEvent>.NativeClassPtr, 100663450);
			SerializedEmitUninstallClientActionsEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedEmitUninstallClientActionsEvent>.NativeClassPtr, 100663451);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0001D1A4 File Offset: 0x0001B3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543985, XrefRangeEnd = 543993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedEmitUninstallClientActionsEvent.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0001D200 File Offset: 0x0001B400
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedEmitUninstallClientActionsEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedEmitUninstallClientActionsEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedEmitUninstallClientActionsEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002839 File Offset: 0x00000A39
		public SerializedEmitUninstallClientActionsEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000106 RID: 262 RVA: 0x0001D23C File Offset: 0x0001B43C
		// (set) Token: 0x06000107 RID: 263 RVA: 0x00002842 File Offset: 0x00000A42
		public unsafe ClientEventResponseID ResponseID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEmitUninstallClientActionsEvent.NativeFieldInfoPtr_ResponseID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEmitUninstallClientActionsEvent.NativeFieldInfoPtr_ResponseID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000108 RID: 264 RVA: 0x0001D26C File Offset: 0x0001B46C
		// (set) Token: 0x06000109 RID: 265 RVA: 0x00002861 File Offset: 0x00000A61
		public unsafe EntityID PlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEmitUninstallClientActionsEvent.NativeFieldInfoPtr_PlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEmitUninstallClientActionsEvent.NativeFieldInfoPtr_PlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeFieldInfoPtr_ResponseID;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeFieldInfoPtr_PlayerID;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

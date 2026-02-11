using System;
using Canis.actions.serialized;
using Canis.attributes;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions
{
	// Token: 0x020001AA RID: 426
	public class SerializedEmitTutorialEvent : SerializedAction
	{
		// Token: 0x06001259 RID: 4697 RVA: 0x00063ABC File Offset: 0x00061CBC
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedEmitTutorialEvent()
		{
			Il2CppClassPointerStore<SerializedEmitTutorialEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SerializedEmitTutorialEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedEmitTutorialEvent>.NativeClassPtr);
			SerializedEmitTutorialEvent.NativeFieldInfoPtr_TutorialActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedEmitTutorialEvent>.NativeClassPtr, "TutorialActions");
			SerializedEmitTutorialEvent.NativeFieldInfoPtr_PlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedEmitTutorialEvent>.NativeClassPtr, "PlayerID");
			SerializedEmitTutorialEvent.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedEmitTutorialEvent>.NativeClassPtr, 100667233);
			SerializedEmitTutorialEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedEmitTutorialEvent>.NativeClassPtr, 100667234);
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x00063B3C File Offset: 0x00061D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585426, XrefRangeEnd = 585452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedEmitTutorialEvent.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x00063B98 File Offset: 0x00061D98
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedEmitTutorialEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedEmitTutorialEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedEmitTutorialEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x000090FA File Offset: 0x000072FA
		public SerializedEmitTutorialEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x0600125D RID: 4701 RVA: 0x00063BD4 File Offset: 0x00061DD4
		// (set) Token: 0x0600125E RID: 4702 RVA: 0x00009103 File Offset: 0x00007303
		public unsafe List<SerializableAttributes> TutorialActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEmitTutorialEvent.NativeFieldInfoPtr_TutorialActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SerializableAttributes>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEmitTutorialEvent.NativeFieldInfoPtr_TutorialActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x0600125F RID: 4703 RVA: 0x00063C04 File Offset: 0x00061E04
		// (set) Token: 0x06001260 RID: 4704 RVA: 0x00009122 File Offset: 0x00007322
		public unsafe EntityID PlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEmitTutorialEvent.NativeFieldInfoPtr_PlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEmitTutorialEvent.NativeFieldInfoPtr_PlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BF6 RID: 3062
		private static readonly IntPtr NativeFieldInfoPtr_TutorialActions;

		// Token: 0x04000BF7 RID: 3063
		private static readonly IntPtr NativeFieldInfoPtr_PlayerID;

		// Token: 0x04000BF8 RID: 3064
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000BF9 RID: 3065
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

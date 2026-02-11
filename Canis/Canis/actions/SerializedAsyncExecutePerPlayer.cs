using System;
using Canis.actions.serialized;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions
{
	// Token: 0x0200019A RID: 410
	public class SerializedAsyncExecutePerPlayer : SerializedAction
	{
		// Token: 0x060011E0 RID: 4576 RVA: 0x00061CF4 File Offset: 0x0005FEF4
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedAsyncExecutePerPlayer()
		{
			Il2CppClassPointerStore<SerializedAsyncExecutePerPlayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SerializedAsyncExecutePerPlayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedAsyncExecutePerPlayer>.NativeClassPtr);
			SerializedAsyncExecutePerPlayer.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedAsyncExecutePerPlayer>.NativeClassPtr, "ID");
			SerializedAsyncExecutePerPlayer.NativeFieldInfoPtr_RunningPlayerIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedAsyncExecutePerPlayer>.NativeClassPtr, "RunningPlayerIDs");
			SerializedAsyncExecutePerPlayer.NativeFieldInfoPtr_CurrentPlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedAsyncExecutePerPlayer>.NativeClassPtr, "CurrentPlayerID");
			SerializedAsyncExecutePerPlayer.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedAsyncExecutePerPlayer>.NativeClassPtr, 100667077);
			SerializedAsyncExecutePerPlayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedAsyncExecutePerPlayer>.NativeClassPtr, 100667078);
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x00061D88 File Offset: 0x0005FF88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 584568, XrefRangeEnd = 584597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedAsyncExecutePerPlayer.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x00061DE4 File Offset: 0x0005FFE4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedAsyncExecutePerPlayer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedAsyncExecutePerPlayer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedAsyncExecutePerPlayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x00008E0F File Offset: 0x0000700F
		public SerializedAsyncExecutePerPlayer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x060011E4 RID: 4580 RVA: 0x00061E20 File Offset: 0x00060020
		// (set) Token: 0x060011E5 RID: 4581 RVA: 0x00008E18 File Offset: 0x00007018
		public unsafe WrappedID ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAsyncExecutePerPlayer.NativeFieldInfoPtr_ID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WrappedID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAsyncExecutePerPlayer.NativeFieldInfoPtr_ID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x060011E6 RID: 4582 RVA: 0x00061E50 File Offset: 0x00060050
		// (set) Token: 0x060011E7 RID: 4583 RVA: 0x00008E37 File Offset: 0x00007037
		public unsafe List<EntityID> RunningPlayerIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAsyncExecutePerPlayer.NativeFieldInfoPtr_RunningPlayerIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAsyncExecutePerPlayer.NativeFieldInfoPtr_RunningPlayerIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x060011E8 RID: 4584 RVA: 0x00061E80 File Offset: 0x00060080
		// (set) Token: 0x060011E9 RID: 4585 RVA: 0x00008E56 File Offset: 0x00007056
		public unsafe EntityID CurrentPlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAsyncExecutePerPlayer.NativeFieldInfoPtr_CurrentPlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAsyncExecutePerPlayer.NativeFieldInfoPtr_CurrentPlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BB4 RID: 2996
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x04000BB5 RID: 2997
		private static readonly IntPtr NativeFieldInfoPtr_RunningPlayerIDs;

		// Token: 0x04000BB6 RID: 2998
		private static readonly IntPtr NativeFieldInfoPtr_CurrentPlayerID;

		// Token: 0x04000BB7 RID: 2999
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000BB8 RID: 3000
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

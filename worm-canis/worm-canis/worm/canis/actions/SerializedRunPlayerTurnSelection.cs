using System;
using Canis;
using Canis.actions;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x02000296 RID: 662
	public class SerializedRunPlayerTurnSelection : SerializedStateMachineAction
	{
		// Token: 0x06001B9F RID: 7071 RVA: 0x000C43C4 File Offset: 0x000C25C4
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedRunPlayerTurnSelection()
		{
			Il2CppClassPointerStore<SerializedRunPlayerTurnSelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedRunPlayerTurnSelection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedRunPlayerTurnSelection>.NativeClassPtr);
			SerializedRunPlayerTurnSelection.NativeFieldInfoPtr_SelectingPlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedRunPlayerTurnSelection>.NativeClassPtr, "SelectingPlayerID");
			SerializedRunPlayerTurnSelection.NativeFieldInfoPtr_UndoNodeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedRunPlayerTurnSelection>.NativeClassPtr, "UndoNodeID");
			SerializedRunPlayerTurnSelection.NativeFieldInfoPtr_SelectedAbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedRunPlayerTurnSelection>.NativeClassPtr, "SelectedAbilityID");
			SerializedRunPlayerTurnSelection.NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedRunPlayerTurnSelection>.NativeClassPtr, 100668814);
			SerializedRunPlayerTurnSelection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedRunPlayerTurnSelection>.NativeClassPtr, 100668815);
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x000C4458 File Offset: 0x000C2658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146952, XrefRangeEnd = 146958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override StateMachineAction GenStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedRunPlayerTurnSelection.NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x000C44B4 File Offset: 0x000C26B4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146958, XrefRangeEnd = 146959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedRunPlayerTurnSelection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedRunPlayerTurnSelection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedRunPlayerTurnSelection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x0000BCBB File Offset: 0x00009EBB
		public SerializedRunPlayerTurnSelection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06001BA3 RID: 7075 RVA: 0x000C44F0 File Offset: 0x000C26F0
		// (set) Token: 0x06001BA4 RID: 7076 RVA: 0x0000BCC4 File Offset: 0x00009EC4
		public unsafe EntityID SelectingPlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunPlayerTurnSelection.NativeFieldInfoPtr_SelectingPlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunPlayerTurnSelection.NativeFieldInfoPtr_SelectingPlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06001BA5 RID: 7077 RVA: 0x000C4520 File Offset: 0x000C2720
		// (set) Token: 0x06001BA6 RID: 7078 RVA: 0x0000BCE3 File Offset: 0x00009EE3
		public unsafe EntityID UndoNodeID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunPlayerTurnSelection.NativeFieldInfoPtr_UndoNodeID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunPlayerTurnSelection.NativeFieldInfoPtr_UndoNodeID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06001BA7 RID: 7079 RVA: 0x000C4550 File Offset: 0x000C2750
		// (set) Token: 0x06001BA8 RID: 7080 RVA: 0x0000BD02 File Offset: 0x00009F02
		public unsafe EntityID SelectedAbilityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunPlayerTurnSelection.NativeFieldInfoPtr_SelectedAbilityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunPlayerTurnSelection.NativeFieldInfoPtr_SelectedAbilityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400110F RID: 4367
		private static readonly IntPtr NativeFieldInfoPtr_SelectingPlayerID;

		// Token: 0x04001110 RID: 4368
		private static readonly IntPtr NativeFieldInfoPtr_UndoNodeID;

		// Token: 0x04001111 RID: 4369
		private static readonly IntPtr NativeFieldInfoPtr_SelectedAbilityID;

		// Token: 0x04001112 RID: 4370
		private static readonly IntPtr NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0;

		// Token: 0x04001113 RID: 4371
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

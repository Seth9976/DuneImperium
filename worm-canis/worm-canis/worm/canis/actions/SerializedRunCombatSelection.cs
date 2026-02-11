using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x02000290 RID: 656
	public class SerializedRunCombatSelection : SerializedAction
	{
		// Token: 0x06001B69 RID: 7017 RVA: 0x000C36D0 File Offset: 0x000C18D0
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedRunCombatSelection()
		{
			Il2CppClassPointerStore<SerializedRunCombatSelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedRunCombatSelection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedRunCombatSelection>.NativeClassPtr);
			SerializedRunCombatSelection.NativeFieldInfoPtr_SelectingPlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedRunCombatSelection>.NativeClassPtr, "SelectingPlayerID");
			SerializedRunCombatSelection.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedRunCombatSelection>.NativeClassPtr, 100668739);
			SerializedRunCombatSelection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedRunCombatSelection>.NativeClassPtr, 100668740);
		}

		// Token: 0x06001B6A RID: 7018 RVA: 0x000C373C File Offset: 0x000C193C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146454, XrefRangeEnd = 146465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedRunCombatSelection.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x000C3798 File Offset: 0x000C1998
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedRunCombatSelection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedRunCombatSelection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedRunCombatSelection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x0000BB58 File Offset: 0x00009D58
		public SerializedRunCombatSelection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06001B6D RID: 7021 RVA: 0x000C37D4 File Offset: 0x000C19D4
		// (set) Token: 0x06001B6E RID: 7022 RVA: 0x0000BB61 File Offset: 0x00009D61
		public unsafe EntityID SelectingPlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunCombatSelection.NativeFieldInfoPtr_SelectingPlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunCombatSelection.NativeFieldInfoPtr_SelectingPlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010E8 RID: 4328
		private static readonly IntPtr NativeFieldInfoPtr_SelectingPlayerID;

		// Token: 0x040010E9 RID: 4329
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x040010EA RID: 4330
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

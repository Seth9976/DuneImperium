using System;
using Canis.actions;
using Canis.context;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Canis.entities
{
	// Token: 0x020000BC RID: 188
	public class IAbilityDefinitionWithUndo : Il2CppObjectBase
	{
		// Token: 0x060008B9 RID: 2233 RVA: 0x0000564F File Offset: 0x0000384F
		// Note: this type is marked as 'beforefieldinit'.
		static IAbilityDefinitionWithUndo()
		{
			Il2CppClassPointerStore<IAbilityDefinitionWithUndo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "IAbilityDefinitionWithUndo");
			IAbilityDefinitionWithUndo.NativeMethodInfoPtr_Undo_Public_Abstract_Virtual_New_IEnumerable_1_Action_UndoNode_PlayerEntity_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAbilityDefinitionWithUndo>.NativeClassPtr, 100665097);
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x0003CF78 File Offset: 0x0003B178
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Action> Undo(UndoNode node, PlayerEntity player, Match match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAbilityDefinitionWithUndo.NativeMethodInfoPtr_Undo_Public_Abstract_Virtual_New_IEnumerable_1_Action_UndoNode_PlayerEntity_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x0000567E File Offset: 0x0000387E
		public IAbilityDefinitionWithUndo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeMethodInfoPtr_Undo_Public_Abstract_Virtual_New_IEnumerable_1_Action_UndoNode_PlayerEntity_Match_Context_0;
	}
}

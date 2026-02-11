using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Networking.selection.targetinformation;

namespace Canis.entities
{
	// Token: 0x020000E9 RID: 233
	public class IUndoableSelection : Il2CppObjectBase
	{
		// Token: 0x06000A61 RID: 2657 RVA: 0x000458B8 File Offset: 0x00043AB8
		// Note: this type is marked as 'beforefieldinit'.
		static IUndoableSelection()
		{
			Il2CppClassPointerStore<IUndoableSelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "IUndoableSelection");
			IUndoableSelection.NativeMethodInfoPtr_AddUndoToSelection_Public_Abstract_Virtual_New_Void_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUndoableSelection>.NativeClassPtr, 100665490);
			IUndoableSelection.NativeMethodInfoPtr_GetUndoForSelection_Public_Abstract_Virtual_New_IEnumerable_1_AbilityDefinition_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUndoableSelection>.NativeClassPtr, 100665491);
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x00045908 File Offset: 0x00043B08
		[CallerCount(0)]
		public unsafe virtual void AddUndoToSelection(Dictionary<EntityID, Il2CppReferenceArray<TargetInformation>> targets, PlayerEntity selectingPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targets);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectingPlayer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUndoableSelection.NativeMethodInfoPtr_AddUndoToSelection_Public_Abstract_Virtual_New_Void_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x00045968 File Offset: 0x00043B68
		[CallerCount(0)]
		public unsafe virtual IEnumerable<AbilityDefinition> GetUndoForSelection(PlayerEntity selectingPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectingPlayer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUndoableSelection.NativeMethodInfoPtr_GetUndoForSelection_Public_Abstract_Virtual_New_IEnumerable_1_AbilityDefinition_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AbilityDefinition>>(intPtr3) : null;
			}
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x00005D3C File Offset: 0x00003F3C
		public IUndoableSelection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000714 RID: 1812
		private static readonly IntPtr NativeMethodInfoPtr_AddUndoToSelection_Public_Abstract_Virtual_New_Void_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_PlayerEntity_0;

		// Token: 0x04000715 RID: 1813
		private static readonly IntPtr NativeMethodInfoPtr_GetUndoForSelection_Public_Abstract_Virtual_New_IEnumerable_1_AbilityDefinition_PlayerEntity_0;
	}
}

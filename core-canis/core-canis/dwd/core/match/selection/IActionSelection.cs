using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.match.selection
{
	// Token: 0x02000131 RID: 305
	public class IActionSelection : Il2CppObjectBase
	{
		// Token: 0x0600116C RID: 4460 RVA: 0x00059168 File Offset: 0x00057368
		// Note: this type is marked as 'beforefieldinit'.
		static IActionSelection()
		{
			Il2CppClassPointerStore<IActionSelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "IActionSelection");
			IActionSelection.NativeMethodInfoPtr_get_SelectedAbility_Public_Abstract_Virtual_New_get_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IActionSelection>.NativeClassPtr, 100665847);
			IActionSelection.NativeMethodInfoPtr_get_AvailableAbilities_Public_Abstract_Virtual_New_get_IEnumerable_1_SelectableAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IActionSelection>.NativeClassPtr, 100665848);
			IActionSelection.NativeMethodInfoPtr_Select_Public_Abstract_Virtual_New_Void_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IActionSelection>.NativeClassPtr, 100665849);
			IActionSelection.NativeMethodInfoPtr_Unselect_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IActionSelection>.NativeClassPtr, 100665850);
			IActionSelection.NativeMethodInfoPtr_PeekNode_Public_Abstract_Virtual_New_ISelectionNode_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IActionSelection>.NativeClassPtr, 100665851);
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x0600116D RID: 4461 RVA: 0x000591F4 File Offset: 0x000573F4
		public unsafe virtual AbilityID SelectedAbility
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IActionSelection.NativeMethodInfoPtr_get_SelectedAbility_Public_Abstract_Virtual_New_get_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x0600116E RID: 4462 RVA: 0x00059240 File Offset: 0x00057440
		public unsafe virtual IEnumerable<SelectableAction> AvailableAbilities
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IActionSelection.NativeMethodInfoPtr_get_AvailableAbilities_Public_Abstract_Virtual_New_get_IEnumerable_1_SelectableAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<SelectableAction>>(intPtr3) : null;
			}
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x0005928C File Offset: 0x0005748C
		[CallerCount(0)]
		public unsafe virtual void Select(AbilityID selection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IActionSelection.NativeMethodInfoPtr_Select_Public_Abstract_Virtual_New_Void_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x000592DC File Offset: 0x000574DC
		[CallerCount(0)]
		public unsafe virtual void Unselect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IActionSelection.NativeMethodInfoPtr_Unselect_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x00059318 File Offset: 0x00057518
		[CallerCount(0)]
		public unsafe virtual ISelectionNode PeekNode(AbilityID abilityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(abilityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IActionSelection.NativeMethodInfoPtr_PeekNode_Public_Abstract_Virtual_New_ISelectionNode_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x000080B6 File Offset: 0x000062B6
		public IActionSelection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C66 RID: 3174
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedAbility_Public_Abstract_Virtual_New_get_AbilityID_0;

		// Token: 0x04000C67 RID: 3175
		private static readonly IntPtr NativeMethodInfoPtr_get_AvailableAbilities_Public_Abstract_Virtual_New_get_IEnumerable_1_SelectableAction_0;

		// Token: 0x04000C68 RID: 3176
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Abstract_Virtual_New_Void_AbilityID_0;

		// Token: 0x04000C69 RID: 3177
		private static readonly IntPtr NativeMethodInfoPtr_Unselect_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000C6A RID: 3178
		private static readonly IntPtr NativeMethodInfoPtr_PeekNode_Public_Abstract_Virtual_New_ISelectionNode_AbilityID_0;
	}
}

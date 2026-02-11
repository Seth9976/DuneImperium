using System;
using Canis.actions;
using Canis.context;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Networking.selection.targetinformation;

namespace Canis.entities
{
	// Token: 0x020000B8 RID: 184
	public class IAbilityDefinition : Il2CppObjectBase
	{
		// Token: 0x0600088C RID: 2188 RVA: 0x0003BDF0 File Offset: 0x00039FF0
		// Note: this type is marked as 'beforefieldinit'.
		static IAbilityDefinition()
		{
			Il2CppClassPointerStore<IAbilityDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "IAbilityDefinition");
			IAbilityDefinition.NativeMethodInfoPtr_get_Self_Public_Abstract_Virtual_New_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAbilityDefinition>.NativeClassPtr, 100665047);
			IAbilityDefinition.NativeMethodInfoPtr_get_Owner_Public_Abstract_Virtual_New_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAbilityDefinition>.NativeClassPtr, 100665048);
			IAbilityDefinition.NativeMethodInfoPtr_Action_Public_Abstract_Virtual_New_IEnumerable_1_Action_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAbilityDefinition>.NativeClassPtr, 100665049);
			IAbilityDefinition.NativeMethodInfoPtr_Cost_Public_Abstract_Virtual_New_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAbilityDefinition>.NativeClassPtr, 100665050);
			IAbilityDefinition.NativeMethodInfoPtr_Targets_Public_Abstract_Virtual_New_IEnumerable_1_TargetInformation_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAbilityDefinition>.NativeClassPtr, 100665051);
			IAbilityDefinition.NativeMethodInfoPtr_HasValidTargets_Public_Abstract_Virtual_New_Boolean_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAbilityDefinition>.NativeClassPtr, 100665052);
			IAbilityDefinition.NativeMethodInfoPtr_GetSourceEntityID_Public_Abstract_Virtual_New_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAbilityDefinition>.NativeClassPtr, 100665053);
			IAbilityDefinition.NativeMethodInfoPtr_CanBeRun_Public_Abstract_Virtual_New_Boolean_Match_PlayerEntity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAbilityDefinition>.NativeClassPtr, 100665054);
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600088D RID: 2189 RVA: 0x0003BEB8 File Offset: 0x0003A0B8
		public unsafe virtual Entity Self
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAbilityDefinition.NativeMethodInfoPtr_get_Self_Public_Abstract_Virtual_New_get_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600088E RID: 2190 RVA: 0x0003BF04 File Offset: 0x0003A104
		public unsafe virtual Entity Owner
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAbilityDefinition.NativeMethodInfoPtr_get_Owner_Public_Abstract_Virtual_New_get_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x0003BF50 File Offset: 0x0003A150
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Action> Action(Match match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAbilityDefinition.NativeMethodInfoPtr_Action_Public_Abstract_Virtual_New_IEnumerable_1_Action_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x0003BFC0 File Offset: 0x0003A1C0
		[CallerCount(0)]
		public unsafe virtual CostAction Cost(Match match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAbilityDefinition.NativeMethodInfoPtr_Cost_Public_Abstract_Virtual_New_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x0003C030 File Offset: 0x0003A230
		[CallerCount(0)]
		public unsafe virtual IEnumerable<TargetInformation> Targets(Match match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAbilityDefinition.NativeMethodInfoPtr_Targets_Public_Abstract_Virtual_New_IEnumerable_1_TargetInformation_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TargetInformation>>(intPtr3) : null;
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x0003C0A0 File Offset: 0x0003A2A0
		[CallerCount(0)]
		public unsafe virtual bool HasValidTargets(Match match, Context targetContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAbilityDefinition.NativeMethodInfoPtr_HasValidTargets_Public_Abstract_Virtual_New_Boolean_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x0003C10C File Offset: 0x0003A30C
		[CallerCount(0)]
		public unsafe virtual EntityID GetSourceEntityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAbilityDefinition.NativeMethodInfoPtr_GetSourceEntityID_Public_Abstract_Virtual_New_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x0003C158 File Offset: 0x0003A358
		[CallerCount(0)]
		public unsafe virtual bool CanBeRun(Match match, PlayerEntity player, Context paramContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAbilityDefinition.NativeMethodInfoPtr_CanBeRun_Public_Abstract_Virtual_New_Boolean_Match_PlayerEntity_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x000055FC File Offset: 0x000037FC
		public IAbilityDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeMethodInfoPtr_get_Self_Public_Abstract_Virtual_New_get_Entity_0;

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeMethodInfoPtr_get_Owner_Public_Abstract_Virtual_New_get_Entity_0;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeMethodInfoPtr_Action_Public_Abstract_Virtual_New_IEnumerable_1_Action_Match_Context_0;

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Abstract_Virtual_New_CostAction_Match_Context_0;

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeMethodInfoPtr_Targets_Public_Abstract_Virtual_New_IEnumerable_1_TargetInformation_Match_Context_0;

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeMethodInfoPtr_HasValidTargets_Public_Abstract_Virtual_New_Boolean_Match_Context_0;

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceEntityID_Public_Abstract_Virtual_New_EntityID_0;

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeMethodInfoPtr_CanBeRun_Public_Abstract_Virtual_New_Boolean_Match_PlayerEntity_Context_0;
	}
}

using System;
using Canis.actions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.entities
{
	// Token: 0x020000E2 RID: 226
	public class IHasAbilities<TMatch, TAbilityDefinition> : Il2CppObjectBase where TMatch : Match where TAbilityDefinition : AbilityDefinitionForGame<TMatch>
	{
		// Token: 0x06000A42 RID: 2626 RVA: 0x00044EDC File Offset: 0x000430DC
		// Note: this type is marked as 'beforefieldinit'.
		static IHasAbilities()
		{
			Il2CppClassPointerStore<IHasAbilities<TMatch, TAbilityDefinition>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "IHasAbilities`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityDefinition>.NativeClassPtr))
			})).TypeHandle.value);
			IHasAbilities<TMatch, TAbilityDefinition>.NativeMethodInfoPtr_get_Abilities_Public_Abstract_Virtual_New_get_IEnumerable_1_TAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasAbilities<TMatch, TAbilityDefinition>>.NativeClassPtr, 100665456);
			IHasAbilities<TMatch, TAbilityDefinition>.NativeMethodInfoPtr_AddChildAbility_Public_Abstract_Virtual_New_IEnumerable_1_Action_TAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasAbilities<TMatch, TAbilityDefinition>>.NativeClassPtr, 100665457);
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x00044F78 File Offset: 0x00043178
		public unsafe virtual IEnumerable<TAbilityDefinition> Abilities
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasAbilities<TMatch, TAbilityDefinition>.NativeMethodInfoPtr_get_Abilities_Public_Abstract_Virtual_New_get_IEnumerable_1_TAbilityDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TAbilityDefinition>>(intPtr3) : null;
			}
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00044FC4 File Offset: 0x000431C4
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Canis.actions.Action> AddChildAbility(TAbilityDefinition abilityDefinition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TAbilityDefinition).IsValueType)
				{
					TAbilityDefinition tabilityDefinition = abilityDefinition;
					intPtr = ((tabilityDefinition is string) ? IL2CPP.ManagedStringToIl2Cpp(tabilityDefinition as string) : IL2CPP.Il2CppObjectBaseToPtr(tabilityDefinition as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref abilityDefinition;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasAbilities<TMatch, TAbilityDefinition>.NativeMethodInfoPtr_AddChildAbility_Public_Abstract_Virtual_New_IEnumerable_1_Action_TAbilityDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr4) : null;
			}
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x00005CEB File Offset: 0x00003EEB
		public IHasAbilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006FD RID: 1789
		private static readonly IntPtr NativeMethodInfoPtr_get_Abilities_Public_Abstract_Virtual_New_get_IEnumerable_1_TAbilityDefinition_0;

		// Token: 0x040006FE RID: 1790
		private static readonly IntPtr NativeMethodInfoPtr_AddChildAbility_Public_Abstract_Virtual_New_IEnumerable_1_Action_TAbilityDefinition_0;
	}
}

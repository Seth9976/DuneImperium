using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.entities
{
	// Token: 0x020000C8 RID: 200
	public class StateBehaviorV2<TMatch, TActiveAbility, TAbilityDefinition> : Object where TMatch : Match where TActiveAbility : ActiveAbility<TMatch, TAbilityDefinition> where TAbilityDefinition : AbilityDefinitionForGame<TMatch>
	{
		// Token: 0x06000915 RID: 2325 RVA: 0x0003F21C File Offset: 0x0003D41C
		// Note: this type is marked as 'beforefieldinit'.
		static StateBehaviorV2()
		{
			Il2CppClassPointerStore<StateBehaviorV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "StateBehaviorV2`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TActiveAbility>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityDefinition>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateBehaviorV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr);
			StateBehaviorV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_Action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateBehaviorV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, "Action");
			StateBehaviorV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_Transition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateBehaviorV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, "Transition");
			StateBehaviorV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateBehaviorV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665194);
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x0003F2E8 File Offset: 0x0003D4E8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StateBehaviorV2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateBehaviorV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateBehaviorV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x000057DF File Offset: 0x000039DF
		public StateBehaviorV2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000918 RID: 2328 RVA: 0x0003F324 File Offset: 0x0003D524
		// (set) Token: 0x06000919 RID: 2329 RVA: 0x000057E8 File Offset: 0x000039E8
		public unsafe StateAction<TMatch, TActiveAbility, TAbilityDefinition> Action
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateBehaviorV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_Action);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StateAction<TMatch, TActiveAbility, TAbilityDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateBehaviorV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_Action), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x0003F354 File Offset: 0x0003D554
		// (set) Token: 0x0600091B RID: 2331 RVA: 0x00005807 File Offset: 0x00003A07
		public unsafe Transition<TActiveAbility> Transition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateBehaviorV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_Transition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transition<TActiveAbility>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateBehaviorV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_Transition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400062D RID: 1581
		private static readonly IntPtr NativeFieldInfoPtr_Action;

		// Token: 0x0400062E RID: 1582
		private static readonly IntPtr NativeFieldInfoPtr_Transition;

		// Token: 0x0400062F RID: 1583
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Canis;
using Canis.actions;
using Canis.attributes;
using Canis.context;
using Canis.entities;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lib.canis.data.enums;
using Networking.selection.targetinformation;
using worm.canis.ai;
using worm.canis.ai.choices;
using worm.canis.data.enums;
using worm.canis.entities;

namespace worm.canis.abilities.ActivatedAbilities.RiseOfIx
{
	// Token: 0x020004D6 RID: 1238
	public class DoubleAgentsAcquireLastAcquired : DeferredAbility
	{
		// Token: 0x0600381E RID: 14366 RVA: 0x0014B2C8 File Offset: 0x001494C8
		// Note: this type is marked as 'beforefieldinit'.
		static DoubleAgentsAcquireLastAcquired()
		{
			Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.ActivatedAbilities.RiseOfIx", "DoubleAgentsAcquireLastAcquired");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired>.NativeClassPtr);
			DoubleAgentsAcquireLastAcquired.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired>.NativeClassPtr, "AbilityName");
			DoubleAgentsAcquireLastAcquired.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired>.NativeClassPtr, "AbilityID");
			DoubleAgentsAcquireLastAcquired.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired>.NativeClassPtr, 100681202);
			DoubleAgentsAcquireLastAcquired.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired>.NativeClassPtr, 100681203);
			DoubleAgentsAcquireLastAcquired.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired>.NativeClassPtr, 100681204);
			DoubleAgentsAcquireLastAcquired.NativeMethodInfoPtr_IsUnexhausted_Protected_Virtual_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired>.NativeClassPtr, 100681205);
			DoubleAgentsAcquireLastAcquired.NativeMethodInfoPtr_SelectionMode_Public_Virtual_DeferredSelectionMode_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired>.NativeClassPtr, 100681206);
			DoubleAgentsAcquireLastAcquired.NativeMethodInfoPtr_CanRunImmediately_Public_Virtual_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired>.NativeClassPtr, 100681207);
			DoubleAgentsAcquireLastAcquired.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired>.NativeClassPtr, 100681208);
			DoubleAgentsAcquireLastAcquired.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired>.NativeClassPtr, 100681209);
			DoubleAgentsAcquireLastAcquired.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired>.NativeClassPtr, 100681210);
			DoubleAgentsAcquireLastAcquired.NativeMethodInfoPtr_GetArchetypesToCopy_Public_Static_List_1_ArchetypeID_WormPlayer_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired>.NativeClassPtr, 100681211);
			DoubleAgentsAcquireLastAcquired.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired>.NativeClassPtr, 100681212);
			DoubleAgentsAcquireLastAcquired.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired>.NativeClassPtr, 100681213);
			DoubleAgentsAcquireLastAcquired.NativeMethodInfoPtr__Evaluate_b__13_0_Private_IEnumerable_1_Entity_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired>.NativeClassPtr, 100681215);
		}

		// Token: 0x0600381F RID: 14367 RVA: 0x0014B424 File Offset: 0x00149624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250490, XrefRangeEnd = 250494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoubleAgentsAcquireLastAcquired.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06003820 RID: 14368 RVA: 0x0014B470 File Offset: 0x00149670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250494, XrefRangeEnd = 250507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoubleAgentsAcquireLastAcquired(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleAgentsAcquireLastAcquired.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003821 RID: 14369 RVA: 0x0014B4BC File Offset: 0x001496BC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoubleAgentsAcquireLastAcquired(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleAgentsAcquireLastAcquired.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003822 RID: 14370 RVA: 0x0014B52C File Offset: 0x0014972C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsUnexhausted(PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoubleAgentsAcquireLastAcquired.NativeMethodInfoPtr_IsUnexhausted_Protected_Virtual_Boolean_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003823 RID: 14371 RVA: 0x0014B584 File Offset: 0x00149784
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 25008, RefRangeEnd = 25013, XrefRangeStart = 25008, XrefRangeEnd = 25013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DeferredSelectionMode SelectionMode(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoubleAgentsAcquireLastAcquired.NativeMethodInfoPtr_SelectionMode_Public_Virtual_DeferredSelectionMode_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003824 RID: 14372 RVA: 0x0014B5DC File Offset: 0x001497DC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanRunImmediately(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoubleAgentsAcquireLastAcquired.NativeMethodInfoPtr_CanRunImmediately_Public_Virtual_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003825 RID: 14373 RVA: 0x0014B634 File Offset: 0x00149834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250507, XrefRangeEnd = 250511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override CostAction Cost(Match match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoubleAgentsAcquireLastAcquired.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x06003826 RID: 14374 RVA: 0x0014B6A4 File Offset: 0x001498A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250511, XrefRangeEnd = 250518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<TargetInformation> Targets(Match match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoubleAgentsAcquireLastAcquired.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TargetInformation>>(intPtr3) : null;
		}

		// Token: 0x06003827 RID: 14375 RVA: 0x0014B714 File Offset: 0x00149914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250518, XrefRangeEnd = 250526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> BeginExecution(WormActiveAbility activeAbility, WormMatch match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeAbility);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoubleAgentsAcquireLastAcquired.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06003828 RID: 14376 RVA: 0x0014B794 File Offset: 0x00149994
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 250583, RefRangeEnd = 250586, XrefRangeStart = 250526, XrefRangeEnd = 250583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<ArchetypeID> GetArchetypesToCopy(WormPlayer player, WormSpace space)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(space);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleAgentsAcquireLastAcquired.NativeMethodInfoPtr_GetArchetypesToCopy_Public_Static_List_1_ArchetypeID_WormPlayer_WormSpace_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr3) : null;
		}

		// Token: 0x06003829 RID: 14377 RVA: 0x0014B7EC File Offset: 0x001499EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25007, RefRangeEnd = 25008, XrefRangeStart = 25007, XrefRangeEnd = 25008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ResumeExecution(WormActiveAbility activeAbility, global::Canis.actions.Action returningAction, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeAbility);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(returningAction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoubleAgentsAcquireLastAcquired.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600382A RID: 14378 RVA: 0x0014B868 File Offset: 0x00149A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250586, XrefRangeEnd = 250679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WormAIChoice Evaluate(WormAIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoubleAgentsAcquireLastAcquired.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x0600382B RID: 14379 RVA: 0x0014B8C4 File Offset: 0x00149AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250679, XrefRangeEnd = 250689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Entity> _Evaluate_b__13_0(EntityID id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleAgentsAcquireLastAcquired.NativeMethodInfoPtr__Evaluate_b__13_0_Private_IEnumerable_1_Entity_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x0600382C RID: 14380 RVA: 0x00012AE7 File Offset: 0x00010CE7
		public DoubleAgentsAcquireLastAcquired(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x0600382D RID: 14381 RVA: 0x0014B914 File Offset: 0x00149B14
		// (set) Token: 0x0600382E RID: 14382 RVA: 0x00012AF0 File Offset: 0x00010CF0
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DoubleAgentsAcquireLastAcquired.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DoubleAgentsAcquireLastAcquired.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x0600382F RID: 14383 RVA: 0x0014B934 File Offset: 0x00149B34
		// (set) Token: 0x06003830 RID: 14384 RVA: 0x00012B02 File Offset: 0x00010D02
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DoubleAgentsAcquireLastAcquired.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DoubleAgentsAcquireLastAcquired.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040024C9 RID: 9417
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x040024CA RID: 9418
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x040024CB RID: 9419
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x040024CC RID: 9420
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x040024CD RID: 9421
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x040024CE RID: 9422
		private static readonly IntPtr NativeMethodInfoPtr_IsUnexhausted_Protected_Virtual_Boolean_PlayerEntity_0;

		// Token: 0x040024CF RID: 9423
		private static readonly IntPtr NativeMethodInfoPtr_SelectionMode_Public_Virtual_DeferredSelectionMode_Context_0;

		// Token: 0x040024D0 RID: 9424
		private static readonly IntPtr NativeMethodInfoPtr_CanRunImmediately_Public_Virtual_Boolean_Context_0;

		// Token: 0x040024D1 RID: 9425
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x040024D2 RID: 9426
		private static readonly IntPtr NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0;

		// Token: 0x040024D3 RID: 9427
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x040024D4 RID: 9428
		private static readonly IntPtr NativeMethodInfoPtr_GetArchetypesToCopy_Public_Static_List_1_ArchetypeID_WormPlayer_WormSpace_0;

		// Token: 0x040024D5 RID: 9429
		private static readonly IntPtr NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0;

		// Token: 0x040024D6 RID: 9430
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0;

		// Token: 0x040024D7 RID: 9431
		private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__13_0_Private_IEnumerable_1_Entity_EntityID_0;

		// Token: 0x02000BBE RID: 3006
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.RiseOfIx.DoubleAgentsAcquireLastAcquired+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600C01F RID: 49183 RVA: 0x002F5EB8 File Offset: 0x002F40B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired.__c>.NativeClassPtr);
				DoubleAgentsAcquireLastAcquired.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired.__c>.NativeClassPtr, "<>9");
				DoubleAgentsAcquireLastAcquired.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired.__c>.NativeClassPtr, "<>9__9_0");
				DoubleAgentsAcquireLastAcquired.__c.NativeFieldInfoPtr___9__9_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired.__c>.NativeClassPtr, "<>9__9_1");
				DoubleAgentsAcquireLastAcquired.__c.NativeFieldInfoPtr___9__9_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired.__c>.NativeClassPtr, "<>9__9_2");
				DoubleAgentsAcquireLastAcquired.__c.NativeFieldInfoPtr___9__11_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired.__c>.NativeClassPtr, "<>9__11_1");
				DoubleAgentsAcquireLastAcquired.__c.NativeFieldInfoPtr___9__11_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired.__c>.NativeClassPtr, "<>9__11_2");
				DoubleAgentsAcquireLastAcquired.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired.__c>.NativeClassPtr, 100681217);
				DoubleAgentsAcquireLastAcquired.__c.NativeMethodInfoPtr__Targets_b__9_0_Internal_Boolean_WormFactionTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired.__c>.NativeClassPtr, 100681218);
				DoubleAgentsAcquireLastAcquired.__c.NativeMethodInfoPtr__Targets_b__9_1_Internal_EntityID_WormFactionTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired.__c>.NativeClassPtr, 100681219);
				DoubleAgentsAcquireLastAcquired.__c.NativeMethodInfoPtr__Targets_b__9_2_Internal_ReadOnlyAttributes_WormFactionTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired.__c>.NativeClassPtr, 100681220);
				DoubleAgentsAcquireLastAcquired.__c.NativeMethodInfoPtr__GetArchetypesToCopy_b__11_1_Internal_ArchetypeID_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired.__c>.NativeClassPtr, 100681221);
				DoubleAgentsAcquireLastAcquired.__c.NativeMethodInfoPtr__GetArchetypesToCopy_b__11_2_Internal_Boolean_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired.__c>.NativeClassPtr, 100681222);
			}

			// Token: 0x0600C020 RID: 49184 RVA: 0x002F5FD4 File Offset: 0x002F41D4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleAgentsAcquireLastAcquired.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C021 RID: 49185 RVA: 0x002F6010 File Offset: 0x002F4210
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Targets_b__9_0(WormFactionTrack _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleAgentsAcquireLastAcquired.__c.NativeMethodInfoPtr__Targets_b__9_0_Internal_Boolean_WormFactionTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600C022 RID: 49186 RVA: 0x002F6060 File Offset: 0x002F4260
			[CallerCount(0)]
			public unsafe EntityID _Targets_b__9_1(WormFactionTrack _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleAgentsAcquireLastAcquired.__c.NativeMethodInfoPtr__Targets_b__9_1_Internal_EntityID_WormFactionTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x0600C023 RID: 49187 RVA: 0x002F60B0 File Offset: 0x002F42B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250113, XrefRangeEnd = 250133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadOnlyAttributes _Targets_b__9_2(WormFactionTrack _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleAgentsAcquireLastAcquired.__c.NativeMethodInfoPtr__Targets_b__9_2_Internal_ReadOnlyAttributes_WormFactionTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
				}
			}

			// Token: 0x0600C024 RID: 49188 RVA: 0x002F6100 File Offset: 0x002F4300
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250133, XrefRangeEnd = 250145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArchetypeID _GetArchetypesToCopy_b__11_1(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleAgentsAcquireLastAcquired.__c.NativeMethodInfoPtr__GetArchetypesToCopy_b__11_1_Internal_ArchetypeID_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
				}
			}

			// Token: 0x0600C025 RID: 49189 RVA: 0x002F6150 File Offset: 0x002F4350
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250145, XrefRangeEnd = 250153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetArchetypesToCopy_b__11_2(ArchetypeID _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleAgentsAcquireLastAcquired.__c.NativeMethodInfoPtr__GetArchetypesToCopy_b__11_2_Internal_Boolean_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600C026 RID: 49190 RVA: 0x00059EAA File Offset: 0x000580AA
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003B91 RID: 15249
			// (get) Token: 0x0600C027 RID: 49191 RVA: 0x002F61A0 File Offset: 0x002F43A0
			// (set) Token: 0x0600C028 RID: 49192 RVA: 0x00059EB3 File Offset: 0x000580B3
			public unsafe static DoubleAgentsAcquireLastAcquired.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DoubleAgentsAcquireLastAcquired.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DoubleAgentsAcquireLastAcquired.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DoubleAgentsAcquireLastAcquired.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B92 RID: 15250
			// (get) Token: 0x0600C029 RID: 49193 RVA: 0x002F61C8 File Offset: 0x002F43C8
			// (set) Token: 0x0600C02A RID: 49194 RVA: 0x00059EC5 File Offset: 0x000580C5
			public unsafe static Func<WormFactionTrack, bool> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DoubleAgentsAcquireLastAcquired.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormFactionTrack, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DoubleAgentsAcquireLastAcquired.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B93 RID: 15251
			// (get) Token: 0x0600C02B RID: 49195 RVA: 0x002F61F0 File Offset: 0x002F43F0
			// (set) Token: 0x0600C02C RID: 49196 RVA: 0x00059ED7 File Offset: 0x000580D7
			public unsafe static Func<WormFactionTrack, EntityID> __9__9_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DoubleAgentsAcquireLastAcquired.__c.NativeFieldInfoPtr___9__9_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormFactionTrack, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DoubleAgentsAcquireLastAcquired.__c.NativeFieldInfoPtr___9__9_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B94 RID: 15252
			// (get) Token: 0x0600C02D RID: 49197 RVA: 0x002F6218 File Offset: 0x002F4418
			// (set) Token: 0x0600C02E RID: 49198 RVA: 0x00059EE9 File Offset: 0x000580E9
			public unsafe static Func<WormFactionTrack, ReadOnlyAttributes> __9__9_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DoubleAgentsAcquireLastAcquired.__c.NativeFieldInfoPtr___9__9_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormFactionTrack, ReadOnlyAttributes>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DoubleAgentsAcquireLastAcquired.__c.NativeFieldInfoPtr___9__9_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B95 RID: 15253
			// (get) Token: 0x0600C02F RID: 49199 RVA: 0x002F6240 File Offset: 0x002F4440
			// (set) Token: 0x0600C030 RID: 49200 RVA: 0x00059EFB File Offset: 0x000580FB
			public unsafe static Func<WormPlayer, ArchetypeID> __9__11_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DoubleAgentsAcquireLastAcquired.__c.NativeFieldInfoPtr___9__11_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DoubleAgentsAcquireLastAcquired.__c.NativeFieldInfoPtr___9__11_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B96 RID: 15254
			// (get) Token: 0x0600C031 RID: 49201 RVA: 0x002F6268 File Offset: 0x002F4468
			// (set) Token: 0x0600C032 RID: 49202 RVA: 0x00059F0D File Offset: 0x0005810D
			public unsafe static Func<ArchetypeID, bool> __9__11_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DoubleAgentsAcquireLastAcquired.__c.NativeFieldInfoPtr___9__11_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ArchetypeID, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DoubleAgentsAcquireLastAcquired.__c.NativeFieldInfoPtr___9__11_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400789F RID: 30879
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040078A0 RID: 30880
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x040078A1 RID: 30881
			private static readonly IntPtr NativeFieldInfoPtr___9__9_1;

			// Token: 0x040078A2 RID: 30882
			private static readonly IntPtr NativeFieldInfoPtr___9__9_2;

			// Token: 0x040078A3 RID: 30883
			private static readonly IntPtr NativeFieldInfoPtr___9__11_1;

			// Token: 0x040078A4 RID: 30884
			private static readonly IntPtr NativeFieldInfoPtr___9__11_2;

			// Token: 0x040078A5 RID: 30885
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040078A6 RID: 30886
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__9_0_Internal_Boolean_WormFactionTrack_0;

			// Token: 0x040078A7 RID: 30887
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__9_1_Internal_EntityID_WormFactionTrack_0;

			// Token: 0x040078A8 RID: 30888
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__9_2_Internal_ReadOnlyAttributes_WormFactionTrack_0;

			// Token: 0x040078A9 RID: 30889
			private static readonly IntPtr NativeMethodInfoPtr__GetArchetypesToCopy_b__11_1_Internal_ArchetypeID_WormPlayer_0;

			// Token: 0x040078AA RID: 30890
			private static readonly IntPtr NativeMethodInfoPtr__GetArchetypesToCopy_b__11_2_Internal_Boolean_ArchetypeID_0;
		}

		// Token: 0x02000BBF RID: 3007
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.RiseOfIx.DoubleAgentsAcquireLastAcquired+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x0600C033 RID: 49203 RVA: 0x002F6290 File Offset: 0x002F4490
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired.__c__DisplayClass11_0>.NativeClassPtr);
				DoubleAgentsAcquireLastAcquired.__c__DisplayClass11_0.NativeFieldInfoPtr_space = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired.__c__DisplayClass11_0>.NativeClassPtr, "space");
				DoubleAgentsAcquireLastAcquired.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired.__c__DisplayClass11_0>.NativeClassPtr, 100681223);
				DoubleAgentsAcquireLastAcquired.__c__DisplayClass11_0.NativeMethodInfoPtr__GetArchetypesToCopy_b__0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired.__c__DisplayClass11_0>.NativeClassPtr, 100681224);
			}

			// Token: 0x0600C034 RID: 49204 RVA: 0x002F62F8 File Offset: 0x002F44F8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleAgentsAcquireLastAcquired.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C035 RID: 49205 RVA: 0x002F6334 File Offset: 0x002F4534
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250153, XrefRangeEnd = 250169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetArchetypesToCopy_b__0(WormPlayer o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleAgentsAcquireLastAcquired.__c__DisplayClass11_0.NativeMethodInfoPtr__GetArchetypesToCopy_b__0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600C036 RID: 49206 RVA: 0x00059F1F File Offset: 0x0005811F
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003B97 RID: 15255
			// (get) Token: 0x0600C037 RID: 49207 RVA: 0x002F6384 File Offset: 0x002F4584
			// (set) Token: 0x0600C038 RID: 49208 RVA: 0x00059F28 File Offset: 0x00058128
			public unsafe WormSpace space
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired.__c__DisplayClass11_0.NativeFieldInfoPtr_space);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired.__c__DisplayClass11_0.NativeFieldInfoPtr_space), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040078AB RID: 30891
			private static readonly IntPtr NativeFieldInfoPtr_space;

			// Token: 0x040078AC RID: 30892
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040078AD RID: 30893
			private static readonly IntPtr NativeMethodInfoPtr__GetArchetypesToCopy_b__0_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x02000BC0 RID: 3008
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.RiseOfIx.DoubleAgentsAcquireLastAcquired+<>c__DisplayClass11_1")]
		public sealed class __c__DisplayClass11_1 : Object
		{
			// Token: 0x0600C039 RID: 49209 RVA: 0x002F63B4 File Offset: 0x002F45B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_1()
			{
				Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired.__c__DisplayClass11_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired>.NativeClassPtr, "<>c__DisplayClass11_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired.__c__DisplayClass11_1>.NativeClassPtr);
				DoubleAgentsAcquireLastAcquired.__c__DisplayClass11_1.NativeFieldInfoPtr_o = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired.__c__DisplayClass11_1>.NativeClassPtr, "o");
				DoubleAgentsAcquireLastAcquired.__c__DisplayClass11_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired.__c__DisplayClass11_1>.NativeClassPtr, 100681225);
				DoubleAgentsAcquireLastAcquired.__c__DisplayClass11_1.NativeMethodInfoPtr__GetArchetypesToCopy_b__3_Internal_Boolean_WormAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired.__c__DisplayClass11_1>.NativeClassPtr, 100681226);
			}

			// Token: 0x0600C03A RID: 49210 RVA: 0x002F641C File Offset: 0x002F461C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired.__c__DisplayClass11_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleAgentsAcquireLastAcquired.__c__DisplayClass11_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C03B RID: 49211 RVA: 0x002F6458 File Offset: 0x002F4658
			[CallerCount(0)]
			public unsafe bool _GetArchetypesToCopy_b__3(WormAgent a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleAgentsAcquireLastAcquired.__c__DisplayClass11_1.NativeMethodInfoPtr__GetArchetypesToCopy_b__3_Internal_Boolean_WormAgent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600C03C RID: 49212 RVA: 0x00059F47 File Offset: 0x00058147
			public __c__DisplayClass11_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003B98 RID: 15256
			// (get) Token: 0x0600C03D RID: 49213 RVA: 0x002F64A8 File Offset: 0x002F46A8
			// (set) Token: 0x0600C03E RID: 49214 RVA: 0x00059F50 File Offset: 0x00058150
			public unsafe WormPlayer o
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired.__c__DisplayClass11_1.NativeFieldInfoPtr_o);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired.__c__DisplayClass11_1.NativeFieldInfoPtr_o), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040078AE RID: 30894
			private static readonly IntPtr NativeFieldInfoPtr_o;

			// Token: 0x040078AF RID: 30895
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040078B0 RID: 30896
			private static readonly IntPtr NativeMethodInfoPtr__GetArchetypesToCopy_b__3_Internal_Boolean_WormAgent_0;
		}

		// Token: 0x02000BC1 RID: 3009
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.RiseOfIx.DoubleAgentsAcquireLastAcquired+<BeginExecution>d__10")]
		public sealed class _BeginExecution_d__10 : Object
		{
			// Token: 0x0600C03F RID: 49215 RVA: 0x002F64D8 File Offset: 0x002F46D8
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__10()
			{
				Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._BeginExecution_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired>.NativeClassPtr, "<BeginExecution>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._BeginExecution_d__10>.NativeClassPtr);
				DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._BeginExecution_d__10>.NativeClassPtr, "<>1__state");
				DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._BeginExecution_d__10>.NativeClassPtr, "<>2__current");
				DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._BeginExecution_d__10>.NativeClassPtr, "<>l__initialThreadId");
				DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._BeginExecution_d__10>.NativeClassPtr, "activeAbility");
				DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._BeginExecution_d__10>.NativeClassPtr, "<>3__activeAbility");
				DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._BeginExecution_d__10>.NativeClassPtr, "<>4__this");
				DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._BeginExecution_d__10>.NativeClassPtr, "match");
				DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._BeginExecution_d__10>.NativeClassPtr, "<>3__match");
				DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._BeginExecution_d__10>.NativeClassPtr, "<player>5__2");
				DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr__faction_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._BeginExecution_d__10>.NativeClassPtr, "<faction>5__3");
				DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr__cardEntityID_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._BeginExecution_d__10>.NativeClassPtr, "<cardEntityID>5__4");
				DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr__toArea_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._BeginExecution_d__10>.NativeClassPtr, "<toArea>5__5");
				DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr__logToken_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._BeginExecution_d__10>.NativeClassPtr, "<logToken>5__6");
				DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr___7__wrap6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._BeginExecution_d__10>.NativeClassPtr, "<>7__wrap6");
				DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr__imperiumCard_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._BeginExecution_d__10>.NativeClassPtr, "<imperiumCard>5__8");
				DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._BeginExecution_d__10>.NativeClassPtr, 100681227);
				DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._BeginExecution_d__10>.NativeClassPtr, 100681228);
				DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._BeginExecution_d__10>.NativeClassPtr, 100681229);
				DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._BeginExecution_d__10>.NativeClassPtr, 100681230);
				DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._BeginExecution_d__10>.NativeClassPtr, 100681231);
				DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._BeginExecution_d__10>.NativeClassPtr, 100681232);
				DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._BeginExecution_d__10>.NativeClassPtr, 100681233);
				DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._BeginExecution_d__10>.NativeClassPtr, 100681234);
				DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._BeginExecution_d__10>.NativeClassPtr, 100681235);
			}

			// Token: 0x0600C040 RID: 49216 RVA: 0x002F66E4 File Offset: 0x002F48E4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._BeginExecution_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600C041 RID: 49217 RVA: 0x002F672C File Offset: 0x002F492C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 250174, RefRangeEnd = 250175, XrefRangeStart = 250169, XrefRangeEnd = 250174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C042 RID: 49218 RVA: 0x002F6760 File Offset: 0x002F4960
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250175, XrefRangeEnd = 250347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C043 RID: 49219 RVA: 0x002F679C File Offset: 0x002F499C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 250350, RefRangeEnd = 250351, XrefRangeStart = 250347, XrefRangeEnd = 250350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003BA8 RID: 15272
			// (get) Token: 0x0600C044 RID: 49220 RVA: 0x002F67D0 File Offset: 0x002F49D0
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600C045 RID: 49221 RVA: 0x002F6810 File Offset: 0x002F4A10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250351, XrefRangeEnd = 250356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003BA9 RID: 15273
			// (get) Token: 0x0600C046 RID: 49222 RVA: 0x002F6844 File Offset: 0x002F4A44
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C047 RID: 49223 RVA: 0x002F6884 File Offset: 0x002F4A84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250356, XrefRangeEnd = 250366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600C048 RID: 49224 RVA: 0x002F68C4 File Offset: 0x002F4AC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C049 RID: 49225 RVA: 0x00059F6F File Offset: 0x0005816F
			public _BeginExecution_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003B99 RID: 15257
			// (get) Token: 0x0600C04A RID: 49226 RVA: 0x002F6904 File Offset: 0x002F4B04
			// (set) Token: 0x0600C04B RID: 49227 RVA: 0x00059F78 File Offset: 0x00058178
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003B9A RID: 15258
			// (get) Token: 0x0600C04C RID: 49228 RVA: 0x002F692C File Offset: 0x002F4B2C
			// (set) Token: 0x0600C04D RID: 49229 RVA: 0x00059F93 File Offset: 0x00058193
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B9B RID: 15259
			// (get) Token: 0x0600C04E RID: 49230 RVA: 0x002F695C File Offset: 0x002F4B5C
			// (set) Token: 0x0600C04F RID: 49231 RVA: 0x00059FB2 File Offset: 0x000581B2
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17003B9C RID: 15260
			// (get) Token: 0x0600C050 RID: 49232 RVA: 0x002F6984 File Offset: 0x002F4B84
			// (set) Token: 0x0600C051 RID: 49233 RVA: 0x00059FCD File Offset: 0x000581CD
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B9D RID: 15261
			// (get) Token: 0x0600C052 RID: 49234 RVA: 0x002F69B4 File Offset: 0x002F4BB4
			// (set) Token: 0x0600C053 RID: 49235 RVA: 0x00059FEC File Offset: 0x000581EC
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B9E RID: 15262
			// (get) Token: 0x0600C054 RID: 49236 RVA: 0x002F69E4 File Offset: 0x002F4BE4
			// (set) Token: 0x0600C055 RID: 49237 RVA: 0x0005A00B File Offset: 0x0005820B
			public unsafe DoubleAgentsAcquireLastAcquired __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DoubleAgentsAcquireLastAcquired>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B9F RID: 15263
			// (get) Token: 0x0600C056 RID: 49238 RVA: 0x002F6A14 File Offset: 0x002F4C14
			// (set) Token: 0x0600C057 RID: 49239 RVA: 0x0005A02A File Offset: 0x0005822A
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BA0 RID: 15264
			// (get) Token: 0x0600C058 RID: 49240 RVA: 0x002F6A44 File Offset: 0x002F4C44
			// (set) Token: 0x0600C059 RID: 49241 RVA: 0x0005A049 File Offset: 0x00058249
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BA1 RID: 15265
			// (get) Token: 0x0600C05A RID: 49242 RVA: 0x002F6A74 File Offset: 0x002F4C74
			// (set) Token: 0x0600C05B RID: 49243 RVA: 0x0005A068 File Offset: 0x00058268
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BA2 RID: 15266
			// (get) Token: 0x0600C05C RID: 49244 RVA: 0x002F6AA4 File Offset: 0x002F4CA4
			// (set) Token: 0x0600C05D RID: 49245 RVA: 0x0005A087 File Offset: 0x00058287
			public unsafe Factions _faction_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr__faction_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr__faction_5__3)) = value;
				}
			}

			// Token: 0x17003BA3 RID: 15267
			// (get) Token: 0x0600C05E RID: 49246 RVA: 0x002F6ACC File Offset: 0x002F4CCC
			// (set) Token: 0x0600C05F RID: 49247 RVA: 0x0005A0A2 File Offset: 0x000582A2
			public unsafe EntityID _cardEntityID_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr__cardEntityID_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr__cardEntityID_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BA4 RID: 15268
			// (get) Token: 0x0600C060 RID: 49248 RVA: 0x002F6AFC File Offset: 0x002F4CFC
			// (set) Token: 0x0600C061 RID: 49249 RVA: 0x0005A0C1 File Offset: 0x000582C1
			public unsafe CardToAreas _toArea_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr__toArea_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr__toArea_5__5)) = value;
				}
			}

			// Token: 0x17003BA5 RID: 15269
			// (get) Token: 0x0600C062 RID: 49250 RVA: 0x002F6B24 File Offset: 0x002F4D24
			// (set) Token: 0x0600C063 RID: 49251 RVA: 0x0005A0DC File Offset: 0x000582DC
			public unsafe string _logToken_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr__logToken_5__6);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr__logToken_5__6), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003BA6 RID: 15270
			// (get) Token: 0x0600C064 RID: 49252 RVA: 0x002F6B4C File Offset: 0x002F4D4C
			// (set) Token: 0x0600C065 RID: 49253 RVA: 0x0005A0FB File Offset: 0x000582FB
			public List<ArchetypeID>.Enumerator __7__wrap6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr___7__wrap6);
					return new List<ArchetypeID>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<ArchetypeID>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr___7__wrap6), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<ArchetypeID>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003BA7 RID: 15271
			// (get) Token: 0x0600C066 RID: 49254 RVA: 0x002F6B7C File Offset: 0x002F4D7C
			// (set) Token: 0x0600C067 RID: 49255 RVA: 0x0005A129 File Offset: 0x00058329
			public unsafe WormImperiumPlayable _imperiumCard_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr__imperiumCard_5__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._BeginExecution_d__10.NativeFieldInfoPtr__imperiumCard_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040078B1 RID: 30897
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040078B2 RID: 30898
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040078B3 RID: 30899
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040078B4 RID: 30900
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x040078B5 RID: 30901
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x040078B6 RID: 30902
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040078B7 RID: 30903
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040078B8 RID: 30904
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x040078B9 RID: 30905
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x040078BA RID: 30906
			private static readonly IntPtr NativeFieldInfoPtr__faction_5__3;

			// Token: 0x040078BB RID: 30907
			private static readonly IntPtr NativeFieldInfoPtr__cardEntityID_5__4;

			// Token: 0x040078BC RID: 30908
			private static readonly IntPtr NativeFieldInfoPtr__toArea_5__5;

			// Token: 0x040078BD RID: 30909
			private static readonly IntPtr NativeFieldInfoPtr__logToken_5__6;

			// Token: 0x040078BE RID: 30910
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap6;

			// Token: 0x040078BF RID: 30911
			private static readonly IntPtr NativeFieldInfoPtr__imperiumCard_5__8;

			// Token: 0x040078C0 RID: 30912
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040078C1 RID: 30913
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040078C2 RID: 30914
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040078C3 RID: 30915
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040078C4 RID: 30916
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040078C5 RID: 30917
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040078C6 RID: 30918
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040078C7 RID: 30919
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040078C8 RID: 30920
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000BC2 RID: 3010
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.RiseOfIx.DoubleAgentsAcquireLastAcquired+<Targets>d__9")]
		public sealed class _Targets_d__9 : Object
		{
			// Token: 0x0600C068 RID: 49256 RVA: 0x002F6BAC File Offset: 0x002F4DAC
			// Note: this type is marked as 'beforefieldinit'.
			static _Targets_d__9()
			{
				Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._Targets_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired>.NativeClassPtr, "<Targets>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._Targets_d__9>.NativeClassPtr);
				DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._Targets_d__9>.NativeClassPtr, "<>1__state");
				DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._Targets_d__9>.NativeClassPtr, "<>2__current");
				DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._Targets_d__9>.NativeClassPtr, "<>l__initialThreadId");
				DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._Targets_d__9>.NativeClassPtr, "context");
				DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._Targets_d__9>.NativeClassPtr, "<>3__context");
				DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._Targets_d__9>.NativeClassPtr, "<>4__this");
				DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._Targets_d__9>.NativeClassPtr, "<player>5__2");
				DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeFieldInfoPtr__archetypes_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._Targets_d__9>.NativeClassPtr, "<archetypes>5__3");
				DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._Targets_d__9>.NativeClassPtr, 100681236);
				DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._Targets_d__9>.NativeClassPtr, 100681237);
				DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._Targets_d__9>.NativeClassPtr, 100681238);
				DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._Targets_d__9>.NativeClassPtr, 100681239);
				DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._Targets_d__9>.NativeClassPtr, 100681240);
				DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._Targets_d__9>.NativeClassPtr, 100681241);
				DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._Targets_d__9>.NativeClassPtr, 100681242);
				DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._Targets_d__9>.NativeClassPtr, 100681243);
			}

			// Token: 0x0600C069 RID: 49257 RVA: 0x002F6D18 File Offset: 0x002F4F18
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Targets_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoubleAgentsAcquireLastAcquired._Targets_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600C06A RID: 49258 RVA: 0x002F6D60 File Offset: 0x002F4F60
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C06B RID: 49259 RVA: 0x002F6D94 File Offset: 0x002F4F94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250366, XrefRangeEnd = 250476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003BB2 RID: 15282
			// (get) Token: 0x0600C06C RID: 49260 RVA: 0x002F6DD0 File Offset: 0x002F4FD0
			public unsafe TargetInformation System.Collections.Generic.IEnumerator<Networking.selection.targetinformation.TargetInformation>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr3) : null;
				}
			}

			// Token: 0x0600C06D RID: 49261 RVA: 0x002F6E10 File Offset: 0x002F5010
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250476, XrefRangeEnd = 250481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003BB3 RID: 15283
			// (get) Token: 0x0600C06E RID: 49262 RVA: 0x002F6E44 File Offset: 0x002F5044
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C06F RID: 49263 RVA: 0x002F6E84 File Offset: 0x002F5084
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250481, XrefRangeEnd = 250490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TargetInformation> System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TargetInformation>>(intPtr3) : null;
			}

			// Token: 0x0600C070 RID: 49264 RVA: 0x002F6EC4 File Offset: 0x002F50C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C071 RID: 49265 RVA: 0x0005A148 File Offset: 0x00058348
			public _Targets_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003BAA RID: 15274
			// (get) Token: 0x0600C072 RID: 49266 RVA: 0x002F6F04 File Offset: 0x002F5104
			// (set) Token: 0x0600C073 RID: 49267 RVA: 0x0005A151 File Offset: 0x00058351
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003BAB RID: 15275
			// (get) Token: 0x0600C074 RID: 49268 RVA: 0x002F6F2C File Offset: 0x002F512C
			// (set) Token: 0x0600C075 RID: 49269 RVA: 0x0005A16C File Offset: 0x0005836C
			public unsafe TargetInformation __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BAC RID: 15276
			// (get) Token: 0x0600C076 RID: 49270 RVA: 0x002F6F5C File Offset: 0x002F515C
			// (set) Token: 0x0600C077 RID: 49271 RVA: 0x0005A18B File Offset: 0x0005838B
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17003BAD RID: 15277
			// (get) Token: 0x0600C078 RID: 49272 RVA: 0x002F6F84 File Offset: 0x002F5184
			// (set) Token: 0x0600C079 RID: 49273 RVA: 0x0005A1A6 File Offset: 0x000583A6
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BAE RID: 15278
			// (get) Token: 0x0600C07A RID: 49274 RVA: 0x002F6FB4 File Offset: 0x002F51B4
			// (set) Token: 0x0600C07B RID: 49275 RVA: 0x0005A1C5 File Offset: 0x000583C5
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BAF RID: 15279
			// (get) Token: 0x0600C07C RID: 49276 RVA: 0x002F6FE4 File Offset: 0x002F51E4
			// (set) Token: 0x0600C07D RID: 49277 RVA: 0x0005A1E4 File Offset: 0x000583E4
			public unsafe DoubleAgentsAcquireLastAcquired __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DoubleAgentsAcquireLastAcquired>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BB0 RID: 15280
			// (get) Token: 0x0600C07E RID: 49278 RVA: 0x002F7014 File Offset: 0x002F5214
			// (set) Token: 0x0600C07F RID: 49279 RVA: 0x0005A203 File Offset: 0x00058403
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BB1 RID: 15281
			// (get) Token: 0x0600C080 RID: 49280 RVA: 0x002F7044 File Offset: 0x002F5244
			// (set) Token: 0x0600C081 RID: 49281 RVA: 0x0005A222 File Offset: 0x00058422
			public unsafe List<ArchetypeID> _archetypes_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeFieldInfoPtr__archetypes_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleAgentsAcquireLastAcquired._Targets_d__9.NativeFieldInfoPtr__archetypes_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040078C9 RID: 30921
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040078CA RID: 30922
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040078CB RID: 30923
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040078CC RID: 30924
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x040078CD RID: 30925
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x040078CE RID: 30926
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040078CF RID: 30927
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x040078D0 RID: 30928
			private static readonly IntPtr NativeFieldInfoPtr__archetypes_5__3;

			// Token: 0x040078D1 RID: 30929
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040078D2 RID: 30930
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040078D3 RID: 30931
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040078D4 RID: 30932
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0;

			// Token: 0x040078D5 RID: 30933
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040078D6 RID: 30934
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040078D7 RID: 30935
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0;

			// Token: 0x040078D8 RID: 30936
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

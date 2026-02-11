using System;
using Canis.actions;
using Canis.attributes;
using Canis.context;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Networking.selection.messages.outgoing;
using Networking.selection.targetinformation;
using Networking.selection.targetresponse;

namespace Canis.entities
{
	// Token: 0x020000B9 RID: 185
	public class AbilityDefinition : Entity
	{
		// Token: 0x06000896 RID: 2198 RVA: 0x0003C1D4 File Offset: 0x0003A3D4
		// Note: this type is marked as 'beforefieldinit'.
		static AbilityDefinition()
		{
			Il2CppClassPointerStore<AbilityDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "AbilityDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityDefinition>.NativeClassPtr);
			AbilityDefinition.NativeMethodInfoPtr__ctor_Protected_Void_Match_String_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition>.NativeClassPtr, 100665055);
			AbilityDefinition.NativeMethodInfoPtr__ctor_Protected_Void_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition>.NativeClassPtr, 100665056);
			AbilityDefinition.NativeMethodInfoPtr_Action_Public_Abstract_Virtual_New_IEnumerable_1_Action_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition>.NativeClassPtr, 100665057);
			AbilityDefinition.NativeMethodInfoPtr_Cost_Public_Abstract_Virtual_New_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition>.NativeClassPtr, 100665058);
			AbilityDefinition.NativeMethodInfoPtr_Targets_Public_Virtual_New_IEnumerable_1_TargetInformation_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition>.NativeClassPtr, 100665059);
			AbilityDefinition.NativeMethodInfoPtr_HasValidTargets_Public_Virtual_New_Boolean_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition>.NativeClassPtr, 100665060);
			AbilityDefinition.NativeMethodInfoPtr_GetAbilityID_Public_Abstract_Virtual_New_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition>.NativeClassPtr, 100665061);
			AbilityDefinition.NativeMethodInfoPtr_GetBaseAbilityID_Public_Virtual_New_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition>.NativeClassPtr, 100665062);
			AbilityDefinition.NativeMethodInfoPtr_GetSourceEntityID_Public_Virtual_New_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition>.NativeClassPtr, 100665063);
			AbilityDefinition.NativeMethodInfoPtr_CanBeRun_Public_Virtual_New_Boolean_Match_PlayerEntity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition>.NativeClassPtr, 100665064);
			AbilityDefinition.NativeMethodInfoPtr_Serialize_Public_Virtual_SerializedEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition>.NativeClassPtr, 100665065);
			AbilityDefinition.NativeMethodInfoPtr_SerializeAttributes_Public_Virtual_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition>.NativeClassPtr, 100665066);
			AbilityDefinition.NativeMethodInfoPtr_get_Self_Public_Virtual_Final_New_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition>.NativeClassPtr, 100665067);
			AbilityDefinition.NativeMethodInfoPtr_get_Owner_Public_Virtual_Final_New_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition>.NativeClassPtr, 100665068);
			AbilityDefinition.NativeMethodInfoPtr_TypedOwner_Public_TEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition>.NativeClassPtr, 100665069);
			AbilityDefinition.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition>.NativeClassPtr, 100665070);
			AbilityDefinition.NativeMethodInfoPtr_GetAbilityKind_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition>.NativeClassPtr, 100665071);
			AbilityDefinition.NativeMethodInfoPtr_IsMatchingTargetResponse_Protected_Virtual_New_Boolean_TargetInformation_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition>.NativeClassPtr, 100665072);
			AbilityDefinition.NativeMethodInfoPtr_IsMatchingAbility_Public_Boolean_PlayerEntity_Entity_Il2CppReferenceArray_1_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition>.NativeClassPtr, 100665073);
			AbilityDefinition.NativeMethodInfoPtr_TryZipInformationAndResponses_Protected_Boolean_Il2CppReferenceArray_1_TargetInformation_Il2CppReferenceArray_1_TargetResponse_byref_List_1_ValueTuple_2_TargetInformation_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition>.NativeClassPtr, 100665074);
			AbilityDefinition.NativeMethodInfoPtr_IsMatchingAbility_Public_Boolean_PlayerEntity_EntityIDTargetResponses_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition>.NativeClassPtr, 100665075);
			AbilityDefinition.NativeMethodInfoPtr__IsMatchingAbility_b__20_1_Private_Boolean_ValueTuple_2_TargetInformation_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition>.NativeClassPtr, 100665076);
			AbilityDefinition.NativeMethodInfoPtr__IsMatchingAbility_b__22_0_Private_Boolean_ValueTuple_2_TargetInformation_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition>.NativeClassPtr, 100665077);
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x0003C3D0 File Offset: 0x0003A5D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 553224, RefRangeEnd = 553227, XrefRangeStart = 553224, XrefRangeEnd = 553227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbilityDefinition(Match m, string name = "", PlayerEntity owningPlayer = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityDefinition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owningPlayer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinition.NativeMethodInfoPtr__ctor_Protected_Void_Match_String_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x0003C440 File Offset: 0x0003A640
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 553228, RefRangeEnd = 553234, XrefRangeStart = 553228, XrefRangeEnd = 553234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbilityDefinition(SerializedEntity se, Match m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityDefinition>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinition.NativeMethodInfoPtr__ctor_Protected_Void_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x0003C4B0 File Offset: 0x0003A6B0
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Canis.actions.Action> Action(Match match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbilityDefinition.NativeMethodInfoPtr_Action_Public_Abstract_Virtual_New_IEnumerable_1_Action_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x0003C520 File Offset: 0x0003A720
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbilityDefinition.NativeMethodInfoPtr_Cost_Public_Abstract_Virtual_New_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x0003C590 File Offset: 0x0003A790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 560402, XrefRangeEnd = 560407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbilityDefinition.NativeMethodInfoPtr_Targets_Public_Virtual_New_IEnumerable_1_TargetInformation_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TargetInformation>>(intPtr3) : null;
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x0003C600 File Offset: 0x0003A800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 560407, XrefRangeEnd = 560421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbilityDefinition.NativeMethodInfoPtr_HasValidTargets_Public_Virtual_New_Boolean_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x0003C66C File Offset: 0x0003A86C
		[CallerCount(0)]
		public unsafe virtual AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbilityDefinition.NativeMethodInfoPtr_GetAbilityID_Public_Abstract_Virtual_New_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x0003C6B8 File Offset: 0x0003A8B8
		[CallerCount(0)]
		public unsafe virtual AbilityID GetBaseAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbilityDefinition.NativeMethodInfoPtr_GetBaseAbilityID_Public_Virtual_New_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x0003C704 File Offset: 0x0003A904
		[CallerCount(0)]
		public unsafe virtual EntityID GetSourceEntityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbilityDefinition.NativeMethodInfoPtr_GetSourceEntityID_Public_Virtual_New_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x0003C750 File Offset: 0x0003A950
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 560422, RefRangeEnd = 560423, XrefRangeStart = 560421, XrefRangeEnd = 560422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanBeRun(Match match, PlayerEntity player, Context paramContext = null)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbilityDefinition.NativeMethodInfoPtr_CanBeRun_Public_Virtual_New_Boolean_Match_PlayerEntity_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x0003C7CC File Offset: 0x0003A9CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 560423, XrefRangeEnd = 560431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedEntity Serialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbilityDefinition.NativeMethodInfoPtr_Serialize_Public_Virtual_SerializedEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedEntity>(intPtr3) : null;
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x0003C818 File Offset: 0x0003AA18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 560431, XrefRangeEnd = 560439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MutableAttributes SerializeAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbilityDefinition.NativeMethodInfoPtr_SerializeAttributes_Public_Virtual_MutableAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr3) : null;
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060008A3 RID: 2211 RVA: 0x0003C864 File Offset: 0x0003AA64
		public unsafe virtual Entity Self
		{
			[CallerCount(1295)]
			[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinition.NativeMethodInfoPtr_get_Self_Public_Virtual_Final_New_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x0003C8A4 File Offset: 0x0003AAA4
		public unsafe virtual Entity Owner
		{
			[CallerCount(480)]
			[CachedScanResults(RefRangeStart = 560442, RefRangeEnd = 560922, XrefRangeStart = 560439, XrefRangeEnd = 560442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinition.NativeMethodInfoPtr_get_Owner_Public_Virtual_Final_New_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x0003C8E4 File Offset: 0x0003AAE4
		[CallerCount(118)]
		[CachedScanResults(RefRangeStart = 560933, RefRangeEnd = 561051, XrefRangeStart = 560922, XrefRangeEnd = 560933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TEntity TypedOwner<TEntity>() where TEntity : Entity
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinition.MethodInfoStoreGeneric_TypedOwner_Public_TEntity_0<TEntity>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TEntity>(intPtr, false, true);
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x0003C920 File Offset: 0x0003AB20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561051, XrefRangeEnd = 561057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbilityDefinition.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x0003C964 File Offset: 0x0003AB64
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetAbilityKind()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbilityDefinition.NativeMethodInfoPtr_GetAbilityKind_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x0003C9A8 File Offset: 0x0003ABA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561057, XrefRangeEnd = 561085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsMatchingTargetResponse(TargetInformation ti, TargetResponse tr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ti);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbilityDefinition.NativeMethodInfoPtr_IsMatchingTargetResponse_Protected_Virtual_New_Boolean_TargetInformation_TargetResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x0003CA14 File Offset: 0x0003AC14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561085, XrefRangeEnd = 561126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMatchingAbility(PlayerEntity selectingPlayer, Entity selectedEntity, Il2CppReferenceArray<TargetResponse> targetResponses)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectingPlayer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectedEntity);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetResponses);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinition.NativeMethodInfoPtr_IsMatchingAbility_Public_Boolean_PlayerEntity_Entity_Il2CppReferenceArray_1_TargetResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x0003CA88 File Offset: 0x0003AC88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 561153, RefRangeEnd = 561154, XrefRangeStart = 561126, XrefRangeEnd = 561153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryZipInformationAndResponses(Il2CppReferenceArray<TargetInformation> targetInfos, Il2CppReferenceArray<TargetResponse> targetResponses, out List<ValueTuple<TargetInformation, TargetResponse>> zipped)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetInfos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetResponses);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AbilityDefinition.NativeMethodInfoPtr_TryZipInformationAndResponses_Protected_Boolean_Il2CppReferenceArray_1_TargetInformation_Il2CppReferenceArray_1_TargetResponse_byref_List_1_ValueTuple_2_TargetInformation_TargetResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			zipped = ((intPtr4 == 0) ? null : new List<ValueTuple<TargetInformation, TargetResponse>>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x0003CB0C File Offset: 0x0003AD0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 561178, RefRangeEnd = 561181, XrefRangeStart = 561154, XrefRangeEnd = 561178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMatchingAbility(PlayerEntity selectingPlayer, EntityIDTargetResponses selection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectingPlayer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinition.NativeMethodInfoPtr_IsMatchingAbility_Public_Boolean_PlayerEntity_EntityIDTargetResponses_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x0003CB6C File Offset: 0x0003AD6C
		[CallerCount(0)]
		public unsafe bool _IsMatchingAbility_b__20_1(ValueTuple<TargetInformation, TargetResponse> pair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinition.NativeMethodInfoPtr__IsMatchingAbility_b__20_1_Private_Boolean_ValueTuple_2_TargetInformation_TargetResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x0003CBC0 File Offset: 0x0003ADC0
		[CallerCount(0)]
		public unsafe bool _IsMatchingAbility_b__22_0(ValueTuple<TargetInformation, TargetResponse> pair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinition.NativeMethodInfoPtr__IsMatchingAbility_b__22_0_Private_Boolean_ValueTuple_2_TargetInformation_TargetResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00005605 File Offset: 0x00003805
		public AbilityDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Match_String_PlayerEntity_0;

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializedEntity_Match_Entity_0;

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeMethodInfoPtr_Action_Public_Abstract_Virtual_New_IEnumerable_1_Action_Match_Context_0;

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Abstract_Virtual_New_CostAction_Match_Context_0;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeMethodInfoPtr_Targets_Public_Virtual_New_IEnumerable_1_TargetInformation_Match_Context_0;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeMethodInfoPtr_HasValidTargets_Public_Virtual_New_Boolean_Match_Context_0;

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Abstract_Virtual_New_AbilityID_0;

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseAbilityID_Public_Virtual_New_AbilityID_0;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceEntityID_Public_Virtual_New_EntityID_0;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeMethodInfoPtr_CanBeRun_Public_Virtual_New_Boolean_Match_PlayerEntity_Context_0;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_SerializedEntity_0;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeMethodInfoPtr_SerializeAttributes_Public_Virtual_MutableAttributes_0;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeMethodInfoPtr_get_Self_Public_Virtual_Final_New_get_Entity_0;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeMethodInfoPtr_get_Owner_Public_Virtual_Final_New_get_Entity_0;

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeMethodInfoPtr_TypedOwner_Public_TEntity_0;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityKind_Public_Virtual_New_String_0;

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeMethodInfoPtr_IsMatchingTargetResponse_Protected_Virtual_New_Boolean_TargetInformation_TargetResponse_0;

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeMethodInfoPtr_IsMatchingAbility_Public_Boolean_PlayerEntity_Entity_Il2CppReferenceArray_1_TargetResponse_0;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeMethodInfoPtr_TryZipInformationAndResponses_Protected_Boolean_Il2CppReferenceArray_1_TargetInformation_Il2CppReferenceArray_1_TargetResponse_byref_List_1_ValueTuple_2_TargetInformation_TargetResponse_0;

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeMethodInfoPtr_IsMatchingAbility_Public_Boolean_PlayerEntity_EntityIDTargetResponses_0;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeMethodInfoPtr__IsMatchingAbility_b__20_1_Private_Boolean_ValueTuple_2_TargetInformation_TargetResponse_0;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeMethodInfoPtr__IsMatchingAbility_b__22_0_Private_Boolean_ValueTuple_2_TargetInformation_TargetResponse_0;

		// Token: 0x020002F3 RID: 755
		[ObfuscatedName("Canis.entities.AbilityDefinition+<>O")]
		public static class __O : Object
		{
			// Token: 0x06001F92 RID: 8082 RVA: 0x0000F341 File Offset: 0x0000D541
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<AbilityDefinition.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityDefinition>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityDefinition.__O>.NativeClassPtr);
				AbilityDefinition.__O.NativeFieldInfoPtr__0___IsValidTargetInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDefinition.__O>.NativeClassPtr, "<0>__IsValidTargetInfo");
			}

			// Token: 0x06001F93 RID: 8083 RVA: 0x0000F375 File Offset: 0x0000D575
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000772 RID: 1906
			// (get) Token: 0x06001F94 RID: 8084 RVA: 0x000910B0 File Offset: 0x0008F2B0
			// (set) Token: 0x06001F95 RID: 8085 RVA: 0x0000F37E File Offset: 0x0000D57E
			public unsafe static Func<TargetInformation, bool> _0___IsValidTargetInfo
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AbilityDefinition.__O.NativeFieldInfoPtr__0___IsValidTargetInfo, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TargetInformation, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AbilityDefinition.__O.NativeFieldInfoPtr__0___IsValidTargetInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013E8 RID: 5096
			private static readonly IntPtr NativeFieldInfoPtr__0___IsValidTargetInfo;
		}

		// Token: 0x020002F4 RID: 756
		[ObfuscatedName("Canis.entities.AbilityDefinition+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06001F96 RID: 8086 RVA: 0x000910D8 File Offset: 0x0008F2D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AbilityDefinition.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityDefinition>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityDefinition.__c>.NativeClassPtr);
				AbilityDefinition.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDefinition.__c>.NativeClassPtr, "<>9");
				AbilityDefinition.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDefinition.__c>.NativeClassPtr, "<>9__20_0");
				AbilityDefinition.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition.__c>.NativeClassPtr, 100665079);
				AbilityDefinition.__c.NativeMethodInfoPtr__IsMatchingAbility_b__20_0_Internal_ValueTuple_2_TargetInformation_TargetResponse_TargetInformation_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition.__c>.NativeClassPtr, 100665080);
			}

			// Token: 0x06001F97 RID: 8087 RVA: 0x00091154 File Offset: 0x0008F354
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityDefinition.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinition.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F98 RID: 8088 RVA: 0x00091190 File Offset: 0x0008F390
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 560373, XrefRangeEnd = 560376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<TargetInformation, TargetResponse> _IsMatchingAbility_b__20_0(TargetInformation ti, TargetResponse tr)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ti);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinition.__c.NativeMethodInfoPtr__IsMatchingAbility_b__20_0_Internal_ValueTuple_2_TargetInformation_TargetResponse_TargetInformation_TargetResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<TargetInformation, TargetResponse>(intPtr);
			}

			// Token: 0x06001F99 RID: 8089 RVA: 0x0000F390 File Offset: 0x0000D590
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000773 RID: 1907
			// (get) Token: 0x06001F9A RID: 8090 RVA: 0x000911EC File Offset: 0x0008F3EC
			// (set) Token: 0x06001F9B RID: 8091 RVA: 0x0000F399 File Offset: 0x0000D599
			public unsafe static AbilityDefinition.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AbilityDefinition.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityDefinition.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AbilityDefinition.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000774 RID: 1908
			// (get) Token: 0x06001F9C RID: 8092 RVA: 0x00091214 File Offset: 0x0008F414
			// (set) Token: 0x06001F9D RID: 8093 RVA: 0x0000F3AB File Offset: 0x0000D5AB
			public unsafe static Func<TargetInformation, TargetResponse, ValueTuple<TargetInformation, TargetResponse>> __9__20_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AbilityDefinition.__c.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TargetInformation, TargetResponse, ValueTuple<TargetInformation, TargetResponse>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AbilityDefinition.__c.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013E9 RID: 5097
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040013EA RID: 5098
			private static readonly IntPtr NativeFieldInfoPtr___9__20_0;

			// Token: 0x040013EB RID: 5099
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040013EC RID: 5100
			private static readonly IntPtr NativeMethodInfoPtr__IsMatchingAbility_b__20_0_Internal_ValueTuple_2_TargetInformation_TargetResponse_TargetInformation_TargetResponse_0;
		}

		// Token: 0x020002F5 RID: 757
		[ObfuscatedName("Canis.entities.AbilityDefinition+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Object
		{
			// Token: 0x06001F9E RID: 8094 RVA: 0x0009123C File Offset: 0x0008F43C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<AbilityDefinition.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityDefinition>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityDefinition.__c__DisplayClass19_0>.NativeClassPtr);
				AbilityDefinition.__c__DisplayClass19_0.NativeFieldInfoPtr_elti = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDefinition.__c__DisplayClass19_0>.NativeClassPtr, "elti");
				AbilityDefinition.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition.__c__DisplayClass19_0>.NativeClassPtr, 100665081);
				AbilityDefinition.__c__DisplayClass19_0.NativeMethodInfoPtr__IsMatchingTargetResponse_b__0_Internal_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition.__c__DisplayClass19_0>.NativeClassPtr, 100665082);
			}

			// Token: 0x06001F9F RID: 8095 RVA: 0x000912A4 File Offset: 0x0008F4A4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityDefinition.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinition.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FA0 RID: 8096 RVA: 0x000912E0 File Offset: 0x0008F4E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 560376, XrefRangeEnd = 560391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsMatchingTargetResponse_b__0(EntityID id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinition.__c__DisplayClass19_0.NativeMethodInfoPtr__IsMatchingTargetResponse_b__0_Internal_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001FA1 RID: 8097 RVA: 0x0000F3BD File Offset: 0x0000D5BD
			public __c__DisplayClass19_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000775 RID: 1909
			// (get) Token: 0x06001FA2 RID: 8098 RVA: 0x00091330 File Offset: 0x0008F530
			// (set) Token: 0x06001FA3 RID: 8099 RVA: 0x0000F3C6 File Offset: 0x0000D5C6
			public unsafe EntityListTargetInformation elti
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityDefinition.__c__DisplayClass19_0.NativeFieldInfoPtr_elti);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityListTargetInformation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityDefinition.__c__DisplayClass19_0.NativeFieldInfoPtr_elti), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013ED RID: 5101
			private static readonly IntPtr NativeFieldInfoPtr_elti;

			// Token: 0x040013EE RID: 5102
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040013EF RID: 5103
			private static readonly IntPtr NativeMethodInfoPtr__IsMatchingTargetResponse_b__0_Internal_Boolean_EntityID_0;
		}

		// Token: 0x020002F6 RID: 758
		[ObfuscatedName("Canis.entities.AbilityDefinition+<>c__DisplayClass19_1")]
		public sealed class __c__DisplayClass19_1 : Object
		{
			// Token: 0x06001FA4 RID: 8100 RVA: 0x00091360 File Offset: 0x0008F560
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_1()
			{
				Il2CppClassPointerStore<AbilityDefinition.__c__DisplayClass19_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityDefinition>.NativeClassPtr, "<>c__DisplayClass19_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityDefinition.__c__DisplayClass19_1>.NativeClassPtr);
				AbilityDefinition.__c__DisplayClass19_1.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDefinition.__c__DisplayClass19_1>.NativeClassPtr, "id");
				AbilityDefinition.__c__DisplayClass19_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition.__c__DisplayClass19_1>.NativeClassPtr, 100665083);
				AbilityDefinition.__c__DisplayClass19_1.NativeMethodInfoPtr__IsMatchingTargetResponse_b__1_Internal_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition.__c__DisplayClass19_1>.NativeClassPtr, 100665084);
			}

			// Token: 0x06001FA5 RID: 8101 RVA: 0x000913C8 File Offset: 0x0008F5C8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityDefinition.__c__DisplayClass19_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinition.__c__DisplayClass19_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FA6 RID: 8102 RVA: 0x00091404 File Offset: 0x0008F604
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 560391, XrefRangeEnd = 560395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsMatchingTargetResponse_b__1(EntityID _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinition.__c__DisplayClass19_1.NativeMethodInfoPtr__IsMatchingTargetResponse_b__1_Internal_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001FA7 RID: 8103 RVA: 0x0000F3E5 File Offset: 0x0000D5E5
			public __c__DisplayClass19_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000776 RID: 1910
			// (get) Token: 0x06001FA8 RID: 8104 RVA: 0x00091454 File Offset: 0x0008F654
			// (set) Token: 0x06001FA9 RID: 8105 RVA: 0x0000F3EE File Offset: 0x0000D5EE
			public unsafe EntityID id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityDefinition.__c__DisplayClass19_1.NativeFieldInfoPtr_id);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityDefinition.__c__DisplayClass19_1.NativeFieldInfoPtr_id), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013F0 RID: 5104
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x040013F1 RID: 5105
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040013F2 RID: 5106
			private static readonly IntPtr NativeMethodInfoPtr__IsMatchingTargetResponse_b__1_Internal_Boolean_EntityID_0;
		}

		// Token: 0x020002F7 RID: 759
		[ObfuscatedName("Canis.entities.AbilityDefinition+<Targets>d__4")]
		public sealed class _Targets_d__4 : Object
		{
			// Token: 0x06001FAA RID: 8106 RVA: 0x00091484 File Offset: 0x0008F684
			// Note: this type is marked as 'beforefieldinit'.
			static _Targets_d__4()
			{
				Il2CppClassPointerStore<AbilityDefinition._Targets_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityDefinition>.NativeClassPtr, "<Targets>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityDefinition._Targets_d__4>.NativeClassPtr);
				AbilityDefinition._Targets_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDefinition._Targets_d__4>.NativeClassPtr, "<>1__state");
				AbilityDefinition._Targets_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDefinition._Targets_d__4>.NativeClassPtr, "<>2__current");
				AbilityDefinition._Targets_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDefinition._Targets_d__4>.NativeClassPtr, "<>l__initialThreadId");
				AbilityDefinition._Targets_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition._Targets_d__4>.NativeClassPtr, 100665085);
				AbilityDefinition._Targets_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition._Targets_d__4>.NativeClassPtr, 100665086);
				AbilityDefinition._Targets_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition._Targets_d__4>.NativeClassPtr, 100665087);
				AbilityDefinition._Targets_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition._Targets_d__4>.NativeClassPtr, 100665088);
				AbilityDefinition._Targets_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition._Targets_d__4>.NativeClassPtr, 100665089);
				AbilityDefinition._Targets_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition._Targets_d__4>.NativeClassPtr, 100665090);
				AbilityDefinition._Targets_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition._Targets_d__4>.NativeClassPtr, 100665091);
				AbilityDefinition._Targets_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinition._Targets_d__4>.NativeClassPtr, 100665092);
			}

			// Token: 0x06001FAB RID: 8107 RVA: 0x0009158C File Offset: 0x0008F78C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Targets_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityDefinition._Targets_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinition._Targets_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FAC RID: 8108 RVA: 0x000915D4 File Offset: 0x0008F7D4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinition._Targets_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FAD RID: 8109 RVA: 0x00091608 File Offset: 0x0008F808
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinition._Targets_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700077A RID: 1914
			// (get) Token: 0x06001FAE RID: 8110 RVA: 0x00091644 File Offset: 0x0008F844
			public unsafe TargetInformation System.Collections.Generic.IEnumerator<Networking.selection.targetinformation.TargetInformation>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinition._Targets_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr3) : null;
				}
			}

			// Token: 0x06001FAF RID: 8111 RVA: 0x00091684 File Offset: 0x0008F884
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 560395, XrefRangeEnd = 560400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinition._Targets_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700077B RID: 1915
			// (get) Token: 0x06001FB0 RID: 8112 RVA: 0x000916B8 File Offset: 0x0008F8B8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinition._Targets_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001FB1 RID: 8113 RVA: 0x000916F8 File Offset: 0x0008F8F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 560400, XrefRangeEnd = 560402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TargetInformation> System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinition._Targets_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TargetInformation>>(intPtr3) : null;
			}

			// Token: 0x06001FB2 RID: 8114 RVA: 0x00091738 File Offset: 0x0008F938
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinition._Targets_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001FB3 RID: 8115 RVA: 0x0000F40D File Offset: 0x0000D60D
			public _Targets_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000777 RID: 1911
			// (get) Token: 0x06001FB4 RID: 8116 RVA: 0x00091778 File Offset: 0x0008F978
			// (set) Token: 0x06001FB5 RID: 8117 RVA: 0x0000F416 File Offset: 0x0000D616
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityDefinition._Targets_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityDefinition._Targets_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000778 RID: 1912
			// (get) Token: 0x06001FB6 RID: 8118 RVA: 0x000917A0 File Offset: 0x0008F9A0
			// (set) Token: 0x06001FB7 RID: 8119 RVA: 0x0000F431 File Offset: 0x0000D631
			public unsafe TargetInformation __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityDefinition._Targets_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityDefinition._Targets_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000779 RID: 1913
			// (get) Token: 0x06001FB8 RID: 8120 RVA: 0x000917D0 File Offset: 0x0008F9D0
			// (set) Token: 0x06001FB9 RID: 8121 RVA: 0x0000F450 File Offset: 0x0000D650
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityDefinition._Targets_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityDefinition._Targets_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x040013F3 RID: 5107
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040013F4 RID: 5108
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040013F5 RID: 5109
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040013F6 RID: 5110
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040013F7 RID: 5111
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040013F8 RID: 5112
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040013F9 RID: 5113
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0;

			// Token: 0x040013FA RID: 5114
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040013FB RID: 5115
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040013FC RID: 5116
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0;

			// Token: 0x040013FD RID: 5117
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020002F8 RID: 760
		private sealed class MethodInfoStoreGeneric_TypedOwner_Public_TEntity_0<TEntity>
		{
			// Token: 0x040013FE RID: 5118
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AbilityDefinition.NativeMethodInfoPtr_TypedOwner_Public_TEntity_0, Il2CppClassPointerStore<AbilityDefinition>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEntity>.NativeClassPtr)) }))));
		}
	}
}

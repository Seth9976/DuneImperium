using System;
using Canis.context;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Networking.selection.targetinformation;

namespace Canis.entities
{
	// Token: 0x020000BD RID: 189
	public static class AbilityExtensions : Object
	{
		// Token: 0x060008BC RID: 2236 RVA: 0x0003D00C File Offset: 0x0003B20C
		// Note: this type is marked as 'beforefieldinit'.
		static AbilityExtensions()
		{
			Il2CppClassPointerStore<AbilityExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "AbilityExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityExtensions>.NativeClassPtr);
			AbilityExtensions.NativeMethodInfoPtr_TargetingContext_Public_Static_Context_IAbilityDefinition_PlayerEntity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityExtensions>.NativeClassPtr, 100665098);
			AbilityExtensions.NativeMethodInfoPtr_CostContext_Public_Static_Context_IAbilityDefinition_PlayerEntity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityExtensions>.NativeClassPtr, 100665099);
			AbilityExtensions.NativeMethodInfoPtr_EventContext_Public_Static_Context_IAbilityDefinition_PlayerEntity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityExtensions>.NativeClassPtr, 100665100);
			AbilityExtensions.NativeMethodInfoPtr_IsValidTargetInfo_Public_Static_Boolean_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityExtensions>.NativeClassPtr, 100665101);
			AbilityExtensions.NativeMethodInfoPtr_HasTargets_Public_Static_Boolean_IAbilityDefinition_Match_PlayerEntity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityExtensions>.NativeClassPtr, 100665102);
			AbilityExtensions.NativeMethodInfoPtr_MeetsCost_Public_Static_Boolean_IAbilityDefinition_Match_PlayerEntity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityExtensions>.NativeClassPtr, 100665103);
			AbilityExtensions.NativeMethodInfoPtr_HasTargetsAndMeetsCost_Public_Static_Boolean_IAbilityDefinition_Match_PlayerEntity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityExtensions>.NativeClassPtr, 100665104);
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x0003D0C8 File Offset: 0x0003B2C8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 561194, RefRangeEnd = 561200, XrefRangeStart = 561187, XrefRangeEnd = 561194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Context TargetingContext(this IAbilityDefinition ability, PlayerEntity forPlayer, Context context = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ability);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(forPlayer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityExtensions.NativeMethodInfoPtr_TargetingContext_Public_Static_Context_IAbilityDefinition_PlayerEntity_Context_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x0003D130 File Offset: 0x0003B330
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 561207, RefRangeEnd = 561212, XrefRangeStart = 561200, XrefRangeEnd = 561207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Context CostContext(this IAbilityDefinition ability, PlayerEntity forPlayer, Context context = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ability);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(forPlayer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityExtensions.NativeMethodInfoPtr_CostContext_Public_Static_Context_IAbilityDefinition_PlayerEntity_Context_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x0003D198 File Offset: 0x0003B398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561212, XrefRangeEnd = 561233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Context EventContext(this IAbilityDefinition ability, PlayerEntity forPlayer, Context context = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ability);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(forPlayer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityExtensions.NativeMethodInfoPtr_EventContext_Public_Static_Context_IAbilityDefinition_PlayerEntity_Context_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x0003D200 File Offset: 0x0003B400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561233, XrefRangeEnd = 561239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidTargetInfo(TargetInformation ti)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ti);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityExtensions.NativeMethodInfoPtr_IsValidTargetInfo_Public_Static_Boolean_TargetInformation_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x0003D244 File Offset: 0x0003B444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561239, XrefRangeEnd = 561252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasTargets(this IAbilityDefinition ability, Match match, PlayerEntity forPlayer, Context context = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ability);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(forPlayer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityExtensions.NativeMethodInfoPtr_HasTargets_Public_Static_Boolean_IAbilityDefinition_Match_PlayerEntity_Context_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x0003D2BC File Offset: 0x0003B4BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 561265, RefRangeEnd = 561266, XrefRangeStart = 561252, XrefRangeEnd = 561265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MeetsCost(this IAbilityDefinition ability, Match match, PlayerEntity forPlayer, Context context = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ability);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(forPlayer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityExtensions.NativeMethodInfoPtr_MeetsCost_Public_Static_Boolean_IAbilityDefinition_Match_PlayerEntity_Context_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x0003D334 File Offset: 0x0003B534
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 561277, RefRangeEnd = 561278, XrefRangeStart = 561266, XrefRangeEnd = 561277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasTargetsAndMeetsCost(this IAbilityDefinition ability, Match match, PlayerEntity forPlayer, Context context = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ability);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(forPlayer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityExtensions.NativeMethodInfoPtr_HasTargetsAndMeetsCost_Public_Static_Boolean_IAbilityDefinition_Match_PlayerEntity_Context_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00005687 File Offset: 0x00003887
		public AbilityExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeMethodInfoPtr_TargetingContext_Public_Static_Context_IAbilityDefinition_PlayerEntity_Context_0;

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeMethodInfoPtr_CostContext_Public_Static_Context_IAbilityDefinition_PlayerEntity_Context_0;

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeMethodInfoPtr_EventContext_Public_Static_Context_IAbilityDefinition_PlayerEntity_Context_0;

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeMethodInfoPtr_IsValidTargetInfo_Public_Static_Boolean_TargetInformation_0;

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeMethodInfoPtr_HasTargets_Public_Static_Boolean_IAbilityDefinition_Match_PlayerEntity_Context_0;

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeMethodInfoPtr_MeetsCost_Public_Static_Boolean_IAbilityDefinition_Match_PlayerEntity_Context_0;

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeMethodInfoPtr_HasTargetsAndMeetsCost_Public_Static_Boolean_IAbilityDefinition_Match_PlayerEntity_Context_0;
	}
}

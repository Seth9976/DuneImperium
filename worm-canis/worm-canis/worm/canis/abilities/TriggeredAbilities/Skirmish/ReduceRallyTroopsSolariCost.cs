using System;
using Canis.entities;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.abilities.TriggeredAbilities.Skirmish
{
	// Token: 0x0200033A RID: 826
	public class ReduceRallyTroopsSolariCost : ReduceSolariSpaceCost
	{
		// Token: 0x060021AB RID: 8619 RVA: 0x000DDA98 File Offset: 0x000DBC98
		// Note: this type is marked as 'beforefieldinit'.
		static ReduceRallyTroopsSolariCost()
		{
			Il2CppClassPointerStore<ReduceRallyTroopsSolariCost>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities.Skirmish", "ReduceRallyTroopsSolariCost");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReduceRallyTroopsSolariCost>.NativeClassPtr);
			ReduceRallyTroopsSolariCost.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReduceRallyTroopsSolariCost>.NativeClassPtr, "AbilityName");
			ReduceRallyTroopsSolariCost.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReduceRallyTroopsSolariCost>.NativeClassPtr, "AbilityID");
			ReduceRallyTroopsSolariCost.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReduceRallyTroopsSolariCost>.NativeClassPtr, 100671782);
			ReduceRallyTroopsSolariCost.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReduceRallyTroopsSolariCost>.NativeClassPtr, 100671783);
			ReduceRallyTroopsSolariCost.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReduceRallyTroopsSolariCost>.NativeClassPtr, 100671784);
			ReduceRallyTroopsSolariCost.NativeMethodInfoPtr_get_SpaceArchetype_Protected_Virtual_get_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReduceRallyTroopsSolariCost>.NativeClassPtr, 100671785);
			ReduceRallyTroopsSolariCost.NativeMethodInfoPtr_get_ReductionAmt_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReduceRallyTroopsSolariCost>.NativeClassPtr, 100671786);
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x000DDB54 File Offset: 0x000DBD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178932, XrefRangeEnd = 178936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReduceRallyTroopsSolariCost.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x000DDBA0 File Offset: 0x000DBDA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178936, XrefRangeEnd = 178944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReduceRallyTroopsSolariCost(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReduceRallyTroopsSolariCost>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReduceRallyTroopsSolariCost.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021AE RID: 8622 RVA: 0x000DDBEC File Offset: 0x000DBDEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReduceRallyTroopsSolariCost(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReduceRallyTroopsSolariCost>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReduceRallyTroopsSolariCost.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x060021AF RID: 8623 RVA: 0x000DDC5C File Offset: 0x000DBE5C
		public unsafe override ArchetypeID SpaceArchetype
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178944, XrefRangeEnd = 178948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReduceRallyTroopsSolariCost.NativeMethodInfoPtr_get_SpaceArchetype_Protected_Virtual_get_ArchetypeID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x060021B0 RID: 8624 RVA: 0x000DDCA8 File Offset: 0x000DBEA8
		public unsafe override int ReductionAmt
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReduceRallyTroopsSolariCost.NativeMethodInfoPtr_get_ReductionAmt_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021B1 RID: 8625 RVA: 0x0000DAEA File Offset: 0x0000BCEA
		public ReduceRallyTroopsSolariCost(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x060021B2 RID: 8626 RVA: 0x000DDCF0 File Offset: 0x000DBEF0
		// (set) Token: 0x060021B3 RID: 8627 RVA: 0x0000DAF3 File Offset: 0x0000BCF3
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReduceRallyTroopsSolariCost.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReduceRallyTroopsSolariCost.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x060021B4 RID: 8628 RVA: 0x000DDD10 File Offset: 0x000DBF10
		// (set) Token: 0x060021B5 RID: 8629 RVA: 0x0000DB05 File Offset: 0x0000BD05
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReduceRallyTroopsSolariCost.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReduceRallyTroopsSolariCost.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001545 RID: 5445
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001546 RID: 5446
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001547 RID: 5447
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001548 RID: 5448
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04001549 RID: 5449
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x0400154A RID: 5450
		private static readonly IntPtr NativeMethodInfoPtr_get_SpaceArchetype_Protected_Virtual_get_ArchetypeID_0;

		// Token: 0x0400154B RID: 5451
		private static readonly IntPtr NativeMethodInfoPtr_get_ReductionAmt_Protected_Virtual_get_Int32_0;
	}
}

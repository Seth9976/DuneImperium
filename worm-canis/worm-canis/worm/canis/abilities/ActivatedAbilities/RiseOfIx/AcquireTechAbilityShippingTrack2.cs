using System;
using Canis;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.gameLogs;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.abilities.ActivatedAbilities.RiseOfIx
{
	// Token: 0x020004C6 RID: 1222
	public class AcquireTechAbilityShippingTrack2 : AcquireTechAbility
	{
		// Token: 0x06003718 RID: 14104 RVA: 0x00145E24 File Offset: 0x00144024
		// Note: this type is marked as 'beforefieldinit'.
		static AcquireTechAbilityShippingTrack2()
		{
			Il2CppClassPointerStore<AcquireTechAbilityShippingTrack2>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.ActivatedAbilities.RiseOfIx", "AcquireTechAbilityShippingTrack2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AcquireTechAbilityShippingTrack2>.NativeClassPtr);
			AcquireTechAbilityShippingTrack2.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquireTechAbilityShippingTrack2>.NativeClassPtr, "AbilityName");
			AcquireTechAbilityShippingTrack2.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquireTechAbilityShippingTrack2>.NativeClassPtr, "AbilityID");
			AcquireTechAbilityShippingTrack2.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTechAbilityShippingTrack2>.NativeClassPtr, 100680755);
			AcquireTechAbilityShippingTrack2.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTechAbilityShippingTrack2>.NativeClassPtr, 100680756);
			AcquireTechAbilityShippingTrack2.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTechAbilityShippingTrack2>.NativeClassPtr, 100680757);
			AcquireTechAbilityShippingTrack2.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTechAbilityShippingTrack2>.NativeClassPtr, 100680758);
			AcquireTechAbilityShippingTrack2.NativeMethodInfoPtr_get_TechDiscount_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTechAbilityShippingTrack2>.NativeClassPtr, 100680759);
			AcquireTechAbilityShippingTrack2.NativeMethodInfoPtr_get_IsCustomAbility_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTechAbilityShippingTrack2>.NativeClassPtr, 100680760);
			AcquireTechAbilityShippingTrack2.NativeMethodInfoPtr_IsUnexhausted_Protected_Virtual_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTechAbilityShippingTrack2>.NativeClassPtr, 100680761);
			AcquireTechAbilityShippingTrack2.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTechAbilityShippingTrack2>.NativeClassPtr, 100680762);
		}

		// Token: 0x06003719 RID: 14105 RVA: 0x00145F1C File Offset: 0x0014411C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246327, XrefRangeEnd = 246331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AcquireTechAbilityShippingTrack2.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x0600371A RID: 14106 RVA: 0x00145F68 File Offset: 0x00144168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246331, XrefRangeEnd = 246351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GameLogBuilder MakeGameLogBuilder(IHasGameLogs hasGameLogs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasGameLogs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AcquireTechAbilityShippingTrack2.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x0600371B RID: 14107 RVA: 0x00145FC4 File Offset: 0x001441C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246351, XrefRangeEnd = 246357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AcquireTechAbilityShippingTrack2(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AcquireTechAbilityShippingTrack2>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcquireTechAbilityShippingTrack2.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600371C RID: 14108 RVA: 0x00146010 File Offset: 0x00144210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246357, XrefRangeEnd = 246361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AcquireTechAbilityShippingTrack2(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AcquireTechAbilityShippingTrack2>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcquireTechAbilityShippingTrack2.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x0600371D RID: 14109 RVA: 0x00146080 File Offset: 0x00144280
		public unsafe override int TechDiscount
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AcquireTechAbilityShippingTrack2.NativeMethodInfoPtr_get_TechDiscount_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x0600371E RID: 14110 RVA: 0x001460C8 File Offset: 0x001442C8
		public unsafe override bool IsCustomAbility
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AcquireTechAbilityShippingTrack2.NativeMethodInfoPtr_get_IsCustomAbility_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600371F RID: 14111 RVA: 0x00146110 File Offset: 0x00144310
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AcquireTechAbilityShippingTrack2.NativeMethodInfoPtr_IsUnexhausted_Protected_Virtual_Boolean_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003720 RID: 14112 RVA: 0x00146168 File Offset: 0x00144368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246361, XrefRangeEnd = 246370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AcquireTechAbilityShippingTrack2.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x06003721 RID: 14113 RVA: 0x000127C0 File Offset: 0x000109C0
		public AcquireTechAbilityShippingTrack2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x06003722 RID: 14114 RVA: 0x001461D8 File Offset: 0x001443D8
		// (set) Token: 0x06003723 RID: 14115 RVA: 0x000127C9 File Offset: 0x000109C9
		public new unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AcquireTechAbilityShippingTrack2.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AcquireTechAbilityShippingTrack2.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x06003724 RID: 14116 RVA: 0x001461F8 File Offset: 0x001443F8
		// (set) Token: 0x06003725 RID: 14117 RVA: 0x000127DB File Offset: 0x000109DB
		public new unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AcquireTechAbilityShippingTrack2.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AcquireTechAbilityShippingTrack2.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002409 RID: 9225
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x0400240A RID: 9226
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x0400240B RID: 9227
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x0400240C RID: 9228
		private static readonly IntPtr NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0;

		// Token: 0x0400240D RID: 9229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x0400240E RID: 9230
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x0400240F RID: 9231
		private static readonly IntPtr NativeMethodInfoPtr_get_TechDiscount_Protected_Virtual_get_Int32_0;

		// Token: 0x04002410 RID: 9232
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCustomAbility_Protected_Virtual_get_Boolean_0;

		// Token: 0x04002411 RID: 9233
		private static readonly IntPtr NativeMethodInfoPtr_IsUnexhausted_Protected_Virtual_Boolean_PlayerEntity_0;

		// Token: 0x04002412 RID: 9234
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;
	}
}

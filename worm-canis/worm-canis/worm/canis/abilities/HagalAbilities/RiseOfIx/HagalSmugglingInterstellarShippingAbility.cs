using System;
using Canis.actions;
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
using worm.canis.entities;

namespace worm.canis.abilities.HagalAbilities.RiseOfIx
{
	// Token: 0x020003C6 RID: 966
	public class HagalSmugglingInterstellarShippingAbility : HagalAbility
	{
		// Token: 0x060028AC RID: 10412 RVA: 0x000FEAC8 File Offset: 0x000FCCC8
		// Note: this type is marked as 'beforefieldinit'.
		static HagalSmugglingInterstellarShippingAbility()
		{
			Il2CppClassPointerStore<HagalSmugglingInterstellarShippingAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.HagalAbilities.RiseOfIx", "HagalSmugglingInterstellarShippingAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalSmugglingInterstellarShippingAbility>.NativeClassPtr);
			HagalSmugglingInterstellarShippingAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSmugglingInterstellarShippingAbility>.NativeClassPtr, "AbilityName");
			HagalSmugglingInterstellarShippingAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSmugglingInterstellarShippingAbility>.NativeClassPtr, "AbilityID");
			HagalSmugglingInterstellarShippingAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSmugglingInterstellarShippingAbility>.NativeClassPtr, 100675225);
			HagalSmugglingInterstellarShippingAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSmugglingInterstellarShippingAbility>.NativeClassPtr, 100675226);
			HagalSmugglingInterstellarShippingAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSmugglingInterstellarShippingAbility>.NativeClassPtr, 100675227);
			HagalSmugglingInterstellarShippingAbility.NativeMethodInfoPtr_GetSpace_Protected_Virtual_WormSpace_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSmugglingInterstellarShippingAbility>.NativeClassPtr, 100675228);
			HagalSmugglingInterstellarShippingAbility.NativeMethodInfoPtr_GrantResources_Protected_Virtual_IEnumerable_1_Action_WormMatch_Context_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSmugglingInterstellarShippingAbility>.NativeClassPtr, 100675229);
		}

		// Token: 0x060028AD RID: 10413 RVA: 0x000FEB84 File Offset: 0x000FCD84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199991, XrefRangeEnd = 199995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalSmugglingInterstellarShippingAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x060028AE RID: 10414 RVA: 0x000FEBD0 File Offset: 0x000FCDD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199995, XrefRangeEnd = 200001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalSmugglingInterstellarShippingAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalSmugglingInterstellarShippingAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSmugglingInterstellarShippingAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028AF RID: 10415 RVA: 0x000FEC1C File Offset: 0x000FCE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200001, XrefRangeEnd = 200005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalSmugglingInterstellarShippingAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalSmugglingInterstellarShippingAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSmugglingInterstellarShippingAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028B0 RID: 10416 RVA: 0x000FEC8C File Offset: 0x000FCE8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200005, XrefRangeEnd = 200020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WormSpace GetSpace(WormMatch match, WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalSmugglingInterstellarShippingAbility.NativeMethodInfoPtr_GetSpace_Protected_Virtual_WormSpace_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr3) : null;
		}

		// Token: 0x060028B1 RID: 10417 RVA: 0x000FECFC File Offset: 0x000FCEFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200020, XrefRangeEnd = 200028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Canis.actions.Action> GrantResources(WormMatch match, Context context, WormSpace space)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(space);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalSmugglingInterstellarShippingAbility.NativeMethodInfoPtr_GrantResources_Protected_Virtual_IEnumerable_1_Action_WormMatch_Context_WormSpace_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060028B2 RID: 10418 RVA: 0x0000F3CC File Offset: 0x0000D5CC
		public HagalSmugglingInterstellarShippingAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x060028B3 RID: 10419 RVA: 0x000FED7C File Offset: 0x000FCF7C
		// (set) Token: 0x060028B4 RID: 10420 RVA: 0x0000F3D5 File Offset: 0x0000D5D5
		public new unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalSmugglingInterstellarShippingAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalSmugglingInterstellarShippingAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x060028B5 RID: 10421 RVA: 0x000FED9C File Offset: 0x000FCF9C
		// (set) Token: 0x060028B6 RID: 10422 RVA: 0x0000F3E7 File Offset: 0x0000D5E7
		public new unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalSmugglingInterstellarShippingAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalSmugglingInterstellarShippingAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A10 RID: 6672
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001A11 RID: 6673
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001A12 RID: 6674
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001A13 RID: 6675
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04001A14 RID: 6676
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001A15 RID: 6677
		private static readonly IntPtr NativeMethodInfoPtr_GetSpace_Protected_Virtual_WormSpace_WormMatch_WormPlayer_0;

		// Token: 0x04001A16 RID: 6678
		private static readonly IntPtr NativeMethodInfoPtr_GrantResources_Protected_Virtual_IEnumerable_1_Action_WormMatch_Context_WormSpace_0;

		// Token: 0x02000979 RID: 2425
		[ObfuscatedName("worm.canis.abilities.HagalAbilities.RiseOfIx.HagalSmugglingInterstellarShippingAbility+<GrantResources>d__6")]
		public sealed class _GrantResources_d__6 : Object
		{
			// Token: 0x06009296 RID: 37526 RVA: 0x002714E0 File Offset: 0x0026F6E0
			// Note: this type is marked as 'beforefieldinit'.
			static _GrantResources_d__6()
			{
				Il2CppClassPointerStore<HagalSmugglingInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HagalSmugglingInterstellarShippingAbility>.NativeClassPtr, "<GrantResources>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalSmugglingInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr);
				HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSmugglingInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, "<>1__state");
				HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSmugglingInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, "<>2__current");
				HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSmugglingInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, "<>l__initialThreadId");
				HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSmugglingInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, "context");
				HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSmugglingInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, "<>3__context");
				HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSmugglingInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, "match");
				HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSmugglingInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, "<>3__match");
				HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr_space = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSmugglingInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, "space");
				HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___3__space = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSmugglingInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, "<>3__space");
				HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSmugglingInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, "<player>5__2");
				HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSmugglingInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, 100675231);
				HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSmugglingInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, 100675232);
				HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSmugglingInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, 100675233);
				HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSmugglingInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, 100675234);
				HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSmugglingInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, 100675235);
				HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSmugglingInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, 100675236);
				HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSmugglingInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, 100675237);
				HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSmugglingInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, 100675238);
			}

			// Token: 0x06009297 RID: 37527 RVA: 0x00271674 File Offset: 0x0026F874
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GrantResources_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalSmugglingInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06009298 RID: 37528 RVA: 0x002716BC File Offset: 0x0026F8BC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009299 RID: 37529 RVA: 0x002716F0 File Offset: 0x0026F8F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199949, XrefRangeEnd = 199976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002B2C RID: 11052
			// (get) Token: 0x0600929A RID: 37530 RVA: 0x0027172C File Offset: 0x0026F92C
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600929B RID: 37531 RVA: 0x0027176C File Offset: 0x0026F96C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199976, XrefRangeEnd = 199981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002B2D RID: 11053
			// (get) Token: 0x0600929C RID: 37532 RVA: 0x002717A0 File Offset: 0x0026F9A0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600929D RID: 37533 RVA: 0x002717E0 File Offset: 0x0026F9E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199981, XrefRangeEnd = 199991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600929E RID: 37534 RVA: 0x00271820 File Offset: 0x0026FA20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600929F RID: 37535 RVA: 0x0003F965 File Offset: 0x0003DB65
			public _GrantResources_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002B22 RID: 11042
			// (get) Token: 0x060092A0 RID: 37536 RVA: 0x00271860 File Offset: 0x0026FA60
			// (set) Token: 0x060092A1 RID: 37537 RVA: 0x0003F96E File Offset: 0x0003DB6E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002B23 RID: 11043
			// (get) Token: 0x060092A2 RID: 37538 RVA: 0x00271888 File Offset: 0x0026FA88
			// (set) Token: 0x060092A3 RID: 37539 RVA: 0x0003F989 File Offset: 0x0003DB89
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B24 RID: 11044
			// (get) Token: 0x060092A4 RID: 37540 RVA: 0x002718B8 File Offset: 0x0026FAB8
			// (set) Token: 0x060092A5 RID: 37541 RVA: 0x0003F9A8 File Offset: 0x0003DBA8
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002B25 RID: 11045
			// (get) Token: 0x060092A6 RID: 37542 RVA: 0x002718E0 File Offset: 0x0026FAE0
			// (set) Token: 0x060092A7 RID: 37543 RVA: 0x0003F9C3 File Offset: 0x0003DBC3
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B26 RID: 11046
			// (get) Token: 0x060092A8 RID: 37544 RVA: 0x00271910 File Offset: 0x0026FB10
			// (set) Token: 0x060092A9 RID: 37545 RVA: 0x0003F9E2 File Offset: 0x0003DBE2
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B27 RID: 11047
			// (get) Token: 0x060092AA RID: 37546 RVA: 0x00271940 File Offset: 0x0026FB40
			// (set) Token: 0x060092AB RID: 37547 RVA: 0x0003FA01 File Offset: 0x0003DC01
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B28 RID: 11048
			// (get) Token: 0x060092AC RID: 37548 RVA: 0x00271970 File Offset: 0x0026FB70
			// (set) Token: 0x060092AD RID: 37549 RVA: 0x0003FA20 File Offset: 0x0003DC20
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B29 RID: 11049
			// (get) Token: 0x060092AE RID: 37550 RVA: 0x002719A0 File Offset: 0x0026FBA0
			// (set) Token: 0x060092AF RID: 37551 RVA: 0x0003FA3F File Offset: 0x0003DC3F
			public unsafe WormSpace space
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr_space);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr_space), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B2A RID: 11050
			// (get) Token: 0x060092B0 RID: 37552 RVA: 0x002719D0 File Offset: 0x0026FBD0
			// (set) Token: 0x060092B1 RID: 37553 RVA: 0x0003FA5E File Offset: 0x0003DC5E
			public unsafe WormSpace __3__space
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___3__space);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___3__space), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B2B RID: 11051
			// (get) Token: 0x060092B2 RID: 37554 RVA: 0x00271A00 File Offset: 0x0026FC00
			// (set) Token: 0x060092B3 RID: 37555 RVA: 0x0003FA7D File Offset: 0x0003DC7D
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSmugglingInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005D71 RID: 23921
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005D72 RID: 23922
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005D73 RID: 23923
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04005D74 RID: 23924
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04005D75 RID: 23925
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x04005D76 RID: 23926
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04005D77 RID: 23927
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04005D78 RID: 23928
			private static readonly IntPtr NativeFieldInfoPtr_space;

			// Token: 0x04005D79 RID: 23929
			private static readonly IntPtr NativeFieldInfoPtr___3__space;

			// Token: 0x04005D7A RID: 23930
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04005D7B RID: 23931
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005D7C RID: 23932
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005D7D RID: 23933
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005D7E RID: 23934
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04005D7F RID: 23935
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005D80 RID: 23936
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005D81 RID: 23937
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04005D82 RID: 23938
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

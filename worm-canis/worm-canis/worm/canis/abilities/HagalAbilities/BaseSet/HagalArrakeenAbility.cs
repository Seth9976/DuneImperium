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

namespace worm.canis.abilities.HagalAbilities.BaseSet
{
	// Token: 0x020003CC RID: 972
	public class HagalArrakeenAbility : HagalAbility
	{
		// Token: 0x060028EA RID: 10474 RVA: 0x000FFA94 File Offset: 0x000FDC94
		// Note: this type is marked as 'beforefieldinit'.
		static HagalArrakeenAbility()
		{
			Il2CppClassPointerStore<HagalArrakeenAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.HagalAbilities.BaseSet", "HagalArrakeenAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalArrakeenAbility>.NativeClassPtr);
			HagalArrakeenAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalArrakeenAbility>.NativeClassPtr, "AbilityName");
			HagalArrakeenAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalArrakeenAbility>.NativeClassPtr, "AbilityID");
			HagalArrakeenAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalArrakeenAbility>.NativeClassPtr, 100675315);
			HagalArrakeenAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalArrakeenAbility>.NativeClassPtr, 100675316);
			HagalArrakeenAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalArrakeenAbility>.NativeClassPtr, 100675317);
			HagalArrakeenAbility.NativeMethodInfoPtr_GrantResources_Protected_Virtual_IEnumerable_1_Action_WormMatch_Context_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalArrakeenAbility>.NativeClassPtr, 100675318);
		}

		// Token: 0x060028EB RID: 10475 RVA: 0x000FFB3C File Offset: 0x000FDD3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200493, XrefRangeEnd = 200497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalArrakeenAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x060028EC RID: 10476 RVA: 0x000FFB88 File Offset: 0x000FDD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200497, XrefRangeEnd = 200503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalArrakeenAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalArrakeenAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalArrakeenAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x000FFBD4 File Offset: 0x000FDDD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200503, XrefRangeEnd = 200507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalArrakeenAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalArrakeenAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalArrakeenAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028EE RID: 10478 RVA: 0x000FFC44 File Offset: 0x000FDE44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200507, XrefRangeEnd = 200515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalArrakeenAbility.NativeMethodInfoPtr_GrantResources_Protected_Virtual_IEnumerable_1_Action_WormMatch_Context_WormSpace_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060028EF RID: 10479 RVA: 0x0000F4DA File Offset: 0x0000D6DA
		public HagalArrakeenAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x060028F0 RID: 10480 RVA: 0x000FFCC4 File Offset: 0x000FDEC4
		// (set) Token: 0x060028F1 RID: 10481 RVA: 0x0000F4E3 File Offset: 0x0000D6E3
		public new unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalArrakeenAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalArrakeenAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x060028F2 RID: 10482 RVA: 0x000FFCE4 File Offset: 0x000FDEE4
		// (set) Token: 0x060028F3 RID: 10483 RVA: 0x0000F4F5 File Offset: 0x0000D6F5
		public new unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalArrakeenAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalArrakeenAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A36 RID: 6710
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001A37 RID: 6711
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001A38 RID: 6712
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001A39 RID: 6713
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04001A3A RID: 6714
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001A3B RID: 6715
		private static readonly IntPtr NativeMethodInfoPtr_GrantResources_Protected_Virtual_IEnumerable_1_Action_WormMatch_Context_WormSpace_0;

		// Token: 0x02000980 RID: 2432
		[ObfuscatedName("worm.canis.abilities.HagalAbilities.BaseSet.HagalArrakeenAbility+<GrantResources>d__5")]
		public sealed class _GrantResources_d__5 : Object
		{
			// Token: 0x06009346 RID: 37702 RVA: 0x002735D0 File Offset: 0x002717D0
			// Note: this type is marked as 'beforefieldinit'.
			static _GrantResources_d__5()
			{
				Il2CppClassPointerStore<HagalArrakeenAbility._GrantResources_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HagalArrakeenAbility>.NativeClassPtr, "<GrantResources>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalArrakeenAbility._GrantResources_d__5>.NativeClassPtr);
				HagalArrakeenAbility._GrantResources_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalArrakeenAbility._GrantResources_d__5>.NativeClassPtr, "<>1__state");
				HagalArrakeenAbility._GrantResources_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalArrakeenAbility._GrantResources_d__5>.NativeClassPtr, "<>2__current");
				HagalArrakeenAbility._GrantResources_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalArrakeenAbility._GrantResources_d__5>.NativeClassPtr, "<>l__initialThreadId");
				HagalArrakeenAbility._GrantResources_d__5.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalArrakeenAbility._GrantResources_d__5>.NativeClassPtr, "context");
				HagalArrakeenAbility._GrantResources_d__5.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalArrakeenAbility._GrantResources_d__5>.NativeClassPtr, "<>3__context");
				HagalArrakeenAbility._GrantResources_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalArrakeenAbility._GrantResources_d__5>.NativeClassPtr, "<>4__this");
				HagalArrakeenAbility._GrantResources_d__5.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalArrakeenAbility._GrantResources_d__5>.NativeClassPtr, "match");
				HagalArrakeenAbility._GrantResources_d__5.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalArrakeenAbility._GrantResources_d__5>.NativeClassPtr, "<>3__match");
				HagalArrakeenAbility._GrantResources_d__5.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalArrakeenAbility._GrantResources_d__5>.NativeClassPtr, "<player>5__2");
				HagalArrakeenAbility._GrantResources_d__5.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalArrakeenAbility._GrantResources_d__5>.NativeClassPtr, "<>7__wrap2");
				HagalArrakeenAbility._GrantResources_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalArrakeenAbility._GrantResources_d__5>.NativeClassPtr, 100675320);
				HagalArrakeenAbility._GrantResources_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalArrakeenAbility._GrantResources_d__5>.NativeClassPtr, 100675321);
				HagalArrakeenAbility._GrantResources_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalArrakeenAbility._GrantResources_d__5>.NativeClassPtr, 100675322);
				HagalArrakeenAbility._GrantResources_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalArrakeenAbility._GrantResources_d__5>.NativeClassPtr, 100675323);
				HagalArrakeenAbility._GrantResources_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalArrakeenAbility._GrantResources_d__5>.NativeClassPtr, 100675324);
				HagalArrakeenAbility._GrantResources_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalArrakeenAbility._GrantResources_d__5>.NativeClassPtr, 100675325);
				HagalArrakeenAbility._GrantResources_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalArrakeenAbility._GrantResources_d__5>.NativeClassPtr, 100675326);
				HagalArrakeenAbility._GrantResources_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalArrakeenAbility._GrantResources_d__5>.NativeClassPtr, 100675327);
				HagalArrakeenAbility._GrantResources_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalArrakeenAbility._GrantResources_d__5>.NativeClassPtr, 100675328);
			}

			// Token: 0x06009347 RID: 37703 RVA: 0x00273778 File Offset: 0x00271978
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GrantResources_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalArrakeenAbility._GrantResources_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalArrakeenAbility._GrantResources_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06009348 RID: 37704 RVA: 0x002737C0 File Offset: 0x002719C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200376, XrefRangeEnd = 200381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalArrakeenAbility._GrantResources_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009349 RID: 37705 RVA: 0x002737F4 File Offset: 0x002719F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200381, XrefRangeEnd = 200475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalArrakeenAbility._GrantResources_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600934A RID: 37706 RVA: 0x00273830 File Offset: 0x00271A30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200475, XrefRangeEnd = 200478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalArrakeenAbility._GrantResources_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002B6E RID: 11118
			// (get) Token: 0x0600934B RID: 37707 RVA: 0x00273864 File Offset: 0x00271A64
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalArrakeenAbility._GrantResources_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600934C RID: 37708 RVA: 0x002738A4 File Offset: 0x00271AA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200478, XrefRangeEnd = 200483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalArrakeenAbility._GrantResources_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002B6F RID: 11119
			// (get) Token: 0x0600934D RID: 37709 RVA: 0x002738D8 File Offset: 0x00271AD8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalArrakeenAbility._GrantResources_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600934E RID: 37710 RVA: 0x00273918 File Offset: 0x00271B18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200483, XrefRangeEnd = 200493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalArrakeenAbility._GrantResources_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600934F RID: 37711 RVA: 0x00273958 File Offset: 0x00271B58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalArrakeenAbility._GrantResources_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06009350 RID: 37712 RVA: 0x0003FFB4 File Offset: 0x0003E1B4
			public _GrantResources_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002B64 RID: 11108
			// (get) Token: 0x06009351 RID: 37713 RVA: 0x00273998 File Offset: 0x00271B98
			// (set) Token: 0x06009352 RID: 37714 RVA: 0x0003FFBD File Offset: 0x0003E1BD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalArrakeenAbility._GrantResources_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalArrakeenAbility._GrantResources_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002B65 RID: 11109
			// (get) Token: 0x06009353 RID: 37715 RVA: 0x002739C0 File Offset: 0x00271BC0
			// (set) Token: 0x06009354 RID: 37716 RVA: 0x0003FFD8 File Offset: 0x0003E1D8
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalArrakeenAbility._GrantResources_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalArrakeenAbility._GrantResources_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B66 RID: 11110
			// (get) Token: 0x06009355 RID: 37717 RVA: 0x002739F0 File Offset: 0x00271BF0
			// (set) Token: 0x06009356 RID: 37718 RVA: 0x0003FFF7 File Offset: 0x0003E1F7
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalArrakeenAbility._GrantResources_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalArrakeenAbility._GrantResources_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002B67 RID: 11111
			// (get) Token: 0x06009357 RID: 37719 RVA: 0x00273A18 File Offset: 0x00271C18
			// (set) Token: 0x06009358 RID: 37720 RVA: 0x00040012 File Offset: 0x0003E212
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalArrakeenAbility._GrantResources_d__5.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalArrakeenAbility._GrantResources_d__5.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B68 RID: 11112
			// (get) Token: 0x06009359 RID: 37721 RVA: 0x00273A48 File Offset: 0x00271C48
			// (set) Token: 0x0600935A RID: 37722 RVA: 0x00040031 File Offset: 0x0003E231
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalArrakeenAbility._GrantResources_d__5.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalArrakeenAbility._GrantResources_d__5.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B69 RID: 11113
			// (get) Token: 0x0600935B RID: 37723 RVA: 0x00273A78 File Offset: 0x00271C78
			// (set) Token: 0x0600935C RID: 37724 RVA: 0x00040050 File Offset: 0x0003E250
			public unsafe HagalArrakeenAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalArrakeenAbility._GrantResources_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HagalArrakeenAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalArrakeenAbility._GrantResources_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B6A RID: 11114
			// (get) Token: 0x0600935D RID: 37725 RVA: 0x00273AA8 File Offset: 0x00271CA8
			// (set) Token: 0x0600935E RID: 37726 RVA: 0x0004006F File Offset: 0x0003E26F
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalArrakeenAbility._GrantResources_d__5.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalArrakeenAbility._GrantResources_d__5.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B6B RID: 11115
			// (get) Token: 0x0600935F RID: 37727 RVA: 0x00273AD8 File Offset: 0x00271CD8
			// (set) Token: 0x06009360 RID: 37728 RVA: 0x0004008E File Offset: 0x0003E28E
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalArrakeenAbility._GrantResources_d__5.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalArrakeenAbility._GrantResources_d__5.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B6C RID: 11116
			// (get) Token: 0x06009361 RID: 37729 RVA: 0x00273B08 File Offset: 0x00271D08
			// (set) Token: 0x06009362 RID: 37730 RVA: 0x000400AD File Offset: 0x0003E2AD
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalArrakeenAbility._GrantResources_d__5.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalArrakeenAbility._GrantResources_d__5.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B6D RID: 11117
			// (get) Token: 0x06009363 RID: 37731 RVA: 0x00273B38 File Offset: 0x00271D38
			// (set) Token: 0x06009364 RID: 37732 RVA: 0x000400CC File Offset: 0x0003E2CC
			public unsafe IEnumerator<Canis.actions.Action> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalArrakeenAbility._GrantResources_d__5.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalArrakeenAbility._GrantResources_d__5.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005DDF RID: 24031
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005DE0 RID: 24032
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005DE1 RID: 24033
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04005DE2 RID: 24034
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04005DE3 RID: 24035
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x04005DE4 RID: 24036
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005DE5 RID: 24037
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04005DE6 RID: 24038
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04005DE7 RID: 24039
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04005DE8 RID: 24040
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04005DE9 RID: 24041
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005DEA RID: 24042
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005DEB RID: 24043
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005DEC RID: 24044
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04005DED RID: 24045
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04005DEE RID: 24046
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005DEF RID: 24047
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005DF0 RID: 24048
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04005DF1 RID: 24049
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

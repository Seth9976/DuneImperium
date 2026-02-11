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
	// Token: 0x020003CD RID: 973
	public class HagalHarvestSpiceAbility : HagalAbility
	{
		// Token: 0x060028F4 RID: 10484 RVA: 0x000FFD0C File Offset: 0x000FDF0C
		// Note: this type is marked as 'beforefieldinit'.
		static HagalHarvestSpiceAbility()
		{
			Il2CppClassPointerStore<HagalHarvestSpiceAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.HagalAbilities.BaseSet", "HagalHarvestSpiceAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalHarvestSpiceAbility>.NativeClassPtr);
			HagalHarvestSpiceAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalHarvestSpiceAbility>.NativeClassPtr, "AbilityName");
			HagalHarvestSpiceAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalHarvestSpiceAbility>.NativeClassPtr, "AbilityID");
			HagalHarvestSpiceAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalHarvestSpiceAbility>.NativeClassPtr, 100675329);
			HagalHarvestSpiceAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalHarvestSpiceAbility>.NativeClassPtr, 100675330);
			HagalHarvestSpiceAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalHarvestSpiceAbility>.NativeClassPtr, 100675331);
			HagalHarvestSpiceAbility.NativeMethodInfoPtr_GetSpace_Protected_Virtual_WormSpace_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalHarvestSpiceAbility>.NativeClassPtr, 100675332);
			HagalHarvestSpiceAbility.NativeMethodInfoPtr_GrantResources_Protected_Virtual_IEnumerable_1_Action_WormMatch_Context_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalHarvestSpiceAbility>.NativeClassPtr, 100675333);
		}

		// Token: 0x060028F5 RID: 10485 RVA: 0x000FFDC8 File Offset: 0x000FDFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200582, XrefRangeEnd = 200586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalHarvestSpiceAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x060028F6 RID: 10486 RVA: 0x000FFE14 File Offset: 0x000FE014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200586, XrefRangeEnd = 200592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalHarvestSpiceAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalHarvestSpiceAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalHarvestSpiceAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x000FFE60 File Offset: 0x000FE060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200592, XrefRangeEnd = 200596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalHarvestSpiceAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalHarvestSpiceAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalHarvestSpiceAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028F8 RID: 10488 RVA: 0x000FFED0 File Offset: 0x000FE0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200596, XrefRangeEnd = 200653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalHarvestSpiceAbility.NativeMethodInfoPtr_GetSpace_Protected_Virtual_WormSpace_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr3) : null;
		}

		// Token: 0x060028F9 RID: 10489 RVA: 0x000FFF40 File Offset: 0x000FE140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200653, XrefRangeEnd = 200662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalHarvestSpiceAbility.NativeMethodInfoPtr_GrantResources_Protected_Virtual_IEnumerable_1_Action_WormMatch_Context_WormSpace_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x0000F507 File Offset: 0x0000D707
		public HagalHarvestSpiceAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x060028FB RID: 10491 RVA: 0x000FFFC0 File Offset: 0x000FE1C0
		// (set) Token: 0x060028FC RID: 10492 RVA: 0x0000F510 File Offset: 0x0000D710
		public new unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalHarvestSpiceAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalHarvestSpiceAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x060028FD RID: 10493 RVA: 0x000FFFE0 File Offset: 0x000FE1E0
		// (set) Token: 0x060028FE RID: 10494 RVA: 0x0000F522 File Offset: 0x0000D722
		public new unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalHarvestSpiceAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalHarvestSpiceAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A3C RID: 6716
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001A3D RID: 6717
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001A3E RID: 6718
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001A3F RID: 6719
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04001A40 RID: 6720
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001A41 RID: 6721
		private static readonly IntPtr NativeMethodInfoPtr_GetSpace_Protected_Virtual_WormSpace_WormMatch_WormPlayer_0;

		// Token: 0x04001A42 RID: 6722
		private static readonly IntPtr NativeMethodInfoPtr_GrantResources_Protected_Virtual_IEnumerable_1_Action_WormMatch_Context_WormSpace_0;

		// Token: 0x02000981 RID: 2433
		[ObfuscatedName("worm.canis.abilities.HagalAbilities.BaseSet.HagalHarvestSpiceAbility+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06009365 RID: 37733 RVA: 0x00273B68 File Offset: 0x00271D68
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<HagalHarvestSpiceAbility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HagalHarvestSpiceAbility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalHarvestSpiceAbility.__c>.NativeClassPtr);
				HagalHarvestSpiceAbility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalHarvestSpiceAbility.__c>.NativeClassPtr, "<>9");
				HagalHarvestSpiceAbility.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalHarvestSpiceAbility.__c>.NativeClassPtr, "<>9__5_0");
				HagalHarvestSpiceAbility.__c.NativeFieldInfoPtr___9__5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalHarvestSpiceAbility.__c>.NativeClassPtr, "<>9__5_1");
				HagalHarvestSpiceAbility.__c.NativeFieldInfoPtr___9__5_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalHarvestSpiceAbility.__c>.NativeClassPtr, "<>9__5_2");
				HagalHarvestSpiceAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalHarvestSpiceAbility.__c>.NativeClassPtr, 100675336);
				HagalHarvestSpiceAbility.__c.NativeMethodInfoPtr__GetSpace_b__5_0_Internal_Int32_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalHarvestSpiceAbility.__c>.NativeClassPtr, 100675337);
				HagalHarvestSpiceAbility.__c.NativeMethodInfoPtr__GetSpace_b__5_1_Internal_Int32_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalHarvestSpiceAbility.__c>.NativeClassPtr, 100675338);
				HagalHarvestSpiceAbility.__c.NativeMethodInfoPtr__GetSpace_b__5_2_Internal_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalHarvestSpiceAbility.__c>.NativeClassPtr, 100675339);
			}

			// Token: 0x06009366 RID: 37734 RVA: 0x00273C34 File Offset: 0x00271E34
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalHarvestSpiceAbility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalHarvestSpiceAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009367 RID: 37735 RVA: 0x00273C70 File Offset: 0x00271E70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200515, XrefRangeEnd = 200516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetSpace_b__5_0(WormSpace _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalHarvestSpiceAbility.__c.NativeMethodInfoPtr__GetSpace_b__5_0_Internal_Int32_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06009368 RID: 37736 RVA: 0x00273CC0 File Offset: 0x00271EC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetSpace_b__5_1(WormSpace _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalHarvestSpiceAbility.__c.NativeMethodInfoPtr__GetSpace_b__5_1_Internal_Int32_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06009369 RID: 37737 RVA: 0x00273D10 File Offset: 0x00271F10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200516, XrefRangeEnd = 200525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetSpace_b__5_2(WormSpace _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalHarvestSpiceAbility.__c.NativeMethodInfoPtr__GetSpace_b__5_2_Internal_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600936A RID: 37738 RVA: 0x000400EB File Offset: 0x0003E2EB
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002B70 RID: 11120
			// (get) Token: 0x0600936B RID: 37739 RVA: 0x00273D60 File Offset: 0x00271F60
			// (set) Token: 0x0600936C RID: 37740 RVA: 0x000400F4 File Offset: 0x0003E2F4
			public unsafe static HagalHarvestSpiceAbility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalHarvestSpiceAbility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HagalHarvestSpiceAbility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalHarvestSpiceAbility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B71 RID: 11121
			// (get) Token: 0x0600936D RID: 37741 RVA: 0x00273D88 File Offset: 0x00271F88
			// (set) Token: 0x0600936E RID: 37742 RVA: 0x00040106 File Offset: 0x0003E306
			public unsafe static Func<WormSpace, int> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalHarvestSpiceAbility.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormSpace, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalHarvestSpiceAbility.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B72 RID: 11122
			// (get) Token: 0x0600936F RID: 37743 RVA: 0x00273DB0 File Offset: 0x00271FB0
			// (set) Token: 0x06009370 RID: 37744 RVA: 0x00040118 File Offset: 0x0003E318
			public unsafe static Func<WormSpace, int> __9__5_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalHarvestSpiceAbility.__c.NativeFieldInfoPtr___9__5_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormSpace, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalHarvestSpiceAbility.__c.NativeFieldInfoPtr___9__5_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B73 RID: 11123
			// (get) Token: 0x06009371 RID: 37745 RVA: 0x00273DD8 File Offset: 0x00271FD8
			// (set) Token: 0x06009372 RID: 37746 RVA: 0x0004012A File Offset: 0x0003E32A
			public unsafe static Func<WormSpace, bool> __9__5_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalHarvestSpiceAbility.__c.NativeFieldInfoPtr___9__5_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormSpace, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalHarvestSpiceAbility.__c.NativeFieldInfoPtr___9__5_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005DF2 RID: 24050
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005DF3 RID: 24051
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04005DF4 RID: 24052
			private static readonly IntPtr NativeFieldInfoPtr___9__5_1;

			// Token: 0x04005DF5 RID: 24053
			private static readonly IntPtr NativeFieldInfoPtr___9__5_2;

			// Token: 0x04005DF6 RID: 24054
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005DF7 RID: 24055
			private static readonly IntPtr NativeMethodInfoPtr__GetSpace_b__5_0_Internal_Int32_WormSpace_0;

			// Token: 0x04005DF8 RID: 24056
			private static readonly IntPtr NativeMethodInfoPtr__GetSpace_b__5_1_Internal_Int32_WormSpace_0;

			// Token: 0x04005DF9 RID: 24057
			private static readonly IntPtr NativeMethodInfoPtr__GetSpace_b__5_2_Internal_Boolean_WormSpace_0;
		}

		// Token: 0x02000982 RID: 2434
		[ObfuscatedName("worm.canis.abilities.HagalAbilities.BaseSet.HagalHarvestSpiceAbility+<GrantResources>d__6")]
		public sealed class _GrantResources_d__6 : Object
		{
			// Token: 0x06009373 RID: 37747 RVA: 0x00273E00 File Offset: 0x00272000
			// Note: this type is marked as 'beforefieldinit'.
			static _GrantResources_d__6()
			{
				Il2CppClassPointerStore<HagalHarvestSpiceAbility._GrantResources_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HagalHarvestSpiceAbility>.NativeClassPtr, "<GrantResources>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalHarvestSpiceAbility._GrantResources_d__6>.NativeClassPtr);
				HagalHarvestSpiceAbility._GrantResources_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalHarvestSpiceAbility._GrantResources_d__6>.NativeClassPtr, "<>1__state");
				HagalHarvestSpiceAbility._GrantResources_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalHarvestSpiceAbility._GrantResources_d__6>.NativeClassPtr, "<>2__current");
				HagalHarvestSpiceAbility._GrantResources_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalHarvestSpiceAbility._GrantResources_d__6>.NativeClassPtr, "<>l__initialThreadId");
				HagalHarvestSpiceAbility._GrantResources_d__6.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalHarvestSpiceAbility._GrantResources_d__6>.NativeClassPtr, "context");
				HagalHarvestSpiceAbility._GrantResources_d__6.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalHarvestSpiceAbility._GrantResources_d__6>.NativeClassPtr, "<>3__context");
				HagalHarvestSpiceAbility._GrantResources_d__6.NativeFieldInfoPtr_space = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalHarvestSpiceAbility._GrantResources_d__6>.NativeClassPtr, "space");
				HagalHarvestSpiceAbility._GrantResources_d__6.NativeFieldInfoPtr___3__space = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalHarvestSpiceAbility._GrantResources_d__6>.NativeClassPtr, "<>3__space");
				HagalHarvestSpiceAbility._GrantResources_d__6.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalHarvestSpiceAbility._GrantResources_d__6>.NativeClassPtr, "match");
				HagalHarvestSpiceAbility._GrantResources_d__6.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalHarvestSpiceAbility._GrantResources_d__6>.NativeClassPtr, "<>3__match");
				HagalHarvestSpiceAbility._GrantResources_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalHarvestSpiceAbility._GrantResources_d__6>.NativeClassPtr, "<>4__this");
				HagalHarvestSpiceAbility._GrantResources_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalHarvestSpiceAbility._GrantResources_d__6>.NativeClassPtr, 100675340);
				HagalHarvestSpiceAbility._GrantResources_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalHarvestSpiceAbility._GrantResources_d__6>.NativeClassPtr, 100675341);
				HagalHarvestSpiceAbility._GrantResources_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalHarvestSpiceAbility._GrantResources_d__6>.NativeClassPtr, 100675342);
				HagalHarvestSpiceAbility._GrantResources_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalHarvestSpiceAbility._GrantResources_d__6>.NativeClassPtr, 100675343);
				HagalHarvestSpiceAbility._GrantResources_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalHarvestSpiceAbility._GrantResources_d__6>.NativeClassPtr, 100675344);
				HagalHarvestSpiceAbility._GrantResources_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalHarvestSpiceAbility._GrantResources_d__6>.NativeClassPtr, 100675345);
				HagalHarvestSpiceAbility._GrantResources_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalHarvestSpiceAbility._GrantResources_d__6>.NativeClassPtr, 100675346);
				HagalHarvestSpiceAbility._GrantResources_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalHarvestSpiceAbility._GrantResources_d__6>.NativeClassPtr, 100675347);
			}

			// Token: 0x06009374 RID: 37748 RVA: 0x00273F94 File Offset: 0x00272194
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GrantResources_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalHarvestSpiceAbility._GrantResources_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalHarvestSpiceAbility._GrantResources_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06009375 RID: 37749 RVA: 0x00273FDC File Offset: 0x002721DC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalHarvestSpiceAbility._GrantResources_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009376 RID: 37750 RVA: 0x00274010 File Offset: 0x00272210
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200525, XrefRangeEnd = 200566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalHarvestSpiceAbility._GrantResources_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002B7E RID: 11134
			// (get) Token: 0x06009377 RID: 37751 RVA: 0x0027404C File Offset: 0x0027224C
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalHarvestSpiceAbility._GrantResources_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06009378 RID: 37752 RVA: 0x0027408C File Offset: 0x0027228C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200566, XrefRangeEnd = 200571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalHarvestSpiceAbility._GrantResources_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002B7F RID: 11135
			// (get) Token: 0x06009379 RID: 37753 RVA: 0x002740C0 File Offset: 0x002722C0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalHarvestSpiceAbility._GrantResources_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600937A RID: 37754 RVA: 0x00274100 File Offset: 0x00272300
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200571, XrefRangeEnd = 200582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalHarvestSpiceAbility._GrantResources_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600937B RID: 37755 RVA: 0x00274140 File Offset: 0x00272340
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalHarvestSpiceAbility._GrantResources_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600937C RID: 37756 RVA: 0x0004013C File Offset: 0x0003E33C
			public _GrantResources_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002B74 RID: 11124
			// (get) Token: 0x0600937D RID: 37757 RVA: 0x00274180 File Offset: 0x00272380
			// (set) Token: 0x0600937E RID: 37758 RVA: 0x00040145 File Offset: 0x0003E345
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalHarvestSpiceAbility._GrantResources_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalHarvestSpiceAbility._GrantResources_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002B75 RID: 11125
			// (get) Token: 0x0600937F RID: 37759 RVA: 0x002741A8 File Offset: 0x002723A8
			// (set) Token: 0x06009380 RID: 37760 RVA: 0x00040160 File Offset: 0x0003E360
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalHarvestSpiceAbility._GrantResources_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalHarvestSpiceAbility._GrantResources_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B76 RID: 11126
			// (get) Token: 0x06009381 RID: 37761 RVA: 0x002741D8 File Offset: 0x002723D8
			// (set) Token: 0x06009382 RID: 37762 RVA: 0x0004017F File Offset: 0x0003E37F
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalHarvestSpiceAbility._GrantResources_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalHarvestSpiceAbility._GrantResources_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002B77 RID: 11127
			// (get) Token: 0x06009383 RID: 37763 RVA: 0x00274200 File Offset: 0x00272400
			// (set) Token: 0x06009384 RID: 37764 RVA: 0x0004019A File Offset: 0x0003E39A
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalHarvestSpiceAbility._GrantResources_d__6.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalHarvestSpiceAbility._GrantResources_d__6.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B78 RID: 11128
			// (get) Token: 0x06009385 RID: 37765 RVA: 0x00274230 File Offset: 0x00272430
			// (set) Token: 0x06009386 RID: 37766 RVA: 0x000401B9 File Offset: 0x0003E3B9
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalHarvestSpiceAbility._GrantResources_d__6.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalHarvestSpiceAbility._GrantResources_d__6.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B79 RID: 11129
			// (get) Token: 0x06009387 RID: 37767 RVA: 0x00274260 File Offset: 0x00272460
			// (set) Token: 0x06009388 RID: 37768 RVA: 0x000401D8 File Offset: 0x0003E3D8
			public unsafe WormSpace space
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalHarvestSpiceAbility._GrantResources_d__6.NativeFieldInfoPtr_space);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalHarvestSpiceAbility._GrantResources_d__6.NativeFieldInfoPtr_space), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B7A RID: 11130
			// (get) Token: 0x06009389 RID: 37769 RVA: 0x00274290 File Offset: 0x00272490
			// (set) Token: 0x0600938A RID: 37770 RVA: 0x000401F7 File Offset: 0x0003E3F7
			public unsafe WormSpace __3__space
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalHarvestSpiceAbility._GrantResources_d__6.NativeFieldInfoPtr___3__space);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalHarvestSpiceAbility._GrantResources_d__6.NativeFieldInfoPtr___3__space), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B7B RID: 11131
			// (get) Token: 0x0600938B RID: 37771 RVA: 0x002742C0 File Offset: 0x002724C0
			// (set) Token: 0x0600938C RID: 37772 RVA: 0x00040216 File Offset: 0x0003E416
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalHarvestSpiceAbility._GrantResources_d__6.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalHarvestSpiceAbility._GrantResources_d__6.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B7C RID: 11132
			// (get) Token: 0x0600938D RID: 37773 RVA: 0x002742F0 File Offset: 0x002724F0
			// (set) Token: 0x0600938E RID: 37774 RVA: 0x00040235 File Offset: 0x0003E435
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalHarvestSpiceAbility._GrantResources_d__6.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalHarvestSpiceAbility._GrantResources_d__6.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B7D RID: 11133
			// (get) Token: 0x0600938F RID: 37775 RVA: 0x00274320 File Offset: 0x00272520
			// (set) Token: 0x06009390 RID: 37776 RVA: 0x00040254 File Offset: 0x0003E454
			public unsafe HagalHarvestSpiceAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalHarvestSpiceAbility._GrantResources_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HagalHarvestSpiceAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalHarvestSpiceAbility._GrantResources_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005DFA RID: 24058
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005DFB RID: 24059
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005DFC RID: 24060
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04005DFD RID: 24061
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04005DFE RID: 24062
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x04005DFF RID: 24063
			private static readonly IntPtr NativeFieldInfoPtr_space;

			// Token: 0x04005E00 RID: 24064
			private static readonly IntPtr NativeFieldInfoPtr___3__space;

			// Token: 0x04005E01 RID: 24065
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04005E02 RID: 24066
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04005E03 RID: 24067
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005E04 RID: 24068
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005E05 RID: 24069
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005E06 RID: 24070
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005E07 RID: 24071
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04005E08 RID: 24072
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005E09 RID: 24073
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005E0A RID: 24074
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04005E0B RID: 24075
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

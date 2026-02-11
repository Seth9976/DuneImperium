using System;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.events;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.abilities.TriggeredAbilities.Skirmish
{
	// Token: 0x02000343 RID: 835
	public class SignetRingAbilityCreation : RuleModAbility
	{
		// Token: 0x0600220D RID: 8717 RVA: 0x000DF56C File Offset: 0x000DD76C
		// Note: this type is marked as 'beforefieldinit'.
		static SignetRingAbilityCreation()
		{
			Il2CppClassPointerStore<SignetRingAbilityCreation>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities.Skirmish", "SignetRingAbilityCreation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SignetRingAbilityCreation>.NativeClassPtr);
			SignetRingAbilityCreation.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignetRingAbilityCreation>.NativeClassPtr, "AbilityName");
			SignetRingAbilityCreation.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignetRingAbilityCreation>.NativeClassPtr, "AbilityID");
			SignetRingAbilityCreation.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignetRingAbilityCreation>.NativeClassPtr, 100671916);
			SignetRingAbilityCreation.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignetRingAbilityCreation>.NativeClassPtr, 100671917);
			SignetRingAbilityCreation.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignetRingAbilityCreation>.NativeClassPtr, 100671918);
			SignetRingAbilityCreation.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignetRingAbilityCreation>.NativeClassPtr, 100671919);
			SignetRingAbilityCreation.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignetRingAbilityCreation>.NativeClassPtr, 100671920);
		}

		// Token: 0x0600220E RID: 8718 RVA: 0x000DF628 File Offset: 0x000DD828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179861, XrefRangeEnd = 179865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SignetRingAbilityCreation.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x0600220F RID: 8719 RVA: 0x000DF674 File Offset: 0x000DD874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179865, XrefRangeEnd = 179868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SignetRingAbilityCreation(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SignetRingAbilityCreation>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignetRingAbilityCreation.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002210 RID: 8720 RVA: 0x000DF6C0 File Offset: 0x000DD8C0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SignetRingAbilityCreation(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SignetRingAbilityCreation>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignetRingAbilityCreation.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002211 RID: 8721 RVA: 0x000DF730 File Offset: 0x000DD930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179868, XrefRangeEnd = 179875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<PlayerEntity> IsValidFor(SerializableEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SignetRingAbilityCreation.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x06002212 RID: 8722 RVA: 0x000DF78C File Offset: 0x000DD98C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179875, XrefRangeEnd = 179882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Canis.actions.Action> BeginExecution(WormActiveAbility activeAbility, WormMatch match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SignetRingAbilityCreation.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x0000DC56 File Offset: 0x0000BE56
		public SignetRingAbilityCreation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06002214 RID: 8724 RVA: 0x000DF80C File Offset: 0x000DDA0C
		// (set) Token: 0x06002215 RID: 8725 RVA: 0x0000DC5F File Offset: 0x0000BE5F
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SignetRingAbilityCreation.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SignetRingAbilityCreation.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06002216 RID: 8726 RVA: 0x000DF82C File Offset: 0x000DDA2C
		// (set) Token: 0x06002217 RID: 8727 RVA: 0x0000DC71 File Offset: 0x0000BE71
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SignetRingAbilityCreation.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SignetRingAbilityCreation.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001586 RID: 5510
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001587 RID: 5511
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001588 RID: 5512
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001589 RID: 5513
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x0400158A RID: 5514
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x0400158B RID: 5515
		private static readonly IntPtr NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0;

		// Token: 0x0400158C RID: 5516
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x02000822 RID: 2082
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Skirmish.SignetRingAbilityCreation+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x060076F2 RID: 30450 RVA: 0x0021F97C File Offset: 0x0021DB7C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<SignetRingAbilityCreation.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SignetRingAbilityCreation>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SignetRingAbilityCreation.__c__DisplayClass6_0>.NativeClassPtr);
				SignetRingAbilityCreation.__c__DisplayClass6_0.NativeFieldInfoPtr_factory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignetRingAbilityCreation.__c__DisplayClass6_0>.NativeClassPtr, "factory");
				SignetRingAbilityCreation.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignetRingAbilityCreation.__c__DisplayClass6_0>.NativeClassPtr, 100671922);
			}

			// Token: 0x060076F3 RID: 30451 RVA: 0x0021F9D0 File Offset: 0x0021DBD0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SignetRingAbilityCreation.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignetRingAbilityCreation.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060076F4 RID: 30452 RVA: 0x0003009D File Offset: 0x0002E29D
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002120 RID: 8480
			// (get) Token: 0x060076F5 RID: 30453 RVA: 0x0021FA0C File Offset: 0x0021DC0C
			// (set) Token: 0x060076F6 RID: 30454 RVA: 0x000300A6 File Offset: 0x0002E2A6
			public unsafe WormAbilityFactory factory
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation.__c__DisplayClass6_0.NativeFieldInfoPtr_factory);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAbilityFactory>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation.__c__DisplayClass6_0.NativeFieldInfoPtr_factory), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004CA1 RID: 19617
			private static readonly IntPtr NativeFieldInfoPtr_factory;

			// Token: 0x04004CA2 RID: 19618
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000823 RID: 2083
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Skirmish.SignetRingAbilityCreation+<>c__DisplayClass6_1")]
		public sealed class __c__DisplayClass6_1 : Object
		{
			// Token: 0x060076F7 RID: 30455 RVA: 0x0021FA3C File Offset: 0x0021DC3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_1()
			{
				Il2CppClassPointerStore<SignetRingAbilityCreation.__c__DisplayClass6_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SignetRingAbilityCreation>.NativeClassPtr, "<>c__DisplayClass6_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SignetRingAbilityCreation.__c__DisplayClass6_1>.NativeClassPtr);
				SignetRingAbilityCreation.__c__DisplayClass6_1.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignetRingAbilityCreation.__c__DisplayClass6_1>.NativeClassPtr, "player");
				SignetRingAbilityCreation.__c__DisplayClass6_1.NativeFieldInfoPtr_field_Public___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignetRingAbilityCreation.__c__DisplayClass6_1>.NativeClassPtr, "CS$<>8__locals1");
				SignetRingAbilityCreation.__c__DisplayClass6_1.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignetRingAbilityCreation.__c__DisplayClass6_1>.NativeClassPtr, "<>9__0");
				SignetRingAbilityCreation.__c__DisplayClass6_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignetRingAbilityCreation.__c__DisplayClass6_1>.NativeClassPtr, 100671923);
				SignetRingAbilityCreation.__c__DisplayClass6_1.NativeMethodInfoPtr__BeginExecution_b__0_Internal_Boolean_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignetRingAbilityCreation.__c__DisplayClass6_1>.NativeClassPtr, 100671924);
			}

			// Token: 0x060076F8 RID: 30456 RVA: 0x0021FACC File Offset: 0x0021DCCC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SignetRingAbilityCreation.__c__DisplayClass6_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignetRingAbilityCreation.__c__DisplayClass6_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060076F9 RID: 30457 RVA: 0x0021FB08 File Offset: 0x0021DD08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179666, XrefRangeEnd = 179677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginExecution_b__0(AbilityID _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignetRingAbilityCreation.__c__DisplayClass6_1.NativeMethodInfoPtr__BeginExecution_b__0_Internal_Boolean_AbilityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060076FA RID: 30458 RVA: 0x000300C5 File Offset: 0x0002E2C5
			public __c__DisplayClass6_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002121 RID: 8481
			// (get) Token: 0x060076FB RID: 30459 RVA: 0x0021FB58 File Offset: 0x0021DD58
			// (set) Token: 0x060076FC RID: 30460 RVA: 0x000300CE File Offset: 0x0002E2CE
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation.__c__DisplayClass6_1.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation.__c__DisplayClass6_1.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002122 RID: 8482
			// (get) Token: 0x060076FD RID: 30461 RVA: 0x0021FB88 File Offset: 0x0021DD88
			// (set) Token: 0x060076FE RID: 30462 RVA: 0x000300ED File Offset: 0x0002E2ED
			public unsafe SignetRingAbilityCreation.__c__DisplayClass6_0 field_Public___c__DisplayClass6_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation.__c__DisplayClass6_1.NativeFieldInfoPtr_field_Public___c__DisplayClass6_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SignetRingAbilityCreation.__c__DisplayClass6_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation.__c__DisplayClass6_1.NativeFieldInfoPtr_field_Public___c__DisplayClass6_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002123 RID: 8483
			// (get) Token: 0x060076FF RID: 30463 RVA: 0x0021FBB8 File Offset: 0x0021DDB8
			// (set) Token: 0x06007700 RID: 30464 RVA: 0x0003010C File Offset: 0x0002E30C
			public unsafe Func<AbilityID, bool> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation.__c__DisplayClass6_1.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AbilityID, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation.__c__DisplayClass6_1.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004CA3 RID: 19619
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04004CA4 RID: 19620
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass6_0_0;

			// Token: 0x04004CA5 RID: 19621
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04004CA6 RID: 19622
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004CA7 RID: 19623
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__0_Internal_Boolean_AbilityID_0;
		}

		// Token: 0x02000824 RID: 2084
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Skirmish.SignetRingAbilityCreation+<>c__DisplayClass6_2")]
		public sealed class __c__DisplayClass6_2 : Object
		{
			// Token: 0x06007701 RID: 30465 RVA: 0x0021FBE8 File Offset: 0x0021DDE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_2()
			{
				Il2CppClassPointerStore<SignetRingAbilityCreation.__c__DisplayClass6_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SignetRingAbilityCreation>.NativeClassPtr, "<>c__DisplayClass6_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SignetRingAbilityCreation.__c__DisplayClass6_2>.NativeClassPtr);
				SignetRingAbilityCreation.__c__DisplayClass6_2.NativeFieldInfoPtr__ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignetRingAbilityCreation.__c__DisplayClass6_2>.NativeClassPtr, "_");
				SignetRingAbilityCreation.__c__DisplayClass6_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignetRingAbilityCreation.__c__DisplayClass6_2>.NativeClassPtr, 100671925);
				SignetRingAbilityCreation.__c__DisplayClass6_2.NativeMethodInfoPtr__BeginExecution_b__1_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignetRingAbilityCreation.__c__DisplayClass6_2>.NativeClassPtr, 100671926);
			}

			// Token: 0x06007702 RID: 30466 RVA: 0x0021FC50 File Offset: 0x0021DE50
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_2()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SignetRingAbilityCreation.__c__DisplayClass6_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignetRingAbilityCreation.__c__DisplayClass6_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007703 RID: 30467 RVA: 0x0021FC8C File Offset: 0x0021DE8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179677, XrefRangeEnd = 179682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginExecution_b__1(WormAbilityDefinition ab)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ab);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignetRingAbilityCreation.__c__DisplayClass6_2.NativeMethodInfoPtr__BeginExecution_b__1_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06007704 RID: 30468 RVA: 0x0003012B File Offset: 0x0002E32B
			public __c__DisplayClass6_2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002124 RID: 8484
			// (get) Token: 0x06007705 RID: 30469 RVA: 0x0021FCDC File Offset: 0x0021DEDC
			// (set) Token: 0x06007706 RID: 30470 RVA: 0x00030134 File Offset: 0x0002E334
			public unsafe AbilityID _
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation.__c__DisplayClass6_2.NativeFieldInfoPtr__);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation.__c__DisplayClass6_2.NativeFieldInfoPtr__), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004CA8 RID: 19624
			private static readonly IntPtr NativeFieldInfoPtr__;

			// Token: 0x04004CA9 RID: 19625
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004CAA RID: 19626
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__1_Internal_Boolean_WormAbilityDefinition_0;
		}

		// Token: 0x02000825 RID: 2085
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Skirmish.SignetRingAbilityCreation+<BeginExecution>d__6")]
		public sealed class _BeginExecution_d__6 : Object
		{
			// Token: 0x06007707 RID: 30471 RVA: 0x0021FD0C File Offset: 0x0021DF0C
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__6()
			{
				Il2CppClassPointerStore<SignetRingAbilityCreation._BeginExecution_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SignetRingAbilityCreation>.NativeClassPtr, "<BeginExecution>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SignetRingAbilityCreation._BeginExecution_d__6>.NativeClassPtr);
				SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignetRingAbilityCreation._BeginExecution_d__6>.NativeClassPtr, "<>1__state");
				SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignetRingAbilityCreation._BeginExecution_d__6>.NativeClassPtr, "<>2__current");
				SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignetRingAbilityCreation._BeginExecution_d__6>.NativeClassPtr, "<>l__initialThreadId");
				SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignetRingAbilityCreation._BeginExecution_d__6>.NativeClassPtr, "match");
				SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignetRingAbilityCreation._BeginExecution_d__6>.NativeClassPtr, "<>3__match");
				SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignetRingAbilityCreation._BeginExecution_d__6>.NativeClassPtr, "<>8__1");
				SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr___8__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignetRingAbilityCreation._BeginExecution_d__6>.NativeClassPtr, "<>8__2");
				SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignetRingAbilityCreation._BeginExecution_d__6>.NativeClassPtr, "activeAbility");
				SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignetRingAbilityCreation._BeginExecution_d__6>.NativeClassPtr, "<>3__activeAbility");
				SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr__allSignetAbilities_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignetRingAbilityCreation._BeginExecution_d__6>.NativeClassPtr, "<allSignetAbilities>5__2");
				SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignetRingAbilityCreation._BeginExecution_d__6>.NativeClassPtr, "<>7__wrap2");
				SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignetRingAbilityCreation._BeginExecution_d__6>.NativeClassPtr, "<>7__wrap3");
				SignetRingAbilityCreation._BeginExecution_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignetRingAbilityCreation._BeginExecution_d__6>.NativeClassPtr, 100671927);
				SignetRingAbilityCreation._BeginExecution_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignetRingAbilityCreation._BeginExecution_d__6>.NativeClassPtr, 100671928);
				SignetRingAbilityCreation._BeginExecution_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignetRingAbilityCreation._BeginExecution_d__6>.NativeClassPtr, 100671929);
				SignetRingAbilityCreation._BeginExecution_d__6.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignetRingAbilityCreation._BeginExecution_d__6>.NativeClassPtr, 100671930);
				SignetRingAbilityCreation._BeginExecution_d__6.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignetRingAbilityCreation._BeginExecution_d__6>.NativeClassPtr, 100671931);
				SignetRingAbilityCreation._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignetRingAbilityCreation._BeginExecution_d__6>.NativeClassPtr, 100671932);
				SignetRingAbilityCreation._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignetRingAbilityCreation._BeginExecution_d__6>.NativeClassPtr, 100671933);
				SignetRingAbilityCreation._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignetRingAbilityCreation._BeginExecution_d__6>.NativeClassPtr, 100671934);
				SignetRingAbilityCreation._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignetRingAbilityCreation._BeginExecution_d__6>.NativeClassPtr, 100671935);
				SignetRingAbilityCreation._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignetRingAbilityCreation._BeginExecution_d__6>.NativeClassPtr, 100671936);
			}

			// Token: 0x06007708 RID: 30472 RVA: 0x0021FEF0 File Offset: 0x0021E0F0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SignetRingAbilityCreation._BeginExecution_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignetRingAbilityCreation._BeginExecution_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06007709 RID: 30473 RVA: 0x0021FF38 File Offset: 0x0021E138
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179682, XrefRangeEnd = 179695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignetRingAbilityCreation._BeginExecution_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600770A RID: 30474 RVA: 0x0021FF6C File Offset: 0x0021E16C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179695, XrefRangeEnd = 179820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignetRingAbilityCreation._BeginExecution_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600770B RID: 30475 RVA: 0x0021FFA8 File Offset: 0x0021E1A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179820, XrefRangeEnd = 179823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignetRingAbilityCreation._BeginExecution_d__6.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600770C RID: 30476 RVA: 0x0021FFDC File Offset: 0x0021E1DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179823, XrefRangeEnd = 179826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignetRingAbilityCreation._BeginExecution_d__6.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002131 RID: 8497
			// (get) Token: 0x0600770D RID: 30477 RVA: 0x00220010 File Offset: 0x0021E210
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignetRingAbilityCreation._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600770E RID: 30478 RVA: 0x00220050 File Offset: 0x0021E250
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179826, XrefRangeEnd = 179831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignetRingAbilityCreation._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002132 RID: 8498
			// (get) Token: 0x0600770F RID: 30479 RVA: 0x00220084 File Offset: 0x0021E284
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignetRingAbilityCreation._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007710 RID: 30480 RVA: 0x002200C4 File Offset: 0x0021E2C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179831, XrefRangeEnd = 179840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignetRingAbilityCreation._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06007711 RID: 30481 RVA: 0x00220104 File Offset: 0x0021E304
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignetRingAbilityCreation._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06007712 RID: 30482 RVA: 0x00030153 File Offset: 0x0002E353
			public _BeginExecution_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002125 RID: 8485
			// (get) Token: 0x06007713 RID: 30483 RVA: 0x00220144 File Offset: 0x0021E344
			// (set) Token: 0x06007714 RID: 30484 RVA: 0x0003015C File Offset: 0x0002E35C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002126 RID: 8486
			// (get) Token: 0x06007715 RID: 30485 RVA: 0x0022016C File Offset: 0x0021E36C
			// (set) Token: 0x06007716 RID: 30486 RVA: 0x00030177 File Offset: 0x0002E377
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002127 RID: 8487
			// (get) Token: 0x06007717 RID: 30487 RVA: 0x0022019C File Offset: 0x0021E39C
			// (set) Token: 0x06007718 RID: 30488 RVA: 0x00030196 File Offset: 0x0002E396
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002128 RID: 8488
			// (get) Token: 0x06007719 RID: 30489 RVA: 0x002201C4 File Offset: 0x0021E3C4
			// (set) Token: 0x0600771A RID: 30490 RVA: 0x000301B1 File Offset: 0x0002E3B1
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002129 RID: 8489
			// (get) Token: 0x0600771B RID: 30491 RVA: 0x002201F4 File Offset: 0x0021E3F4
			// (set) Token: 0x0600771C RID: 30492 RVA: 0x000301D0 File Offset: 0x0002E3D0
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700212A RID: 8490
			// (get) Token: 0x0600771D RID: 30493 RVA: 0x00220224 File Offset: 0x0021E424
			// (set) Token: 0x0600771E RID: 30494 RVA: 0x000301EF File Offset: 0x0002E3EF
			public unsafe SignetRingAbilityCreation.__c__DisplayClass6_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SignetRingAbilityCreation.__c__DisplayClass6_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700212B RID: 8491
			// (get) Token: 0x0600771F RID: 30495 RVA: 0x00220254 File Offset: 0x0021E454
			// (set) Token: 0x06007720 RID: 30496 RVA: 0x0003020E File Offset: 0x0002E40E
			public unsafe SignetRingAbilityCreation.__c__DisplayClass6_1 __8__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr___8__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SignetRingAbilityCreation.__c__DisplayClass6_1>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr___8__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700212C RID: 8492
			// (get) Token: 0x06007721 RID: 30497 RVA: 0x00220284 File Offset: 0x0021E484
			// (set) Token: 0x06007722 RID: 30498 RVA: 0x0003022D File Offset: 0x0002E42D
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700212D RID: 8493
			// (get) Token: 0x06007723 RID: 30499 RVA: 0x002202B4 File Offset: 0x0021E4B4
			// (set) Token: 0x06007724 RID: 30500 RVA: 0x0003024C File Offset: 0x0002E44C
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700212E RID: 8494
			// (get) Token: 0x06007725 RID: 30501 RVA: 0x002202E4 File Offset: 0x0021E4E4
			// (set) Token: 0x06007726 RID: 30502 RVA: 0x0003026B File Offset: 0x0002E46B
			public unsafe List<AbilityID> _allSignetAbilities_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr__allSignetAbilities_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AbilityID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr__allSignetAbilities_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700212F RID: 8495
			// (get) Token: 0x06007727 RID: 30503 RVA: 0x00220314 File Offset: 0x0021E514
			// (set) Token: 0x06007728 RID: 30504 RVA: 0x0003028A File Offset: 0x0002E48A
			public List<WormPlayer>.Enumerator __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr___7__wrap2);
					return new List<WormPlayer>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<WormPlayer>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr___7__wrap2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<WormPlayer>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002130 RID: 8496
			// (get) Token: 0x06007729 RID: 30505 RVA: 0x00220344 File Offset: 0x0021E544
			// (set) Token: 0x0600772A RID: 30506 RVA: 0x000302B8 File Offset: 0x0002E4B8
			public unsafe IEnumerator<AbilityID> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<AbilityID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._BeginExecution_d__6.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004CAB RID: 19627
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004CAC RID: 19628
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004CAD RID: 19629
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004CAE RID: 19630
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04004CAF RID: 19631
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04004CB0 RID: 19632
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04004CB1 RID: 19633
			private static readonly IntPtr NativeFieldInfoPtr___8__2;

			// Token: 0x04004CB2 RID: 19634
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04004CB3 RID: 19635
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04004CB4 RID: 19636
			private static readonly IntPtr NativeFieldInfoPtr__allSignetAbilities_5__2;

			// Token: 0x04004CB5 RID: 19637
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04004CB6 RID: 19638
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x04004CB7 RID: 19639
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004CB8 RID: 19640
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004CB9 RID: 19641
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004CBA RID: 19642
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04004CBB RID: 19643
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04004CBC RID: 19644
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004CBD RID: 19645
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004CBE RID: 19646
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004CBF RID: 19647
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004CC0 RID: 19648
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000826 RID: 2086
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Skirmish.SignetRingAbilityCreation+<IsValidFor>d__5")]
		public sealed class _IsValidFor_d__5 : Object
		{
			// Token: 0x0600772B RID: 30507 RVA: 0x00220374 File Offset: 0x0021E574
			// Note: this type is marked as 'beforefieldinit'.
			static _IsValidFor_d__5()
			{
				Il2CppClassPointerStore<SignetRingAbilityCreation._IsValidFor_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SignetRingAbilityCreation>.NativeClassPtr, "<IsValidFor>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SignetRingAbilityCreation._IsValidFor_d__5>.NativeClassPtr);
				SignetRingAbilityCreation._IsValidFor_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignetRingAbilityCreation._IsValidFor_d__5>.NativeClassPtr, "<>1__state");
				SignetRingAbilityCreation._IsValidFor_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignetRingAbilityCreation._IsValidFor_d__5>.NativeClassPtr, "<>2__current");
				SignetRingAbilityCreation._IsValidFor_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignetRingAbilityCreation._IsValidFor_d__5>.NativeClassPtr, "<>l__initialThreadId");
				SignetRingAbilityCreation._IsValidFor_d__5.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignetRingAbilityCreation._IsValidFor_d__5>.NativeClassPtr, "evt");
				SignetRingAbilityCreation._IsValidFor_d__5.NativeFieldInfoPtr___3__evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignetRingAbilityCreation._IsValidFor_d__5>.NativeClassPtr, "<>3__evt");
				SignetRingAbilityCreation._IsValidFor_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignetRingAbilityCreation._IsValidFor_d__5>.NativeClassPtr, "<>4__this");
				SignetRingAbilityCreation._IsValidFor_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignetRingAbilityCreation._IsValidFor_d__5>.NativeClassPtr, 100671937);
				SignetRingAbilityCreation._IsValidFor_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignetRingAbilityCreation._IsValidFor_d__5>.NativeClassPtr, 100671938);
				SignetRingAbilityCreation._IsValidFor_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignetRingAbilityCreation._IsValidFor_d__5>.NativeClassPtr, 100671939);
				SignetRingAbilityCreation._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignetRingAbilityCreation._IsValidFor_d__5>.NativeClassPtr, 100671940);
				SignetRingAbilityCreation._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignetRingAbilityCreation._IsValidFor_d__5>.NativeClassPtr, 100671941);
				SignetRingAbilityCreation._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignetRingAbilityCreation._IsValidFor_d__5>.NativeClassPtr, 100671942);
				SignetRingAbilityCreation._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignetRingAbilityCreation._IsValidFor_d__5>.NativeClassPtr, 100671943);
				SignetRingAbilityCreation._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignetRingAbilityCreation._IsValidFor_d__5>.NativeClassPtr, 100671944);
			}

			// Token: 0x0600772C RID: 30508 RVA: 0x002204B8 File Offset: 0x0021E6B8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _IsValidFor_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SignetRingAbilityCreation._IsValidFor_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignetRingAbilityCreation._IsValidFor_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600772D RID: 30509 RVA: 0x00220500 File Offset: 0x0021E700
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignetRingAbilityCreation._IsValidFor_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600772E RID: 30510 RVA: 0x00220534 File Offset: 0x0021E734
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179840, XrefRangeEnd = 179847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignetRingAbilityCreation._IsValidFor_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002139 RID: 8505
			// (get) Token: 0x0600772F RID: 30511 RVA: 0x00220570 File Offset: 0x0021E770
			public unsafe PlayerEntity System.Collections.Generic.IEnumerator<Canis.entities.PlayerEntity>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignetRingAbilityCreation._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
				}
			}

			// Token: 0x06007730 RID: 30512 RVA: 0x002205B0 File Offset: 0x0021E7B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179847, XrefRangeEnd = 179852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignetRingAbilityCreation._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700213A RID: 8506
			// (get) Token: 0x06007731 RID: 30513 RVA: 0x002205E4 File Offset: 0x0021E7E4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignetRingAbilityCreation._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007732 RID: 30514 RVA: 0x00220624 File Offset: 0x0021E824
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179852, XrefRangeEnd = 179861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<PlayerEntity> System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignetRingAbilityCreation._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<PlayerEntity>>(intPtr3) : null;
			}

			// Token: 0x06007733 RID: 30515 RVA: 0x00220664 File Offset: 0x0021E864
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignetRingAbilityCreation._IsValidFor_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06007734 RID: 30516 RVA: 0x000302D7 File Offset: 0x0002E4D7
			public _IsValidFor_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002133 RID: 8499
			// (get) Token: 0x06007735 RID: 30517 RVA: 0x002206A4 File Offset: 0x0021E8A4
			// (set) Token: 0x06007736 RID: 30518 RVA: 0x000302E0 File Offset: 0x0002E4E0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._IsValidFor_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._IsValidFor_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002134 RID: 8500
			// (get) Token: 0x06007737 RID: 30519 RVA: 0x002206CC File Offset: 0x0021E8CC
			// (set) Token: 0x06007738 RID: 30520 RVA: 0x000302FB File Offset: 0x0002E4FB
			public unsafe PlayerEntity __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._IsValidFor_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._IsValidFor_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002135 RID: 8501
			// (get) Token: 0x06007739 RID: 30521 RVA: 0x002206FC File Offset: 0x0021E8FC
			// (set) Token: 0x0600773A RID: 30522 RVA: 0x0003031A File Offset: 0x0002E51A
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._IsValidFor_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._IsValidFor_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002136 RID: 8502
			// (get) Token: 0x0600773B RID: 30523 RVA: 0x00220724 File Offset: 0x0021E924
			// (set) Token: 0x0600773C RID: 30524 RVA: 0x00030335 File Offset: 0x0002E535
			public unsafe SerializableEvent evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._IsValidFor_d__5.NativeFieldInfoPtr_evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._IsValidFor_d__5.NativeFieldInfoPtr_evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002137 RID: 8503
			// (get) Token: 0x0600773D RID: 30525 RVA: 0x00220754 File Offset: 0x0021E954
			// (set) Token: 0x0600773E RID: 30526 RVA: 0x00030354 File Offset: 0x0002E554
			public unsafe SerializableEvent __3__evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._IsValidFor_d__5.NativeFieldInfoPtr___3__evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._IsValidFor_d__5.NativeFieldInfoPtr___3__evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002138 RID: 8504
			// (get) Token: 0x0600773F RID: 30527 RVA: 0x00220784 File Offset: 0x0021E984
			// (set) Token: 0x06007740 RID: 30528 RVA: 0x00030373 File Offset: 0x0002E573
			public unsafe SignetRingAbilityCreation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._IsValidFor_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SignetRingAbilityCreation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignetRingAbilityCreation._IsValidFor_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004CC1 RID: 19649
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004CC2 RID: 19650
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004CC3 RID: 19651
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004CC4 RID: 19652
			private static readonly IntPtr NativeFieldInfoPtr_evt;

			// Token: 0x04004CC5 RID: 19653
			private static readonly IntPtr NativeFieldInfoPtr___3__evt;

			// Token: 0x04004CC6 RID: 19654
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004CC7 RID: 19655
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004CC8 RID: 19656
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004CC9 RID: 19657
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004CCA RID: 19658
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0;

			// Token: 0x04004CCB RID: 19659
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004CCC RID: 19660
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004CCD RID: 19661
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0;

			// Token: 0x04004CCE RID: 19662
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

using System;
using Canis;
using Canis.actions;
using canis.archetypes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.abilities;
using worm.canis.data.enums;
using worm.canis.entities;

namespace worm.canis.actions.phases
{
	// Token: 0x020002C8 RID: 712
	public class HagalSetupPhase : SetupPhase
	{
		// Token: 0x06001D50 RID: 7504 RVA: 0x000CB120 File Offset: 0x000C9320
		// Note: this type is marked as 'beforefieldinit'.
		static HagalSetupPhase()
		{
			Il2CppClassPointerStore<HagalSetupPhase>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.phases", "HagalSetupPhase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalSetupPhase>.NativeClassPtr);
			HagalSetupPhase.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase>.NativeClassPtr, 100669628);
			HagalSetupPhase.NativeMethodInfoPtr__ctor_Public_Void_SerializedHagalSetupPhase_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase>.NativeClassPtr, 100669629);
			HagalSetupPhase.NativeMethodInfoPtr_BeginSetupExtra_Protected_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase>.NativeClassPtr, 100669630);
			HagalSetupPhase.NativeMethodInfoPtr_CreateDecksExtra_Protected_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase>.NativeClassPtr, 100669631);
			HagalSetupPhase.NativeMethodInfoPtr_CompleteSetupExtra_Protected_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase>.NativeClassPtr, 100669632);
			HagalSetupPhase.NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase>.NativeClassPtr, 100669633);
		}

		// Token: 0x06001D51 RID: 7505 RVA: 0x000CB1C8 File Offset: 0x000C93C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158391, XrefRangeEnd = 158392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalSetupPhase(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalSetupPhase>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D52 RID: 7506 RVA: 0x000CB214 File Offset: 0x000C9414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158392, XrefRangeEnd = 158393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalSetupPhase(SerializedHagalSetupPhase serialized, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalSetupPhase>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase.NativeMethodInfoPtr__ctor_Public_Void_SerializedHagalSetupPhase_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D53 RID: 7507 RVA: 0x000CB274 File Offset: 0x000C9474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158393, XrefRangeEnd = 158399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> BeginSetupExtra()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalSetupPhase.NativeMethodInfoPtr_BeginSetupExtra_Protected_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x000CB2C0 File Offset: 0x000C94C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158399, XrefRangeEnd = 158405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> CreateDecksExtra()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalSetupPhase.NativeMethodInfoPtr_CreateDecksExtra_Protected_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x000CB30C File Offset: 0x000C950C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158405, XrefRangeEnd = 158411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> CompleteSetupExtra()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalSetupPhase.NativeMethodInfoPtr_CompleteSetupExtra_Protected_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001D56 RID: 7510 RVA: 0x000CB358 File Offset: 0x000C9558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158411, XrefRangeEnd = 158439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedStateMachineAction MakeSerializedStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalSetupPhase.NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedStateMachineAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001D57 RID: 7511 RVA: 0x0000C5AE File Offset: 0x0000A7AE
		public HagalSetupPhase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001243 RID: 4675
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04001244 RID: 4676
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedHagalSetupPhase_WormMatch_0;

		// Token: 0x04001245 RID: 4677
		private static readonly IntPtr NativeMethodInfoPtr_BeginSetupExtra_Protected_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04001246 RID: 4678
		private static readonly IntPtr NativeMethodInfoPtr_CreateDecksExtra_Protected_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04001247 RID: 4679
		private static readonly IntPtr NativeMethodInfoPtr_CompleteSetupExtra_Protected_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04001248 RID: 4680
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0;

		// Token: 0x02000735 RID: 1845
		[ObfuscatedName("worm.canis.actions.phases.HagalSetupPhase+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600658C RID: 25996 RVA: 0x001E94FC File Offset: 0x001E76FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<HagalSetupPhase.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HagalSetupPhase>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalSetupPhase.__c>.NativeClassPtr);
				HagalSetupPhase.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSetupPhase.__c>.NativeClassPtr, "<>9");
				HagalSetupPhase.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSetupPhase.__c>.NativeClassPtr, "<>9__2_0");
				HagalSetupPhase.__c.NativeFieldInfoPtr___9__2_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSetupPhase.__c>.NativeClassPtr, "<>9__2_3");
				HagalSetupPhase.__c.NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSetupPhase.__c>.NativeClassPtr, "<>9__2_1");
				HagalSetupPhase.__c.NativeFieldInfoPtr___9__2_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSetupPhase.__c>.NativeClassPtr, "<>9__2_4");
				HagalSetupPhase.__c.NativeFieldInfoPtr___9__2_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSetupPhase.__c>.NativeClassPtr, "<>9__2_5");
				HagalSetupPhase.__c.NativeFieldInfoPtr___9__2_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSetupPhase.__c>.NativeClassPtr, "<>9__2_6");
				HagalSetupPhase.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSetupPhase.__c>.NativeClassPtr, "<>9__3_1");
				HagalSetupPhase.__c.NativeFieldInfoPtr___9__3_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSetupPhase.__c>.NativeClassPtr, "<>9__3_2");
				HagalSetupPhase.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSetupPhase.__c>.NativeClassPtr, "<>9__4_0");
				HagalSetupPhase.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSetupPhase.__c>.NativeClassPtr, "<>9__4_1");
				HagalSetupPhase.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase.__c>.NativeClassPtr, 100669635);
				HagalSetupPhase.__c.NativeMethodInfoPtr__BeginSetupExtra_b__2_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase.__c>.NativeClassPtr, 100669636);
				HagalSetupPhase.__c.NativeMethodInfoPtr__BeginSetupExtra_b__2_3_Internal_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase.__c>.NativeClassPtr, 100669637);
				HagalSetupPhase.__c.NativeMethodInfoPtr__BeginSetupExtra_b__2_1_Internal_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase.__c>.NativeClassPtr, 100669638);
				HagalSetupPhase.__c.NativeMethodInfoPtr__BeginSetupExtra_b__2_4_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase.__c>.NativeClassPtr, 100669639);
				HagalSetupPhase.__c.NativeMethodInfoPtr__BeginSetupExtra_b__2_5_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase.__c>.NativeClassPtr, 100669640);
				HagalSetupPhase.__c.NativeMethodInfoPtr__BeginSetupExtra_b__2_6_Internal_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase.__c>.NativeClassPtr, 100669641);
				HagalSetupPhase.__c.NativeMethodInfoPtr__CreateDecksExtra_b__3_1_Internal_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase.__c>.NativeClassPtr, 100669642);
				HagalSetupPhase.__c.NativeMethodInfoPtr__CreateDecksExtra_b__3_2_Internal_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase.__c>.NativeClassPtr, 100669643);
				HagalSetupPhase.__c.NativeMethodInfoPtr__CompleteSetupExtra_b__4_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase.__c>.NativeClassPtr, 100669644);
				HagalSetupPhase.__c.NativeMethodInfoPtr__CompleteSetupExtra_b__4_1_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase.__c>.NativeClassPtr, 100669645);
			}

			// Token: 0x0600658D RID: 25997 RVA: 0x001E96E0 File Offset: 0x001E78E0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalSetupPhase.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600658E RID: 25998 RVA: 0x001E971C File Offset: 0x001E791C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginSetupExtra_b__2_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase.__c.NativeMethodInfoPtr__BeginSetupExtra_b__2_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600658F RID: 25999 RVA: 0x001E976C File Offset: 0x001E796C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157937, XrefRangeEnd = 157946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginSetupExtra_b__2_3(WormSpace _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase.__c.NativeMethodInfoPtr__BeginSetupExtra_b__2_3_Internal_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006590 RID: 26000 RVA: 0x001E97BC File Offset: 0x001E79BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157946, XrefRangeEnd = 157955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginSetupExtra_b__2_1(WormSpace _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase.__c.NativeMethodInfoPtr__BeginSetupExtra_b__2_1_Internal_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006591 RID: 26001 RVA: 0x001E980C File Offset: 0x001E7A0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginSetupExtra_b__2_4(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase.__c.NativeMethodInfoPtr__BeginSetupExtra_b__2_4_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006592 RID: 26002 RVA: 0x001E985C File Offset: 0x001E7A5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginSetupExtra_b__2_5(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase.__c.NativeMethodInfoPtr__BeginSetupExtra_b__2_5_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006593 RID: 26003 RVA: 0x001E98AC File Offset: 0x001E7AAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157955, XrefRangeEnd = 157964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginSetupExtra_b__2_6(WormSpace _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase.__c.NativeMethodInfoPtr__BeginSetupExtra_b__2_6_Internal_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006594 RID: 26004 RVA: 0x001E98FC File Offset: 0x001E7AFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157964, XrefRangeEnd = 157973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreateDecksExtra_b__3_1(Archetype _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase.__c.NativeMethodInfoPtr__CreateDecksExtra_b__3_1_Internal_Boolean_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006595 RID: 26005 RVA: 0x001E994C File Offset: 0x001E7B4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157973, XrefRangeEnd = 157982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreateDecksExtra_b__3_2(Archetype _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase.__c.NativeMethodInfoPtr__CreateDecksExtra_b__3_2_Internal_Boolean_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006596 RID: 26006 RVA: 0x001E999C File Offset: 0x001E7B9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CompleteSetupExtra_b__4_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase.__c.NativeMethodInfoPtr__CompleteSetupExtra_b__4_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006597 RID: 26007 RVA: 0x001E99EC File Offset: 0x001E7BEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157982, XrefRangeEnd = 157983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CompleteSetupExtra_b__4_1(WormAbilityDefinition _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase.__c.NativeMethodInfoPtr__CompleteSetupExtra_b__4_1_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006598 RID: 26008 RVA: 0x000277A8 File Offset: 0x000259A8
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B47 RID: 6983
			// (get) Token: 0x06006599 RID: 26009 RVA: 0x001E9A3C File Offset: 0x001E7C3C
			// (set) Token: 0x0600659A RID: 26010 RVA: 0x000277B1 File Offset: 0x000259B1
			public unsafe static HagalSetupPhase.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalSetupPhase.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HagalSetupPhase.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalSetupPhase.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B48 RID: 6984
			// (get) Token: 0x0600659B RID: 26011 RVA: 0x001E9A64 File Offset: 0x001E7C64
			// (set) Token: 0x0600659C RID: 26012 RVA: 0x000277C3 File Offset: 0x000259C3
			public unsafe static Func<WormPlayer, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalSetupPhase.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalSetupPhase.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B49 RID: 6985
			// (get) Token: 0x0600659D RID: 26013 RVA: 0x001E9A8C File Offset: 0x001E7C8C
			// (set) Token: 0x0600659E RID: 26014 RVA: 0x000277D5 File Offset: 0x000259D5
			public unsafe static Func<WormSpace, bool> __9__2_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalSetupPhase.__c.NativeFieldInfoPtr___9__2_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormSpace, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalSetupPhase.__c.NativeFieldInfoPtr___9__2_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B4A RID: 6986
			// (get) Token: 0x0600659F RID: 26015 RVA: 0x001E9AB4 File Offset: 0x001E7CB4
			// (set) Token: 0x060065A0 RID: 26016 RVA: 0x000277E7 File Offset: 0x000259E7
			public unsafe static Func<WormSpace, bool> __9__2_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalSetupPhase.__c.NativeFieldInfoPtr___9__2_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormSpace, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalSetupPhase.__c.NativeFieldInfoPtr___9__2_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B4B RID: 6987
			// (get) Token: 0x060065A1 RID: 26017 RVA: 0x001E9ADC File Offset: 0x001E7CDC
			// (set) Token: 0x060065A2 RID: 26018 RVA: 0x000277F9 File Offset: 0x000259F9
			public unsafe static Func<WormPlayer, bool> __9__2_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalSetupPhase.__c.NativeFieldInfoPtr___9__2_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalSetupPhase.__c.NativeFieldInfoPtr___9__2_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B4C RID: 6988
			// (get) Token: 0x060065A3 RID: 26019 RVA: 0x001E9B04 File Offset: 0x001E7D04
			// (set) Token: 0x060065A4 RID: 26020 RVA: 0x0002780B File Offset: 0x00025A0B
			public unsafe static Func<WormPlayer, bool> __9__2_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalSetupPhase.__c.NativeFieldInfoPtr___9__2_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalSetupPhase.__c.NativeFieldInfoPtr___9__2_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B4D RID: 6989
			// (get) Token: 0x060065A5 RID: 26021 RVA: 0x001E9B2C File Offset: 0x001E7D2C
			// (set) Token: 0x060065A6 RID: 26022 RVA: 0x0002781D File Offset: 0x00025A1D
			public unsafe static Func<WormSpace, bool> __9__2_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalSetupPhase.__c.NativeFieldInfoPtr___9__2_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormSpace, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalSetupPhase.__c.NativeFieldInfoPtr___9__2_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B4E RID: 6990
			// (get) Token: 0x060065A7 RID: 26023 RVA: 0x001E9B54 File Offset: 0x001E7D54
			// (set) Token: 0x060065A8 RID: 26024 RVA: 0x0002782F File Offset: 0x00025A2F
			public unsafe static Predicate<Archetype> __9__3_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalSetupPhase.__c.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Archetype>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalSetupPhase.__c.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B4F RID: 6991
			// (get) Token: 0x060065A9 RID: 26025 RVA: 0x001E9B7C File Offset: 0x001E7D7C
			// (set) Token: 0x060065AA RID: 26026 RVA: 0x00027841 File Offset: 0x00025A41
			public unsafe static Predicate<Archetype> __9__3_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalSetupPhase.__c.NativeFieldInfoPtr___9__3_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Archetype>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalSetupPhase.__c.NativeFieldInfoPtr___9__3_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B50 RID: 6992
			// (get) Token: 0x060065AB RID: 26027 RVA: 0x001E9BA4 File Offset: 0x001E7DA4
			// (set) Token: 0x060065AC RID: 26028 RVA: 0x00027853 File Offset: 0x00025A53
			public unsafe static Func<WormPlayer, bool> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalSetupPhase.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalSetupPhase.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B51 RID: 6993
			// (get) Token: 0x060065AD RID: 26029 RVA: 0x001E9BCC File Offset: 0x001E7DCC
			// (set) Token: 0x060065AE RID: 26030 RVA: 0x00027865 File Offset: 0x00025A65
			public unsafe static Func<WormAbilityDefinition, bool> __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalSetupPhase.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAbilityDefinition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalSetupPhase.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040041B6 RID: 16822
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040041B7 RID: 16823
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x040041B8 RID: 16824
			private static readonly IntPtr NativeFieldInfoPtr___9__2_3;

			// Token: 0x040041B9 RID: 16825
			private static readonly IntPtr NativeFieldInfoPtr___9__2_1;

			// Token: 0x040041BA RID: 16826
			private static readonly IntPtr NativeFieldInfoPtr___9__2_4;

			// Token: 0x040041BB RID: 16827
			private static readonly IntPtr NativeFieldInfoPtr___9__2_5;

			// Token: 0x040041BC RID: 16828
			private static readonly IntPtr NativeFieldInfoPtr___9__2_6;

			// Token: 0x040041BD RID: 16829
			private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

			// Token: 0x040041BE RID: 16830
			private static readonly IntPtr NativeFieldInfoPtr___9__3_2;

			// Token: 0x040041BF RID: 16831
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x040041C0 RID: 16832
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x040041C1 RID: 16833
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040041C2 RID: 16834
			private static readonly IntPtr NativeMethodInfoPtr__BeginSetupExtra_b__2_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x040041C3 RID: 16835
			private static readonly IntPtr NativeMethodInfoPtr__BeginSetupExtra_b__2_3_Internal_Boolean_WormSpace_0;

			// Token: 0x040041C4 RID: 16836
			private static readonly IntPtr NativeMethodInfoPtr__BeginSetupExtra_b__2_1_Internal_Boolean_WormSpace_0;

			// Token: 0x040041C5 RID: 16837
			private static readonly IntPtr NativeMethodInfoPtr__BeginSetupExtra_b__2_4_Internal_Boolean_WormPlayer_0;

			// Token: 0x040041C6 RID: 16838
			private static readonly IntPtr NativeMethodInfoPtr__BeginSetupExtra_b__2_5_Internal_Boolean_WormPlayer_0;

			// Token: 0x040041C7 RID: 16839
			private static readonly IntPtr NativeMethodInfoPtr__BeginSetupExtra_b__2_6_Internal_Boolean_WormSpace_0;

			// Token: 0x040041C8 RID: 16840
			private static readonly IntPtr NativeMethodInfoPtr__CreateDecksExtra_b__3_1_Internal_Boolean_Archetype_0;

			// Token: 0x040041C9 RID: 16841
			private static readonly IntPtr NativeMethodInfoPtr__CreateDecksExtra_b__3_2_Internal_Boolean_Archetype_0;

			// Token: 0x040041CA RID: 16842
			private static readonly IntPtr NativeMethodInfoPtr__CompleteSetupExtra_b__4_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x040041CB RID: 16843
			private static readonly IntPtr NativeMethodInfoPtr__CompleteSetupExtra_b__4_1_Internal_Boolean_WormAbilityDefinition_0;
		}

		// Token: 0x02000736 RID: 1846
		[ObfuscatedName("worm.canis.actions.phases.HagalSetupPhase+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x060065AF RID: 26031 RVA: 0x001E9BF4 File Offset: 0x001E7DF4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<HagalSetupPhase.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HagalSetupPhase>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalSetupPhase.__c__DisplayClass2_0>.NativeClassPtr);
				HagalSetupPhase.__c__DisplayClass2_0.NativeFieldInfoPtr_soloPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSetupPhase.__c__DisplayClass2_0>.NativeClassPtr, "soloPlayer");
				HagalSetupPhase.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase.__c__DisplayClass2_0>.NativeClassPtr, 100669646);
				HagalSetupPhase.__c__DisplayClass2_0.NativeMethodInfoPtr__BeginSetupExtra_b__2_Internal_Boolean_WormAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase.__c__DisplayClass2_0>.NativeClassPtr, 100669647);
			}

			// Token: 0x060065B0 RID: 26032 RVA: 0x001E9C5C File Offset: 0x001E7E5C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalSetupPhase.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060065B1 RID: 26033 RVA: 0x001E9C98 File Offset: 0x001E7E98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157983, XrefRangeEnd = 157984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginSetupExtra_b__2(WormAgent _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase.__c__DisplayClass2_0.NativeMethodInfoPtr__BeginSetupExtra_b__2_Internal_Boolean_WormAgent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060065B2 RID: 26034 RVA: 0x00027877 File Offset: 0x00025A77
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B52 RID: 6994
			// (get) Token: 0x060065B3 RID: 26035 RVA: 0x001E9CE8 File Offset: 0x001E7EE8
			// (set) Token: 0x060065B4 RID: 26036 RVA: 0x00027880 File Offset: 0x00025A80
			public unsafe WormPlayer soloPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase.__c__DisplayClass2_0.NativeFieldInfoPtr_soloPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase.__c__DisplayClass2_0.NativeFieldInfoPtr_soloPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040041CC RID: 16844
			private static readonly IntPtr NativeFieldInfoPtr_soloPlayer;

			// Token: 0x040041CD RID: 16845
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040041CE RID: 16846
			private static readonly IntPtr NativeMethodInfoPtr__BeginSetupExtra_b__2_Internal_Boolean_WormAgent_0;
		}

		// Token: 0x02000737 RID: 1847
		[ObfuscatedName("worm.canis.actions.phases.HagalSetupPhase+<>c__DisplayClass2_1")]
		public sealed class __c__DisplayClass2_1 : Object
		{
			// Token: 0x060065B5 RID: 26037 RVA: 0x001E9D18 File Offset: 0x001E7F18
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_1()
			{
				Il2CppClassPointerStore<HagalSetupPhase.__c__DisplayClass2_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HagalSetupPhase>.NativeClassPtr, "<>c__DisplayClass2_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalSetupPhase.__c__DisplayClass2_1>.NativeClassPtr);
				HagalSetupPhase.__c__DisplayClass2_1.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSetupPhase.__c__DisplayClass2_1>.NativeClassPtr, "player");
				HagalSetupPhase.__c__DisplayClass2_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase.__c__DisplayClass2_1>.NativeClassPtr, 100669648);
				HagalSetupPhase.__c__DisplayClass2_1.NativeMethodInfoPtr__BeginSetupExtra_b__7_Internal_Boolean_WormAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase.__c__DisplayClass2_1>.NativeClassPtr, 100669649);
			}

			// Token: 0x060065B6 RID: 26038 RVA: 0x001E9D80 File Offset: 0x001E7F80
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalSetupPhase.__c__DisplayClass2_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase.__c__DisplayClass2_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060065B7 RID: 26039 RVA: 0x001E9DBC File Offset: 0x001E7FBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginSetupExtra_b__7(WormAgent _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase.__c__DisplayClass2_1.NativeMethodInfoPtr__BeginSetupExtra_b__7_Internal_Boolean_WormAgent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060065B8 RID: 26040 RVA: 0x0002789F File Offset: 0x00025A9F
			public __c__DisplayClass2_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B53 RID: 6995
			// (get) Token: 0x060065B9 RID: 26041 RVA: 0x001E9E0C File Offset: 0x001E800C
			// (set) Token: 0x060065BA RID: 26042 RVA: 0x000278A8 File Offset: 0x00025AA8
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase.__c__DisplayClass2_1.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase.__c__DisplayClass2_1.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040041CF RID: 16847
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040041D0 RID: 16848
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040041D1 RID: 16849
			private static readonly IntPtr NativeMethodInfoPtr__BeginSetupExtra_b__7_Internal_Boolean_WormAgent_0;
		}

		// Token: 0x02000738 RID: 1848
		[ObfuscatedName("worm.canis.actions.phases.HagalSetupPhase+<>c__DisplayClass3_0")]
		public new sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x060065BB RID: 26043 RVA: 0x001E9E3C File Offset: 0x001E803C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<HagalSetupPhase.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HagalSetupPhase>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalSetupPhase.__c__DisplayClass3_0>.NativeClassPtr);
				HagalSetupPhase.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSetupPhase.__c__DisplayClass3_0>.NativeClassPtr, "<>4__this");
				HagalSetupPhase.__c__DisplayClass3_0.NativeFieldInfoPtr_excludePlayerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSetupPhase.__c__DisplayClass3_0>.NativeClassPtr, "excludePlayerCount");
				HagalSetupPhase.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase.__c__DisplayClass3_0>.NativeClassPtr, 100669650);
				HagalSetupPhase.__c__DisplayClass3_0.NativeMethodInfoPtr__CreateDecksExtra_b__0_Internal_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase.__c__DisplayClass3_0>.NativeClassPtr, 100669651);
			}

			// Token: 0x060065BC RID: 26044 RVA: 0x001E9EB8 File Offset: 0x001E80B8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalSetupPhase.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060065BD RID: 26045 RVA: 0x001E9EF4 File Offset: 0x001E80F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157984, XrefRangeEnd = 157994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreateDecksExtra_b__0(Archetype arch)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(arch);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase.__c__DisplayClass3_0.NativeMethodInfoPtr__CreateDecksExtra_b__0_Internal_Boolean_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060065BE RID: 26046 RVA: 0x000278C7 File Offset: 0x00025AC7
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B54 RID: 6996
			// (get) Token: 0x060065BF RID: 26047 RVA: 0x001E9F44 File Offset: 0x001E8144
			// (set) Token: 0x060065C0 RID: 26048 RVA: 0x000278D0 File Offset: 0x00025AD0
			public unsafe HagalSetupPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HagalSetupPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B55 RID: 6997
			// (get) Token: 0x060065C1 RID: 26049 RVA: 0x001E9F74 File Offset: 0x001E8174
			// (set) Token: 0x060065C2 RID: 26050 RVA: 0x000278EF File Offset: 0x00025AEF
			public unsafe int excludePlayerCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase.__c__DisplayClass3_0.NativeFieldInfoPtr_excludePlayerCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase.__c__DisplayClass3_0.NativeFieldInfoPtr_excludePlayerCount)) = value;
				}
			}

			// Token: 0x040041D2 RID: 16850
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040041D3 RID: 16851
			private static readonly IntPtr NativeFieldInfoPtr_excludePlayerCount;

			// Token: 0x040041D4 RID: 16852
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040041D5 RID: 16853
			private static readonly IntPtr NativeMethodInfoPtr__CreateDecksExtra_b__0_Internal_Boolean_Archetype_0;
		}

		// Token: 0x02000739 RID: 1849
		[ObfuscatedName("worm.canis.actions.phases.HagalSetupPhase+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x060065C3 RID: 26051 RVA: 0x001E9F9C File Offset: 0x001E819C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<HagalSetupPhase.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HagalSetupPhase>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalSetupPhase.__c__DisplayClass5_0>.NativeClassPtr);
				HagalSetupPhase.__c__DisplayClass5_0.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSetupPhase.__c__DisplayClass5_0>.NativeClassPtr, "match");
				HagalSetupPhase.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase.__c__DisplayClass5_0>.NativeClassPtr, 100669652);
				HagalSetupPhase.__c__DisplayClass5_0.NativeMethodInfoPtr__MakeSerializedStateMachineAction_b__0_Internal_IEnumerable_1_SerializedAssignLeader_AssignLeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase.__c__DisplayClass5_0>.NativeClassPtr, 100669653);
			}

			// Token: 0x060065C4 RID: 26052 RVA: 0x001EA004 File Offset: 0x001E8204
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalSetupPhase.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060065C5 RID: 26053 RVA: 0x001EA040 File Offset: 0x001E8240
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157994, XrefRangeEnd = 158010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<SerializedAssignLeader> _MakeSerializedStateMachineAction_b__0(AssignLeader _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase.__c__DisplayClass5_0.NativeMethodInfoPtr__MakeSerializedStateMachineAction_b__0_Internal_IEnumerable_1_SerializedAssignLeader_AssignLeader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<SerializedAssignLeader>>(intPtr3) : null;
				}
			}

			// Token: 0x060065C6 RID: 26054 RVA: 0x0002790A File Offset: 0x00025B0A
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B56 RID: 6998
			// (get) Token: 0x060065C7 RID: 26055 RVA: 0x001EA090 File Offset: 0x001E8290
			// (set) Token: 0x060065C8 RID: 26056 RVA: 0x00027913 File Offset: 0x00025B13
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase.__c__DisplayClass5_0.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase.__c__DisplayClass5_0.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040041D6 RID: 16854
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040041D7 RID: 16855
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040041D8 RID: 16856
			private static readonly IntPtr NativeMethodInfoPtr__MakeSerializedStateMachineAction_b__0_Internal_IEnumerable_1_SerializedAssignLeader_AssignLeader_0;
		}

		// Token: 0x0200073A RID: 1850
		[ObfuscatedName("worm.canis.actions.phases.HagalSetupPhase+<BeginSetupExtra>d__2")]
		public sealed class _BeginSetupExtra_d__2 : Object
		{
			// Token: 0x060065C9 RID: 26057 RVA: 0x001EA0C0 File Offset: 0x001E82C0
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginSetupExtra_d__2()
			{
				Il2CppClassPointerStore<HagalSetupPhase._BeginSetupExtra_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HagalSetupPhase>.NativeClassPtr, "<BeginSetupExtra>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalSetupPhase._BeginSetupExtra_d__2>.NativeClassPtr);
				HagalSetupPhase._BeginSetupExtra_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSetupPhase._BeginSetupExtra_d__2>.NativeClassPtr, "<>1__state");
				HagalSetupPhase._BeginSetupExtra_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSetupPhase._BeginSetupExtra_d__2>.NativeClassPtr, "<>2__current");
				HagalSetupPhase._BeginSetupExtra_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSetupPhase._BeginSetupExtra_d__2>.NativeClassPtr, "<>l__initialThreadId");
				HagalSetupPhase._BeginSetupExtra_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSetupPhase._BeginSetupExtra_d__2>.NativeClassPtr, "<>4__this");
				HagalSetupPhase._BeginSetupExtra_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase._BeginSetupExtra_d__2>.NativeClassPtr, 100669654);
				HagalSetupPhase._BeginSetupExtra_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase._BeginSetupExtra_d__2>.NativeClassPtr, 100669655);
				HagalSetupPhase._BeginSetupExtra_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase._BeginSetupExtra_d__2>.NativeClassPtr, 100669656);
				HagalSetupPhase._BeginSetupExtra_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase._BeginSetupExtra_d__2>.NativeClassPtr, 100669657);
				HagalSetupPhase._BeginSetupExtra_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase._BeginSetupExtra_d__2>.NativeClassPtr, 100669658);
				HagalSetupPhase._BeginSetupExtra_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase._BeginSetupExtra_d__2>.NativeClassPtr, 100669659);
				HagalSetupPhase._BeginSetupExtra_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase._BeginSetupExtra_d__2>.NativeClassPtr, 100669660);
				HagalSetupPhase._BeginSetupExtra_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase._BeginSetupExtra_d__2>.NativeClassPtr, 100669661);
			}

			// Token: 0x060065CA RID: 26058 RVA: 0x001EA1DC File Offset: 0x001E83DC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginSetupExtra_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalSetupPhase._BeginSetupExtra_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase._BeginSetupExtra_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060065CB RID: 26059 RVA: 0x001EA224 File Offset: 0x001E8424
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase._BeginSetupExtra_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060065CC RID: 26060 RVA: 0x001EA258 File Offset: 0x001E8458
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158010, XrefRangeEnd = 158130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase._BeginSetupExtra_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001B5B RID: 7003
			// (get) Token: 0x060065CD RID: 26061 RVA: 0x001EA294 File Offset: 0x001E8494
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase._BeginSetupExtra_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060065CE RID: 26062 RVA: 0x001EA2D4 File Offset: 0x001E84D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158130, XrefRangeEnd = 158135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase._BeginSetupExtra_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001B5C RID: 7004
			// (get) Token: 0x060065CF RID: 26063 RVA: 0x001EA308 File Offset: 0x001E8508
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase._BeginSetupExtra_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060065D0 RID: 26064 RVA: 0x001EA348 File Offset: 0x001E8548
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158135, XrefRangeEnd = 158137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase._BeginSetupExtra_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060065D1 RID: 26065 RVA: 0x001EA388 File Offset: 0x001E8588
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase._BeginSetupExtra_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060065D2 RID: 26066 RVA: 0x00027932 File Offset: 0x00025B32
			public _BeginSetupExtra_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B57 RID: 6999
			// (get) Token: 0x060065D3 RID: 26067 RVA: 0x001EA3C8 File Offset: 0x001E85C8
			// (set) Token: 0x060065D4 RID: 26068 RVA: 0x0002793B File Offset: 0x00025B3B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase._BeginSetupExtra_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase._BeginSetupExtra_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001B58 RID: 7000
			// (get) Token: 0x060065D5 RID: 26069 RVA: 0x001EA3F0 File Offset: 0x001E85F0
			// (set) Token: 0x060065D6 RID: 26070 RVA: 0x00027956 File Offset: 0x00025B56
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase._BeginSetupExtra_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase._BeginSetupExtra_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B59 RID: 7001
			// (get) Token: 0x060065D7 RID: 26071 RVA: 0x001EA420 File Offset: 0x001E8620
			// (set) Token: 0x060065D8 RID: 26072 RVA: 0x00027975 File Offset: 0x00025B75
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase._BeginSetupExtra_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase._BeginSetupExtra_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001B5A RID: 7002
			// (get) Token: 0x060065D9 RID: 26073 RVA: 0x001EA448 File Offset: 0x001E8648
			// (set) Token: 0x060065DA RID: 26074 RVA: 0x00027990 File Offset: 0x00025B90
			public unsafe HagalSetupPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase._BeginSetupExtra_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HagalSetupPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase._BeginSetupExtra_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040041D9 RID: 16857
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040041DA RID: 16858
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040041DB RID: 16859
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040041DC RID: 16860
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040041DD RID: 16861
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040041DE RID: 16862
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040041DF RID: 16863
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040041E0 RID: 16864
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040041E1 RID: 16865
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040041E2 RID: 16866
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040041E3 RID: 16867
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040041E4 RID: 16868
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200073B RID: 1851
		[ObfuscatedName("worm.canis.actions.phases.HagalSetupPhase+<CompleteSetupExtra>d__4")]
		public sealed class _CompleteSetupExtra_d__4 : Object
		{
			// Token: 0x060065DB RID: 26075 RVA: 0x001EA478 File Offset: 0x001E8678
			// Note: this type is marked as 'beforefieldinit'.
			static _CompleteSetupExtra_d__4()
			{
				Il2CppClassPointerStore<HagalSetupPhase._CompleteSetupExtra_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HagalSetupPhase>.NativeClassPtr, "<CompleteSetupExtra>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalSetupPhase._CompleteSetupExtra_d__4>.NativeClassPtr);
				HagalSetupPhase._CompleteSetupExtra_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSetupPhase._CompleteSetupExtra_d__4>.NativeClassPtr, "<>1__state");
				HagalSetupPhase._CompleteSetupExtra_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSetupPhase._CompleteSetupExtra_d__4>.NativeClassPtr, "<>2__current");
				HagalSetupPhase._CompleteSetupExtra_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSetupPhase._CompleteSetupExtra_d__4>.NativeClassPtr, "<>l__initialThreadId");
				HagalSetupPhase._CompleteSetupExtra_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSetupPhase._CompleteSetupExtra_d__4>.NativeClassPtr, "<>4__this");
				HagalSetupPhase._CompleteSetupExtra_d__4.NativeFieldInfoPtr__hagalDifficulty_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSetupPhase._CompleteSetupExtra_d__4>.NativeClassPtr, "<hagalDifficulty>5__2");
				HagalSetupPhase._CompleteSetupExtra_d__4.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSetupPhase._CompleteSetupExtra_d__4>.NativeClassPtr, "<>7__wrap2");
				HagalSetupPhase._CompleteSetupExtra_d__4.NativeFieldInfoPtr__player_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSetupPhase._CompleteSetupExtra_d__4>.NativeClassPtr, "<player>5__4");
				HagalSetupPhase._CompleteSetupExtra_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase._CompleteSetupExtra_d__4>.NativeClassPtr, 100669662);
				HagalSetupPhase._CompleteSetupExtra_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase._CompleteSetupExtra_d__4>.NativeClassPtr, 100669663);
				HagalSetupPhase._CompleteSetupExtra_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase._CompleteSetupExtra_d__4>.NativeClassPtr, 100669664);
				HagalSetupPhase._CompleteSetupExtra_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase._CompleteSetupExtra_d__4>.NativeClassPtr, 100669665);
				HagalSetupPhase._CompleteSetupExtra_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase._CompleteSetupExtra_d__4>.NativeClassPtr, 100669666);
				HagalSetupPhase._CompleteSetupExtra_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase._CompleteSetupExtra_d__4>.NativeClassPtr, 100669667);
				HagalSetupPhase._CompleteSetupExtra_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase._CompleteSetupExtra_d__4>.NativeClassPtr, 100669668);
				HagalSetupPhase._CompleteSetupExtra_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase._CompleteSetupExtra_d__4>.NativeClassPtr, 100669669);
				HagalSetupPhase._CompleteSetupExtra_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase._CompleteSetupExtra_d__4>.NativeClassPtr, 100669670);
			}

			// Token: 0x060065DC RID: 26076 RVA: 0x001EA5E4 File Offset: 0x001E87E4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CompleteSetupExtra_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalSetupPhase._CompleteSetupExtra_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase._CompleteSetupExtra_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060065DD RID: 26077 RVA: 0x001EA62C File Offset: 0x001E882C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158137, XrefRangeEnd = 158142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase._CompleteSetupExtra_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060065DE RID: 26078 RVA: 0x001EA660 File Offset: 0x001E8860
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158142, XrefRangeEnd = 158239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase._CompleteSetupExtra_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060065DF RID: 26079 RVA: 0x001EA69C File Offset: 0x001E889C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158239, XrefRangeEnd = 158242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase._CompleteSetupExtra_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001B64 RID: 7012
			// (get) Token: 0x060065E0 RID: 26080 RVA: 0x001EA6D0 File Offset: 0x001E88D0
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase._CompleteSetupExtra_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060065E1 RID: 26081 RVA: 0x001EA710 File Offset: 0x001E8910
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158242, XrefRangeEnd = 158247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase._CompleteSetupExtra_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001B65 RID: 7013
			// (get) Token: 0x060065E2 RID: 26082 RVA: 0x001EA744 File Offset: 0x001E8944
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase._CompleteSetupExtra_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060065E3 RID: 26083 RVA: 0x001EA784 File Offset: 0x001E8984
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158247, XrefRangeEnd = 158249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase._CompleteSetupExtra_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060065E4 RID: 26084 RVA: 0x001EA7C4 File Offset: 0x001E89C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase._CompleteSetupExtra_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060065E5 RID: 26085 RVA: 0x000279AF File Offset: 0x00025BAF
			public _CompleteSetupExtra_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B5D RID: 7005
			// (get) Token: 0x060065E6 RID: 26086 RVA: 0x001EA804 File Offset: 0x001E8A04
			// (set) Token: 0x060065E7 RID: 26087 RVA: 0x000279B8 File Offset: 0x00025BB8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase._CompleteSetupExtra_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase._CompleteSetupExtra_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001B5E RID: 7006
			// (get) Token: 0x060065E8 RID: 26088 RVA: 0x001EA82C File Offset: 0x001E8A2C
			// (set) Token: 0x060065E9 RID: 26089 RVA: 0x000279D3 File Offset: 0x00025BD3
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase._CompleteSetupExtra_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase._CompleteSetupExtra_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B5F RID: 7007
			// (get) Token: 0x060065EA RID: 26090 RVA: 0x001EA85C File Offset: 0x001E8A5C
			// (set) Token: 0x060065EB RID: 26091 RVA: 0x000279F2 File Offset: 0x00025BF2
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase._CompleteSetupExtra_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase._CompleteSetupExtra_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001B60 RID: 7008
			// (get) Token: 0x060065EC RID: 26092 RVA: 0x001EA884 File Offset: 0x001E8A84
			// (set) Token: 0x060065ED RID: 26093 RVA: 0x00027A0D File Offset: 0x00025C0D
			public unsafe HagalSetupPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase._CompleteSetupExtra_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HagalSetupPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase._CompleteSetupExtra_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B61 RID: 7009
			// (get) Token: 0x060065EE RID: 26094 RVA: 0x001EA8B4 File Offset: 0x001E8AB4
			// (set) Token: 0x060065EF RID: 26095 RVA: 0x00027A2C File Offset: 0x00025C2C
			public unsafe HagalDifficultyLevels _hagalDifficulty_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase._CompleteSetupExtra_d__4.NativeFieldInfoPtr__hagalDifficulty_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase._CompleteSetupExtra_d__4.NativeFieldInfoPtr__hagalDifficulty_5__2)) = value;
				}
			}

			// Token: 0x17001B62 RID: 7010
			// (get) Token: 0x060065F0 RID: 26096 RVA: 0x001EA8DC File Offset: 0x001E8ADC
			// (set) Token: 0x060065F1 RID: 26097 RVA: 0x00027A47 File Offset: 0x00025C47
			public unsafe IEnumerator<WormPlayer> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase._CompleteSetupExtra_d__4.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<WormPlayer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase._CompleteSetupExtra_d__4.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B63 RID: 7011
			// (get) Token: 0x060065F2 RID: 26098 RVA: 0x001EA90C File Offset: 0x001E8B0C
			// (set) Token: 0x060065F3 RID: 26099 RVA: 0x00027A66 File Offset: 0x00025C66
			public unsafe WormPlayer _player_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase._CompleteSetupExtra_d__4.NativeFieldInfoPtr__player_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase._CompleteSetupExtra_d__4.NativeFieldInfoPtr__player_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040041E5 RID: 16869
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040041E6 RID: 16870
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040041E7 RID: 16871
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040041E8 RID: 16872
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040041E9 RID: 16873
			private static readonly IntPtr NativeFieldInfoPtr__hagalDifficulty_5__2;

			// Token: 0x040041EA RID: 16874
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x040041EB RID: 16875
			private static readonly IntPtr NativeFieldInfoPtr__player_5__4;

			// Token: 0x040041EC RID: 16876
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040041ED RID: 16877
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040041EE RID: 16878
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040041EF RID: 16879
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040041F0 RID: 16880
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040041F1 RID: 16881
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040041F2 RID: 16882
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040041F3 RID: 16883
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040041F4 RID: 16884
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200073C RID: 1852
		[ObfuscatedName("worm.canis.actions.phases.HagalSetupPhase+<CreateDecksExtra>d__3")]
		public sealed class _CreateDecksExtra_d__3 : Object
		{
			// Token: 0x060065F4 RID: 26100 RVA: 0x001EA93C File Offset: 0x001E8B3C
			// Note: this type is marked as 'beforefieldinit'.
			static _CreateDecksExtra_d__3()
			{
				Il2CppClassPointerStore<HagalSetupPhase._CreateDecksExtra_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HagalSetupPhase>.NativeClassPtr, "<CreateDecksExtra>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalSetupPhase._CreateDecksExtra_d__3>.NativeClassPtr);
				HagalSetupPhase._CreateDecksExtra_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSetupPhase._CreateDecksExtra_d__3>.NativeClassPtr, "<>1__state");
				HagalSetupPhase._CreateDecksExtra_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSetupPhase._CreateDecksExtra_d__3>.NativeClassPtr, "<>2__current");
				HagalSetupPhase._CreateDecksExtra_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSetupPhase._CreateDecksExtra_d__3>.NativeClassPtr, "<>l__initialThreadId");
				HagalSetupPhase._CreateDecksExtra_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalSetupPhase._CreateDecksExtra_d__3>.NativeClassPtr, "<>4__this");
				HagalSetupPhase._CreateDecksExtra_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase._CreateDecksExtra_d__3>.NativeClassPtr, 100669671);
				HagalSetupPhase._CreateDecksExtra_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase._CreateDecksExtra_d__3>.NativeClassPtr, 100669672);
				HagalSetupPhase._CreateDecksExtra_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase._CreateDecksExtra_d__3>.NativeClassPtr, 100669673);
				HagalSetupPhase._CreateDecksExtra_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase._CreateDecksExtra_d__3>.NativeClassPtr, 100669674);
				HagalSetupPhase._CreateDecksExtra_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase._CreateDecksExtra_d__3>.NativeClassPtr, 100669675);
				HagalSetupPhase._CreateDecksExtra_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase._CreateDecksExtra_d__3>.NativeClassPtr, 100669676);
				HagalSetupPhase._CreateDecksExtra_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase._CreateDecksExtra_d__3>.NativeClassPtr, 100669677);
				HagalSetupPhase._CreateDecksExtra_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalSetupPhase._CreateDecksExtra_d__3>.NativeClassPtr, 100669678);
			}

			// Token: 0x060065F5 RID: 26101 RVA: 0x001EAA58 File Offset: 0x001E8C58
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CreateDecksExtra_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalSetupPhase._CreateDecksExtra_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase._CreateDecksExtra_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060065F6 RID: 26102 RVA: 0x001EAAA0 File Offset: 0x001E8CA0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase._CreateDecksExtra_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060065F7 RID: 26103 RVA: 0x001EAAD4 File Offset: 0x001E8CD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158249, XrefRangeEnd = 158384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase._CreateDecksExtra_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001B6A RID: 7018
			// (get) Token: 0x060065F8 RID: 26104 RVA: 0x001EAB10 File Offset: 0x001E8D10
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase._CreateDecksExtra_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060065F9 RID: 26105 RVA: 0x001EAB50 File Offset: 0x001E8D50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158384, XrefRangeEnd = 158389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase._CreateDecksExtra_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001B6B RID: 7019
			// (get) Token: 0x060065FA RID: 26106 RVA: 0x001EAB84 File Offset: 0x001E8D84
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase._CreateDecksExtra_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060065FB RID: 26107 RVA: 0x001EABC4 File Offset: 0x001E8DC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158389, XrefRangeEnd = 158391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase._CreateDecksExtra_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060065FC RID: 26108 RVA: 0x001EAC04 File Offset: 0x001E8E04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalSetupPhase._CreateDecksExtra_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060065FD RID: 26109 RVA: 0x00027A85 File Offset: 0x00025C85
			public _CreateDecksExtra_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B66 RID: 7014
			// (get) Token: 0x060065FE RID: 26110 RVA: 0x001EAC44 File Offset: 0x001E8E44
			// (set) Token: 0x060065FF RID: 26111 RVA: 0x00027A8E File Offset: 0x00025C8E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase._CreateDecksExtra_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase._CreateDecksExtra_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001B67 RID: 7015
			// (get) Token: 0x06006600 RID: 26112 RVA: 0x001EAC6C File Offset: 0x001E8E6C
			// (set) Token: 0x06006601 RID: 26113 RVA: 0x00027AA9 File Offset: 0x00025CA9
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase._CreateDecksExtra_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase._CreateDecksExtra_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B68 RID: 7016
			// (get) Token: 0x06006602 RID: 26114 RVA: 0x001EAC9C File Offset: 0x001E8E9C
			// (set) Token: 0x06006603 RID: 26115 RVA: 0x00027AC8 File Offset: 0x00025CC8
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase._CreateDecksExtra_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase._CreateDecksExtra_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001B69 RID: 7017
			// (get) Token: 0x06006604 RID: 26116 RVA: 0x001EACC4 File Offset: 0x001E8EC4
			// (set) Token: 0x06006605 RID: 26117 RVA: 0x00027AE3 File Offset: 0x00025CE3
			public unsafe HagalSetupPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase._CreateDecksExtra_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HagalSetupPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalSetupPhase._CreateDecksExtra_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040041F5 RID: 16885
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040041F6 RID: 16886
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040041F7 RID: 16887
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040041F8 RID: 16888
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040041F9 RID: 16889
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040041FA RID: 16890
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040041FB RID: 16891
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040041FC RID: 16892
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040041FD RID: 16893
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040041FE RID: 16894
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040041FF RID: 16895
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004200 RID: 16896
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

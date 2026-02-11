using System;
using Canis;
using Canis.actions;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.actions.phases
{
	// Token: 0x020002C5 RID: 709
	public class GenerateConflictPhase : StateMachineAction<GenerateConflictState>
	{
		// Token: 0x06001D34 RID: 7476 RVA: 0x000CAA94 File Offset: 0x000C8C94
		// Note: this type is marked as 'beforefieldinit'.
		static GenerateConflictPhase()
		{
			Il2CppClassPointerStore<GenerateConflictPhase>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.phases", "GenerateConflictPhase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenerateConflictPhase>.NativeClassPtr);
			GenerateConflictPhase.NativeFieldInfoPtr_controlledSpaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateConflictPhase>.NativeClassPtr, "controlledSpaces");
			GenerateConflictPhase.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateConflictPhase>.NativeClassPtr, "wormMatch");
			GenerateConflictPhase.NativeMethodInfoPtr__ctor_Public_Void_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase>.NativeClassPtr, 100669580);
			GenerateConflictPhase.NativeMethodInfoPtr__ctor_Public_Void_SerializedGenerateConflictPhase_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase>.NativeClassPtr, 100669581);
			GenerateConflictPhase.NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_GenerateConflictState_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase>.NativeClassPtr, 100669582);
			GenerateConflictPhase.NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_GenerateConflictState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase>.NativeClassPtr, 100669583);
			GenerateConflictPhase.NativeMethodInfoPtr_DetermineConflict_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase>.NativeClassPtr, 100669584);
			GenerateConflictPhase.NativeMethodInfoPtr_ConvertSpecimens_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase>.NativeClassPtr, 100669585);
			GenerateConflictPhase.NativeMethodInfoPtr_DeployControlTroops_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase>.NativeClassPtr, 100669586);
			GenerateConflictPhase.NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase>.NativeClassPtr, 100669587);
		}

		// Token: 0x06001D35 RID: 7477 RVA: 0x000CAB8C File Offset: 0x000C8D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157622, XrefRangeEnd = 157642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenerateConflictPhase(Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenerateConflictPhase>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenerateConflictPhase.NativeMethodInfoPtr__ctor_Public_Void_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D36 RID: 7478 RVA: 0x000CABD8 File Offset: 0x000C8DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157642, XrefRangeEnd = 157669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenerateConflictPhase(SerializedGenerateConflictPhase serialized, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenerateConflictPhase>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenerateConflictPhase.NativeMethodInfoPtr__ctor_Public_Void_SerializedGenerateConflictPhase_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D37 RID: 7479 RVA: 0x000CAC38 File Offset: 0x000C8E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157669, XrefRangeEnd = 157676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Nullable<GenerateConflictState> DetermineNextTypedState(global::Canis.actions.Action lastAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenerateConflictPhase.NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_GenerateConflictState_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<GenerateConflictState>(intPtr);
			}
		}

		// Token: 0x06001D38 RID: 7480 RVA: 0x000CAC8C File Offset: 0x000C8E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157676, XrefRangeEnd = 157684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override StateMachineAction.StateBehavior TypedBehaviorFor(GenerateConflictState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenerateConflictPhase.NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_GenerateConflictState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineAction.StateBehavior>(intPtr3) : null;
			}
		}

		// Token: 0x06001D39 RID: 7481 RVA: 0x000CACE4 File Offset: 0x000C8EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157684, XrefRangeEnd = 157690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> DetermineConflict()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenerateConflictPhase.NativeMethodInfoPtr_DetermineConflict_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001D3A RID: 7482 RVA: 0x000CAD24 File Offset: 0x000C8F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157690, XrefRangeEnd = 157696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> ConvertSpecimens()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenerateConflictPhase.NativeMethodInfoPtr_ConvertSpecimens_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x000CAD64 File Offset: 0x000C8F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157696, XrefRangeEnd = 157702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> DeployControlTroops()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenerateConflictPhase.NativeMethodInfoPtr_DeployControlTroops_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x000CADA4 File Offset: 0x000C8FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157702, XrefRangeEnd = 157728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedStateMachineAction MakeSerializedStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenerateConflictPhase.NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedStateMachineAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001D3D RID: 7485 RVA: 0x0000C4F8 File Offset: 0x0000A6F8
		public GenerateConflictPhase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06001D3E RID: 7486 RVA: 0x000CAE00 File Offset: 0x000C9000
		// (set) Token: 0x06001D3F RID: 7487 RVA: 0x0000C501 File Offset: 0x0000A701
		public unsafe List<WormSpace> controlledSpaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase.NativeFieldInfoPtr_controlledSpaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormSpace>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase.NativeFieldInfoPtr_controlledSpaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06001D40 RID: 7488 RVA: 0x000CAE30 File Offset: 0x000C9030
		// (set) Token: 0x06001D41 RID: 7489 RVA: 0x0000C520 File Offset: 0x0000A720
		public unsafe WormMatch wormMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase.NativeFieldInfoPtr_wormMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001232 RID: 4658
		private static readonly IntPtr NativeFieldInfoPtr_controlledSpaces;

		// Token: 0x04001233 RID: 4659
		private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

		// Token: 0x04001234 RID: 4660
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_0;

		// Token: 0x04001235 RID: 4661
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedGenerateConflictPhase_WormMatch_0;

		// Token: 0x04001236 RID: 4662
		private static readonly IntPtr NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_GenerateConflictState_Action_0;

		// Token: 0x04001237 RID: 4663
		private static readonly IntPtr NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_GenerateConflictState_0;

		// Token: 0x04001238 RID: 4664
		private static readonly IntPtr NativeMethodInfoPtr_DetermineConflict_Private_IEnumerable_1_Action_0;

		// Token: 0x04001239 RID: 4665
		private static readonly IntPtr NativeMethodInfoPtr_ConvertSpecimens_Private_IEnumerable_1_Action_0;

		// Token: 0x0400123A RID: 4666
		private static readonly IntPtr NativeMethodInfoPtr_DeployControlTroops_Private_IEnumerable_1_Action_0;

		// Token: 0x0400123B RID: 4667
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0;

		// Token: 0x02000730 RID: 1840
		[ObfuscatedName("worm.canis.actions.phases.GenerateConflictPhase+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600651F RID: 25887 RVA: 0x001E80D0 File Offset: 0x001E62D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GenerateConflictPhase.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenerateConflictPhase>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenerateConflictPhase.__c>.NativeClassPtr);
				GenerateConflictPhase.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateConflictPhase.__c>.NativeClassPtr, "<>9");
				GenerateConflictPhase.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateConflictPhase.__c>.NativeClassPtr, "<>9__6_0");
				GenerateConflictPhase.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateConflictPhase.__c>.NativeClassPtr, "<>9__9_0");
				GenerateConflictPhase.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase.__c>.NativeClassPtr, 100669589);
				GenerateConflictPhase.__c.NativeMethodInfoPtr__DetermineConflict_b__6_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase.__c>.NativeClassPtr, 100669590);
				GenerateConflictPhase.__c.NativeMethodInfoPtr__MakeSerializedStateMachineAction_b__9_0_Internal_EntityID_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase.__c>.NativeClassPtr, 100669591);
			}

			// Token: 0x06006520 RID: 25888 RVA: 0x001E8174 File Offset: 0x001E6374
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenerateConflictPhase.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenerateConflictPhase.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006521 RID: 25889 RVA: 0x001E81B0 File Offset: 0x001E63B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DetermineConflict_b__6_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenerateConflictPhase.__c.NativeMethodInfoPtr__DetermineConflict_b__6_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006522 RID: 25890 RVA: 0x001E8200 File Offset: 0x001E6400
			[CallerCount(0)]
			public unsafe EntityID _MakeSerializedStateMachineAction_b__9_0(WormSpace _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenerateConflictPhase.__c.NativeMethodInfoPtr__MakeSerializedStateMachineAction_b__9_0_Internal_EntityID_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x06006523 RID: 25891 RVA: 0x000273F2 File Offset: 0x000255F2
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B1F RID: 6943
			// (get) Token: 0x06006524 RID: 25892 RVA: 0x001E8250 File Offset: 0x001E6450
			// (set) Token: 0x06006525 RID: 25893 RVA: 0x000273FB File Offset: 0x000255FB
			public unsafe static GenerateConflictPhase.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GenerateConflictPhase.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenerateConflictPhase.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GenerateConflictPhase.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B20 RID: 6944
			// (get) Token: 0x06006526 RID: 25894 RVA: 0x001E8278 File Offset: 0x001E6478
			// (set) Token: 0x06006527 RID: 25895 RVA: 0x0002740D File Offset: 0x0002560D
			public unsafe static Func<WormPlayer, bool> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GenerateConflictPhase.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GenerateConflictPhase.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B21 RID: 6945
			// (get) Token: 0x06006528 RID: 25896 RVA: 0x001E82A0 File Offset: 0x001E64A0
			// (set) Token: 0x06006529 RID: 25897 RVA: 0x0002741F File Offset: 0x0002561F
			public unsafe static Func<WormSpace, EntityID> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GenerateConflictPhase.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormSpace, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GenerateConflictPhase.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004173 RID: 16755
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004174 RID: 16756
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04004175 RID: 16757
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04004176 RID: 16758
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004177 RID: 16759
			private static readonly IntPtr NativeMethodInfoPtr__DetermineConflict_b__6_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x04004178 RID: 16760
			private static readonly IntPtr NativeMethodInfoPtr__MakeSerializedStateMachineAction_b__9_0_Internal_EntityID_WormSpace_0;
		}

		// Token: 0x02000731 RID: 1841
		[ObfuscatedName("worm.canis.actions.phases.GenerateConflictPhase+<ConvertSpecimens>d__7")]
		public sealed class _ConvertSpecimens_d__7 : Object
		{
			// Token: 0x0600652A RID: 25898 RVA: 0x001E82C8 File Offset: 0x001E64C8
			// Note: this type is marked as 'beforefieldinit'.
			static _ConvertSpecimens_d__7()
			{
				Il2CppClassPointerStore<GenerateConflictPhase._ConvertSpecimens_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenerateConflictPhase>.NativeClassPtr, "<ConvertSpecimens>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenerateConflictPhase._ConvertSpecimens_d__7>.NativeClassPtr);
				GenerateConflictPhase._ConvertSpecimens_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateConflictPhase._ConvertSpecimens_d__7>.NativeClassPtr, "<>1__state");
				GenerateConflictPhase._ConvertSpecimens_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateConflictPhase._ConvertSpecimens_d__7>.NativeClassPtr, "<>2__current");
				GenerateConflictPhase._ConvertSpecimens_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateConflictPhase._ConvertSpecimens_d__7>.NativeClassPtr, "<>l__initialThreadId");
				GenerateConflictPhase._ConvertSpecimens_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateConflictPhase._ConvertSpecimens_d__7>.NativeClassPtr, "<>4__this");
				GenerateConflictPhase._ConvertSpecimens_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase._ConvertSpecimens_d__7>.NativeClassPtr, 100669592);
				GenerateConflictPhase._ConvertSpecimens_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase._ConvertSpecimens_d__7>.NativeClassPtr, 100669593);
				GenerateConflictPhase._ConvertSpecimens_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase._ConvertSpecimens_d__7>.NativeClassPtr, 100669594);
				GenerateConflictPhase._ConvertSpecimens_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase._ConvertSpecimens_d__7>.NativeClassPtr, 100669595);
				GenerateConflictPhase._ConvertSpecimens_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase._ConvertSpecimens_d__7>.NativeClassPtr, 100669596);
				GenerateConflictPhase._ConvertSpecimens_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase._ConvertSpecimens_d__7>.NativeClassPtr, 100669597);
				GenerateConflictPhase._ConvertSpecimens_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase._ConvertSpecimens_d__7>.NativeClassPtr, 100669598);
				GenerateConflictPhase._ConvertSpecimens_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase._ConvertSpecimens_d__7>.NativeClassPtr, 100669599);
			}

			// Token: 0x0600652B RID: 25899 RVA: 0x001E83E4 File Offset: 0x001E65E4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ConvertSpecimens_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenerateConflictPhase._ConvertSpecimens_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenerateConflictPhase._ConvertSpecimens_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600652C RID: 25900 RVA: 0x001E842C File Offset: 0x001E662C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenerateConflictPhase._ConvertSpecimens_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600652D RID: 25901 RVA: 0x001E8460 File Offset: 0x001E6660
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157389, XrefRangeEnd = 157418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenerateConflictPhase._ConvertSpecimens_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001B26 RID: 6950
			// (get) Token: 0x0600652E RID: 25902 RVA: 0x001E849C File Offset: 0x001E669C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenerateConflictPhase._ConvertSpecimens_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600652F RID: 25903 RVA: 0x001E84DC File Offset: 0x001E66DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157418, XrefRangeEnd = 157423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenerateConflictPhase._ConvertSpecimens_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001B27 RID: 6951
			// (get) Token: 0x06006530 RID: 25904 RVA: 0x001E8510 File Offset: 0x001E6710
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenerateConflictPhase._ConvertSpecimens_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006531 RID: 25905 RVA: 0x001E8550 File Offset: 0x001E6750
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157423, XrefRangeEnd = 157425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenerateConflictPhase._ConvertSpecimens_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006532 RID: 25906 RVA: 0x001E8590 File Offset: 0x001E6790
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenerateConflictPhase._ConvertSpecimens_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006533 RID: 25907 RVA: 0x00027431 File Offset: 0x00025631
			public _ConvertSpecimens_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B22 RID: 6946
			// (get) Token: 0x06006534 RID: 25908 RVA: 0x001E85D0 File Offset: 0x001E67D0
			// (set) Token: 0x06006535 RID: 25909 RVA: 0x0002743A File Offset: 0x0002563A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._ConvertSpecimens_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._ConvertSpecimens_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001B23 RID: 6947
			// (get) Token: 0x06006536 RID: 25910 RVA: 0x001E85F8 File Offset: 0x001E67F8
			// (set) Token: 0x06006537 RID: 25911 RVA: 0x00027455 File Offset: 0x00025655
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._ConvertSpecimens_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._ConvertSpecimens_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B24 RID: 6948
			// (get) Token: 0x06006538 RID: 25912 RVA: 0x001E8628 File Offset: 0x001E6828
			// (set) Token: 0x06006539 RID: 25913 RVA: 0x00027474 File Offset: 0x00025674
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._ConvertSpecimens_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._ConvertSpecimens_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001B25 RID: 6949
			// (get) Token: 0x0600653A RID: 25914 RVA: 0x001E8650 File Offset: 0x001E6850
			// (set) Token: 0x0600653B RID: 25915 RVA: 0x0002748F File Offset: 0x0002568F
			public unsafe GenerateConflictPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._ConvertSpecimens_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenerateConflictPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._ConvertSpecimens_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004179 RID: 16761
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400417A RID: 16762
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400417B RID: 16763
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400417C RID: 16764
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400417D RID: 16765
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400417E RID: 16766
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400417F RID: 16767
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004180 RID: 16768
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004181 RID: 16769
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004182 RID: 16770
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004183 RID: 16771
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004184 RID: 16772
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000732 RID: 1842
		[ObfuscatedName("worm.canis.actions.phases.GenerateConflictPhase+<DeployControlTroops>d__8")]
		public sealed class _DeployControlTroops_d__8 : Object
		{
			// Token: 0x0600653C RID: 25916 RVA: 0x001E8680 File Offset: 0x001E6880
			// Note: this type is marked as 'beforefieldinit'.
			static _DeployControlTroops_d__8()
			{
				Il2CppClassPointerStore<GenerateConflictPhase._DeployControlTroops_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenerateConflictPhase>.NativeClassPtr, "<DeployControlTroops>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenerateConflictPhase._DeployControlTroops_d__8>.NativeClassPtr);
				GenerateConflictPhase._DeployControlTroops_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateConflictPhase._DeployControlTroops_d__8>.NativeClassPtr, "<>1__state");
				GenerateConflictPhase._DeployControlTroops_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateConflictPhase._DeployControlTroops_d__8>.NativeClassPtr, "<>2__current");
				GenerateConflictPhase._DeployControlTroops_d__8.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateConflictPhase._DeployControlTroops_d__8>.NativeClassPtr, "<>l__initialThreadId");
				GenerateConflictPhase._DeployControlTroops_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateConflictPhase._DeployControlTroops_d__8>.NativeClassPtr, "<>4__this");
				GenerateConflictPhase._DeployControlTroops_d__8.NativeFieldInfoPtr__controlledSpace_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateConflictPhase._DeployControlTroops_d__8>.NativeClassPtr, "<controlledSpace>5__2");
				GenerateConflictPhase._DeployControlTroops_d__8.NativeFieldInfoPtr__controller_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateConflictPhase._DeployControlTroops_d__8>.NativeClassPtr, "<controller>5__3");
				GenerateConflictPhase._DeployControlTroops_d__8.NativeFieldInfoPtr__sequenceHelper_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateConflictPhase._DeployControlTroops_d__8>.NativeClassPtr, "<sequenceHelper>5__4");
				GenerateConflictPhase._DeployControlTroops_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase._DeployControlTroops_d__8>.NativeClassPtr, 100669600);
				GenerateConflictPhase._DeployControlTroops_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase._DeployControlTroops_d__8>.NativeClassPtr, 100669601);
				GenerateConflictPhase._DeployControlTroops_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase._DeployControlTroops_d__8>.NativeClassPtr, 100669602);
				GenerateConflictPhase._DeployControlTroops_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase._DeployControlTroops_d__8>.NativeClassPtr, 100669603);
				GenerateConflictPhase._DeployControlTroops_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase._DeployControlTroops_d__8>.NativeClassPtr, 100669604);
				GenerateConflictPhase._DeployControlTroops_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase._DeployControlTroops_d__8>.NativeClassPtr, 100669605);
				GenerateConflictPhase._DeployControlTroops_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase._DeployControlTroops_d__8>.NativeClassPtr, 100669606);
				GenerateConflictPhase._DeployControlTroops_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase._DeployControlTroops_d__8>.NativeClassPtr, 100669607);
			}

			// Token: 0x0600653D RID: 25917 RVA: 0x001E87D8 File Offset: 0x001E69D8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DeployControlTroops_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenerateConflictPhase._DeployControlTroops_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenerateConflictPhase._DeployControlTroops_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600653E RID: 25918 RVA: 0x001E8820 File Offset: 0x001E6A20
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenerateConflictPhase._DeployControlTroops_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600653F RID: 25919 RVA: 0x001E8854 File Offset: 0x001E6A54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157425, XrefRangeEnd = 157542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenerateConflictPhase._DeployControlTroops_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001B2F RID: 6959
			// (get) Token: 0x06006540 RID: 25920 RVA: 0x001E8890 File Offset: 0x001E6A90
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenerateConflictPhase._DeployControlTroops_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006541 RID: 25921 RVA: 0x001E88D0 File Offset: 0x001E6AD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157542, XrefRangeEnd = 157547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenerateConflictPhase._DeployControlTroops_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001B30 RID: 6960
			// (get) Token: 0x06006542 RID: 25922 RVA: 0x001E8904 File Offset: 0x001E6B04
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenerateConflictPhase._DeployControlTroops_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006543 RID: 25923 RVA: 0x001E8944 File Offset: 0x001E6B44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157547, XrefRangeEnd = 157549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenerateConflictPhase._DeployControlTroops_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006544 RID: 25924 RVA: 0x001E8984 File Offset: 0x001E6B84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenerateConflictPhase._DeployControlTroops_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006545 RID: 25925 RVA: 0x000274AE File Offset: 0x000256AE
			public _DeployControlTroops_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B28 RID: 6952
			// (get) Token: 0x06006546 RID: 25926 RVA: 0x001E89C4 File Offset: 0x001E6BC4
			// (set) Token: 0x06006547 RID: 25927 RVA: 0x000274B7 File Offset: 0x000256B7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._DeployControlTroops_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._DeployControlTroops_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001B29 RID: 6953
			// (get) Token: 0x06006548 RID: 25928 RVA: 0x001E89EC File Offset: 0x001E6BEC
			// (set) Token: 0x06006549 RID: 25929 RVA: 0x000274D2 File Offset: 0x000256D2
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._DeployControlTroops_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._DeployControlTroops_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B2A RID: 6954
			// (get) Token: 0x0600654A RID: 25930 RVA: 0x001E8A1C File Offset: 0x001E6C1C
			// (set) Token: 0x0600654B RID: 25931 RVA: 0x000274F1 File Offset: 0x000256F1
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._DeployControlTroops_d__8.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._DeployControlTroops_d__8.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001B2B RID: 6955
			// (get) Token: 0x0600654C RID: 25932 RVA: 0x001E8A44 File Offset: 0x001E6C44
			// (set) Token: 0x0600654D RID: 25933 RVA: 0x0002750C File Offset: 0x0002570C
			public unsafe GenerateConflictPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._DeployControlTroops_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenerateConflictPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._DeployControlTroops_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B2C RID: 6956
			// (get) Token: 0x0600654E RID: 25934 RVA: 0x001E8A74 File Offset: 0x001E6C74
			// (set) Token: 0x0600654F RID: 25935 RVA: 0x0002752B File Offset: 0x0002572B
			public unsafe WormSpace _controlledSpace_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._DeployControlTroops_d__8.NativeFieldInfoPtr__controlledSpace_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._DeployControlTroops_d__8.NativeFieldInfoPtr__controlledSpace_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B2D RID: 6957
			// (get) Token: 0x06006550 RID: 25936 RVA: 0x001E8AA4 File Offset: 0x001E6CA4
			// (set) Token: 0x06006551 RID: 25937 RVA: 0x0002754A File Offset: 0x0002574A
			public unsafe WormPlayer _controller_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._DeployControlTroops_d__8.NativeFieldInfoPtr__controller_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._DeployControlTroops_d__8.NativeFieldInfoPtr__controller_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B2E RID: 6958
			// (get) Token: 0x06006552 RID: 25938 RVA: 0x001E8AD4 File Offset: 0x001E6CD4
			// (set) Token: 0x06006553 RID: 25939 RVA: 0x00027569 File Offset: 0x00025769
			public unsafe SequenceHelper _sequenceHelper_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._DeployControlTroops_d__8.NativeFieldInfoPtr__sequenceHelper_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._DeployControlTroops_d__8.NativeFieldInfoPtr__sequenceHelper_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004185 RID: 16773
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004186 RID: 16774
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004187 RID: 16775
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004188 RID: 16776
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004189 RID: 16777
			private static readonly IntPtr NativeFieldInfoPtr__controlledSpace_5__2;

			// Token: 0x0400418A RID: 16778
			private static readonly IntPtr NativeFieldInfoPtr__controller_5__3;

			// Token: 0x0400418B RID: 16779
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__4;

			// Token: 0x0400418C RID: 16780
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400418D RID: 16781
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400418E RID: 16782
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400418F RID: 16783
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004190 RID: 16784
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004191 RID: 16785
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004192 RID: 16786
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004193 RID: 16787
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000733 RID: 1843
		[ObfuscatedName("worm.canis.actions.phases.GenerateConflictPhase+<DetermineConflict>d__6")]
		public sealed class _DetermineConflict_d__6 : Object
		{
			// Token: 0x06006554 RID: 25940 RVA: 0x001E8B04 File Offset: 0x001E6D04
			// Note: this type is marked as 'beforefieldinit'.
			static _DetermineConflict_d__6()
			{
				Il2CppClassPointerStore<GenerateConflictPhase._DetermineConflict_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenerateConflictPhase>.NativeClassPtr, "<DetermineConflict>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenerateConflictPhase._DetermineConflict_d__6>.NativeClassPtr);
				GenerateConflictPhase._DetermineConflict_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateConflictPhase._DetermineConflict_d__6>.NativeClassPtr, "<>1__state");
				GenerateConflictPhase._DetermineConflict_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateConflictPhase._DetermineConflict_d__6>.NativeClassPtr, "<>2__current");
				GenerateConflictPhase._DetermineConflict_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateConflictPhase._DetermineConflict_d__6>.NativeClassPtr, "<>l__initialThreadId");
				GenerateConflictPhase._DetermineConflict_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateConflictPhase._DetermineConflict_d__6>.NativeClassPtr, "<>4__this");
				GenerateConflictPhase._DetermineConflict_d__6.NativeFieldInfoPtr__board_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateConflictPhase._DetermineConflict_d__6>.NativeClassPtr, "<board>5__2");
				GenerateConflictPhase._DetermineConflict_d__6.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateConflictPhase._DetermineConflict_d__6>.NativeClassPtr, "<>7__wrap2");
				GenerateConflictPhase._DetermineConflict_d__6.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateConflictPhase._DetermineConflict_d__6>.NativeClassPtr, "<>7__wrap3");
				GenerateConflictPhase._DetermineConflict_d__6.NativeFieldInfoPtr__controlledSpace_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateConflictPhase._DetermineConflict_d__6>.NativeClassPtr, "<controlledSpace>5__5");
				GenerateConflictPhase._DetermineConflict_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase._DetermineConflict_d__6>.NativeClassPtr, 100669608);
				GenerateConflictPhase._DetermineConflict_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase._DetermineConflict_d__6>.NativeClassPtr, 100669609);
				GenerateConflictPhase._DetermineConflict_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase._DetermineConflict_d__6>.NativeClassPtr, 100669610);
				GenerateConflictPhase._DetermineConflict_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase._DetermineConflict_d__6>.NativeClassPtr, 100669611);
				GenerateConflictPhase._DetermineConflict_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase._DetermineConflict_d__6>.NativeClassPtr, 100669612);
				GenerateConflictPhase._DetermineConflict_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase._DetermineConflict_d__6>.NativeClassPtr, 100669613);
				GenerateConflictPhase._DetermineConflict_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase._DetermineConflict_d__6>.NativeClassPtr, 100669614);
				GenerateConflictPhase._DetermineConflict_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateConflictPhase._DetermineConflict_d__6>.NativeClassPtr, 100669615);
			}

			// Token: 0x06006555 RID: 25941 RVA: 0x001E8C70 File Offset: 0x001E6E70
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DetermineConflict_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenerateConflictPhase._DetermineConflict_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenerateConflictPhase._DetermineConflict_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006556 RID: 25942 RVA: 0x001E8CB8 File Offset: 0x001E6EB8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenerateConflictPhase._DetermineConflict_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006557 RID: 25943 RVA: 0x001E8CEC File Offset: 0x001E6EEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157549, XrefRangeEnd = 157615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenerateConflictPhase._DetermineConflict_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001B39 RID: 6969
			// (get) Token: 0x06006558 RID: 25944 RVA: 0x001E8D28 File Offset: 0x001E6F28
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenerateConflictPhase._DetermineConflict_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006559 RID: 25945 RVA: 0x001E8D68 File Offset: 0x001E6F68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157615, XrefRangeEnd = 157620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenerateConflictPhase._DetermineConflict_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001B3A RID: 6970
			// (get) Token: 0x0600655A RID: 25946 RVA: 0x001E8D9C File Offset: 0x001E6F9C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenerateConflictPhase._DetermineConflict_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600655B RID: 25947 RVA: 0x001E8DDC File Offset: 0x001E6FDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157620, XrefRangeEnd = 157622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenerateConflictPhase._DetermineConflict_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600655C RID: 25948 RVA: 0x001E8E1C File Offset: 0x001E701C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenerateConflictPhase._DetermineConflict_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600655D RID: 25949 RVA: 0x00027588 File Offset: 0x00025788
			public _DetermineConflict_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B31 RID: 6961
			// (get) Token: 0x0600655E RID: 25950 RVA: 0x001E8E5C File Offset: 0x001E705C
			// (set) Token: 0x0600655F RID: 25951 RVA: 0x00027591 File Offset: 0x00025791
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._DetermineConflict_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._DetermineConflict_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001B32 RID: 6962
			// (get) Token: 0x06006560 RID: 25952 RVA: 0x001E8E84 File Offset: 0x001E7084
			// (set) Token: 0x06006561 RID: 25953 RVA: 0x000275AC File Offset: 0x000257AC
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._DetermineConflict_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._DetermineConflict_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B33 RID: 6963
			// (get) Token: 0x06006562 RID: 25954 RVA: 0x001E8EB4 File Offset: 0x001E70B4
			// (set) Token: 0x06006563 RID: 25955 RVA: 0x000275CB File Offset: 0x000257CB
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._DetermineConflict_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._DetermineConflict_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001B34 RID: 6964
			// (get) Token: 0x06006564 RID: 25956 RVA: 0x001E8EDC File Offset: 0x001E70DC
			// (set) Token: 0x06006565 RID: 25957 RVA: 0x000275E6 File Offset: 0x000257E6
			public unsafe GenerateConflictPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._DetermineConflict_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenerateConflictPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._DetermineConflict_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B35 RID: 6965
			// (get) Token: 0x06006566 RID: 25958 RVA: 0x001E8F0C File Offset: 0x001E710C
			// (set) Token: 0x06006567 RID: 25959 RVA: 0x00027605 File Offset: 0x00025805
			public unsafe WormBoard _board_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._DetermineConflict_d__6.NativeFieldInfoPtr__board_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormBoard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._DetermineConflict_d__6.NativeFieldInfoPtr__board_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B36 RID: 6966
			// (get) Token: 0x06006568 RID: 25960 RVA: 0x001E8F3C File Offset: 0x001E713C
			// (set) Token: 0x06006569 RID: 25961 RVA: 0x00027624 File Offset: 0x00025824
			public unsafe Il2CppReferenceArray<ArchetypeID> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._DetermineConflict_d__6.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._DetermineConflict_d__6.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B37 RID: 6967
			// (get) Token: 0x0600656A RID: 25962 RVA: 0x001E8F6C File Offset: 0x001E716C
			// (set) Token: 0x0600656B RID: 25963 RVA: 0x00027643 File Offset: 0x00025843
			public unsafe int __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._DetermineConflict_d__6.NativeFieldInfoPtr___7__wrap3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._DetermineConflict_d__6.NativeFieldInfoPtr___7__wrap3)) = value;
				}
			}

			// Token: 0x17001B38 RID: 6968
			// (get) Token: 0x0600656C RID: 25964 RVA: 0x001E8F94 File Offset: 0x001E7194
			// (set) Token: 0x0600656D RID: 25965 RVA: 0x0002765E File Offset: 0x0002585E
			public unsafe WormSpace _controlledSpace_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._DetermineConflict_d__6.NativeFieldInfoPtr__controlledSpace_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateConflictPhase._DetermineConflict_d__6.NativeFieldInfoPtr__controlledSpace_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004194 RID: 16788
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004195 RID: 16789
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004196 RID: 16790
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004197 RID: 16791
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004198 RID: 16792
			private static readonly IntPtr NativeFieldInfoPtr__board_5__2;

			// Token: 0x04004199 RID: 16793
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x0400419A RID: 16794
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x0400419B RID: 16795
			private static readonly IntPtr NativeFieldInfoPtr__controlledSpace_5__5;

			// Token: 0x0400419C RID: 16796
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400419D RID: 16797
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400419E RID: 16798
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400419F RID: 16799
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040041A0 RID: 16800
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040041A1 RID: 16801
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040041A2 RID: 16802
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040041A3 RID: 16803
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.context;
using Canis.entities;
using Canis.gameLogs;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.actions
{
	// Token: 0x02000235 RID: 565
	public class DeployUnits : global::Canis.actions.Action
	{
		// Token: 0x060018AF RID: 6319 RVA: 0x000B9038 File Offset: 0x000B7238
		// Note: this type is marked as 'beforefieldinit'.
		static DeployUnits()
		{
			Il2CppClassPointerStore<DeployUnits>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "DeployUnits");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeployUnits>.NativeClassPtr);
			DeployUnits.NativeFieldInfoPtr_unitsToMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits>.NativeClassPtr, "unitsToMove");
			DeployUnits.NativeFieldInfoPtr_skipUnitsGainedUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits>.NativeClassPtr, "skipUnitsGainedUpdate");
			DeployUnits.NativeFieldInfoPtr__LogMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits>.NativeClassPtr, "<LogMode>k__BackingField");
			DeployUnits.NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits>.NativeClassPtr, 100667623);
			DeployUnits.NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits>.NativeClassPtr, 100667624);
			DeployUnits.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_WormUnit_Match_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits>.NativeClassPtr, 100667625);
			DeployUnits.NativeMethodInfoPtr__ctor_Public_Void_SerializedDeployUnits_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits>.NativeClassPtr, 100667626);
			DeployUnits.NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits>.NativeClassPtr, 100667627);
			DeployUnits.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits>.NativeClassPtr, 100667628);
			DeployUnits.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits>.NativeClassPtr, 100667629);
			DeployUnits.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits>.NativeClassPtr, 100667630);
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x060018B0 RID: 6320 RVA: 0x000B9144 File Offset: 0x000B7344
		// (set) Token: 0x060018B1 RID: 6321 RVA: 0x000B9180 File Offset: 0x000B7380
		public unsafe virtual ActionLogModes LogMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 134006, RefRangeEnd = 134007, XrefRangeStart = 134006, XrefRangeEnd = 134006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits.NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits.NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x000B91C0 File Offset: 0x000B73C0
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 134012, RefRangeEnd = 134028, XrefRangeStart = 134007, XrefRangeEnd = 134012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeployUnits(IEnumerable<WormUnit> unitsToMove, Match m, bool skipUnitsGainedUpdate = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeployUnits>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unitsToMove);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipUnitsGainedUpdate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_WormUnit_Match_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x000B922C File Offset: 0x000B742C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 134053, RefRangeEnd = 134055, XrefRangeStart = 134028, XrefRangeEnd = 134053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeployUnits(SerializedDeployUnits serialized, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeployUnits>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits.NativeMethodInfoPtr__ctor_Public_Void_SerializedDeployUnits_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x000B928C File Offset: 0x000B748C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134055, XrefRangeEnd = 134063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<ValueTuple<string, Object>> MakeAnalyticsData(WormMatch wormMatch, WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits.NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<string, Object>>>(intPtr3) : null;
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x000B92F0 File Offset: 0x000B74F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134063, XrefRangeEnd = 134069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeployUnits.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x000B933C File Offset: 0x000B753C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134069, XrefRangeEnd = 134076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> undo(Context undoContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeployUnits.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x000B9398 File Offset: 0x000B7598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134076, XrefRangeEnd = 134102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeployUnits.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x0000AA2B File Offset: 0x00008C2B
		public DeployUnits(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x060018B9 RID: 6329 RVA: 0x000B93F4 File Offset: 0x000B75F4
		// (set) Token: 0x060018BA RID: 6330 RVA: 0x0000AA34 File Offset: 0x00008C34
		public unsafe Il2CppReferenceArray<WormUnit> unitsToMove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits.NativeFieldInfoPtr_unitsToMove);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WormUnit>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits.NativeFieldInfoPtr_unitsToMove), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x060018BB RID: 6331 RVA: 0x000B9424 File Offset: 0x000B7624
		// (set) Token: 0x060018BC RID: 6332 RVA: 0x0000AA53 File Offset: 0x00008C53
		public unsafe bool skipUnitsGainedUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits.NativeFieldInfoPtr_skipUnitsGainedUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits.NativeFieldInfoPtr_skipUnitsGainedUpdate)) = value;
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x060018BD RID: 6333 RVA: 0x000B944C File Offset: 0x000B764C
		// (set) Token: 0x060018BE RID: 6334 RVA: 0x0000AA6E File Offset: 0x00008C6E
		public unsafe ActionLogModes _LogMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits.NativeFieldInfoPtr__LogMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits.NativeFieldInfoPtr__LogMode_k__BackingField)) = value;
			}
		}

		// Token: 0x04000F44 RID: 3908
		private static readonly IntPtr NativeFieldInfoPtr_unitsToMove;

		// Token: 0x04000F45 RID: 3909
		private static readonly IntPtr NativeFieldInfoPtr_skipUnitsGainedUpdate;

		// Token: 0x04000F46 RID: 3910
		private static readonly IntPtr NativeFieldInfoPtr__LogMode_k__BackingField;

		// Token: 0x04000F47 RID: 3911
		private static readonly IntPtr NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0;

		// Token: 0x04000F48 RID: 3912
		private static readonly IntPtr NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0;

		// Token: 0x04000F49 RID: 3913
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_WormUnit_Match_Boolean_0;

		// Token: 0x04000F4A RID: 3914
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedDeployUnits_Match_0;

		// Token: 0x04000F4B RID: 3915
		private static readonly IntPtr NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_0;

		// Token: 0x04000F4C RID: 3916
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04000F4D RID: 3917
		private static readonly IntPtr NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0;

		// Token: 0x04000F4E RID: 3918
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x0200066B RID: 1643
		[ObfuscatedName("worm.canis.actions.DeployUnits+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060053CF RID: 21455 RVA: 0x001B4A54 File Offset: 0x001B2C54
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DeployUnits.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeployUnits>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeployUnits.__c>.NativeClassPtr);
				DeployUnits.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits.__c>.NativeClassPtr, "<>9");
				DeployUnits.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits.__c>.NativeClassPtr, "<>9__8_0");
				DeployUnits.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits.__c>.NativeClassPtr, "<>9__8_1");
				DeployUnits.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits.__c>.NativeClassPtr, "<>9__9_0");
				DeployUnits.__c.NativeFieldInfoPtr___9__9_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits.__c>.NativeClassPtr, "<>9__9_1");
				DeployUnits.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits.__c>.NativeClassPtr, "<>9__11_0");
				DeployUnits.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits.__c>.NativeClassPtr, 100667632);
				DeployUnits.__c.NativeMethodInfoPtr__MakeAnalyticsData_b__8_0_Internal_Int32_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits.__c>.NativeClassPtr, 100667633);
				DeployUnits.__c.NativeMethodInfoPtr__MakeAnalyticsData_b__8_1_Internal_Int32_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits.__c>.NativeClassPtr, 100667634);
				DeployUnits.__c.NativeMethodInfoPtr__execute_b__9_0_Internal_EntityID_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits.__c>.NativeClassPtr, 100667635);
				DeployUnits.__c.NativeMethodInfoPtr__execute_b__9_1_Internal_Int32_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits.__c>.NativeClassPtr, 100667636);
				DeployUnits.__c.NativeMethodInfoPtr__MakeSerializedAction_b__11_0_Internal_EntityID_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits.__c>.NativeClassPtr, 100667637);
			}

			// Token: 0x060053D0 RID: 21456 RVA: 0x001B4B70 File Offset: 0x001B2D70
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeployUnits.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053D1 RID: 21457 RVA: 0x001B4BAC File Offset: 0x001B2DAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _MakeAnalyticsData_b__8_0(WormUnit wt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(wt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits.__c.NativeMethodInfoPtr__MakeAnalyticsData_b__8_0_Internal_Int32_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060053D2 RID: 21458 RVA: 0x001B4BFC File Offset: 0x001B2DFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _MakeAnalyticsData_b__8_1(WormUnit wt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(wt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits.__c.NativeMethodInfoPtr__MakeAnalyticsData_b__8_1_Internal_Int32_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060053D3 RID: 21459 RVA: 0x001B4C4C File Offset: 0x001B2E4C
			[CallerCount(0)]
			public unsafe EntityID _execute_b__9_0(WormUnit _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits.__c.NativeMethodInfoPtr__execute_b__9_0_Internal_EntityID_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x060053D4 RID: 21460 RVA: 0x001B4C9C File Offset: 0x001B2E9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _execute_b__9_1(WormUnit wt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(wt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits.__c.NativeMethodInfoPtr__execute_b__9_1_Internal_Int32_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060053D5 RID: 21461 RVA: 0x001B4CEC File Offset: 0x001B2EEC
			[CallerCount(0)]
			public unsafe EntityID _MakeSerializedAction_b__11_0(WormUnit _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits.__c.NativeMethodInfoPtr__MakeSerializedAction_b__11_0_Internal_EntityID_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x060053D6 RID: 21462 RVA: 0x0001D708 File Offset: 0x0001B908
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014DD RID: 5341
			// (get) Token: 0x060053D7 RID: 21463 RVA: 0x001B4D3C File Offset: 0x001B2F3C
			// (set) Token: 0x060053D8 RID: 21464 RVA: 0x0001D711 File Offset: 0x0001B911
			public unsafe static DeployUnits.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DeployUnits.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeployUnits.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeployUnits.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014DE RID: 5342
			// (get) Token: 0x060053D9 RID: 21465 RVA: 0x001B4D64 File Offset: 0x001B2F64
			// (set) Token: 0x060053DA RID: 21466 RVA: 0x0001D723 File Offset: 0x0001B923
			public unsafe static Func<WormUnit, int> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DeployUnits.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormUnit, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeployUnits.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014DF RID: 5343
			// (get) Token: 0x060053DB RID: 21467 RVA: 0x001B4D8C File Offset: 0x001B2F8C
			// (set) Token: 0x060053DC RID: 21468 RVA: 0x0001D735 File Offset: 0x0001B935
			public unsafe static Func<WormUnit, int> __9__8_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DeployUnits.__c.NativeFieldInfoPtr___9__8_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormUnit, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeployUnits.__c.NativeFieldInfoPtr___9__8_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014E0 RID: 5344
			// (get) Token: 0x060053DD RID: 21469 RVA: 0x001B4DB4 File Offset: 0x001B2FB4
			// (set) Token: 0x060053DE RID: 21470 RVA: 0x0001D747 File Offset: 0x0001B947
			public unsafe static Func<WormUnit, EntityID> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DeployUnits.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormUnit, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeployUnits.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014E1 RID: 5345
			// (get) Token: 0x060053DF RID: 21471 RVA: 0x001B4DDC File Offset: 0x001B2FDC
			// (set) Token: 0x060053E0 RID: 21472 RVA: 0x0001D759 File Offset: 0x0001B959
			public unsafe static Func<WormUnit, int> __9__9_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DeployUnits.__c.NativeFieldInfoPtr___9__9_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormUnit, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeployUnits.__c.NativeFieldInfoPtr___9__9_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014E2 RID: 5346
			// (get) Token: 0x060053E1 RID: 21473 RVA: 0x001B4E04 File Offset: 0x001B3004
			// (set) Token: 0x060053E2 RID: 21474 RVA: 0x0001D76B File Offset: 0x0001B96B
			public unsafe static Func<WormUnit, EntityID> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DeployUnits.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormUnit, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeployUnits.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040036D7 RID: 14039
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040036D8 RID: 14040
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x040036D9 RID: 14041
			private static readonly IntPtr NativeFieldInfoPtr___9__8_1;

			// Token: 0x040036DA RID: 14042
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x040036DB RID: 14043
			private static readonly IntPtr NativeFieldInfoPtr___9__9_1;

			// Token: 0x040036DC RID: 14044
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x040036DD RID: 14045
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040036DE RID: 14046
			private static readonly IntPtr NativeMethodInfoPtr__MakeAnalyticsData_b__8_0_Internal_Int32_WormUnit_0;

			// Token: 0x040036DF RID: 14047
			private static readonly IntPtr NativeMethodInfoPtr__MakeAnalyticsData_b__8_1_Internal_Int32_WormUnit_0;

			// Token: 0x040036E0 RID: 14048
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__9_0_Internal_EntityID_WormUnit_0;

			// Token: 0x040036E1 RID: 14049
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__9_1_Internal_Int32_WormUnit_0;

			// Token: 0x040036E2 RID: 14050
			private static readonly IntPtr NativeMethodInfoPtr__MakeSerializedAction_b__11_0_Internal_EntityID_WormUnit_0;
		}

		// Token: 0x0200066C RID: 1644
		[ObfuscatedName("worm.canis.actions.DeployUnits+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x060053E3 RID: 21475 RVA: 0x001B4E2C File Offset: 0x001B302C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<DeployUnits.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeployUnits>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeployUnits.__c__DisplayClass7_0>.NativeClassPtr);
				DeployUnits.__c__DisplayClass7_0.NativeFieldInfoPtr_m = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits.__c__DisplayClass7_0>.NativeClassPtr, "m");
				DeployUnits.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits.__c__DisplayClass7_0>.NativeClassPtr, 100667638);
				DeployUnits.__c__DisplayClass7_0.NativeMethodInfoPtr___ctor_b__0_Internal_IEnumerable_1_WormUnit_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits.__c__DisplayClass7_0>.NativeClassPtr, 100667639);
			}

			// Token: 0x060053E4 RID: 21476 RVA: 0x001B4E94 File Offset: 0x001B3094
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeployUnits.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053E5 RID: 21477 RVA: 0x001B4ED0 File Offset: 0x001B30D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133168, XrefRangeEnd = 133178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<WormUnit> __ctor_b__0(EntityID id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits.__c__DisplayClass7_0.NativeMethodInfoPtr___ctor_b__0_Internal_IEnumerable_1_WormUnit_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormUnit>>(intPtr3) : null;
				}
			}

			// Token: 0x060053E6 RID: 21478 RVA: 0x0001D77D File Offset: 0x0001B97D
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014E3 RID: 5347
			// (get) Token: 0x060053E7 RID: 21479 RVA: 0x001B4F20 File Offset: 0x001B3120
			// (set) Token: 0x060053E8 RID: 21480 RVA: 0x0001D786 File Offset: 0x0001B986
			public unsafe Match m
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits.__c__DisplayClass7_0.NativeFieldInfoPtr_m);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits.__c__DisplayClass7_0.NativeFieldInfoPtr_m), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040036E3 RID: 14051
			private static readonly IntPtr NativeFieldInfoPtr_m;

			// Token: 0x040036E4 RID: 14052
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040036E5 RID: 14053
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_Internal_IEnumerable_1_WormUnit_EntityID_0;
		}

		// Token: 0x0200066D RID: 1645
		[ObfuscatedName("worm.canis.actions.DeployUnits+<MakeAnalyticsData>d__8")]
		public sealed class _MakeAnalyticsData_d__8 : Object
		{
			// Token: 0x060053E9 RID: 21481 RVA: 0x001B4F50 File Offset: 0x001B3150
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeAnalyticsData_d__8()
			{
				Il2CppClassPointerStore<DeployUnits._MakeAnalyticsData_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeployUnits>.NativeClassPtr, "<MakeAnalyticsData>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeployUnits._MakeAnalyticsData_d__8>.NativeClassPtr);
				DeployUnits._MakeAnalyticsData_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._MakeAnalyticsData_d__8>.NativeClassPtr, "<>1__state");
				DeployUnits._MakeAnalyticsData_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._MakeAnalyticsData_d__8>.NativeClassPtr, "<>2__current");
				DeployUnits._MakeAnalyticsData_d__8.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._MakeAnalyticsData_d__8>.NativeClassPtr, "<>l__initialThreadId");
				DeployUnits._MakeAnalyticsData_d__8.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._MakeAnalyticsData_d__8>.NativeClassPtr, "wormMatch");
				DeployUnits._MakeAnalyticsData_d__8.NativeFieldInfoPtr___3__wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._MakeAnalyticsData_d__8>.NativeClassPtr, "<>3__wormMatch");
				DeployUnits._MakeAnalyticsData_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._MakeAnalyticsData_d__8>.NativeClassPtr, "<>4__this");
				DeployUnits._MakeAnalyticsData_d__8.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._MakeAnalyticsData_d__8>.NativeClassPtr, "player");
				DeployUnits._MakeAnalyticsData_d__8.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._MakeAnalyticsData_d__8>.NativeClassPtr, "<>3__player");
				DeployUnits._MakeAnalyticsData_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits._MakeAnalyticsData_d__8>.NativeClassPtr, 100667640);
				DeployUnits._MakeAnalyticsData_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits._MakeAnalyticsData_d__8>.NativeClassPtr, 100667641);
				DeployUnits._MakeAnalyticsData_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits._MakeAnalyticsData_d__8>.NativeClassPtr, 100667642);
				DeployUnits._MakeAnalyticsData_d__8.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits._MakeAnalyticsData_d__8>.NativeClassPtr, 100667643);
				DeployUnits._MakeAnalyticsData_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits._MakeAnalyticsData_d__8>.NativeClassPtr, 100667644);
				DeployUnits._MakeAnalyticsData_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits._MakeAnalyticsData_d__8>.NativeClassPtr, 100667645);
				DeployUnits._MakeAnalyticsData_d__8.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits._MakeAnalyticsData_d__8>.NativeClassPtr, 100667646);
				DeployUnits._MakeAnalyticsData_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits._MakeAnalyticsData_d__8>.NativeClassPtr, 100667647);
			}

			// Token: 0x060053EA RID: 21482 RVA: 0x001B50BC File Offset: 0x001B32BC
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MakeAnalyticsData_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeployUnits._MakeAnalyticsData_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits._MakeAnalyticsData_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060053EB RID: 21483 RVA: 0x001B5104 File Offset: 0x001B3304
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits._MakeAnalyticsData_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053EC RID: 21484 RVA: 0x001B5138 File Offset: 0x001B3338
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133178, XrefRangeEnd = 133295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits._MakeAnalyticsData_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170014EC RID: 5356
			// (get) Token: 0x060053ED RID: 21485 RVA: 0x001B5174 File Offset: 0x001B3374
			public unsafe ValueTuple<string, Object> prop_ValueTuple_2_String_Object_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits._MakeAnalyticsData_d__8.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<string, Object>(intPtr);
				}
			}

			// Token: 0x060053EE RID: 21486 RVA: 0x001B51AC File Offset: 0x001B33AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133295, XrefRangeEnd = 133300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits._MakeAnalyticsData_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170014ED RID: 5357
			// (get) Token: 0x060053EF RID: 21487 RVA: 0x001B51E0 File Offset: 0x001B33E0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133300, XrefRangeEnd = 133303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits._MakeAnalyticsData_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060053F0 RID: 21488 RVA: 0x001B5220 File Offset: 0x001B3420
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133303, XrefRangeEnd = 133313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<string, Object>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits._MakeAnalyticsData_d__8.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<string, Object>>>(intPtr3) : null;
			}

			// Token: 0x060053F1 RID: 21489 RVA: 0x001B5260 File Offset: 0x001B3460
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits._MakeAnalyticsData_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060053F2 RID: 21490 RVA: 0x0001D7A5 File Offset: 0x0001B9A5
			public _MakeAnalyticsData_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014E4 RID: 5348
			// (get) Token: 0x060053F3 RID: 21491 RVA: 0x001B52A0 File Offset: 0x001B34A0
			// (set) Token: 0x060053F4 RID: 21492 RVA: 0x0001D7AE File Offset: 0x0001B9AE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._MakeAnalyticsData_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._MakeAnalyticsData_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170014E5 RID: 5349
			// (get) Token: 0x060053F5 RID: 21493 RVA: 0x001B52C8 File Offset: 0x001B34C8
			// (set) Token: 0x060053F6 RID: 21494 RVA: 0x0001D7C9 File Offset: 0x0001B9C9
			public ValueTuple<string, Object> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._MakeAnalyticsData_d__8.NativeFieldInfoPtr___2__current);
					return new ValueTuple<string, Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._MakeAnalyticsData_d__8.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170014E6 RID: 5350
			// (get) Token: 0x060053F7 RID: 21495 RVA: 0x001B52F8 File Offset: 0x001B34F8
			// (set) Token: 0x060053F8 RID: 21496 RVA: 0x0001D7F7 File Offset: 0x0001B9F7
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._MakeAnalyticsData_d__8.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._MakeAnalyticsData_d__8.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170014E7 RID: 5351
			// (get) Token: 0x060053F9 RID: 21497 RVA: 0x001B5320 File Offset: 0x001B3520
			// (set) Token: 0x060053FA RID: 21498 RVA: 0x0001D812 File Offset: 0x0001BA12
			public unsafe WormMatch wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._MakeAnalyticsData_d__8.NativeFieldInfoPtr_wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._MakeAnalyticsData_d__8.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014E8 RID: 5352
			// (get) Token: 0x060053FB RID: 21499 RVA: 0x001B5350 File Offset: 0x001B3550
			// (set) Token: 0x060053FC RID: 21500 RVA: 0x0001D831 File Offset: 0x0001BA31
			public unsafe WormMatch __3__wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._MakeAnalyticsData_d__8.NativeFieldInfoPtr___3__wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._MakeAnalyticsData_d__8.NativeFieldInfoPtr___3__wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014E9 RID: 5353
			// (get) Token: 0x060053FD RID: 21501 RVA: 0x001B5380 File Offset: 0x001B3580
			// (set) Token: 0x060053FE RID: 21502 RVA: 0x0001D850 File Offset: 0x0001BA50
			public unsafe DeployUnits __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._MakeAnalyticsData_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeployUnits>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._MakeAnalyticsData_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014EA RID: 5354
			// (get) Token: 0x060053FF RID: 21503 RVA: 0x001B53B0 File Offset: 0x001B35B0
			// (set) Token: 0x06005400 RID: 21504 RVA: 0x0001D86F File Offset: 0x0001BA6F
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._MakeAnalyticsData_d__8.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._MakeAnalyticsData_d__8.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014EB RID: 5355
			// (get) Token: 0x06005401 RID: 21505 RVA: 0x001B53E0 File Offset: 0x001B35E0
			// (set) Token: 0x06005402 RID: 21506 RVA: 0x0001D88E File Offset: 0x0001BA8E
			public unsafe WormPlayer __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._MakeAnalyticsData_d__8.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._MakeAnalyticsData_d__8.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040036E6 RID: 14054
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040036E7 RID: 14055
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040036E8 RID: 14056
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040036E9 RID: 14057
			private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

			// Token: 0x040036EA RID: 14058
			private static readonly IntPtr NativeFieldInfoPtr___3__wormMatch;

			// Token: 0x040036EB RID: 14059
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040036EC RID: 14060
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040036ED RID: 14061
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x040036EE RID: 14062
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040036EF RID: 14063
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040036F0 RID: 14064
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040036F1 RID: 14065
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0;

			// Token: 0x040036F2 RID: 14066
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040036F3 RID: 14067
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040036F4 RID: 14068
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0;

			// Token: 0x040036F5 RID: 14069
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200066E RID: 1646
		[ObfuscatedName("worm.canis.actions.DeployUnits+<execute>d__9")]
		public sealed class _execute_d__9 : Object
		{
			// Token: 0x06005403 RID: 21507 RVA: 0x001B5410 File Offset: 0x001B3610
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__9()
			{
				Il2CppClassPointerStore<DeployUnits._execute_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeployUnits>.NativeClassPtr, "<execute>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeployUnits._execute_d__9>.NativeClassPtr);
				DeployUnits._execute_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._execute_d__9>.NativeClassPtr, "<>1__state");
				DeployUnits._execute_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._execute_d__9>.NativeClassPtr, "<>2__current");
				DeployUnits._execute_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._execute_d__9>.NativeClassPtr, "<>l__initialThreadId");
				DeployUnits._execute_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._execute_d__9>.NativeClassPtr, "<>4__this");
				DeployUnits._execute_d__9.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._execute_d__9>.NativeClassPtr, "<player>5__2");
				DeployUnits._execute_d__9.NativeFieldInfoPtr__wm_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._execute_d__9>.NativeClassPtr, "<wm>5__3");
				DeployUnits._execute_d__9.NativeFieldInfoPtr__childUndo_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._execute_d__9>.NativeClassPtr, "<childUndo>5__4");
				DeployUnits._execute_d__9.NativeFieldInfoPtr__amountToMove_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._execute_d__9>.NativeClassPtr, "<amountToMove>5__5");
				DeployUnits._execute_d__9.NativeFieldInfoPtr__troopCount_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._execute_d__9>.NativeClassPtr, "<troopCount>5__6");
				DeployUnits._execute_d__9.NativeFieldInfoPtr__dreadnoughtCount_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._execute_d__9>.NativeClassPtr, "<dreadnoughtCount>5__7");
				DeployUnits._execute_d__9.NativeFieldInfoPtr__deploymentZone_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._execute_d__9>.NativeClassPtr, "<deploymentZone>5__8");
				DeployUnits._execute_d__9.NativeFieldInfoPtr__fromZone_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._execute_d__9>.NativeClassPtr, "<fromZone>5__9");
				DeployUnits._execute_d__9.NativeFieldInfoPtr__logBuilder_5__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._execute_d__9>.NativeClassPtr, "<logBuilder>5__10");
				DeployUnits._execute_d__9.NativeFieldInfoPtr__possibleStrength_5__11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._execute_d__9>.NativeClassPtr, "<possibleStrength>5__11");
				DeployUnits._execute_d__9.NativeFieldInfoPtr__totalStrength_5__12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._execute_d__9>.NativeClassPtr, "<totalStrength>5__12");
				DeployUnits._execute_d__9.NativeFieldInfoPtr__troopDeployNumber_5__13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._execute_d__9>.NativeClassPtr, "<troopDeployNumber>5__13");
				DeployUnits._execute_d__9.NativeFieldInfoPtr__dreadnoughtDeployNumber_5__14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._execute_d__9>.NativeClassPtr, "<dreadnoughtDeployNumber>5__14");
				DeployUnits._execute_d__9.NativeFieldInfoPtr__baseDeployableUnits_5__15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._execute_d__9>.NativeClassPtr, "<baseDeployableUnits>5__15");
				DeployUnits._execute_d__9.NativeFieldInfoPtr__shippingTroopsDeployed_5__16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._execute_d__9>.NativeClassPtr, "<shippingTroopsDeployed>5__16");
				DeployUnits._execute_d__9.NativeFieldInfoPtr___7__wrap16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._execute_d__9>.NativeClassPtr, "<>7__wrap16");
				DeployUnits._execute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits._execute_d__9>.NativeClassPtr, 100667648);
				DeployUnits._execute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits._execute_d__9>.NativeClassPtr, 100667649);
				DeployUnits._execute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits._execute_d__9>.NativeClassPtr, 100667650);
				DeployUnits._execute_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits._execute_d__9>.NativeClassPtr, 100667651);
				DeployUnits._execute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits._execute_d__9>.NativeClassPtr, 100667652);
				DeployUnits._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits._execute_d__9>.NativeClassPtr, 100667653);
				DeployUnits._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits._execute_d__9>.NativeClassPtr, 100667654);
				DeployUnits._execute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits._execute_d__9>.NativeClassPtr, 100667655);
				DeployUnits._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits._execute_d__9>.NativeClassPtr, 100667656);
			}

			// Token: 0x06005404 RID: 21508 RVA: 0x001B5680 File Offset: 0x001B3880
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeployUnits._execute_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits._execute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005405 RID: 21509 RVA: 0x001B56C8 File Offset: 0x001B38C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133313, XrefRangeEnd = 133316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits._execute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005406 RID: 21510 RVA: 0x001B56FC File Offset: 0x001B38FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133316, XrefRangeEnd = 133726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits._execute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005407 RID: 21511 RVA: 0x001B5738 File Offset: 0x001B3938
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 133729, RefRangeEnd = 133730, XrefRangeStart = 133726, XrefRangeEnd = 133729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits._execute_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001502 RID: 5378
			// (get) Token: 0x06005408 RID: 21512 RVA: 0x001B576C File Offset: 0x001B396C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits._execute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005409 RID: 21513 RVA: 0x001B57AC File Offset: 0x001B39AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133730, XrefRangeEnd = 133735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001503 RID: 5379
			// (get) Token: 0x0600540A RID: 21514 RVA: 0x001B57E0 File Offset: 0x001B39E0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600540B RID: 21515 RVA: 0x001B5820 File Offset: 0x001B3A20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133735, XrefRangeEnd = 133737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits._execute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600540C RID: 21516 RVA: 0x001B5860 File Offset: 0x001B3A60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600540D RID: 21517 RVA: 0x0001D8AD File Offset: 0x0001BAAD
			public _execute_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014EE RID: 5358
			// (get) Token: 0x0600540E RID: 21518 RVA: 0x001B58A0 File Offset: 0x001B3AA0
			// (set) Token: 0x0600540F RID: 21519 RVA: 0x0001D8B6 File Offset: 0x0001BAB6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170014EF RID: 5359
			// (get) Token: 0x06005410 RID: 21520 RVA: 0x001B58C8 File Offset: 0x001B3AC8
			// (set) Token: 0x06005411 RID: 21521 RVA: 0x0001D8D1 File Offset: 0x0001BAD1
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014F0 RID: 5360
			// (get) Token: 0x06005412 RID: 21522 RVA: 0x001B58F8 File Offset: 0x001B3AF8
			// (set) Token: 0x06005413 RID: 21523 RVA: 0x0001D8F0 File Offset: 0x0001BAF0
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170014F1 RID: 5361
			// (get) Token: 0x06005414 RID: 21524 RVA: 0x001B5920 File Offset: 0x001B3B20
			// (set) Token: 0x06005415 RID: 21525 RVA: 0x0001D90B File Offset: 0x0001BB0B
			public unsafe DeployUnits __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeployUnits>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014F2 RID: 5362
			// (get) Token: 0x06005416 RID: 21526 RVA: 0x001B5950 File Offset: 0x001B3B50
			// (set) Token: 0x06005417 RID: 21527 RVA: 0x0001D92A File Offset: 0x0001BB2A
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014F3 RID: 5363
			// (get) Token: 0x06005418 RID: 21528 RVA: 0x001B5980 File Offset: 0x001B3B80
			// (set) Token: 0x06005419 RID: 21529 RVA: 0x0001D949 File Offset: 0x0001BB49
			public unsafe WormMatch _wm_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr__wm_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr__wm_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014F4 RID: 5364
			// (get) Token: 0x0600541A RID: 21530 RVA: 0x001B59B0 File Offset: 0x001B3BB0
			// (set) Token: 0x0600541B RID: 21531 RVA: 0x0001D968 File Offset: 0x0001BB68
			public unsafe UndoNode _childUndo_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr__childUndo_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr__childUndo_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014F5 RID: 5365
			// (get) Token: 0x0600541C RID: 21532 RVA: 0x001B59E0 File Offset: 0x001B3BE0
			// (set) Token: 0x0600541D RID: 21533 RVA: 0x0001D987 File Offset: 0x0001BB87
			public unsafe int _amountToMove_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr__amountToMove_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr__amountToMove_5__5)) = value;
				}
			}

			// Token: 0x170014F6 RID: 5366
			// (get) Token: 0x0600541E RID: 21534 RVA: 0x001B5A08 File Offset: 0x001B3C08
			// (set) Token: 0x0600541F RID: 21535 RVA: 0x0001D9A2 File Offset: 0x0001BBA2
			public unsafe int _troopCount_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr__troopCount_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr__troopCount_5__6)) = value;
				}
			}

			// Token: 0x170014F7 RID: 5367
			// (get) Token: 0x06005420 RID: 21536 RVA: 0x001B5A30 File Offset: 0x001B3C30
			// (set) Token: 0x06005421 RID: 21537 RVA: 0x0001D9BD File Offset: 0x0001BBBD
			public unsafe int _dreadnoughtCount_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr__dreadnoughtCount_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr__dreadnoughtCount_5__7)) = value;
				}
			}

			// Token: 0x170014F8 RID: 5368
			// (get) Token: 0x06005422 RID: 21538 RVA: 0x001B5A58 File Offset: 0x001B3C58
			// (set) Token: 0x06005423 RID: 21539 RVA: 0x0001D9D8 File Offset: 0x0001BBD8
			public unsafe WormPlayArea _deploymentZone_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr__deploymentZone_5__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr__deploymentZone_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014F9 RID: 5369
			// (get) Token: 0x06005424 RID: 21540 RVA: 0x001B5A88 File Offset: 0x001B3C88
			// (set) Token: 0x06005425 RID: 21541 RVA: 0x0001D9F7 File Offset: 0x0001BBF7
			public unsafe Entity _fromZone_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr__fromZone_5__9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr__fromZone_5__9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014FA RID: 5370
			// (get) Token: 0x06005426 RID: 21542 RVA: 0x001B5AB8 File Offset: 0x001B3CB8
			// (set) Token: 0x06005427 RID: 21543 RVA: 0x0001DA16 File Offset: 0x0001BC16
			public unsafe GameLogBuilder _logBuilder_5__10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr__logBuilder_5__10);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr__logBuilder_5__10), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014FB RID: 5371
			// (get) Token: 0x06005428 RID: 21544 RVA: 0x001B5AE8 File Offset: 0x001B3CE8
			// (set) Token: 0x06005429 RID: 21545 RVA: 0x0001DA35 File Offset: 0x0001BC35
			public unsafe int _possibleStrength_5__11
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr__possibleStrength_5__11);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr__possibleStrength_5__11)) = value;
				}
			}

			// Token: 0x170014FC RID: 5372
			// (get) Token: 0x0600542A RID: 21546 RVA: 0x001B5B10 File Offset: 0x001B3D10
			// (set) Token: 0x0600542B RID: 21547 RVA: 0x0001DA50 File Offset: 0x0001BC50
			public unsafe int _totalStrength_5__12
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr__totalStrength_5__12);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr__totalStrength_5__12)) = value;
				}
			}

			// Token: 0x170014FD RID: 5373
			// (get) Token: 0x0600542C RID: 21548 RVA: 0x001B5B38 File Offset: 0x001B3D38
			// (set) Token: 0x0600542D RID: 21549 RVA: 0x0001DA6B File Offset: 0x0001BC6B
			public unsafe int _troopDeployNumber_5__13
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr__troopDeployNumber_5__13);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr__troopDeployNumber_5__13)) = value;
				}
			}

			// Token: 0x170014FE RID: 5374
			// (get) Token: 0x0600542E RID: 21550 RVA: 0x001B5B60 File Offset: 0x001B3D60
			// (set) Token: 0x0600542F RID: 21551 RVA: 0x0001DA86 File Offset: 0x0001BC86
			public unsafe int _dreadnoughtDeployNumber_5__14
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr__dreadnoughtDeployNumber_5__14);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr__dreadnoughtDeployNumber_5__14)) = value;
				}
			}

			// Token: 0x170014FF RID: 5375
			// (get) Token: 0x06005430 RID: 21552 RVA: 0x001B5B88 File Offset: 0x001B3D88
			// (set) Token: 0x06005431 RID: 21553 RVA: 0x0001DAA1 File Offset: 0x0001BCA1
			public unsafe int _baseDeployableUnits_5__15
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr__baseDeployableUnits_5__15);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr__baseDeployableUnits_5__15)) = value;
				}
			}

			// Token: 0x17001500 RID: 5376
			// (get) Token: 0x06005432 RID: 21554 RVA: 0x001B5BB0 File Offset: 0x001B3DB0
			// (set) Token: 0x06005433 RID: 21555 RVA: 0x0001DABC File Offset: 0x0001BCBC
			public unsafe int _shippingTroopsDeployed_5__16
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr__shippingTroopsDeployed_5__16);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr__shippingTroopsDeployed_5__16)) = value;
				}
			}

			// Token: 0x17001501 RID: 5377
			// (get) Token: 0x06005434 RID: 21556 RVA: 0x001B5BD8 File Offset: 0x001B3DD8
			// (set) Token: 0x06005435 RID: 21557 RVA: 0x0001DAD7 File Offset: 0x0001BCD7
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap16
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr___7__wrap16);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._execute_d__9.NativeFieldInfoPtr___7__wrap16), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040036F6 RID: 14070
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040036F7 RID: 14071
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040036F8 RID: 14072
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040036F9 RID: 14073
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040036FA RID: 14074
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x040036FB RID: 14075
			private static readonly IntPtr NativeFieldInfoPtr__wm_5__3;

			// Token: 0x040036FC RID: 14076
			private static readonly IntPtr NativeFieldInfoPtr__childUndo_5__4;

			// Token: 0x040036FD RID: 14077
			private static readonly IntPtr NativeFieldInfoPtr__amountToMove_5__5;

			// Token: 0x040036FE RID: 14078
			private static readonly IntPtr NativeFieldInfoPtr__troopCount_5__6;

			// Token: 0x040036FF RID: 14079
			private static readonly IntPtr NativeFieldInfoPtr__dreadnoughtCount_5__7;

			// Token: 0x04003700 RID: 14080
			private static readonly IntPtr NativeFieldInfoPtr__deploymentZone_5__8;

			// Token: 0x04003701 RID: 14081
			private static readonly IntPtr NativeFieldInfoPtr__fromZone_5__9;

			// Token: 0x04003702 RID: 14082
			private static readonly IntPtr NativeFieldInfoPtr__logBuilder_5__10;

			// Token: 0x04003703 RID: 14083
			private static readonly IntPtr NativeFieldInfoPtr__possibleStrength_5__11;

			// Token: 0x04003704 RID: 14084
			private static readonly IntPtr NativeFieldInfoPtr__totalStrength_5__12;

			// Token: 0x04003705 RID: 14085
			private static readonly IntPtr NativeFieldInfoPtr__troopDeployNumber_5__13;

			// Token: 0x04003706 RID: 14086
			private static readonly IntPtr NativeFieldInfoPtr__dreadnoughtDeployNumber_5__14;

			// Token: 0x04003707 RID: 14087
			private static readonly IntPtr NativeFieldInfoPtr__baseDeployableUnits_5__15;

			// Token: 0x04003708 RID: 14088
			private static readonly IntPtr NativeFieldInfoPtr__shippingTroopsDeployed_5__16;

			// Token: 0x04003709 RID: 14089
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap16;

			// Token: 0x0400370A RID: 14090
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400370B RID: 14091
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400370C RID: 14092
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400370D RID: 14093
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400370E RID: 14094
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400370F RID: 14095
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003710 RID: 14096
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003711 RID: 14097
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003712 RID: 14098
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200066F RID: 1647
		[ObfuscatedName("worm.canis.actions.DeployUnits+<undo>d__10")]
		public sealed class _undo_d__10 : Object
		{
			// Token: 0x06005436 RID: 21558 RVA: 0x001B5C08 File Offset: 0x001B3E08
			// Note: this type is marked as 'beforefieldinit'.
			static _undo_d__10()
			{
				Il2CppClassPointerStore<DeployUnits._undo_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeployUnits>.NativeClassPtr, "<undo>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeployUnits._undo_d__10>.NativeClassPtr);
				DeployUnits._undo_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._undo_d__10>.NativeClassPtr, "<>1__state");
				DeployUnits._undo_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._undo_d__10>.NativeClassPtr, "<>2__current");
				DeployUnits._undo_d__10.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._undo_d__10>.NativeClassPtr, "<>l__initialThreadId");
				DeployUnits._undo_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._undo_d__10>.NativeClassPtr, "<>4__this");
				DeployUnits._undo_d__10.NativeFieldInfoPtr_undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._undo_d__10>.NativeClassPtr, "undoContext");
				DeployUnits._undo_d__10.NativeFieldInfoPtr___3__undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._undo_d__10>.NativeClassPtr, "<>3__undoContext");
				DeployUnits._undo_d__10.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._undo_d__10>.NativeClassPtr, "<player>5__2");
				DeployUnits._undo_d__10.NativeFieldInfoPtr__undoNode_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._undo_d__10>.NativeClassPtr, "<undoNode>5__3");
				DeployUnits._undo_d__10.NativeFieldInfoPtr__wm_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._undo_d__10>.NativeClassPtr, "<wm>5__4");
				DeployUnits._undo_d__10.NativeFieldInfoPtr__conflict_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._undo_d__10>.NativeClassPtr, "<conflict>5__5");
				DeployUnits._undo_d__10.NativeFieldInfoPtr__units_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._undo_d__10>.NativeClassPtr, "<units>5__6");
				DeployUnits._undo_d__10.NativeFieldInfoPtr__troopCount_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._undo_d__10>.NativeClassPtr, "<troopCount>5__7");
				DeployUnits._undo_d__10.NativeFieldInfoPtr__possibleStrengthBack_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._undo_d__10>.NativeClassPtr, "<possibleStrengthBack>5__8");
				DeployUnits._undo_d__10.NativeFieldInfoPtr__strengthToLose_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeployUnits._undo_d__10>.NativeClassPtr, "<strengthToLose>5__9");
				DeployUnits._undo_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits._undo_d__10>.NativeClassPtr, 100667657);
				DeployUnits._undo_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits._undo_d__10>.NativeClassPtr, 100667658);
				DeployUnits._undo_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits._undo_d__10>.NativeClassPtr, 100667659);
				DeployUnits._undo_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits._undo_d__10>.NativeClassPtr, 100667660);
				DeployUnits._undo_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits._undo_d__10>.NativeClassPtr, 100667661);
				DeployUnits._undo_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits._undo_d__10>.NativeClassPtr, 100667662);
				DeployUnits._undo_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits._undo_d__10>.NativeClassPtr, 100667663);
				DeployUnits._undo_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeployUnits._undo_d__10>.NativeClassPtr, 100667664);
			}

			// Token: 0x06005437 RID: 21559 RVA: 0x001B5DEC File Offset: 0x001B3FEC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _undo_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeployUnits._undo_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits._undo_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005438 RID: 21560 RVA: 0x001B5E34 File Offset: 0x001B4034
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits._undo_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005439 RID: 21561 RVA: 0x001B5E68 File Offset: 0x001B4068
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133737, XrefRangeEnd = 133992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits._undo_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001512 RID: 5394
			// (get) Token: 0x0600543A RID: 21562 RVA: 0x001B5EA4 File Offset: 0x001B40A4
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits._undo_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600543B RID: 21563 RVA: 0x001B5EE4 File Offset: 0x001B40E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133992, XrefRangeEnd = 133997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits._undo_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001513 RID: 5395
			// (get) Token: 0x0600543C RID: 21564 RVA: 0x001B5F18 File Offset: 0x001B4118
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits._undo_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600543D RID: 21565 RVA: 0x001B5F58 File Offset: 0x001B4158
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133997, XrefRangeEnd = 134006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits._undo_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600543E RID: 21566 RVA: 0x001B5F98 File Offset: 0x001B4198
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeployUnits._undo_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600543F RID: 21567 RVA: 0x0001DAF6 File Offset: 0x0001BCF6
			public _undo_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001504 RID: 5380
			// (get) Token: 0x06005440 RID: 21568 RVA: 0x001B5FD8 File Offset: 0x001B41D8
			// (set) Token: 0x06005441 RID: 21569 RVA: 0x0001DAFF File Offset: 0x0001BCFF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._undo_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._undo_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001505 RID: 5381
			// (get) Token: 0x06005442 RID: 21570 RVA: 0x001B6000 File Offset: 0x001B4200
			// (set) Token: 0x06005443 RID: 21571 RVA: 0x0001DB1A File Offset: 0x0001BD1A
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._undo_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._undo_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001506 RID: 5382
			// (get) Token: 0x06005444 RID: 21572 RVA: 0x001B6030 File Offset: 0x001B4230
			// (set) Token: 0x06005445 RID: 21573 RVA: 0x0001DB39 File Offset: 0x0001BD39
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._undo_d__10.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._undo_d__10.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001507 RID: 5383
			// (get) Token: 0x06005446 RID: 21574 RVA: 0x001B6058 File Offset: 0x001B4258
			// (set) Token: 0x06005447 RID: 21575 RVA: 0x0001DB54 File Offset: 0x0001BD54
			public unsafe DeployUnits __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._undo_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeployUnits>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._undo_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001508 RID: 5384
			// (get) Token: 0x06005448 RID: 21576 RVA: 0x001B6088 File Offset: 0x001B4288
			// (set) Token: 0x06005449 RID: 21577 RVA: 0x0001DB73 File Offset: 0x0001BD73
			public unsafe Context undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._undo_d__10.NativeFieldInfoPtr_undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._undo_d__10.NativeFieldInfoPtr_undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001509 RID: 5385
			// (get) Token: 0x0600544A RID: 21578 RVA: 0x001B60B8 File Offset: 0x001B42B8
			// (set) Token: 0x0600544B RID: 21579 RVA: 0x0001DB92 File Offset: 0x0001BD92
			public unsafe Context __3__undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._undo_d__10.NativeFieldInfoPtr___3__undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._undo_d__10.NativeFieldInfoPtr___3__undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700150A RID: 5386
			// (get) Token: 0x0600544C RID: 21580 RVA: 0x001B60E8 File Offset: 0x001B42E8
			// (set) Token: 0x0600544D RID: 21581 RVA: 0x0001DBB1 File Offset: 0x0001BDB1
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._undo_d__10.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._undo_d__10.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700150B RID: 5387
			// (get) Token: 0x0600544E RID: 21582 RVA: 0x001B6118 File Offset: 0x001B4318
			// (set) Token: 0x0600544F RID: 21583 RVA: 0x0001DBD0 File Offset: 0x0001BDD0
			public unsafe UndoNode _undoNode_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._undo_d__10.NativeFieldInfoPtr__undoNode_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._undo_d__10.NativeFieldInfoPtr__undoNode_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700150C RID: 5388
			// (get) Token: 0x06005450 RID: 21584 RVA: 0x001B6148 File Offset: 0x001B4348
			// (set) Token: 0x06005451 RID: 21585 RVA: 0x0001DBEF File Offset: 0x0001BDEF
			public unsafe WormMatch _wm_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._undo_d__10.NativeFieldInfoPtr__wm_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._undo_d__10.NativeFieldInfoPtr__wm_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700150D RID: 5389
			// (get) Token: 0x06005452 RID: 21586 RVA: 0x001B6178 File Offset: 0x001B4378
			// (set) Token: 0x06005453 RID: 21587 RVA: 0x0001DC0E File Offset: 0x0001BE0E
			public unsafe WormConflictArea _conflict_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._undo_d__10.NativeFieldInfoPtr__conflict_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormConflictArea>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._undo_d__10.NativeFieldInfoPtr__conflict_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700150E RID: 5390
			// (get) Token: 0x06005454 RID: 21588 RVA: 0x001B61A8 File Offset: 0x001B43A8
			// (set) Token: 0x06005455 RID: 21589 RVA: 0x0001DC2D File Offset: 0x0001BE2D
			public unsafe Il2CppReferenceArray<Entity> _units_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._undo_d__10.NativeFieldInfoPtr__units_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._undo_d__10.NativeFieldInfoPtr__units_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700150F RID: 5391
			// (get) Token: 0x06005456 RID: 21590 RVA: 0x001B61D8 File Offset: 0x001B43D8
			// (set) Token: 0x06005457 RID: 21591 RVA: 0x0001DC4C File Offset: 0x0001BE4C
			public unsafe int _troopCount_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._undo_d__10.NativeFieldInfoPtr__troopCount_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._undo_d__10.NativeFieldInfoPtr__troopCount_5__7)) = value;
				}
			}

			// Token: 0x17001510 RID: 5392
			// (get) Token: 0x06005458 RID: 21592 RVA: 0x001B6200 File Offset: 0x001B4400
			// (set) Token: 0x06005459 RID: 21593 RVA: 0x0001DC67 File Offset: 0x0001BE67
			public unsafe int _possibleStrengthBack_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._undo_d__10.NativeFieldInfoPtr__possibleStrengthBack_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._undo_d__10.NativeFieldInfoPtr__possibleStrengthBack_5__8)) = value;
				}
			}

			// Token: 0x17001511 RID: 5393
			// (get) Token: 0x0600545A RID: 21594 RVA: 0x001B6228 File Offset: 0x001B4428
			// (set) Token: 0x0600545B RID: 21595 RVA: 0x0001DC82 File Offset: 0x0001BE82
			public unsafe int _strengthToLose_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._undo_d__10.NativeFieldInfoPtr__strengthToLose_5__9);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeployUnits._undo_d__10.NativeFieldInfoPtr__strengthToLose_5__9)) = value;
				}
			}

			// Token: 0x04003713 RID: 14099
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003714 RID: 14100
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003715 RID: 14101
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003716 RID: 14102
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003717 RID: 14103
			private static readonly IntPtr NativeFieldInfoPtr_undoContext;

			// Token: 0x04003718 RID: 14104
			private static readonly IntPtr NativeFieldInfoPtr___3__undoContext;

			// Token: 0x04003719 RID: 14105
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x0400371A RID: 14106
			private static readonly IntPtr NativeFieldInfoPtr__undoNode_5__3;

			// Token: 0x0400371B RID: 14107
			private static readonly IntPtr NativeFieldInfoPtr__wm_5__4;

			// Token: 0x0400371C RID: 14108
			private static readonly IntPtr NativeFieldInfoPtr__conflict_5__5;

			// Token: 0x0400371D RID: 14109
			private static readonly IntPtr NativeFieldInfoPtr__units_5__6;

			// Token: 0x0400371E RID: 14110
			private static readonly IntPtr NativeFieldInfoPtr__troopCount_5__7;

			// Token: 0x0400371F RID: 14111
			private static readonly IntPtr NativeFieldInfoPtr__possibleStrengthBack_5__8;

			// Token: 0x04003720 RID: 14112
			private static readonly IntPtr NativeFieldInfoPtr__strengthToLose_5__9;

			// Token: 0x04003721 RID: 14113
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003722 RID: 14114
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003723 RID: 14115
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003724 RID: 14116
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003725 RID: 14117
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003726 RID: 14118
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003727 RID: 14119
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003728 RID: 14120
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

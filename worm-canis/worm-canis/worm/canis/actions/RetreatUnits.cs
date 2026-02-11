using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.context;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;
using Networking.selection.targetresponse;
using worm.canis.entities;

namespace worm.canis.actions
{
	// Token: 0x0200027E RID: 638
	public class RetreatUnits : global::Canis.actions.Action
	{
		// Token: 0x06001ACB RID: 6859 RVA: 0x000C0F4C File Offset: 0x000BF14C
		// Note: this type is marked as 'beforefieldinit'.
		static RetreatUnits()
		{
			Il2CppClassPointerStore<RetreatUnits>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "RetreatUnits");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RetreatUnits>.NativeClassPtr);
			RetreatUnits.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetreatUnits>.NativeClassPtr, "wormMatch");
			RetreatUnits.NativeFieldInfoPtr__LogMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetreatUnits>.NativeClassPtr, "<LogMode>k__BackingField");
			RetreatUnits.NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits>.NativeClassPtr, 100668493);
			RetreatUnits.NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits>.NativeClassPtr, 100668494);
			RetreatUnits.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits>.NativeClassPtr, 100668495);
			RetreatUnits.NativeMethodInfoPtr_GetPlayArea_Protected_Virtual_New_WormPlayArea_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits>.NativeClassPtr, 100668496);
			RetreatUnits.NativeMethodInfoPtr_get_GetLogToken_Protected_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits>.NativeClassPtr, 100668497);
			RetreatUnits.NativeMethodInfoPtr_ExtractUnits_Private_IEnumerable_1_WormUnit_EntityListTargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits>.NativeClassPtr, 100668498);
			RetreatUnits.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits>.NativeClassPtr, 100668499);
			RetreatUnits.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits>.NativeClassPtr, 100668500);
			RetreatUnits.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits>.NativeClassPtr, 100668501);
			RetreatUnits.NativeMethodInfoPtr__ExtractUnits_b__9_0_Private_IEnumerable_1_WormUnit_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits>.NativeClassPtr, 100668502);
			RetreatUnits.NativeMethodInfoPtr__execute_b__10_2_Private_ValueTuple_3_WormPlayer_WormPlayArea_Il2CppReferenceArray_1_Entity_IGrouping_2_WormPlayer_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits>.NativeClassPtr, 100668503);
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06001ACC RID: 6860 RVA: 0x000C1080 File Offset: 0x000BF280
		// (set) Token: 0x06001ACD RID: 6861 RVA: 0x000C10BC File Offset: 0x000BF2BC
		public unsafe virtual ActionLogModes LogMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetreatUnits.NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137951, RefRangeEnd = 137952, XrefRangeStart = 137951, XrefRangeEnd = 137952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetreatUnits.NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x000C10FC File Offset: 0x000BF2FC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 144460, RefRangeEnd = 144468, XrefRangeStart = 144458, XrefRangeEnd = 144460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RetreatUnits(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RetreatUnits>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetreatUnits.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x000C1148 File Offset: 0x000BF348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144468, XrefRangeEnd = 144471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual WormPlayArea GetPlayArea(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RetreatUnits.NativeMethodInfoPtr_GetPlayArea_Protected_Virtual_New_WormPlayArea_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06001AD0 RID: 6864 RVA: 0x000C11A4 File Offset: 0x000BF3A4
		public unsafe virtual string GetLogToken
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144471, XrefRangeEnd = 144473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RetreatUnits.NativeMethodInfoPtr_get_GetLogToken_Protected_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x000C11E8 File Offset: 0x000BF3E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 144483, RefRangeEnd = 144484, XrefRangeStart = 144473, XrefRangeEnd = 144483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<WormUnit> ExtractUnits(EntityListTargetResponse eltr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eltr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetreatUnits.NativeMethodInfoPtr_ExtractUnits_Private_IEnumerable_1_WormUnit_EntityListTargetResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormUnit>>(intPtr3) : null;
			}
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x000C1238 File Offset: 0x000BF438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144484, XrefRangeEnd = 144490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RetreatUnits.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x000C1284 File Offset: 0x000BF484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144490, XrefRangeEnd = 144496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> undo(Context undoContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RetreatUnits.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x000C12E0 File Offset: 0x000BF4E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144496, XrefRangeEnd = 144500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RetreatUnits.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x000C133C File Offset: 0x000BF53C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144500, XrefRangeEnd = 144510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<WormUnit> _ExtractUnits_b__9_0(EntityID id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetreatUnits.NativeMethodInfoPtr__ExtractUnits_b__9_0_Private_IEnumerable_1_WormUnit_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormUnit>>(intPtr3) : null;
			}
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x000C138C File Offset: 0x000BF58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144510, XrefRangeEnd = 144521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<WormPlayer, WormPlayArea, Il2CppReferenceArray<Entity>> _execute_b__10_2(IGrouping<WormPlayer, WormUnit> group)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetreatUnits.NativeMethodInfoPtr__execute_b__10_2_Private_ValueTuple_3_WormPlayer_WormPlayArea_Il2CppReferenceArray_1_Entity_IGrouping_2_WormPlayer_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<WormPlayer, WormPlayArea, Il2CppReferenceArray<Entity>>(intPtr);
			}
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x0000B84C File Offset: 0x00009A4C
		public RetreatUnits(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06001AD8 RID: 6872 RVA: 0x000C13D4 File Offset: 0x000BF5D4
		// (set) Token: 0x06001AD9 RID: 6873 RVA: 0x0000B855 File Offset: 0x00009A55
		public unsafe WormMatch wormMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits.NativeFieldInfoPtr_wormMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06001ADA RID: 6874 RVA: 0x000C1404 File Offset: 0x000BF604
		// (set) Token: 0x06001ADB RID: 6875 RVA: 0x0000B874 File Offset: 0x00009A74
		public unsafe ActionLogModes _LogMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits.NativeFieldInfoPtr__LogMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits.NativeFieldInfoPtr__LogMode_k__BackingField)) = value;
			}
		}

		// Token: 0x04001084 RID: 4228
		private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

		// Token: 0x04001085 RID: 4229
		private static readonly IntPtr NativeFieldInfoPtr__LogMode_k__BackingField;

		// Token: 0x04001086 RID: 4230
		private static readonly IntPtr NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0;

		// Token: 0x04001087 RID: 4231
		private static readonly IntPtr NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0;

		// Token: 0x04001088 RID: 4232
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04001089 RID: 4233
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayArea_Protected_Virtual_New_WormPlayArea_WormPlayer_0;

		// Token: 0x0400108A RID: 4234
		private static readonly IntPtr NativeMethodInfoPtr_get_GetLogToken_Protected_Virtual_New_get_String_0;

		// Token: 0x0400108B RID: 4235
		private static readonly IntPtr NativeMethodInfoPtr_ExtractUnits_Private_IEnumerable_1_WormUnit_EntityListTargetResponse_0;

		// Token: 0x0400108C RID: 4236
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x0400108D RID: 4237
		private static readonly IntPtr NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0;

		// Token: 0x0400108E RID: 4238
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x0400108F RID: 4239
		private static readonly IntPtr NativeMethodInfoPtr__ExtractUnits_b__9_0_Private_IEnumerable_1_WormUnit_EntityID_0;

		// Token: 0x04001090 RID: 4240
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__10_2_Private_ValueTuple_3_WormPlayer_WormPlayArea_Il2CppReferenceArray_1_Entity_IGrouping_2_WormPlayer_WormUnit_0;

		// Token: 0x020006C6 RID: 1734
		[ObfuscatedName("worm.canis.actions.RetreatUnits+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06005BBE RID: 23486 RVA: 0x001CBE00 File Offset: 0x001CA000
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RetreatUnits.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RetreatUnits>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RetreatUnits.__c>.NativeClassPtr);
				RetreatUnits.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetreatUnits.__c>.NativeClassPtr, "<>9");
				RetreatUnits.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetreatUnits.__c>.NativeClassPtr, "<>9__10_0");
				RetreatUnits.__c.NativeFieldInfoPtr___9__10_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetreatUnits.__c>.NativeClassPtr, "<>9__10_1");
				RetreatUnits.__c.NativeFieldInfoPtr___9__10_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetreatUnits.__c>.NativeClassPtr, "<>9__10_4");
				RetreatUnits.__c.NativeFieldInfoPtr___9__10_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetreatUnits.__c>.NativeClassPtr, "<>9__10_3");
				RetreatUnits.__c.NativeFieldInfoPtr___9__10_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetreatUnits.__c>.NativeClassPtr, "<>9__10_5");
				RetreatUnits.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits.__c>.NativeClassPtr, 100668505);
				RetreatUnits.__c.NativeMethodInfoPtr__execute_b__10_0_Internal_WormPlayer_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits.__c>.NativeClassPtr, 100668506);
				RetreatUnits.__c.NativeMethodInfoPtr__execute_b__10_1_Internal_Boolean_IGrouping_2_WormPlayer_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits.__c>.NativeClassPtr, 100668507);
				RetreatUnits.__c.NativeMethodInfoPtr__execute_b__10_3_Internal_IEnumerable_1_EntityID_ValueTuple_3_WormPlayer_WormPlayArea_Il2CppReferenceArray_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits.__c>.NativeClassPtr, 100668508);
				RetreatUnits.__c.NativeMethodInfoPtr__execute_b__10_4_Internal_EntityID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits.__c>.NativeClassPtr, 100668509);
				RetreatUnits.__c.NativeMethodInfoPtr__execute_b__10_5_Internal_Int32_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits.__c>.NativeClassPtr, 100668510);
			}

			// Token: 0x06005BBF RID: 23487 RVA: 0x001CBF1C File Offset: 0x001CA11C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RetreatUnits.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetreatUnits.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005BC0 RID: 23488 RVA: 0x001CBF58 File Offset: 0x001CA158
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143912, XrefRangeEnd = 143913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WormPlayer _execute_b__10_0(WormUnit troop)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(troop);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetreatUnits.__c.NativeMethodInfoPtr__execute_b__10_0_Internal_WormPlayer_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr3) : null;
				}
			}

			// Token: 0x06005BC1 RID: 23489 RVA: 0x001CBFA8 File Offset: 0x001CA1A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143913, XrefRangeEnd = 143916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__10_1(IGrouping<WormPlayer, WormUnit> group)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetreatUnits.__c.NativeMethodInfoPtr__execute_b__10_1_Internal_Boolean_IGrouping_2_WormPlayer_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005BC2 RID: 23490 RVA: 0x001CBFF8 File Offset: 0x001CA1F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143916, XrefRangeEnd = 143934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<EntityID> _execute_b__10_3(ValueTuple<WormPlayer, WormPlayArea, Il2CppReferenceArray<Entity>> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetreatUnits.__c.NativeMethodInfoPtr__execute_b__10_3_Internal_IEnumerable_1_EntityID_ValueTuple_3_WormPlayer_WormPlayArea_Il2CppReferenceArray_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<EntityID>>(intPtr3) : null;
				}
			}

			// Token: 0x06005BC3 RID: 23491 RVA: 0x001CC050 File Offset: 0x001CA250
			[CallerCount(0)]
			public unsafe EntityID _execute_b__10_4(Entity t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetreatUnits.__c.NativeMethodInfoPtr__execute_b__10_4_Internal_EntityID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x06005BC4 RID: 23492 RVA: 0x001CC0A0 File Offset: 0x001CA2A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _execute_b__10_5(WormUnit wt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(wt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetreatUnits.__c.NativeMethodInfoPtr__execute_b__10_5_Internal_Int32_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005BC5 RID: 23493 RVA: 0x0002208D File Offset: 0x0002028D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170017C8 RID: 6088
			// (get) Token: 0x06005BC6 RID: 23494 RVA: 0x001CC0F0 File Offset: 0x001CA2F0
			// (set) Token: 0x06005BC7 RID: 23495 RVA: 0x00022096 File Offset: 0x00020296
			public unsafe static RetreatUnits.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RetreatUnits.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RetreatUnits.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RetreatUnits.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017C9 RID: 6089
			// (get) Token: 0x06005BC8 RID: 23496 RVA: 0x001CC118 File Offset: 0x001CA318
			// (set) Token: 0x06005BC9 RID: 23497 RVA: 0x000220A8 File Offset: 0x000202A8
			public unsafe static Func<WormUnit, WormPlayer> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RetreatUnits.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormUnit, WormPlayer>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RetreatUnits.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017CA RID: 6090
			// (get) Token: 0x06005BCA RID: 23498 RVA: 0x001CC140 File Offset: 0x001CA340
			// (set) Token: 0x06005BCB RID: 23499 RVA: 0x000220BA File Offset: 0x000202BA
			public unsafe static Func<IGrouping<WormPlayer, WormUnit>, bool> __9__10_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RetreatUnits.__c.NativeFieldInfoPtr___9__10_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<WormPlayer, WormUnit>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RetreatUnits.__c.NativeFieldInfoPtr___9__10_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017CB RID: 6091
			// (get) Token: 0x06005BCC RID: 23500 RVA: 0x001CC168 File Offset: 0x001CA368
			// (set) Token: 0x06005BCD RID: 23501 RVA: 0x000220CC File Offset: 0x000202CC
			public unsafe static Func<Entity, EntityID> __9__10_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RetreatUnits.__c.NativeFieldInfoPtr___9__10_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RetreatUnits.__c.NativeFieldInfoPtr___9__10_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017CC RID: 6092
			// (get) Token: 0x06005BCE RID: 23502 RVA: 0x001CC190 File Offset: 0x001CA390
			// (set) Token: 0x06005BCF RID: 23503 RVA: 0x000220DE File Offset: 0x000202DE
			public unsafe static Func<ValueTuple<WormPlayer, WormPlayArea, Il2CppReferenceArray<Entity>>, IEnumerable<EntityID>> __9__10_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RetreatUnits.__c.NativeFieldInfoPtr___9__10_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<WormPlayer, WormPlayArea, Il2CppReferenceArray<Entity>>, IEnumerable<EntityID>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RetreatUnits.__c.NativeFieldInfoPtr___9__10_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017CD RID: 6093
			// (get) Token: 0x06005BD0 RID: 23504 RVA: 0x001CC1B8 File Offset: 0x001CA3B8
			// (set) Token: 0x06005BD1 RID: 23505 RVA: 0x000220F0 File Offset: 0x000202F0
			public unsafe static Func<WormUnit, int> __9__10_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RetreatUnits.__c.NativeFieldInfoPtr___9__10_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormUnit, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RetreatUnits.__c.NativeFieldInfoPtr___9__10_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003BAB RID: 15275
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003BAC RID: 15276
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x04003BAD RID: 15277
			private static readonly IntPtr NativeFieldInfoPtr___9__10_1;

			// Token: 0x04003BAE RID: 15278
			private static readonly IntPtr NativeFieldInfoPtr___9__10_4;

			// Token: 0x04003BAF RID: 15279
			private static readonly IntPtr NativeFieldInfoPtr___9__10_3;

			// Token: 0x04003BB0 RID: 15280
			private static readonly IntPtr NativeFieldInfoPtr___9__10_5;

			// Token: 0x04003BB1 RID: 15281
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003BB2 RID: 15282
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__10_0_Internal_WormPlayer_WormUnit_0;

			// Token: 0x04003BB3 RID: 15283
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__10_1_Internal_Boolean_IGrouping_2_WormPlayer_WormUnit_0;

			// Token: 0x04003BB4 RID: 15284
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__10_3_Internal_IEnumerable_1_EntityID_ValueTuple_3_WormPlayer_WormPlayArea_Il2CppReferenceArray_1_Entity_0;

			// Token: 0x04003BB5 RID: 15285
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__10_4_Internal_EntityID_Entity_0;

			// Token: 0x04003BB6 RID: 15286
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__10_5_Internal_Int32_WormUnit_0;
		}

		// Token: 0x020006C7 RID: 1735
		[ObfuscatedName("worm.canis.actions.RetreatUnits+<execute>d__10")]
		public sealed class _execute_d__10 : Object
		{
			// Token: 0x06005BD2 RID: 23506 RVA: 0x001CC1E0 File Offset: 0x001CA3E0
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__10()
			{
				Il2CppClassPointerStore<RetreatUnits._execute_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RetreatUnits>.NativeClassPtr, "<execute>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RetreatUnits._execute_d__10>.NativeClassPtr);
				RetreatUnits._execute_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetreatUnits._execute_d__10>.NativeClassPtr, "<>1__state");
				RetreatUnits._execute_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetreatUnits._execute_d__10>.NativeClassPtr, "<>2__current");
				RetreatUnits._execute_d__10.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetreatUnits._execute_d__10>.NativeClassPtr, "<>l__initialThreadId");
				RetreatUnits._execute_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetreatUnits._execute_d__10>.NativeClassPtr, "<>4__this");
				RetreatUnits._execute_d__10.NativeFieldInfoPtr__troopPairs_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetreatUnits._execute_d__10>.NativeClassPtr, "<troopPairs>5__2");
				RetreatUnits._execute_d__10.NativeFieldInfoPtr__childUndo_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetreatUnits._execute_d__10>.NativeClassPtr, "<childUndo>5__3");
				RetreatUnits._execute_d__10.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetreatUnits._execute_d__10>.NativeClassPtr, "<>7__wrap3");
				RetreatUnits._execute_d__10.NativeFieldInfoPtr__player_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetreatUnits._execute_d__10>.NativeClassPtr, "<player>5__5");
				RetreatUnits._execute_d__10.NativeFieldInfoPtr__targets_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetreatUnits._execute_d__10>.NativeClassPtr, "<targets>5__6");
				RetreatUnits._execute_d__10.NativeFieldInfoPtr__totalStrengthPaid_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetreatUnits._execute_d__10>.NativeClassPtr, "<totalStrengthPaid>5__7");
				RetreatUnits._execute_d__10.NativeFieldInfoPtr__deploymentZone_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetreatUnits._execute_d__10>.NativeClassPtr, "<deploymentZone>5__8");
				RetreatUnits._execute_d__10.NativeFieldInfoPtr__remainingStrength_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetreatUnits._execute_d__10>.NativeClassPtr, "<remainingStrength>5__9");
				RetreatUnits._execute_d__10.NativeFieldInfoPtr___7__wrap9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetreatUnits._execute_d__10>.NativeClassPtr, "<>7__wrap9");
				RetreatUnits._execute_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits._execute_d__10>.NativeClassPtr, 100668511);
				RetreatUnits._execute_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits._execute_d__10>.NativeClassPtr, 100668512);
				RetreatUnits._execute_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits._execute_d__10>.NativeClassPtr, 100668513);
				RetreatUnits._execute_d__10.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits._execute_d__10>.NativeClassPtr, 100668514);
				RetreatUnits._execute_d__10.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits._execute_d__10>.NativeClassPtr, 100668515);
				RetreatUnits._execute_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits._execute_d__10>.NativeClassPtr, 100668516);
				RetreatUnits._execute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits._execute_d__10>.NativeClassPtr, 100668517);
				RetreatUnits._execute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits._execute_d__10>.NativeClassPtr, 100668518);
				RetreatUnits._execute_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits._execute_d__10>.NativeClassPtr, 100668519);
				RetreatUnits._execute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits._execute_d__10>.NativeClassPtr, 100668520);
			}

			// Token: 0x06005BD3 RID: 23507 RVA: 0x001CC3D8 File Offset: 0x001CA5D8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RetreatUnits._execute_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetreatUnits._execute_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005BD4 RID: 23508 RVA: 0x001CC420 File Offset: 0x001CA620
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143934, XrefRangeEnd = 143945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetreatUnits._execute_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005BD5 RID: 23509 RVA: 0x001CC454 File Offset: 0x001CA654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143945, XrefRangeEnd = 144308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetreatUnits._execute_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005BD6 RID: 23510 RVA: 0x001CC490 File Offset: 0x001CA690
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 144311, RefRangeEnd = 144312, XrefRangeStart = 144308, XrefRangeEnd = 144311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetreatUnits._execute_d__10.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005BD7 RID: 23511 RVA: 0x001CC4C4 File Offset: 0x001CA6C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144312, XrefRangeEnd = 144315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetreatUnits._execute_d__10.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170017DB RID: 6107
			// (get) Token: 0x06005BD8 RID: 23512 RVA: 0x001CC4F8 File Offset: 0x001CA6F8
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetreatUnits._execute_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005BD9 RID: 23513 RVA: 0x001CC538 File Offset: 0x001CA738
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144315, XrefRangeEnd = 144320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetreatUnits._execute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170017DC RID: 6108
			// (get) Token: 0x06005BDA RID: 23514 RVA: 0x001CC56C File Offset: 0x001CA76C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetreatUnits._execute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005BDB RID: 23515 RVA: 0x001CC5AC File Offset: 0x001CA7AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144320, XrefRangeEnd = 144322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetreatUnits._execute_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005BDC RID: 23516 RVA: 0x001CC5EC File Offset: 0x001CA7EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetreatUnits._execute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005BDD RID: 23517 RVA: 0x00022102 File Offset: 0x00020302
			public _execute_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170017CE RID: 6094
			// (get) Token: 0x06005BDE RID: 23518 RVA: 0x001CC62C File Offset: 0x001CA82C
			// (set) Token: 0x06005BDF RID: 23519 RVA: 0x0002210B File Offset: 0x0002030B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._execute_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._execute_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170017CF RID: 6095
			// (get) Token: 0x06005BE0 RID: 23520 RVA: 0x001CC654 File Offset: 0x001CA854
			// (set) Token: 0x06005BE1 RID: 23521 RVA: 0x00022126 File Offset: 0x00020326
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._execute_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._execute_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017D0 RID: 6096
			// (get) Token: 0x06005BE2 RID: 23522 RVA: 0x001CC684 File Offset: 0x001CA884
			// (set) Token: 0x06005BE3 RID: 23523 RVA: 0x00022145 File Offset: 0x00020345
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._execute_d__10.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._execute_d__10.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170017D1 RID: 6097
			// (get) Token: 0x06005BE4 RID: 23524 RVA: 0x001CC6AC File Offset: 0x001CA8AC
			// (set) Token: 0x06005BE5 RID: 23525 RVA: 0x00022160 File Offset: 0x00020360
			public unsafe RetreatUnits __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._execute_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RetreatUnits>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._execute_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017D2 RID: 6098
			// (get) Token: 0x06005BE6 RID: 23526 RVA: 0x001CC6DC File Offset: 0x001CA8DC
			// (set) Token: 0x06005BE7 RID: 23527 RVA: 0x0002217F File Offset: 0x0002037F
			public unsafe List<ValueTuple<WormPlayer, WormPlayArea, Il2CppReferenceArray<Entity>>> _troopPairs_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._execute_d__10.NativeFieldInfoPtr__troopPairs_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<WormPlayer, WormPlayArea, Il2CppReferenceArray<Entity>>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._execute_d__10.NativeFieldInfoPtr__troopPairs_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017D3 RID: 6099
			// (get) Token: 0x06005BE8 RID: 23528 RVA: 0x001CC70C File Offset: 0x001CA90C
			// (set) Token: 0x06005BE9 RID: 23529 RVA: 0x0002219E File Offset: 0x0002039E
			public unsafe UndoNode _childUndo_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._execute_d__10.NativeFieldInfoPtr__childUndo_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._execute_d__10.NativeFieldInfoPtr__childUndo_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017D4 RID: 6100
			// (get) Token: 0x06005BEA RID: 23530 RVA: 0x001CC73C File Offset: 0x001CA93C
			// (set) Token: 0x06005BEB RID: 23531 RVA: 0x000221BD File Offset: 0x000203BD
			public List<ValueTuple<WormPlayer, WormPlayArea, Il2CppReferenceArray<Entity>>>.Enumerator __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._execute_d__10.NativeFieldInfoPtr___7__wrap3);
					return new List<ValueTuple<WormPlayer, WormPlayArea, Il2CppReferenceArray<Entity>>>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<ValueTuple<WormPlayer, WormPlayArea, Il2CppReferenceArray<Entity>>>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._execute_d__10.NativeFieldInfoPtr___7__wrap3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<ValueTuple<WormPlayer, WormPlayArea, Il2CppReferenceArray<Entity>>>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170017D5 RID: 6101
			// (get) Token: 0x06005BEC RID: 23532 RVA: 0x001CC76C File Offset: 0x001CA96C
			// (set) Token: 0x06005BED RID: 23533 RVA: 0x000221EB File Offset: 0x000203EB
			public unsafe WormPlayer _player_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._execute_d__10.NativeFieldInfoPtr__player_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._execute_d__10.NativeFieldInfoPtr__player_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017D6 RID: 6102
			// (get) Token: 0x06005BEE RID: 23534 RVA: 0x001CC79C File Offset: 0x001CA99C
			// (set) Token: 0x06005BEF RID: 23535 RVA: 0x0002220A File Offset: 0x0002040A
			public unsafe Il2CppReferenceArray<Entity> _targets_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._execute_d__10.NativeFieldInfoPtr__targets_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._execute_d__10.NativeFieldInfoPtr__targets_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017D7 RID: 6103
			// (get) Token: 0x06005BF0 RID: 23536 RVA: 0x001CC7CC File Offset: 0x001CA9CC
			// (set) Token: 0x06005BF1 RID: 23537 RVA: 0x00022229 File Offset: 0x00020429
			public unsafe int _totalStrengthPaid_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._execute_d__10.NativeFieldInfoPtr__totalStrengthPaid_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._execute_d__10.NativeFieldInfoPtr__totalStrengthPaid_5__7)) = value;
				}
			}

			// Token: 0x170017D8 RID: 6104
			// (get) Token: 0x06005BF2 RID: 23538 RVA: 0x001CC7F4 File Offset: 0x001CA9F4
			// (set) Token: 0x06005BF3 RID: 23539 RVA: 0x00022244 File Offset: 0x00020444
			public unsafe WormPlayArea _deploymentZone_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._execute_d__10.NativeFieldInfoPtr__deploymentZone_5__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._execute_d__10.NativeFieldInfoPtr__deploymentZone_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017D9 RID: 6105
			// (get) Token: 0x06005BF4 RID: 23540 RVA: 0x001CC824 File Offset: 0x001CAA24
			// (set) Token: 0x06005BF5 RID: 23541 RVA: 0x00022263 File Offset: 0x00020463
			public unsafe int _remainingStrength_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._execute_d__10.NativeFieldInfoPtr__remainingStrength_5__9);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._execute_d__10.NativeFieldInfoPtr__remainingStrength_5__9)) = value;
				}
			}

			// Token: 0x170017DA RID: 6106
			// (get) Token: 0x06005BF6 RID: 23542 RVA: 0x001CC84C File Offset: 0x001CAA4C
			// (set) Token: 0x06005BF7 RID: 23543 RVA: 0x0002227E File Offset: 0x0002047E
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._execute_d__10.NativeFieldInfoPtr___7__wrap9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._execute_d__10.NativeFieldInfoPtr___7__wrap9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003BB7 RID: 15287
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003BB8 RID: 15288
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003BB9 RID: 15289
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003BBA RID: 15290
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003BBB RID: 15291
			private static readonly IntPtr NativeFieldInfoPtr__troopPairs_5__2;

			// Token: 0x04003BBC RID: 15292
			private static readonly IntPtr NativeFieldInfoPtr__childUndo_5__3;

			// Token: 0x04003BBD RID: 15293
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x04003BBE RID: 15294
			private static readonly IntPtr NativeFieldInfoPtr__player_5__5;

			// Token: 0x04003BBF RID: 15295
			private static readonly IntPtr NativeFieldInfoPtr__targets_5__6;

			// Token: 0x04003BC0 RID: 15296
			private static readonly IntPtr NativeFieldInfoPtr__totalStrengthPaid_5__7;

			// Token: 0x04003BC1 RID: 15297
			private static readonly IntPtr NativeFieldInfoPtr__deploymentZone_5__8;

			// Token: 0x04003BC2 RID: 15298
			private static readonly IntPtr NativeFieldInfoPtr__remainingStrength_5__9;

			// Token: 0x04003BC3 RID: 15299
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap9;

			// Token: 0x04003BC4 RID: 15300
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003BC5 RID: 15301
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003BC6 RID: 15302
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003BC7 RID: 15303
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003BC8 RID: 15304
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04003BC9 RID: 15305
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003BCA RID: 15306
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003BCB RID: 15307
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003BCC RID: 15308
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003BCD RID: 15309
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020006C8 RID: 1736
		[ObfuscatedName("worm.canis.actions.RetreatUnits+<undo>d__11")]
		public sealed class _undo_d__11 : Object
		{
			// Token: 0x06005BF8 RID: 23544 RVA: 0x001CC87C File Offset: 0x001CAA7C
			// Note: this type is marked as 'beforefieldinit'.
			static _undo_d__11()
			{
				Il2CppClassPointerStore<RetreatUnits._undo_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RetreatUnits>.NativeClassPtr, "<undo>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RetreatUnits._undo_d__11>.NativeClassPtr);
				RetreatUnits._undo_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetreatUnits._undo_d__11>.NativeClassPtr, "<>1__state");
				RetreatUnits._undo_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetreatUnits._undo_d__11>.NativeClassPtr, "<>2__current");
				RetreatUnits._undo_d__11.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetreatUnits._undo_d__11>.NativeClassPtr, "<>l__initialThreadId");
				RetreatUnits._undo_d__11.NativeFieldInfoPtr_undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetreatUnits._undo_d__11>.NativeClassPtr, "undoContext");
				RetreatUnits._undo_d__11.NativeFieldInfoPtr___3__undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetreatUnits._undo_d__11>.NativeClassPtr, "<>3__undoContext");
				RetreatUnits._undo_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetreatUnits._undo_d__11>.NativeClassPtr, "<>4__this");
				RetreatUnits._undo_d__11.NativeFieldInfoPtr__wm_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetreatUnits._undo_d__11>.NativeClassPtr, "<wm>5__2");
				RetreatUnits._undo_d__11.NativeFieldInfoPtr__possibleStrengthReset_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetreatUnits._undo_d__11>.NativeClassPtr, "<possibleStrengthReset>5__3");
				RetreatUnits._undo_d__11.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetreatUnits._undo_d__11>.NativeClassPtr, "<>7__wrap3");
				RetreatUnits._undo_d__11.NativeFieldInfoPtr__unit_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetreatUnits._undo_d__11>.NativeClassPtr, "<unit>5__5");
				RetreatUnits._undo_d__11.NativeFieldInfoPtr__wormPlayer_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetreatUnits._undo_d__11>.NativeClassPtr, "<wormPlayer>5__6");
				RetreatUnits._undo_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits._undo_d__11>.NativeClassPtr, 100668521);
				RetreatUnits._undo_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits._undo_d__11>.NativeClassPtr, 100668522);
				RetreatUnits._undo_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits._undo_d__11>.NativeClassPtr, 100668523);
				RetreatUnits._undo_d__11.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits._undo_d__11>.NativeClassPtr, 100668524);
				RetreatUnits._undo_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits._undo_d__11>.NativeClassPtr, 100668525);
				RetreatUnits._undo_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits._undo_d__11>.NativeClassPtr, 100668526);
				RetreatUnits._undo_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits._undo_d__11>.NativeClassPtr, 100668527);
				RetreatUnits._undo_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits._undo_d__11>.NativeClassPtr, 100668528);
				RetreatUnits._undo_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetreatUnits._undo_d__11>.NativeClassPtr, 100668529);
			}

			// Token: 0x06005BF9 RID: 23545 RVA: 0x001CCA38 File Offset: 0x001CAC38
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _undo_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RetreatUnits._undo_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetreatUnits._undo_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005BFA RID: 23546 RVA: 0x001CCA80 File Offset: 0x001CAC80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144322, XrefRangeEnd = 144327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetreatUnits._undo_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005BFB RID: 23547 RVA: 0x001CCAB4 File Offset: 0x001CACB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144327, XrefRangeEnd = 144441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetreatUnits._undo_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005BFC RID: 23548 RVA: 0x001CCAF0 File Offset: 0x001CACF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144441, XrefRangeEnd = 144444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetreatUnits._undo_d__11.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170017E8 RID: 6120
			// (get) Token: 0x06005BFD RID: 23549 RVA: 0x001CCB24 File Offset: 0x001CAD24
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetreatUnits._undo_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005BFE RID: 23550 RVA: 0x001CCB64 File Offset: 0x001CAD64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144444, XrefRangeEnd = 144449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetreatUnits._undo_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170017E9 RID: 6121
			// (get) Token: 0x06005BFF RID: 23551 RVA: 0x001CCB98 File Offset: 0x001CAD98
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetreatUnits._undo_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005C00 RID: 23552 RVA: 0x001CCBD8 File Offset: 0x001CADD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144449, XrefRangeEnd = 144458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetreatUnits._undo_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005C01 RID: 23553 RVA: 0x001CCC18 File Offset: 0x001CAE18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetreatUnits._undo_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005C02 RID: 23554 RVA: 0x0002229D File Offset: 0x0002049D
			public _undo_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170017DD RID: 6109
			// (get) Token: 0x06005C03 RID: 23555 RVA: 0x001CCC58 File Offset: 0x001CAE58
			// (set) Token: 0x06005C04 RID: 23556 RVA: 0x000222A6 File Offset: 0x000204A6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._undo_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._undo_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170017DE RID: 6110
			// (get) Token: 0x06005C05 RID: 23557 RVA: 0x001CCC80 File Offset: 0x001CAE80
			// (set) Token: 0x06005C06 RID: 23558 RVA: 0x000222C1 File Offset: 0x000204C1
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._undo_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._undo_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017DF RID: 6111
			// (get) Token: 0x06005C07 RID: 23559 RVA: 0x001CCCB0 File Offset: 0x001CAEB0
			// (set) Token: 0x06005C08 RID: 23560 RVA: 0x000222E0 File Offset: 0x000204E0
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._undo_d__11.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._undo_d__11.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170017E0 RID: 6112
			// (get) Token: 0x06005C09 RID: 23561 RVA: 0x001CCCD8 File Offset: 0x001CAED8
			// (set) Token: 0x06005C0A RID: 23562 RVA: 0x000222FB File Offset: 0x000204FB
			public unsafe Context undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._undo_d__11.NativeFieldInfoPtr_undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._undo_d__11.NativeFieldInfoPtr_undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017E1 RID: 6113
			// (get) Token: 0x06005C0B RID: 23563 RVA: 0x001CCD08 File Offset: 0x001CAF08
			// (set) Token: 0x06005C0C RID: 23564 RVA: 0x0002231A File Offset: 0x0002051A
			public unsafe Context __3__undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._undo_d__11.NativeFieldInfoPtr___3__undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._undo_d__11.NativeFieldInfoPtr___3__undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017E2 RID: 6114
			// (get) Token: 0x06005C0D RID: 23565 RVA: 0x001CCD38 File Offset: 0x001CAF38
			// (set) Token: 0x06005C0E RID: 23566 RVA: 0x00022339 File Offset: 0x00020539
			public unsafe RetreatUnits __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._undo_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RetreatUnits>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._undo_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017E3 RID: 6115
			// (get) Token: 0x06005C0F RID: 23567 RVA: 0x001CCD68 File Offset: 0x001CAF68
			// (set) Token: 0x06005C10 RID: 23568 RVA: 0x00022358 File Offset: 0x00020558
			public unsafe WormMatch _wm_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._undo_d__11.NativeFieldInfoPtr__wm_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._undo_d__11.NativeFieldInfoPtr__wm_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017E4 RID: 6116
			// (get) Token: 0x06005C11 RID: 23569 RVA: 0x001CCD98 File Offset: 0x001CAF98
			// (set) Token: 0x06005C12 RID: 23570 RVA: 0x00022377 File Offset: 0x00020577
			public unsafe bool _possibleStrengthReset_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._undo_d__11.NativeFieldInfoPtr__possibleStrengthReset_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._undo_d__11.NativeFieldInfoPtr__possibleStrengthReset_5__3)) = value;
				}
			}

			// Token: 0x170017E5 RID: 6117
			// (get) Token: 0x06005C13 RID: 23571 RVA: 0x001CCDC0 File Offset: 0x001CAFC0
			// (set) Token: 0x06005C14 RID: 23572 RVA: 0x00022392 File Offset: 0x00020592
			public List<WormUnit>.Enumerator __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._undo_d__11.NativeFieldInfoPtr___7__wrap3);
					return new List<WormUnit>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<WormUnit>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._undo_d__11.NativeFieldInfoPtr___7__wrap3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<WormUnit>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170017E6 RID: 6118
			// (get) Token: 0x06005C15 RID: 23573 RVA: 0x001CCDF0 File Offset: 0x001CAFF0
			// (set) Token: 0x06005C16 RID: 23574 RVA: 0x000223C0 File Offset: 0x000205C0
			public unsafe WormUnit _unit_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._undo_d__11.NativeFieldInfoPtr__unit_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormUnit>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._undo_d__11.NativeFieldInfoPtr__unit_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017E7 RID: 6119
			// (get) Token: 0x06005C17 RID: 23575 RVA: 0x001CCE20 File Offset: 0x001CB020
			// (set) Token: 0x06005C18 RID: 23576 RVA: 0x000223DF File Offset: 0x000205DF
			public unsafe WormPlayer _wormPlayer_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._undo_d__11.NativeFieldInfoPtr__wormPlayer_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetreatUnits._undo_d__11.NativeFieldInfoPtr__wormPlayer_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003BCE RID: 15310
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003BCF RID: 15311
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003BD0 RID: 15312
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003BD1 RID: 15313
			private static readonly IntPtr NativeFieldInfoPtr_undoContext;

			// Token: 0x04003BD2 RID: 15314
			private static readonly IntPtr NativeFieldInfoPtr___3__undoContext;

			// Token: 0x04003BD3 RID: 15315
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003BD4 RID: 15316
			private static readonly IntPtr NativeFieldInfoPtr__wm_5__2;

			// Token: 0x04003BD5 RID: 15317
			private static readonly IntPtr NativeFieldInfoPtr__possibleStrengthReset_5__3;

			// Token: 0x04003BD6 RID: 15318
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x04003BD7 RID: 15319
			private static readonly IntPtr NativeFieldInfoPtr__unit_5__5;

			// Token: 0x04003BD8 RID: 15320
			private static readonly IntPtr NativeFieldInfoPtr__wormPlayer_5__6;

			// Token: 0x04003BD9 RID: 15321
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003BDA RID: 15322
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003BDB RID: 15323
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003BDC RID: 15324
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003BDD RID: 15325
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003BDE RID: 15326
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003BDF RID: 15327
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003BE0 RID: 15328
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003BE1 RID: 15329
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

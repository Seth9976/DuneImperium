using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.context;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.actions.Immortality
{
	// Token: 0x020002E2 RID: 738
	public class GainTleilaxuInfluence : global::Canis.actions.Action
	{
		// Token: 0x06001E5C RID: 7772 RVA: 0x000CF6BC File Offset: 0x000CD8BC
		// Note: this type is marked as 'beforefieldinit'.
		static GainTleilaxuInfluence()
		{
			Il2CppClassPointerStore<GainTleilaxuInfluence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.Immortality", "GainTleilaxuInfluence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainTleilaxuInfluence>.NativeClassPtr);
			GainTleilaxuInfluence.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainTleilaxuInfluence>.NativeClassPtr, "player");
			GainTleilaxuInfluence.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainTleilaxuInfluence>.NativeClassPtr, "Amount");
			GainTleilaxuInfluence.NativeFieldInfoPtr_gameLogID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainTleilaxuInfluence>.NativeClassPtr, "gameLogID");
			GainTleilaxuInfluence.NativeFieldInfoPtr__LogMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainTleilaxuInfluence>.NativeClassPtr, "<LogMode>k__BackingField");
			GainTleilaxuInfluence.NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainTleilaxuInfluence>.NativeClassPtr, 100670422);
			GainTleilaxuInfluence.NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainTleilaxuInfluence>.NativeClassPtr, 100670423);
			GainTleilaxuInfluence.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainTleilaxuInfluence>.NativeClassPtr, 100670424);
			GainTleilaxuInfluence.NativeMethodInfoPtr__ctor_Public_Void_SerializedGainTleilaxuInfluence_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainTleilaxuInfluence>.NativeClassPtr, 100670425);
			GainTleilaxuInfluence.NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainTleilaxuInfluence>.NativeClassPtr, 100670426);
			GainTleilaxuInfluence.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainTleilaxuInfluence>.NativeClassPtr, 100670427);
			GainTleilaxuInfluence.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainTleilaxuInfluence>.NativeClassPtr, 100670428);
			GainTleilaxuInfluence.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainTleilaxuInfluence>.NativeClassPtr, 100670429);
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06001E5D RID: 7773 RVA: 0x000CF7DC File Offset: 0x000CD9DC
		// (set) Token: 0x06001E5E RID: 7774 RVA: 0x000CF818 File Offset: 0x000CDA18
		public unsafe virtual ActionLogModes LogMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainTleilaxuInfluence.NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 170594, RefRangeEnd = 170603, XrefRangeStart = 170594, XrefRangeEnd = 170603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainTleilaxuInfluence.NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x000CF858 File Offset: 0x000CDA58
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 171141, RefRangeEnd = 171157, XrefRangeStart = 171139, XrefRangeEnd = 171141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GainTleilaxuInfluence(int amt, Match m, int gameLogID = -1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainTleilaxuInfluence>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gameLogID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainTleilaxuInfluence.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x000CF8C0 File Offset: 0x000CDAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171157, XrefRangeEnd = 171162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GainTleilaxuInfluence(SerializedGainTleilaxuInfluence serialized, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainTleilaxuInfluence>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainTleilaxuInfluence.NativeMethodInfoPtr__ctor_Public_Void_SerializedGainTleilaxuInfluence_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x000CF920 File Offset: 0x000CDB20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171162, XrefRangeEnd = 171169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<ValueTuple<string, Object>> MakeAnalyticsData(WormMatch wormMatch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainTleilaxuInfluence.NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<string, Object>>>(intPtr3) : null;
			}
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x000CF970 File Offset: 0x000CDB70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171169, XrefRangeEnd = 171214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainTleilaxuInfluence.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x000CF9BC File Offset: 0x000CDBBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171214, XrefRangeEnd = 171221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> undo(Context undoContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainTleilaxuInfluence.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x000CFA18 File Offset: 0x000CDC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171221, XrefRangeEnd = 171226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainTleilaxuInfluence.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x0000CB48 File Offset: 0x0000AD48
		public GainTleilaxuInfluence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06001E66 RID: 7782 RVA: 0x000CFA74 File Offset: 0x000CDC74
		// (set) Token: 0x06001E67 RID: 7783 RVA: 0x0000CB51 File Offset: 0x0000AD51
		public unsafe WormPlayer player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06001E68 RID: 7784 RVA: 0x000CFAA4 File Offset: 0x000CDCA4
		// (set) Token: 0x06001E69 RID: 7785 RVA: 0x0000CB70 File Offset: 0x0000AD70
		public unsafe int Amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence.NativeFieldInfoPtr_Amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence.NativeFieldInfoPtr_Amount)) = value;
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06001E6A RID: 7786 RVA: 0x000CFACC File Offset: 0x000CDCCC
		// (set) Token: 0x06001E6B RID: 7787 RVA: 0x0000CB8B File Offset: 0x0000AD8B
		public unsafe int gameLogID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence.NativeFieldInfoPtr_gameLogID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence.NativeFieldInfoPtr_gameLogID)) = value;
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06001E6C RID: 7788 RVA: 0x000CFAF4 File Offset: 0x000CDCF4
		// (set) Token: 0x06001E6D RID: 7789 RVA: 0x0000CBA6 File Offset: 0x0000ADA6
		public unsafe ActionLogModes _LogMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence.NativeFieldInfoPtr__LogMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence.NativeFieldInfoPtr__LogMode_k__BackingField)) = value;
			}
		}

		// Token: 0x04001324 RID: 4900
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x04001325 RID: 4901
		private static readonly IntPtr NativeFieldInfoPtr_Amount;

		// Token: 0x04001326 RID: 4902
		private static readonly IntPtr NativeFieldInfoPtr_gameLogID;

		// Token: 0x04001327 RID: 4903
		private static readonly IntPtr NativeFieldInfoPtr__LogMode_k__BackingField;

		// Token: 0x04001328 RID: 4904
		private static readonly IntPtr NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0;

		// Token: 0x04001329 RID: 4905
		private static readonly IntPtr NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0;

		// Token: 0x0400132A RID: 4906
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_Int32_0;

		// Token: 0x0400132B RID: 4907
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedGainTleilaxuInfluence_Match_0;

		// Token: 0x0400132C RID: 4908
		private static readonly IntPtr NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_0;

		// Token: 0x0400132D RID: 4909
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x0400132E RID: 4910
		private static readonly IntPtr NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0;

		// Token: 0x0400132F RID: 4911
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x02000787 RID: 1927
		[ObfuscatedName("worm.canis.actions.Immortality.GainTleilaxuInfluence+<MakeAnalyticsData>d__9")]
		public sealed class _MakeAnalyticsData_d__9 : Object
		{
			// Token: 0x06006C90 RID: 27792 RVA: 0x001FF26C File Offset: 0x001FD46C
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeAnalyticsData_d__9()
			{
				Il2CppClassPointerStore<GainTleilaxuInfluence._MakeAnalyticsData_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainTleilaxuInfluence>.NativeClassPtr, "<MakeAnalyticsData>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainTleilaxuInfluence._MakeAnalyticsData_d__9>.NativeClassPtr);
				GainTleilaxuInfluence._MakeAnalyticsData_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainTleilaxuInfluence._MakeAnalyticsData_d__9>.NativeClassPtr, "<>1__state");
				GainTleilaxuInfluence._MakeAnalyticsData_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainTleilaxuInfluence._MakeAnalyticsData_d__9>.NativeClassPtr, "<>2__current");
				GainTleilaxuInfluence._MakeAnalyticsData_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainTleilaxuInfluence._MakeAnalyticsData_d__9>.NativeClassPtr, "<>l__initialThreadId");
				GainTleilaxuInfluence._MakeAnalyticsData_d__9.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainTleilaxuInfluence._MakeAnalyticsData_d__9>.NativeClassPtr, "wormMatch");
				GainTleilaxuInfluence._MakeAnalyticsData_d__9.NativeFieldInfoPtr___3__wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainTleilaxuInfluence._MakeAnalyticsData_d__9>.NativeClassPtr, "<>3__wormMatch");
				GainTleilaxuInfluence._MakeAnalyticsData_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainTleilaxuInfluence._MakeAnalyticsData_d__9>.NativeClassPtr, "<>4__this");
				GainTleilaxuInfluence._MakeAnalyticsData_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainTleilaxuInfluence._MakeAnalyticsData_d__9>.NativeClassPtr, 100670430);
				GainTleilaxuInfluence._MakeAnalyticsData_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainTleilaxuInfluence._MakeAnalyticsData_d__9>.NativeClassPtr, 100670431);
				GainTleilaxuInfluence._MakeAnalyticsData_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainTleilaxuInfluence._MakeAnalyticsData_d__9>.NativeClassPtr, 100670432);
				GainTleilaxuInfluence._MakeAnalyticsData_d__9.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainTleilaxuInfluence._MakeAnalyticsData_d__9>.NativeClassPtr, 100670433);
				GainTleilaxuInfluence._MakeAnalyticsData_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainTleilaxuInfluence._MakeAnalyticsData_d__9>.NativeClassPtr, 100670434);
				GainTleilaxuInfluence._MakeAnalyticsData_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainTleilaxuInfluence._MakeAnalyticsData_d__9>.NativeClassPtr, 100670435);
				GainTleilaxuInfluence._MakeAnalyticsData_d__9.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainTleilaxuInfluence._MakeAnalyticsData_d__9>.NativeClassPtr, 100670436);
				GainTleilaxuInfluence._MakeAnalyticsData_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainTleilaxuInfluence._MakeAnalyticsData_d__9>.NativeClassPtr, 100670437);
			}

			// Token: 0x06006C91 RID: 27793 RVA: 0x001FF3B0 File Offset: 0x001FD5B0
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MakeAnalyticsData_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainTleilaxuInfluence._MakeAnalyticsData_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainTleilaxuInfluence._MakeAnalyticsData_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006C92 RID: 27794 RVA: 0x001FF3F8 File Offset: 0x001FD5F8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainTleilaxuInfluence._MakeAnalyticsData_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006C93 RID: 27795 RVA: 0x001FF42C File Offset: 0x001FD62C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170961, XrefRangeEnd = 170979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainTleilaxuInfluence._MakeAnalyticsData_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001DAA RID: 7594
			// (get) Token: 0x06006C94 RID: 27796 RVA: 0x001FF468 File Offset: 0x001FD668
			public unsafe ValueTuple<string, Object> prop_ValueTuple_2_String_Object_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainTleilaxuInfluence._MakeAnalyticsData_d__9.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<string, Object>(intPtr);
				}
			}

			// Token: 0x06006C95 RID: 27797 RVA: 0x001FF4A0 File Offset: 0x001FD6A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170979, XrefRangeEnd = 170984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainTleilaxuInfluence._MakeAnalyticsData_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001DAB RID: 7595
			// (get) Token: 0x06006C96 RID: 27798 RVA: 0x001FF4D4 File Offset: 0x001FD6D4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170984, XrefRangeEnd = 170987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainTleilaxuInfluence._MakeAnalyticsData_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006C97 RID: 27799 RVA: 0x001FF514 File Offset: 0x001FD714
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170987, XrefRangeEnd = 170996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<string, Object>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainTleilaxuInfluence._MakeAnalyticsData_d__9.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<string, Object>>>(intPtr3) : null;
			}

			// Token: 0x06006C98 RID: 27800 RVA: 0x001FF554 File Offset: 0x001FD754
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainTleilaxuInfluence._MakeAnalyticsData_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006C99 RID: 27801 RVA: 0x0002B05C File Offset: 0x0002925C
			public _MakeAnalyticsData_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001DA4 RID: 7588
			// (get) Token: 0x06006C9A RID: 27802 RVA: 0x001FF594 File Offset: 0x001FD794
			// (set) Token: 0x06006C9B RID: 27803 RVA: 0x0002B065 File Offset: 0x00029265
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence._MakeAnalyticsData_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence._MakeAnalyticsData_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001DA5 RID: 7589
			// (get) Token: 0x06006C9C RID: 27804 RVA: 0x001FF5BC File Offset: 0x001FD7BC
			// (set) Token: 0x06006C9D RID: 27805 RVA: 0x0002B080 File Offset: 0x00029280
			public ValueTuple<string, Object> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence._MakeAnalyticsData_d__9.NativeFieldInfoPtr___2__current);
					return new ValueTuple<string, Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence._MakeAnalyticsData_d__9.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001DA6 RID: 7590
			// (get) Token: 0x06006C9E RID: 27806 RVA: 0x001FF5EC File Offset: 0x001FD7EC
			// (set) Token: 0x06006C9F RID: 27807 RVA: 0x0002B0AE File Offset: 0x000292AE
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence._MakeAnalyticsData_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence._MakeAnalyticsData_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001DA7 RID: 7591
			// (get) Token: 0x06006CA0 RID: 27808 RVA: 0x001FF614 File Offset: 0x001FD814
			// (set) Token: 0x06006CA1 RID: 27809 RVA: 0x0002B0C9 File Offset: 0x000292C9
			public unsafe WormMatch wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence._MakeAnalyticsData_d__9.NativeFieldInfoPtr_wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence._MakeAnalyticsData_d__9.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DA8 RID: 7592
			// (get) Token: 0x06006CA2 RID: 27810 RVA: 0x001FF644 File Offset: 0x001FD844
			// (set) Token: 0x06006CA3 RID: 27811 RVA: 0x0002B0E8 File Offset: 0x000292E8
			public unsafe WormMatch __3__wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence._MakeAnalyticsData_d__9.NativeFieldInfoPtr___3__wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence._MakeAnalyticsData_d__9.NativeFieldInfoPtr___3__wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DA9 RID: 7593
			// (get) Token: 0x06006CA4 RID: 27812 RVA: 0x001FF674 File Offset: 0x001FD874
			// (set) Token: 0x06006CA5 RID: 27813 RVA: 0x0002B107 File Offset: 0x00029307
			public unsafe GainTleilaxuInfluence __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence._MakeAnalyticsData_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GainTleilaxuInfluence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence._MakeAnalyticsData_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004627 RID: 17959
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004628 RID: 17960
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004629 RID: 17961
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400462A RID: 17962
			private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

			// Token: 0x0400462B RID: 17963
			private static readonly IntPtr NativeFieldInfoPtr___3__wormMatch;

			// Token: 0x0400462C RID: 17964
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400462D RID: 17965
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400462E RID: 17966
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400462F RID: 17967
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004630 RID: 17968
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0;

			// Token: 0x04004631 RID: 17969
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004632 RID: 17970
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004633 RID: 17971
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0;

			// Token: 0x04004634 RID: 17972
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000788 RID: 1928
		[ObfuscatedName("worm.canis.actions.Immortality.GainTleilaxuInfluence+<undo>d__11")]
		public sealed class _undo_d__11 : Object
		{
			// Token: 0x06006CA6 RID: 27814 RVA: 0x001FF6A4 File Offset: 0x001FD8A4
			// Note: this type is marked as 'beforefieldinit'.
			static _undo_d__11()
			{
				Il2CppClassPointerStore<GainTleilaxuInfluence._undo_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainTleilaxuInfluence>.NativeClassPtr, "<undo>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainTleilaxuInfluence._undo_d__11>.NativeClassPtr);
				GainTleilaxuInfluence._undo_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainTleilaxuInfluence._undo_d__11>.NativeClassPtr, "<>1__state");
				GainTleilaxuInfluence._undo_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainTleilaxuInfluence._undo_d__11>.NativeClassPtr, "<>2__current");
				GainTleilaxuInfluence._undo_d__11.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainTleilaxuInfluence._undo_d__11>.NativeClassPtr, "<>l__initialThreadId");
				GainTleilaxuInfluence._undo_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainTleilaxuInfluence._undo_d__11>.NativeClassPtr, "<>4__this");
				GainTleilaxuInfluence._undo_d__11.NativeFieldInfoPtr_undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainTleilaxuInfluence._undo_d__11>.NativeClassPtr, "undoContext");
				GainTleilaxuInfluence._undo_d__11.NativeFieldInfoPtr___3__undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainTleilaxuInfluence._undo_d__11>.NativeClassPtr, "<>3__undoContext");
				GainTleilaxuInfluence._undo_d__11.NativeFieldInfoPtr__wm_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainTleilaxuInfluence._undo_d__11>.NativeClassPtr, "<wm>5__2");
				GainTleilaxuInfluence._undo_d__11.NativeFieldInfoPtr__originSpace_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainTleilaxuInfluence._undo_d__11>.NativeClassPtr, "<originSpace>5__3");
				GainTleilaxuInfluence._undo_d__11.NativeFieldInfoPtr__marker_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainTleilaxuInfluence._undo_d__11>.NativeClassPtr, "<marker>5__4");
				GainTleilaxuInfluence._undo_d__11.NativeFieldInfoPtr__spice_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainTleilaxuInfluence._undo_d__11>.NativeClassPtr, "<spice>5__5");
				GainTleilaxuInfluence._undo_d__11.NativeFieldInfoPtr__sequenceHelper_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainTleilaxuInfluence._undo_d__11>.NativeClassPtr, "<sequenceHelper>5__6");
				GainTleilaxuInfluence._undo_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainTleilaxuInfluence._undo_d__11>.NativeClassPtr, 100670438);
				GainTleilaxuInfluence._undo_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainTleilaxuInfluence._undo_d__11>.NativeClassPtr, 100670439);
				GainTleilaxuInfluence._undo_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainTleilaxuInfluence._undo_d__11>.NativeClassPtr, 100670440);
				GainTleilaxuInfluence._undo_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainTleilaxuInfluence._undo_d__11>.NativeClassPtr, 100670441);
				GainTleilaxuInfluence._undo_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainTleilaxuInfluence._undo_d__11>.NativeClassPtr, 100670442);
				GainTleilaxuInfluence._undo_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainTleilaxuInfluence._undo_d__11>.NativeClassPtr, 100670443);
				GainTleilaxuInfluence._undo_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainTleilaxuInfluence._undo_d__11>.NativeClassPtr, 100670444);
				GainTleilaxuInfluence._undo_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainTleilaxuInfluence._undo_d__11>.NativeClassPtr, 100670445);
			}

			// Token: 0x06006CA7 RID: 27815 RVA: 0x001FF84C File Offset: 0x001FDA4C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _undo_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainTleilaxuInfluence._undo_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainTleilaxuInfluence._undo_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006CA8 RID: 27816 RVA: 0x001FF894 File Offset: 0x001FDA94
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainTleilaxuInfluence._undo_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006CA9 RID: 27817 RVA: 0x001FF8C8 File Offset: 0x001FDAC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170996, XrefRangeEnd = 171125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainTleilaxuInfluence._undo_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001DB7 RID: 7607
			// (get) Token: 0x06006CAA RID: 27818 RVA: 0x001FF904 File Offset: 0x001FDB04
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainTleilaxuInfluence._undo_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006CAB RID: 27819 RVA: 0x001FF944 File Offset: 0x001FDB44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171125, XrefRangeEnd = 171130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainTleilaxuInfluence._undo_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001DB8 RID: 7608
			// (get) Token: 0x06006CAC RID: 27820 RVA: 0x001FF978 File Offset: 0x001FDB78
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainTleilaxuInfluence._undo_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006CAD RID: 27821 RVA: 0x001FF9B8 File Offset: 0x001FDBB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171130, XrefRangeEnd = 171139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainTleilaxuInfluence._undo_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006CAE RID: 27822 RVA: 0x001FF9F8 File Offset: 0x001FDBF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainTleilaxuInfluence._undo_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006CAF RID: 27823 RVA: 0x0002B126 File Offset: 0x00029326
			public _undo_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001DAC RID: 7596
			// (get) Token: 0x06006CB0 RID: 27824 RVA: 0x001FFA38 File Offset: 0x001FDC38
			// (set) Token: 0x06006CB1 RID: 27825 RVA: 0x0002B12F File Offset: 0x0002932F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence._undo_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence._undo_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001DAD RID: 7597
			// (get) Token: 0x06006CB2 RID: 27826 RVA: 0x001FFA60 File Offset: 0x001FDC60
			// (set) Token: 0x06006CB3 RID: 27827 RVA: 0x0002B14A File Offset: 0x0002934A
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence._undo_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence._undo_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DAE RID: 7598
			// (get) Token: 0x06006CB4 RID: 27828 RVA: 0x001FFA90 File Offset: 0x001FDC90
			// (set) Token: 0x06006CB5 RID: 27829 RVA: 0x0002B169 File Offset: 0x00029369
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence._undo_d__11.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence._undo_d__11.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001DAF RID: 7599
			// (get) Token: 0x06006CB6 RID: 27830 RVA: 0x001FFAB8 File Offset: 0x001FDCB8
			// (set) Token: 0x06006CB7 RID: 27831 RVA: 0x0002B184 File Offset: 0x00029384
			public unsafe GainTleilaxuInfluence __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence._undo_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GainTleilaxuInfluence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence._undo_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DB0 RID: 7600
			// (get) Token: 0x06006CB8 RID: 27832 RVA: 0x001FFAE8 File Offset: 0x001FDCE8
			// (set) Token: 0x06006CB9 RID: 27833 RVA: 0x0002B1A3 File Offset: 0x000293A3
			public unsafe Context undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence._undo_d__11.NativeFieldInfoPtr_undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence._undo_d__11.NativeFieldInfoPtr_undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DB1 RID: 7601
			// (get) Token: 0x06006CBA RID: 27834 RVA: 0x001FFB18 File Offset: 0x001FDD18
			// (set) Token: 0x06006CBB RID: 27835 RVA: 0x0002B1C2 File Offset: 0x000293C2
			public unsafe Context __3__undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence._undo_d__11.NativeFieldInfoPtr___3__undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence._undo_d__11.NativeFieldInfoPtr___3__undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DB2 RID: 7602
			// (get) Token: 0x06006CBC RID: 27836 RVA: 0x001FFB48 File Offset: 0x001FDD48
			// (set) Token: 0x06006CBD RID: 27837 RVA: 0x0002B1E1 File Offset: 0x000293E1
			public unsafe WormMatch _wm_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence._undo_d__11.NativeFieldInfoPtr__wm_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence._undo_d__11.NativeFieldInfoPtr__wm_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DB3 RID: 7603
			// (get) Token: 0x06006CBE RID: 27838 RVA: 0x001FFB78 File Offset: 0x001FDD78
			// (set) Token: 0x06006CBF RID: 27839 RVA: 0x0002B200 File Offset: 0x00029400
			public unsafe WormSpace _originSpace_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence._undo_d__11.NativeFieldInfoPtr__originSpace_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence._undo_d__11.NativeFieldInfoPtr__originSpace_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DB4 RID: 7604
			// (get) Token: 0x06006CC0 RID: 27840 RVA: 0x001FFBA8 File Offset: 0x001FDDA8
			// (set) Token: 0x06006CC1 RID: 27841 RVA: 0x0002B21F File Offset: 0x0002941F
			public unsafe Entity _marker_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence._undo_d__11.NativeFieldInfoPtr__marker_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence._undo_d__11.NativeFieldInfoPtr__marker_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DB5 RID: 7605
			// (get) Token: 0x06006CC2 RID: 27842 RVA: 0x001FFBD8 File Offset: 0x001FDDD8
			// (set) Token: 0x06006CC3 RID: 27843 RVA: 0x0002B23E File Offset: 0x0002943E
			public unsafe int _spice_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence._undo_d__11.NativeFieldInfoPtr__spice_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence._undo_d__11.NativeFieldInfoPtr__spice_5__5)) = value;
				}
			}

			// Token: 0x17001DB6 RID: 7606
			// (get) Token: 0x06006CC4 RID: 27844 RVA: 0x001FFC00 File Offset: 0x001FDE00
			// (set) Token: 0x06006CC5 RID: 27845 RVA: 0x0002B259 File Offset: 0x00029459
			public unsafe SequenceHelper _sequenceHelper_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence._undo_d__11.NativeFieldInfoPtr__sequenceHelper_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainTleilaxuInfluence._undo_d__11.NativeFieldInfoPtr__sequenceHelper_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004635 RID: 17973
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004636 RID: 17974
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004637 RID: 17975
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004638 RID: 17976
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004639 RID: 17977
			private static readonly IntPtr NativeFieldInfoPtr_undoContext;

			// Token: 0x0400463A RID: 17978
			private static readonly IntPtr NativeFieldInfoPtr___3__undoContext;

			// Token: 0x0400463B RID: 17979
			private static readonly IntPtr NativeFieldInfoPtr__wm_5__2;

			// Token: 0x0400463C RID: 17980
			private static readonly IntPtr NativeFieldInfoPtr__originSpace_5__3;

			// Token: 0x0400463D RID: 17981
			private static readonly IntPtr NativeFieldInfoPtr__marker_5__4;

			// Token: 0x0400463E RID: 17982
			private static readonly IntPtr NativeFieldInfoPtr__spice_5__5;

			// Token: 0x0400463F RID: 17983
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__6;

			// Token: 0x04004640 RID: 17984
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004641 RID: 17985
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004642 RID: 17986
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004643 RID: 17987
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004644 RID: 17988
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004645 RID: 17989
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004646 RID: 17990
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004647 RID: 17991
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

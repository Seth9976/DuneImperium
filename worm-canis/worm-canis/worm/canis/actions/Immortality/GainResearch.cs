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
	// Token: 0x020002DE RID: 734
	public class GainResearch : global::Canis.actions.Action
	{
		// Token: 0x06001E2A RID: 7722 RVA: 0x000CEB68 File Offset: 0x000CCD68
		// Note: this type is marked as 'beforefieldinit'.
		static GainResearch()
		{
			Il2CppClassPointerStore<GainResearch>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.Immortality", "GainResearch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainResearch>.NativeClassPtr);
			GainResearch.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResearch>.NativeClassPtr, "player");
			GainResearch.NativeFieldInfoPtr_TargetSpaceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResearch>.NativeClassPtr, "TargetSpaceIndex");
			GainResearch.NativeFieldInfoPtr_gameLogID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResearch>.NativeClassPtr, "gameLogID");
			GainResearch.NativeFieldInfoPtr__LogMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResearch>.NativeClassPtr, "<LogMode>k__BackingField");
			GainResearch.NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResearch>.NativeClassPtr, 100670349);
			GainResearch.NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResearch>.NativeClassPtr, 100670350);
			GainResearch.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResearch>.NativeClassPtr, 100670351);
			GainResearch.NativeMethodInfoPtr__ctor_Public_Void_SerializedGainResearch_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResearch>.NativeClassPtr, 100670352);
			GainResearch.NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResearch>.NativeClassPtr, 100670353);
			GainResearch.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResearch>.NativeClassPtr, 100670354);
			GainResearch.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResearch>.NativeClassPtr, 100670355);
			GainResearch.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResearch>.NativeClassPtr, 100670356);
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06001E2B RID: 7723 RVA: 0x000CEC88 File Offset: 0x000CCE88
		// (set) Token: 0x06001E2C RID: 7724 RVA: 0x000CECC4 File Offset: 0x000CCEC4
		public unsafe virtual ActionLogModes LogMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResearch.NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 170594, RefRangeEnd = 170603, XrefRangeStart = 170594, XrefRangeEnd = 170594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResearch.NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x000CED04 File Offset: 0x000CCF04
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 170612, RefRangeEnd = 170616, XrefRangeStart = 170603, XrefRangeEnd = 170612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GainResearch(WormMatch m, WormSpace space = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainResearch>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(space);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResearch.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x000CED64 File Offset: 0x000CCF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170616, XrefRangeEnd = 170621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GainResearch(SerializedGainResearch serialized, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainResearch>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResearch.NativeMethodInfoPtr__ctor_Public_Void_SerializedGainResearch_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x000CEDC4 File Offset: 0x000CCFC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170621, XrefRangeEnd = 170628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<ValueTuple<string, Object>> MakeAnalyticsData(WormMatch wormMatch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResearch.NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<string, Object>>>(intPtr3) : null;
			}
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x000CEE14 File Offset: 0x000CD014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170628, XrefRangeEnd = 170634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainResearch.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x000CEE60 File Offset: 0x000CD060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170634, XrefRangeEnd = 170641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> undo(Context undoContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainResearch.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x000CEEBC File Offset: 0x000CD0BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170641, XrefRangeEnd = 170646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainResearch.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x0000C9F3 File Offset: 0x0000ABF3
		public GainResearch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06001E34 RID: 7732 RVA: 0x000CEF18 File Offset: 0x000CD118
		// (set) Token: 0x06001E35 RID: 7733 RVA: 0x0000C9FC File Offset: 0x0000ABFC
		public unsafe WormPlayer player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06001E36 RID: 7734 RVA: 0x000CEF48 File Offset: 0x000CD148
		// (set) Token: 0x06001E37 RID: 7735 RVA: 0x0000CA1B File Offset: 0x0000AC1B
		public unsafe int TargetSpaceIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch.NativeFieldInfoPtr_TargetSpaceIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch.NativeFieldInfoPtr_TargetSpaceIndex)) = value;
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06001E38 RID: 7736 RVA: 0x000CEF70 File Offset: 0x000CD170
		// (set) Token: 0x06001E39 RID: 7737 RVA: 0x0000CA36 File Offset: 0x0000AC36
		public unsafe int gameLogID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch.NativeFieldInfoPtr_gameLogID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch.NativeFieldInfoPtr_gameLogID)) = value;
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06001E3A RID: 7738 RVA: 0x000CEF98 File Offset: 0x000CD198
		// (set) Token: 0x06001E3B RID: 7739 RVA: 0x0000CA51 File Offset: 0x0000AC51
		public unsafe ActionLogModes _LogMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch.NativeFieldInfoPtr__LogMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch.NativeFieldInfoPtr__LogMode_k__BackingField)) = value;
			}
		}

		// Token: 0x04001305 RID: 4869
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x04001306 RID: 4870
		private static readonly IntPtr NativeFieldInfoPtr_TargetSpaceIndex;

		// Token: 0x04001307 RID: 4871
		private static readonly IntPtr NativeFieldInfoPtr_gameLogID;

		// Token: 0x04001308 RID: 4872
		private static readonly IntPtr NativeFieldInfoPtr__LogMode_k__BackingField;

		// Token: 0x04001309 RID: 4873
		private static readonly IntPtr NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0;

		// Token: 0x0400130A RID: 4874
		private static readonly IntPtr NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0;

		// Token: 0x0400130B RID: 4875
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_WormSpace_0;

		// Token: 0x0400130C RID: 4876
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedGainResearch_Match_0;

		// Token: 0x0400130D RID: 4877
		private static readonly IntPtr NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_0;

		// Token: 0x0400130E RID: 4878
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x0400130F RID: 4879
		private static readonly IntPtr NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0;

		// Token: 0x04001310 RID: 4880
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x02000780 RID: 1920
		[ObfuscatedName("worm.canis.actions.Immortality.GainResearch+<MakeAnalyticsData>d__9")]
		public sealed class _MakeAnalyticsData_d__9 : Object
		{
			// Token: 0x06006BDC RID: 27612 RVA: 0x001FD220 File Offset: 0x001FB420
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeAnalyticsData_d__9()
			{
				Il2CppClassPointerStore<GainResearch._MakeAnalyticsData_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainResearch>.NativeClassPtr, "<MakeAnalyticsData>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainResearch._MakeAnalyticsData_d__9>.NativeClassPtr);
				GainResearch._MakeAnalyticsData_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResearch._MakeAnalyticsData_d__9>.NativeClassPtr, "<>1__state");
				GainResearch._MakeAnalyticsData_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResearch._MakeAnalyticsData_d__9>.NativeClassPtr, "<>2__current");
				GainResearch._MakeAnalyticsData_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResearch._MakeAnalyticsData_d__9>.NativeClassPtr, "<>l__initialThreadId");
				GainResearch._MakeAnalyticsData_d__9.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResearch._MakeAnalyticsData_d__9>.NativeClassPtr, "wormMatch");
				GainResearch._MakeAnalyticsData_d__9.NativeFieldInfoPtr___3__wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResearch._MakeAnalyticsData_d__9>.NativeClassPtr, "<>3__wormMatch");
				GainResearch._MakeAnalyticsData_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResearch._MakeAnalyticsData_d__9>.NativeClassPtr, "<>4__this");
				GainResearch._MakeAnalyticsData_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResearch._MakeAnalyticsData_d__9>.NativeClassPtr, 100670357);
				GainResearch._MakeAnalyticsData_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResearch._MakeAnalyticsData_d__9>.NativeClassPtr, 100670358);
				GainResearch._MakeAnalyticsData_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResearch._MakeAnalyticsData_d__9>.NativeClassPtr, 100670359);
				GainResearch._MakeAnalyticsData_d__9.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResearch._MakeAnalyticsData_d__9>.NativeClassPtr, 100670360);
				GainResearch._MakeAnalyticsData_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResearch._MakeAnalyticsData_d__9>.NativeClassPtr, 100670361);
				GainResearch._MakeAnalyticsData_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResearch._MakeAnalyticsData_d__9>.NativeClassPtr, 100670362);
				GainResearch._MakeAnalyticsData_d__9.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResearch._MakeAnalyticsData_d__9>.NativeClassPtr, 100670363);
				GainResearch._MakeAnalyticsData_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResearch._MakeAnalyticsData_d__9>.NativeClassPtr, 100670364);
			}

			// Token: 0x06006BDD RID: 27613 RVA: 0x001FD364 File Offset: 0x001FB564
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MakeAnalyticsData_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainResearch._MakeAnalyticsData_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResearch._MakeAnalyticsData_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006BDE RID: 27614 RVA: 0x001FD3AC File Offset: 0x001FB5AC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResearch._MakeAnalyticsData_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006BDF RID: 27615 RVA: 0x001FD3E0 File Offset: 0x001FB5E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170212, XrefRangeEnd = 170230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResearch._MakeAnalyticsData_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001D65 RID: 7525
			// (get) Token: 0x06006BE0 RID: 27616 RVA: 0x001FD41C File Offset: 0x001FB61C
			public unsafe ValueTuple<string, Object> prop_ValueTuple_2_String_Object_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResearch._MakeAnalyticsData_d__9.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<string, Object>(intPtr);
				}
			}

			// Token: 0x06006BE1 RID: 27617 RVA: 0x001FD454 File Offset: 0x001FB654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170230, XrefRangeEnd = 170235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResearch._MakeAnalyticsData_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D66 RID: 7526
			// (get) Token: 0x06006BE2 RID: 27618 RVA: 0x001FD488 File Offset: 0x001FB688
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170235, XrefRangeEnd = 170238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResearch._MakeAnalyticsData_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006BE3 RID: 27619 RVA: 0x001FD4C8 File Offset: 0x001FB6C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170238, XrefRangeEnd = 170247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<string, Object>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResearch._MakeAnalyticsData_d__9.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<string, Object>>>(intPtr3) : null;
			}

			// Token: 0x06006BE4 RID: 27620 RVA: 0x001FD508 File Offset: 0x001FB708
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResearch._MakeAnalyticsData_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006BE5 RID: 27621 RVA: 0x0002A96A File Offset: 0x00028B6A
			public _MakeAnalyticsData_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D5F RID: 7519
			// (get) Token: 0x06006BE6 RID: 27622 RVA: 0x001FD548 File Offset: 0x001FB748
			// (set) Token: 0x06006BE7 RID: 27623 RVA: 0x0002A973 File Offset: 0x00028B73
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._MakeAnalyticsData_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._MakeAnalyticsData_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D60 RID: 7520
			// (get) Token: 0x06006BE8 RID: 27624 RVA: 0x001FD570 File Offset: 0x001FB770
			// (set) Token: 0x06006BE9 RID: 27625 RVA: 0x0002A98E File Offset: 0x00028B8E
			public ValueTuple<string, Object> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._MakeAnalyticsData_d__9.NativeFieldInfoPtr___2__current);
					return new ValueTuple<string, Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._MakeAnalyticsData_d__9.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001D61 RID: 7521
			// (get) Token: 0x06006BEA RID: 27626 RVA: 0x001FD5A0 File Offset: 0x001FB7A0
			// (set) Token: 0x06006BEB RID: 27627 RVA: 0x0002A9BC File Offset: 0x00028BBC
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._MakeAnalyticsData_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._MakeAnalyticsData_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001D62 RID: 7522
			// (get) Token: 0x06006BEC RID: 27628 RVA: 0x001FD5C8 File Offset: 0x001FB7C8
			// (set) Token: 0x06006BED RID: 27629 RVA: 0x0002A9D7 File Offset: 0x00028BD7
			public unsafe WormMatch wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._MakeAnalyticsData_d__9.NativeFieldInfoPtr_wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._MakeAnalyticsData_d__9.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D63 RID: 7523
			// (get) Token: 0x06006BEE RID: 27630 RVA: 0x001FD5F8 File Offset: 0x001FB7F8
			// (set) Token: 0x06006BEF RID: 27631 RVA: 0x0002A9F6 File Offset: 0x00028BF6
			public unsafe WormMatch __3__wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._MakeAnalyticsData_d__9.NativeFieldInfoPtr___3__wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._MakeAnalyticsData_d__9.NativeFieldInfoPtr___3__wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D64 RID: 7524
			// (get) Token: 0x06006BF0 RID: 27632 RVA: 0x001FD628 File Offset: 0x001FB828
			// (set) Token: 0x06006BF1 RID: 27633 RVA: 0x0002AA15 File Offset: 0x00028C15
			public unsafe GainResearch __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._MakeAnalyticsData_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GainResearch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._MakeAnalyticsData_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040045BA RID: 17850
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040045BB RID: 17851
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040045BC RID: 17852
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040045BD RID: 17853
			private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

			// Token: 0x040045BE RID: 17854
			private static readonly IntPtr NativeFieldInfoPtr___3__wormMatch;

			// Token: 0x040045BF RID: 17855
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040045C0 RID: 17856
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040045C1 RID: 17857
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040045C2 RID: 17858
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040045C3 RID: 17859
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0;

			// Token: 0x040045C4 RID: 17860
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040045C5 RID: 17861
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040045C6 RID: 17862
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0;

			// Token: 0x040045C7 RID: 17863
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000781 RID: 1921
		[ObfuscatedName("worm.canis.actions.Immortality.GainResearch+<execute>d__10")]
		public sealed class _execute_d__10 : Object
		{
			// Token: 0x06006BF2 RID: 27634 RVA: 0x001FD658 File Offset: 0x001FB858
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__10()
			{
				Il2CppClassPointerStore<GainResearch._execute_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainResearch>.NativeClassPtr, "<execute>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainResearch._execute_d__10>.NativeClassPtr);
				GainResearch._execute_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResearch._execute_d__10>.NativeClassPtr, "<>1__state");
				GainResearch._execute_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResearch._execute_d__10>.NativeClassPtr, "<>2__current");
				GainResearch._execute_d__10.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResearch._execute_d__10>.NativeClassPtr, "<>l__initialThreadId");
				GainResearch._execute_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResearch._execute_d__10>.NativeClassPtr, "<>4__this");
				GainResearch._execute_d__10.NativeFieldInfoPtr__wm_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResearch._execute_d__10>.NativeClassPtr, "<wm>5__2");
				GainResearch._execute_d__10.NativeFieldInfoPtr__researchTrack_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResearch._execute_d__10>.NativeClassPtr, "<researchTrack>5__3");
				GainResearch._execute_d__10.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResearch._execute_d__10>.NativeClassPtr, "<>7__wrap3");
				GainResearch._execute_d__10.NativeFieldInfoPtr__sequenceHelper_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResearch._execute_d__10>.NativeClassPtr, "<sequenceHelper>5__5");
				GainResearch._execute_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResearch._execute_d__10>.NativeClassPtr, 100670365);
				GainResearch._execute_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResearch._execute_d__10>.NativeClassPtr, 100670366);
				GainResearch._execute_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResearch._execute_d__10>.NativeClassPtr, 100670367);
				GainResearch._execute_d__10.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResearch._execute_d__10>.NativeClassPtr, 100670368);
				GainResearch._execute_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResearch._execute_d__10>.NativeClassPtr, 100670369);
				GainResearch._execute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResearch._execute_d__10>.NativeClassPtr, 100670370);
				GainResearch._execute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResearch._execute_d__10>.NativeClassPtr, 100670371);
				GainResearch._execute_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResearch._execute_d__10>.NativeClassPtr, 100670372);
				GainResearch._execute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResearch._execute_d__10>.NativeClassPtr, 100670373);
			}

			// Token: 0x06006BF3 RID: 27635 RVA: 0x001FD7D8 File Offset: 0x001FB9D8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainResearch._execute_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResearch._execute_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006BF4 RID: 27636 RVA: 0x001FD820 File Offset: 0x001FBA20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170247, XrefRangeEnd = 170252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResearch._execute_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006BF5 RID: 27637 RVA: 0x001FD854 File Offset: 0x001FBA54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170252, XrefRangeEnd = 170414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResearch._execute_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006BF6 RID: 27638 RVA: 0x001FD890 File Offset: 0x001FBA90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170414, XrefRangeEnd = 170417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResearch._execute_d__10.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D6F RID: 7535
			// (get) Token: 0x06006BF7 RID: 27639 RVA: 0x001FD8C4 File Offset: 0x001FBAC4
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResearch._execute_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006BF8 RID: 27640 RVA: 0x001FD904 File Offset: 0x001FBB04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170417, XrefRangeEnd = 170422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResearch._execute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D70 RID: 7536
			// (get) Token: 0x06006BF9 RID: 27641 RVA: 0x001FD938 File Offset: 0x001FBB38
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResearch._execute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006BFA RID: 27642 RVA: 0x001FD978 File Offset: 0x001FBB78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170422, XrefRangeEnd = 170424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResearch._execute_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006BFB RID: 27643 RVA: 0x001FD9B8 File Offset: 0x001FBBB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResearch._execute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006BFC RID: 27644 RVA: 0x0002AA34 File Offset: 0x00028C34
			public _execute_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D67 RID: 7527
			// (get) Token: 0x06006BFD RID: 27645 RVA: 0x001FD9F8 File Offset: 0x001FBBF8
			// (set) Token: 0x06006BFE RID: 27646 RVA: 0x0002AA3D File Offset: 0x00028C3D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._execute_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._execute_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D68 RID: 7528
			// (get) Token: 0x06006BFF RID: 27647 RVA: 0x001FDA20 File Offset: 0x001FBC20
			// (set) Token: 0x06006C00 RID: 27648 RVA: 0x0002AA58 File Offset: 0x00028C58
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._execute_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._execute_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D69 RID: 7529
			// (get) Token: 0x06006C01 RID: 27649 RVA: 0x001FDA50 File Offset: 0x001FBC50
			// (set) Token: 0x06006C02 RID: 27650 RVA: 0x0002AA77 File Offset: 0x00028C77
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._execute_d__10.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._execute_d__10.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001D6A RID: 7530
			// (get) Token: 0x06006C03 RID: 27651 RVA: 0x001FDA78 File Offset: 0x001FBC78
			// (set) Token: 0x06006C04 RID: 27652 RVA: 0x0002AA92 File Offset: 0x00028C92
			public unsafe GainResearch __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._execute_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GainResearch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._execute_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D6B RID: 7531
			// (get) Token: 0x06006C05 RID: 27653 RVA: 0x001FDAA8 File Offset: 0x001FBCA8
			// (set) Token: 0x06006C06 RID: 27654 RVA: 0x0002AAB1 File Offset: 0x00028CB1
			public unsafe WormMatch _wm_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._execute_d__10.NativeFieldInfoPtr__wm_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._execute_d__10.NativeFieldInfoPtr__wm_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D6C RID: 7532
			// (get) Token: 0x06006C07 RID: 27655 RVA: 0x001FDAD8 File Offset: 0x001FBCD8
			// (set) Token: 0x06006C08 RID: 27656 RVA: 0x0002AAD0 File Offset: 0x00028CD0
			public unsafe WormResearchTrack _researchTrack_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._execute_d__10.NativeFieldInfoPtr__researchTrack_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormResearchTrack>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._execute_d__10.NativeFieldInfoPtr__researchTrack_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D6D RID: 7533
			// (get) Token: 0x06006C09 RID: 27657 RVA: 0x001FDB08 File Offset: 0x001FBD08
			// (set) Token: 0x06006C0A RID: 27658 RVA: 0x0002AAEF File Offset: 0x00028CEF
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._execute_d__10.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._execute_d__10.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D6E RID: 7534
			// (get) Token: 0x06006C0B RID: 27659 RVA: 0x001FDB38 File Offset: 0x001FBD38
			// (set) Token: 0x06006C0C RID: 27660 RVA: 0x0002AB0E File Offset: 0x00028D0E
			public unsafe SequenceHelper _sequenceHelper_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._execute_d__10.NativeFieldInfoPtr__sequenceHelper_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._execute_d__10.NativeFieldInfoPtr__sequenceHelper_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040045C8 RID: 17864
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040045C9 RID: 17865
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040045CA RID: 17866
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040045CB RID: 17867
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040045CC RID: 17868
			private static readonly IntPtr NativeFieldInfoPtr__wm_5__2;

			// Token: 0x040045CD RID: 17869
			private static readonly IntPtr NativeFieldInfoPtr__researchTrack_5__3;

			// Token: 0x040045CE RID: 17870
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x040045CF RID: 17871
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__5;

			// Token: 0x040045D0 RID: 17872
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040045D1 RID: 17873
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040045D2 RID: 17874
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040045D3 RID: 17875
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040045D4 RID: 17876
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040045D5 RID: 17877
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040045D6 RID: 17878
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040045D7 RID: 17879
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040045D8 RID: 17880
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000782 RID: 1922
		[ObfuscatedName("worm.canis.actions.Immortality.GainResearch+<undo>d__11")]
		public sealed class _undo_d__11 : Object
		{
			// Token: 0x06006C0D RID: 27661 RVA: 0x001FDB68 File Offset: 0x001FBD68
			// Note: this type is marked as 'beforefieldinit'.
			static _undo_d__11()
			{
				Il2CppClassPointerStore<GainResearch._undo_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainResearch>.NativeClassPtr, "<undo>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainResearch._undo_d__11>.NativeClassPtr);
				GainResearch._undo_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResearch._undo_d__11>.NativeClassPtr, "<>1__state");
				GainResearch._undo_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResearch._undo_d__11>.NativeClassPtr, "<>2__current");
				GainResearch._undo_d__11.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResearch._undo_d__11>.NativeClassPtr, "<>l__initialThreadId");
				GainResearch._undo_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResearch._undo_d__11>.NativeClassPtr, "<>4__this");
				GainResearch._undo_d__11.NativeFieldInfoPtr_undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResearch._undo_d__11>.NativeClassPtr, "undoContext");
				GainResearch._undo_d__11.NativeFieldInfoPtr___3__undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResearch._undo_d__11>.NativeClassPtr, "<>3__undoContext");
				GainResearch._undo_d__11.NativeFieldInfoPtr__wm_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResearch._undo_d__11>.NativeClassPtr, "<wm>5__2");
				GainResearch._undo_d__11.NativeFieldInfoPtr__undoNode_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResearch._undo_d__11>.NativeClassPtr, "<undoNode>5__3");
				GainResearch._undo_d__11.NativeFieldInfoPtr__originSpace_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResearch._undo_d__11>.NativeClassPtr, "<originSpace>5__4");
				GainResearch._undo_d__11.NativeFieldInfoPtr__marker_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResearch._undo_d__11>.NativeClassPtr, "<marker>5__5");
				GainResearch._undo_d__11.NativeFieldInfoPtr__markerDiff_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResearch._undo_d__11>.NativeClassPtr, "<markerDiff>5__6");
				GainResearch._undo_d__11.NativeFieldInfoPtr__sequenceHelper_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainResearch._undo_d__11>.NativeClassPtr, "<sequenceHelper>5__7");
				GainResearch._undo_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResearch._undo_d__11>.NativeClassPtr, 100670374);
				GainResearch._undo_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResearch._undo_d__11>.NativeClassPtr, 100670375);
				GainResearch._undo_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResearch._undo_d__11>.NativeClassPtr, 100670376);
				GainResearch._undo_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResearch._undo_d__11>.NativeClassPtr, 100670377);
				GainResearch._undo_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResearch._undo_d__11>.NativeClassPtr, 100670378);
				GainResearch._undo_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResearch._undo_d__11>.NativeClassPtr, 100670379);
				GainResearch._undo_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResearch._undo_d__11>.NativeClassPtr, 100670380);
				GainResearch._undo_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainResearch._undo_d__11>.NativeClassPtr, 100670381);
			}

			// Token: 0x06006C0E RID: 27662 RVA: 0x001FDD24 File Offset: 0x001FBF24
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _undo_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainResearch._undo_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResearch._undo_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006C0F RID: 27663 RVA: 0x001FDD6C File Offset: 0x001FBF6C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResearch._undo_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006C10 RID: 27664 RVA: 0x001FDDA0 File Offset: 0x001FBFA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170424, XrefRangeEnd = 170580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResearch._undo_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001D7D RID: 7549
			// (get) Token: 0x06006C11 RID: 27665 RVA: 0x001FDDDC File Offset: 0x001FBFDC
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResearch._undo_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006C12 RID: 27666 RVA: 0x001FDE1C File Offset: 0x001FC01C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170580, XrefRangeEnd = 170585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResearch._undo_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D7E RID: 7550
			// (get) Token: 0x06006C13 RID: 27667 RVA: 0x001FDE50 File Offset: 0x001FC050
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResearch._undo_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006C14 RID: 27668 RVA: 0x001FDE90 File Offset: 0x001FC090
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170585, XrefRangeEnd = 170594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResearch._undo_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006C15 RID: 27669 RVA: 0x001FDED0 File Offset: 0x001FC0D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainResearch._undo_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006C16 RID: 27670 RVA: 0x0002AB2D File Offset: 0x00028D2D
			public _undo_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D71 RID: 7537
			// (get) Token: 0x06006C17 RID: 27671 RVA: 0x001FDF10 File Offset: 0x001FC110
			// (set) Token: 0x06006C18 RID: 27672 RVA: 0x0002AB36 File Offset: 0x00028D36
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._undo_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._undo_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D72 RID: 7538
			// (get) Token: 0x06006C19 RID: 27673 RVA: 0x001FDF38 File Offset: 0x001FC138
			// (set) Token: 0x06006C1A RID: 27674 RVA: 0x0002AB51 File Offset: 0x00028D51
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._undo_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._undo_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D73 RID: 7539
			// (get) Token: 0x06006C1B RID: 27675 RVA: 0x001FDF68 File Offset: 0x001FC168
			// (set) Token: 0x06006C1C RID: 27676 RVA: 0x0002AB70 File Offset: 0x00028D70
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._undo_d__11.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._undo_d__11.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001D74 RID: 7540
			// (get) Token: 0x06006C1D RID: 27677 RVA: 0x001FDF90 File Offset: 0x001FC190
			// (set) Token: 0x06006C1E RID: 27678 RVA: 0x0002AB8B File Offset: 0x00028D8B
			public unsafe GainResearch __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._undo_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GainResearch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._undo_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D75 RID: 7541
			// (get) Token: 0x06006C1F RID: 27679 RVA: 0x001FDFC0 File Offset: 0x001FC1C0
			// (set) Token: 0x06006C20 RID: 27680 RVA: 0x0002ABAA File Offset: 0x00028DAA
			public unsafe Context undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._undo_d__11.NativeFieldInfoPtr_undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._undo_d__11.NativeFieldInfoPtr_undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D76 RID: 7542
			// (get) Token: 0x06006C21 RID: 27681 RVA: 0x001FDFF0 File Offset: 0x001FC1F0
			// (set) Token: 0x06006C22 RID: 27682 RVA: 0x0002ABC9 File Offset: 0x00028DC9
			public unsafe Context __3__undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._undo_d__11.NativeFieldInfoPtr___3__undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._undo_d__11.NativeFieldInfoPtr___3__undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D77 RID: 7543
			// (get) Token: 0x06006C23 RID: 27683 RVA: 0x001FE020 File Offset: 0x001FC220
			// (set) Token: 0x06006C24 RID: 27684 RVA: 0x0002ABE8 File Offset: 0x00028DE8
			public unsafe WormMatch _wm_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._undo_d__11.NativeFieldInfoPtr__wm_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._undo_d__11.NativeFieldInfoPtr__wm_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D78 RID: 7544
			// (get) Token: 0x06006C25 RID: 27685 RVA: 0x001FE050 File Offset: 0x001FC250
			// (set) Token: 0x06006C26 RID: 27686 RVA: 0x0002AC07 File Offset: 0x00028E07
			public unsafe UndoNode _undoNode_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._undo_d__11.NativeFieldInfoPtr__undoNode_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._undo_d__11.NativeFieldInfoPtr__undoNode_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D79 RID: 7545
			// (get) Token: 0x06006C27 RID: 27687 RVA: 0x001FE080 File Offset: 0x001FC280
			// (set) Token: 0x06006C28 RID: 27688 RVA: 0x0002AC26 File Offset: 0x00028E26
			public unsafe WormSpace _originSpace_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._undo_d__11.NativeFieldInfoPtr__originSpace_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._undo_d__11.NativeFieldInfoPtr__originSpace_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D7A RID: 7546
			// (get) Token: 0x06006C29 RID: 27689 RVA: 0x001FE0B0 File Offset: 0x001FC2B0
			// (set) Token: 0x06006C2A RID: 27690 RVA: 0x0002AC45 File Offset: 0x00028E45
			public unsafe Entity _marker_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._undo_d__11.NativeFieldInfoPtr__marker_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._undo_d__11.NativeFieldInfoPtr__marker_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D7B RID: 7547
			// (get) Token: 0x06006C2B RID: 27691 RVA: 0x001FE0E0 File Offset: 0x001FC2E0
			// (set) Token: 0x06006C2C RID: 27692 RVA: 0x0002AC64 File Offset: 0x00028E64
			public unsafe int _markerDiff_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._undo_d__11.NativeFieldInfoPtr__markerDiff_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._undo_d__11.NativeFieldInfoPtr__markerDiff_5__6)) = value;
				}
			}

			// Token: 0x17001D7C RID: 7548
			// (get) Token: 0x06006C2D RID: 27693 RVA: 0x001FE108 File Offset: 0x001FC308
			// (set) Token: 0x06006C2E RID: 27694 RVA: 0x0002AC7F File Offset: 0x00028E7F
			public unsafe SequenceHelper _sequenceHelper_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._undo_d__11.NativeFieldInfoPtr__sequenceHelper_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainResearch._undo_d__11.NativeFieldInfoPtr__sequenceHelper_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040045D9 RID: 17881
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040045DA RID: 17882
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040045DB RID: 17883
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040045DC RID: 17884
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040045DD RID: 17885
			private static readonly IntPtr NativeFieldInfoPtr_undoContext;

			// Token: 0x040045DE RID: 17886
			private static readonly IntPtr NativeFieldInfoPtr___3__undoContext;

			// Token: 0x040045DF RID: 17887
			private static readonly IntPtr NativeFieldInfoPtr__wm_5__2;

			// Token: 0x040045E0 RID: 17888
			private static readonly IntPtr NativeFieldInfoPtr__undoNode_5__3;

			// Token: 0x040045E1 RID: 17889
			private static readonly IntPtr NativeFieldInfoPtr__originSpace_5__4;

			// Token: 0x040045E2 RID: 17890
			private static readonly IntPtr NativeFieldInfoPtr__marker_5__5;

			// Token: 0x040045E3 RID: 17891
			private static readonly IntPtr NativeFieldInfoPtr__markerDiff_5__6;

			// Token: 0x040045E4 RID: 17892
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__7;

			// Token: 0x040045E5 RID: 17893
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040045E6 RID: 17894
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040045E7 RID: 17895
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040045E8 RID: 17896
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040045E9 RID: 17897
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040045EA RID: 17898
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040045EB RID: 17899
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040045EC RID: 17900
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

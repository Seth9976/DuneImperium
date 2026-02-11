using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.context;
using Canis.entities;
using Canis.gameLogs;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.actions
{
	// Token: 0x0200029F RID: 671
	public class TrashCard : global::Canis.actions.Action
	{
		// Token: 0x06001BDF RID: 7135 RVA: 0x000C5330 File Offset: 0x000C3530
		// Note: this type is marked as 'beforefieldinit'.
		static TrashCard()
		{
			Il2CppClassPointerStore<TrashCard>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "TrashCard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashCard>.NativeClassPtr);
			TrashCard.NativeFieldInfoPtr__LogMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard>.NativeClassPtr, "<LogMode>k__BackingField");
			TrashCard.NativeFieldInfoPtr_ShowSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard>.NativeClassPtr, "ShowSequence");
			TrashCard.NativeFieldInfoPtr_ReplaceImperiumRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard>.NativeClassPtr, "ReplaceImperiumRow");
			TrashCard.NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashCard>.NativeClassPtr, 100668918);
			TrashCard.NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashCard>.NativeClassPtr, 100668919);
			TrashCard.NativeMethodInfoPtr__ctor_Public_Void_Match_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashCard>.NativeClassPtr, 100668920);
			TrashCard.NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashCard>.NativeClassPtr, 100668921);
			TrashCard.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashCard>.NativeClassPtr, 100668922);
			TrashCard.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashCard>.NativeClassPtr, 100668923);
			TrashCard.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashCard>.NativeClassPtr, 100668924);
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06001BE0 RID: 7136 RVA: 0x000C5428 File Offset: 0x000C3628
		// (set) Token: 0x06001BE1 RID: 7137 RVA: 0x000C5464 File Offset: 0x000C3664
		public unsafe virtual ActionLogModes LogMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashCard.NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashCard.NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x000C54A4 File Offset: 0x000C36A4
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 148937, RefRangeEnd = 148961, XrefRangeStart = 148936, XrefRangeEnd = 148937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashCard(Match m, bool showSequence = true, bool replaceImperiumRow = true)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashCard>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref showSequence;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref replaceImperiumRow;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashCard.NativeMethodInfoPtr__ctor_Public_Void_Match_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x000C550C File Offset: 0x000C370C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148961, XrefRangeEnd = 148969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<ValueTuple<string, Object>> MakeAnalyticsData(WormMatch wormMatch, WormPlayer player, WormImperiumPlayable imperiumCard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(imperiumCard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashCard.NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<string, Object>>>(intPtr3) : null;
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x000C5580 File Offset: 0x000C3780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148969, XrefRangeEnd = 148975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashCard.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x000C55CC File Offset: 0x000C37CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148975, XrefRangeEnd = 148981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> undo(Context undoContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashCard.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x000C5628 File Offset: 0x000C3828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148981, XrefRangeEnd = 148985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashCard.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x0000BDE7 File Offset: 0x00009FE7
		public TrashCard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06001BE8 RID: 7144 RVA: 0x000C5684 File Offset: 0x000C3884
		// (set) Token: 0x06001BE9 RID: 7145 RVA: 0x0000BDF0 File Offset: 0x00009FF0
		public unsafe ActionLogModes _LogMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard.NativeFieldInfoPtr__LogMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard.NativeFieldInfoPtr__LogMode_k__BackingField)) = value;
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06001BEA RID: 7146 RVA: 0x000C56AC File Offset: 0x000C38AC
		// (set) Token: 0x06001BEB RID: 7147 RVA: 0x0000BE0B File Offset: 0x0000A00B
		public unsafe bool ShowSequence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard.NativeFieldInfoPtr_ShowSequence);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard.NativeFieldInfoPtr_ShowSequence)) = value;
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06001BEC RID: 7148 RVA: 0x000C56D4 File Offset: 0x000C38D4
		// (set) Token: 0x06001BED RID: 7149 RVA: 0x0000BE26 File Offset: 0x0000A026
		public unsafe bool ReplaceImperiumRow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard.NativeFieldInfoPtr_ReplaceImperiumRow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard.NativeFieldInfoPtr_ReplaceImperiumRow)) = value;
			}
		}

		// Token: 0x04001135 RID: 4405
		private static readonly IntPtr NativeFieldInfoPtr__LogMode_k__BackingField;

		// Token: 0x04001136 RID: 4406
		private static readonly IntPtr NativeFieldInfoPtr_ShowSequence;

		// Token: 0x04001137 RID: 4407
		private static readonly IntPtr NativeFieldInfoPtr_ReplaceImperiumRow;

		// Token: 0x04001138 RID: 4408
		private static readonly IntPtr NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0;

		// Token: 0x04001139 RID: 4409
		private static readonly IntPtr NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0;

		// Token: 0x0400113A RID: 4410
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_Boolean_Boolean_0;

		// Token: 0x0400113B RID: 4411
		private static readonly IntPtr NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_WormImperiumPlayable_0;

		// Token: 0x0400113C RID: 4412
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x0400113D RID: 4413
		private static readonly IntPtr NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0;

		// Token: 0x0400113E RID: 4414
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x020006ED RID: 1773
		[ObfuscatedName("worm.canis.actions.TrashCard+<MakeAnalyticsData>d__7")]
		public sealed class _MakeAnalyticsData_d__7 : Object
		{
			// Token: 0x06005F5C RID: 24412 RVA: 0x001D6880 File Offset: 0x001D4A80
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeAnalyticsData_d__7()
			{
				Il2CppClassPointerStore<TrashCard._MakeAnalyticsData_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrashCard>.NativeClassPtr, "<MakeAnalyticsData>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashCard._MakeAnalyticsData_d__7>.NativeClassPtr);
				TrashCard._MakeAnalyticsData_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._MakeAnalyticsData_d__7>.NativeClassPtr, "<>1__state");
				TrashCard._MakeAnalyticsData_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._MakeAnalyticsData_d__7>.NativeClassPtr, "<>2__current");
				TrashCard._MakeAnalyticsData_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._MakeAnalyticsData_d__7>.NativeClassPtr, "<>l__initialThreadId");
				TrashCard._MakeAnalyticsData_d__7.NativeFieldInfoPtr_imperiumCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._MakeAnalyticsData_d__7>.NativeClassPtr, "imperiumCard");
				TrashCard._MakeAnalyticsData_d__7.NativeFieldInfoPtr___3__imperiumCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._MakeAnalyticsData_d__7>.NativeClassPtr, "<>3__imperiumCard");
				TrashCard._MakeAnalyticsData_d__7.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._MakeAnalyticsData_d__7>.NativeClassPtr, "player");
				TrashCard._MakeAnalyticsData_d__7.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._MakeAnalyticsData_d__7>.NativeClassPtr, "<>3__player");
				TrashCard._MakeAnalyticsData_d__7.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._MakeAnalyticsData_d__7>.NativeClassPtr, "wormMatch");
				TrashCard._MakeAnalyticsData_d__7.NativeFieldInfoPtr___3__wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._MakeAnalyticsData_d__7>.NativeClassPtr, "<>3__wormMatch");
				TrashCard._MakeAnalyticsData_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashCard._MakeAnalyticsData_d__7>.NativeClassPtr, 100668925);
				TrashCard._MakeAnalyticsData_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashCard._MakeAnalyticsData_d__7>.NativeClassPtr, 100668926);
				TrashCard._MakeAnalyticsData_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashCard._MakeAnalyticsData_d__7>.NativeClassPtr, 100668927);
				TrashCard._MakeAnalyticsData_d__7.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashCard._MakeAnalyticsData_d__7>.NativeClassPtr, 100668928);
				TrashCard._MakeAnalyticsData_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashCard._MakeAnalyticsData_d__7>.NativeClassPtr, 100668929);
				TrashCard._MakeAnalyticsData_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashCard._MakeAnalyticsData_d__7>.NativeClassPtr, 100668930);
				TrashCard._MakeAnalyticsData_d__7.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashCard._MakeAnalyticsData_d__7>.NativeClassPtr, 100668931);
				TrashCard._MakeAnalyticsData_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashCard._MakeAnalyticsData_d__7>.NativeClassPtr, 100668932);
			}

			// Token: 0x06005F5D RID: 24413 RVA: 0x001D6A00 File Offset: 0x001D4C00
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MakeAnalyticsData_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashCard._MakeAnalyticsData_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashCard._MakeAnalyticsData_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005F5E RID: 24414 RVA: 0x001D6A48 File Offset: 0x001D4C48
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashCard._MakeAnalyticsData_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005F5F RID: 24415 RVA: 0x001D6A7C File Offset: 0x001D4C7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148148, XrefRangeEnd = 148161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashCard._MakeAnalyticsData_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001926 RID: 6438
			// (get) Token: 0x06005F60 RID: 24416 RVA: 0x001D6AB8 File Offset: 0x001D4CB8
			public unsafe ValueTuple<string, Object> prop_ValueTuple_2_String_Object_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashCard._MakeAnalyticsData_d__7.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<string, Object>(intPtr);
				}
			}

			// Token: 0x06005F61 RID: 24417 RVA: 0x001D6AF0 File Offset: 0x001D4CF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148161, XrefRangeEnd = 148166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashCard._MakeAnalyticsData_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001927 RID: 6439
			// (get) Token: 0x06005F62 RID: 24418 RVA: 0x001D6B24 File Offset: 0x001D4D24
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148166, XrefRangeEnd = 148169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashCard._MakeAnalyticsData_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005F63 RID: 24419 RVA: 0x001D6B64 File Offset: 0x001D4D64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148169, XrefRangeEnd = 148179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<string, Object>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashCard._MakeAnalyticsData_d__7.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<string, Object>>>(intPtr3) : null;
			}

			// Token: 0x06005F64 RID: 24420 RVA: 0x001D6BA4 File Offset: 0x001D4DA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashCard._MakeAnalyticsData_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005F65 RID: 24421 RVA: 0x00024232 File Offset: 0x00022432
			public _MakeAnalyticsData_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700191D RID: 6429
			// (get) Token: 0x06005F66 RID: 24422 RVA: 0x001D6BE4 File Offset: 0x001D4DE4
			// (set) Token: 0x06005F67 RID: 24423 RVA: 0x0002423B File Offset: 0x0002243B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._MakeAnalyticsData_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._MakeAnalyticsData_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700191E RID: 6430
			// (get) Token: 0x06005F68 RID: 24424 RVA: 0x001D6C0C File Offset: 0x001D4E0C
			// (set) Token: 0x06005F69 RID: 24425 RVA: 0x00024256 File Offset: 0x00022456
			public ValueTuple<string, Object> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._MakeAnalyticsData_d__7.NativeFieldInfoPtr___2__current);
					return new ValueTuple<string, Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._MakeAnalyticsData_d__7.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700191F RID: 6431
			// (get) Token: 0x06005F6A RID: 24426 RVA: 0x001D6C3C File Offset: 0x001D4E3C
			// (set) Token: 0x06005F6B RID: 24427 RVA: 0x00024284 File Offset: 0x00022484
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._MakeAnalyticsData_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._MakeAnalyticsData_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001920 RID: 6432
			// (get) Token: 0x06005F6C RID: 24428 RVA: 0x001D6C64 File Offset: 0x001D4E64
			// (set) Token: 0x06005F6D RID: 24429 RVA: 0x0002429F File Offset: 0x0002249F
			public unsafe WormImperiumPlayable imperiumCard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._MakeAnalyticsData_d__7.NativeFieldInfoPtr_imperiumCard);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._MakeAnalyticsData_d__7.NativeFieldInfoPtr_imperiumCard), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001921 RID: 6433
			// (get) Token: 0x06005F6E RID: 24430 RVA: 0x001D6C94 File Offset: 0x001D4E94
			// (set) Token: 0x06005F6F RID: 24431 RVA: 0x000242BE File Offset: 0x000224BE
			public unsafe WormImperiumPlayable __3__imperiumCard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._MakeAnalyticsData_d__7.NativeFieldInfoPtr___3__imperiumCard);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._MakeAnalyticsData_d__7.NativeFieldInfoPtr___3__imperiumCard), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001922 RID: 6434
			// (get) Token: 0x06005F70 RID: 24432 RVA: 0x001D6CC4 File Offset: 0x001D4EC4
			// (set) Token: 0x06005F71 RID: 24433 RVA: 0x000242DD File Offset: 0x000224DD
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._MakeAnalyticsData_d__7.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._MakeAnalyticsData_d__7.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001923 RID: 6435
			// (get) Token: 0x06005F72 RID: 24434 RVA: 0x001D6CF4 File Offset: 0x001D4EF4
			// (set) Token: 0x06005F73 RID: 24435 RVA: 0x000242FC File Offset: 0x000224FC
			public unsafe WormPlayer __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._MakeAnalyticsData_d__7.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._MakeAnalyticsData_d__7.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001924 RID: 6436
			// (get) Token: 0x06005F74 RID: 24436 RVA: 0x001D6D24 File Offset: 0x001D4F24
			// (set) Token: 0x06005F75 RID: 24437 RVA: 0x0002431B File Offset: 0x0002251B
			public unsafe WormMatch wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._MakeAnalyticsData_d__7.NativeFieldInfoPtr_wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._MakeAnalyticsData_d__7.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001925 RID: 6437
			// (get) Token: 0x06005F76 RID: 24438 RVA: 0x001D6D54 File Offset: 0x001D4F54
			// (set) Token: 0x06005F77 RID: 24439 RVA: 0x0002433A File Offset: 0x0002253A
			public unsafe WormMatch __3__wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._MakeAnalyticsData_d__7.NativeFieldInfoPtr___3__wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._MakeAnalyticsData_d__7.NativeFieldInfoPtr___3__wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003DE2 RID: 15842
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003DE3 RID: 15843
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003DE4 RID: 15844
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003DE5 RID: 15845
			private static readonly IntPtr NativeFieldInfoPtr_imperiumCard;

			// Token: 0x04003DE6 RID: 15846
			private static readonly IntPtr NativeFieldInfoPtr___3__imperiumCard;

			// Token: 0x04003DE7 RID: 15847
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04003DE8 RID: 15848
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x04003DE9 RID: 15849
			private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

			// Token: 0x04003DEA RID: 15850
			private static readonly IntPtr NativeFieldInfoPtr___3__wormMatch;

			// Token: 0x04003DEB RID: 15851
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003DEC RID: 15852
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003DED RID: 15853
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003DEE RID: 15854
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0;

			// Token: 0x04003DEF RID: 15855
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003DF0 RID: 15856
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003DF1 RID: 15857
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0;

			// Token: 0x04003DF2 RID: 15858
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020006EE RID: 1774
		[ObfuscatedName("worm.canis.actions.TrashCard+<execute>d__8")]
		public sealed class _execute_d__8 : Object
		{
			// Token: 0x06005F78 RID: 24440 RVA: 0x001D6D84 File Offset: 0x001D4F84
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__8()
			{
				Il2CppClassPointerStore<TrashCard._execute_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrashCard>.NativeClassPtr, "<execute>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashCard._execute_d__8>.NativeClassPtr);
				TrashCard._execute_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._execute_d__8>.NativeClassPtr, "<>1__state");
				TrashCard._execute_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._execute_d__8>.NativeClassPtr, "<>2__current");
				TrashCard._execute_d__8.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._execute_d__8>.NativeClassPtr, "<>l__initialThreadId");
				TrashCard._execute_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._execute_d__8>.NativeClassPtr, "<>4__this");
				TrashCard._execute_d__8.NativeFieldInfoPtr__card_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._execute_d__8>.NativeClassPtr, "<card>5__2");
				TrashCard._execute_d__8.NativeFieldInfoPtr__wm_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._execute_d__8>.NativeClassPtr, "<wm>5__3");
				TrashCard._execute_d__8.NativeFieldInfoPtr__trashPile_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._execute_d__8>.NativeClassPtr, "<trashPile>5__4");
				TrashCard._execute_d__8.NativeFieldInfoPtr__fromImperiumRow_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._execute_d__8>.NativeClassPtr, "<fromImperiumRow>5__5");
				TrashCard._execute_d__8.NativeFieldInfoPtr__sequenceHelper_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._execute_d__8>.NativeClassPtr, "<sequenceHelper>5__6");
				TrashCard._execute_d__8.NativeFieldInfoPtr__moveAction_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._execute_d__8>.NativeClassPtr, "<moveAction>5__7");
				TrashCard._execute_d__8.NativeFieldInfoPtr__gameLogBuilder_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._execute_d__8>.NativeClassPtr, "<gameLogBuilder>5__8");
				TrashCard._execute_d__8.NativeFieldInfoPtr__trashedAcquiredCard_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._execute_d__8>.NativeClassPtr, "<trashedAcquiredCard>5__9");
				TrashCard._execute_d__8.NativeFieldInfoPtr__player_5__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._execute_d__8>.NativeClassPtr, "<player>5__10");
				TrashCard._execute_d__8.NativeFieldInfoPtr__childUndo_5__11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._execute_d__8>.NativeClassPtr, "<childUndo>5__11");
				TrashCard._execute_d__8.NativeFieldInfoPtr___7__wrap11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._execute_d__8>.NativeClassPtr, "<>7__wrap11");
				TrashCard._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashCard._execute_d__8>.NativeClassPtr, 100668933);
				TrashCard._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashCard._execute_d__8>.NativeClassPtr, 100668934);
				TrashCard._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashCard._execute_d__8>.NativeClassPtr, 100668935);
				TrashCard._execute_d__8.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashCard._execute_d__8>.NativeClassPtr, 100668936);
				TrashCard._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashCard._execute_d__8>.NativeClassPtr, 100668937);
				TrashCard._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashCard._execute_d__8>.NativeClassPtr, 100668938);
				TrashCard._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashCard._execute_d__8>.NativeClassPtr, 100668939);
				TrashCard._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashCard._execute_d__8>.NativeClassPtr, 100668940);
				TrashCard._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashCard._execute_d__8>.NativeClassPtr, 100668941);
			}

			// Token: 0x06005F79 RID: 24441 RVA: 0x001D6F90 File Offset: 0x001D5190
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashCard._execute_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashCard._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005F7A RID: 24442 RVA: 0x001D6FD8 File Offset: 0x001D51D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148179, XrefRangeEnd = 148182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashCard._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005F7B RID: 24443 RVA: 0x001D700C File Offset: 0x001D520C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148182, XrefRangeEnd = 148628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashCard._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005F7C RID: 24444 RVA: 0x001D7048 File Offset: 0x001D5248
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148628, XrefRangeEnd = 148631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashCard._execute_d__8.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001937 RID: 6455
			// (get) Token: 0x06005F7D RID: 24445 RVA: 0x001D707C File Offset: 0x001D527C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashCard._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005F7E RID: 24446 RVA: 0x001D70BC File Offset: 0x001D52BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148631, XrefRangeEnd = 148636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashCard._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001938 RID: 6456
			// (get) Token: 0x06005F7F RID: 24447 RVA: 0x001D70F0 File Offset: 0x001D52F0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashCard._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005F80 RID: 24448 RVA: 0x001D7130 File Offset: 0x001D5330
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148636, XrefRangeEnd = 148638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashCard._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005F81 RID: 24449 RVA: 0x001D7170 File Offset: 0x001D5370
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashCard._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005F82 RID: 24450 RVA: 0x00024359 File Offset: 0x00022559
			public _execute_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001928 RID: 6440
			// (get) Token: 0x06005F83 RID: 24451 RVA: 0x001D71B0 File Offset: 0x001D53B0
			// (set) Token: 0x06005F84 RID: 24452 RVA: 0x00024362 File Offset: 0x00022562
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._execute_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._execute_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001929 RID: 6441
			// (get) Token: 0x06005F85 RID: 24453 RVA: 0x001D71D8 File Offset: 0x001D53D8
			// (set) Token: 0x06005F86 RID: 24454 RVA: 0x0002437D File Offset: 0x0002257D
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._execute_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._execute_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700192A RID: 6442
			// (get) Token: 0x06005F87 RID: 24455 RVA: 0x001D7208 File Offset: 0x001D5408
			// (set) Token: 0x06005F88 RID: 24456 RVA: 0x0002439C File Offset: 0x0002259C
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._execute_d__8.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._execute_d__8.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700192B RID: 6443
			// (get) Token: 0x06005F89 RID: 24457 RVA: 0x001D7230 File Offset: 0x001D5430
			// (set) Token: 0x06005F8A RID: 24458 RVA: 0x000243B7 File Offset: 0x000225B7
			public unsafe TrashCard __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._execute_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashCard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._execute_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700192C RID: 6444
			// (get) Token: 0x06005F8B RID: 24459 RVA: 0x001D7260 File Offset: 0x001D5460
			// (set) Token: 0x06005F8C RID: 24460 RVA: 0x000243D6 File Offset: 0x000225D6
			public unsafe WormImperiumPlayable _card_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._execute_d__8.NativeFieldInfoPtr__card_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._execute_d__8.NativeFieldInfoPtr__card_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700192D RID: 6445
			// (get) Token: 0x06005F8D RID: 24461 RVA: 0x001D7290 File Offset: 0x001D5490
			// (set) Token: 0x06005F8E RID: 24462 RVA: 0x000243F5 File Offset: 0x000225F5
			public unsafe WormMatch _wm_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._execute_d__8.NativeFieldInfoPtr__wm_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._execute_d__8.NativeFieldInfoPtr__wm_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700192E RID: 6446
			// (get) Token: 0x06005F8F RID: 24463 RVA: 0x001D72C0 File Offset: 0x001D54C0
			// (set) Token: 0x06005F90 RID: 24464 RVA: 0x00024414 File Offset: 0x00022614
			public unsafe WormPlayArea _trashPile_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._execute_d__8.NativeFieldInfoPtr__trashPile_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._execute_d__8.NativeFieldInfoPtr__trashPile_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700192F RID: 6447
			// (get) Token: 0x06005F91 RID: 24465 RVA: 0x001D72F0 File Offset: 0x001D54F0
			// (set) Token: 0x06005F92 RID: 24466 RVA: 0x00024433 File Offset: 0x00022633
			public unsafe int _fromImperiumRow_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._execute_d__8.NativeFieldInfoPtr__fromImperiumRow_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._execute_d__8.NativeFieldInfoPtr__fromImperiumRow_5__5)) = value;
				}
			}

			// Token: 0x17001930 RID: 6448
			// (get) Token: 0x06005F93 RID: 24467 RVA: 0x001D7318 File Offset: 0x001D5518
			// (set) Token: 0x06005F94 RID: 24468 RVA: 0x0002444E File Offset: 0x0002264E
			public unsafe SequenceHelper _sequenceHelper_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._execute_d__8.NativeFieldInfoPtr__sequenceHelper_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._execute_d__8.NativeFieldInfoPtr__sequenceHelper_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001931 RID: 6449
			// (get) Token: 0x06005F95 RID: 24469 RVA: 0x001D7348 File Offset: 0x001D5548
			// (set) Token: 0x06005F96 RID: 24470 RVA: 0x0002446D File Offset: 0x0002266D
			public unsafe Move _moveAction_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._execute_d__8.NativeFieldInfoPtr__moveAction_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Move>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._execute_d__8.NativeFieldInfoPtr__moveAction_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001932 RID: 6450
			// (get) Token: 0x06005F97 RID: 24471 RVA: 0x001D7378 File Offset: 0x001D5578
			// (set) Token: 0x06005F98 RID: 24472 RVA: 0x0002448C File Offset: 0x0002268C
			public unsafe GameLogBuilder _gameLogBuilder_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._execute_d__8.NativeFieldInfoPtr__gameLogBuilder_5__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._execute_d__8.NativeFieldInfoPtr__gameLogBuilder_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001933 RID: 6451
			// (get) Token: 0x06005F99 RID: 24473 RVA: 0x001D73A8 File Offset: 0x001D55A8
			// (set) Token: 0x06005F9A RID: 24474 RVA: 0x000244AB File Offset: 0x000226AB
			public unsafe bool _trashedAcquiredCard_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._execute_d__8.NativeFieldInfoPtr__trashedAcquiredCard_5__9);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._execute_d__8.NativeFieldInfoPtr__trashedAcquiredCard_5__9)) = value;
				}
			}

			// Token: 0x17001934 RID: 6452
			// (get) Token: 0x06005F9B RID: 24475 RVA: 0x001D73D0 File Offset: 0x001D55D0
			// (set) Token: 0x06005F9C RID: 24476 RVA: 0x000244C6 File Offset: 0x000226C6
			public unsafe WormPlayer _player_5__10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._execute_d__8.NativeFieldInfoPtr__player_5__10);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._execute_d__8.NativeFieldInfoPtr__player_5__10), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001935 RID: 6453
			// (get) Token: 0x06005F9D RID: 24477 RVA: 0x001D7400 File Offset: 0x001D5600
			// (set) Token: 0x06005F9E RID: 24478 RVA: 0x000244E5 File Offset: 0x000226E5
			public unsafe UndoNode _childUndo_5__11
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._execute_d__8.NativeFieldInfoPtr__childUndo_5__11);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._execute_d__8.NativeFieldInfoPtr__childUndo_5__11), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001936 RID: 6454
			// (get) Token: 0x06005F9F RID: 24479 RVA: 0x001D7430 File Offset: 0x001D5630
			// (set) Token: 0x06005FA0 RID: 24480 RVA: 0x00024504 File Offset: 0x00022704
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap11
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._execute_d__8.NativeFieldInfoPtr___7__wrap11);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._execute_d__8.NativeFieldInfoPtr___7__wrap11), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003DF3 RID: 15859
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003DF4 RID: 15860
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003DF5 RID: 15861
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003DF6 RID: 15862
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003DF7 RID: 15863
			private static readonly IntPtr NativeFieldInfoPtr__card_5__2;

			// Token: 0x04003DF8 RID: 15864
			private static readonly IntPtr NativeFieldInfoPtr__wm_5__3;

			// Token: 0x04003DF9 RID: 15865
			private static readonly IntPtr NativeFieldInfoPtr__trashPile_5__4;

			// Token: 0x04003DFA RID: 15866
			private static readonly IntPtr NativeFieldInfoPtr__fromImperiumRow_5__5;

			// Token: 0x04003DFB RID: 15867
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__6;

			// Token: 0x04003DFC RID: 15868
			private static readonly IntPtr NativeFieldInfoPtr__moveAction_5__7;

			// Token: 0x04003DFD RID: 15869
			private static readonly IntPtr NativeFieldInfoPtr__gameLogBuilder_5__8;

			// Token: 0x04003DFE RID: 15870
			private static readonly IntPtr NativeFieldInfoPtr__trashedAcquiredCard_5__9;

			// Token: 0x04003DFF RID: 15871
			private static readonly IntPtr NativeFieldInfoPtr__player_5__10;

			// Token: 0x04003E00 RID: 15872
			private static readonly IntPtr NativeFieldInfoPtr__childUndo_5__11;

			// Token: 0x04003E01 RID: 15873
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap11;

			// Token: 0x04003E02 RID: 15874
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003E03 RID: 15875
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003E04 RID: 15876
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003E05 RID: 15877
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003E06 RID: 15878
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003E07 RID: 15879
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003E08 RID: 15880
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003E09 RID: 15881
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003E0A RID: 15882
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020006EF RID: 1775
		[ObfuscatedName("worm.canis.actions.TrashCard+<undo>d__9")]
		public sealed class _undo_d__9 : Object
		{
			// Token: 0x06005FA1 RID: 24481 RVA: 0x001D7460 File Offset: 0x001D5660
			// Note: this type is marked as 'beforefieldinit'.
			static _undo_d__9()
			{
				Il2CppClassPointerStore<TrashCard._undo_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrashCard>.NativeClassPtr, "<undo>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashCard._undo_d__9>.NativeClassPtr);
				TrashCard._undo_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._undo_d__9>.NativeClassPtr, "<>1__state");
				TrashCard._undo_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._undo_d__9>.NativeClassPtr, "<>2__current");
				TrashCard._undo_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._undo_d__9>.NativeClassPtr, "<>l__initialThreadId");
				TrashCard._undo_d__9.NativeFieldInfoPtr_undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._undo_d__9>.NativeClassPtr, "undoContext");
				TrashCard._undo_d__9.NativeFieldInfoPtr___3__undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._undo_d__9>.NativeClassPtr, "<>3__undoContext");
				TrashCard._undo_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._undo_d__9>.NativeClassPtr, "<>4__this");
				TrashCard._undo_d__9.NativeFieldInfoPtr__undoNode_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._undo_d__9>.NativeClassPtr, "<undoNode>5__2");
				TrashCard._undo_d__9.NativeFieldInfoPtr__origin_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._undo_d__9>.NativeClassPtr, "<origin>5__3");
				TrashCard._undo_d__9.NativeFieldInfoPtr__card_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._undo_d__9>.NativeClassPtr, "<card>5__4");
				TrashCard._undo_d__9.NativeFieldInfoPtr__player_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._undo_d__9>.NativeClassPtr, "<player>5__5");
				TrashCard._undo_d__9.NativeFieldInfoPtr__sequenceHelper_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashCard._undo_d__9>.NativeClassPtr, "<sequenceHelper>5__6");
				TrashCard._undo_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashCard._undo_d__9>.NativeClassPtr, 100668942);
				TrashCard._undo_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashCard._undo_d__9>.NativeClassPtr, 100668943);
				TrashCard._undo_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashCard._undo_d__9>.NativeClassPtr, 100668944);
				TrashCard._undo_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashCard._undo_d__9>.NativeClassPtr, 100668945);
				TrashCard._undo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashCard._undo_d__9>.NativeClassPtr, 100668946);
				TrashCard._undo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashCard._undo_d__9>.NativeClassPtr, 100668947);
				TrashCard._undo_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashCard._undo_d__9>.NativeClassPtr, 100668948);
				TrashCard._undo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashCard._undo_d__9>.NativeClassPtr, 100668949);
			}

			// Token: 0x06005FA2 RID: 24482 RVA: 0x001D7608 File Offset: 0x001D5808
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _undo_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashCard._undo_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashCard._undo_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005FA3 RID: 24483 RVA: 0x001D7650 File Offset: 0x001D5850
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashCard._undo_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005FA4 RID: 24484 RVA: 0x001D7684 File Offset: 0x001D5884
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148638, XrefRangeEnd = 148922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashCard._undo_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001944 RID: 6468
			// (get) Token: 0x06005FA5 RID: 24485 RVA: 0x001D76C0 File Offset: 0x001D58C0
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashCard._undo_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005FA6 RID: 24486 RVA: 0x001D7700 File Offset: 0x001D5900
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148922, XrefRangeEnd = 148927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashCard._undo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001945 RID: 6469
			// (get) Token: 0x06005FA7 RID: 24487 RVA: 0x001D7734 File Offset: 0x001D5934
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashCard._undo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005FA8 RID: 24488 RVA: 0x001D7774 File Offset: 0x001D5974
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148927, XrefRangeEnd = 148936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashCard._undo_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005FA9 RID: 24489 RVA: 0x001D77B4 File Offset: 0x001D59B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashCard._undo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005FAA RID: 24490 RVA: 0x00024523 File Offset: 0x00022723
			public _undo_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001939 RID: 6457
			// (get) Token: 0x06005FAB RID: 24491 RVA: 0x001D77F4 File Offset: 0x001D59F4
			// (set) Token: 0x06005FAC RID: 24492 RVA: 0x0002452C File Offset: 0x0002272C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._undo_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._undo_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700193A RID: 6458
			// (get) Token: 0x06005FAD RID: 24493 RVA: 0x001D781C File Offset: 0x001D5A1C
			// (set) Token: 0x06005FAE RID: 24494 RVA: 0x00024547 File Offset: 0x00022747
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._undo_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._undo_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700193B RID: 6459
			// (get) Token: 0x06005FAF RID: 24495 RVA: 0x001D784C File Offset: 0x001D5A4C
			// (set) Token: 0x06005FB0 RID: 24496 RVA: 0x00024566 File Offset: 0x00022766
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._undo_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._undo_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700193C RID: 6460
			// (get) Token: 0x06005FB1 RID: 24497 RVA: 0x001D7874 File Offset: 0x001D5A74
			// (set) Token: 0x06005FB2 RID: 24498 RVA: 0x00024581 File Offset: 0x00022781
			public unsafe Context undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._undo_d__9.NativeFieldInfoPtr_undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._undo_d__9.NativeFieldInfoPtr_undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700193D RID: 6461
			// (get) Token: 0x06005FB3 RID: 24499 RVA: 0x001D78A4 File Offset: 0x001D5AA4
			// (set) Token: 0x06005FB4 RID: 24500 RVA: 0x000245A0 File Offset: 0x000227A0
			public unsafe Context __3__undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._undo_d__9.NativeFieldInfoPtr___3__undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._undo_d__9.NativeFieldInfoPtr___3__undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700193E RID: 6462
			// (get) Token: 0x06005FB5 RID: 24501 RVA: 0x001D78D4 File Offset: 0x001D5AD4
			// (set) Token: 0x06005FB6 RID: 24502 RVA: 0x000245BF File Offset: 0x000227BF
			public unsafe TrashCard __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._undo_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashCard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._undo_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700193F RID: 6463
			// (get) Token: 0x06005FB7 RID: 24503 RVA: 0x001D7904 File Offset: 0x001D5B04
			// (set) Token: 0x06005FB8 RID: 24504 RVA: 0x000245DE File Offset: 0x000227DE
			public unsafe UndoNode _undoNode_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._undo_d__9.NativeFieldInfoPtr__undoNode_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._undo_d__9.NativeFieldInfoPtr__undoNode_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001940 RID: 6464
			// (get) Token: 0x06005FB9 RID: 24505 RVA: 0x001D7934 File Offset: 0x001D5B34
			// (set) Token: 0x06005FBA RID: 24506 RVA: 0x000245FD File Offset: 0x000227FD
			public unsafe Entity _origin_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._undo_d__9.NativeFieldInfoPtr__origin_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._undo_d__9.NativeFieldInfoPtr__origin_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001941 RID: 6465
			// (get) Token: 0x06005FBB RID: 24507 RVA: 0x001D7964 File Offset: 0x001D5B64
			// (set) Token: 0x06005FBC RID: 24508 RVA: 0x0002461C File Offset: 0x0002281C
			public unsafe WormImperiumPlayable _card_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._undo_d__9.NativeFieldInfoPtr__card_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._undo_d__9.NativeFieldInfoPtr__card_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001942 RID: 6466
			// (get) Token: 0x06005FBD RID: 24509 RVA: 0x001D7994 File Offset: 0x001D5B94
			// (set) Token: 0x06005FBE RID: 24510 RVA: 0x0002463B File Offset: 0x0002283B
			public unsafe WormPlayer _player_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._undo_d__9.NativeFieldInfoPtr__player_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._undo_d__9.NativeFieldInfoPtr__player_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001943 RID: 6467
			// (get) Token: 0x06005FBF RID: 24511 RVA: 0x001D79C4 File Offset: 0x001D5BC4
			// (set) Token: 0x06005FC0 RID: 24512 RVA: 0x0002465A File Offset: 0x0002285A
			public unsafe SequenceHelper _sequenceHelper_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._undo_d__9.NativeFieldInfoPtr__sequenceHelper_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashCard._undo_d__9.NativeFieldInfoPtr__sequenceHelper_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003E0B RID: 15883
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003E0C RID: 15884
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003E0D RID: 15885
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003E0E RID: 15886
			private static readonly IntPtr NativeFieldInfoPtr_undoContext;

			// Token: 0x04003E0F RID: 15887
			private static readonly IntPtr NativeFieldInfoPtr___3__undoContext;

			// Token: 0x04003E10 RID: 15888
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003E11 RID: 15889
			private static readonly IntPtr NativeFieldInfoPtr__undoNode_5__2;

			// Token: 0x04003E12 RID: 15890
			private static readonly IntPtr NativeFieldInfoPtr__origin_5__3;

			// Token: 0x04003E13 RID: 15891
			private static readonly IntPtr NativeFieldInfoPtr__card_5__4;

			// Token: 0x04003E14 RID: 15892
			private static readonly IntPtr NativeFieldInfoPtr__player_5__5;

			// Token: 0x04003E15 RID: 15893
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__6;

			// Token: 0x04003E16 RID: 15894
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003E17 RID: 15895
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003E18 RID: 15896
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003E19 RID: 15897
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003E1A RID: 15898
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003E1B RID: 15899
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003E1C RID: 15900
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003E1D RID: 15901
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

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
using worm.canis.entities;

namespace worm.canis.actions
{
	// Token: 0x02000284 RID: 644
	public class AddTechNegotiators : global::Canis.actions.Action
	{
		// Token: 0x06001AF4 RID: 6900 RVA: 0x000C1A9C File Offset: 0x000BFC9C
		// Note: this type is marked as 'beforefieldinit'.
		static AddTechNegotiators()
		{
			Il2CppClassPointerStore<AddTechNegotiators>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "AddTechNegotiators");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddTechNegotiators>.NativeClassPtr);
			AddTechNegotiators.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTechNegotiators>.NativeClassPtr, "amount");
			AddTechNegotiators.NativeFieldInfoPtr__LogMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTechNegotiators>.NativeClassPtr, "<LogMode>k__BackingField");
			AddTechNegotiators.NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTechNegotiators>.NativeClassPtr, 100668561);
			AddTechNegotiators.NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTechNegotiators>.NativeClassPtr, 100668562);
			AddTechNegotiators.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTechNegotiators>.NativeClassPtr, 100668563);
			AddTechNegotiators.NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTechNegotiators>.NativeClassPtr, 100668564);
			AddTechNegotiators.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTechNegotiators>.NativeClassPtr, 100668565);
			AddTechNegotiators.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTechNegotiators>.NativeClassPtr, 100668566);
			AddTechNegotiators.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTechNegotiators>.NativeClassPtr, 100668567);
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06001AF5 RID: 6901 RVA: 0x000C1B80 File Offset: 0x000BFD80
		// (set) Token: 0x06001AF6 RID: 6902 RVA: 0x000C1BBC File Offset: 0x000BFDBC
		public unsafe virtual ActionLogModes LogMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTechNegotiators.NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTechNegotiators.NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x000C1BFC File Offset: 0x000BFDFC
		[CallerCount(56)]
		[CachedScanResults(RefRangeStart = 137491, RefRangeEnd = 137547, XrefRangeStart = 137491, XrefRangeEnd = 137547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddTechNegotiators(int amt, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddTechNegotiators>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTechNegotiators.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x000C1C58 File Offset: 0x000BFE58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145348, XrefRangeEnd = 145356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTechNegotiators.NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<string, Object>>>(intPtr3) : null;
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x000C1CBC File Offset: 0x000BFEBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145356, XrefRangeEnd = 145362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddTechNegotiators.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x000C1D08 File Offset: 0x000BFF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145362, XrefRangeEnd = 145369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> undo(Context undoContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddTechNegotiators.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x000C1D64 File Offset: 0x000BFF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145369, XrefRangeEnd = 145373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddTechNegotiators.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x0000B8BC File Offset: 0x00009ABC
		public AddTechNegotiators(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06001AFD RID: 6909 RVA: 0x000C1DC0 File Offset: 0x000BFFC0
		// (set) Token: 0x06001AFE RID: 6910 RVA: 0x0000B8C5 File Offset: 0x00009AC5
		public unsafe int amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators.NativeFieldInfoPtr_amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators.NativeFieldInfoPtr_amount)) = value;
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06001AFF RID: 6911 RVA: 0x000C1DE8 File Offset: 0x000BFFE8
		// (set) Token: 0x06001B00 RID: 6912 RVA: 0x0000B8E0 File Offset: 0x00009AE0
		public unsafe ActionLogModes _LogMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators.NativeFieldInfoPtr__LogMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators.NativeFieldInfoPtr__LogMode_k__BackingField)) = value;
			}
		}

		// Token: 0x0400109F RID: 4255
		private static readonly IntPtr NativeFieldInfoPtr_amount;

		// Token: 0x040010A0 RID: 4256
		private static readonly IntPtr NativeFieldInfoPtr__LogMode_k__BackingField;

		// Token: 0x040010A1 RID: 4257
		private static readonly IntPtr NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0;

		// Token: 0x040010A2 RID: 4258
		private static readonly IntPtr NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0;

		// Token: 0x040010A3 RID: 4259
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0;

		// Token: 0x040010A4 RID: 4260
		private static readonly IntPtr NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_0;

		// Token: 0x040010A5 RID: 4261
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x040010A6 RID: 4262
		private static readonly IntPtr NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0;

		// Token: 0x040010A7 RID: 4263
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x020006CB RID: 1739
		[ObfuscatedName("worm.canis.actions.AddTechNegotiators+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06005C55 RID: 23637 RVA: 0x001CD8E0 File Offset: 0x001CBAE0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AddTechNegotiators.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddTechNegotiators>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddTechNegotiators.__c>.NativeClassPtr);
				AddTechNegotiators.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTechNegotiators.__c>.NativeClassPtr, "<>9");
				AddTechNegotiators.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTechNegotiators.__c>.NativeClassPtr, "<>9__7_0");
				AddTechNegotiators.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTechNegotiators.__c>.NativeClassPtr, 100668569);
				AddTechNegotiators.__c.NativeMethodInfoPtr__execute_b__7_0_Internal_EntityID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTechNegotiators.__c>.NativeClassPtr, 100668570);
			}

			// Token: 0x06005C56 RID: 23638 RVA: 0x001CD95C File Offset: 0x001CBB5C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddTechNegotiators.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTechNegotiators.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005C57 RID: 23639 RVA: 0x001CD998 File Offset: 0x001CBB98
			[CallerCount(0)]
			public unsafe EntityID _execute_b__7_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTechNegotiators.__c.NativeMethodInfoPtr__execute_b__7_0_Internal_EntityID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x06005C58 RID: 23640 RVA: 0x00022656 File Offset: 0x00020856
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001800 RID: 6144
			// (get) Token: 0x06005C59 RID: 23641 RVA: 0x001CD9E8 File Offset: 0x001CBBE8
			// (set) Token: 0x06005C5A RID: 23642 RVA: 0x0002265F File Offset: 0x0002085F
			public unsafe static AddTechNegotiators.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AddTechNegotiators.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddTechNegotiators.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AddTechNegotiators.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001801 RID: 6145
			// (get) Token: 0x06005C5B RID: 23643 RVA: 0x001CDA10 File Offset: 0x001CBC10
			// (set) Token: 0x06005C5C RID: 23644 RVA: 0x00022671 File Offset: 0x00020871
			public unsafe static Func<Entity, EntityID> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AddTechNegotiators.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AddTechNegotiators.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003C06 RID: 15366
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003C07 RID: 15367
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04003C08 RID: 15368
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003C09 RID: 15369
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__7_0_Internal_EntityID_Entity_0;
		}

		// Token: 0x020006CC RID: 1740
		[ObfuscatedName("worm.canis.actions.AddTechNegotiators+<MakeAnalyticsData>d__6")]
		public sealed class _MakeAnalyticsData_d__6 : Object
		{
			// Token: 0x06005C5D RID: 23645 RVA: 0x001CDA38 File Offset: 0x001CBC38
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeAnalyticsData_d__6()
			{
				Il2CppClassPointerStore<AddTechNegotiators._MakeAnalyticsData_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddTechNegotiators>.NativeClassPtr, "<MakeAnalyticsData>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddTechNegotiators._MakeAnalyticsData_d__6>.NativeClassPtr);
				AddTechNegotiators._MakeAnalyticsData_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTechNegotiators._MakeAnalyticsData_d__6>.NativeClassPtr, "<>1__state");
				AddTechNegotiators._MakeAnalyticsData_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTechNegotiators._MakeAnalyticsData_d__6>.NativeClassPtr, "<>2__current");
				AddTechNegotiators._MakeAnalyticsData_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTechNegotiators._MakeAnalyticsData_d__6>.NativeClassPtr, "<>l__initialThreadId");
				AddTechNegotiators._MakeAnalyticsData_d__6.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTechNegotiators._MakeAnalyticsData_d__6>.NativeClassPtr, "wormMatch");
				AddTechNegotiators._MakeAnalyticsData_d__6.NativeFieldInfoPtr___3__wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTechNegotiators._MakeAnalyticsData_d__6>.NativeClassPtr, "<>3__wormMatch");
				AddTechNegotiators._MakeAnalyticsData_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTechNegotiators._MakeAnalyticsData_d__6>.NativeClassPtr, "<>4__this");
				AddTechNegotiators._MakeAnalyticsData_d__6.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTechNegotiators._MakeAnalyticsData_d__6>.NativeClassPtr, "player");
				AddTechNegotiators._MakeAnalyticsData_d__6.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTechNegotiators._MakeAnalyticsData_d__6>.NativeClassPtr, "<>3__player");
				AddTechNegotiators._MakeAnalyticsData_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTechNegotiators._MakeAnalyticsData_d__6>.NativeClassPtr, 100668571);
				AddTechNegotiators._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTechNegotiators._MakeAnalyticsData_d__6>.NativeClassPtr, 100668572);
				AddTechNegotiators._MakeAnalyticsData_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTechNegotiators._MakeAnalyticsData_d__6>.NativeClassPtr, 100668573);
				AddTechNegotiators._MakeAnalyticsData_d__6.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTechNegotiators._MakeAnalyticsData_d__6>.NativeClassPtr, 100668574);
				AddTechNegotiators._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTechNegotiators._MakeAnalyticsData_d__6>.NativeClassPtr, 100668575);
				AddTechNegotiators._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTechNegotiators._MakeAnalyticsData_d__6>.NativeClassPtr, 100668576);
				AddTechNegotiators._MakeAnalyticsData_d__6.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTechNegotiators._MakeAnalyticsData_d__6>.NativeClassPtr, 100668577);
				AddTechNegotiators._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTechNegotiators._MakeAnalyticsData_d__6>.NativeClassPtr, 100668578);
			}

			// Token: 0x06005C5E RID: 23646 RVA: 0x001CDBA4 File Offset: 0x001CBDA4
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MakeAnalyticsData_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddTechNegotiators._MakeAnalyticsData_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTechNegotiators._MakeAnalyticsData_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005C5F RID: 23647 RVA: 0x001CDBEC File Offset: 0x001CBDEC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTechNegotiators._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005C60 RID: 23648 RVA: 0x001CDC20 File Offset: 0x001CBE20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145070, XrefRangeEnd = 145088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTechNegotiators._MakeAnalyticsData_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700180A RID: 6154
			// (get) Token: 0x06005C61 RID: 23649 RVA: 0x001CDC5C File Offset: 0x001CBE5C
			public unsafe ValueTuple<string, Object> prop_ValueTuple_2_String_Object_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTechNegotiators._MakeAnalyticsData_d__6.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<string, Object>(intPtr);
				}
			}

			// Token: 0x06005C62 RID: 23650 RVA: 0x001CDC94 File Offset: 0x001CBE94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145088, XrefRangeEnd = 145093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTechNegotiators._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700180B RID: 6155
			// (get) Token: 0x06005C63 RID: 23651 RVA: 0x001CDCC8 File Offset: 0x001CBEC8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145093, XrefRangeEnd = 145096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTechNegotiators._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005C64 RID: 23652 RVA: 0x001CDD08 File Offset: 0x001CBF08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145096, XrefRangeEnd = 145106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<string, Object>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTechNegotiators._MakeAnalyticsData_d__6.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<string, Object>>>(intPtr3) : null;
			}

			// Token: 0x06005C65 RID: 23653 RVA: 0x001CDD48 File Offset: 0x001CBF48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTechNegotiators._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005C66 RID: 23654 RVA: 0x00022683 File Offset: 0x00020883
			public _MakeAnalyticsData_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001802 RID: 6146
			// (get) Token: 0x06005C67 RID: 23655 RVA: 0x001CDD88 File Offset: 0x001CBF88
			// (set) Token: 0x06005C68 RID: 23656 RVA: 0x0002268C File Offset: 0x0002088C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._MakeAnalyticsData_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._MakeAnalyticsData_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001803 RID: 6147
			// (get) Token: 0x06005C69 RID: 23657 RVA: 0x001CDDB0 File Offset: 0x001CBFB0
			// (set) Token: 0x06005C6A RID: 23658 RVA: 0x000226A7 File Offset: 0x000208A7
			public ValueTuple<string, Object> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._MakeAnalyticsData_d__6.NativeFieldInfoPtr___2__current);
					return new ValueTuple<string, Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._MakeAnalyticsData_d__6.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001804 RID: 6148
			// (get) Token: 0x06005C6B RID: 23659 RVA: 0x001CDDE0 File Offset: 0x001CBFE0
			// (set) Token: 0x06005C6C RID: 23660 RVA: 0x000226D5 File Offset: 0x000208D5
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._MakeAnalyticsData_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._MakeAnalyticsData_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001805 RID: 6149
			// (get) Token: 0x06005C6D RID: 23661 RVA: 0x001CDE08 File Offset: 0x001CC008
			// (set) Token: 0x06005C6E RID: 23662 RVA: 0x000226F0 File Offset: 0x000208F0
			public unsafe WormMatch wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._MakeAnalyticsData_d__6.NativeFieldInfoPtr_wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._MakeAnalyticsData_d__6.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001806 RID: 6150
			// (get) Token: 0x06005C6F RID: 23663 RVA: 0x001CDE38 File Offset: 0x001CC038
			// (set) Token: 0x06005C70 RID: 23664 RVA: 0x0002270F File Offset: 0x0002090F
			public unsafe WormMatch __3__wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._MakeAnalyticsData_d__6.NativeFieldInfoPtr___3__wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._MakeAnalyticsData_d__6.NativeFieldInfoPtr___3__wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001807 RID: 6151
			// (get) Token: 0x06005C71 RID: 23665 RVA: 0x001CDE68 File Offset: 0x001CC068
			// (set) Token: 0x06005C72 RID: 23666 RVA: 0x0002272E File Offset: 0x0002092E
			public unsafe AddTechNegotiators __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._MakeAnalyticsData_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddTechNegotiators>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._MakeAnalyticsData_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001808 RID: 6152
			// (get) Token: 0x06005C73 RID: 23667 RVA: 0x001CDE98 File Offset: 0x001CC098
			// (set) Token: 0x06005C74 RID: 23668 RVA: 0x0002274D File Offset: 0x0002094D
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._MakeAnalyticsData_d__6.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._MakeAnalyticsData_d__6.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001809 RID: 6153
			// (get) Token: 0x06005C75 RID: 23669 RVA: 0x001CDEC8 File Offset: 0x001CC0C8
			// (set) Token: 0x06005C76 RID: 23670 RVA: 0x0002276C File Offset: 0x0002096C
			public unsafe WormPlayer __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._MakeAnalyticsData_d__6.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._MakeAnalyticsData_d__6.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003C0A RID: 15370
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003C0B RID: 15371
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003C0C RID: 15372
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003C0D RID: 15373
			private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

			// Token: 0x04003C0E RID: 15374
			private static readonly IntPtr NativeFieldInfoPtr___3__wormMatch;

			// Token: 0x04003C0F RID: 15375
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003C10 RID: 15376
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04003C11 RID: 15377
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x04003C12 RID: 15378
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003C13 RID: 15379
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003C14 RID: 15380
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003C15 RID: 15381
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0;

			// Token: 0x04003C16 RID: 15382
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003C17 RID: 15383
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003C18 RID: 15384
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0;

			// Token: 0x04003C19 RID: 15385
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020006CD RID: 1741
		[ObfuscatedName("worm.canis.actions.AddTechNegotiators+<execute>d__7")]
		public sealed class _execute_d__7 : Object
		{
			// Token: 0x06005C77 RID: 23671 RVA: 0x001CDEF8 File Offset: 0x001CC0F8
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__7()
			{
				Il2CppClassPointerStore<AddTechNegotiators._execute_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddTechNegotiators>.NativeClassPtr, "<execute>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddTechNegotiators._execute_d__7>.NativeClassPtr);
				AddTechNegotiators._execute_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTechNegotiators._execute_d__7>.NativeClassPtr, "<>1__state");
				AddTechNegotiators._execute_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTechNegotiators._execute_d__7>.NativeClassPtr, "<>2__current");
				AddTechNegotiators._execute_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTechNegotiators._execute_d__7>.NativeClassPtr, "<>l__initialThreadId");
				AddTechNegotiators._execute_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTechNegotiators._execute_d__7>.NativeClassPtr, "<>4__this");
				AddTechNegotiators._execute_d__7.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTechNegotiators._execute_d__7>.NativeClassPtr, "<player>5__2");
				AddTechNegotiators._execute_d__7.NativeFieldInfoPtr__wm_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTechNegotiators._execute_d__7>.NativeClassPtr, "<wm>5__3");
				AddTechNegotiators._execute_d__7.NativeFieldInfoPtr__unitsToMove_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTechNegotiators._execute_d__7>.NativeClassPtr, "<unitsToMove>5__4");
				AddTechNegotiators._execute_d__7.NativeFieldInfoPtr__negotiators_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTechNegotiators._execute_d__7>.NativeClassPtr, "<negotiators>5__5");
				AddTechNegotiators._execute_d__7.NativeFieldInfoPtr__unaddedTechNegotiators_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTechNegotiators._execute_d__7>.NativeClassPtr, "<unaddedTechNegotiators>5__6");
				AddTechNegotiators._execute_d__7.NativeFieldInfoPtr__logStr_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTechNegotiators._execute_d__7>.NativeClassPtr, "<logStr>5__7");
				AddTechNegotiators._execute_d__7.NativeFieldInfoPtr__childUndo_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTechNegotiators._execute_d__7>.NativeClassPtr, "<childUndo>5__8");
				AddTechNegotiators._execute_d__7.NativeFieldInfoPtr___7__wrap8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTechNegotiators._execute_d__7>.NativeClassPtr, "<>7__wrap8");
				AddTechNegotiators._execute_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTechNegotiators._execute_d__7>.NativeClassPtr, 100668579);
				AddTechNegotiators._execute_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTechNegotiators._execute_d__7>.NativeClassPtr, 100668580);
				AddTechNegotiators._execute_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTechNegotiators._execute_d__7>.NativeClassPtr, 100668581);
				AddTechNegotiators._execute_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTechNegotiators._execute_d__7>.NativeClassPtr, 100668582);
				AddTechNegotiators._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTechNegotiators._execute_d__7>.NativeClassPtr, 100668583);
				AddTechNegotiators._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTechNegotiators._execute_d__7>.NativeClassPtr, 100668584);
				AddTechNegotiators._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTechNegotiators._execute_d__7>.NativeClassPtr, 100668585);
				AddTechNegotiators._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTechNegotiators._execute_d__7>.NativeClassPtr, 100668586);
				AddTechNegotiators._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTechNegotiators._execute_d__7>.NativeClassPtr, 100668587);
			}

			// Token: 0x06005C78 RID: 23672 RVA: 0x001CE0C8 File Offset: 0x001CC2C8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddTechNegotiators._execute_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTechNegotiators._execute_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005C79 RID: 23673 RVA: 0x001CE110 File Offset: 0x001CC310
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145106, XrefRangeEnd = 145111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTechNegotiators._execute_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005C7A RID: 23674 RVA: 0x001CE144 File Offset: 0x001CC344
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145111, XrefRangeEnd = 145283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTechNegotiators._execute_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005C7B RID: 23675 RVA: 0x001CE180 File Offset: 0x001CC380
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145283, XrefRangeEnd = 145286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTechNegotiators._execute_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001818 RID: 6168
			// (get) Token: 0x06005C7C RID: 23676 RVA: 0x001CE1B4 File Offset: 0x001CC3B4
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTechNegotiators._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005C7D RID: 23677 RVA: 0x001CE1F4 File Offset: 0x001CC3F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145286, XrefRangeEnd = 145291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTechNegotiators._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001819 RID: 6169
			// (get) Token: 0x06005C7E RID: 23678 RVA: 0x001CE228 File Offset: 0x001CC428
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTechNegotiators._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005C7F RID: 23679 RVA: 0x001CE268 File Offset: 0x001CC468
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145291, XrefRangeEnd = 145293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTechNegotiators._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005C80 RID: 23680 RVA: 0x001CE2A8 File Offset: 0x001CC4A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTechNegotiators._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005C81 RID: 23681 RVA: 0x0002278B File Offset: 0x0002098B
			public _execute_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700180C RID: 6156
			// (get) Token: 0x06005C82 RID: 23682 RVA: 0x001CE2E8 File Offset: 0x001CC4E8
			// (set) Token: 0x06005C83 RID: 23683 RVA: 0x00022794 File Offset: 0x00020994
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._execute_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._execute_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700180D RID: 6157
			// (get) Token: 0x06005C84 RID: 23684 RVA: 0x001CE310 File Offset: 0x001CC510
			// (set) Token: 0x06005C85 RID: 23685 RVA: 0x000227AF File Offset: 0x000209AF
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._execute_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._execute_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700180E RID: 6158
			// (get) Token: 0x06005C86 RID: 23686 RVA: 0x001CE340 File Offset: 0x001CC540
			// (set) Token: 0x06005C87 RID: 23687 RVA: 0x000227CE File Offset: 0x000209CE
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._execute_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._execute_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700180F RID: 6159
			// (get) Token: 0x06005C88 RID: 23688 RVA: 0x001CE368 File Offset: 0x001CC568
			// (set) Token: 0x06005C89 RID: 23689 RVA: 0x000227E9 File Offset: 0x000209E9
			public unsafe AddTechNegotiators __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._execute_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddTechNegotiators>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._execute_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001810 RID: 6160
			// (get) Token: 0x06005C8A RID: 23690 RVA: 0x001CE398 File Offset: 0x001CC598
			// (set) Token: 0x06005C8B RID: 23691 RVA: 0x00022808 File Offset: 0x00020A08
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._execute_d__7.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._execute_d__7.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001811 RID: 6161
			// (get) Token: 0x06005C8C RID: 23692 RVA: 0x001CE3C8 File Offset: 0x001CC5C8
			// (set) Token: 0x06005C8D RID: 23693 RVA: 0x00022827 File Offset: 0x00020A27
			public unsafe WormMatch _wm_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._execute_d__7.NativeFieldInfoPtr__wm_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._execute_d__7.NativeFieldInfoPtr__wm_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001812 RID: 6162
			// (get) Token: 0x06005C8E RID: 23694 RVA: 0x001CE3F8 File Offset: 0x001CC5F8
			// (set) Token: 0x06005C8F RID: 23695 RVA: 0x00022846 File Offset: 0x00020A46
			public unsafe List<Entity> _unitsToMove_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._execute_d__7.NativeFieldInfoPtr__unitsToMove_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._execute_d__7.NativeFieldInfoPtr__unitsToMove_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001813 RID: 6163
			// (get) Token: 0x06005C90 RID: 23696 RVA: 0x001CE428 File Offset: 0x001CC628
			// (set) Token: 0x06005C91 RID: 23697 RVA: 0x00022865 File Offset: 0x00020A65
			public unsafe WormPlayArea _negotiators_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._execute_d__7.NativeFieldInfoPtr__negotiators_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._execute_d__7.NativeFieldInfoPtr__negotiators_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001814 RID: 6164
			// (get) Token: 0x06005C92 RID: 23698 RVA: 0x001CE458 File Offset: 0x001CC658
			// (set) Token: 0x06005C93 RID: 23699 RVA: 0x00022884 File Offset: 0x00020A84
			public unsafe int _unaddedTechNegotiators_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._execute_d__7.NativeFieldInfoPtr__unaddedTechNegotiators_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._execute_d__7.NativeFieldInfoPtr__unaddedTechNegotiators_5__6)) = value;
				}
			}

			// Token: 0x17001815 RID: 6165
			// (get) Token: 0x06005C94 RID: 23700 RVA: 0x001CE480 File Offset: 0x001CC680
			// (set) Token: 0x06005C95 RID: 23701 RVA: 0x0002289F File Offset: 0x00020A9F
			public unsafe string _logStr_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._execute_d__7.NativeFieldInfoPtr__logStr_5__7);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._execute_d__7.NativeFieldInfoPtr__logStr_5__7), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001816 RID: 6166
			// (get) Token: 0x06005C96 RID: 23702 RVA: 0x001CE4A8 File Offset: 0x001CC6A8
			// (set) Token: 0x06005C97 RID: 23703 RVA: 0x000228BE File Offset: 0x00020ABE
			public unsafe UndoNode _childUndo_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._execute_d__7.NativeFieldInfoPtr__childUndo_5__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._execute_d__7.NativeFieldInfoPtr__childUndo_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001817 RID: 6167
			// (get) Token: 0x06005C98 RID: 23704 RVA: 0x001CE4D8 File Offset: 0x001CC6D8
			// (set) Token: 0x06005C99 RID: 23705 RVA: 0x000228DD File Offset: 0x00020ADD
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._execute_d__7.NativeFieldInfoPtr___7__wrap8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._execute_d__7.NativeFieldInfoPtr___7__wrap8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003C1A RID: 15386
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003C1B RID: 15387
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003C1C RID: 15388
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003C1D RID: 15389
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003C1E RID: 15390
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04003C1F RID: 15391
			private static readonly IntPtr NativeFieldInfoPtr__wm_5__3;

			// Token: 0x04003C20 RID: 15392
			private static readonly IntPtr NativeFieldInfoPtr__unitsToMove_5__4;

			// Token: 0x04003C21 RID: 15393
			private static readonly IntPtr NativeFieldInfoPtr__negotiators_5__5;

			// Token: 0x04003C22 RID: 15394
			private static readonly IntPtr NativeFieldInfoPtr__unaddedTechNegotiators_5__6;

			// Token: 0x04003C23 RID: 15395
			private static readonly IntPtr NativeFieldInfoPtr__logStr_5__7;

			// Token: 0x04003C24 RID: 15396
			private static readonly IntPtr NativeFieldInfoPtr__childUndo_5__8;

			// Token: 0x04003C25 RID: 15397
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap8;

			// Token: 0x04003C26 RID: 15398
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003C27 RID: 15399
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003C28 RID: 15400
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003C29 RID: 15401
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003C2A RID: 15402
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003C2B RID: 15403
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003C2C RID: 15404
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003C2D RID: 15405
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003C2E RID: 15406
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020006CE RID: 1742
		[ObfuscatedName("worm.canis.actions.AddTechNegotiators+<undo>d__8")]
		public sealed class _undo_d__8 : Object
		{
			// Token: 0x06005C9A RID: 23706 RVA: 0x001CE508 File Offset: 0x001CC708
			// Note: this type is marked as 'beforefieldinit'.
			static _undo_d__8()
			{
				Il2CppClassPointerStore<AddTechNegotiators._undo_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddTechNegotiators>.NativeClassPtr, "<undo>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddTechNegotiators._undo_d__8>.NativeClassPtr);
				AddTechNegotiators._undo_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTechNegotiators._undo_d__8>.NativeClassPtr, "<>1__state");
				AddTechNegotiators._undo_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTechNegotiators._undo_d__8>.NativeClassPtr, "<>2__current");
				AddTechNegotiators._undo_d__8.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTechNegotiators._undo_d__8>.NativeClassPtr, "<>l__initialThreadId");
				AddTechNegotiators._undo_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTechNegotiators._undo_d__8>.NativeClassPtr, "<>4__this");
				AddTechNegotiators._undo_d__8.NativeFieldInfoPtr_undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTechNegotiators._undo_d__8>.NativeClassPtr, "undoContext");
				AddTechNegotiators._undo_d__8.NativeFieldInfoPtr___3__undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTechNegotiators._undo_d__8>.NativeClassPtr, "<>3__undoContext");
				AddTechNegotiators._undo_d__8.NativeFieldInfoPtr__wm_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTechNegotiators._undo_d__8>.NativeClassPtr, "<wm>5__2");
				AddTechNegotiators._undo_d__8.NativeFieldInfoPtr__player_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTechNegotiators._undo_d__8>.NativeClassPtr, "<player>5__3");
				AddTechNegotiators._undo_d__8.NativeFieldInfoPtr__undoNode_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTechNegotiators._undo_d__8>.NativeClassPtr, "<undoNode>5__4");
				AddTechNegotiators._undo_d__8.NativeFieldInfoPtr__movedUnits_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTechNegotiators._undo_d__8>.NativeClassPtr, "<movedUnits>5__5");
				AddTechNegotiators._undo_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTechNegotiators._undo_d__8>.NativeClassPtr, 100668588);
				AddTechNegotiators._undo_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTechNegotiators._undo_d__8>.NativeClassPtr, 100668589);
				AddTechNegotiators._undo_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTechNegotiators._undo_d__8>.NativeClassPtr, 100668590);
				AddTechNegotiators._undo_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTechNegotiators._undo_d__8>.NativeClassPtr, 100668591);
				AddTechNegotiators._undo_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTechNegotiators._undo_d__8>.NativeClassPtr, 100668592);
				AddTechNegotiators._undo_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTechNegotiators._undo_d__8>.NativeClassPtr, 100668593);
				AddTechNegotiators._undo_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTechNegotiators._undo_d__8>.NativeClassPtr, 100668594);
				AddTechNegotiators._undo_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTechNegotiators._undo_d__8>.NativeClassPtr, 100668595);
			}

			// Token: 0x06005C9B RID: 23707 RVA: 0x001CE69C File Offset: 0x001CC89C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _undo_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddTechNegotiators._undo_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTechNegotiators._undo_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005C9C RID: 23708 RVA: 0x001CE6E4 File Offset: 0x001CC8E4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTechNegotiators._undo_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005C9D RID: 23709 RVA: 0x001CE718 File Offset: 0x001CC918
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145293, XrefRangeEnd = 145334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTechNegotiators._undo_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001824 RID: 6180
			// (get) Token: 0x06005C9E RID: 23710 RVA: 0x001CE754 File Offset: 0x001CC954
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTechNegotiators._undo_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005C9F RID: 23711 RVA: 0x001CE794 File Offset: 0x001CC994
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145334, XrefRangeEnd = 145339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTechNegotiators._undo_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001825 RID: 6181
			// (get) Token: 0x06005CA0 RID: 23712 RVA: 0x001CE7C8 File Offset: 0x001CC9C8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTechNegotiators._undo_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005CA1 RID: 23713 RVA: 0x001CE808 File Offset: 0x001CCA08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145339, XrefRangeEnd = 145348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTechNegotiators._undo_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005CA2 RID: 23714 RVA: 0x001CE848 File Offset: 0x001CCA48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTechNegotiators._undo_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005CA3 RID: 23715 RVA: 0x000228FC File Offset: 0x00020AFC
			public _undo_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700181A RID: 6170
			// (get) Token: 0x06005CA4 RID: 23716 RVA: 0x001CE888 File Offset: 0x001CCA88
			// (set) Token: 0x06005CA5 RID: 23717 RVA: 0x00022905 File Offset: 0x00020B05
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._undo_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._undo_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700181B RID: 6171
			// (get) Token: 0x06005CA6 RID: 23718 RVA: 0x001CE8B0 File Offset: 0x001CCAB0
			// (set) Token: 0x06005CA7 RID: 23719 RVA: 0x00022920 File Offset: 0x00020B20
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._undo_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._undo_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700181C RID: 6172
			// (get) Token: 0x06005CA8 RID: 23720 RVA: 0x001CE8E0 File Offset: 0x001CCAE0
			// (set) Token: 0x06005CA9 RID: 23721 RVA: 0x0002293F File Offset: 0x00020B3F
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._undo_d__8.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._undo_d__8.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700181D RID: 6173
			// (get) Token: 0x06005CAA RID: 23722 RVA: 0x001CE908 File Offset: 0x001CCB08
			// (set) Token: 0x06005CAB RID: 23723 RVA: 0x0002295A File Offset: 0x00020B5A
			public unsafe AddTechNegotiators __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._undo_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddTechNegotiators>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._undo_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700181E RID: 6174
			// (get) Token: 0x06005CAC RID: 23724 RVA: 0x001CE938 File Offset: 0x001CCB38
			// (set) Token: 0x06005CAD RID: 23725 RVA: 0x00022979 File Offset: 0x00020B79
			public unsafe Context undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._undo_d__8.NativeFieldInfoPtr_undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._undo_d__8.NativeFieldInfoPtr_undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700181F RID: 6175
			// (get) Token: 0x06005CAE RID: 23726 RVA: 0x001CE968 File Offset: 0x001CCB68
			// (set) Token: 0x06005CAF RID: 23727 RVA: 0x00022998 File Offset: 0x00020B98
			public unsafe Context __3__undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._undo_d__8.NativeFieldInfoPtr___3__undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._undo_d__8.NativeFieldInfoPtr___3__undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001820 RID: 6176
			// (get) Token: 0x06005CB0 RID: 23728 RVA: 0x001CE998 File Offset: 0x001CCB98
			// (set) Token: 0x06005CB1 RID: 23729 RVA: 0x000229B7 File Offset: 0x00020BB7
			public unsafe WormMatch _wm_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._undo_d__8.NativeFieldInfoPtr__wm_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._undo_d__8.NativeFieldInfoPtr__wm_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001821 RID: 6177
			// (get) Token: 0x06005CB2 RID: 23730 RVA: 0x001CE9C8 File Offset: 0x001CCBC8
			// (set) Token: 0x06005CB3 RID: 23731 RVA: 0x000229D6 File Offset: 0x00020BD6
			public unsafe WormPlayer _player_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._undo_d__8.NativeFieldInfoPtr__player_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._undo_d__8.NativeFieldInfoPtr__player_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001822 RID: 6178
			// (get) Token: 0x06005CB4 RID: 23732 RVA: 0x001CE9F8 File Offset: 0x001CCBF8
			// (set) Token: 0x06005CB5 RID: 23733 RVA: 0x000229F5 File Offset: 0x00020BF5
			public unsafe UndoNode _undoNode_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._undo_d__8.NativeFieldInfoPtr__undoNode_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._undo_d__8.NativeFieldInfoPtr__undoNode_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001823 RID: 6179
			// (get) Token: 0x06005CB6 RID: 23734 RVA: 0x001CEA28 File Offset: 0x001CCC28
			// (set) Token: 0x06005CB7 RID: 23735 RVA: 0x00022A14 File Offset: 0x00020C14
			public unsafe Il2CppReferenceArray<Entity> _movedUnits_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._undo_d__8.NativeFieldInfoPtr__movedUnits_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTechNegotiators._undo_d__8.NativeFieldInfoPtr__movedUnits_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003C2F RID: 15407
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003C30 RID: 15408
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003C31 RID: 15409
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003C32 RID: 15410
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003C33 RID: 15411
			private static readonly IntPtr NativeFieldInfoPtr_undoContext;

			// Token: 0x04003C34 RID: 15412
			private static readonly IntPtr NativeFieldInfoPtr___3__undoContext;

			// Token: 0x04003C35 RID: 15413
			private static readonly IntPtr NativeFieldInfoPtr__wm_5__2;

			// Token: 0x04003C36 RID: 15414
			private static readonly IntPtr NativeFieldInfoPtr__player_5__3;

			// Token: 0x04003C37 RID: 15415
			private static readonly IntPtr NativeFieldInfoPtr__undoNode_5__4;

			// Token: 0x04003C38 RID: 15416
			private static readonly IntPtr NativeFieldInfoPtr__movedUnits_5__5;

			// Token: 0x04003C39 RID: 15417
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003C3A RID: 15418
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003C3B RID: 15419
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003C3C RID: 15420
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003C3D RID: 15421
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003C3E RID: 15422
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003C3F RID: 15423
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003C40 RID: 15424
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

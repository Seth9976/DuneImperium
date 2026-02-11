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

namespace worm.canis.actions.Immortality
{
	// Token: 0x020002E0 RID: 736
	public class GainSpecimens : global::Canis.actions.Action
	{
		// Token: 0x06001E48 RID: 7752 RVA: 0x000CF1A8 File Offset: 0x000CD3A8
		// Note: this type is marked as 'beforefieldinit'.
		static GainSpecimens()
		{
			Il2CppClassPointerStore<GainSpecimens>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.Immortality", "GainSpecimens");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainSpecimens>.NativeClassPtr);
			GainSpecimens.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainSpecimens>.NativeClassPtr, "amount");
			GainSpecimens.NativeFieldInfoPtr__LogMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainSpecimens>.NativeClassPtr, "<LogMode>k__BackingField");
			GainSpecimens.NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens>.NativeClassPtr, 100670384);
			GainSpecimens.NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens>.NativeClassPtr, 100670385);
			GainSpecimens.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens>.NativeClassPtr, 100670386);
			GainSpecimens.NativeMethodInfoPtr__ctor_Public_Void_SerializedGainSpecimens_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens>.NativeClassPtr, 100670387);
			GainSpecimens.NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens>.NativeClassPtr, 100670388);
			GainSpecimens.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens>.NativeClassPtr, 100670389);
			GainSpecimens.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens>.NativeClassPtr, 100670390);
			GainSpecimens.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens>.NativeClassPtr, 100670391);
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06001E49 RID: 7753 RVA: 0x000CF2A0 File Offset: 0x000CD4A0
		// (set) Token: 0x06001E4A RID: 7754 RVA: 0x000CF2DC File Offset: 0x000CD4DC
		public unsafe virtual ActionLogModes LogMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpecimens.NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpecimens.NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x000CF31C File Offset: 0x000CD51C
		[CallerCount(56)]
		[CachedScanResults(RefRangeStart = 137491, RefRangeEnd = 137547, XrefRangeStart = 137491, XrefRangeEnd = 137547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GainSpecimens(int amount, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainSpecimens>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpecimens.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x000CF378 File Offset: 0x000CD578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170931, XrefRangeEnd = 170932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GainSpecimens(SerializedGainSpecimens serialized, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainSpecimens>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpecimens.NativeMethodInfoPtr__ctor_Public_Void_SerializedGainSpecimens_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x000CF3D8 File Offset: 0x000CD5D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170932, XrefRangeEnd = 170940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpecimens.NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<string, Object>>>(intPtr3) : null;
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x000CF43C File Offset: 0x000CD63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170940, XrefRangeEnd = 170946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainSpecimens.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x000CF488 File Offset: 0x000CD688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170946, XrefRangeEnd = 170953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> undo(Context undoContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainSpecimens.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x000CF4E4 File Offset: 0x000CD6E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170953, XrefRangeEnd = 170957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainSpecimens.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x0000CAE5 File Offset: 0x0000ACE5
		public GainSpecimens(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06001E52 RID: 7762 RVA: 0x000CF540 File Offset: 0x000CD740
		// (set) Token: 0x06001E53 RID: 7763 RVA: 0x0000CAEE File Offset: 0x0000ACEE
		public unsafe int amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens.NativeFieldInfoPtr_amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens.NativeFieldInfoPtr_amount)) = value;
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06001E54 RID: 7764 RVA: 0x000CF568 File Offset: 0x000CD768
		// (set) Token: 0x06001E55 RID: 7765 RVA: 0x0000CB09 File Offset: 0x0000AD09
		public unsafe ActionLogModes _LogMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens.NativeFieldInfoPtr__LogMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens.NativeFieldInfoPtr__LogMode_k__BackingField)) = value;
			}
		}

		// Token: 0x04001317 RID: 4887
		private static readonly IntPtr NativeFieldInfoPtr_amount;

		// Token: 0x04001318 RID: 4888
		private static readonly IntPtr NativeFieldInfoPtr__LogMode_k__BackingField;

		// Token: 0x04001319 RID: 4889
		private static readonly IntPtr NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0;

		// Token: 0x0400131A RID: 4890
		private static readonly IntPtr NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0;

		// Token: 0x0400131B RID: 4891
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0;

		// Token: 0x0400131C RID: 4892
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedGainSpecimens_Match_0;

		// Token: 0x0400131D RID: 4893
		private static readonly IntPtr NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_0;

		// Token: 0x0400131E RID: 4894
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x0400131F RID: 4895
		private static readonly IntPtr NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0;

		// Token: 0x04001320 RID: 4896
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x02000783 RID: 1923
		[ObfuscatedName("worm.canis.actions.Immortality.GainSpecimens+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06006C2F RID: 27695 RVA: 0x001FE138 File Offset: 0x001FC338
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GainSpecimens.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainSpecimens>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainSpecimens.__c>.NativeClassPtr);
				GainSpecimens.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainSpecimens.__c>.NativeClassPtr, "<>9");
				GainSpecimens.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainSpecimens.__c>.NativeClassPtr, "<>9__8_0");
				GainSpecimens.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens.__c>.NativeClassPtr, 100670393);
				GainSpecimens.__c.NativeMethodInfoPtr__execute_b__8_0_Internal_EntityID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens.__c>.NativeClassPtr, 100670394);
			}

			// Token: 0x06006C30 RID: 27696 RVA: 0x001FE1B4 File Offset: 0x001FC3B4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainSpecimens.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpecimens.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006C31 RID: 27697 RVA: 0x001FE1F0 File Offset: 0x001FC3F0
			[CallerCount(0)]
			public unsafe EntityID _execute_b__8_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpecimens.__c.NativeMethodInfoPtr__execute_b__8_0_Internal_EntityID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x06006C32 RID: 27698 RVA: 0x0002AC9E File Offset: 0x00028E9E
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D7F RID: 7551
			// (get) Token: 0x06006C33 RID: 27699 RVA: 0x001FE240 File Offset: 0x001FC440
			// (set) Token: 0x06006C34 RID: 27700 RVA: 0x0002ACA7 File Offset: 0x00028EA7
			public unsafe static GainSpecimens.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GainSpecimens.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GainSpecimens.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GainSpecimens.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D80 RID: 7552
			// (get) Token: 0x06006C35 RID: 27701 RVA: 0x001FE268 File Offset: 0x001FC468
			// (set) Token: 0x06006C36 RID: 27702 RVA: 0x0002ACB9 File Offset: 0x00028EB9
			public unsafe static Func<Entity, EntityID> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GainSpecimens.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GainSpecimens.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040045ED RID: 17901
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040045EE RID: 17902
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x040045EF RID: 17903
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040045F0 RID: 17904
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__8_0_Internal_EntityID_Entity_0;
		}

		// Token: 0x02000784 RID: 1924
		[ObfuscatedName("worm.canis.actions.Immortality.GainSpecimens+<MakeAnalyticsData>d__7")]
		public sealed class _MakeAnalyticsData_d__7 : Object
		{
			// Token: 0x06006C37 RID: 27703 RVA: 0x001FE290 File Offset: 0x001FC490
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeAnalyticsData_d__7()
			{
				Il2CppClassPointerStore<GainSpecimens._MakeAnalyticsData_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainSpecimens>.NativeClassPtr, "<MakeAnalyticsData>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainSpecimens._MakeAnalyticsData_d__7>.NativeClassPtr);
				GainSpecimens._MakeAnalyticsData_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainSpecimens._MakeAnalyticsData_d__7>.NativeClassPtr, "<>1__state");
				GainSpecimens._MakeAnalyticsData_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainSpecimens._MakeAnalyticsData_d__7>.NativeClassPtr, "<>2__current");
				GainSpecimens._MakeAnalyticsData_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainSpecimens._MakeAnalyticsData_d__7>.NativeClassPtr, "<>l__initialThreadId");
				GainSpecimens._MakeAnalyticsData_d__7.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainSpecimens._MakeAnalyticsData_d__7>.NativeClassPtr, "wormMatch");
				GainSpecimens._MakeAnalyticsData_d__7.NativeFieldInfoPtr___3__wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainSpecimens._MakeAnalyticsData_d__7>.NativeClassPtr, "<>3__wormMatch");
				GainSpecimens._MakeAnalyticsData_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainSpecimens._MakeAnalyticsData_d__7>.NativeClassPtr, "<>4__this");
				GainSpecimens._MakeAnalyticsData_d__7.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainSpecimens._MakeAnalyticsData_d__7>.NativeClassPtr, "player");
				GainSpecimens._MakeAnalyticsData_d__7.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainSpecimens._MakeAnalyticsData_d__7>.NativeClassPtr, "<>3__player");
				GainSpecimens._MakeAnalyticsData_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens._MakeAnalyticsData_d__7>.NativeClassPtr, 100670395);
				GainSpecimens._MakeAnalyticsData_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens._MakeAnalyticsData_d__7>.NativeClassPtr, 100670396);
				GainSpecimens._MakeAnalyticsData_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens._MakeAnalyticsData_d__7>.NativeClassPtr, 100670397);
				GainSpecimens._MakeAnalyticsData_d__7.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens._MakeAnalyticsData_d__7>.NativeClassPtr, 100670398);
				GainSpecimens._MakeAnalyticsData_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens._MakeAnalyticsData_d__7>.NativeClassPtr, 100670399);
				GainSpecimens._MakeAnalyticsData_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens._MakeAnalyticsData_d__7>.NativeClassPtr, 100670400);
				GainSpecimens._MakeAnalyticsData_d__7.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens._MakeAnalyticsData_d__7>.NativeClassPtr, 100670401);
				GainSpecimens._MakeAnalyticsData_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens._MakeAnalyticsData_d__7>.NativeClassPtr, 100670402);
			}

			// Token: 0x06006C38 RID: 27704 RVA: 0x001FE3FC File Offset: 0x001FC5FC
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MakeAnalyticsData_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainSpecimens._MakeAnalyticsData_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpecimens._MakeAnalyticsData_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006C39 RID: 27705 RVA: 0x001FE444 File Offset: 0x001FC644
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpecimens._MakeAnalyticsData_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006C3A RID: 27706 RVA: 0x001FE478 File Offset: 0x001FC678
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170654, XrefRangeEnd = 170672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpecimens._MakeAnalyticsData_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001D89 RID: 7561
			// (get) Token: 0x06006C3B RID: 27707 RVA: 0x001FE4B4 File Offset: 0x001FC6B4
			public unsafe ValueTuple<string, Object> prop_ValueTuple_2_String_Object_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpecimens._MakeAnalyticsData_d__7.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<string, Object>(intPtr);
				}
			}

			// Token: 0x06006C3C RID: 27708 RVA: 0x001FE4EC File Offset: 0x001FC6EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170672, XrefRangeEnd = 170677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpecimens._MakeAnalyticsData_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D8A RID: 7562
			// (get) Token: 0x06006C3D RID: 27709 RVA: 0x001FE520 File Offset: 0x001FC720
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170677, XrefRangeEnd = 170680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpecimens._MakeAnalyticsData_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006C3E RID: 27710 RVA: 0x001FE560 File Offset: 0x001FC760
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170680, XrefRangeEnd = 170690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<string, Object>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpecimens._MakeAnalyticsData_d__7.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<string, Object>>>(intPtr3) : null;
			}

			// Token: 0x06006C3F RID: 27711 RVA: 0x001FE5A0 File Offset: 0x001FC7A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpecimens._MakeAnalyticsData_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006C40 RID: 27712 RVA: 0x0002ACCB File Offset: 0x00028ECB
			public _MakeAnalyticsData_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D81 RID: 7553
			// (get) Token: 0x06006C41 RID: 27713 RVA: 0x001FE5E0 File Offset: 0x001FC7E0
			// (set) Token: 0x06006C42 RID: 27714 RVA: 0x0002ACD4 File Offset: 0x00028ED4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._MakeAnalyticsData_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._MakeAnalyticsData_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D82 RID: 7554
			// (get) Token: 0x06006C43 RID: 27715 RVA: 0x001FE608 File Offset: 0x001FC808
			// (set) Token: 0x06006C44 RID: 27716 RVA: 0x0002ACEF File Offset: 0x00028EEF
			public ValueTuple<string, Object> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._MakeAnalyticsData_d__7.NativeFieldInfoPtr___2__current);
					return new ValueTuple<string, Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._MakeAnalyticsData_d__7.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001D83 RID: 7555
			// (get) Token: 0x06006C45 RID: 27717 RVA: 0x001FE638 File Offset: 0x001FC838
			// (set) Token: 0x06006C46 RID: 27718 RVA: 0x0002AD1D File Offset: 0x00028F1D
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._MakeAnalyticsData_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._MakeAnalyticsData_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001D84 RID: 7556
			// (get) Token: 0x06006C47 RID: 27719 RVA: 0x001FE660 File Offset: 0x001FC860
			// (set) Token: 0x06006C48 RID: 27720 RVA: 0x0002AD38 File Offset: 0x00028F38
			public unsafe WormMatch wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._MakeAnalyticsData_d__7.NativeFieldInfoPtr_wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._MakeAnalyticsData_d__7.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D85 RID: 7557
			// (get) Token: 0x06006C49 RID: 27721 RVA: 0x001FE690 File Offset: 0x001FC890
			// (set) Token: 0x06006C4A RID: 27722 RVA: 0x0002AD57 File Offset: 0x00028F57
			public unsafe WormMatch __3__wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._MakeAnalyticsData_d__7.NativeFieldInfoPtr___3__wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._MakeAnalyticsData_d__7.NativeFieldInfoPtr___3__wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D86 RID: 7558
			// (get) Token: 0x06006C4B RID: 27723 RVA: 0x001FE6C0 File Offset: 0x001FC8C0
			// (set) Token: 0x06006C4C RID: 27724 RVA: 0x0002AD76 File Offset: 0x00028F76
			public unsafe GainSpecimens __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._MakeAnalyticsData_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GainSpecimens>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._MakeAnalyticsData_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D87 RID: 7559
			// (get) Token: 0x06006C4D RID: 27725 RVA: 0x001FE6F0 File Offset: 0x001FC8F0
			// (set) Token: 0x06006C4E RID: 27726 RVA: 0x0002AD95 File Offset: 0x00028F95
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._MakeAnalyticsData_d__7.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._MakeAnalyticsData_d__7.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D88 RID: 7560
			// (get) Token: 0x06006C4F RID: 27727 RVA: 0x001FE720 File Offset: 0x001FC920
			// (set) Token: 0x06006C50 RID: 27728 RVA: 0x0002ADB4 File Offset: 0x00028FB4
			public unsafe WormPlayer __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._MakeAnalyticsData_d__7.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._MakeAnalyticsData_d__7.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040045F1 RID: 17905
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040045F2 RID: 17906
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040045F3 RID: 17907
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040045F4 RID: 17908
			private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

			// Token: 0x040045F5 RID: 17909
			private static readonly IntPtr NativeFieldInfoPtr___3__wormMatch;

			// Token: 0x040045F6 RID: 17910
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040045F7 RID: 17911
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040045F8 RID: 17912
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x040045F9 RID: 17913
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040045FA RID: 17914
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040045FB RID: 17915
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040045FC RID: 17916
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0;

			// Token: 0x040045FD RID: 17917
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040045FE RID: 17918
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040045FF RID: 17919
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0;

			// Token: 0x04004600 RID: 17920
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000785 RID: 1925
		[ObfuscatedName("worm.canis.actions.Immortality.GainSpecimens+<execute>d__8")]
		public sealed class _execute_d__8 : Object
		{
			// Token: 0x06006C51 RID: 27729 RVA: 0x001FE750 File Offset: 0x001FC950
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__8()
			{
				Il2CppClassPointerStore<GainSpecimens._execute_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainSpecimens>.NativeClassPtr, "<execute>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainSpecimens._execute_d__8>.NativeClassPtr);
				GainSpecimens._execute_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainSpecimens._execute_d__8>.NativeClassPtr, "<>1__state");
				GainSpecimens._execute_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainSpecimens._execute_d__8>.NativeClassPtr, "<>2__current");
				GainSpecimens._execute_d__8.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainSpecimens._execute_d__8>.NativeClassPtr, "<>l__initialThreadId");
				GainSpecimens._execute_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainSpecimens._execute_d__8>.NativeClassPtr, "<>4__this");
				GainSpecimens._execute_d__8.NativeFieldInfoPtr__wm_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainSpecimens._execute_d__8>.NativeClassPtr, "<wm>5__2");
				GainSpecimens._execute_d__8.NativeFieldInfoPtr__player_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainSpecimens._execute_d__8>.NativeClassPtr, "<player>5__3");
				GainSpecimens._execute_d__8.NativeFieldInfoPtr__unitsToMove_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainSpecimens._execute_d__8>.NativeClassPtr, "<unitsToMove>5__4");
				GainSpecimens._execute_d__8.NativeFieldInfoPtr__ungainedSpecimens_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainSpecimens._execute_d__8>.NativeClassPtr, "<ungainedSpecimens>5__5");
				GainSpecimens._execute_d__8.NativeFieldInfoPtr__logStr_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainSpecimens._execute_d__8>.NativeClassPtr, "<logStr>5__6");
				GainSpecimens._execute_d__8.NativeFieldInfoPtr__childUndo_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainSpecimens._execute_d__8>.NativeClassPtr, "<childUndo>5__7");
				GainSpecimens._execute_d__8.NativeFieldInfoPtr___7__wrap7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainSpecimens._execute_d__8>.NativeClassPtr, "<>7__wrap7");
				GainSpecimens._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens._execute_d__8>.NativeClassPtr, 100670403);
				GainSpecimens._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens._execute_d__8>.NativeClassPtr, 100670404);
				GainSpecimens._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens._execute_d__8>.NativeClassPtr, 100670405);
				GainSpecimens._execute_d__8.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens._execute_d__8>.NativeClassPtr, 100670406);
				GainSpecimens._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens._execute_d__8>.NativeClassPtr, 100670407);
				GainSpecimens._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens._execute_d__8>.NativeClassPtr, 100670408);
				GainSpecimens._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens._execute_d__8>.NativeClassPtr, 100670409);
				GainSpecimens._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens._execute_d__8>.NativeClassPtr, 100670410);
				GainSpecimens._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens._execute_d__8>.NativeClassPtr, 100670411);
			}

			// Token: 0x06006C52 RID: 27730 RVA: 0x001FE90C File Offset: 0x001FCB0C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainSpecimens._execute_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpecimens._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006C53 RID: 27731 RVA: 0x001FE954 File Offset: 0x001FCB54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170690, XrefRangeEnd = 170695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpecimens._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006C54 RID: 27732 RVA: 0x001FE988 File Offset: 0x001FCB88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170695, XrefRangeEnd = 170863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpecimens._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006C55 RID: 27733 RVA: 0x001FE9C4 File Offset: 0x001FCBC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170863, XrefRangeEnd = 170866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpecimens._execute_d__8.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D96 RID: 7574
			// (get) Token: 0x06006C56 RID: 27734 RVA: 0x001FE9F8 File Offset: 0x001FCBF8
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpecimens._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006C57 RID: 27735 RVA: 0x001FEA38 File Offset: 0x001FCC38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170866, XrefRangeEnd = 170871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpecimens._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D97 RID: 7575
			// (get) Token: 0x06006C58 RID: 27736 RVA: 0x001FEA6C File Offset: 0x001FCC6C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpecimens._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006C59 RID: 27737 RVA: 0x001FEAAC File Offset: 0x001FCCAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170871, XrefRangeEnd = 170873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpecimens._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006C5A RID: 27738 RVA: 0x001FEAEC File Offset: 0x001FCCEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpecimens._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006C5B RID: 27739 RVA: 0x0002ADD3 File Offset: 0x00028FD3
			public _execute_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D8B RID: 7563
			// (get) Token: 0x06006C5C RID: 27740 RVA: 0x001FEB2C File Offset: 0x001FCD2C
			// (set) Token: 0x06006C5D RID: 27741 RVA: 0x0002ADDC File Offset: 0x00028FDC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._execute_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._execute_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D8C RID: 7564
			// (get) Token: 0x06006C5E RID: 27742 RVA: 0x001FEB54 File Offset: 0x001FCD54
			// (set) Token: 0x06006C5F RID: 27743 RVA: 0x0002ADF7 File Offset: 0x00028FF7
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._execute_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._execute_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D8D RID: 7565
			// (get) Token: 0x06006C60 RID: 27744 RVA: 0x001FEB84 File Offset: 0x001FCD84
			// (set) Token: 0x06006C61 RID: 27745 RVA: 0x0002AE16 File Offset: 0x00029016
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._execute_d__8.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._execute_d__8.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001D8E RID: 7566
			// (get) Token: 0x06006C62 RID: 27746 RVA: 0x001FEBAC File Offset: 0x001FCDAC
			// (set) Token: 0x06006C63 RID: 27747 RVA: 0x0002AE31 File Offset: 0x00029031
			public unsafe GainSpecimens __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._execute_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GainSpecimens>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._execute_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D8F RID: 7567
			// (get) Token: 0x06006C64 RID: 27748 RVA: 0x001FEBDC File Offset: 0x001FCDDC
			// (set) Token: 0x06006C65 RID: 27749 RVA: 0x0002AE50 File Offset: 0x00029050
			public unsafe WormMatch _wm_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._execute_d__8.NativeFieldInfoPtr__wm_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._execute_d__8.NativeFieldInfoPtr__wm_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D90 RID: 7568
			// (get) Token: 0x06006C66 RID: 27750 RVA: 0x001FEC0C File Offset: 0x001FCE0C
			// (set) Token: 0x06006C67 RID: 27751 RVA: 0x0002AE6F File Offset: 0x0002906F
			public unsafe WormPlayer _player_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._execute_d__8.NativeFieldInfoPtr__player_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._execute_d__8.NativeFieldInfoPtr__player_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D91 RID: 7569
			// (get) Token: 0x06006C68 RID: 27752 RVA: 0x001FEC3C File Offset: 0x001FCE3C
			// (set) Token: 0x06006C69 RID: 27753 RVA: 0x0002AE8E File Offset: 0x0002908E
			public unsafe List<Entity> _unitsToMove_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._execute_d__8.NativeFieldInfoPtr__unitsToMove_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._execute_d__8.NativeFieldInfoPtr__unitsToMove_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D92 RID: 7570
			// (get) Token: 0x06006C6A RID: 27754 RVA: 0x001FEC6C File Offset: 0x001FCE6C
			// (set) Token: 0x06006C6B RID: 27755 RVA: 0x0002AEAD File Offset: 0x000290AD
			public unsafe int _ungainedSpecimens_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._execute_d__8.NativeFieldInfoPtr__ungainedSpecimens_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._execute_d__8.NativeFieldInfoPtr__ungainedSpecimens_5__5)) = value;
				}
			}

			// Token: 0x17001D93 RID: 7571
			// (get) Token: 0x06006C6C RID: 27756 RVA: 0x001FEC94 File Offset: 0x001FCE94
			// (set) Token: 0x06006C6D RID: 27757 RVA: 0x0002AEC8 File Offset: 0x000290C8
			public unsafe string _logStr_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._execute_d__8.NativeFieldInfoPtr__logStr_5__6);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._execute_d__8.NativeFieldInfoPtr__logStr_5__6), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001D94 RID: 7572
			// (get) Token: 0x06006C6E RID: 27758 RVA: 0x001FECBC File Offset: 0x001FCEBC
			// (set) Token: 0x06006C6F RID: 27759 RVA: 0x0002AEE7 File Offset: 0x000290E7
			public unsafe UndoNode _childUndo_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._execute_d__8.NativeFieldInfoPtr__childUndo_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._execute_d__8.NativeFieldInfoPtr__childUndo_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D95 RID: 7573
			// (get) Token: 0x06006C70 RID: 27760 RVA: 0x001FECEC File Offset: 0x001FCEEC
			// (set) Token: 0x06006C71 RID: 27761 RVA: 0x0002AF06 File Offset: 0x00029106
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._execute_d__8.NativeFieldInfoPtr___7__wrap7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._execute_d__8.NativeFieldInfoPtr___7__wrap7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004601 RID: 17921
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004602 RID: 17922
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004603 RID: 17923
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004604 RID: 17924
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004605 RID: 17925
			private static readonly IntPtr NativeFieldInfoPtr__wm_5__2;

			// Token: 0x04004606 RID: 17926
			private static readonly IntPtr NativeFieldInfoPtr__player_5__3;

			// Token: 0x04004607 RID: 17927
			private static readonly IntPtr NativeFieldInfoPtr__unitsToMove_5__4;

			// Token: 0x04004608 RID: 17928
			private static readonly IntPtr NativeFieldInfoPtr__ungainedSpecimens_5__5;

			// Token: 0x04004609 RID: 17929
			private static readonly IntPtr NativeFieldInfoPtr__logStr_5__6;

			// Token: 0x0400460A RID: 17930
			private static readonly IntPtr NativeFieldInfoPtr__childUndo_5__7;

			// Token: 0x0400460B RID: 17931
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap7;

			// Token: 0x0400460C RID: 17932
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400460D RID: 17933
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400460E RID: 17934
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400460F RID: 17935
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04004610 RID: 17936
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004611 RID: 17937
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004612 RID: 17938
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004613 RID: 17939
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004614 RID: 17940
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000786 RID: 1926
		[ObfuscatedName("worm.canis.actions.Immortality.GainSpecimens+<undo>d__9")]
		public sealed class _undo_d__9 : Object
		{
			// Token: 0x06006C72 RID: 27762 RVA: 0x001FED1C File Offset: 0x001FCF1C
			// Note: this type is marked as 'beforefieldinit'.
			static _undo_d__9()
			{
				Il2CppClassPointerStore<GainSpecimens._undo_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainSpecimens>.NativeClassPtr, "<undo>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainSpecimens._undo_d__9>.NativeClassPtr);
				GainSpecimens._undo_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainSpecimens._undo_d__9>.NativeClassPtr, "<>1__state");
				GainSpecimens._undo_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainSpecimens._undo_d__9>.NativeClassPtr, "<>2__current");
				GainSpecimens._undo_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainSpecimens._undo_d__9>.NativeClassPtr, "<>l__initialThreadId");
				GainSpecimens._undo_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainSpecimens._undo_d__9>.NativeClassPtr, "<>4__this");
				GainSpecimens._undo_d__9.NativeFieldInfoPtr_undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainSpecimens._undo_d__9>.NativeClassPtr, "undoContext");
				GainSpecimens._undo_d__9.NativeFieldInfoPtr___3__undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainSpecimens._undo_d__9>.NativeClassPtr, "<>3__undoContext");
				GainSpecimens._undo_d__9.NativeFieldInfoPtr__wm_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainSpecimens._undo_d__9>.NativeClassPtr, "<wm>5__2");
				GainSpecimens._undo_d__9.NativeFieldInfoPtr__player_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainSpecimens._undo_d__9>.NativeClassPtr, "<player>5__3");
				GainSpecimens._undo_d__9.NativeFieldInfoPtr__undoNode_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainSpecimens._undo_d__9>.NativeClassPtr, "<undoNode>5__4");
				GainSpecimens._undo_d__9.NativeFieldInfoPtr__gainedSpecimens_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainSpecimens._undo_d__9>.NativeClassPtr, "<gainedSpecimens>5__5");
				GainSpecimens._undo_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens._undo_d__9>.NativeClassPtr, 100670412);
				GainSpecimens._undo_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens._undo_d__9>.NativeClassPtr, 100670413);
				GainSpecimens._undo_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens._undo_d__9>.NativeClassPtr, 100670414);
				GainSpecimens._undo_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens._undo_d__9>.NativeClassPtr, 100670415);
				GainSpecimens._undo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens._undo_d__9>.NativeClassPtr, 100670416);
				GainSpecimens._undo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens._undo_d__9>.NativeClassPtr, 100670417);
				GainSpecimens._undo_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens._undo_d__9>.NativeClassPtr, 100670418);
				GainSpecimens._undo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpecimens._undo_d__9>.NativeClassPtr, 100670419);
			}

			// Token: 0x06006C73 RID: 27763 RVA: 0x001FEEB0 File Offset: 0x001FD0B0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _undo_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainSpecimens._undo_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpecimens._undo_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006C74 RID: 27764 RVA: 0x001FEEF8 File Offset: 0x001FD0F8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpecimens._undo_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006C75 RID: 27765 RVA: 0x001FEF2C File Offset: 0x001FD12C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170873, XrefRangeEnd = 170914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpecimens._undo_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001DA2 RID: 7586
			// (get) Token: 0x06006C76 RID: 27766 RVA: 0x001FEF68 File Offset: 0x001FD168
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpecimens._undo_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006C77 RID: 27767 RVA: 0x001FEFA8 File Offset: 0x001FD1A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170914, XrefRangeEnd = 170922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpecimens._undo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001DA3 RID: 7587
			// (get) Token: 0x06006C78 RID: 27768 RVA: 0x001FEFDC File Offset: 0x001FD1DC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpecimens._undo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006C79 RID: 27769 RVA: 0x001FF01C File Offset: 0x001FD21C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170922, XrefRangeEnd = 170931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpecimens._undo_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006C7A RID: 27770 RVA: 0x001FF05C File Offset: 0x001FD25C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpecimens._undo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006C7B RID: 27771 RVA: 0x0002AF25 File Offset: 0x00029125
			public _undo_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D98 RID: 7576
			// (get) Token: 0x06006C7C RID: 27772 RVA: 0x001FF09C File Offset: 0x001FD29C
			// (set) Token: 0x06006C7D RID: 27773 RVA: 0x0002AF2E File Offset: 0x0002912E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._undo_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._undo_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D99 RID: 7577
			// (get) Token: 0x06006C7E RID: 27774 RVA: 0x001FF0C4 File Offset: 0x001FD2C4
			// (set) Token: 0x06006C7F RID: 27775 RVA: 0x0002AF49 File Offset: 0x00029149
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._undo_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._undo_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D9A RID: 7578
			// (get) Token: 0x06006C80 RID: 27776 RVA: 0x001FF0F4 File Offset: 0x001FD2F4
			// (set) Token: 0x06006C81 RID: 27777 RVA: 0x0002AF68 File Offset: 0x00029168
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._undo_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._undo_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001D9B RID: 7579
			// (get) Token: 0x06006C82 RID: 27778 RVA: 0x001FF11C File Offset: 0x001FD31C
			// (set) Token: 0x06006C83 RID: 27779 RVA: 0x0002AF83 File Offset: 0x00029183
			public unsafe GainSpecimens __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._undo_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GainSpecimens>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._undo_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D9C RID: 7580
			// (get) Token: 0x06006C84 RID: 27780 RVA: 0x001FF14C File Offset: 0x001FD34C
			// (set) Token: 0x06006C85 RID: 27781 RVA: 0x0002AFA2 File Offset: 0x000291A2
			public unsafe Context undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._undo_d__9.NativeFieldInfoPtr_undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._undo_d__9.NativeFieldInfoPtr_undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D9D RID: 7581
			// (get) Token: 0x06006C86 RID: 27782 RVA: 0x001FF17C File Offset: 0x001FD37C
			// (set) Token: 0x06006C87 RID: 27783 RVA: 0x0002AFC1 File Offset: 0x000291C1
			public unsafe Context __3__undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._undo_d__9.NativeFieldInfoPtr___3__undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._undo_d__9.NativeFieldInfoPtr___3__undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D9E RID: 7582
			// (get) Token: 0x06006C88 RID: 27784 RVA: 0x001FF1AC File Offset: 0x001FD3AC
			// (set) Token: 0x06006C89 RID: 27785 RVA: 0x0002AFE0 File Offset: 0x000291E0
			public unsafe WormMatch _wm_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._undo_d__9.NativeFieldInfoPtr__wm_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._undo_d__9.NativeFieldInfoPtr__wm_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D9F RID: 7583
			// (get) Token: 0x06006C8A RID: 27786 RVA: 0x001FF1DC File Offset: 0x001FD3DC
			// (set) Token: 0x06006C8B RID: 27787 RVA: 0x0002AFFF File Offset: 0x000291FF
			public unsafe WormPlayer _player_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._undo_d__9.NativeFieldInfoPtr__player_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._undo_d__9.NativeFieldInfoPtr__player_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DA0 RID: 7584
			// (get) Token: 0x06006C8C RID: 27788 RVA: 0x001FF20C File Offset: 0x001FD40C
			// (set) Token: 0x06006C8D RID: 27789 RVA: 0x0002B01E File Offset: 0x0002921E
			public unsafe UndoNode _undoNode_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._undo_d__9.NativeFieldInfoPtr__undoNode_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._undo_d__9.NativeFieldInfoPtr__undoNode_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DA1 RID: 7585
			// (get) Token: 0x06006C8E RID: 27790 RVA: 0x001FF23C File Offset: 0x001FD43C
			// (set) Token: 0x06006C8F RID: 27791 RVA: 0x0002B03D File Offset: 0x0002923D
			public unsafe Il2CppReferenceArray<Entity> _gainedSpecimens_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._undo_d__9.NativeFieldInfoPtr__gainedSpecimens_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpecimens._undo_d__9.NativeFieldInfoPtr__gainedSpecimens_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004615 RID: 17941
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004616 RID: 17942
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004617 RID: 17943
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004618 RID: 17944
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004619 RID: 17945
			private static readonly IntPtr NativeFieldInfoPtr_undoContext;

			// Token: 0x0400461A RID: 17946
			private static readonly IntPtr NativeFieldInfoPtr___3__undoContext;

			// Token: 0x0400461B RID: 17947
			private static readonly IntPtr NativeFieldInfoPtr__wm_5__2;

			// Token: 0x0400461C RID: 17948
			private static readonly IntPtr NativeFieldInfoPtr__player_5__3;

			// Token: 0x0400461D RID: 17949
			private static readonly IntPtr NativeFieldInfoPtr__undoNode_5__4;

			// Token: 0x0400461E RID: 17950
			private static readonly IntPtr NativeFieldInfoPtr__gainedSpecimens_5__5;

			// Token: 0x0400461F RID: 17951
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004620 RID: 17952
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004621 RID: 17953
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004622 RID: 17954
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004623 RID: 17955
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004624 RID: 17956
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004625 RID: 17957
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004626 RID: 17958
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.context;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.data.enums;
using worm.canis.entities;

namespace worm.canis.actions
{
	// Token: 0x02000242 RID: 578
	public class GainFactionInfluence : global::Canis.actions.Action
	{
		// Token: 0x06001922 RID: 6434 RVA: 0x000BAC20 File Offset: 0x000B8E20
		// Note: this type is marked as 'beforefieldinit'.
		static GainFactionInfluence()
		{
			Il2CppClassPointerStore<GainFactionInfluence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "GainFactionInfluence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainFactionInfluence>.NativeClassPtr);
			GainFactionInfluence.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainFactionInfluence>.NativeClassPtr, "player");
			GainFactionInfluence.NativeFieldInfoPtr_faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainFactionInfluence>.NativeClassPtr, "faction");
			GainFactionInfluence.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainFactionInfluence>.NativeClassPtr, "Amount");
			GainFactionInfluence.NativeFieldInfoPtr_gameLogID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainFactionInfluence>.NativeClassPtr, "gameLogID");
			GainFactionInfluence.NativeFieldInfoPtr__LogMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainFactionInfluence>.NativeClassPtr, "<LogMode>k__BackingField");
			GainFactionInfluence.NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainFactionInfluence>.NativeClassPtr, 100667821);
			GainFactionInfluence.NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainFactionInfluence>.NativeClassPtr, 100667822);
			GainFactionInfluence.NativeMethodInfoPtr__ctor_Public_Void_Factions_Int32_Match_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainFactionInfluence>.NativeClassPtr, 100667823);
			GainFactionInfluence.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_Int32_Match_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainFactionInfluence>.NativeClassPtr, 100667824);
			GainFactionInfluence.NativeMethodInfoPtr__ctor_Public_Void_SerializedGainFactionInfluence_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainFactionInfluence>.NativeClassPtr, 100667825);
			GainFactionInfluence.NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainFactionInfluence>.NativeClassPtr, 100667826);
			GainFactionInfluence.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainFactionInfluence>.NativeClassPtr, 100667827);
			GainFactionInfluence.NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainFactionInfluence>.NativeClassPtr, 100667828);
			GainFactionInfluence.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainFactionInfluence>.NativeClassPtr, 100667829);
			GainFactionInfluence.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainFactionInfluence>.NativeClassPtr, 100667830);
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06001923 RID: 6435 RVA: 0x000BAD7C File Offset: 0x000B8F7C
		// (set) Token: 0x06001924 RID: 6436 RVA: 0x000BADB8 File Offset: 0x000B8FB8
		public unsafe virtual ActionLogModes LogMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainFactionInfluence.NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 135903, RefRangeEnd = 135917, XrefRangeStart = 135903, XrefRangeEnd = 135903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainFactionInfluence.NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x000BADF8 File Offset: 0x000B8FF8
		[CallerCount(49)]
		[CachedScanResults(RefRangeStart = 135919, RefRangeEnd = 135968, XrefRangeStart = 135917, XrefRangeEnd = 135919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GainFactionInfluence(Factions faction, int amt, Match m, int gameLogID = -1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainFactionInfluence>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref faction;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amt;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gameLogID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainFactionInfluence.NativeMethodInfoPtr__ctor_Public_Void_Factions_Int32_Match_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x000BAE70 File Offset: 0x000B9070
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 135970, RefRangeEnd = 135972, XrefRangeStart = 135968, XrefRangeEnd = 135970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GainFactionInfluence(WormPlayer player, int amt, Match m, int gameLogID = -1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainFactionInfluence>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amt;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gameLogID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainFactionInfluence.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_Int32_Match_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x000BAEEC File Offset: 0x000B90EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135972, XrefRangeEnd = 135977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GainFactionInfluence(SerializedGainFactionInfluence serialized, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainFactionInfluence>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainFactionInfluence.NativeMethodInfoPtr__ctor_Public_Void_SerializedGainFactionInfluence_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001928 RID: 6440 RVA: 0x000BAF4C File Offset: 0x000B914C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135977, XrefRangeEnd = 135984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<ValueTuple<string, Object>> MakeAnalyticsData(WormMatch wormMatch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainFactionInfluence.NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<string, Object>>>(intPtr3) : null;
			}
		}

		// Token: 0x06001929 RID: 6441 RVA: 0x000BAF9C File Offset: 0x000B919C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135984, XrefRangeEnd = 136037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainFactionInfluence.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x000BAFE8 File Offset: 0x000B91E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136037, XrefRangeEnd = 136041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HandleReturningAction(global::Canis.actions.Action returningAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(returningAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainFactionInfluence.NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x000BB038 File Offset: 0x000B9238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136041, XrefRangeEnd = 136048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> undo(Context undoContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainFactionInfluence.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x000BB094 File Offset: 0x000B9294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136048, XrefRangeEnd = 136053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainFactionInfluence.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x0000ACC9 File Offset: 0x00008EC9
		public GainFactionInfluence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x0600192E RID: 6446 RVA: 0x000BB0F0 File Offset: 0x000B92F0
		// (set) Token: 0x0600192F RID: 6447 RVA: 0x0000ACD2 File Offset: 0x00008ED2
		public unsafe WormPlayer player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06001930 RID: 6448 RVA: 0x000BB120 File Offset: 0x000B9320
		// (set) Token: 0x06001931 RID: 6449 RVA: 0x0000ACF1 File Offset: 0x00008EF1
		public unsafe Factions faction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence.NativeFieldInfoPtr_faction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence.NativeFieldInfoPtr_faction)) = value;
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06001932 RID: 6450 RVA: 0x000BB148 File Offset: 0x000B9348
		// (set) Token: 0x06001933 RID: 6451 RVA: 0x0000AD0C File Offset: 0x00008F0C
		public unsafe int Amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence.NativeFieldInfoPtr_Amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence.NativeFieldInfoPtr_Amount)) = value;
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06001934 RID: 6452 RVA: 0x000BB170 File Offset: 0x000B9370
		// (set) Token: 0x06001935 RID: 6453 RVA: 0x0000AD27 File Offset: 0x00008F27
		public unsafe int gameLogID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence.NativeFieldInfoPtr_gameLogID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence.NativeFieldInfoPtr_gameLogID)) = value;
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06001936 RID: 6454 RVA: 0x000BB198 File Offset: 0x000B9398
		// (set) Token: 0x06001937 RID: 6455 RVA: 0x0000AD42 File Offset: 0x00008F42
		public unsafe ActionLogModes _LogMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence.NativeFieldInfoPtr__LogMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence.NativeFieldInfoPtr__LogMode_k__BackingField)) = value;
			}
		}

		// Token: 0x04000F8A RID: 3978
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x04000F8B RID: 3979
		private static readonly IntPtr NativeFieldInfoPtr_faction;

		// Token: 0x04000F8C RID: 3980
		private static readonly IntPtr NativeFieldInfoPtr_Amount;

		// Token: 0x04000F8D RID: 3981
		private static readonly IntPtr NativeFieldInfoPtr_gameLogID;

		// Token: 0x04000F8E RID: 3982
		private static readonly IntPtr NativeFieldInfoPtr__LogMode_k__BackingField;

		// Token: 0x04000F8F RID: 3983
		private static readonly IntPtr NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0;

		// Token: 0x04000F90 RID: 3984
		private static readonly IntPtr NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0;

		// Token: 0x04000F91 RID: 3985
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Factions_Int32_Match_Int32_0;

		// Token: 0x04000F92 RID: 3986
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_Int32_Match_Int32_0;

		// Token: 0x04000F93 RID: 3987
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedGainFactionInfluence_Match_0;

		// Token: 0x04000F94 RID: 3988
		private static readonly IntPtr NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_0;

		// Token: 0x04000F95 RID: 3989
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04000F96 RID: 3990
		private static readonly IntPtr NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0;

		// Token: 0x04000F97 RID: 3991
		private static readonly IntPtr NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0;

		// Token: 0x04000F98 RID: 3992
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x0200067F RID: 1663
		[ObfuscatedName("worm.canis.actions.GainFactionInfluence+<MakeAnalyticsData>d__11")]
		public sealed class _MakeAnalyticsData_d__11 : Object
		{
			// Token: 0x060055C3 RID: 21955 RVA: 0x001BA400 File Offset: 0x001B8600
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeAnalyticsData_d__11()
			{
				Il2CppClassPointerStore<GainFactionInfluence._MakeAnalyticsData_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainFactionInfluence>.NativeClassPtr, "<MakeAnalyticsData>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainFactionInfluence._MakeAnalyticsData_d__11>.NativeClassPtr);
				GainFactionInfluence._MakeAnalyticsData_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainFactionInfluence._MakeAnalyticsData_d__11>.NativeClassPtr, "<>1__state");
				GainFactionInfluence._MakeAnalyticsData_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainFactionInfluence._MakeAnalyticsData_d__11>.NativeClassPtr, "<>2__current");
				GainFactionInfluence._MakeAnalyticsData_d__11.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainFactionInfluence._MakeAnalyticsData_d__11>.NativeClassPtr, "<>l__initialThreadId");
				GainFactionInfluence._MakeAnalyticsData_d__11.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainFactionInfluence._MakeAnalyticsData_d__11>.NativeClassPtr, "wormMatch");
				GainFactionInfluence._MakeAnalyticsData_d__11.NativeFieldInfoPtr___3__wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainFactionInfluence._MakeAnalyticsData_d__11>.NativeClassPtr, "<>3__wormMatch");
				GainFactionInfluence._MakeAnalyticsData_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainFactionInfluence._MakeAnalyticsData_d__11>.NativeClassPtr, "<>4__this");
				GainFactionInfluence._MakeAnalyticsData_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainFactionInfluence._MakeAnalyticsData_d__11>.NativeClassPtr, 100667831);
				GainFactionInfluence._MakeAnalyticsData_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainFactionInfluence._MakeAnalyticsData_d__11>.NativeClassPtr, 100667832);
				GainFactionInfluence._MakeAnalyticsData_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainFactionInfluence._MakeAnalyticsData_d__11>.NativeClassPtr, 100667833);
				GainFactionInfluence._MakeAnalyticsData_d__11.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainFactionInfluence._MakeAnalyticsData_d__11>.NativeClassPtr, 100667834);
				GainFactionInfluence._MakeAnalyticsData_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainFactionInfluence._MakeAnalyticsData_d__11>.NativeClassPtr, 100667835);
				GainFactionInfluence._MakeAnalyticsData_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainFactionInfluence._MakeAnalyticsData_d__11>.NativeClassPtr, 100667836);
				GainFactionInfluence._MakeAnalyticsData_d__11.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainFactionInfluence._MakeAnalyticsData_d__11>.NativeClassPtr, 100667837);
				GainFactionInfluence._MakeAnalyticsData_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainFactionInfluence._MakeAnalyticsData_d__11>.NativeClassPtr, 100667838);
			}

			// Token: 0x060055C4 RID: 21956 RVA: 0x001BA544 File Offset: 0x001B8744
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MakeAnalyticsData_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainFactionInfluence._MakeAnalyticsData_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainFactionInfluence._MakeAnalyticsData_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060055C5 RID: 21957 RVA: 0x001BA58C File Offset: 0x001B878C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainFactionInfluence._MakeAnalyticsData_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060055C6 RID: 21958 RVA: 0x001BA5C0 File Offset: 0x001B87C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135796, XrefRangeEnd = 135816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainFactionInfluence._MakeAnalyticsData_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700159F RID: 5535
			// (get) Token: 0x060055C7 RID: 21959 RVA: 0x001BA5FC File Offset: 0x001B87FC
			public unsafe ValueTuple<string, Object> prop_ValueTuple_2_String_Object_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainFactionInfluence._MakeAnalyticsData_d__11.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<string, Object>(intPtr);
				}
			}

			// Token: 0x060055C8 RID: 21960 RVA: 0x001BA634 File Offset: 0x001B8834
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135816, XrefRangeEnd = 135821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainFactionInfluence._MakeAnalyticsData_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170015A0 RID: 5536
			// (get) Token: 0x060055C9 RID: 21961 RVA: 0x001BA668 File Offset: 0x001B8868
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135821, XrefRangeEnd = 135824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainFactionInfluence._MakeAnalyticsData_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060055CA RID: 21962 RVA: 0x001BA6A8 File Offset: 0x001B88A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135824, XrefRangeEnd = 135833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<string, Object>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainFactionInfluence._MakeAnalyticsData_d__11.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<string, Object>>>(intPtr3) : null;
			}

			// Token: 0x060055CB RID: 21963 RVA: 0x001BA6E8 File Offset: 0x001B88E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainFactionInfluence._MakeAnalyticsData_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060055CC RID: 21964 RVA: 0x0001E9ED File Offset: 0x0001CBED
			public _MakeAnalyticsData_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001599 RID: 5529
			// (get) Token: 0x060055CD RID: 21965 RVA: 0x001BA728 File Offset: 0x001B8928
			// (set) Token: 0x060055CE RID: 21966 RVA: 0x0001E9F6 File Offset: 0x0001CBF6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence._MakeAnalyticsData_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence._MakeAnalyticsData_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700159A RID: 5530
			// (get) Token: 0x060055CF RID: 21967 RVA: 0x001BA750 File Offset: 0x001B8950
			// (set) Token: 0x060055D0 RID: 21968 RVA: 0x0001EA11 File Offset: 0x0001CC11
			public ValueTuple<string, Object> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence._MakeAnalyticsData_d__11.NativeFieldInfoPtr___2__current);
					return new ValueTuple<string, Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence._MakeAnalyticsData_d__11.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700159B RID: 5531
			// (get) Token: 0x060055D1 RID: 21969 RVA: 0x001BA780 File Offset: 0x001B8980
			// (set) Token: 0x060055D2 RID: 21970 RVA: 0x0001EA3F File Offset: 0x0001CC3F
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence._MakeAnalyticsData_d__11.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence._MakeAnalyticsData_d__11.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700159C RID: 5532
			// (get) Token: 0x060055D3 RID: 21971 RVA: 0x001BA7A8 File Offset: 0x001B89A8
			// (set) Token: 0x060055D4 RID: 21972 RVA: 0x0001EA5A File Offset: 0x0001CC5A
			public unsafe WormMatch wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence._MakeAnalyticsData_d__11.NativeFieldInfoPtr_wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence._MakeAnalyticsData_d__11.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700159D RID: 5533
			// (get) Token: 0x060055D5 RID: 21973 RVA: 0x001BA7D8 File Offset: 0x001B89D8
			// (set) Token: 0x060055D6 RID: 21974 RVA: 0x0001EA79 File Offset: 0x0001CC79
			public unsafe WormMatch __3__wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence._MakeAnalyticsData_d__11.NativeFieldInfoPtr___3__wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence._MakeAnalyticsData_d__11.NativeFieldInfoPtr___3__wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700159E RID: 5534
			// (get) Token: 0x060055D7 RID: 21975 RVA: 0x001BA808 File Offset: 0x001B8A08
			// (set) Token: 0x060055D8 RID: 21976 RVA: 0x0001EA98 File Offset: 0x0001CC98
			public unsafe GainFactionInfluence __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence._MakeAnalyticsData_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GainFactionInfluence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence._MakeAnalyticsData_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003805 RID: 14341
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003806 RID: 14342
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003807 RID: 14343
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003808 RID: 14344
			private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

			// Token: 0x04003809 RID: 14345
			private static readonly IntPtr NativeFieldInfoPtr___3__wormMatch;

			// Token: 0x0400380A RID: 14346
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400380B RID: 14347
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400380C RID: 14348
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400380D RID: 14349
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400380E RID: 14350
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0;

			// Token: 0x0400380F RID: 14351
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003810 RID: 14352
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003811 RID: 14353
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0;

			// Token: 0x04003812 RID: 14354
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000680 RID: 1664
		[ObfuscatedName("worm.canis.actions.GainFactionInfluence+<undo>d__14")]
		public sealed class _undo_d__14 : Object
		{
			// Token: 0x060055D9 RID: 21977 RVA: 0x001BA838 File Offset: 0x001B8A38
			// Note: this type is marked as 'beforefieldinit'.
			static _undo_d__14()
			{
				Il2CppClassPointerStore<GainFactionInfluence._undo_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainFactionInfluence>.NativeClassPtr, "<undo>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainFactionInfluence._undo_d__14>.NativeClassPtr);
				GainFactionInfluence._undo_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainFactionInfluence._undo_d__14>.NativeClassPtr, "<>1__state");
				GainFactionInfluence._undo_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainFactionInfluence._undo_d__14>.NativeClassPtr, "<>2__current");
				GainFactionInfluence._undo_d__14.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainFactionInfluence._undo_d__14>.NativeClassPtr, "<>l__initialThreadId");
				GainFactionInfluence._undo_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainFactionInfluence._undo_d__14>.NativeClassPtr, "<>4__this");
				GainFactionInfluence._undo_d__14.NativeFieldInfoPtr_undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainFactionInfluence._undo_d__14>.NativeClassPtr, "undoContext");
				GainFactionInfluence._undo_d__14.NativeFieldInfoPtr___3__undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainFactionInfluence._undo_d__14>.NativeClassPtr, "<>3__undoContext");
				GainFactionInfluence._undo_d__14.NativeFieldInfoPtr__wm_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainFactionInfluence._undo_d__14>.NativeClassPtr, "<wm>5__2");
				GainFactionInfluence._undo_d__14.NativeFieldInfoPtr__originSpace_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainFactionInfluence._undo_d__14>.NativeClassPtr, "<originSpace>5__3");
				GainFactionInfluence._undo_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainFactionInfluence._undo_d__14>.NativeClassPtr, 100667839);
				GainFactionInfluence._undo_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainFactionInfluence._undo_d__14>.NativeClassPtr, 100667840);
				GainFactionInfluence._undo_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainFactionInfluence._undo_d__14>.NativeClassPtr, 100667841);
				GainFactionInfluence._undo_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainFactionInfluence._undo_d__14>.NativeClassPtr, 100667842);
				GainFactionInfluence._undo_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainFactionInfluence._undo_d__14>.NativeClassPtr, 100667843);
				GainFactionInfluence._undo_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainFactionInfluence._undo_d__14>.NativeClassPtr, 100667844);
				GainFactionInfluence._undo_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainFactionInfluence._undo_d__14>.NativeClassPtr, 100667845);
				GainFactionInfluence._undo_d__14.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainFactionInfluence._undo_d__14>.NativeClassPtr, 100667846);
			}

			// Token: 0x060055DA RID: 21978 RVA: 0x001BA9A4 File Offset: 0x001B8BA4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _undo_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainFactionInfluence._undo_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainFactionInfluence._undo_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060055DB RID: 21979 RVA: 0x001BA9EC File Offset: 0x001B8BEC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainFactionInfluence._undo_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060055DC RID: 21980 RVA: 0x001BAA20 File Offset: 0x001B8C20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135833, XrefRangeEnd = 135889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainFactionInfluence._undo_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170015A9 RID: 5545
			// (get) Token: 0x060055DD RID: 21981 RVA: 0x001BAA5C File Offset: 0x001B8C5C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainFactionInfluence._undo_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060055DE RID: 21982 RVA: 0x001BAA9C File Offset: 0x001B8C9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135889, XrefRangeEnd = 135894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainFactionInfluence._undo_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170015AA RID: 5546
			// (get) Token: 0x060055DF RID: 21983 RVA: 0x001BAAD0 File Offset: 0x001B8CD0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainFactionInfluence._undo_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060055E0 RID: 21984 RVA: 0x001BAB10 File Offset: 0x001B8D10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135894, XrefRangeEnd = 135903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainFactionInfluence._undo_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060055E1 RID: 21985 RVA: 0x001BAB50 File Offset: 0x001B8D50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainFactionInfluence._undo_d__14.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060055E2 RID: 21986 RVA: 0x0001EAB7 File Offset: 0x0001CCB7
			public _undo_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015A1 RID: 5537
			// (get) Token: 0x060055E3 RID: 21987 RVA: 0x001BAB90 File Offset: 0x001B8D90
			// (set) Token: 0x060055E4 RID: 21988 RVA: 0x0001EAC0 File Offset: 0x0001CCC0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence._undo_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence._undo_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170015A2 RID: 5538
			// (get) Token: 0x060055E5 RID: 21989 RVA: 0x001BABB8 File Offset: 0x001B8DB8
			// (set) Token: 0x060055E6 RID: 21990 RVA: 0x0001EADB File Offset: 0x0001CCDB
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence._undo_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence._undo_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015A3 RID: 5539
			// (get) Token: 0x060055E7 RID: 21991 RVA: 0x001BABE8 File Offset: 0x001B8DE8
			// (set) Token: 0x060055E8 RID: 21992 RVA: 0x0001EAFA File Offset: 0x0001CCFA
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence._undo_d__14.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence._undo_d__14.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170015A4 RID: 5540
			// (get) Token: 0x060055E9 RID: 21993 RVA: 0x001BAC10 File Offset: 0x001B8E10
			// (set) Token: 0x060055EA RID: 21994 RVA: 0x0001EB15 File Offset: 0x0001CD15
			public unsafe GainFactionInfluence __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence._undo_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GainFactionInfluence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence._undo_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015A5 RID: 5541
			// (get) Token: 0x060055EB RID: 21995 RVA: 0x001BAC40 File Offset: 0x001B8E40
			// (set) Token: 0x060055EC RID: 21996 RVA: 0x0001EB34 File Offset: 0x0001CD34
			public unsafe Context undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence._undo_d__14.NativeFieldInfoPtr_undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence._undo_d__14.NativeFieldInfoPtr_undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015A6 RID: 5542
			// (get) Token: 0x060055ED RID: 21997 RVA: 0x001BAC70 File Offset: 0x001B8E70
			// (set) Token: 0x060055EE RID: 21998 RVA: 0x0001EB53 File Offset: 0x0001CD53
			public unsafe Context __3__undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence._undo_d__14.NativeFieldInfoPtr___3__undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence._undo_d__14.NativeFieldInfoPtr___3__undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015A7 RID: 5543
			// (get) Token: 0x060055EF RID: 21999 RVA: 0x001BACA0 File Offset: 0x001B8EA0
			// (set) Token: 0x060055F0 RID: 22000 RVA: 0x0001EB72 File Offset: 0x0001CD72
			public unsafe WormMatch _wm_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence._undo_d__14.NativeFieldInfoPtr__wm_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence._undo_d__14.NativeFieldInfoPtr__wm_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015A8 RID: 5544
			// (get) Token: 0x060055F1 RID: 22001 RVA: 0x001BACD0 File Offset: 0x001B8ED0
			// (set) Token: 0x060055F2 RID: 22002 RVA: 0x0001EB91 File Offset: 0x0001CD91
			public unsafe WormSpace _originSpace_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence._undo_d__14.NativeFieldInfoPtr__originSpace_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainFactionInfluence._undo_d__14.NativeFieldInfoPtr__originSpace_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003813 RID: 14355
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003814 RID: 14356
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003815 RID: 14357
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003816 RID: 14358
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003817 RID: 14359
			private static readonly IntPtr NativeFieldInfoPtr_undoContext;

			// Token: 0x04003818 RID: 14360
			private static readonly IntPtr NativeFieldInfoPtr___3__undoContext;

			// Token: 0x04003819 RID: 14361
			private static readonly IntPtr NativeFieldInfoPtr__wm_5__2;

			// Token: 0x0400381A RID: 14362
			private static readonly IntPtr NativeFieldInfoPtr__originSpace_5__3;

			// Token: 0x0400381B RID: 14363
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400381C RID: 14364
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400381D RID: 14365
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400381E RID: 14366
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400381F RID: 14367
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003820 RID: 14368
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003821 RID: 14369
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003822 RID: 14370
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

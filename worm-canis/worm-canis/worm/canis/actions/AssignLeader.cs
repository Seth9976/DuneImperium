using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.actions
{
	// Token: 0x02000226 RID: 550
	public class AssignLeader : global::Canis.actions.Action
	{
		// Token: 0x06001840 RID: 6208 RVA: 0x000B71E0 File Offset: 0x000B53E0
		// Note: this type is marked as 'beforefieldinit'.
		static AssignLeader()
		{
			Il2CppClassPointerStore<AssignLeader>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "AssignLeader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssignLeader>.NativeClassPtr);
			AssignLeader.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignLeader>.NativeClassPtr, "wormMatch");
			AssignLeader.NativeFieldInfoPtr_initialOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignLeader>.NativeClassPtr, "initialOptions");
			AssignLeader.NativeFieldInfoPtr_Player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignLeader>.NativeClassPtr, "Player");
			AssignLeader.NativeMethodInfoPtr_get_Options_Protected_Abstract_Virtual_New_get_IReadOnlyList_1_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignLeader>.NativeClassPtr, 100667436);
			AssignLeader.NativeMethodInfoPtr_get_WithTargeting_Public_Abstract_Virtual_New_get_TargetPicker_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignLeader>.NativeClassPtr, 100667437);
			AssignLeader.NativeMethodInfoPtr_MakeAnalyticsData_Protected_Abstract_Virtual_New_IEnumerable_1_ValueTuple_2_String_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignLeader>.NativeClassPtr, 100667438);
			AssignLeader.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_IEnumerable_1_ArchetypeID_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignLeader>.NativeClassPtr, 100667439);
			AssignLeader.NativeMethodInfoPtr_GetPlayer_Private_Static_WormPlayer_SerializedAssignLeader_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignLeader>.NativeClassPtr, 100667440);
			AssignLeader.NativeMethodInfoPtr__ctor_Protected_Void_SerializedAssignLeader_IEnumerable_1_ArchetypeID_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignLeader>.NativeClassPtr, 100667441);
			AssignLeader.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignLeader>.NativeClassPtr, 100667442);
			AssignLeader.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_Final_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignLeader>.NativeClassPtr, 100667443);
			AssignLeader.NativeMethodInfoPtr_MakeSerializedAssignLeader_Protected_Abstract_Virtual_New_SerializedAssignLeader_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignLeader>.NativeClassPtr, 100667444);
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06001841 RID: 6209 RVA: 0x000B7300 File Offset: 0x000B5500
		public unsafe virtual IReadOnlyList<ArchetypeID> Options
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssignLeader.NativeMethodInfoPtr_get_Options_Protected_Abstract_Virtual_New_get_IReadOnlyList_1_ArchetypeID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<ArchetypeID>>(intPtr3) : null;
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06001842 RID: 6210 RVA: 0x000B734C File Offset: 0x000B554C
		public unsafe virtual TargetPicker<int> WithTargeting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssignLeader.NativeMethodInfoPtr_get_WithTargeting_Public_Abstract_Virtual_New_get_TargetPicker_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetPicker<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x000B7398 File Offset: 0x000B5598
		[CallerCount(0)]
		public unsafe virtual IEnumerable<ValueTuple<string, Object>> MakeAnalyticsData(int choice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref choice;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssignLeader.NativeMethodInfoPtr_MakeAnalyticsData_Protected_Abstract_Virtual_New_IEnumerable_1_ValueTuple_2_String_Object_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<string, Object>>>(intPtr3) : null;
			}
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x000B73F0 File Offset: 0x000B55F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 131800, RefRangeEnd = 131803, XrefRangeStart = 131787, XrefRangeEnd = 131800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssignLeader(WormPlayer player, IEnumerable<ArchetypeID> options, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssignLeader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignLeader.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_IEnumerable_1_ArchetypeID_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x000B7460 File Offset: 0x000B5660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131803, XrefRangeEnd = 131806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WormPlayer GetPlayer(SerializedAssignLeader serialized, WormMatch match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignLeader.NativeMethodInfoPtr_GetPlayer_Private_Static_WormPlayer_SerializedAssignLeader_WormMatch_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr3) : null;
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x000B74B8 File Offset: 0x000B56B8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 131828, RefRangeEnd = 131834, XrefRangeStart = 131806, XrefRangeEnd = 131828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssignLeader(SerializedAssignLeader serialized, IEnumerable<ArchetypeID> options, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssignLeader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignLeader.NativeMethodInfoPtr__ctor_Protected_Void_SerializedAssignLeader_IEnumerable_1_ArchetypeID_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x000B7528 File Offset: 0x000B5728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131834, XrefRangeEnd = 131840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssignLeader.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x000B7574 File Offset: 0x000B5774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131840, XrefRangeEnd = 131841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignLeader.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_Final_SerializedAction_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x000B75C4 File Offset: 0x000B57C4
		[CallerCount(0)]
		public unsafe virtual SerializedAssignLeader MakeSerializedAssignLeader(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssignLeader.NativeMethodInfoPtr_MakeSerializedAssignLeader_Protected_Abstract_Virtual_New_SerializedAssignLeader_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAssignLeader>(intPtr3) : null;
			}
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x0000A86E File Offset: 0x00008A6E
		public AssignLeader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x0600184B RID: 6219 RVA: 0x000B7620 File Offset: 0x000B5820
		// (set) Token: 0x0600184C RID: 6220 RVA: 0x0000A877 File Offset: 0x00008A77
		public unsafe WormMatch wormMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignLeader.NativeFieldInfoPtr_wormMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignLeader.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x0600184D RID: 6221 RVA: 0x000B7650 File Offset: 0x000B5850
		// (set) Token: 0x0600184E RID: 6222 RVA: 0x0000A896 File Offset: 0x00008A96
		public unsafe List<ArchetypeID> initialOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignLeader.NativeFieldInfoPtr_initialOptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignLeader.NativeFieldInfoPtr_initialOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x0600184F RID: 6223 RVA: 0x000B7680 File Offset: 0x000B5880
		// (set) Token: 0x06001850 RID: 6224 RVA: 0x0000A8B5 File Offset: 0x00008AB5
		public unsafe WormPlayer Player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignLeader.NativeFieldInfoPtr_Player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignLeader.NativeFieldInfoPtr_Player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EFD RID: 3837
		private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

		// Token: 0x04000EFE RID: 3838
		private static readonly IntPtr NativeFieldInfoPtr_initialOptions;

		// Token: 0x04000EFF RID: 3839
		private static readonly IntPtr NativeFieldInfoPtr_Player;

		// Token: 0x04000F00 RID: 3840
		private static readonly IntPtr NativeMethodInfoPtr_get_Options_Protected_Abstract_Virtual_New_get_IReadOnlyList_1_ArchetypeID_0;

		// Token: 0x04000F01 RID: 3841
		private static readonly IntPtr NativeMethodInfoPtr_get_WithTargeting_Public_Abstract_Virtual_New_get_TargetPicker_1_Int32_0;

		// Token: 0x04000F02 RID: 3842
		private static readonly IntPtr NativeMethodInfoPtr_MakeAnalyticsData_Protected_Abstract_Virtual_New_IEnumerable_1_ValueTuple_2_String_Object_Int32_0;

		// Token: 0x04000F03 RID: 3843
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_IEnumerable_1_ArchetypeID_WormMatch_0;

		// Token: 0x04000F04 RID: 3844
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayer_Private_Static_WormPlayer_SerializedAssignLeader_WormMatch_0;

		// Token: 0x04000F05 RID: 3845
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializedAssignLeader_IEnumerable_1_ArchetypeID_WormMatch_0;

		// Token: 0x04000F06 RID: 3846
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04000F07 RID: 3847
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_Final_SerializedAction_Match_0;

		// Token: 0x04000F08 RID: 3848
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAssignLeader_Protected_Abstract_Virtual_New_SerializedAssignLeader_Match_0;

		// Token: 0x02000653 RID: 1619
		[ObfuscatedName("worm.canis.actions.AssignLeader+<execute>d__11")]
		public sealed class _execute_d__11 : Object
		{
			// Token: 0x0600527A RID: 21114 RVA: 0x001B08A8 File Offset: 0x001AEAA8
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__11()
			{
				Il2CppClassPointerStore<AssignLeader._execute_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssignLeader>.NativeClassPtr, "<execute>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssignLeader._execute_d__11>.NativeClassPtr);
				AssignLeader._execute_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignLeader._execute_d__11>.NativeClassPtr, "<>1__state");
				AssignLeader._execute_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignLeader._execute_d__11>.NativeClassPtr, "<>2__current");
				AssignLeader._execute_d__11.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignLeader._execute_d__11>.NativeClassPtr, "<>l__initialThreadId");
				AssignLeader._execute_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignLeader._execute_d__11>.NativeClassPtr, "<>4__this");
				AssignLeader._execute_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignLeader._execute_d__11>.NativeClassPtr, 100667445);
				AssignLeader._execute_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignLeader._execute_d__11>.NativeClassPtr, 100667446);
				AssignLeader._execute_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignLeader._execute_d__11>.NativeClassPtr, 100667447);
				AssignLeader._execute_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignLeader._execute_d__11>.NativeClassPtr, 100667448);
				AssignLeader._execute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignLeader._execute_d__11>.NativeClassPtr, 100667449);
				AssignLeader._execute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignLeader._execute_d__11>.NativeClassPtr, 100667450);
				AssignLeader._execute_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignLeader._execute_d__11>.NativeClassPtr, 100667451);
				AssignLeader._execute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignLeader._execute_d__11>.NativeClassPtr, 100667452);
			}

			// Token: 0x0600527B RID: 21115 RVA: 0x001B09C4 File Offset: 0x001AEBC4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssignLeader._execute_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignLeader._execute_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600527C RID: 21116 RVA: 0x001B0A0C File Offset: 0x001AEC0C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignLeader._execute_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600527D RID: 21117 RVA: 0x001B0A40 File Offset: 0x001AEC40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131741, XrefRangeEnd = 131780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignLeader._execute_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001474 RID: 5236
			// (get) Token: 0x0600527E RID: 21118 RVA: 0x001B0A7C File Offset: 0x001AEC7C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignLeader._execute_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600527F RID: 21119 RVA: 0x001B0ABC File Offset: 0x001AECBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131780, XrefRangeEnd = 131785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignLeader._execute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001475 RID: 5237
			// (get) Token: 0x06005280 RID: 21120 RVA: 0x001B0AF0 File Offset: 0x001AECF0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignLeader._execute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005281 RID: 21121 RVA: 0x001B0B30 File Offset: 0x001AED30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131785, XrefRangeEnd = 131787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignLeader._execute_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005282 RID: 21122 RVA: 0x001B0B70 File Offset: 0x001AED70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignLeader._execute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005283 RID: 21123 RVA: 0x0001CC64 File Offset: 0x0001AE64
			public _execute_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001470 RID: 5232
			// (get) Token: 0x06005284 RID: 21124 RVA: 0x001B0BB0 File Offset: 0x001AEDB0
			// (set) Token: 0x06005285 RID: 21125 RVA: 0x0001CC6D File Offset: 0x0001AE6D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignLeader._execute_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignLeader._execute_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001471 RID: 5233
			// (get) Token: 0x06005286 RID: 21126 RVA: 0x001B0BD8 File Offset: 0x001AEDD8
			// (set) Token: 0x06005287 RID: 21127 RVA: 0x0001CC88 File Offset: 0x0001AE88
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignLeader._execute_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignLeader._execute_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001472 RID: 5234
			// (get) Token: 0x06005288 RID: 21128 RVA: 0x001B0C08 File Offset: 0x001AEE08
			// (set) Token: 0x06005289 RID: 21129 RVA: 0x0001CCA7 File Offset: 0x0001AEA7
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignLeader._execute_d__11.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignLeader._execute_d__11.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001473 RID: 5235
			// (get) Token: 0x0600528A RID: 21130 RVA: 0x001B0C30 File Offset: 0x001AEE30
			// (set) Token: 0x0600528B RID: 21131 RVA: 0x0001CCC2 File Offset: 0x0001AEC2
			public unsafe AssignLeader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignLeader._execute_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssignLeader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignLeader._execute_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003607 RID: 13831
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003608 RID: 13832
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003609 RID: 13833
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400360A RID: 13834
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400360B RID: 13835
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400360C RID: 13836
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400360D RID: 13837
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400360E RID: 13838
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400360F RID: 13839
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003610 RID: 13840
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003611 RID: 13841
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003612 RID: 13842
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

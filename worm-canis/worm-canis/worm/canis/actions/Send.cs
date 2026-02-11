using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.attributes;
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
	// Token: 0x02000299 RID: 665
	public class Send : global::Canis.actions.Action
	{
		// Token: 0x06001BB2 RID: 7090 RVA: 0x000C47D0 File Offset: 0x000C29D0
		// Note: this type is marked as 'beforefieldinit'.
		static Send()
		{
			Il2CppClassPointerStore<Send>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "Send");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Send>.NativeClassPtr);
			Send.NativeFieldInfoPtr_ControlResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send>.NativeClassPtr, "ControlResources");
			Send.NativeMethodInfoPtr__ctor_Public_Void_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Send>.NativeClassPtr, 100668829);
			Send.NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormAgent_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Send>.NativeClassPtr, 100668830);
			Send.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Send>.NativeClassPtr, 100668831);
			Send.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Send>.NativeClassPtr, 100668832);
			Send.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Send>.NativeClassPtr, 100668833);
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x000C4878 File Offset: 0x000C2A78
		[CallerCount(191)]
		[CachedScanResults(RefRangeStart = 51381, RefRangeEnd = 51572, XrefRangeStart = 51381, XrefRangeEnd = 51572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Send(Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Send>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Send.NativeMethodInfoPtr__ctor_Public_Void_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x000C48C4 File Offset: 0x000C2AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147488, XrefRangeEnd = 147496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<ValueTuple<string, Object>> MakeAnalyticsData(WormAgent agent, WormSpace space)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(agent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(space);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Send.NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormAgent_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<string, Object>>>(intPtr3) : null;
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x000C4928 File Offset: 0x000C2B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147496, XrefRangeEnd = 147502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Send.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x000C4974 File Offset: 0x000C2B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147502, XrefRangeEnd = 147509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> undo(Context undoContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Send.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x06001BB7 RID: 7095 RVA: 0x000C49D0 File Offset: 0x000C2BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147509, XrefRangeEnd = 147513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Send.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x0000BD33 File Offset: 0x00009F33
		public Send(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06001BB9 RID: 7097 RVA: 0x000C4A2C File Offset: 0x000C2C2C
		// (set) Token: 0x06001BBA RID: 7098 RVA: 0x0000BD3C File Offset: 0x00009F3C
		public unsafe static Dictionary<AttributeDefinition<Nullable<int>>, AttributeDefinition<Nullable<int>>> ControlResources
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Send.NativeFieldInfoPtr_ControlResources, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AttributeDefinition<Nullable<int>>, AttributeDefinition<Nullable<int>>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Send.NativeFieldInfoPtr_ControlResources, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001119 RID: 4377
		private static readonly IntPtr NativeFieldInfoPtr_ControlResources;

		// Token: 0x0400111A RID: 4378
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_0;

		// Token: 0x0400111B RID: 4379
		private static readonly IntPtr NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormAgent_WormSpace_0;

		// Token: 0x0400111C RID: 4380
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x0400111D RID: 4381
		private static readonly IntPtr NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0;

		// Token: 0x0400111E RID: 4382
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x020006E5 RID: 1765
		[ObfuscatedName("worm.canis.actions.Send+<MakeAnalyticsData>d__2")]
		public sealed class _MakeAnalyticsData_d__2 : Object
		{
			// Token: 0x06005E72 RID: 24178 RVA: 0x001D3EB4 File Offset: 0x001D20B4
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeAnalyticsData_d__2()
			{
				Il2CppClassPointerStore<Send._MakeAnalyticsData_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Send>.NativeClassPtr, "<MakeAnalyticsData>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Send._MakeAnalyticsData_d__2>.NativeClassPtr);
				Send._MakeAnalyticsData_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send._MakeAnalyticsData_d__2>.NativeClassPtr, "<>1__state");
				Send._MakeAnalyticsData_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send._MakeAnalyticsData_d__2>.NativeClassPtr, "<>2__current");
				Send._MakeAnalyticsData_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send._MakeAnalyticsData_d__2>.NativeClassPtr, "<>l__initialThreadId");
				Send._MakeAnalyticsData_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send._MakeAnalyticsData_d__2>.NativeClassPtr, "<>4__this");
				Send._MakeAnalyticsData_d__2.NativeFieldInfoPtr_space = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send._MakeAnalyticsData_d__2>.NativeClassPtr, "space");
				Send._MakeAnalyticsData_d__2.NativeFieldInfoPtr___3__space = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send._MakeAnalyticsData_d__2>.NativeClassPtr, "<>3__space");
				Send._MakeAnalyticsData_d__2.NativeFieldInfoPtr_agent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send._MakeAnalyticsData_d__2>.NativeClassPtr, "agent");
				Send._MakeAnalyticsData_d__2.NativeFieldInfoPtr___3__agent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send._MakeAnalyticsData_d__2>.NativeClassPtr, "<>3__agent");
				Send._MakeAnalyticsData_d__2.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send._MakeAnalyticsData_d__2>.NativeClassPtr, "<player>5__2");
				Send._MakeAnalyticsData_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Send._MakeAnalyticsData_d__2>.NativeClassPtr, 100668835);
				Send._MakeAnalyticsData_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Send._MakeAnalyticsData_d__2>.NativeClassPtr, 100668836);
				Send._MakeAnalyticsData_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Send._MakeAnalyticsData_d__2>.NativeClassPtr, 100668837);
				Send._MakeAnalyticsData_d__2.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Send._MakeAnalyticsData_d__2>.NativeClassPtr, 100668838);
				Send._MakeAnalyticsData_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Send._MakeAnalyticsData_d__2>.NativeClassPtr, 100668839);
				Send._MakeAnalyticsData_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Send._MakeAnalyticsData_d__2>.NativeClassPtr, 100668840);
				Send._MakeAnalyticsData_d__2.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Send._MakeAnalyticsData_d__2>.NativeClassPtr, 100668841);
				Send._MakeAnalyticsData_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Send._MakeAnalyticsData_d__2>.NativeClassPtr, 100668842);
			}

			// Token: 0x06005E73 RID: 24179 RVA: 0x001D4034 File Offset: 0x001D2234
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MakeAnalyticsData_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Send._MakeAnalyticsData_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Send._MakeAnalyticsData_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005E74 RID: 24180 RVA: 0x001D407C File Offset: 0x001D227C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Send._MakeAnalyticsData_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005E75 RID: 24181 RVA: 0x001D40B0 File Offset: 0x001D22B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146989, XrefRangeEnd = 147018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Send._MakeAnalyticsData_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170018CB RID: 6347
			// (get) Token: 0x06005E76 RID: 24182 RVA: 0x001D40EC File Offset: 0x001D22EC
			public unsafe ValueTuple<string, Object> prop_ValueTuple_2_String_Object_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Send._MakeAnalyticsData_d__2.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<string, Object>(intPtr);
				}
			}

			// Token: 0x06005E77 RID: 24183 RVA: 0x001D4124 File Offset: 0x001D2324
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147018, XrefRangeEnd = 147023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Send._MakeAnalyticsData_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170018CC RID: 6348
			// (get) Token: 0x06005E78 RID: 24184 RVA: 0x001D4158 File Offset: 0x001D2358
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147023, XrefRangeEnd = 147026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Send._MakeAnalyticsData_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005E79 RID: 24185 RVA: 0x001D4198 File Offset: 0x001D2398
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147026, XrefRangeEnd = 147036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<string, Object>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Send._MakeAnalyticsData_d__2.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<string, Object>>>(intPtr3) : null;
			}

			// Token: 0x06005E7A RID: 24186 RVA: 0x001D41D8 File Offset: 0x001D23D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Send._MakeAnalyticsData_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005E7B RID: 24187 RVA: 0x000238FF File Offset: 0x00021AFF
			public _MakeAnalyticsData_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170018C2 RID: 6338
			// (get) Token: 0x06005E7C RID: 24188 RVA: 0x001D4218 File Offset: 0x001D2418
			// (set) Token: 0x06005E7D RID: 24189 RVA: 0x00023908 File Offset: 0x00021B08
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._MakeAnalyticsData_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._MakeAnalyticsData_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170018C3 RID: 6339
			// (get) Token: 0x06005E7E RID: 24190 RVA: 0x001D4240 File Offset: 0x001D2440
			// (set) Token: 0x06005E7F RID: 24191 RVA: 0x00023923 File Offset: 0x00021B23
			public ValueTuple<string, Object> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._MakeAnalyticsData_d__2.NativeFieldInfoPtr___2__current);
					return new ValueTuple<string, Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._MakeAnalyticsData_d__2.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170018C4 RID: 6340
			// (get) Token: 0x06005E80 RID: 24192 RVA: 0x001D4270 File Offset: 0x001D2470
			// (set) Token: 0x06005E81 RID: 24193 RVA: 0x00023951 File Offset: 0x00021B51
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._MakeAnalyticsData_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._MakeAnalyticsData_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170018C5 RID: 6341
			// (get) Token: 0x06005E82 RID: 24194 RVA: 0x001D4298 File Offset: 0x001D2498
			// (set) Token: 0x06005E83 RID: 24195 RVA: 0x0002396C File Offset: 0x00021B6C
			public unsafe Send __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._MakeAnalyticsData_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Send>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._MakeAnalyticsData_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018C6 RID: 6342
			// (get) Token: 0x06005E84 RID: 24196 RVA: 0x001D42C8 File Offset: 0x001D24C8
			// (set) Token: 0x06005E85 RID: 24197 RVA: 0x0002398B File Offset: 0x00021B8B
			public unsafe WormSpace space
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._MakeAnalyticsData_d__2.NativeFieldInfoPtr_space);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._MakeAnalyticsData_d__2.NativeFieldInfoPtr_space), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018C7 RID: 6343
			// (get) Token: 0x06005E86 RID: 24198 RVA: 0x001D42F8 File Offset: 0x001D24F8
			// (set) Token: 0x06005E87 RID: 24199 RVA: 0x000239AA File Offset: 0x00021BAA
			public unsafe WormSpace __3__space
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._MakeAnalyticsData_d__2.NativeFieldInfoPtr___3__space);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._MakeAnalyticsData_d__2.NativeFieldInfoPtr___3__space), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018C8 RID: 6344
			// (get) Token: 0x06005E88 RID: 24200 RVA: 0x001D4328 File Offset: 0x001D2528
			// (set) Token: 0x06005E89 RID: 24201 RVA: 0x000239C9 File Offset: 0x00021BC9
			public unsafe WormAgent agent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._MakeAnalyticsData_d__2.NativeFieldInfoPtr_agent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAgent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._MakeAnalyticsData_d__2.NativeFieldInfoPtr_agent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018C9 RID: 6345
			// (get) Token: 0x06005E8A RID: 24202 RVA: 0x001D4358 File Offset: 0x001D2558
			// (set) Token: 0x06005E8B RID: 24203 RVA: 0x000239E8 File Offset: 0x00021BE8
			public unsafe WormAgent __3__agent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._MakeAnalyticsData_d__2.NativeFieldInfoPtr___3__agent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAgent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._MakeAnalyticsData_d__2.NativeFieldInfoPtr___3__agent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018CA RID: 6346
			// (get) Token: 0x06005E8C RID: 24204 RVA: 0x001D4388 File Offset: 0x001D2588
			// (set) Token: 0x06005E8D RID: 24205 RVA: 0x00023A07 File Offset: 0x00021C07
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._MakeAnalyticsData_d__2.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._MakeAnalyticsData_d__2.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003D55 RID: 15701
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003D56 RID: 15702
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003D57 RID: 15703
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003D58 RID: 15704
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003D59 RID: 15705
			private static readonly IntPtr NativeFieldInfoPtr_space;

			// Token: 0x04003D5A RID: 15706
			private static readonly IntPtr NativeFieldInfoPtr___3__space;

			// Token: 0x04003D5B RID: 15707
			private static readonly IntPtr NativeFieldInfoPtr_agent;

			// Token: 0x04003D5C RID: 15708
			private static readonly IntPtr NativeFieldInfoPtr___3__agent;

			// Token: 0x04003D5D RID: 15709
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04003D5E RID: 15710
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003D5F RID: 15711
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003D60 RID: 15712
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003D61 RID: 15713
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0;

			// Token: 0x04003D62 RID: 15714
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003D63 RID: 15715
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003D64 RID: 15716
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0;

			// Token: 0x04003D65 RID: 15717
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020006E6 RID: 1766
		[ObfuscatedName("worm.canis.actions.Send+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x06005E8E RID: 24206 RVA: 0x001D43B8 File Offset: 0x001D25B8
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<Send._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Send>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Send._execute_d__3>.NativeClassPtr);
				Send._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send._execute_d__3>.NativeClassPtr, "<>1__state");
				Send._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send._execute_d__3>.NativeClassPtr, "<>2__current");
				Send._execute_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send._execute_d__3>.NativeClassPtr, "<>l__initialThreadId");
				Send._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send._execute_d__3>.NativeClassPtr, "<>4__this");
				Send._execute_d__3.NativeFieldInfoPtr__agent_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send._execute_d__3>.NativeClassPtr, "<agent>5__2");
				Send._execute_d__3.NativeFieldInfoPtr__space_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send._execute_d__3>.NativeClassPtr, "<space>5__3");
				Send._execute_d__3.NativeFieldInfoPtr__wormMatch_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send._execute_d__3>.NativeClassPtr, "<wormMatch>5__4");
				Send._execute_d__3.NativeFieldInfoPtr__player_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send._execute_d__3>.NativeClassPtr, "<player>5__5");
				Send._execute_d__3.NativeFieldInfoPtr__sequenceName_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send._execute_d__3>.NativeClassPtr, "<sequenceName>5__6");
				Send._execute_d__3.NativeFieldInfoPtr__sequenceHelper_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send._execute_d__3>.NativeClassPtr, "<sequenceHelper>5__7");
				Send._execute_d__3.NativeFieldInfoPtr__origin_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send._execute_d__3>.NativeClassPtr, "<origin>5__8");
				Send._execute_d__3.NativeFieldInfoPtr__controllingPlayer_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send._execute_d__3>.NativeClassPtr, "<controllingPlayer>5__9");
				Send._execute_d__3.NativeFieldInfoPtr__childUndo_5__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send._execute_d__3>.NativeClassPtr, "<childUndo>5__10");
				Send._execute_d__3.NativeFieldInfoPtr__gameLogBuilder_5__11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send._execute_d__3>.NativeClassPtr, "<gameLogBuilder>5__11");
				Send._execute_d__3.NativeFieldInfoPtr___7__wrap11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send._execute_d__3>.NativeClassPtr, "<>7__wrap11");
				Send._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Send._execute_d__3>.NativeClassPtr, 100668843);
				Send._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Send._execute_d__3>.NativeClassPtr, 100668844);
				Send._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Send._execute_d__3>.NativeClassPtr, 100668845);
				Send._execute_d__3.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Send._execute_d__3>.NativeClassPtr, 100668846);
				Send._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Send._execute_d__3>.NativeClassPtr, 100668847);
				Send._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Send._execute_d__3>.NativeClassPtr, 100668848);
				Send._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Send._execute_d__3>.NativeClassPtr, 100668849);
				Send._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Send._execute_d__3>.NativeClassPtr, 100668850);
				Send._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Send._execute_d__3>.NativeClassPtr, 100668851);
			}

			// Token: 0x06005E8F RID: 24207 RVA: 0x001D45C4 File Offset: 0x001D27C4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Send._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Send._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005E90 RID: 24208 RVA: 0x001D460C File Offset: 0x001D280C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147036, XrefRangeEnd = 147041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Send._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005E91 RID: 24209 RVA: 0x001D4640 File Offset: 0x001D2840
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147041, XrefRangeEnd = 147329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Send._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005E92 RID: 24210 RVA: 0x001D467C File Offset: 0x001D287C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 147332, RefRangeEnd = 147333, XrefRangeStart = 147329, XrefRangeEnd = 147332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Send._execute_d__3.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170018DC RID: 6364
			// (get) Token: 0x06005E93 RID: 24211 RVA: 0x001D46B0 File Offset: 0x001D28B0
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Send._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005E94 RID: 24212 RVA: 0x001D46F0 File Offset: 0x001D28F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147333, XrefRangeEnd = 147338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Send._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170018DD RID: 6365
			// (get) Token: 0x06005E95 RID: 24213 RVA: 0x001D4724 File Offset: 0x001D2924
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Send._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005E96 RID: 24214 RVA: 0x001D4764 File Offset: 0x001D2964
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147338, XrefRangeEnd = 147340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Send._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005E97 RID: 24215 RVA: 0x001D47A4 File Offset: 0x001D29A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Send._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005E98 RID: 24216 RVA: 0x00023A26 File Offset: 0x00021C26
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170018CD RID: 6349
			// (get) Token: 0x06005E99 RID: 24217 RVA: 0x001D47E4 File Offset: 0x001D29E4
			// (set) Token: 0x06005E9A RID: 24218 RVA: 0x00023A2F File Offset: 0x00021C2F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170018CE RID: 6350
			// (get) Token: 0x06005E9B RID: 24219 RVA: 0x001D480C File Offset: 0x001D2A0C
			// (set) Token: 0x06005E9C RID: 24220 RVA: 0x00023A4A File Offset: 0x00021C4A
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018CF RID: 6351
			// (get) Token: 0x06005E9D RID: 24221 RVA: 0x001D483C File Offset: 0x001D2A3C
			// (set) Token: 0x06005E9E RID: 24222 RVA: 0x00023A69 File Offset: 0x00021C69
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._execute_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._execute_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170018D0 RID: 6352
			// (get) Token: 0x06005E9F RID: 24223 RVA: 0x001D4864 File Offset: 0x001D2A64
			// (set) Token: 0x06005EA0 RID: 24224 RVA: 0x00023A84 File Offset: 0x00021C84
			public unsafe Send __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Send>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018D1 RID: 6353
			// (get) Token: 0x06005EA1 RID: 24225 RVA: 0x001D4894 File Offset: 0x001D2A94
			// (set) Token: 0x06005EA2 RID: 24226 RVA: 0x00023AA3 File Offset: 0x00021CA3
			public unsafe WormAgent _agent_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._execute_d__3.NativeFieldInfoPtr__agent_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAgent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._execute_d__3.NativeFieldInfoPtr__agent_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018D2 RID: 6354
			// (get) Token: 0x06005EA3 RID: 24227 RVA: 0x001D48C4 File Offset: 0x001D2AC4
			// (set) Token: 0x06005EA4 RID: 24228 RVA: 0x00023AC2 File Offset: 0x00021CC2
			public unsafe WormSpace _space_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._execute_d__3.NativeFieldInfoPtr__space_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._execute_d__3.NativeFieldInfoPtr__space_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018D3 RID: 6355
			// (get) Token: 0x06005EA5 RID: 24229 RVA: 0x001D48F4 File Offset: 0x001D2AF4
			// (set) Token: 0x06005EA6 RID: 24230 RVA: 0x00023AE1 File Offset: 0x00021CE1
			public unsafe WormMatch _wormMatch_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._execute_d__3.NativeFieldInfoPtr__wormMatch_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._execute_d__3.NativeFieldInfoPtr__wormMatch_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018D4 RID: 6356
			// (get) Token: 0x06005EA7 RID: 24231 RVA: 0x001D4924 File Offset: 0x001D2B24
			// (set) Token: 0x06005EA8 RID: 24232 RVA: 0x00023B00 File Offset: 0x00021D00
			public unsafe WormPlayer _player_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._execute_d__3.NativeFieldInfoPtr__player_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._execute_d__3.NativeFieldInfoPtr__player_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018D5 RID: 6357
			// (get) Token: 0x06005EA9 RID: 24233 RVA: 0x001D4954 File Offset: 0x001D2B54
			// (set) Token: 0x06005EAA RID: 24234 RVA: 0x00023B1F File Offset: 0x00021D1F
			public unsafe string _sequenceName_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._execute_d__3.NativeFieldInfoPtr__sequenceName_5__6);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._execute_d__3.NativeFieldInfoPtr__sequenceName_5__6), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170018D6 RID: 6358
			// (get) Token: 0x06005EAB RID: 24235 RVA: 0x001D497C File Offset: 0x001D2B7C
			// (set) Token: 0x06005EAC RID: 24236 RVA: 0x00023B3E File Offset: 0x00021D3E
			public unsafe SequenceHelper _sequenceHelper_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._execute_d__3.NativeFieldInfoPtr__sequenceHelper_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._execute_d__3.NativeFieldInfoPtr__sequenceHelper_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018D7 RID: 6359
			// (get) Token: 0x06005EAD RID: 24237 RVA: 0x001D49AC File Offset: 0x001D2BAC
			// (set) Token: 0x06005EAE RID: 24238 RVA: 0x00023B5D File Offset: 0x00021D5D
			public unsafe Entity _origin_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._execute_d__3.NativeFieldInfoPtr__origin_5__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._execute_d__3.NativeFieldInfoPtr__origin_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018D8 RID: 6360
			// (get) Token: 0x06005EAF RID: 24239 RVA: 0x001D49DC File Offset: 0x001D2BDC
			// (set) Token: 0x06005EB0 RID: 24240 RVA: 0x00023B7C File Offset: 0x00021D7C
			public unsafe WormPlayer _controllingPlayer_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._execute_d__3.NativeFieldInfoPtr__controllingPlayer_5__9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._execute_d__3.NativeFieldInfoPtr__controllingPlayer_5__9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018D9 RID: 6361
			// (get) Token: 0x06005EB1 RID: 24241 RVA: 0x001D4A0C File Offset: 0x001D2C0C
			// (set) Token: 0x06005EB2 RID: 24242 RVA: 0x00023B9B File Offset: 0x00021D9B
			public unsafe UndoNode _childUndo_5__10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._execute_d__3.NativeFieldInfoPtr__childUndo_5__10);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._execute_d__3.NativeFieldInfoPtr__childUndo_5__10), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018DA RID: 6362
			// (get) Token: 0x06005EB3 RID: 24243 RVA: 0x001D4A3C File Offset: 0x001D2C3C
			// (set) Token: 0x06005EB4 RID: 24244 RVA: 0x00023BBA File Offset: 0x00021DBA
			public unsafe GameLogBuilder _gameLogBuilder_5__11
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._execute_d__3.NativeFieldInfoPtr__gameLogBuilder_5__11);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._execute_d__3.NativeFieldInfoPtr__gameLogBuilder_5__11), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018DB RID: 6363
			// (get) Token: 0x06005EB5 RID: 24245 RVA: 0x001D4A6C File Offset: 0x001D2C6C
			// (set) Token: 0x06005EB6 RID: 24246 RVA: 0x00023BD9 File Offset: 0x00021DD9
			public Dictionary<AttributeDefinition<Nullable<int>>, AttributeDefinition<Nullable<int>>>.Enumerator __7__wrap11
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._execute_d__3.NativeFieldInfoPtr___7__wrap11);
					return new Dictionary<AttributeDefinition<Nullable<int>>, AttributeDefinition<Nullable<int>>>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dictionary<AttributeDefinition<Nullable<int>>, AttributeDefinition<Nullable<int>>>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._execute_d__3.NativeFieldInfoPtr___7__wrap11), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Dictionary<AttributeDefinition<Nullable<int>>, AttributeDefinition<Nullable<int>>>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04003D66 RID: 15718
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003D67 RID: 15719
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003D68 RID: 15720
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003D69 RID: 15721
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003D6A RID: 15722
			private static readonly IntPtr NativeFieldInfoPtr__agent_5__2;

			// Token: 0x04003D6B RID: 15723
			private static readonly IntPtr NativeFieldInfoPtr__space_5__3;

			// Token: 0x04003D6C RID: 15724
			private static readonly IntPtr NativeFieldInfoPtr__wormMatch_5__4;

			// Token: 0x04003D6D RID: 15725
			private static readonly IntPtr NativeFieldInfoPtr__player_5__5;

			// Token: 0x04003D6E RID: 15726
			private static readonly IntPtr NativeFieldInfoPtr__sequenceName_5__6;

			// Token: 0x04003D6F RID: 15727
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__7;

			// Token: 0x04003D70 RID: 15728
			private static readonly IntPtr NativeFieldInfoPtr__origin_5__8;

			// Token: 0x04003D71 RID: 15729
			private static readonly IntPtr NativeFieldInfoPtr__controllingPlayer_5__9;

			// Token: 0x04003D72 RID: 15730
			private static readonly IntPtr NativeFieldInfoPtr__childUndo_5__10;

			// Token: 0x04003D73 RID: 15731
			private static readonly IntPtr NativeFieldInfoPtr__gameLogBuilder_5__11;

			// Token: 0x04003D74 RID: 15732
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap11;

			// Token: 0x04003D75 RID: 15733
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003D76 RID: 15734
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003D77 RID: 15735
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003D78 RID: 15736
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003D79 RID: 15737
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003D7A RID: 15738
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003D7B RID: 15739
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003D7C RID: 15740
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003D7D RID: 15741
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020006E7 RID: 1767
		[ObfuscatedName("worm.canis.actions.Send+<undo>d__4")]
		public sealed class _undo_d__4 : Object
		{
			// Token: 0x06005EB7 RID: 24247 RVA: 0x001D4A9C File Offset: 0x001D2C9C
			// Note: this type is marked as 'beforefieldinit'.
			static _undo_d__4()
			{
				Il2CppClassPointerStore<Send._undo_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Send>.NativeClassPtr, "<undo>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Send._undo_d__4>.NativeClassPtr);
				Send._undo_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send._undo_d__4>.NativeClassPtr, "<>1__state");
				Send._undo_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send._undo_d__4>.NativeClassPtr, "<>2__current");
				Send._undo_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send._undo_d__4>.NativeClassPtr, "<>l__initialThreadId");
				Send._undo_d__4.NativeFieldInfoPtr_undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send._undo_d__4>.NativeClassPtr, "undoContext");
				Send._undo_d__4.NativeFieldInfoPtr___3__undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send._undo_d__4>.NativeClassPtr, "<>3__undoContext");
				Send._undo_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send._undo_d__4>.NativeClassPtr, "<>4__this");
				Send._undo_d__4.NativeFieldInfoPtr__origin_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send._undo_d__4>.NativeClassPtr, "<origin>5__2");
				Send._undo_d__4.NativeFieldInfoPtr__agent_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send._undo_d__4>.NativeClassPtr, "<agent>5__3");
				Send._undo_d__4.NativeFieldInfoPtr__sequenceHelper_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send._undo_d__4>.NativeClassPtr, "<sequenceHelper>5__4");
				Send._undo_d__4.NativeFieldInfoPtr__wormPlayer_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Send._undo_d__4>.NativeClassPtr, "<wormPlayer>5__5");
				Send._undo_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Send._undo_d__4>.NativeClassPtr, 100668852);
				Send._undo_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Send._undo_d__4>.NativeClassPtr, 100668853);
				Send._undo_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Send._undo_d__4>.NativeClassPtr, 100668854);
				Send._undo_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Send._undo_d__4>.NativeClassPtr, 100668855);
				Send._undo_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Send._undo_d__4>.NativeClassPtr, 100668856);
				Send._undo_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Send._undo_d__4>.NativeClassPtr, 100668857);
				Send._undo_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Send._undo_d__4>.NativeClassPtr, 100668858);
				Send._undo_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Send._undo_d__4>.NativeClassPtr, 100668859);
			}

			// Token: 0x06005EB8 RID: 24248 RVA: 0x001D4C30 File Offset: 0x001D2E30
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _undo_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Send._undo_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Send._undo_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005EB9 RID: 24249 RVA: 0x001D4C78 File Offset: 0x001D2E78
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Send._undo_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005EBA RID: 24250 RVA: 0x001D4CAC File Offset: 0x001D2EAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147340, XrefRangeEnd = 147474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Send._undo_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170018E8 RID: 6376
			// (get) Token: 0x06005EBB RID: 24251 RVA: 0x001D4CE8 File Offset: 0x001D2EE8
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Send._undo_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005EBC RID: 24252 RVA: 0x001D4D28 File Offset: 0x001D2F28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147474, XrefRangeEnd = 147479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Send._undo_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170018E9 RID: 6377
			// (get) Token: 0x06005EBD RID: 24253 RVA: 0x001D4D5C File Offset: 0x001D2F5C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Send._undo_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005EBE RID: 24254 RVA: 0x001D4D9C File Offset: 0x001D2F9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147479, XrefRangeEnd = 147488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Send._undo_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005EBF RID: 24255 RVA: 0x001D4DDC File Offset: 0x001D2FDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Send._undo_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005EC0 RID: 24256 RVA: 0x00023C07 File Offset: 0x00021E07
			public _undo_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170018DE RID: 6366
			// (get) Token: 0x06005EC1 RID: 24257 RVA: 0x001D4E1C File Offset: 0x001D301C
			// (set) Token: 0x06005EC2 RID: 24258 RVA: 0x00023C10 File Offset: 0x00021E10
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._undo_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._undo_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170018DF RID: 6367
			// (get) Token: 0x06005EC3 RID: 24259 RVA: 0x001D4E44 File Offset: 0x001D3044
			// (set) Token: 0x06005EC4 RID: 24260 RVA: 0x00023C2B File Offset: 0x00021E2B
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._undo_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._undo_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018E0 RID: 6368
			// (get) Token: 0x06005EC5 RID: 24261 RVA: 0x001D4E74 File Offset: 0x001D3074
			// (set) Token: 0x06005EC6 RID: 24262 RVA: 0x00023C4A File Offset: 0x00021E4A
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._undo_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._undo_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170018E1 RID: 6369
			// (get) Token: 0x06005EC7 RID: 24263 RVA: 0x001D4E9C File Offset: 0x001D309C
			// (set) Token: 0x06005EC8 RID: 24264 RVA: 0x00023C65 File Offset: 0x00021E65
			public unsafe Context undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._undo_d__4.NativeFieldInfoPtr_undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._undo_d__4.NativeFieldInfoPtr_undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018E2 RID: 6370
			// (get) Token: 0x06005EC9 RID: 24265 RVA: 0x001D4ECC File Offset: 0x001D30CC
			// (set) Token: 0x06005ECA RID: 24266 RVA: 0x00023C84 File Offset: 0x00021E84
			public unsafe Context __3__undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._undo_d__4.NativeFieldInfoPtr___3__undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._undo_d__4.NativeFieldInfoPtr___3__undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018E3 RID: 6371
			// (get) Token: 0x06005ECB RID: 24267 RVA: 0x001D4EFC File Offset: 0x001D30FC
			// (set) Token: 0x06005ECC RID: 24268 RVA: 0x00023CA3 File Offset: 0x00021EA3
			public unsafe Send __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._undo_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Send>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._undo_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018E4 RID: 6372
			// (get) Token: 0x06005ECD RID: 24269 RVA: 0x001D4F2C File Offset: 0x001D312C
			// (set) Token: 0x06005ECE RID: 24270 RVA: 0x00023CC2 File Offset: 0x00021EC2
			public unsafe Entity _origin_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._undo_d__4.NativeFieldInfoPtr__origin_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._undo_d__4.NativeFieldInfoPtr__origin_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018E5 RID: 6373
			// (get) Token: 0x06005ECF RID: 24271 RVA: 0x001D4F5C File Offset: 0x001D315C
			// (set) Token: 0x06005ED0 RID: 24272 RVA: 0x00023CE1 File Offset: 0x00021EE1
			public unsafe WormAgent _agent_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._undo_d__4.NativeFieldInfoPtr__agent_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAgent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._undo_d__4.NativeFieldInfoPtr__agent_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018E6 RID: 6374
			// (get) Token: 0x06005ED1 RID: 24273 RVA: 0x001D4F8C File Offset: 0x001D318C
			// (set) Token: 0x06005ED2 RID: 24274 RVA: 0x00023D00 File Offset: 0x00021F00
			public unsafe SequenceHelper _sequenceHelper_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._undo_d__4.NativeFieldInfoPtr__sequenceHelper_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._undo_d__4.NativeFieldInfoPtr__sequenceHelper_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018E7 RID: 6375
			// (get) Token: 0x06005ED3 RID: 24275 RVA: 0x001D4FBC File Offset: 0x001D31BC
			// (set) Token: 0x06005ED4 RID: 24276 RVA: 0x00023D1F File Offset: 0x00021F1F
			public unsafe WormPlayer _wormPlayer_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._undo_d__4.NativeFieldInfoPtr__wormPlayer_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Send._undo_d__4.NativeFieldInfoPtr__wormPlayer_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003D7E RID: 15742
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003D7F RID: 15743
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003D80 RID: 15744
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003D81 RID: 15745
			private static readonly IntPtr NativeFieldInfoPtr_undoContext;

			// Token: 0x04003D82 RID: 15746
			private static readonly IntPtr NativeFieldInfoPtr___3__undoContext;

			// Token: 0x04003D83 RID: 15747
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003D84 RID: 15748
			private static readonly IntPtr NativeFieldInfoPtr__origin_5__2;

			// Token: 0x04003D85 RID: 15749
			private static readonly IntPtr NativeFieldInfoPtr__agent_5__3;

			// Token: 0x04003D86 RID: 15750
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__4;

			// Token: 0x04003D87 RID: 15751
			private static readonly IntPtr NativeFieldInfoPtr__wormPlayer_5__5;

			// Token: 0x04003D88 RID: 15752
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003D89 RID: 15753
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003D8A RID: 15754
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003D8B RID: 15755
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003D8C RID: 15756
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003D8D RID: 15757
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003D8E RID: 15758
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003D8F RID: 15759
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

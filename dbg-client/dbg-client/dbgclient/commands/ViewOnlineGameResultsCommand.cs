using System;
using boardgames.ui.commands;
using Canis;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dbgclient.commands
{
	// Token: 0x020000DA RID: 218
	public class ViewOnlineGameResultsCommand : FailableCommand
	{
		// Token: 0x0600093E RID: 2366 RVA: 0x0003AB00 File Offset: 0x00038D00
		// Note: this type is marked as 'beforefieldinit'.
		static ViewOnlineGameResultsCommand()
		{
			Il2CppClassPointerStore<ViewOnlineGameResultsCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.commands", "ViewOnlineGameResultsCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ViewOnlineGameResultsCommand>.NativeClassPtr);
			ViewOnlineGameResultsCommand.NativeFieldInfoPtr_soloScenarioName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewOnlineGameResultsCommand>.NativeClassPtr, "soloScenarioName");
			ViewOnlineGameResultsCommand.NativeFieldInfoPtr_gameResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewOnlineGameResultsCommand>.NativeClassPtr, "gameResults");
			ViewOnlineGameResultsCommand.NativeMethodInfoPtr__ctor_Public_Void_DBGGameResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewOnlineGameResultsCommand>.NativeClassPtr, 100664632);
			ViewOnlineGameResultsCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewOnlineGameResultsCommand>.NativeClassPtr, 100664633);
			ViewOnlineGameResultsCommand.NativeMethodInfoPtr_ConfigurePlayerMatchInitData_Protected_Virtual_New_Void_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewOnlineGameResultsCommand>.NativeClassPtr, 100664634);
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x0003AB94 File Offset: 0x00038D94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 505468, RefRangeEnd = 505470, XrefRangeStart = 505462, XrefRangeEnd = 505468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ViewOnlineGameResultsCommand(DBGGameResults gameResults)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ViewOnlineGameResultsCommand>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameResults);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewOnlineGameResultsCommand.NativeMethodInfoPtr__ctor_Public_Void_DBGGameResults_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x0003ABE0 File Offset: 0x00038DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505470, XrefRangeEnd = 505475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViewOnlineGameResultsCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x0003AC2C File Offset: 0x00038E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505475, XrefRangeEnd = 505526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ConfigurePlayerMatchInitData(MatchInitData matchInitData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchInitData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViewOnlineGameResultsCommand.NativeMethodInfoPtr_ConfigurePlayerMatchInitData_Protected_Virtual_New_Void_MatchInitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x000065B8 File Offset: 0x000047B8
		public ViewOnlineGameResultsCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x0003AC7C File Offset: 0x00038E7C
		// (set) Token: 0x06000944 RID: 2372 RVA: 0x000065C1 File Offset: 0x000047C1
		public unsafe string soloScenarioName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewOnlineGameResultsCommand.NativeFieldInfoPtr_soloScenarioName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewOnlineGameResultsCommand.NativeFieldInfoPtr_soloScenarioName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x0003ACA4 File Offset: 0x00038EA4
		// (set) Token: 0x06000946 RID: 2374 RVA: 0x000065E0 File Offset: 0x000047E0
		public unsafe DBGGameResults gameResults
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewOnlineGameResultsCommand.NativeFieldInfoPtr_gameResults);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGGameResults>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewOnlineGameResultsCommand.NativeFieldInfoPtr_gameResults), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeFieldInfoPtr_soloScenarioName;

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeFieldInfoPtr_gameResults;

		// Token: 0x040005A1 RID: 1441
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DBGGameResults_0;

		// Token: 0x040005A2 RID: 1442
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040005A3 RID: 1443
		private static readonly IntPtr NativeMethodInfoPtr_ConfigurePlayerMatchInitData_Protected_Virtual_New_Void_MatchInitData_0;

		// Token: 0x0200032A RID: 810
		[ObfuscatedName("dbgclient.commands.ViewOnlineGameResultsCommand+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x0600262F RID: 9775 RVA: 0x0009ABC8 File Offset: 0x00098DC8
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<ViewOnlineGameResultsCommand._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ViewOnlineGameResultsCommand>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ViewOnlineGameResultsCommand._execute_d__3>.NativeClassPtr);
				ViewOnlineGameResultsCommand._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewOnlineGameResultsCommand._execute_d__3>.NativeClassPtr, "<>1__state");
				ViewOnlineGameResultsCommand._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewOnlineGameResultsCommand._execute_d__3>.NativeClassPtr, "<>2__current");
				ViewOnlineGameResultsCommand._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewOnlineGameResultsCommand._execute_d__3>.NativeClassPtr, "<>4__this");
				ViewOnlineGameResultsCommand._execute_d__3.NativeFieldInfoPtr__matchInitData_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewOnlineGameResultsCommand._execute_d__3>.NativeClassPtr, "<matchInitData>5__2");
				ViewOnlineGameResultsCommand._execute_d__3.NativeFieldInfoPtr__getResults_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewOnlineGameResultsCommand._execute_d__3>.NativeClassPtr, "<getResults>5__3");
				ViewOnlineGameResultsCommand._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewOnlineGameResultsCommand._execute_d__3>.NativeClassPtr, 100664635);
				ViewOnlineGameResultsCommand._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewOnlineGameResultsCommand._execute_d__3>.NativeClassPtr, 100664636);
				ViewOnlineGameResultsCommand._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewOnlineGameResultsCommand._execute_d__3>.NativeClassPtr, 100664637);
				ViewOnlineGameResultsCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewOnlineGameResultsCommand._execute_d__3>.NativeClassPtr, 100664638);
				ViewOnlineGameResultsCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewOnlineGameResultsCommand._execute_d__3>.NativeClassPtr, 100664639);
				ViewOnlineGameResultsCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewOnlineGameResultsCommand._execute_d__3>.NativeClassPtr, 100664640);
			}

			// Token: 0x06002630 RID: 9776 RVA: 0x0009ACD0 File Offset: 0x00098ED0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ViewOnlineGameResultsCommand._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewOnlineGameResultsCommand._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002631 RID: 9777 RVA: 0x0009AD18 File Offset: 0x00098F18
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewOnlineGameResultsCommand._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002632 RID: 9778 RVA: 0x0009AD4C File Offset: 0x00098F4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505423, XrefRangeEnd = 505457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewOnlineGameResultsCommand._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A8F RID: 2703
			// (get) Token: 0x06002633 RID: 9779 RVA: 0x0009AD88 File Offset: 0x00098F88
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewOnlineGameResultsCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002634 RID: 9780 RVA: 0x0009ADC8 File Offset: 0x00098FC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505457, XrefRangeEnd = 505462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewOnlineGameResultsCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A90 RID: 2704
			// (get) Token: 0x06002635 RID: 9781 RVA: 0x0009ADFC File Offset: 0x00098FFC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewOnlineGameResultsCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002636 RID: 9782 RVA: 0x00013CAF File Offset: 0x00011EAF
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A8A RID: 2698
			// (get) Token: 0x06002637 RID: 9783 RVA: 0x0009AE3C File Offset: 0x0009903C
			// (set) Token: 0x06002638 RID: 9784 RVA: 0x00013CB8 File Offset: 0x00011EB8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewOnlineGameResultsCommand._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewOnlineGameResultsCommand._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A8B RID: 2699
			// (get) Token: 0x06002639 RID: 9785 RVA: 0x0009AE64 File Offset: 0x00099064
			// (set) Token: 0x0600263A RID: 9786 RVA: 0x00013CD3 File Offset: 0x00011ED3
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewOnlineGameResultsCommand._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewOnlineGameResultsCommand._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A8C RID: 2700
			// (get) Token: 0x0600263B RID: 9787 RVA: 0x0009AE94 File Offset: 0x00099094
			// (set) Token: 0x0600263C RID: 9788 RVA: 0x00013CF2 File Offset: 0x00011EF2
			public unsafe ViewOnlineGameResultsCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewOnlineGameResultsCommand._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ViewOnlineGameResultsCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewOnlineGameResultsCommand._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A8D RID: 2701
			// (get) Token: 0x0600263D RID: 9789 RVA: 0x0009AEC4 File Offset: 0x000990C4
			// (set) Token: 0x0600263E RID: 9790 RVA: 0x00013D11 File Offset: 0x00011F11
			public unsafe MatchInitData _matchInitData_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewOnlineGameResultsCommand._execute_d__3.NativeFieldInfoPtr__matchInitData_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewOnlineGameResultsCommand._execute_d__3.NativeFieldInfoPtr__matchInitData_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A8E RID: 2702
			// (get) Token: 0x0600263F RID: 9791 RVA: 0x0009AEF4 File Offset: 0x000990F4
			// (set) Token: 0x06002640 RID: 9792 RVA: 0x00013D30 File Offset: 0x00011F30
			public unsafe IGetGameResultsDataCommand _getResults_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewOnlineGameResultsCommand._execute_d__3.NativeFieldInfoPtr__getResults_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGetGameResultsDataCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewOnlineGameResultsCommand._execute_d__3.NativeFieldInfoPtr__getResults_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017F0 RID: 6128
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040017F1 RID: 6129
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040017F2 RID: 6130
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040017F3 RID: 6131
			private static readonly IntPtr NativeFieldInfoPtr__matchInitData_5__2;

			// Token: 0x040017F4 RID: 6132
			private static readonly IntPtr NativeFieldInfoPtr__getResults_5__3;

			// Token: 0x040017F5 RID: 6133
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040017F6 RID: 6134
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017F7 RID: 6135
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040017F8 RID: 6136
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040017F9 RID: 6137
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017FA RID: 6138
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

using System;
using boardgames.notifications;
using dwd.core.commands;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.menus.commands
{
	// Token: 0x02000229 RID: 553
	public class RunGameCompleteNotificationFlow : Command
	{
		// Token: 0x06001937 RID: 6455 RVA: 0x0006F800 File Offset: 0x0006DA00
		// Note: this type is marked as 'beforefieldinit'.
		static RunGameCompleteNotificationFlow()
		{
			Il2CppClassPointerStore<RunGameCompleteNotificationFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "RunGameCompleteNotificationFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunGameCompleteNotificationFlow>.NativeClassPtr);
			RunGameCompleteNotificationFlow.NativeFieldInfoPtr_gameCompleteTitleLoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunGameCompleteNotificationFlow>.NativeClassPtr, "gameCompleteTitleLoc");
			RunGameCompleteNotificationFlow.NativeFieldInfoPtr_gameCompleteLoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunGameCompleteNotificationFlow>.NativeClassPtr, "gameCompleteLoc");
			RunGameCompleteNotificationFlow.NativeFieldInfoPtr_results = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunGameCompleteNotificationFlow>.NativeClassPtr, "results");
			RunGameCompleteNotificationFlow.NativeFieldInfoPtr_notifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunGameCompleteNotificationFlow>.NativeClassPtr, "notifications");
			RunGameCompleteNotificationFlow.NativeMethodInfoPtr__ctor_Public_Void_DBGGameResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunGameCompleteNotificationFlow>.NativeClassPtr, 100667171);
			RunGameCompleteNotificationFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunGameCompleteNotificationFlow>.NativeClassPtr, 100667172);
			RunGameCompleteNotificationFlow.NativeMethodInfoPtr_ShowGameResults_Protected_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunGameCompleteNotificationFlow>.NativeClassPtr, 100667173);
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x0006F8BC File Offset: 0x0006DABC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 528934, RefRangeEnd = 528935, XrefRangeStart = 528920, XrefRangeEnd = 528934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunGameCompleteNotificationFlow(DBGGameResults results)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunGameCompleteNotificationFlow>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(results);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunGameCompleteNotificationFlow.NativeMethodInfoPtr__ctor_Public_Void_DBGGameResults_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x0006F908 File Offset: 0x0006DB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528935, XrefRangeEnd = 528940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunGameCompleteNotificationFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x0006F954 File Offset: 0x0006DB54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528940, XrefRangeEnd = 528961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator ShowGameResults()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunGameCompleteNotificationFlow.NativeMethodInfoPtr_ShowGameResults_Protected_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x0000DE3A File Offset: 0x0000C03A
		public RunGameCompleteNotificationFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x0600193C RID: 6460 RVA: 0x0006F9A0 File Offset: 0x0006DBA0
		// (set) Token: 0x0600193D RID: 6461 RVA: 0x0000DE43 File Offset: 0x0000C043
		public unsafe string gameCompleteTitleLoc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunGameCompleteNotificationFlow.NativeFieldInfoPtr_gameCompleteTitleLoc);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunGameCompleteNotificationFlow.NativeFieldInfoPtr_gameCompleteTitleLoc), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x0600193E RID: 6462 RVA: 0x0006F9C8 File Offset: 0x0006DBC8
		// (set) Token: 0x0600193F RID: 6463 RVA: 0x0000DE62 File Offset: 0x0000C062
		public unsafe string gameCompleteLoc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunGameCompleteNotificationFlow.NativeFieldInfoPtr_gameCompleteLoc);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunGameCompleteNotificationFlow.NativeFieldInfoPtr_gameCompleteLoc), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06001940 RID: 6464 RVA: 0x0006F9F0 File Offset: 0x0006DBF0
		// (set) Token: 0x06001941 RID: 6465 RVA: 0x0000DE81 File Offset: 0x0000C081
		public unsafe DBGGameResults results
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunGameCompleteNotificationFlow.NativeFieldInfoPtr_results);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGGameResults>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunGameCompleteNotificationFlow.NativeFieldInfoPtr_results), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06001942 RID: 6466 RVA: 0x0006FA20 File Offset: 0x0006DC20
		// (set) Token: 0x06001943 RID: 6467 RVA: 0x0000DEA0 File Offset: 0x0000C0A0
		public unsafe DBGNotifications notifications
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunGameCompleteNotificationFlow.NativeFieldInfoPtr_notifications);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGNotifications>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunGameCompleteNotificationFlow.NativeFieldInfoPtr_notifications), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FBF RID: 4031
		private static readonly IntPtr NativeFieldInfoPtr_gameCompleteTitleLoc;

		// Token: 0x04000FC0 RID: 4032
		private static readonly IntPtr NativeFieldInfoPtr_gameCompleteLoc;

		// Token: 0x04000FC1 RID: 4033
		private static readonly IntPtr NativeFieldInfoPtr_results;

		// Token: 0x04000FC2 RID: 4034
		private static readonly IntPtr NativeFieldInfoPtr_notifications;

		// Token: 0x04000FC3 RID: 4035
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DBGGameResults_0;

		// Token: 0x04000FC4 RID: 4036
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000FC5 RID: 4037
		private static readonly IntPtr NativeMethodInfoPtr_ShowGameResults_Protected_Virtual_New_IEnumerator_0;

		// Token: 0x0200040A RID: 1034
		[ObfuscatedName("boardgames.menus.commands.RunGameCompleteNotificationFlow+<execute>d__5")]
		public sealed class _execute_d__5 : Object
		{
			// Token: 0x060030AF RID: 12463 RVA: 0x000B9CC0 File Offset: 0x000B7EC0
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__5()
			{
				Il2CppClassPointerStore<RunGameCompleteNotificationFlow._execute_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunGameCompleteNotificationFlow>.NativeClassPtr, "<execute>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunGameCompleteNotificationFlow._execute_d__5>.NativeClassPtr);
				RunGameCompleteNotificationFlow._execute_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunGameCompleteNotificationFlow._execute_d__5>.NativeClassPtr, "<>1__state");
				RunGameCompleteNotificationFlow._execute_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunGameCompleteNotificationFlow._execute_d__5>.NativeClassPtr, "<>2__current");
				RunGameCompleteNotificationFlow._execute_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunGameCompleteNotificationFlow._execute_d__5>.NativeClassPtr, "<>4__this");
				RunGameCompleteNotificationFlow._execute_d__5.NativeFieldInfoPtr__confirmOrDeny_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunGameCompleteNotificationFlow._execute_d__5>.NativeClassPtr, "<confirmOrDeny>5__2");
				RunGameCompleteNotificationFlow._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunGameCompleteNotificationFlow._execute_d__5>.NativeClassPtr, 100667174);
				RunGameCompleteNotificationFlow._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunGameCompleteNotificationFlow._execute_d__5>.NativeClassPtr, 100667175);
				RunGameCompleteNotificationFlow._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunGameCompleteNotificationFlow._execute_d__5>.NativeClassPtr, 100667176);
				RunGameCompleteNotificationFlow._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunGameCompleteNotificationFlow._execute_d__5>.NativeClassPtr, 100667177);
				RunGameCompleteNotificationFlow._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunGameCompleteNotificationFlow._execute_d__5>.NativeClassPtr, 100667178);
				RunGameCompleteNotificationFlow._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunGameCompleteNotificationFlow._execute_d__5>.NativeClassPtr, 100667179);
			}

			// Token: 0x060030B0 RID: 12464 RVA: 0x000B9DB4 File Offset: 0x000B7FB4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunGameCompleteNotificationFlow._execute_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunGameCompleteNotificationFlow._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060030B1 RID: 12465 RVA: 0x000B9DFC File Offset: 0x000B7FFC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunGameCompleteNotificationFlow._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060030B2 RID: 12466 RVA: 0x000B9E30 File Offset: 0x000B8030
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528848, XrefRangeEnd = 528915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunGameCompleteNotificationFlow._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000E14 RID: 3604
			// (get) Token: 0x060030B3 RID: 12467 RVA: 0x000B9E6C File Offset: 0x000B806C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunGameCompleteNotificationFlow._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060030B4 RID: 12468 RVA: 0x000B9EAC File Offset: 0x000B80AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528915, XrefRangeEnd = 528920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunGameCompleteNotificationFlow._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000E15 RID: 3605
			// (get) Token: 0x060030B5 RID: 12469 RVA: 0x000B9EE0 File Offset: 0x000B80E0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunGameCompleteNotificationFlow._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060030B6 RID: 12470 RVA: 0x000192C6 File Offset: 0x000174C6
			public _execute_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E10 RID: 3600
			// (get) Token: 0x060030B7 RID: 12471 RVA: 0x000B9F20 File Offset: 0x000B8120
			// (set) Token: 0x060030B8 RID: 12472 RVA: 0x000192CF File Offset: 0x000174CF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunGameCompleteNotificationFlow._execute_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunGameCompleteNotificationFlow._execute_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000E11 RID: 3601
			// (get) Token: 0x060030B9 RID: 12473 RVA: 0x000B9F48 File Offset: 0x000B8148
			// (set) Token: 0x060030BA RID: 12474 RVA: 0x000192EA File Offset: 0x000174EA
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunGameCompleteNotificationFlow._execute_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunGameCompleteNotificationFlow._execute_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E12 RID: 3602
			// (get) Token: 0x060030BB RID: 12475 RVA: 0x000B9F78 File Offset: 0x000B8178
			// (set) Token: 0x060030BC RID: 12476 RVA: 0x00019309 File Offset: 0x00017509
			public unsafe RunGameCompleteNotificationFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunGameCompleteNotificationFlow._execute_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunGameCompleteNotificationFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunGameCompleteNotificationFlow._execute_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E13 RID: 3603
			// (get) Token: 0x060030BD RID: 12477 RVA: 0x000B9FA8 File Offset: 0x000B81A8
			// (set) Token: 0x060030BE RID: 12478 RVA: 0x00019328 File Offset: 0x00017528
			public unsafe ConfirmOrDenyPrompt _confirmOrDeny_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunGameCompleteNotificationFlow._execute_d__5.NativeFieldInfoPtr__confirmOrDeny_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOrDenyPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunGameCompleteNotificationFlow._execute_d__5.NativeFieldInfoPtr__confirmOrDeny_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001E19 RID: 7705
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001E1A RID: 7706
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001E1B RID: 7707
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001E1C RID: 7708
			private static readonly IntPtr NativeFieldInfoPtr__confirmOrDeny_5__2;

			// Token: 0x04001E1D RID: 7709
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001E1E RID: 7710
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001E1F RID: 7711
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001E20 RID: 7712
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001E21 RID: 7713
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001E22 RID: 7714
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

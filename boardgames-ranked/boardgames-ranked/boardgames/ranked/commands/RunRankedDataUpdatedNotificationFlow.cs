using System;
using boardgames.ranked.networking.notifications;
using dwd.core.commands;
using dwd.core.ui.prompt.prompters;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.ranked.commands
{
	// Token: 0x02000038 RID: 56
	public class RunRankedDataUpdatedNotificationFlow : Command
	{
		// Token: 0x060001E5 RID: 485 RVA: 0x00008D50 File Offset: 0x00006F50
		// Note: this type is marked as 'beforefieldinit'.
		static RunRankedDataUpdatedNotificationFlow()
		{
			Il2CppClassPointerStore<RunRankedDataUpdatedNotificationFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.commands", "RunRankedDataUpdatedNotificationFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunRankedDataUpdatedNotificationFlow>.NativeClassPtr);
			RunRankedDataUpdatedNotificationFlow.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRankedDataUpdatedNotificationFlow>.NativeClassPtr, "message");
			RunRankedDataUpdatedNotificationFlow.NativeMethodInfoPtr__ctor_Public_Void_RankedDataUpdated_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedDataUpdatedNotificationFlow>.NativeClassPtr, 100663490);
			RunRankedDataUpdatedNotificationFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedDataUpdatedNotificationFlow>.NativeClassPtr, 100663491);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00008DBC File Offset: 0x00006FBC
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 495009, RefRangeEnd = 495046, XrefRangeStart = 495009, XrefRangeEnd = 495046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunRankedDataUpdatedNotificationFlow(RankedDataUpdated message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunRankedDataUpdatedNotificationFlow>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRankedDataUpdatedNotificationFlow.NativeMethodInfoPtr__ctor_Public_Void_RankedDataUpdated_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00008E08 File Offset: 0x00007008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226142, XrefRangeEnd = 1226147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunRankedDataUpdatedNotificationFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00003102 File Offset: 0x00001302
		public RunRankedDataUpdatedNotificationFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x00008E54 File Offset: 0x00007054
		// (set) Token: 0x060001EA RID: 490 RVA: 0x0000310B File Offset: 0x0000130B
		public unsafe RankedDataUpdated message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedDataUpdatedNotificationFlow.NativeFieldInfoPtr_message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RankedDataUpdated>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedDataUpdatedNotificationFlow.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RankedDataUpdated_0;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000048 RID: 72
		[ObfuscatedName("boardgames.ranked.commands.RunRankedDataUpdatedNotificationFlow+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x06000288 RID: 648 RVA: 0x0000A91C File Offset: 0x00008B1C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<RunRankedDataUpdatedNotificationFlow._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunRankedDataUpdatedNotificationFlow>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunRankedDataUpdatedNotificationFlow._execute_d__2>.NativeClassPtr);
				RunRankedDataUpdatedNotificationFlow._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRankedDataUpdatedNotificationFlow._execute_d__2>.NativeClassPtr, "<>1__state");
				RunRankedDataUpdatedNotificationFlow._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRankedDataUpdatedNotificationFlow._execute_d__2>.NativeClassPtr, "<>2__current");
				RunRankedDataUpdatedNotificationFlow._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRankedDataUpdatedNotificationFlow._execute_d__2>.NativeClassPtr, "<>4__this");
				RunRankedDataUpdatedNotificationFlow._execute_d__2.NativeFieldInfoPtr__modalScopes_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRankedDataUpdatedNotificationFlow._execute_d__2>.NativeClassPtr, "<modalScopes>5__2");
				RunRankedDataUpdatedNotificationFlow._execute_d__2.NativeFieldInfoPtr__curtainPrompter_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRankedDataUpdatedNotificationFlow._execute_d__2>.NativeClassPtr, "<curtainPrompter>5__3");
				RunRankedDataUpdatedNotificationFlow._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedDataUpdatedNotificationFlow._execute_d__2>.NativeClassPtr, 100663492);
				RunRankedDataUpdatedNotificationFlow._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedDataUpdatedNotificationFlow._execute_d__2>.NativeClassPtr, 100663493);
				RunRankedDataUpdatedNotificationFlow._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedDataUpdatedNotificationFlow._execute_d__2>.NativeClassPtr, 100663494);
				RunRankedDataUpdatedNotificationFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedDataUpdatedNotificationFlow._execute_d__2>.NativeClassPtr, 100663495);
				RunRankedDataUpdatedNotificationFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedDataUpdatedNotificationFlow._execute_d__2>.NativeClassPtr, 100663496);
				RunRankedDataUpdatedNotificationFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedDataUpdatedNotificationFlow._execute_d__2>.NativeClassPtr, 100663497);
			}

			// Token: 0x06000289 RID: 649 RVA: 0x0000AA24 File Offset: 0x00008C24
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunRankedDataUpdatedNotificationFlow._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRankedDataUpdatedNotificationFlow._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600028A RID: 650 RVA: 0x0000AA6C File Offset: 0x00008C6C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRankedDataUpdatedNotificationFlow._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600028B RID: 651 RVA: 0x0000AAA0 File Offset: 0x00008CA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226100, XrefRangeEnd = 1226137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRankedDataUpdatedNotificationFlow._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000BD RID: 189
			// (get) Token: 0x0600028C RID: 652 RVA: 0x0000AADC File Offset: 0x00008CDC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRankedDataUpdatedNotificationFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600028D RID: 653 RVA: 0x0000AB1C File Offset: 0x00008D1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226137, XrefRangeEnd = 1226142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRankedDataUpdatedNotificationFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000BE RID: 190
			// (get) Token: 0x0600028E RID: 654 RVA: 0x0000AB50 File Offset: 0x00008D50
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRankedDataUpdatedNotificationFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600028F RID: 655 RVA: 0x0000363C File Offset: 0x0000183C
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000B8 RID: 184
			// (get) Token: 0x06000290 RID: 656 RVA: 0x0000AB90 File Offset: 0x00008D90
			// (set) Token: 0x06000291 RID: 657 RVA: 0x00003645 File Offset: 0x00001845
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedDataUpdatedNotificationFlow._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedDataUpdatedNotificationFlow._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000B9 RID: 185
			// (get) Token: 0x06000292 RID: 658 RVA: 0x0000ABB8 File Offset: 0x00008DB8
			// (set) Token: 0x06000293 RID: 659 RVA: 0x00003660 File Offset: 0x00001860
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedDataUpdatedNotificationFlow._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedDataUpdatedNotificationFlow._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000BA RID: 186
			// (get) Token: 0x06000294 RID: 660 RVA: 0x0000ABE8 File Offset: 0x00008DE8
			// (set) Token: 0x06000295 RID: 661 RVA: 0x0000367F File Offset: 0x0000187F
			public unsafe RunRankedDataUpdatedNotificationFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedDataUpdatedNotificationFlow._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunRankedDataUpdatedNotificationFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedDataUpdatedNotificationFlow._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000BB RID: 187
			// (get) Token: 0x06000296 RID: 662 RVA: 0x0000AC18 File Offset: 0x00008E18
			// (set) Token: 0x06000297 RID: 663 RVA: 0x0000369E File Offset: 0x0000189E
			public unsafe ModalScopes _modalScopes_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedDataUpdatedNotificationFlow._execute_d__2.NativeFieldInfoPtr__modalScopes_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModalScopes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedDataUpdatedNotificationFlow._execute_d__2.NativeFieldInfoPtr__modalScopes_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000BC RID: 188
			// (get) Token: 0x06000298 RID: 664 RVA: 0x0000AC48 File Offset: 0x00008E48
			// (set) Token: 0x06000299 RID: 665 RVA: 0x000036BD File Offset: 0x000018BD
			public unsafe IModalPrompter _curtainPrompter_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedDataUpdatedNotificationFlow._execute_d__2.NativeFieldInfoPtr__curtainPrompter_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IModalPrompter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedDataUpdatedNotificationFlow._execute_d__2.NativeFieldInfoPtr__curtainPrompter_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000164 RID: 356
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000165 RID: 357
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000166 RID: 358
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000167 RID: 359
			private static readonly IntPtr NativeFieldInfoPtr__modalScopes_5__2;

			// Token: 0x04000168 RID: 360
			private static readonly IntPtr NativeFieldInfoPtr__curtainPrompter_5__3;

			// Token: 0x04000169 RID: 361
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400016A RID: 362
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400016B RID: 363
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400016C RID: 364
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400016D RID: 365
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400016E RID: 366
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

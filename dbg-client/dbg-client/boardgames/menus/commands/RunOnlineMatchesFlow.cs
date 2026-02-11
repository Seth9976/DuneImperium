using System;
using boardgames.account;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.menus.commands
{
	// Token: 0x0200022F RID: 559
	public class RunOnlineMatchesFlow : FailableCommand
	{
		// Token: 0x0600196E RID: 6510 RVA: 0x00070408 File Offset: 0x0006E608
		// Note: this type is marked as 'beforefieldinit'.
		static RunOnlineMatchesFlow()
		{
			Il2CppClassPointerStore<RunOnlineMatchesFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "RunOnlineMatchesFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunOnlineMatchesFlow>.NativeClassPtr);
			RunOnlineMatchesFlow.NativeFieldInfoPtr_showNoCrossplayWarning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunOnlineMatchesFlow>.NativeClassPtr, "showNoCrossplayWarning");
			RunOnlineMatchesFlow.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunOnlineMatchesFlow>.NativeClassPtr, 100667236);
			RunOnlineMatchesFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunOnlineMatchesFlow>.NativeClassPtr, 100667237);
			RunOnlineMatchesFlow.NativeMethodInfoPtr_Run_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunOnlineMatchesFlow>.NativeClassPtr, 100667238);
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x00070488 File Offset: 0x0006E688
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 529476, RefRangeEnd = 529480, XrefRangeStart = 529475, XrefRangeEnd = 529476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunOnlineMatchesFlow(bool showNoCrossplayWarning = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunOnlineMatchesFlow>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref showNoCrossplayWarning;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunOnlineMatchesFlow.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x000704D0 File Offset: 0x0006E6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529480, XrefRangeEnd = 529485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunOnlineMatchesFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x0007051C File Offset: 0x0006E71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529485, XrefRangeEnd = 529490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Run()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunOnlineMatchesFlow.NativeMethodInfoPtr_Run_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x0000DF83 File Offset: 0x0000C183
		public RunOnlineMatchesFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06001973 RID: 6515 RVA: 0x0007055C File Offset: 0x0006E75C
		// (set) Token: 0x06001974 RID: 6516 RVA: 0x0000DF8C File Offset: 0x0000C18C
		public unsafe bool showNoCrossplayWarning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunOnlineMatchesFlow.NativeFieldInfoPtr_showNoCrossplayWarning);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunOnlineMatchesFlow.NativeFieldInfoPtr_showNoCrossplayWarning)) = value;
			}
		}

		// Token: 0x04000FE1 RID: 4065
		private static readonly IntPtr NativeFieldInfoPtr_showNoCrossplayWarning;

		// Token: 0x04000FE2 RID: 4066
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000FE3 RID: 4067
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000FE4 RID: 4068
		private static readonly IntPtr NativeMethodInfoPtr_Run_Private_IEnumerator_0;

		// Token: 0x02000411 RID: 1041
		[ObfuscatedName("boardgames.menus.commands.RunOnlineMatchesFlow+<Run>d__3")]
		public sealed class _Run_d__3 : Object
		{
			// Token: 0x0600311E RID: 12574 RVA: 0x000BB1C0 File Offset: 0x000B93C0
			// Note: this type is marked as 'beforefieldinit'.
			static _Run_d__3()
			{
				Il2CppClassPointerStore<RunOnlineMatchesFlow._Run_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunOnlineMatchesFlow>.NativeClassPtr, "<Run>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunOnlineMatchesFlow._Run_d__3>.NativeClassPtr);
				RunOnlineMatchesFlow._Run_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunOnlineMatchesFlow._Run_d__3>.NativeClassPtr, "<>1__state");
				RunOnlineMatchesFlow._Run_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunOnlineMatchesFlow._Run_d__3>.NativeClassPtr, "<>2__current");
				RunOnlineMatchesFlow._Run_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunOnlineMatchesFlow._Run_d__3>.NativeClassPtr, "<>4__this");
				RunOnlineMatchesFlow._Run_d__3.NativeFieldInfoPtr__login_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunOnlineMatchesFlow._Run_d__3>.NativeClassPtr, "<login>5__2");
				RunOnlineMatchesFlow._Run_d__3.NativeFieldInfoPtr__canCrossplay_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunOnlineMatchesFlow._Run_d__3>.NativeClassPtr, "<canCrossplay>5__3");
				RunOnlineMatchesFlow._Run_d__3.NativeFieldInfoPtr__lobbySessionProvider_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunOnlineMatchesFlow._Run_d__3>.NativeClassPtr, "<lobbySessionProvider>5__4");
				RunOnlineMatchesFlow._Run_d__3.NativeFieldInfoPtr__check_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunOnlineMatchesFlow._Run_d__3>.NativeClassPtr, "<check>5__5");
				RunOnlineMatchesFlow._Run_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunOnlineMatchesFlow._Run_d__3>.NativeClassPtr, 100667239);
				RunOnlineMatchesFlow._Run_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunOnlineMatchesFlow._Run_d__3>.NativeClassPtr, 100667240);
				RunOnlineMatchesFlow._Run_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunOnlineMatchesFlow._Run_d__3>.NativeClassPtr, 100667241);
				RunOnlineMatchesFlow._Run_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunOnlineMatchesFlow._Run_d__3>.NativeClassPtr, 100667242);
				RunOnlineMatchesFlow._Run_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunOnlineMatchesFlow._Run_d__3>.NativeClassPtr, 100667243);
				RunOnlineMatchesFlow._Run_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunOnlineMatchesFlow._Run_d__3>.NativeClassPtr, 100667244);
			}

			// Token: 0x0600311F RID: 12575 RVA: 0x000BB2F0 File Offset: 0x000B94F0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Run_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunOnlineMatchesFlow._Run_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunOnlineMatchesFlow._Run_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003120 RID: 12576 RVA: 0x000BB338 File Offset: 0x000B9538
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunOnlineMatchesFlow._Run_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003121 RID: 12577 RVA: 0x000BB36C File Offset: 0x000B956C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529393, XrefRangeEnd = 529454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunOnlineMatchesFlow._Run_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000E40 RID: 3648
			// (get) Token: 0x06003122 RID: 12578 RVA: 0x000BB3A8 File Offset: 0x000B95A8
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunOnlineMatchesFlow._Run_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003123 RID: 12579 RVA: 0x000BB3E8 File Offset: 0x000B95E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529454, XrefRangeEnd = 529459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunOnlineMatchesFlow._Run_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000E41 RID: 3649
			// (get) Token: 0x06003124 RID: 12580 RVA: 0x000BB41C File Offset: 0x000B961C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunOnlineMatchesFlow._Run_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003125 RID: 12581 RVA: 0x00019645 File Offset: 0x00017845
			public _Run_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E39 RID: 3641
			// (get) Token: 0x06003126 RID: 12582 RVA: 0x000BB45C File Offset: 0x000B965C
			// (set) Token: 0x06003127 RID: 12583 RVA: 0x0001964E File Offset: 0x0001784E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunOnlineMatchesFlow._Run_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunOnlineMatchesFlow._Run_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000E3A RID: 3642
			// (get) Token: 0x06003128 RID: 12584 RVA: 0x000BB484 File Offset: 0x000B9684
			// (set) Token: 0x06003129 RID: 12585 RVA: 0x00019669 File Offset: 0x00017869
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunOnlineMatchesFlow._Run_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunOnlineMatchesFlow._Run_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E3B RID: 3643
			// (get) Token: 0x0600312A RID: 12586 RVA: 0x000BB4B4 File Offset: 0x000B96B4
			// (set) Token: 0x0600312B RID: 12587 RVA: 0x00019688 File Offset: 0x00017888
			public unsafe RunOnlineMatchesFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunOnlineMatchesFlow._Run_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunOnlineMatchesFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunOnlineMatchesFlow._Run_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E3C RID: 3644
			// (get) Token: 0x0600312C RID: 12588 RVA: 0x000BB4E4 File Offset: 0x000B96E4
			// (set) Token: 0x0600312D RID: 12589 RVA: 0x000196A7 File Offset: 0x000178A7
			public unsafe LoginIfNeeded _login_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunOnlineMatchesFlow._Run_d__3.NativeFieldInfoPtr__login_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoginIfNeeded>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunOnlineMatchesFlow._Run_d__3.NativeFieldInfoPtr__login_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E3D RID: 3645
			// (get) Token: 0x0600312E RID: 12590 RVA: 0x000BB514 File Offset: 0x000B9714
			// (set) Token: 0x0600312F RID: 12591 RVA: 0x000196C6 File Offset: 0x000178C6
			public unsafe bool _canCrossplay_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunOnlineMatchesFlow._Run_d__3.NativeFieldInfoPtr__canCrossplay_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunOnlineMatchesFlow._Run_d__3.NativeFieldInfoPtr__canCrossplay_5__3)) = value;
				}
			}

			// Token: 0x17000E3E RID: 3646
			// (get) Token: 0x06003130 RID: 12592 RVA: 0x000BB53C File Offset: 0x000B973C
			// (set) Token: 0x06003131 RID: 12593 RVA: 0x000196E1 File Offset: 0x000178E1
			public unsafe LobbySessionProvider _lobbySessionProvider_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunOnlineMatchesFlow._Run_d__3.NativeFieldInfoPtr__lobbySessionProvider_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbySessionProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunOnlineMatchesFlow._Run_d__3.NativeFieldInfoPtr__lobbySessionProvider_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E3F RID: 3647
			// (get) Token: 0x06003132 RID: 12594 RVA: 0x000BB56C File Offset: 0x000B976C
			// (set) Token: 0x06003133 RID: 12595 RVA: 0x00019700 File Offset: 0x00017900
			public unsafe ICheckPrivilegesCommand _check_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunOnlineMatchesFlow._Run_d__3.NativeFieldInfoPtr__check_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICheckPrivilegesCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunOnlineMatchesFlow._Run_d__3.NativeFieldInfoPtr__check_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001E5D RID: 7773
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001E5E RID: 7774
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001E5F RID: 7775
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001E60 RID: 7776
			private static readonly IntPtr NativeFieldInfoPtr__login_5__2;

			// Token: 0x04001E61 RID: 7777
			private static readonly IntPtr NativeFieldInfoPtr__canCrossplay_5__3;

			// Token: 0x04001E62 RID: 7778
			private static readonly IntPtr NativeFieldInfoPtr__lobbySessionProvider_5__4;

			// Token: 0x04001E63 RID: 7779
			private static readonly IntPtr NativeFieldInfoPtr__check_5__5;

			// Token: 0x04001E64 RID: 7780
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001E65 RID: 7781
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001E66 RID: 7782
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001E67 RID: 7783
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001E68 RID: 7784
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001E69 RID: 7785
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000412 RID: 1042
		[ObfuscatedName("boardgames.menus.commands.RunOnlineMatchesFlow+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x06003134 RID: 12596 RVA: 0x000BB59C File Offset: 0x000B979C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<RunOnlineMatchesFlow._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunOnlineMatchesFlow>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunOnlineMatchesFlow._execute_d__2>.NativeClassPtr);
				RunOnlineMatchesFlow._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunOnlineMatchesFlow._execute_d__2>.NativeClassPtr, "<>1__state");
				RunOnlineMatchesFlow._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunOnlineMatchesFlow._execute_d__2>.NativeClassPtr, "<>2__current");
				RunOnlineMatchesFlow._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunOnlineMatchesFlow._execute_d__2>.NativeClassPtr, "<>4__this");
				RunOnlineMatchesFlow._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunOnlineMatchesFlow._execute_d__2>.NativeClassPtr, 100667245);
				RunOnlineMatchesFlow._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunOnlineMatchesFlow._execute_d__2>.NativeClassPtr, 100667246);
				RunOnlineMatchesFlow._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunOnlineMatchesFlow._execute_d__2>.NativeClassPtr, 100667247);
				RunOnlineMatchesFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunOnlineMatchesFlow._execute_d__2>.NativeClassPtr, 100667248);
				RunOnlineMatchesFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunOnlineMatchesFlow._execute_d__2>.NativeClassPtr, 100667249);
				RunOnlineMatchesFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunOnlineMatchesFlow._execute_d__2>.NativeClassPtr, 100667250);
			}

			// Token: 0x06003135 RID: 12597 RVA: 0x000BB67C File Offset: 0x000B987C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunOnlineMatchesFlow._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunOnlineMatchesFlow._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003136 RID: 12598 RVA: 0x000BB6C4 File Offset: 0x000B98C4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunOnlineMatchesFlow._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003137 RID: 12599 RVA: 0x000BB6F8 File Offset: 0x000B98F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529459, XrefRangeEnd = 529470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunOnlineMatchesFlow._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000E45 RID: 3653
			// (get) Token: 0x06003138 RID: 12600 RVA: 0x000BB734 File Offset: 0x000B9934
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunOnlineMatchesFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003139 RID: 12601 RVA: 0x000BB774 File Offset: 0x000B9974
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529470, XrefRangeEnd = 529475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunOnlineMatchesFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000E46 RID: 3654
			// (get) Token: 0x0600313A RID: 12602 RVA: 0x000BB7A8 File Offset: 0x000B99A8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunOnlineMatchesFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600313B RID: 12603 RVA: 0x0001971F File Offset: 0x0001791F
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E42 RID: 3650
			// (get) Token: 0x0600313C RID: 12604 RVA: 0x000BB7E8 File Offset: 0x000B99E8
			// (set) Token: 0x0600313D RID: 12605 RVA: 0x00019728 File Offset: 0x00017928
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunOnlineMatchesFlow._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunOnlineMatchesFlow._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000E43 RID: 3651
			// (get) Token: 0x0600313E RID: 12606 RVA: 0x000BB810 File Offset: 0x000B9A10
			// (set) Token: 0x0600313F RID: 12607 RVA: 0x00019743 File Offset: 0x00017943
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunOnlineMatchesFlow._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunOnlineMatchesFlow._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E44 RID: 3652
			// (get) Token: 0x06003140 RID: 12608 RVA: 0x000BB840 File Offset: 0x000B9A40
			// (set) Token: 0x06003141 RID: 12609 RVA: 0x00019762 File Offset: 0x00017962
			public unsafe RunOnlineMatchesFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunOnlineMatchesFlow._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunOnlineMatchesFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunOnlineMatchesFlow._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001E6A RID: 7786
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001E6B RID: 7787
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001E6C RID: 7788
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001E6D RID: 7789
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001E6E RID: 7790
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001E6F RID: 7791
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001E70 RID: 7792
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001E71 RID: 7793
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001E72 RID: 7794
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

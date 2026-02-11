using System;
using boardgames.behaviours;
using boardgames.menus.prompts;
using dwd.core.commands;
using dwd.core.data.composition;
using dwd.core.platform.providers;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.menus.commands
{
	// Token: 0x02000228 RID: 552
	public class RunFriendsListFlow : Command
	{
		// Token: 0x0600192C RID: 6444 RVA: 0x0006F5F4 File Offset: 0x0006D7F4
		// Note: this type is marked as 'beforefieldinit'.
		static RunFriendsListFlow()
		{
			Il2CppClassPointerStore<RunFriendsListFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "RunFriendsListFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunFriendsListFlow>.NativeClassPtr);
			RunFriendsListFlow.NativeFieldInfoPtr_shouldRestoreScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunFriendsListFlow>.NativeClassPtr, "shouldRestoreScroll");
			RunFriendsListFlow.NativeFieldInfoPtr_scope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunFriendsListFlow>.NativeClassPtr, "scope");
			RunFriendsListFlow.NativeFieldInfoPtr_friendsListPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunFriendsListFlow>.NativeClassPtr, "friendsListPrompt");
			RunFriendsListFlow.NativeMethodInfoPtr__ctor_Public_Void_Boolean_ModalScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFriendsListFlow>.NativeClassPtr, 100667160);
			RunFriendsListFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFriendsListFlow>.NativeClassPtr, 100667161);
			RunFriendsListFlow.NativeMethodInfoPtr_Dismiss_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFriendsListFlow>.NativeClassPtr, 100667162);
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x0006F69C File Offset: 0x0006D89C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 528839, RefRangeEnd = 528842, XrefRangeStart = 528837, XrefRangeEnd = 528839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunFriendsListFlow(bool shouldRestoreScroll = false, ModalScope scope = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunFriendsListFlow>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shouldRestoreScroll;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scope);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunFriendsListFlow.NativeMethodInfoPtr__ctor_Public_Void_Boolean_ModalScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600192E RID: 6446 RVA: 0x0006F6F8 File Offset: 0x0006D8F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528842, XrefRangeEnd = 528847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunFriendsListFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x0006F744 File Offset: 0x0006D944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528847, XrefRangeEnd = 528848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunFriendsListFlow.NativeMethodInfoPtr_Dismiss_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x0000DDD8 File Offset: 0x0000BFD8
		public RunFriendsListFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06001931 RID: 6449 RVA: 0x0006F778 File Offset: 0x0006D978
		// (set) Token: 0x06001932 RID: 6450 RVA: 0x0000DDE1 File Offset: 0x0000BFE1
		public unsafe bool shouldRestoreScroll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendsListFlow.NativeFieldInfoPtr_shouldRestoreScroll);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendsListFlow.NativeFieldInfoPtr_shouldRestoreScroll)) = value;
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06001933 RID: 6451 RVA: 0x0006F7A0 File Offset: 0x0006D9A0
		// (set) Token: 0x06001934 RID: 6452 RVA: 0x0000DDFC File Offset: 0x0000BFFC
		public unsafe ModalScope scope
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendsListFlow.NativeFieldInfoPtr_scope);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModalScope>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendsListFlow.NativeFieldInfoPtr_scope), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06001935 RID: 6453 RVA: 0x0006F7D0 File Offset: 0x0006D9D0
		// (set) Token: 0x06001936 RID: 6454 RVA: 0x0000DE1B File Offset: 0x0000C01B
		public unsafe FriendsListPrompt friendsListPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendsListFlow.NativeFieldInfoPtr_friendsListPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FriendsListPrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendsListFlow.NativeFieldInfoPtr_friendsListPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FB9 RID: 4025
		private static readonly IntPtr NativeFieldInfoPtr_shouldRestoreScroll;

		// Token: 0x04000FBA RID: 4026
		private static readonly IntPtr NativeFieldInfoPtr_scope;

		// Token: 0x04000FBB RID: 4027
		private static readonly IntPtr NativeFieldInfoPtr_friendsListPrompt;

		// Token: 0x04000FBC RID: 4028
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_ModalScope_0;

		// Token: 0x04000FBD RID: 4029
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000FBE RID: 4030
		private static readonly IntPtr NativeMethodInfoPtr_Dismiss_Public_Void_0;

		// Token: 0x02000408 RID: 1032
		[ObfuscatedName("boardgames.menus.commands.RunFriendsListFlow+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x0600308F RID: 12431 RVA: 0x000B9744 File Offset: 0x000B7944
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<RunFriendsListFlow.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunFriendsListFlow>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunFriendsListFlow.__c__DisplayClass4_0>.NativeClassPtr);
				RunFriendsListFlow.__c__DisplayClass4_0.NativeFieldInfoPtr_platformProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunFriendsListFlow.__c__DisplayClass4_0>.NativeClassPtr, "platformProvider");
				RunFriendsListFlow.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFriendsListFlow.__c__DisplayClass4_0>.NativeClassPtr, 100667163);
				RunFriendsListFlow.__c__DisplayClass4_0.NativeMethodInfoPtr__execute_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFriendsListFlow.__c__DisplayClass4_0>.NativeClassPtr, 100667164);
			}

			// Token: 0x06003090 RID: 12432 RVA: 0x000B97AC File Offset: 0x000B79AC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunFriendsListFlow.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunFriendsListFlow.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003091 RID: 12433 RVA: 0x000B97E8 File Offset: 0x000B79E8
			[CallerCount(0)]
			public unsafe bool _execute_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunFriendsListFlow.__c__DisplayClass4_0.NativeMethodInfoPtr__execute_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003092 RID: 12434 RVA: 0x00019182 File Offset: 0x00017382
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E04 RID: 3588
			// (get) Token: 0x06003093 RID: 12435 RVA: 0x000B9824 File Offset: 0x000B7A24
			// (set) Token: 0x06003094 RID: 12436 RVA: 0x0001918B File Offset: 0x0001738B
			public unsafe PlatformProvider platformProvider
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendsListFlow.__c__DisplayClass4_0.NativeFieldInfoPtr_platformProvider);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendsListFlow.__c__DisplayClass4_0.NativeFieldInfoPtr_platformProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001E07 RID: 7687
			private static readonly IntPtr NativeFieldInfoPtr_platformProvider;

			// Token: 0x04001E08 RID: 7688
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001E09 RID: 7689
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__0_Internal_Boolean_0;
		}

		// Token: 0x02000409 RID: 1033
		[ObfuscatedName("boardgames.menus.commands.RunFriendsListFlow+<execute>d__4")]
		public sealed class _execute_d__4 : Object
		{
			// Token: 0x06003095 RID: 12437 RVA: 0x000B9854 File Offset: 0x000B7A54
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__4()
			{
				Il2CppClassPointerStore<RunFriendsListFlow._execute_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunFriendsListFlow>.NativeClassPtr, "<execute>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunFriendsListFlow._execute_d__4>.NativeClassPtr);
				RunFriendsListFlow._execute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunFriendsListFlow._execute_d__4>.NativeClassPtr, "<>1__state");
				RunFriendsListFlow._execute_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunFriendsListFlow._execute_d__4>.NativeClassPtr, "<>2__current");
				RunFriendsListFlow._execute_d__4.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunFriendsListFlow._execute_d__4>.NativeClassPtr, "<>8__1");
				RunFriendsListFlow._execute_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunFriendsListFlow._execute_d__4>.NativeClassPtr, "<>4__this");
				RunFriendsListFlow._execute_d__4.NativeFieldInfoPtr__login_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunFriendsListFlow._execute_d__4>.NativeClassPtr, "<login>5__2");
				RunFriendsListFlow._execute_d__4.NativeFieldInfoPtr__button_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunFriendsListFlow._execute_d__4>.NativeClassPtr, "<button>5__3");
				RunFriendsListFlow._execute_d__4.NativeFieldInfoPtr__modalScopes_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunFriendsListFlow._execute_d__4>.NativeClassPtr, "<modalScopes>5__4");
				RunFriendsListFlow._execute_d__4.NativeFieldInfoPtr__selectedData_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunFriendsListFlow._execute_d__4>.NativeClassPtr, "<selectedData>5__5");
				RunFriendsListFlow._execute_d__4.NativeFieldInfoPtr__confirmOrDeny_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunFriendsListFlow._execute_d__4>.NativeClassPtr, "<confirmOrDeny>5__6");
				RunFriendsListFlow._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFriendsListFlow._execute_d__4>.NativeClassPtr, 100667165);
				RunFriendsListFlow._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFriendsListFlow._execute_d__4>.NativeClassPtr, 100667166);
				RunFriendsListFlow._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFriendsListFlow._execute_d__4>.NativeClassPtr, 100667167);
				RunFriendsListFlow._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFriendsListFlow._execute_d__4>.NativeClassPtr, 100667168);
				RunFriendsListFlow._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFriendsListFlow._execute_d__4>.NativeClassPtr, 100667169);
				RunFriendsListFlow._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFriendsListFlow._execute_d__4>.NativeClassPtr, 100667170);
			}

			// Token: 0x06003096 RID: 12438 RVA: 0x000B99AC File Offset: 0x000B7BAC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunFriendsListFlow._execute_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunFriendsListFlow._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003097 RID: 12439 RVA: 0x000B99F4 File Offset: 0x000B7BF4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunFriendsListFlow._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003098 RID: 12440 RVA: 0x000B9A28 File Offset: 0x000B7C28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528714, XrefRangeEnd = 528832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunFriendsListFlow._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000E0E RID: 3598
			// (get) Token: 0x06003099 RID: 12441 RVA: 0x000B9A64 File Offset: 0x000B7C64
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunFriendsListFlow._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600309A RID: 12442 RVA: 0x000B9AA4 File Offset: 0x000B7CA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528832, XrefRangeEnd = 528837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunFriendsListFlow._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000E0F RID: 3599
			// (get) Token: 0x0600309B RID: 12443 RVA: 0x000B9AD8 File Offset: 0x000B7CD8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunFriendsListFlow._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600309C RID: 12444 RVA: 0x000191AA File Offset: 0x000173AA
			public _execute_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E05 RID: 3589
			// (get) Token: 0x0600309D RID: 12445 RVA: 0x000B9B18 File Offset: 0x000B7D18
			// (set) Token: 0x0600309E RID: 12446 RVA: 0x000191B3 File Offset: 0x000173B3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendsListFlow._execute_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendsListFlow._execute_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000E06 RID: 3590
			// (get) Token: 0x0600309F RID: 12447 RVA: 0x000B9B40 File Offset: 0x000B7D40
			// (set) Token: 0x060030A0 RID: 12448 RVA: 0x000191CE File Offset: 0x000173CE
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendsListFlow._execute_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendsListFlow._execute_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E07 RID: 3591
			// (get) Token: 0x060030A1 RID: 12449 RVA: 0x000B9B70 File Offset: 0x000B7D70
			// (set) Token: 0x060030A2 RID: 12450 RVA: 0x000191ED File Offset: 0x000173ED
			public unsafe RunFriendsListFlow.__c__DisplayClass4_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendsListFlow._execute_d__4.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunFriendsListFlow.__c__DisplayClass4_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendsListFlow._execute_d__4.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E08 RID: 3592
			// (get) Token: 0x060030A3 RID: 12451 RVA: 0x000B9BA0 File Offset: 0x000B7DA0
			// (set) Token: 0x060030A4 RID: 12452 RVA: 0x0001920C File Offset: 0x0001740C
			public unsafe RunFriendsListFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendsListFlow._execute_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunFriendsListFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendsListFlow._execute_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E09 RID: 3593
			// (get) Token: 0x060030A5 RID: 12453 RVA: 0x000B9BD0 File Offset: 0x000B7DD0
			// (set) Token: 0x060030A6 RID: 12454 RVA: 0x0001922B File Offset: 0x0001742B
			public unsafe LoginIfNeeded _login_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendsListFlow._execute_d__4.NativeFieldInfoPtr__login_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoginIfNeeded>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendsListFlow._execute_d__4.NativeFieldInfoPtr__login_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E0A RID: 3594
			// (get) Token: 0x060030A7 RID: 12455 RVA: 0x000B9C00 File Offset: 0x000B7E00
			// (set) Token: 0x060030A8 RID: 12456 RVA: 0x0001924A File Offset: 0x0001744A
			public unsafe FriendsListButtonBehaviour _button_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendsListFlow._execute_d__4.NativeFieldInfoPtr__button_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FriendsListButtonBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendsListFlow._execute_d__4.NativeFieldInfoPtr__button_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E0B RID: 3595
			// (get) Token: 0x060030A9 RID: 12457 RVA: 0x000B9C30 File Offset: 0x000B7E30
			// (set) Token: 0x060030AA RID: 12458 RVA: 0x00019269 File Offset: 0x00017469
			public unsafe ModalScopes _modalScopes_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendsListFlow._execute_d__4.NativeFieldInfoPtr__modalScopes_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModalScopes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendsListFlow._execute_d__4.NativeFieldInfoPtr__modalScopes_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E0C RID: 3596
			// (get) Token: 0x060030AB RID: 12459 RVA: 0x000B9C60 File Offset: 0x000B7E60
			// (set) Token: 0x060030AC RID: 12460 RVA: 0x00019288 File Offset: 0x00017488
			public unsafe DataComposition _selectedData_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendsListFlow._execute_d__4.NativeFieldInfoPtr__selectedData_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendsListFlow._execute_d__4.NativeFieldInfoPtr__selectedData_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E0D RID: 3597
			// (get) Token: 0x060030AD RID: 12461 RVA: 0x000B9C90 File Offset: 0x000B7E90
			// (set) Token: 0x060030AE RID: 12462 RVA: 0x000192A7 File Offset: 0x000174A7
			public unsafe ConfirmOrDenyPrompt _confirmOrDeny_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendsListFlow._execute_d__4.NativeFieldInfoPtr__confirmOrDeny_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOrDenyPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendsListFlow._execute_d__4.NativeFieldInfoPtr__confirmOrDeny_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001E0A RID: 7690
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001E0B RID: 7691
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001E0C RID: 7692
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04001E0D RID: 7693
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001E0E RID: 7694
			private static readonly IntPtr NativeFieldInfoPtr__login_5__2;

			// Token: 0x04001E0F RID: 7695
			private static readonly IntPtr NativeFieldInfoPtr__button_5__3;

			// Token: 0x04001E10 RID: 7696
			private static readonly IntPtr NativeFieldInfoPtr__modalScopes_5__4;

			// Token: 0x04001E11 RID: 7697
			private static readonly IntPtr NativeFieldInfoPtr__selectedData_5__5;

			// Token: 0x04001E12 RID: 7698
			private static readonly IntPtr NativeFieldInfoPtr__confirmOrDeny_5__6;

			// Token: 0x04001E13 RID: 7699
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001E14 RID: 7700
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001E15 RID: 7701
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001E16 RID: 7702
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001E17 RID: 7703
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001E18 RID: 7704
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

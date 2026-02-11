using System;
using boardgames.menus.prompts;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using zen.src.menus.commands;

namespace boardgames.menus.commands
{
	// Token: 0x0200021E RID: 542
	public class RunChangePasswordFlow : Command
	{
		// Token: 0x060018BC RID: 6332 RVA: 0x0006DD78 File Offset: 0x0006BF78
		// Note: this type is marked as 'beforefieldinit'.
		static RunChangePasswordFlow()
		{
			Il2CppClassPointerStore<RunChangePasswordFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "RunChangePasswordFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunChangePasswordFlow>.NativeClassPtr);
			RunChangePasswordFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunChangePasswordFlow>.NativeClassPtr, 100667028);
			RunChangePasswordFlow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunChangePasswordFlow>.NativeClassPtr, 100667029);
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x0006DDD0 File Offset: 0x0006BFD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527771, XrefRangeEnd = 527775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunChangePasswordFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x0006DE1C File Offset: 0x0006C01C
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 498694, RefRangeEnd = 498749, XrefRangeStart = 498694, XrefRangeEnd = 498749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunChangePasswordFlow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunChangePasswordFlow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunChangePasswordFlow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x0000DAD6 File Offset: 0x0000BCD6
		public RunChangePasswordFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F74 RID: 3956
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000F75 RID: 3957
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003F9 RID: 1017
		[ObfuscatedName("boardgames.menus.commands.RunChangePasswordFlow+<execute>d__0")]
		public sealed class _execute_d__0 : Object
		{
			// Token: 0x06002F97 RID: 12183 RVA: 0x000B69A0 File Offset: 0x000B4BA0
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__0()
			{
				Il2CppClassPointerStore<RunChangePasswordFlow._execute_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunChangePasswordFlow>.NativeClassPtr, "<execute>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunChangePasswordFlow._execute_d__0>.NativeClassPtr);
				RunChangePasswordFlow._execute_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunChangePasswordFlow._execute_d__0>.NativeClassPtr, "<>1__state");
				RunChangePasswordFlow._execute_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunChangePasswordFlow._execute_d__0>.NativeClassPtr, "<>2__current");
				RunChangePasswordFlow._execute_d__0.NativeFieldInfoPtr__resolved_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunChangePasswordFlow._execute_d__0>.NativeClassPtr, "<resolved>5__2");
				RunChangePasswordFlow._execute_d__0.NativeFieldInfoPtr__changePassPrompt_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunChangePasswordFlow._execute_d__0>.NativeClassPtr, "<changePassPrompt>5__3");
				RunChangePasswordFlow._execute_d__0.NativeFieldInfoPtr__changePassword_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunChangePasswordFlow._execute_d__0>.NativeClassPtr, "<changePassword>5__4");
				RunChangePasswordFlow._execute_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunChangePasswordFlow._execute_d__0>.NativeClassPtr, 100667030);
				RunChangePasswordFlow._execute_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunChangePasswordFlow._execute_d__0>.NativeClassPtr, 100667031);
				RunChangePasswordFlow._execute_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunChangePasswordFlow._execute_d__0>.NativeClassPtr, 100667032);
				RunChangePasswordFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunChangePasswordFlow._execute_d__0>.NativeClassPtr, 100667033);
				RunChangePasswordFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunChangePasswordFlow._execute_d__0>.NativeClassPtr, 100667034);
				RunChangePasswordFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunChangePasswordFlow._execute_d__0>.NativeClassPtr, 100667035);
			}

			// Token: 0x06002F98 RID: 12184 RVA: 0x000B6AA8 File Offset: 0x000B4CA8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunChangePasswordFlow._execute_d__0>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunChangePasswordFlow._execute_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F99 RID: 12185 RVA: 0x000B6AF0 File Offset: 0x000B4CF0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunChangePasswordFlow._execute_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F9A RID: 12186 RVA: 0x000B6B24 File Offset: 0x000B4D24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527743, XrefRangeEnd = 527766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunChangePasswordFlow._execute_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000DAC RID: 3500
			// (get) Token: 0x06002F9B RID: 12187 RVA: 0x000B6B60 File Offset: 0x000B4D60
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunChangePasswordFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002F9C RID: 12188 RVA: 0x000B6BA0 File Offset: 0x000B4DA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527766, XrefRangeEnd = 527771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunChangePasswordFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000DAD RID: 3501
			// (get) Token: 0x06002F9D RID: 12189 RVA: 0x000B6BD4 File Offset: 0x000B4DD4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunChangePasswordFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002F9E RID: 12190 RVA: 0x00018937 File Offset: 0x00016B37
			public _execute_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DA7 RID: 3495
			// (get) Token: 0x06002F9F RID: 12191 RVA: 0x000B6C14 File Offset: 0x000B4E14
			// (set) Token: 0x06002FA0 RID: 12192 RVA: 0x00018940 File Offset: 0x00016B40
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunChangePasswordFlow._execute_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunChangePasswordFlow._execute_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000DA8 RID: 3496
			// (get) Token: 0x06002FA1 RID: 12193 RVA: 0x000B6C3C File Offset: 0x000B4E3C
			// (set) Token: 0x06002FA2 RID: 12194 RVA: 0x0001895B File Offset: 0x00016B5B
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunChangePasswordFlow._execute_d__0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunChangePasswordFlow._execute_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DA9 RID: 3497
			// (get) Token: 0x06002FA3 RID: 12195 RVA: 0x000B6C6C File Offset: 0x000B4E6C
			// (set) Token: 0x06002FA4 RID: 12196 RVA: 0x0001897A File Offset: 0x00016B7A
			public unsafe bool _resolved_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunChangePasswordFlow._execute_d__0.NativeFieldInfoPtr__resolved_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunChangePasswordFlow._execute_d__0.NativeFieldInfoPtr__resolved_5__2)) = value;
				}
			}

			// Token: 0x17000DAA RID: 3498
			// (get) Token: 0x06002FA5 RID: 12197 RVA: 0x000B6C94 File Offset: 0x000B4E94
			// (set) Token: 0x06002FA6 RID: 12198 RVA: 0x00018995 File Offset: 0x00016B95
			public unsafe ChangePasswordPrompt _changePassPrompt_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunChangePasswordFlow._execute_d__0.NativeFieldInfoPtr__changePassPrompt_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChangePasswordPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunChangePasswordFlow._execute_d__0.NativeFieldInfoPtr__changePassPrompt_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DAB RID: 3499
			// (get) Token: 0x06002FA7 RID: 12199 RVA: 0x000B6CC4 File Offset: 0x000B4EC4
			// (set) Token: 0x06002FA8 RID: 12200 RVA: 0x000189B4 File Offset: 0x00016BB4
			public unsafe ChangePasswordCommand _changePassword_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunChangePasswordFlow._execute_d__0.NativeFieldInfoPtr__changePassword_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChangePasswordCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunChangePasswordFlow._execute_d__0.NativeFieldInfoPtr__changePassword_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001D72 RID: 7538
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001D73 RID: 7539
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001D74 RID: 7540
			private static readonly IntPtr NativeFieldInfoPtr__resolved_5__2;

			// Token: 0x04001D75 RID: 7541
			private static readonly IntPtr NativeFieldInfoPtr__changePassPrompt_5__3;

			// Token: 0x04001D76 RID: 7542
			private static readonly IntPtr NativeFieldInfoPtr__changePassword_5__4;

			// Token: 0x04001D77 RID: 7543
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001D78 RID: 7544
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D79 RID: 7545
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001D7A RID: 7546
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001D7B RID: 7547
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D7C RID: 7548
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

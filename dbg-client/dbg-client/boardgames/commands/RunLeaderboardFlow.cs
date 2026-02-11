using System;
using boardgames.menus.commands;
using dwd.core.commands;
using dwd.core.data.composition;
using dwd.core.prefabs.implementations.byflavor;
using dwd.core.ui.prompt.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.commands
{
	// Token: 0x0200019F RID: 415
	public class RunLeaderboardFlow : FailableCommand
	{
		// Token: 0x0600125E RID: 4702 RVA: 0x0005863C File Offset: 0x0005683C
		// Note: this type is marked as 'beforefieldinit'.
		static RunLeaderboardFlow()
		{
			Il2CppClassPointerStore<RunLeaderboardFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.commands", "RunLeaderboardFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunLeaderboardFlow>.NativeClassPtr);
			RunLeaderboardFlow.NativeFieldInfoPtr_promptFlavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLeaderboardFlow>.NativeClassPtr, "promptFlavors");
			RunLeaderboardFlow.NativeFieldInfoPtr_loadCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLeaderboardFlow>.NativeClassPtr, "loadCommand");
			RunLeaderboardFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLeaderboardFlow>.NativeClassPtr, 100665962);
			RunLeaderboardFlow.NativeMethodInfoPtr_GetLoadLeaderboardsCommand_Protected_Virtual_New_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLeaderboardFlow>.NativeClassPtr, 100665963);
			RunLeaderboardFlow.NativeMethodInfoPtr_GetPromptData_Protected_Virtual_New_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLeaderboardFlow>.NativeClassPtr, 100665964);
			RunLeaderboardFlow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLeaderboardFlow>.NativeClassPtr, 100665965);
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x000586E4 File Offset: 0x000568E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516894, XrefRangeEnd = 516899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunLeaderboardFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x00058730 File Offset: 0x00056930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516899, XrefRangeEnd = 516903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Command GetLoadLeaderboardsCommand()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunLeaderboardFlow.NativeMethodInfoPtr_GetLoadLeaderboardsCommand_Protected_Virtual_New_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x0005877C File Offset: 0x0005697C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516903, XrefRangeEnd = 516916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DataComposition GetPromptData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunLeaderboardFlow.NativeMethodInfoPtr_GetPromptData_Protected_Virtual_New_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x000587C8 File Offset: 0x000569C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 516927, RefRangeEnd = 516929, XrefRangeStart = 516916, XrefRangeEnd = 516927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunLeaderboardFlow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunLeaderboardFlow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLeaderboardFlow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x0000AB78 File Offset: 0x00008D78
		public RunLeaderboardFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06001264 RID: 4708 RVA: 0x00058804 File Offset: 0x00056A04
		// (set) Token: 0x06001265 RID: 4709 RVA: 0x0000AB81 File Offset: 0x00008D81
		public PrefabFlavorContext promptFlavors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLeaderboardFlow.NativeFieldInfoPtr_promptFlavors);
				return new PrefabFlavorContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabFlavorContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLeaderboardFlow.NativeFieldInfoPtr_promptFlavors), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PrefabFlavorContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06001266 RID: 4710 RVA: 0x00058834 File Offset: 0x00056A34
		// (set) Token: 0x06001267 RID: 4711 RVA: 0x0000ABAF File Offset: 0x00008DAF
		public unsafe Command loadCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLeaderboardFlow.NativeFieldInfoPtr_loadCommand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLeaderboardFlow.NativeFieldInfoPtr_loadCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B43 RID: 2883
		private static readonly IntPtr NativeFieldInfoPtr_promptFlavors;

		// Token: 0x04000B44 RID: 2884
		private static readonly IntPtr NativeFieldInfoPtr_loadCommand;

		// Token: 0x04000B45 RID: 2885
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000B46 RID: 2886
		private static readonly IntPtr NativeMethodInfoPtr_GetLoadLeaderboardsCommand_Protected_Virtual_New_Command_0;

		// Token: 0x04000B47 RID: 2887
		private static readonly IntPtr NativeMethodInfoPtr_GetPromptData_Protected_Virtual_New_DataComposition_0;

		// Token: 0x04000B48 RID: 2888
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200038F RID: 911
		[ObfuscatedName("boardgames.commands.RunLeaderboardFlow+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x06002AF5 RID: 10997 RVA: 0x000A8F7C File Offset: 0x000A717C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<RunLeaderboardFlow._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunLeaderboardFlow>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunLeaderboardFlow._execute_d__2>.NativeClassPtr);
				RunLeaderboardFlow._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLeaderboardFlow._execute_d__2>.NativeClassPtr, "<>1__state");
				RunLeaderboardFlow._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLeaderboardFlow._execute_d__2>.NativeClassPtr, "<>2__current");
				RunLeaderboardFlow._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLeaderboardFlow._execute_d__2>.NativeClassPtr, "<>4__this");
				RunLeaderboardFlow._execute_d__2.NativeFieldInfoPtr__login_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLeaderboardFlow._execute_d__2>.NativeClassPtr, "<login>5__2");
				RunLeaderboardFlow._execute_d__2.NativeFieldInfoPtr__load_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLeaderboardFlow._execute_d__2>.NativeClassPtr, "<load>5__3");
				RunLeaderboardFlow._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLeaderboardFlow._execute_d__2>.NativeClassPtr, 100665966);
				RunLeaderboardFlow._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLeaderboardFlow._execute_d__2>.NativeClassPtr, 100665967);
				RunLeaderboardFlow._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLeaderboardFlow._execute_d__2>.NativeClassPtr, 100665968);
				RunLeaderboardFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLeaderboardFlow._execute_d__2>.NativeClassPtr, 100665969);
				RunLeaderboardFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLeaderboardFlow._execute_d__2>.NativeClassPtr, 100665970);
				RunLeaderboardFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLeaderboardFlow._execute_d__2>.NativeClassPtr, 100665971);
			}

			// Token: 0x06002AF6 RID: 10998 RVA: 0x000A9084 File Offset: 0x000A7284
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunLeaderboardFlow._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLeaderboardFlow._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002AF7 RID: 10999 RVA: 0x000A90CC File Offset: 0x000A72CC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLeaderboardFlow._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002AF8 RID: 11000 RVA: 0x000A9100 File Offset: 0x000A7300
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516862, XrefRangeEnd = 516889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLeaderboardFlow._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000C2E RID: 3118
			// (get) Token: 0x06002AF9 RID: 11001 RVA: 0x000A913C File Offset: 0x000A733C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLeaderboardFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002AFA RID: 11002 RVA: 0x000A917C File Offset: 0x000A737C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516889, XrefRangeEnd = 516894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLeaderboardFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C2F RID: 3119
			// (get) Token: 0x06002AFB RID: 11003 RVA: 0x000A91B0 File Offset: 0x000A73B0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLeaderboardFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002AFC RID: 11004 RVA: 0x00016361 File Offset: 0x00014561
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C29 RID: 3113
			// (get) Token: 0x06002AFD RID: 11005 RVA: 0x000A91F0 File Offset: 0x000A73F0
			// (set) Token: 0x06002AFE RID: 11006 RVA: 0x0001636A File Offset: 0x0001456A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLeaderboardFlow._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLeaderboardFlow._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C2A RID: 3114
			// (get) Token: 0x06002AFF RID: 11007 RVA: 0x000A9218 File Offset: 0x000A7418
			// (set) Token: 0x06002B00 RID: 11008 RVA: 0x00016385 File Offset: 0x00014585
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLeaderboardFlow._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLeaderboardFlow._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C2B RID: 3115
			// (get) Token: 0x06002B01 RID: 11009 RVA: 0x000A9248 File Offset: 0x000A7448
			// (set) Token: 0x06002B02 RID: 11010 RVA: 0x000163A4 File Offset: 0x000145A4
			public unsafe RunLeaderboardFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLeaderboardFlow._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunLeaderboardFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLeaderboardFlow._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C2C RID: 3116
			// (get) Token: 0x06002B03 RID: 11011 RVA: 0x000A9278 File Offset: 0x000A7478
			// (set) Token: 0x06002B04 RID: 11012 RVA: 0x000163C3 File Offset: 0x000145C3
			public unsafe LoginIfNeeded _login_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLeaderboardFlow._execute_d__2.NativeFieldInfoPtr__login_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoginIfNeeded>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLeaderboardFlow._execute_d__2.NativeFieldInfoPtr__login_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C2D RID: 3117
			// (get) Token: 0x06002B05 RID: 11013 RVA: 0x000A92A8 File Offset: 0x000A74A8
			// (set) Token: 0x06002B06 RID: 11014 RVA: 0x000163E2 File Offset: 0x000145E2
			public unsafe ShowSpinnerWhile<IFailable> _load_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLeaderboardFlow._execute_d__2.NativeFieldInfoPtr__load_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShowSpinnerWhile<IFailable>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLeaderboardFlow._execute_d__2.NativeFieldInfoPtr__load_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001ACB RID: 6859
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001ACC RID: 6860
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001ACD RID: 6861
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001ACE RID: 6862
			private static readonly IntPtr NativeFieldInfoPtr__login_5__2;

			// Token: 0x04001ACF RID: 6863
			private static readonly IntPtr NativeFieldInfoPtr__load_5__3;

			// Token: 0x04001AD0 RID: 6864
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001AD1 RID: 6865
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001AD2 RID: 6866
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001AD3 RID: 6867
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001AD4 RID: 6868
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001AD5 RID: 6869
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

using System;
using dbgclient.prompts;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dbgclient.commands
{
	// Token: 0x020000D9 RID: 217
	public class RunShopFlow : Command
	{
		// Token: 0x06000936 RID: 2358 RVA: 0x0003A9A8 File Offset: 0x00038BA8
		// Note: this type is marked as 'beforefieldinit'.
		static RunShopFlow()
		{
			Il2CppClassPointerStore<RunShopFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.commands", "RunShopFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunShopFlow>.NativeClassPtr);
			RunShopFlow.NativeFieldInfoPtr_ShopTimeoutTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunShopFlow>.NativeClassPtr, "ShopTimeoutTime");
			RunShopFlow.NativeFieldInfoPtr_startingTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunShopFlow>.NativeClassPtr, "startingTab");
			RunShopFlow.NativeMethodInfoPtr__ctor_Public_Void_ShopPromptTab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunShopFlow>.NativeClassPtr, 100664622);
			RunShopFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunShopFlow>.NativeClassPtr, 100664623);
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x0003AA28 File Offset: 0x00038C28
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 505412, RefRangeEnd = 505418, XrefRangeStart = 505411, XrefRangeEnd = 505412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunShopFlow(ShopPromptTab startingTab = ShopPromptTab.Featured)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunShopFlow>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startingTab;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunShopFlow.NativeMethodInfoPtr__ctor_Public_Void_ShopPromptTab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x0003AA70 File Offset: 0x00038C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505418, XrefRangeEnd = 505423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunShopFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00006586 File Offset: 0x00004786
		public RunShopFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x0600093A RID: 2362 RVA: 0x0003AABC File Offset: 0x00038CBC
		// (set) Token: 0x0600093B RID: 2363 RVA: 0x0000658F File Offset: 0x0000478F
		public unsafe static float ShopTimeoutTime
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(RunShopFlow.NativeFieldInfoPtr_ShopTimeoutTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunShopFlow.NativeFieldInfoPtr_ShopTimeoutTime, (void*)(&value));
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x0600093C RID: 2364 RVA: 0x0003AAD8 File Offset: 0x00038CD8
		// (set) Token: 0x0600093D RID: 2365 RVA: 0x0000659D File Offset: 0x0000479D
		public unsafe ShopPromptTab startingTab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunShopFlow.NativeFieldInfoPtr_startingTab);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunShopFlow.NativeFieldInfoPtr_startingTab)) = value;
			}
		}

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeFieldInfoPtr_ShopTimeoutTime;

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeFieldInfoPtr_startingTab;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ShopPromptTab_0;

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000328 RID: 808
		[ObfuscatedName("dbgclient.commands.RunShopFlow+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x0600261B RID: 9755 RVA: 0x0009A7E4 File Offset: 0x000989E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<RunShopFlow.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunShopFlow>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunShopFlow.__c__DisplayClass3_0>.NativeClassPtr);
				RunShopFlow.__c__DisplayClass3_0.NativeFieldInfoPtr_refresh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunShopFlow.__c__DisplayClass3_0>.NativeClassPtr, "refresh");
				RunShopFlow.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunShopFlow.__c__DisplayClass3_0>.NativeClassPtr, 100664624);
				RunShopFlow.__c__DisplayClass3_0.NativeMethodInfoPtr__execute_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunShopFlow.__c__DisplayClass3_0>.NativeClassPtr, 100664625);
			}

			// Token: 0x0600261C RID: 9756 RVA: 0x0009A84C File Offset: 0x00098A4C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunShopFlow.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunShopFlow.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600261D RID: 9757 RVA: 0x0009A888 File Offset: 0x00098A88
			[CallerCount(0)]
			public unsafe bool _execute_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunShopFlow.__c__DisplayClass3_0.NativeMethodInfoPtr__execute_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600261E RID: 9758 RVA: 0x00013C25 File Offset: 0x00011E25
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A84 RID: 2692
			// (get) Token: 0x0600261F RID: 9759 RVA: 0x0009A8C4 File Offset: 0x00098AC4
			// (set) Token: 0x06002620 RID: 9760 RVA: 0x00013C2E File Offset: 0x00011E2E
			public unsafe Command refresh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunShopFlow.__c__DisplayClass3_0.NativeFieldInfoPtr_refresh);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunShopFlow.__c__DisplayClass3_0.NativeFieldInfoPtr_refresh), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017E4 RID: 6116
			private static readonly IntPtr NativeFieldInfoPtr_refresh;

			// Token: 0x040017E5 RID: 6117
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040017E6 RID: 6118
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__0_Internal_Boolean_0;
		}

		// Token: 0x02000329 RID: 809
		[ObfuscatedName("dbgclient.commands.RunShopFlow+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x06002621 RID: 9761 RVA: 0x0009A8F4 File Offset: 0x00098AF4
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<RunShopFlow._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunShopFlow>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunShopFlow._execute_d__3>.NativeClassPtr);
				RunShopFlow._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunShopFlow._execute_d__3>.NativeClassPtr, "<>1__state");
				RunShopFlow._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunShopFlow._execute_d__3>.NativeClassPtr, "<>2__current");
				RunShopFlow._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunShopFlow._execute_d__3>.NativeClassPtr, "<>4__this");
				RunShopFlow._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunShopFlow._execute_d__3>.NativeClassPtr, 100664626);
				RunShopFlow._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunShopFlow._execute_d__3>.NativeClassPtr, 100664627);
				RunShopFlow._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunShopFlow._execute_d__3>.NativeClassPtr, 100664628);
				RunShopFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunShopFlow._execute_d__3>.NativeClassPtr, 100664629);
				RunShopFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunShopFlow._execute_d__3>.NativeClassPtr, 100664630);
				RunShopFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunShopFlow._execute_d__3>.NativeClassPtr, 100664631);
			}

			// Token: 0x06002622 RID: 9762 RVA: 0x0009A9D4 File Offset: 0x00098BD4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunShopFlow._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunShopFlow._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002623 RID: 9763 RVA: 0x0009AA1C File Offset: 0x00098C1C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunShopFlow._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002624 RID: 9764 RVA: 0x0009AA50 File Offset: 0x00098C50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505381, XrefRangeEnd = 505406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunShopFlow._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A88 RID: 2696
			// (get) Token: 0x06002625 RID: 9765 RVA: 0x0009AA8C File Offset: 0x00098C8C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunShopFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002626 RID: 9766 RVA: 0x0009AACC File Offset: 0x00098CCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505406, XrefRangeEnd = 505411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunShopFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A89 RID: 2697
			// (get) Token: 0x06002627 RID: 9767 RVA: 0x0009AB00 File Offset: 0x00098D00
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunShopFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002628 RID: 9768 RVA: 0x00013C4D File Offset: 0x00011E4D
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A85 RID: 2693
			// (get) Token: 0x06002629 RID: 9769 RVA: 0x0009AB40 File Offset: 0x00098D40
			// (set) Token: 0x0600262A RID: 9770 RVA: 0x00013C56 File Offset: 0x00011E56
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunShopFlow._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunShopFlow._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A86 RID: 2694
			// (get) Token: 0x0600262B RID: 9771 RVA: 0x0009AB68 File Offset: 0x00098D68
			// (set) Token: 0x0600262C RID: 9772 RVA: 0x00013C71 File Offset: 0x00011E71
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunShopFlow._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunShopFlow._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A87 RID: 2695
			// (get) Token: 0x0600262D RID: 9773 RVA: 0x0009AB98 File Offset: 0x00098D98
			// (set) Token: 0x0600262E RID: 9774 RVA: 0x00013C90 File Offset: 0x00011E90
			public unsafe RunShopFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunShopFlow._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunShopFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunShopFlow._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017E7 RID: 6119
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040017E8 RID: 6120
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040017E9 RID: 6121
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040017EA RID: 6122
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040017EB RID: 6123
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017EC RID: 6124
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040017ED RID: 6125
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040017EE RID: 6126
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017EF RID: 6127
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

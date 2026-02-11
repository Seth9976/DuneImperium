using System;
using dwd.core.input.context;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dwd.core.commands
{
	// Token: 0x02000038 RID: 56
	public class WithBlockingInputContext : Command
	{
		// Token: 0x060001B5 RID: 437 RVA: 0x0000C604 File Offset: 0x0000A804
		// Note: this type is marked as 'beforefieldinit'.
		static WithBlockingInputContext()
		{
			Il2CppClassPointerStore<WithBlockingInputContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.commands", "WithBlockingInputContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WithBlockingInputContext>.NativeClassPtr);
			WithBlockingInputContext.NativeFieldInfoPtr_innerCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WithBlockingInputContext>.NativeClassPtr, "innerCommand");
			WithBlockingInputContext.NativeFieldInfoPtr_BlockingContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WithBlockingInputContext>.NativeClassPtr, "BlockingContext");
			WithBlockingInputContext.NativeMethodInfoPtr__ctor_Public_Void_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WithBlockingInputContext>.NativeClassPtr, 100663524);
			WithBlockingInputContext.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WithBlockingInputContext>.NativeClassPtr, 100663525);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000C684 File Offset: 0x0000A884
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1120278, RefRangeEnd = 1120279, XrefRangeStart = 1120262, XrefRangeEnd = 1120278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WithBlockingInputContext(IEnumerator innerCommand)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WithBlockingInputContext>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerCommand);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WithBlockingInputContext.NativeMethodInfoPtr__ctor_Public_Void_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000C6D0 File Offset: 0x0000A8D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120279, XrefRangeEnd = 1120284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WithBlockingInputContext.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002F9A File Offset: 0x0000119A
		public WithBlockingInputContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x0000C71C File Offset: 0x0000A91C
		// (set) Token: 0x060001BA RID: 442 RVA: 0x00002FA3 File Offset: 0x000011A3
		public unsafe Command innerCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WithBlockingInputContext.NativeFieldInfoPtr_innerCommand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WithBlockingInputContext.NativeFieldInfoPtr_innerCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001BB RID: 443 RVA: 0x0000C74C File Offset: 0x0000A94C
		// (set) Token: 0x060001BC RID: 444 RVA: 0x00002FC2 File Offset: 0x000011C2
		public unsafe InputContext BlockingContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WithBlockingInputContext.NativeFieldInfoPtr_BlockingContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WithBlockingInputContext.NativeFieldInfoPtr_BlockingContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeFieldInfoPtr_innerCommand;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeFieldInfoPtr_BlockingContext;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerator_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x020000BE RID: 190
		[ObfuscatedName("dwd.core.commands.WithBlockingInputContext+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x06000895 RID: 2197 RVA: 0x00022AD0 File Offset: 0x00020CD0
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<WithBlockingInputContext._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WithBlockingInputContext>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WithBlockingInputContext._execute_d__3>.NativeClassPtr);
				WithBlockingInputContext._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WithBlockingInputContext._execute_d__3>.NativeClassPtr, "<>1__state");
				WithBlockingInputContext._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WithBlockingInputContext._execute_d__3>.NativeClassPtr, "<>2__current");
				WithBlockingInputContext._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WithBlockingInputContext._execute_d__3>.NativeClassPtr, "<>4__this");
				WithBlockingInputContext._execute_d__3.NativeFieldInfoPtr__inputContextManager_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WithBlockingInputContext._execute_d__3>.NativeClassPtr, "<inputContextManager>5__2");
				WithBlockingInputContext._execute_d__3.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WithBlockingInputContext._execute_d__3>.NativeClassPtr, "<>7__wrap2");
				WithBlockingInputContext._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WithBlockingInputContext._execute_d__3>.NativeClassPtr, 100663526);
				WithBlockingInputContext._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WithBlockingInputContext._execute_d__3>.NativeClassPtr, 100663527);
				WithBlockingInputContext._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WithBlockingInputContext._execute_d__3>.NativeClassPtr, 100663528);
				WithBlockingInputContext._execute_d__3.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WithBlockingInputContext._execute_d__3>.NativeClassPtr, 100663529);
				WithBlockingInputContext._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WithBlockingInputContext._execute_d__3>.NativeClassPtr, 100663530);
				WithBlockingInputContext._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WithBlockingInputContext._execute_d__3>.NativeClassPtr, 100663531);
				WithBlockingInputContext._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WithBlockingInputContext._execute_d__3>.NativeClassPtr, 100663532);
			}

			// Token: 0x06000896 RID: 2198 RVA: 0x00022BEC File Offset: 0x00020DEC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WithBlockingInputContext._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WithBlockingInputContext._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000897 RID: 2199 RVA: 0x00022C34 File Offset: 0x00020E34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120209, XrefRangeEnd = 1120212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WithBlockingInputContext._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000898 RID: 2200 RVA: 0x00022C68 File Offset: 0x00020E68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120212, XrefRangeEnd = 1120251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WithBlockingInputContext._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000899 RID: 2201 RVA: 0x00022CA4 File Offset: 0x00020EA4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1120256, RefRangeEnd = 1120257, XrefRangeStart = 1120251, XrefRangeEnd = 1120256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WithBlockingInputContext._execute_d__3.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700027C RID: 636
			// (get) Token: 0x0600089A RID: 2202 RVA: 0x00022CD8 File Offset: 0x00020ED8
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WithBlockingInputContext._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600089B RID: 2203 RVA: 0x00022D18 File Offset: 0x00020F18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120257, XrefRangeEnd = 1120262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WithBlockingInputContext._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700027D RID: 637
			// (get) Token: 0x0600089C RID: 2204 RVA: 0x00022D4C File Offset: 0x00020F4C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WithBlockingInputContext._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600089D RID: 2205 RVA: 0x000067EB File Offset: 0x000049EB
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000277 RID: 631
			// (get) Token: 0x0600089E RID: 2206 RVA: 0x00022D8C File Offset: 0x00020F8C
			// (set) Token: 0x0600089F RID: 2207 RVA: 0x000067F4 File Offset: 0x000049F4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WithBlockingInputContext._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WithBlockingInputContext._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000278 RID: 632
			// (get) Token: 0x060008A0 RID: 2208 RVA: 0x00022DB4 File Offset: 0x00020FB4
			// (set) Token: 0x060008A1 RID: 2209 RVA: 0x0000680F File Offset: 0x00004A0F
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WithBlockingInputContext._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WithBlockingInputContext._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000279 RID: 633
			// (get) Token: 0x060008A2 RID: 2210 RVA: 0x00022DE4 File Offset: 0x00020FE4
			// (set) Token: 0x060008A3 RID: 2211 RVA: 0x0000682E File Offset: 0x00004A2E
			public unsafe WithBlockingInputContext __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WithBlockingInputContext._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WithBlockingInputContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WithBlockingInputContext._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700027A RID: 634
			// (get) Token: 0x060008A4 RID: 2212 RVA: 0x00022E14 File Offset: 0x00021014
			// (set) Token: 0x060008A5 RID: 2213 RVA: 0x0000684D File Offset: 0x00004A4D
			public unsafe InputContextManager _inputContextManager_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WithBlockingInputContext._execute_d__3.NativeFieldInfoPtr__inputContextManager_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputContextManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WithBlockingInputContext._execute_d__3.NativeFieldInfoPtr__inputContextManager_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700027B RID: 635
			// (get) Token: 0x060008A6 RID: 2214 RVA: 0x00022E44 File Offset: 0x00021044
			// (set) Token: 0x060008A7 RID: 2215 RVA: 0x0000686C File Offset: 0x00004A6C
			public unsafe IEnumerator __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WithBlockingInputContext._execute_d__3.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WithBlockingInputContext._execute_d__3.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000545 RID: 1349
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000546 RID: 1350
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000547 RID: 1351
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000548 RID: 1352
			private static readonly IntPtr NativeFieldInfoPtr__inputContextManager_5__2;

			// Token: 0x04000549 RID: 1353
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x0400054A RID: 1354
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400054B RID: 1355
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400054C RID: 1356
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400054D RID: 1357
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400054E RID: 1358
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400054F RID: 1359
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000550 RID: 1360
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;

namespace dwd.core.commands
{
	// Token: 0x0200002F RID: 47
	public static class HigherOrder : Object
	{
		// Token: 0x060001D0 RID: 464 RVA: 0x0000BEE8 File Offset: 0x0000A0E8
		// Note: this type is marked as 'beforefieldinit'.
		static HigherOrder()
		{
			Il2CppClassPointerStore<HigherOrder>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-commands.dll", "dwd.core.commands", "HigherOrder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HigherOrder>.NativeClassPtr);
			HigherOrder.NativeMethodInfoPtr_Repeat_Public_Static_IEnumerator_Func_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HigherOrder>.NativeClassPtr, 100663794);
			HigherOrder.NativeMethodInfoPtr_RepeatWhile_Public_Static_IEnumerator_Func_1_T_Func_2_T_Boolean_Func_2_T_TOther_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HigherOrder>.NativeClassPtr, 100663795);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000BF40 File Offset: 0x0000A140
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1209633, RefRangeEnd = 1209635, XrefRangeStart = 1209628, XrefRangeEnd = 1209633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator Repeat(this Func<Command> generator)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(generator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HigherOrder.NativeMethodInfoPtr_Repeat_Public_Static_IEnumerator_Func_1_Command_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000BF84 File Offset: 0x0000A184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209635, XrefRangeEnd = 1209641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator RepeatWhile<T, TOther>(this Func<T> generator, Func<T, bool> shouldContinue, Func<T, TOther> inBetweenGen = null) where T : Command
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(generator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(shouldContinue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inBetweenGen);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HigherOrder.MethodInfoStoreGeneric_RepeatWhile_Public_Static_IEnumerator_Func_1_T_Func_2_T_Boolean_Func_2_T_TOther_0<T, TOther>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002C27 File Offset: 0x00000E27
		public HigherOrder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_Repeat_Public_Static_IEnumerator_Func_1_Command_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_RepeatWhile_Public_Static_IEnumerator_Func_1_T_Func_2_T_Boolean_Func_2_T_TOther_0;

		// Token: 0x0200008F RID: 143
		[ObfuscatedName("dwd.core.commands.HigherOrder+<Repeat>d__0")]
		public sealed class _Repeat_d__0 : Object
		{
			// Token: 0x06000548 RID: 1352 RVA: 0x00017658 File Offset: 0x00015858
			// Note: this type is marked as 'beforefieldinit'.
			static _Repeat_d__0()
			{
				Il2CppClassPointerStore<HigherOrder._Repeat_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HigherOrder>.NativeClassPtr, "<Repeat>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HigherOrder._Repeat_d__0>.NativeClassPtr);
				HigherOrder._Repeat_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HigherOrder._Repeat_d__0>.NativeClassPtr, "<>1__state");
				HigherOrder._Repeat_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HigherOrder._Repeat_d__0>.NativeClassPtr, "<>2__current");
				HigherOrder._Repeat_d__0.NativeFieldInfoPtr_generator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HigherOrder._Repeat_d__0>.NativeClassPtr, "generator");
				HigherOrder._Repeat_d__0.NativeFieldInfoPtr__command_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HigherOrder._Repeat_d__0>.NativeClassPtr, "<command>5__2");
				HigherOrder._Repeat_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HigherOrder._Repeat_d__0>.NativeClassPtr, 100663796);
				HigherOrder._Repeat_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HigherOrder._Repeat_d__0>.NativeClassPtr, 100663797);
				HigherOrder._Repeat_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HigherOrder._Repeat_d__0>.NativeClassPtr, 100663798);
				HigherOrder._Repeat_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HigherOrder._Repeat_d__0>.NativeClassPtr, 100663799);
				HigherOrder._Repeat_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HigherOrder._Repeat_d__0>.NativeClassPtr, 100663800);
				HigherOrder._Repeat_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HigherOrder._Repeat_d__0>.NativeClassPtr, 100663801);
			}

			// Token: 0x06000549 RID: 1353 RVA: 0x0001774C File Offset: 0x0001594C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Repeat_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HigherOrder._Repeat_d__0>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HigherOrder._Repeat_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600054A RID: 1354 RVA: 0x00017794 File Offset: 0x00015994
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HigherOrder._Repeat_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600054B RID: 1355 RVA: 0x000177C8 File Offset: 0x000159C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209604, XrefRangeEnd = 1209611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HigherOrder._Repeat_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700016B RID: 363
			// (get) Token: 0x0600054C RID: 1356 RVA: 0x00017804 File Offset: 0x00015A04
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HigherOrder._Repeat_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600054D RID: 1357 RVA: 0x00017844 File Offset: 0x00015A44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209611, XrefRangeEnd = 1209616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HigherOrder._Repeat_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700016C RID: 364
			// (get) Token: 0x0600054E RID: 1358 RVA: 0x00017878 File Offset: 0x00015A78
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HigherOrder._Repeat_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600054F RID: 1359 RVA: 0x0000451F File Offset: 0x0000271F
			public _Repeat_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000167 RID: 359
			// (get) Token: 0x06000550 RID: 1360 RVA: 0x000178B8 File Offset: 0x00015AB8
			// (set) Token: 0x06000551 RID: 1361 RVA: 0x00004528 File Offset: 0x00002728
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HigherOrder._Repeat_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HigherOrder._Repeat_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000168 RID: 360
			// (get) Token: 0x06000552 RID: 1362 RVA: 0x000178E0 File Offset: 0x00015AE0
			// (set) Token: 0x06000553 RID: 1363 RVA: 0x00004543 File Offset: 0x00002743
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HigherOrder._Repeat_d__0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HigherOrder._Repeat_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000169 RID: 361
			// (get) Token: 0x06000554 RID: 1364 RVA: 0x00017910 File Offset: 0x00015B10
			// (set) Token: 0x06000555 RID: 1365 RVA: 0x00004562 File Offset: 0x00002762
			public unsafe Func<Command> generator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HigherOrder._Repeat_d__0.NativeFieldInfoPtr_generator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Command>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HigherOrder._Repeat_d__0.NativeFieldInfoPtr_generator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700016A RID: 362
			// (get) Token: 0x06000556 RID: 1366 RVA: 0x00017940 File Offset: 0x00015B40
			// (set) Token: 0x06000557 RID: 1367 RVA: 0x00004581 File Offset: 0x00002781
			public unsafe Command _command_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HigherOrder._Repeat_d__0.NativeFieldInfoPtr__command_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HigherOrder._Repeat_d__0.NativeFieldInfoPtr__command_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000339 RID: 825
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400033A RID: 826
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400033B RID: 827
			private static readonly IntPtr NativeFieldInfoPtr_generator;

			// Token: 0x0400033C RID: 828
			private static readonly IntPtr NativeFieldInfoPtr__command_5__2;

			// Token: 0x0400033D RID: 829
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400033E RID: 830
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400033F RID: 831
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000340 RID: 832
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000341 RID: 833
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000342 RID: 834
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000090 RID: 144
		[ObfuscatedName("dwd.core.commands.HigherOrder+<RepeatWhile>d__1`2")]
		public sealed class _RepeatWhile_d__1<T, TOther> : Object where T : Command
		{
			// Token: 0x06000558 RID: 1368 RVA: 0x00017970 File Offset: 0x00015B70
			// Note: this type is marked as 'beforefieldinit'.
			static _RepeatWhile_d__1()
			{
				Il2CppClassPointerStore<HigherOrder._RepeatWhile_d__1<T, TOther>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HigherOrder>.NativeClassPtr, "<RepeatWhile>d__1`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOther>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HigherOrder._RepeatWhile_d__1<T, TOther>>.NativeClassPtr);
				HigherOrder._RepeatWhile_d__1<T, TOther>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HigherOrder._RepeatWhile_d__1<T, TOther>>.NativeClassPtr, "<>1__state");
				HigherOrder._RepeatWhile_d__1<T, TOther>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HigherOrder._RepeatWhile_d__1<T, TOther>>.NativeClassPtr, "<>2__current");
				HigherOrder._RepeatWhile_d__1<T, TOther>.NativeFieldInfoPtr_generator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HigherOrder._RepeatWhile_d__1<T, TOther>>.NativeClassPtr, "generator");
				HigherOrder._RepeatWhile_d__1<T, TOther>.NativeFieldInfoPtr_shouldContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HigherOrder._RepeatWhile_d__1<T, TOther>>.NativeClassPtr, "shouldContinue");
				HigherOrder._RepeatWhile_d__1<T, TOther>.NativeFieldInfoPtr_inBetweenGen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HigherOrder._RepeatWhile_d__1<T, TOther>>.NativeClassPtr, "inBetweenGen");
				HigherOrder._RepeatWhile_d__1<T, TOther>.NativeFieldInfoPtr__command_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HigherOrder._RepeatWhile_d__1<T, TOther>>.NativeClassPtr, "<command>5__2");
				HigherOrder._RepeatWhile_d__1<T, TOther>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HigherOrder._RepeatWhile_d__1<T, TOther>>.NativeClassPtr, 100663802);
				HigherOrder._RepeatWhile_d__1<T, TOther>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HigherOrder._RepeatWhile_d__1<T, TOther>>.NativeClassPtr, 100663803);
				HigherOrder._RepeatWhile_d__1<T, TOther>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HigherOrder._RepeatWhile_d__1<T, TOther>>.NativeClassPtr, 100663804);
				HigherOrder._RepeatWhile_d__1<T, TOther>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HigherOrder._RepeatWhile_d__1<T, TOther>>.NativeClassPtr, 100663805);
				HigherOrder._RepeatWhile_d__1<T, TOther>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HigherOrder._RepeatWhile_d__1<T, TOther>>.NativeClassPtr, 100663806);
				HigherOrder._RepeatWhile_d__1<T, TOther>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HigherOrder._RepeatWhile_d__1<T, TOther>>.NativeClassPtr, 100663807);
			}

			// Token: 0x06000559 RID: 1369 RVA: 0x00017AD8 File Offset: 0x00015CD8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RepeatWhile_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HigherOrder._RepeatWhile_d__1<T, TOther>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HigherOrder._RepeatWhile_d__1<T, TOther>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600055A RID: 1370 RVA: 0x00017B20 File Offset: 0x00015D20
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HigherOrder._RepeatWhile_d__1<T, TOther>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600055B RID: 1371 RVA: 0x00017B54 File Offset: 0x00015D54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209616, XrefRangeEnd = 1209628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HigherOrder._RepeatWhile_d__1<T, TOther>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000173 RID: 371
			// (get) Token: 0x0600055C RID: 1372 RVA: 0x00017B90 File Offset: 0x00015D90
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HigherOrder._RepeatWhile_d__1<T, TOther>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600055D RID: 1373 RVA: 0x00017BD0 File Offset: 0x00015DD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HigherOrder._RepeatWhile_d__1<T, TOther>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000174 RID: 372
			// (get) Token: 0x0600055E RID: 1374 RVA: 0x00017C04 File Offset: 0x00015E04
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HigherOrder._RepeatWhile_d__1<T, TOther>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600055F RID: 1375 RVA: 0x000045A0 File Offset: 0x000027A0
			public _RepeatWhile_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700016D RID: 365
			// (get) Token: 0x06000560 RID: 1376 RVA: 0x00017C44 File Offset: 0x00015E44
			// (set) Token: 0x06000561 RID: 1377 RVA: 0x000045A9 File Offset: 0x000027A9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HigherOrder._RepeatWhile_d__1<T, TOther>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HigherOrder._RepeatWhile_d__1<T, TOther>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700016E RID: 366
			// (get) Token: 0x06000562 RID: 1378 RVA: 0x00017C6C File Offset: 0x00015E6C
			// (set) Token: 0x06000563 RID: 1379 RVA: 0x000045C4 File Offset: 0x000027C4
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HigherOrder._RepeatWhile_d__1<T, TOther>.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HigherOrder._RepeatWhile_d__1<T, TOther>.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700016F RID: 367
			// (get) Token: 0x06000564 RID: 1380 RVA: 0x00017C9C File Offset: 0x00015E9C
			// (set) Token: 0x06000565 RID: 1381 RVA: 0x000045E3 File Offset: 0x000027E3
			public unsafe Func<T> generator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HigherOrder._RepeatWhile_d__1<T, TOther>.NativeFieldInfoPtr_generator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HigherOrder._RepeatWhile_d__1<T, TOther>.NativeFieldInfoPtr_generator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000170 RID: 368
			// (get) Token: 0x06000566 RID: 1382 RVA: 0x00017CCC File Offset: 0x00015ECC
			// (set) Token: 0x06000567 RID: 1383 RVA: 0x00004602 File Offset: 0x00002802
			public unsafe Func<T, bool> shouldContinue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HigherOrder._RepeatWhile_d__1<T, TOther>.NativeFieldInfoPtr_shouldContinue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HigherOrder._RepeatWhile_d__1<T, TOther>.NativeFieldInfoPtr_shouldContinue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000171 RID: 369
			// (get) Token: 0x06000568 RID: 1384 RVA: 0x00017CFC File Offset: 0x00015EFC
			// (set) Token: 0x06000569 RID: 1385 RVA: 0x00004621 File Offset: 0x00002821
			public unsafe Func<T, TOther> inBetweenGen
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HigherOrder._RepeatWhile_d__1<T, TOther>.NativeFieldInfoPtr_inBetweenGen);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, TOther>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HigherOrder._RepeatWhile_d__1<T, TOther>.NativeFieldInfoPtr_inBetweenGen), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000172 RID: 370
			// (get) Token: 0x0600056A RID: 1386 RVA: 0x00017D2C File Offset: 0x00015F2C
			// (set) Token: 0x0600056B RID: 1387 RVA: 0x00017D54 File Offset: 0x00015F54
			public unsafe T _command_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HigherOrder._RepeatWhile_d__1<T, TOther>.NativeFieldInfoPtr__command_5__2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HigherOrder._RepeatWhile_d__1<T, TOther>.NativeFieldInfoPtr__command_5__2);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x04000343 RID: 835
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000344 RID: 836
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000345 RID: 837
			private static readonly IntPtr NativeFieldInfoPtr_generator;

			// Token: 0x04000346 RID: 838
			private static readonly IntPtr NativeFieldInfoPtr_shouldContinue;

			// Token: 0x04000347 RID: 839
			private static readonly IntPtr NativeFieldInfoPtr_inBetweenGen;

			// Token: 0x04000348 RID: 840
			private static readonly IntPtr NativeFieldInfoPtr__command_5__2;

			// Token: 0x04000349 RID: 841
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400034A RID: 842
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400034B RID: 843
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400034C RID: 844
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400034D RID: 845
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400034E RID: 846
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000091 RID: 145
		private sealed class MethodInfoStoreGeneric_RepeatWhile_Public_Static_IEnumerator_Func_1_T_Func_2_T_Boolean_Func_2_T_TOther_0<T, TOther>
		{
			// Token: 0x0400034F RID: 847
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HigherOrder.NativeMethodInfoPtr_RepeatWhile_Public_Static_IEnumerator_Func_1_T_Func_2_T_Boolean_Func_2_T_TOther_0, Il2CppClassPointerStore<HigherOrder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOther>.NativeClassPtr))
			}))));
		}
	}
}

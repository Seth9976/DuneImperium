using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dwd.core.await
{
	// Token: 0x02000205 RID: 517
	public class AwaiterCommand<T> : Command
	{
		// Token: 0x06001C8C RID: 7308 RVA: 0x00084B24 File Offset: 0x00082D24
		// Note: this type is marked as 'beforefieldinit'.
		static AwaiterCommand()
		{
			Il2CppClassPointerStore<AwaiterCommand<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.await", "AwaiterCommand`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AwaiterCommand<T>>.NativeClassPtr);
			AwaiterCommand<T>.NativeFieldInfoPtr_toAwait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaiterCommand<T>>.NativeClassPtr, "toAwait");
			AwaiterCommand<T>.NativeFieldInfoPtr_awaiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaiterCommand<T>>.NativeClassPtr, "awaiter");
			AwaiterCommand<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerator_SimpleUnitySafeAwaiter_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaiterCommand<T>>.NativeClassPtr, 100667840);
			AwaiterCommand<T>.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaiterCommand<T>>.NativeClassPtr, 100667841);
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x00084BE0 File Offset: 0x00082DE0
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 495165, RefRangeEnd = 495182, XrefRangeStart = 495165, XrefRangeEnd = 495182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AwaiterCommand(IEnumerator toAwait, SimpleUnitySafeAwaiter<T> awaiter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AwaiterCommand<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toAwait);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(awaiter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaiterCommand<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerator_SimpleUnitySafeAwaiter_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x00084C40 File Offset: 0x00082E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AwaiterCommand<T>.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x0000C417 File Offset: 0x0000A617
		public AwaiterCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06001C90 RID: 7312 RVA: 0x00084C8C File Offset: 0x00082E8C
		// (set) Token: 0x06001C91 RID: 7313 RVA: 0x0000C420 File Offset: 0x0000A620
		public unsafe IEnumerator toAwait
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AwaiterCommand<T>.NativeFieldInfoPtr_toAwait);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AwaiterCommand<T>.NativeFieldInfoPtr_toAwait), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06001C92 RID: 7314 RVA: 0x00084CBC File Offset: 0x00082EBC
		// (set) Token: 0x06001C93 RID: 7315 RVA: 0x0000C43F File Offset: 0x0000A63F
		public unsafe SimpleUnitySafeAwaiter<T> awaiter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AwaiterCommand<T>.NativeFieldInfoPtr_awaiter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimpleUnitySafeAwaiter<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AwaiterCommand<T>.NativeFieldInfoPtr_awaiter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001404 RID: 5124
		private static readonly IntPtr NativeFieldInfoPtr_toAwait;

		// Token: 0x04001405 RID: 5125
		private static readonly IntPtr NativeFieldInfoPtr_awaiter;

		// Token: 0x04001406 RID: 5126
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerator_SimpleUnitySafeAwaiter_1_T_0;

		// Token: 0x04001407 RID: 5127
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000391 RID: 913
		[ObfuscatedName("dwd.core.await.AwaiterCommand`1+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x060028E4 RID: 10468 RVA: 0x000ABFBC File Offset: 0x000AA1BC
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<AwaiterCommand<T>._execute_d__3>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AwaiterCommand<T>>.NativeClassPtr, "<execute>d__3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AwaiterCommand<T>._execute_d__3>.NativeClassPtr);
				AwaiterCommand<T>._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaiterCommand<T>._execute_d__3>.NativeClassPtr, "<>1__state");
				AwaiterCommand<T>._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaiterCommand<T>._execute_d__3>.NativeClassPtr, "<>2__current");
				AwaiterCommand<T>._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaiterCommand<T>._execute_d__3>.NativeClassPtr, "<>4__this");
				AwaiterCommand<T>._execute_d__3.NativeFieldInfoPtr__isDone_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaiterCommand<T>._execute_d__3>.NativeClassPtr, "<isDone>5__2");
				AwaiterCommand<T>._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaiterCommand<T>._execute_d__3>.NativeClassPtr, 100667842);
				AwaiterCommand<T>._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaiterCommand<T>._execute_d__3>.NativeClassPtr, 100667843);
				AwaiterCommand<T>._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaiterCommand<T>._execute_d__3>.NativeClassPtr, 100667844);
				AwaiterCommand<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaiterCommand<T>._execute_d__3>.NativeClassPtr, 100667845);
				AwaiterCommand<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaiterCommand<T>._execute_d__3>.NativeClassPtr, 100667846);
				AwaiterCommand<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaiterCommand<T>._execute_d__3>.NativeClassPtr, 100667847);
			}

			// Token: 0x060028E5 RID: 10469 RVA: 0x000AC0EC File Offset: 0x000AA2EC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AwaiterCommand<T>._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaiterCommand<T>._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060028E6 RID: 10470 RVA: 0x000AC134 File Offset: 0x000AA334
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaiterCommand<T>._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060028E7 RID: 10471 RVA: 0x000AC168 File Offset: 0x000AA368
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885629, XrefRangeEnd = 885636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaiterCommand<T>._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000BA0 RID: 2976
			// (get) Token: 0x060028E8 RID: 10472 RVA: 0x000AC1A4 File Offset: 0x000AA3A4
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaiterCommand<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060028E9 RID: 10473 RVA: 0x000AC1E4 File Offset: 0x000AA3E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaiterCommand<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BA1 RID: 2977
			// (get) Token: 0x060028EA RID: 10474 RVA: 0x000AC218 File Offset: 0x000AA418
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaiterCommand<T>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060028EB RID: 10475 RVA: 0x00012963 File Offset: 0x00010B63
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B9C RID: 2972
			// (get) Token: 0x060028EC RID: 10476 RVA: 0x000AC258 File Offset: 0x000AA458
			// (set) Token: 0x060028ED RID: 10477 RVA: 0x0001296C File Offset: 0x00010B6C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AwaiterCommand<T>._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AwaiterCommand<T>._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B9D RID: 2973
			// (get) Token: 0x060028EE RID: 10478 RVA: 0x000AC280 File Offset: 0x000AA480
			// (set) Token: 0x060028EF RID: 10479 RVA: 0x00012987 File Offset: 0x00010B87
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AwaiterCommand<T>._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AwaiterCommand<T>._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B9E RID: 2974
			// (get) Token: 0x060028F0 RID: 10480 RVA: 0x000AC2B0 File Offset: 0x000AA4B0
			// (set) Token: 0x060028F1 RID: 10481 RVA: 0x000129A6 File Offset: 0x00010BA6
			public unsafe AwaiterCommand<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AwaiterCommand<T>._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AwaiterCommand<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AwaiterCommand<T>._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B9F RID: 2975
			// (get) Token: 0x060028F2 RID: 10482 RVA: 0x000AC2E0 File Offset: 0x000AA4E0
			// (set) Token: 0x060028F3 RID: 10483 RVA: 0x000129C5 File Offset: 0x00010BC5
			public unsafe bool _isDone_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AwaiterCommand<T>._execute_d__3.NativeFieldInfoPtr__isDone_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AwaiterCommand<T>._execute_d__3.NativeFieldInfoPtr__isDone_5__2)) = value;
				}
			}

			// Token: 0x04001BB4 RID: 7092
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001BB5 RID: 7093
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001BB6 RID: 7094
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001BB7 RID: 7095
			private static readonly IntPtr NativeFieldInfoPtr__isDone_5__2;

			// Token: 0x04001BB8 RID: 7096
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001BB9 RID: 7097
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001BBA RID: 7098
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001BBB RID: 7099
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001BBC RID: 7100
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001BBD RID: 7101
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

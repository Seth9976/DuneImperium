using System;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions
{
	// Token: 0x020001F3 RID: 499
	public class Swap : Action
	{
		// Token: 0x0600152B RID: 5419 RVA: 0x0006ED0C File Offset: 0x0006CF0C
		// Note: this type is marked as 'beforefieldinit'.
		static Swap()
		{
			Il2CppClassPointerStore<Swap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "Swap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Swap>.NativeClassPtr);
			Swap.NativeFieldInfoPtr_first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Swap>.NativeClassPtr, "first");
			Swap.NativeFieldInfoPtr_second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Swap>.NativeClassPtr, "second");
			Swap.NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Swap>.NativeClassPtr, 100668036);
			Swap.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Swap>.NativeClassPtr, 100668037);
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x0006ED8C File Offset: 0x0006CF8C
		[CallerCount(153)]
		[CachedScanResults(RefRangeStart = 586710, RefRangeEnd = 586863, XrefRangeStart = 586710, XrefRangeEnd = 586863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Swap(Entity first, Entity second, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Swap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(second);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Swap.NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x0006EDFC File Offset: 0x0006CFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590701, XrefRangeEnd = 590707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Swap.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x0000A3AB File Offset: 0x000085AB
		public Swap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x0600152F RID: 5423 RVA: 0x0006EE48 File Offset: 0x0006D048
		// (set) Token: 0x06001530 RID: 5424 RVA: 0x0000A3B4 File Offset: 0x000085B4
		public unsafe Entity first
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Swap.NativeFieldInfoPtr_first);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Swap.NativeFieldInfoPtr_first), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06001531 RID: 5425 RVA: 0x0006EE78 File Offset: 0x0006D078
		// (set) Token: 0x06001532 RID: 5426 RVA: 0x0000A3D3 File Offset: 0x000085D3
		public unsafe Entity second
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Swap.NativeFieldInfoPtr_second);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Swap.NativeFieldInfoPtr_second), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DB1 RID: 3505
		private static readonly IntPtr NativeFieldInfoPtr_first;

		// Token: 0x04000DB2 RID: 3506
		private static readonly IntPtr NativeFieldInfoPtr_second;

		// Token: 0x04000DB3 RID: 3507
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_Match_0;

		// Token: 0x04000DB4 RID: 3508
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x02000438 RID: 1080
		[ObfuscatedName("Canis.actions.Swap+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x06002F7E RID: 12158 RVA: 0x000C632C File Offset: 0x000C452C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<Swap._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Swap>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Swap._execute_d__3>.NativeClassPtr);
				Swap._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Swap._execute_d__3>.NativeClassPtr, "<>1__state");
				Swap._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Swap._execute_d__3>.NativeClassPtr, "<>2__current");
				Swap._execute_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Swap._execute_d__3>.NativeClassPtr, "<>l__initialThreadId");
				Swap._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Swap._execute_d__3>.NativeClassPtr, "<>4__this");
				Swap._execute_d__3.NativeFieldInfoPtr__firstParent_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Swap._execute_d__3>.NativeClassPtr, "<firstParent>5__2");
				Swap._execute_d__3.NativeFieldInfoPtr__firstIdx_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Swap._execute_d__3>.NativeClassPtr, "<firstIdx>5__3");
				Swap._execute_d__3.NativeFieldInfoPtr__secondParent_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Swap._execute_d__3>.NativeClassPtr, "<secondParent>5__4");
				Swap._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Swap._execute_d__3>.NativeClassPtr, 100668038);
				Swap._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Swap._execute_d__3>.NativeClassPtr, 100668039);
				Swap._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Swap._execute_d__3>.NativeClassPtr, 100668040);
				Swap._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Swap._execute_d__3>.NativeClassPtr, 100668041);
				Swap._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Swap._execute_d__3>.NativeClassPtr, 100668042);
				Swap._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Swap._execute_d__3>.NativeClassPtr, 100668043);
				Swap._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Swap._execute_d__3>.NativeClassPtr, 100668044);
				Swap._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Swap._execute_d__3>.NativeClassPtr, 100668045);
			}

			// Token: 0x06002F7F RID: 12159 RVA: 0x000C6484 File Offset: 0x000C4684
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Swap._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Swap._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F80 RID: 12160 RVA: 0x000C64CC File Offset: 0x000C46CC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Swap._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F81 RID: 12161 RVA: 0x000C6500 File Offset: 0x000C4700
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590659, XrefRangeEnd = 590694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Swap._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000C6A RID: 3178
			// (get) Token: 0x06002F82 RID: 12162 RVA: 0x000C653C File Offset: 0x000C473C
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Swap._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002F83 RID: 12163 RVA: 0x000C657C File Offset: 0x000C477C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590694, XrefRangeEnd = 590699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Swap._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C6B RID: 3179
			// (get) Token: 0x06002F84 RID: 12164 RVA: 0x000C65B0 File Offset: 0x000C47B0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Swap._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002F85 RID: 12165 RVA: 0x000C65F0 File Offset: 0x000C47F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590699, XrefRangeEnd = 590701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Swap._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06002F86 RID: 12166 RVA: 0x000C6630 File Offset: 0x000C4830
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Swap._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002F87 RID: 12167 RVA: 0x00016B28 File Offset: 0x00014D28
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C63 RID: 3171
			// (get) Token: 0x06002F88 RID: 12168 RVA: 0x000C6670 File Offset: 0x000C4870
			// (set) Token: 0x06002F89 RID: 12169 RVA: 0x00016B31 File Offset: 0x00014D31
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Swap._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Swap._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C64 RID: 3172
			// (get) Token: 0x06002F8A RID: 12170 RVA: 0x000C6698 File Offset: 0x000C4898
			// (set) Token: 0x06002F8B RID: 12171 RVA: 0x00016B4C File Offset: 0x00014D4C
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Swap._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Swap._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C65 RID: 3173
			// (get) Token: 0x06002F8C RID: 12172 RVA: 0x000C66C8 File Offset: 0x000C48C8
			// (set) Token: 0x06002F8D RID: 12173 RVA: 0x00016B6B File Offset: 0x00014D6B
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Swap._execute_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Swap._execute_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000C66 RID: 3174
			// (get) Token: 0x06002F8E RID: 12174 RVA: 0x000C66F0 File Offset: 0x000C48F0
			// (set) Token: 0x06002F8F RID: 12175 RVA: 0x00016B86 File Offset: 0x00014D86
			public unsafe Swap __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Swap._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Swap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Swap._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C67 RID: 3175
			// (get) Token: 0x06002F90 RID: 12176 RVA: 0x000C6720 File Offset: 0x000C4920
			// (set) Token: 0x06002F91 RID: 12177 RVA: 0x00016BA5 File Offset: 0x00014DA5
			public unsafe Entity _firstParent_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Swap._execute_d__3.NativeFieldInfoPtr__firstParent_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Swap._execute_d__3.NativeFieldInfoPtr__firstParent_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C68 RID: 3176
			// (get) Token: 0x06002F92 RID: 12178 RVA: 0x000C6750 File Offset: 0x000C4950
			// (set) Token: 0x06002F93 RID: 12179 RVA: 0x00016BC4 File Offset: 0x00014DC4
			public unsafe int _firstIdx_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Swap._execute_d__3.NativeFieldInfoPtr__firstIdx_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Swap._execute_d__3.NativeFieldInfoPtr__firstIdx_5__3)) = value;
				}
			}

			// Token: 0x17000C69 RID: 3177
			// (get) Token: 0x06002F94 RID: 12180 RVA: 0x000C6778 File Offset: 0x000C4978
			// (set) Token: 0x06002F95 RID: 12181 RVA: 0x00016BDF File Offset: 0x00014DDF
			public unsafe Entity _secondParent_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Swap._execute_d__3.NativeFieldInfoPtr__secondParent_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Swap._execute_d__3.NativeFieldInfoPtr__secondParent_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001DB9 RID: 7609
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001DBA RID: 7610
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001DBB RID: 7611
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001DBC RID: 7612
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001DBD RID: 7613
			private static readonly IntPtr NativeFieldInfoPtr__firstParent_5__2;

			// Token: 0x04001DBE RID: 7614
			private static readonly IntPtr NativeFieldInfoPtr__firstIdx_5__3;

			// Token: 0x04001DBF RID: 7615
			private static readonly IntPtr NativeFieldInfoPtr__secondParent_5__4;

			// Token: 0x04001DC0 RID: 7616
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001DC1 RID: 7617
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001DC2 RID: 7618
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001DC3 RID: 7619
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001DC4 RID: 7620
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001DC5 RID: 7621
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001DC6 RID: 7622
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001DC7 RID: 7623
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

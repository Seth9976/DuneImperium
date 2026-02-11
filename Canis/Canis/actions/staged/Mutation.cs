using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions.staged
{
	// Token: 0x02000208 RID: 520
	public class Mutation : Staging
	{
		// Token: 0x06001608 RID: 5640 RVA: 0x00071E0C File Offset: 0x0007000C
		// Note: this type is marked as 'beforefieldinit'.
		static Mutation()
		{
			Il2CppClassPointerStore<Mutation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.staged", "Mutation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mutation>.NativeClassPtr);
			Mutation.NativeFieldInfoPtr_Mutate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mutation>.NativeClassPtr, "Mutate");
			Mutation.NativeMethodInfoPtr__ctor_Public_Void_Mutate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mutation>.NativeClassPtr, 100668293);
			Mutation.NativeMethodInfoPtr_Apply_Public_Virtual_Final_IEnumerable_1_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mutation>.NativeClassPtr, 100668294);
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x00071E78 File Offset: 0x00070078
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Mutation(Mutate mutate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Mutation>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mutate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mutation.NativeMethodInfoPtr__ctor_Public_Void_Mutate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x00071EC4 File Offset: 0x000700C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 592873, XrefRangeEnd = 592880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> Apply(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mutation.NativeMethodInfoPtr_Apply_Public_Virtual_Final_IEnumerable_1_Action_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
			}
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x0000AA89 File Offset: 0x00008C89
		public Mutation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x0600160C RID: 5644 RVA: 0x00071F14 File Offset: 0x00070114
		// (set) Token: 0x0600160D RID: 5645 RVA: 0x0000AA92 File Offset: 0x00008C92
		public unsafe Mutate Mutate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mutation.NativeFieldInfoPtr_Mutate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mutate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mutation.NativeFieldInfoPtr_Mutate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E31 RID: 3633
		private static readonly IntPtr NativeFieldInfoPtr_Mutate;

		// Token: 0x04000E32 RID: 3634
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Mutate_0;

		// Token: 0x04000E33 RID: 3635
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_Final_IEnumerable_1_Action_Match_0;

		// Token: 0x02000457 RID: 1111
		[ObfuscatedName("Canis.actions.staged.Mutation+<Apply>d__2")]
		public sealed class _Apply_d__2 : Object
		{
			// Token: 0x06003156 RID: 12630 RVA: 0x000CC0B8 File Offset: 0x000CA2B8
			// Note: this type is marked as 'beforefieldinit'.
			static _Apply_d__2()
			{
				Il2CppClassPointerStore<Mutation._Apply_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Mutation>.NativeClassPtr, "<Apply>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mutation._Apply_d__2>.NativeClassPtr);
				Mutation._Apply_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mutation._Apply_d__2>.NativeClassPtr, "<>1__state");
				Mutation._Apply_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mutation._Apply_d__2>.NativeClassPtr, "<>2__current");
				Mutation._Apply_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mutation._Apply_d__2>.NativeClassPtr, "<>l__initialThreadId");
				Mutation._Apply_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mutation._Apply_d__2>.NativeClassPtr, "<>4__this");
				Mutation._Apply_d__2.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mutation._Apply_d__2>.NativeClassPtr, "match");
				Mutation._Apply_d__2.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mutation._Apply_d__2>.NativeClassPtr, "<>3__match");
				Mutation._Apply_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mutation._Apply_d__2>.NativeClassPtr, 100668295);
				Mutation._Apply_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mutation._Apply_d__2>.NativeClassPtr, 100668296);
				Mutation._Apply_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mutation._Apply_d__2>.NativeClassPtr, 100668297);
				Mutation._Apply_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mutation._Apply_d__2>.NativeClassPtr, 100668298);
				Mutation._Apply_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mutation._Apply_d__2>.NativeClassPtr, 100668299);
				Mutation._Apply_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mutation._Apply_d__2>.NativeClassPtr, 100668300);
				Mutation._Apply_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mutation._Apply_d__2>.NativeClassPtr, 100668301);
				Mutation._Apply_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mutation._Apply_d__2>.NativeClassPtr, 100668302);
			}

			// Token: 0x06003157 RID: 12631 RVA: 0x000CC1FC File Offset: 0x000CA3FC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Apply_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Mutation._Apply_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mutation._Apply_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003158 RID: 12632 RVA: 0x000CC244 File Offset: 0x000CA444
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mutation._Apply_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003159 RID: 12633 RVA: 0x000CC278 File Offset: 0x000CA478
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mutation._Apply_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D01 RID: 3329
			// (get) Token: 0x0600315A RID: 12634 RVA: 0x000CC2B4 File Offset: 0x000CA4B4
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mutation._Apply_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600315B RID: 12635 RVA: 0x000CC2F4 File Offset: 0x000CA4F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 592859, XrefRangeEnd = 592864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mutation._Apply_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D02 RID: 3330
			// (get) Token: 0x0600315C RID: 12636 RVA: 0x000CC328 File Offset: 0x000CA528
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mutation._Apply_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600315D RID: 12637 RVA: 0x000CC368 File Offset: 0x000CA568
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 592864, XrefRangeEnd = 592873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mutation._Apply_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x0600315E RID: 12638 RVA: 0x000CC3A8 File Offset: 0x000CA5A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mutation._Apply_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600315F RID: 12639 RVA: 0x0001795C File Offset: 0x00015B5C
			public _Apply_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CFB RID: 3323
			// (get) Token: 0x06003160 RID: 12640 RVA: 0x000CC3E8 File Offset: 0x000CA5E8
			// (set) Token: 0x06003161 RID: 12641 RVA: 0x00017965 File Offset: 0x00015B65
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mutation._Apply_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mutation._Apply_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000CFC RID: 3324
			// (get) Token: 0x06003162 RID: 12642 RVA: 0x000CC410 File Offset: 0x000CA610
			// (set) Token: 0x06003163 RID: 12643 RVA: 0x00017980 File Offset: 0x00015B80
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mutation._Apply_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mutation._Apply_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CFD RID: 3325
			// (get) Token: 0x06003164 RID: 12644 RVA: 0x000CC440 File Offset: 0x000CA640
			// (set) Token: 0x06003165 RID: 12645 RVA: 0x0001799F File Offset: 0x00015B9F
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mutation._Apply_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mutation._Apply_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000CFE RID: 3326
			// (get) Token: 0x06003166 RID: 12646 RVA: 0x000CC468 File Offset: 0x000CA668
			// (set) Token: 0x06003167 RID: 12647 RVA: 0x000179BA File Offset: 0x00015BBA
			public unsafe Mutation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mutation._Apply_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mutation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mutation._Apply_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CFF RID: 3327
			// (get) Token: 0x06003168 RID: 12648 RVA: 0x000CC498 File Offset: 0x000CA698
			// (set) Token: 0x06003169 RID: 12649 RVA: 0x000179D9 File Offset: 0x00015BD9
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mutation._Apply_d__2.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mutation._Apply_d__2.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D00 RID: 3328
			// (get) Token: 0x0600316A RID: 12650 RVA: 0x000CC4C8 File Offset: 0x000CA6C8
			// (set) Token: 0x0600316B RID: 12651 RVA: 0x000179F8 File Offset: 0x00015BF8
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mutation._Apply_d__2.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mutation._Apply_d__2.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001EDF RID: 7903
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001EE0 RID: 7904
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001EE1 RID: 7905
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001EE2 RID: 7906
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001EE3 RID: 7907
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04001EE4 RID: 7908
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04001EE5 RID: 7909
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001EE6 RID: 7910
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001EE7 RID: 7911
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001EE8 RID: 7912
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001EE9 RID: 7913
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001EEA RID: 7914
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001EEB RID: 7915
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001EEC RID: 7916
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

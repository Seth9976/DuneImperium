using System;
using Canis.context;
using Canis.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions.components
{
	// Token: 0x02000230 RID: 560
	public class FireEventComponent : ActionComponent
	{
		// Token: 0x06001759 RID: 5977 RVA: 0x00076FBC File Offset: 0x000751BC
		// Note: this type is marked as 'beforefieldinit'.
		static FireEventComponent()
		{
			Il2CppClassPointerStore<FireEventComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.components", "FireEventComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FireEventComponent>.NativeClassPtr);
			FireEventComponent.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireEventComponent>.NativeClassPtr, "evt");
			FireEventComponent.NativeFieldInfoPtr_eventContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireEventComponent>.NativeClassPtr, "eventContext");
			FireEventComponent.NativeMethodInfoPtr__ctor_Public_Void_Int32_Event_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FireEventComponent>.NativeClassPtr, 100668614);
			FireEventComponent.NativeMethodInfoPtr_Do_Public_Virtual_IEnumerable_1_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FireEventComponent>.NativeClassPtr, 100668615);
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x0007703C File Offset: 0x0007523C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 425621, RefRangeEnd = 425634, XrefRangeStart = 425621, XrefRangeEnd = 425634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FireEventComponent(int sortOrder, Event evt, Context eventContext = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FireEventComponent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sortOrder;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FireEventComponent.NativeMethodInfoPtr__ctor_Public_Void_Int32_Event_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x000770A8 File Offset: 0x000752A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595209, XrefRangeEnd = 595216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> Do(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FireEventComponent.NativeMethodInfoPtr_Do_Public_Virtual_IEnumerable_1_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
			}
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x0000B28F File Offset: 0x0000948F
		public FireEventComponent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x0600175D RID: 5981 RVA: 0x00077104 File Offset: 0x00075304
		// (set) Token: 0x0600175E RID: 5982 RVA: 0x0000B298 File Offset: 0x00009498
		public unsafe Event evt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireEventComponent.NativeFieldInfoPtr_evt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Event>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireEventComponent.NativeFieldInfoPtr_evt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x0600175F RID: 5983 RVA: 0x00077134 File Offset: 0x00075334
		// (set) Token: 0x06001760 RID: 5984 RVA: 0x0000B2B7 File Offset: 0x000094B7
		public unsafe Context eventContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireEventComponent.NativeFieldInfoPtr_eventContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireEventComponent.NativeFieldInfoPtr_eventContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EFA RID: 3834
		private static readonly IntPtr NativeFieldInfoPtr_evt;

		// Token: 0x04000EFB RID: 3835
		private static readonly IntPtr NativeFieldInfoPtr_eventContext;

		// Token: 0x04000EFC RID: 3836
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Event_Context_0;

		// Token: 0x04000EFD RID: 3837
		private static readonly IntPtr NativeMethodInfoPtr_Do_Public_Virtual_IEnumerable_1_Action_Match_0;

		// Token: 0x02000479 RID: 1145
		[ObfuscatedName("Canis.actions.components.FireEventComponent+<Do>d__3")]
		public sealed class _Do_d__3 : Object
		{
			// Token: 0x06003359 RID: 13145 RVA: 0x000D201C File Offset: 0x000D021C
			// Note: this type is marked as 'beforefieldinit'.
			static _Do_d__3()
			{
				Il2CppClassPointerStore<FireEventComponent._Do_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FireEventComponent>.NativeClassPtr, "<Do>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FireEventComponent._Do_d__3>.NativeClassPtr);
				FireEventComponent._Do_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireEventComponent._Do_d__3>.NativeClassPtr, "<>1__state");
				FireEventComponent._Do_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireEventComponent._Do_d__3>.NativeClassPtr, "<>2__current");
				FireEventComponent._Do_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireEventComponent._Do_d__3>.NativeClassPtr, "<>l__initialThreadId");
				FireEventComponent._Do_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireEventComponent._Do_d__3>.NativeClassPtr, "<>4__this");
				FireEventComponent._Do_d__3.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireEventComponent._Do_d__3>.NativeClassPtr, "match");
				FireEventComponent._Do_d__3.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireEventComponent._Do_d__3>.NativeClassPtr, "<>3__match");
				FireEventComponent._Do_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FireEventComponent._Do_d__3>.NativeClassPtr, 100668616);
				FireEventComponent._Do_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FireEventComponent._Do_d__3>.NativeClassPtr, 100668617);
				FireEventComponent._Do_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FireEventComponent._Do_d__3>.NativeClassPtr, 100668618);
				FireEventComponent._Do_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FireEventComponent._Do_d__3>.NativeClassPtr, 100668619);
				FireEventComponent._Do_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FireEventComponent._Do_d__3>.NativeClassPtr, 100668620);
				FireEventComponent._Do_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FireEventComponent._Do_d__3>.NativeClassPtr, 100668621);
				FireEventComponent._Do_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FireEventComponent._Do_d__3>.NativeClassPtr, 100668622);
				FireEventComponent._Do_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FireEventComponent._Do_d__3>.NativeClassPtr, 100668623);
			}

			// Token: 0x0600335A RID: 13146 RVA: 0x000D2160 File Offset: 0x000D0360
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Do_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FireEventComponent._Do_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FireEventComponent._Do_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600335B RID: 13147 RVA: 0x000D21A8 File Offset: 0x000D03A8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FireEventComponent._Do_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600335C RID: 13148 RVA: 0x000D21DC File Offset: 0x000D03DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595190, XrefRangeEnd = 595195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FireEventComponent._Do_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000DAC RID: 3500
			// (get) Token: 0x0600335D RID: 13149 RVA: 0x000D2218 File Offset: 0x000D0418
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FireEventComponent._Do_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600335E RID: 13150 RVA: 0x000D2258 File Offset: 0x000D0458
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595195, XrefRangeEnd = 595200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FireEventComponent._Do_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000DAD RID: 3501
			// (get) Token: 0x0600335F RID: 13151 RVA: 0x000D228C File Offset: 0x000D048C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FireEventComponent._Do_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003360 RID: 13152 RVA: 0x000D22CC File Offset: 0x000D04CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595200, XrefRangeEnd = 595209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FireEventComponent._Do_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06003361 RID: 13153 RVA: 0x000D230C File Offset: 0x000D050C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FireEventComponent._Do_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06003362 RID: 13154 RVA: 0x00018AA2 File Offset: 0x00016CA2
			public _Do_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DA6 RID: 3494
			// (get) Token: 0x06003363 RID: 13155 RVA: 0x000D234C File Offset: 0x000D054C
			// (set) Token: 0x06003364 RID: 13156 RVA: 0x00018AAB File Offset: 0x00016CAB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireEventComponent._Do_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireEventComponent._Do_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000DA7 RID: 3495
			// (get) Token: 0x06003365 RID: 13157 RVA: 0x000D2374 File Offset: 0x000D0574
			// (set) Token: 0x06003366 RID: 13158 RVA: 0x00018AC6 File Offset: 0x00016CC6
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireEventComponent._Do_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireEventComponent._Do_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DA8 RID: 3496
			// (get) Token: 0x06003367 RID: 13159 RVA: 0x000D23A4 File Offset: 0x000D05A4
			// (set) Token: 0x06003368 RID: 13160 RVA: 0x00018AE5 File Offset: 0x00016CE5
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireEventComponent._Do_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireEventComponent._Do_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000DA9 RID: 3497
			// (get) Token: 0x06003369 RID: 13161 RVA: 0x000D23CC File Offset: 0x000D05CC
			// (set) Token: 0x0600336A RID: 13162 RVA: 0x00018B00 File Offset: 0x00016D00
			public unsafe FireEventComponent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireEventComponent._Do_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FireEventComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireEventComponent._Do_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DAA RID: 3498
			// (get) Token: 0x0600336B RID: 13163 RVA: 0x000D23FC File Offset: 0x000D05FC
			// (set) Token: 0x0600336C RID: 13164 RVA: 0x00018B1F File Offset: 0x00016D1F
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireEventComponent._Do_d__3.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireEventComponent._Do_d__3.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DAB RID: 3499
			// (get) Token: 0x0600336D RID: 13165 RVA: 0x000D242C File Offset: 0x000D062C
			// (set) Token: 0x0600336E RID: 13166 RVA: 0x00018B3E File Offset: 0x00016D3E
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireEventComponent._Do_d__3.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireEventComponent._Do_d__3.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002011 RID: 8209
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002012 RID: 8210
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002013 RID: 8211
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002014 RID: 8212
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002015 RID: 8213
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04002016 RID: 8214
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04002017 RID: 8215
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002018 RID: 8216
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002019 RID: 8217
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400201A RID: 8218
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400201B RID: 8219
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400201C RID: 8220
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400201D RID: 8221
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x0400201E RID: 8222
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

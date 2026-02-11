using System;
using Canis.attributes;
using dwd.core.match.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.Events;
using worm.canis.data.enums;

namespace worm.match.dataRenderers
{
	// Token: 0x020000F1 RID: 241
	public class EventsForEnabledSets : VersionedView<IAttribute<Il2CppStructArray<Set>>>
	{
		// Token: 0x06000AA2 RID: 2722 RVA: 0x00038758 File Offset: 0x00036958
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForEnabledSets()
		{
			Il2CppClassPointerStore<EventsForEnabledSets>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "EventsForEnabledSets");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForEnabledSets>.NativeClassPtr);
			EventsForEnabledSets.NativeFieldInfoPtr_events = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForEnabledSets>.NativeClassPtr, "events");
			EventsForEnabledSets.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForEnabledSets>.NativeClassPtr, 100664758);
			EventsForEnabledSets.NativeMethodInfoPtr_Init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForEnabledSets>.NativeClassPtr, 100664759);
			EventsForEnabledSets.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForEnabledSets>.NativeClassPtr, 100664760);
			EventsForEnabledSets.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForEnabledSets>.NativeClassPtr, 100664761);
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x000387EC File Offset: 0x000369EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701815, XrefRangeEnd = 701824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventsForEnabledSets.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x00038828 File Offset: 0x00036A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701824, XrefRangeEnd = 701829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForEnabledSets.NativeMethodInfoPtr_Init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x00038868 File Offset: 0x00036A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701829, XrefRangeEnd = 701845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventsForEnabledSets.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x000388A4 File Offset: 0x00036AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701845, XrefRangeEnd = 701852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForEnabledSets()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForEnabledSets>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForEnabledSets.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x000078E9 File Offset: 0x00005AE9
		public EventsForEnabledSets(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x000388E0 File Offset: 0x00036AE0
		// (set) Token: 0x06000AA9 RID: 2729 RVA: 0x000078F2 File Offset: 0x00005AF2
		public unsafe Il2CppReferenceArray<EventsForEnabledSets.SetsEvent> events
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForEnabledSets.NativeFieldInfoPtr_events);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EventsForEnabledSets.SetsEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForEnabledSets.NativeFieldInfoPtr_events), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000624 RID: 1572
		private static readonly IntPtr NativeFieldInfoPtr_events;

		// Token: 0x04000625 RID: 1573
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000626 RID: 1574
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_IEnumerator_0;

		// Token: 0x04000627 RID: 1575
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000628 RID: 1576
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000352 RID: 850
		[Serializable]
		public class SetsEvent : Object
		{
			// Token: 0x0600225C RID: 8796 RVA: 0x00080884 File Offset: 0x0007EA84
			// Note: this type is marked as 'beforefieldinit'.
			static SetsEvent()
			{
				Il2CppClassPointerStore<EventsForEnabledSets.SetsEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventsForEnabledSets>.NativeClassPtr, "SetsEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForEnabledSets.SetsEvent>.NativeClassPtr);
				EventsForEnabledSets.SetsEvent.NativeFieldInfoPtr_sets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForEnabledSets.SetsEvent>.NativeClassPtr, "sets");
				EventsForEnabledSets.SetsEvent.NativeFieldInfoPtr_onMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForEnabledSets.SetsEvent>.NativeClassPtr, "onMatch");
				EventsForEnabledSets.SetsEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForEnabledSets.SetsEvent>.NativeClassPtr, 100664762);
			}

			// Token: 0x0600225D RID: 8797 RVA: 0x000808EC File Offset: 0x0007EAEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701792, XrefRangeEnd = 701802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetsEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForEnabledSets.SetsEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForEnabledSets.SetsEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600225E RID: 8798 RVA: 0x00013420 File Offset: 0x00011620
			public SetsEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700097A RID: 2426
			// (get) Token: 0x0600225F RID: 8799 RVA: 0x00080928 File Offset: 0x0007EB28
			// (set) Token: 0x06002260 RID: 8800 RVA: 0x00013429 File Offset: 0x00011629
			public unsafe Il2CppStructArray<Set> sets
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForEnabledSets.SetsEvent.NativeFieldInfoPtr_sets);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Set>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForEnabledSets.SetsEvent.NativeFieldInfoPtr_sets), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700097B RID: 2427
			// (get) Token: 0x06002261 RID: 8801 RVA: 0x00080958 File Offset: 0x0007EB58
			// (set) Token: 0x06002262 RID: 8802 RVA: 0x00013448 File Offset: 0x00011648
			public unsafe UnityEvent onMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForEnabledSets.SetsEvent.NativeFieldInfoPtr_onMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForEnabledSets.SetsEvent.NativeFieldInfoPtr_onMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013C6 RID: 5062
			private static readonly IntPtr NativeFieldInfoPtr_sets;

			// Token: 0x040013C7 RID: 5063
			private static readonly IntPtr NativeFieldInfoPtr_onMatch;

			// Token: 0x040013C8 RID: 5064
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000353 RID: 851
		[ObfuscatedName("worm.match.dataRenderers.EventsForEnabledSets+<Init>d__3")]
		public sealed class _Init_d__3 : Object
		{
			// Token: 0x06002263 RID: 8803 RVA: 0x00080988 File Offset: 0x0007EB88
			// Note: this type is marked as 'beforefieldinit'.
			static _Init_d__3()
			{
				Il2CppClassPointerStore<EventsForEnabledSets._Init_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventsForEnabledSets>.NativeClassPtr, "<Init>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForEnabledSets._Init_d__3>.NativeClassPtr);
				EventsForEnabledSets._Init_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForEnabledSets._Init_d__3>.NativeClassPtr, "<>1__state");
				EventsForEnabledSets._Init_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForEnabledSets._Init_d__3>.NativeClassPtr, "<>2__current");
				EventsForEnabledSets._Init_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForEnabledSets._Init_d__3>.NativeClassPtr, "<>4__this");
				EventsForEnabledSets._Init_d__3.NativeFieldInfoPtr__entitiesProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForEnabledSets._Init_d__3>.NativeClassPtr, "<entitiesProvider>5__2");
				EventsForEnabledSets._Init_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForEnabledSets._Init_d__3>.NativeClassPtr, 100664763);
				EventsForEnabledSets._Init_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForEnabledSets._Init_d__3>.NativeClassPtr, 100664764);
				EventsForEnabledSets._Init_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForEnabledSets._Init_d__3>.NativeClassPtr, 100664765);
				EventsForEnabledSets._Init_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForEnabledSets._Init_d__3>.NativeClassPtr, 100664766);
				EventsForEnabledSets._Init_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForEnabledSets._Init_d__3>.NativeClassPtr, 100664767);
				EventsForEnabledSets._Init_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForEnabledSets._Init_d__3>.NativeClassPtr, 100664768);
			}

			// Token: 0x06002264 RID: 8804 RVA: 0x00080A7C File Offset: 0x0007EC7C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Init_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForEnabledSets._Init_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForEnabledSets._Init_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002265 RID: 8805 RVA: 0x00080AC4 File Offset: 0x0007ECC4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForEnabledSets._Init_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002266 RID: 8806 RVA: 0x00080AF8 File Offset: 0x0007ECF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701802, XrefRangeEnd = 701810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForEnabledSets._Init_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000980 RID: 2432
			// (get) Token: 0x06002267 RID: 8807 RVA: 0x00080B34 File Offset: 0x0007ED34
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForEnabledSets._Init_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002268 RID: 8808 RVA: 0x00080B74 File Offset: 0x0007ED74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701810, XrefRangeEnd = 701815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForEnabledSets._Init_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000981 RID: 2433
			// (get) Token: 0x06002269 RID: 8809 RVA: 0x00080BA8 File Offset: 0x0007EDA8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForEnabledSets._Init_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600226A RID: 8810 RVA: 0x00013467 File Offset: 0x00011667
			public _Init_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700097C RID: 2428
			// (get) Token: 0x0600226B RID: 8811 RVA: 0x00080BE8 File Offset: 0x0007EDE8
			// (set) Token: 0x0600226C RID: 8812 RVA: 0x00013470 File Offset: 0x00011670
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForEnabledSets._Init_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForEnabledSets._Init_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700097D RID: 2429
			// (get) Token: 0x0600226D RID: 8813 RVA: 0x00080C10 File Offset: 0x0007EE10
			// (set) Token: 0x0600226E RID: 8814 RVA: 0x0001348B File Offset: 0x0001168B
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForEnabledSets._Init_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForEnabledSets._Init_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700097E RID: 2430
			// (get) Token: 0x0600226F RID: 8815 RVA: 0x00080C40 File Offset: 0x0007EE40
			// (set) Token: 0x06002270 RID: 8816 RVA: 0x000134AA File Offset: 0x000116AA
			public unsafe EventsForEnabledSets __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForEnabledSets._Init_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventsForEnabledSets>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForEnabledSets._Init_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700097F RID: 2431
			// (get) Token: 0x06002271 RID: 8817 RVA: 0x00080C70 File Offset: 0x0007EE70
			// (set) Token: 0x06002272 RID: 8818 RVA: 0x000134C9 File Offset: 0x000116C9
			public unsafe EntitiesProvider _entitiesProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForEnabledSets._Init_d__3.NativeFieldInfoPtr__entitiesProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForEnabledSets._Init_d__3.NativeFieldInfoPtr__entitiesProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013C9 RID: 5065
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040013CA RID: 5066
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040013CB RID: 5067
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040013CC RID: 5068
			private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__2;

			// Token: 0x040013CD RID: 5069
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040013CE RID: 5070
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040013CF RID: 5071
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040013D0 RID: 5072
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040013D1 RID: 5073
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040013D2 RID: 5074
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

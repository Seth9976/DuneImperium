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
	// Token: 0x0200011F RID: 287
	public class WormEventsForSet : VersionedView<IAttribute<Il2CppStructArray<Set>>>
	{
		// Token: 0x06000D20 RID: 3360 RVA: 0x0003FEC8 File Offset: 0x0003E0C8
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventsForSet()
		{
			Il2CppClassPointerStore<WormEventsForSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormEventsForSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsForSet>.NativeClassPtr);
			WormEventsForSet.NativeFieldInfoPtr_set = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForSet>.NativeClassPtr, "set");
			WormEventsForSet.NativeFieldInfoPtr_onSetEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForSet>.NativeClassPtr, "onSetEnabled");
			WormEventsForSet.NativeFieldInfoPtr_onSetDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForSet>.NativeClassPtr, "onSetDisabled");
			WormEventsForSet.NativeFieldInfoPtr_onSetDisabledStrict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForSet>.NativeClassPtr, "onSetDisabledStrict");
			WormEventsForSet.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForSet>.NativeClassPtr, 100665090);
			WormEventsForSet.NativeMethodInfoPtr_Init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForSet>.NativeClassPtr, 100665091);
			WormEventsForSet.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForSet>.NativeClassPtr, 100665092);
			WormEventsForSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForSet>.NativeClassPtr, 100665093);
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x0003FF98 File Offset: 0x0003E198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705314, XrefRangeEnd = 705323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventsForSet.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x0003FFD4 File Offset: 0x0003E1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705323, XrefRangeEnd = 705328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForSet.NativeMethodInfoPtr_Init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x00040014 File Offset: 0x0003E214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705328, XrefRangeEnd = 705340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventsForSet.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x00040050 File Offset: 0x0003E250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705340, XrefRangeEnd = 705356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventsForSet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsForSet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x00008F07 File Offset: 0x00007107
		public WormEventsForSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000D26 RID: 3366 RVA: 0x0004008C File Offset: 0x0003E28C
		// (set) Token: 0x06000D27 RID: 3367 RVA: 0x00008F10 File Offset: 0x00007110
		public unsafe Set set
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForSet.NativeFieldInfoPtr_set);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForSet.NativeFieldInfoPtr_set)) = value;
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000D28 RID: 3368 RVA: 0x000400B4 File Offset: 0x0003E2B4
		// (set) Token: 0x06000D29 RID: 3369 RVA: 0x00008F2B File Offset: 0x0000712B
		public unsafe UnityEvent onSetEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForSet.NativeFieldInfoPtr_onSetEnabled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForSet.NativeFieldInfoPtr_onSetEnabled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000D2A RID: 3370 RVA: 0x000400E4 File Offset: 0x0003E2E4
		// (set) Token: 0x06000D2B RID: 3371 RVA: 0x00008F4A File Offset: 0x0000714A
		public unsafe UnityEvent onSetDisabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForSet.NativeFieldInfoPtr_onSetDisabled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForSet.NativeFieldInfoPtr_onSetDisabled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000D2C RID: 3372 RVA: 0x00040114 File Offset: 0x0003E314
		// (set) Token: 0x06000D2D RID: 3373 RVA: 0x00008F69 File Offset: 0x00007169
		public unsafe UnityEvent onSetDisabledStrict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForSet.NativeFieldInfoPtr_onSetDisabledStrict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForSet.NativeFieldInfoPtr_onSetDisabledStrict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400079B RID: 1947
		private static readonly IntPtr NativeFieldInfoPtr_set;

		// Token: 0x0400079C RID: 1948
		private static readonly IntPtr NativeFieldInfoPtr_onSetEnabled;

		// Token: 0x0400079D RID: 1949
		private static readonly IntPtr NativeFieldInfoPtr_onSetDisabled;

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeFieldInfoPtr_onSetDisabledStrict;

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040007A0 RID: 1952
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_IEnumerator_0;

		// Token: 0x040007A1 RID: 1953
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200037F RID: 895
		[ObfuscatedName("worm.match.dataRenderers.WormEventsForSet+<Init>d__5")]
		public sealed class _Init_d__5 : Object
		{
			// Token: 0x060023FE RID: 9214 RVA: 0x0008517C File Offset: 0x0008337C
			// Note: this type is marked as 'beforefieldinit'.
			static _Init_d__5()
			{
				Il2CppClassPointerStore<WormEventsForSet._Init_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEventsForSet>.NativeClassPtr, "<Init>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsForSet._Init_d__5>.NativeClassPtr);
				WormEventsForSet._Init_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForSet._Init_d__5>.NativeClassPtr, "<>1__state");
				WormEventsForSet._Init_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForSet._Init_d__5>.NativeClassPtr, "<>2__current");
				WormEventsForSet._Init_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForSet._Init_d__5>.NativeClassPtr, "<>4__this");
				WormEventsForSet._Init_d__5.NativeFieldInfoPtr__entitiesProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForSet._Init_d__5>.NativeClassPtr, "<entitiesProvider>5__2");
				WormEventsForSet._Init_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForSet._Init_d__5>.NativeClassPtr, 100665094);
				WormEventsForSet._Init_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForSet._Init_d__5>.NativeClassPtr, 100665095);
				WormEventsForSet._Init_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForSet._Init_d__5>.NativeClassPtr, 100665096);
				WormEventsForSet._Init_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForSet._Init_d__5>.NativeClassPtr, 100665097);
				WormEventsForSet._Init_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForSet._Init_d__5>.NativeClassPtr, 100665098);
				WormEventsForSet._Init_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForSet._Init_d__5>.NativeClassPtr, 100665099);
			}

			// Token: 0x060023FF RID: 9215 RVA: 0x00085270 File Offset: 0x00083470
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Init_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsForSet._Init_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForSet._Init_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002400 RID: 9216 RVA: 0x000852B8 File Offset: 0x000834B8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForSet._Init_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002401 RID: 9217 RVA: 0x000852EC File Offset: 0x000834EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705301, XrefRangeEnd = 705309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForSet._Init_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170009F7 RID: 2551
			// (get) Token: 0x06002402 RID: 9218 RVA: 0x00085328 File Offset: 0x00083528
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForSet._Init_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002403 RID: 9219 RVA: 0x00085368 File Offset: 0x00083568
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705309, XrefRangeEnd = 705314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForSet._Init_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009F8 RID: 2552
			// (get) Token: 0x06002404 RID: 9220 RVA: 0x0008539C File Offset: 0x0008359C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForSet._Init_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002405 RID: 9221 RVA: 0x0001416F File Offset: 0x0001236F
			public _Init_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009F3 RID: 2547
			// (get) Token: 0x06002406 RID: 9222 RVA: 0x000853DC File Offset: 0x000835DC
			// (set) Token: 0x06002407 RID: 9223 RVA: 0x00014178 File Offset: 0x00012378
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForSet._Init_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForSet._Init_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009F4 RID: 2548
			// (get) Token: 0x06002408 RID: 9224 RVA: 0x00085404 File Offset: 0x00083604
			// (set) Token: 0x06002409 RID: 9225 RVA: 0x00014193 File Offset: 0x00012393
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForSet._Init_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForSet._Init_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009F5 RID: 2549
			// (get) Token: 0x0600240A RID: 9226 RVA: 0x00085434 File Offset: 0x00083634
			// (set) Token: 0x0600240B RID: 9227 RVA: 0x000141B2 File Offset: 0x000123B2
			public unsafe WormEventsForSet __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForSet._Init_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEventsForSet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForSet._Init_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009F6 RID: 2550
			// (get) Token: 0x0600240C RID: 9228 RVA: 0x00085464 File Offset: 0x00083664
			// (set) Token: 0x0600240D RID: 9229 RVA: 0x000141D1 File Offset: 0x000123D1
			public unsafe EntitiesProvider _entitiesProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForSet._Init_d__5.NativeFieldInfoPtr__entitiesProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForSet._Init_d__5.NativeFieldInfoPtr__entitiesProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040014A3 RID: 5283
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040014A4 RID: 5284
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040014A5 RID: 5285
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040014A6 RID: 5286
			private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__2;

			// Token: 0x040014A7 RID: 5287
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040014A8 RID: 5288
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014A9 RID: 5289
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040014AA RID: 5290
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040014AB RID: 5291
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014AC RID: 5292
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

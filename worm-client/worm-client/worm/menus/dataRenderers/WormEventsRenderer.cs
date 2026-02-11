using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using worm.components;
using worm.networking.responses;

namespace worm.menus.dataRenderers
{
	// Token: 0x0200008E RID: 142
	public class WormEventsRenderer : VersionedView<WormEventsProvider>
	{
		// Token: 0x06000587 RID: 1415 RVA: 0x00029A28 File Offset: 0x00027C28
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventsRenderer()
		{
			Il2CppClassPointerStore<WormEventsRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.dataRenderers", "WormEventsRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsRenderer>.NativeClassPtr);
			WormEventsRenderer.NativeFieldInfoPtr_eventPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsRenderer>.NativeClassPtr, "eventPrefab");
			WormEventsRenderer.NativeFieldInfoPtr_eventDisplayRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsRenderer>.NativeClassPtr, "eventDisplayRoot");
			WormEventsRenderer.NativeFieldInfoPtr_loadingSpinner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsRenderer>.NativeClassPtr, "loadingSpinner");
			WormEventsRenderer.NativeFieldInfoPtr_emptyMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsRenderer>.NativeClassPtr, "emptyMessage");
			WormEventsRenderer.NativeFieldInfoPtr_eventDisplays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsRenderer>.NativeClassPtr, "eventDisplays");
			WormEventsRenderer.NativeFieldInfoPtr_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsRenderer>.NativeClassPtr, "timeout");
			WormEventsRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsRenderer>.NativeClassPtr, 100664095);
			WormEventsRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsRenderer>.NativeClassPtr, 100664096);
			WormEventsRenderer.NativeMethodInfoPtr_Timeout_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsRenderer>.NativeClassPtr, 100664097);
			WormEventsRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsRenderer>.NativeClassPtr, 100664098);
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00029B20 File Offset: 0x00027D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695293, XrefRangeEnd = 695306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventsRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00029B5C File Offset: 0x00027D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695306, XrefRangeEnd = 695408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventsRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00029B98 File Offset: 0x00027D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695408, XrefRangeEnd = 695413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Timeout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsRenderer.NativeMethodInfoPtr_Timeout_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00029BD8 File Offset: 0x00027DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695413, XrefRangeEnd = 695423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventsRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00004BD4 File Offset: 0x00002DD4
		public WormEventsRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x00029C14 File Offset: 0x00027E14
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x00004BDD File Offset: 0x00002DDD
		public unsafe SubscriptionProvider eventPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsRenderer.NativeFieldInfoPtr_eventPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsRenderer.NativeFieldInfoPtr_eventPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x00029C44 File Offset: 0x00027E44
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x00004BFC File Offset: 0x00002DFC
		public unsafe Transform eventDisplayRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsRenderer.NativeFieldInfoPtr_eventDisplayRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsRenderer.NativeFieldInfoPtr_eventDisplayRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x00029C74 File Offset: 0x00027E74
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x00004C1B File Offset: 0x00002E1B
		public unsafe GameObject loadingSpinner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsRenderer.NativeFieldInfoPtr_loadingSpinner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsRenderer.NativeFieldInfoPtr_loadingSpinner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x00029CA4 File Offset: 0x00027EA4
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x00004C3A File Offset: 0x00002E3A
		public unsafe GameObject emptyMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsRenderer.NativeFieldInfoPtr_emptyMessage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsRenderer.NativeFieldInfoPtr_emptyMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x00029CD4 File Offset: 0x00027ED4
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x00004C59 File Offset: 0x00002E59
		public unsafe List<SubscriptionProvider> eventDisplays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsRenderer.NativeFieldInfoPtr_eventDisplays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SubscriptionProvider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsRenderer.NativeFieldInfoPtr_eventDisplays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x00029D04 File Offset: 0x00027F04
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x00004C78 File Offset: 0x00002E78
		public unsafe Coroutine timeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsRenderer.NativeFieldInfoPtr_timeout);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsRenderer.NativeFieldInfoPtr_timeout), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeFieldInfoPtr_eventPrefab;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeFieldInfoPtr_eventDisplayRoot;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeFieldInfoPtr_loadingSpinner;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeFieldInfoPtr_emptyMessage;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeFieldInfoPtr_eventDisplays;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeFieldInfoPtr_timeout;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeMethodInfoPtr_Timeout_Private_IEnumerator_0;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000305 RID: 773
		[ObfuscatedName("worm.menus.dataRenderers.WormEventsRenderer+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06001F27 RID: 7975 RVA: 0x000775E0 File Offset: 0x000757E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormEventsRenderer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEventsRenderer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsRenderer.__c>.NativeClassPtr);
				WormEventsRenderer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsRenderer.__c>.NativeClassPtr, "<>9");
				WormEventsRenderer.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsRenderer.__c>.NativeClassPtr, "<>9__7_0");
				WormEventsRenderer.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsRenderer.__c>.NativeClassPtr, "<>9__7_1");
				WormEventsRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsRenderer.__c>.NativeClassPtr, 100664100);
				WormEventsRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__7_0_Internal_EventID_EventDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsRenderer.__c>.NativeClassPtr, 100664101);
				WormEventsRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__7_1_Internal_Boolean_SubscriptionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsRenderer.__c>.NativeClassPtr, 100664102);
			}

			// Token: 0x06001F28 RID: 7976 RVA: 0x00077684 File Offset: 0x00075884
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsRenderer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F29 RID: 7977 RVA: 0x000776C0 File Offset: 0x000758C0
			[CallerCount(0)]
			public unsafe EventID _dirtyUpdate_b__7_0(EventDefinition e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__7_0_Internal_EventID_EventDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventID>(intPtr3) : null;
				}
			}

			// Token: 0x06001F2A RID: 7978 RVA: 0x00077710 File Offset: 0x00075910
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695266, XrefRangeEnd = 695276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _dirtyUpdate_b__7_1(SubscriptionProvider d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__7_1_Internal_Boolean_SubscriptionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001F2B RID: 7979 RVA: 0x000119C1 File Offset: 0x0000FBC1
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000883 RID: 2179
			// (get) Token: 0x06001F2C RID: 7980 RVA: 0x00077760 File Offset: 0x00075960
			// (set) Token: 0x06001F2D RID: 7981 RVA: 0x000119CA File Offset: 0x0000FBCA
			public unsafe static WormEventsRenderer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormEventsRenderer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEventsRenderer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormEventsRenderer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000884 RID: 2180
			// (get) Token: 0x06001F2E RID: 7982 RVA: 0x00077788 File Offset: 0x00075988
			// (set) Token: 0x06001F2F RID: 7983 RVA: 0x000119DC File Offset: 0x0000FBDC
			public unsafe static Func<EventDefinition, EventID> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormEventsRenderer.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EventDefinition, EventID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormEventsRenderer.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000885 RID: 2181
			// (get) Token: 0x06001F30 RID: 7984 RVA: 0x000777B0 File Offset: 0x000759B0
			// (set) Token: 0x06001F31 RID: 7985 RVA: 0x000119EE File Offset: 0x0000FBEE
			public unsafe static Func<SubscriptionProvider, bool> __9__7_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormEventsRenderer.__c.NativeFieldInfoPtr___9__7_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SubscriptionProvider, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormEventsRenderer.__c.NativeFieldInfoPtr___9__7_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001201 RID: 4609
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001202 RID: 4610
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04001203 RID: 4611
			private static readonly IntPtr NativeFieldInfoPtr___9__7_1;

			// Token: 0x04001204 RID: 4612
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001205 RID: 4613
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__7_0_Internal_EventID_EventDefinition_0;

			// Token: 0x04001206 RID: 4614
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__7_1_Internal_Boolean_SubscriptionProvider_0;
		}

		// Token: 0x02000306 RID: 774
		[ObfuscatedName("worm.menus.dataRenderers.WormEventsRenderer+<Timeout>d__8")]
		public sealed class _Timeout_d__8 : global::Il2CppSystem.Object
		{
			// Token: 0x06001F32 RID: 7986 RVA: 0x000777D8 File Offset: 0x000759D8
			// Note: this type is marked as 'beforefieldinit'.
			static _Timeout_d__8()
			{
				Il2CppClassPointerStore<WormEventsRenderer._Timeout_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEventsRenderer>.NativeClassPtr, "<Timeout>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsRenderer._Timeout_d__8>.NativeClassPtr);
				WormEventsRenderer._Timeout_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsRenderer._Timeout_d__8>.NativeClassPtr, "<>1__state");
				WormEventsRenderer._Timeout_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsRenderer._Timeout_d__8>.NativeClassPtr, "<>2__current");
				WormEventsRenderer._Timeout_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsRenderer._Timeout_d__8>.NativeClassPtr, "<>4__this");
				WormEventsRenderer._Timeout_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsRenderer._Timeout_d__8>.NativeClassPtr, 100664103);
				WormEventsRenderer._Timeout_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsRenderer._Timeout_d__8>.NativeClassPtr, 100664104);
				WormEventsRenderer._Timeout_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsRenderer._Timeout_d__8>.NativeClassPtr, 100664105);
				WormEventsRenderer._Timeout_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsRenderer._Timeout_d__8>.NativeClassPtr, 100664106);
				WormEventsRenderer._Timeout_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsRenderer._Timeout_d__8>.NativeClassPtr, 100664107);
				WormEventsRenderer._Timeout_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsRenderer._Timeout_d__8>.NativeClassPtr, 100664108);
			}

			// Token: 0x06001F33 RID: 7987 RVA: 0x000778B8 File Offset: 0x00075AB8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Timeout_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsRenderer._Timeout_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsRenderer._Timeout_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F34 RID: 7988 RVA: 0x00077900 File Offset: 0x00075B00
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsRenderer._Timeout_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F35 RID: 7989 RVA: 0x00077934 File Offset: 0x00075B34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695276, XrefRangeEnd = 695288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsRenderer._Timeout_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000889 RID: 2185
			// (get) Token: 0x06001F36 RID: 7990 RVA: 0x00077970 File Offset: 0x00075B70
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsRenderer._Timeout_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001F37 RID: 7991 RVA: 0x000779B0 File Offset: 0x00075BB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695288, XrefRangeEnd = 695293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsRenderer._Timeout_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700088A RID: 2186
			// (get) Token: 0x06001F38 RID: 7992 RVA: 0x000779E4 File Offset: 0x00075BE4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsRenderer._Timeout_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001F39 RID: 7993 RVA: 0x00011A00 File Offset: 0x0000FC00
			public _Timeout_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000886 RID: 2182
			// (get) Token: 0x06001F3A RID: 7994 RVA: 0x00077A24 File Offset: 0x00075C24
			// (set) Token: 0x06001F3B RID: 7995 RVA: 0x00011A09 File Offset: 0x0000FC09
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsRenderer._Timeout_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsRenderer._Timeout_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000887 RID: 2183
			// (get) Token: 0x06001F3C RID: 7996 RVA: 0x00077A4C File Offset: 0x00075C4C
			// (set) Token: 0x06001F3D RID: 7997 RVA: 0x00011A24 File Offset: 0x0000FC24
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsRenderer._Timeout_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsRenderer._Timeout_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000888 RID: 2184
			// (get) Token: 0x06001F3E RID: 7998 RVA: 0x00077A7C File Offset: 0x00075C7C
			// (set) Token: 0x06001F3F RID: 7999 RVA: 0x00011A43 File Offset: 0x0000FC43
			public unsafe WormEventsRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsRenderer._Timeout_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEventsRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsRenderer._Timeout_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001207 RID: 4615
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001208 RID: 4616
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001209 RID: 4617
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400120A RID: 4618
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400120B RID: 4619
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400120C RID: 4620
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400120D RID: 4621
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400120E RID: 4622
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400120F RID: 4623
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

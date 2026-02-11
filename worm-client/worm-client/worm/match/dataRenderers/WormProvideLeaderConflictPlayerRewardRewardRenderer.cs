using System;
using dwd.core.match.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x02000156 RID: 342
	public class WormProvideLeaderConflictPlayerRewardRewardRenderer : Subscriber<WormConflictPlayerRewardData>
	{
		// Token: 0x06000F55 RID: 3925 RVA: 0x0004620C File Offset: 0x0004440C
		// Note: this type is marked as 'beforefieldinit'.
		static WormProvideLeaderConflictPlayerRewardRewardRenderer()
		{
			Il2CppClassPointerStore<WormProvideLeaderConflictPlayerRewardRewardRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormProvideLeaderConflictPlayerRewardRewardRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormProvideLeaderConflictPlayerRewardRewardRenderer>.NativeClassPtr);
			WormProvideLeaderConflictPlayerRewardRewardRenderer.NativeFieldInfoPtr_leaderEntityComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormProvideLeaderConflictPlayerRewardRewardRenderer>.NativeClassPtr, "leaderEntityComponent");
			WormProvideLeaderConflictPlayerRewardRewardRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormProvideLeaderConflictPlayerRewardRewardRenderer>.NativeClassPtr, 100665366);
			WormProvideLeaderConflictPlayerRewardRewardRenderer.NativeMethodInfoPtr_Init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormProvideLeaderConflictPlayerRewardRewardRenderer>.NativeClassPtr, 100665367);
			WormProvideLeaderConflictPlayerRewardRewardRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormProvideLeaderConflictPlayerRewardRewardRenderer>.NativeClassPtr, 100665368);
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x0004628C File Offset: 0x0004448C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707695, XrefRangeEnd = 707701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormProvideLeaderConflictPlayerRewardRewardRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x000462C8 File Offset: 0x000444C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707701, XrefRangeEnd = 707706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormProvideLeaderConflictPlayerRewardRewardRenderer.NativeMethodInfoPtr_Init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x00046308 File Offset: 0x00044508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707706, XrefRangeEnd = 707709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormProvideLeaderConflictPlayerRewardRewardRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormProvideLeaderConflictPlayerRewardRewardRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormProvideLeaderConflictPlayerRewardRewardRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x0000A185 File Offset: 0x00008385
		public WormProvideLeaderConflictPlayerRewardRewardRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000F5A RID: 3930 RVA: 0x00046344 File Offset: 0x00044544
		// (set) Token: 0x06000F5B RID: 3931 RVA: 0x0000A18E File Offset: 0x0000838E
		public unsafe EntityView leaderEntityComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormProvideLeaderConflictPlayerRewardRewardRenderer.NativeFieldInfoPtr_leaderEntityComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormProvideLeaderConflictPlayerRewardRewardRenderer.NativeFieldInfoPtr_leaderEntityComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008D2 RID: 2258
		private static readonly IntPtr NativeFieldInfoPtr_leaderEntityComponent;

		// Token: 0x040008D3 RID: 2259
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x040008D4 RID: 2260
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_IEnumerator_0;

		// Token: 0x040008D5 RID: 2261
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200039F RID: 927
		[ObfuscatedName("worm.match.dataRenderers.WormProvideLeaderConflictPlayerRewardRewardRenderer+<Init>d__2")]
		public sealed class _Init_d__2 : Object
		{
			// Token: 0x0600254C RID: 9548 RVA: 0x00088C5C File Offset: 0x00086E5C
			// Note: this type is marked as 'beforefieldinit'.
			static _Init_d__2()
			{
				Il2CppClassPointerStore<WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormProvideLeaderConflictPlayerRewardRewardRenderer>.NativeClassPtr, "<Init>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2>.NativeClassPtr);
				WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2>.NativeClassPtr, "<>1__state");
				WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2>.NativeClassPtr, "<>2__current");
				WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2>.NativeClassPtr, "<>4__this");
				WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2.NativeFieldInfoPtr__entitiesProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2>.NativeClassPtr, "<entitiesProvider>5__2");
				WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2>.NativeClassPtr, 100665369);
				WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2>.NativeClassPtr, 100665370);
				WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2>.NativeClassPtr, 100665371);
				WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2>.NativeClassPtr, 100665372);
				WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2>.NativeClassPtr, 100665373);
				WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2>.NativeClassPtr, 100665374);
			}

			// Token: 0x0600254D RID: 9549 RVA: 0x00088D50 File Offset: 0x00086F50
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Init_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600254E RID: 9550 RVA: 0x00088D98 File Offset: 0x00086F98
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600254F RID: 9551 RVA: 0x00088DCC File Offset: 0x00086FCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707682, XrefRangeEnd = 707690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A65 RID: 2661
			// (get) Token: 0x06002550 RID: 9552 RVA: 0x00088E08 File Offset: 0x00087008
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002551 RID: 9553 RVA: 0x00088E48 File Offset: 0x00087048
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707690, XrefRangeEnd = 707695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A66 RID: 2662
			// (get) Token: 0x06002552 RID: 9554 RVA: 0x00088E7C File Offset: 0x0008707C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002553 RID: 9555 RVA: 0x00014C70 File Offset: 0x00012E70
			public _Init_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A61 RID: 2657
			// (get) Token: 0x06002554 RID: 9556 RVA: 0x00088EBC File Offset: 0x000870BC
			// (set) Token: 0x06002555 RID: 9557 RVA: 0x00014C79 File Offset: 0x00012E79
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A62 RID: 2658
			// (get) Token: 0x06002556 RID: 9558 RVA: 0x00088EE4 File Offset: 0x000870E4
			// (set) Token: 0x06002557 RID: 9559 RVA: 0x00014C94 File Offset: 0x00012E94
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A63 RID: 2659
			// (get) Token: 0x06002558 RID: 9560 RVA: 0x00088F14 File Offset: 0x00087114
			// (set) Token: 0x06002559 RID: 9561 RVA: 0x00014CB3 File Offset: 0x00012EB3
			public unsafe WormProvideLeaderConflictPlayerRewardRewardRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormProvideLeaderConflictPlayerRewardRewardRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A64 RID: 2660
			// (get) Token: 0x0600255A RID: 9562 RVA: 0x00088F44 File Offset: 0x00087144
			// (set) Token: 0x0600255B RID: 9563 RVA: 0x00014CD2 File Offset: 0x00012ED2
			public unsafe EntitiesProvider _entitiesProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2.NativeFieldInfoPtr__entitiesProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormProvideLeaderConflictPlayerRewardRewardRenderer._Init_d__2.NativeFieldInfoPtr__entitiesProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001567 RID: 5479
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001568 RID: 5480
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001569 RID: 5481
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400156A RID: 5482
			private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__2;

			// Token: 0x0400156B RID: 5483
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400156C RID: 5484
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400156D RID: 5485
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400156E RID: 5486
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400156F RID: 5487
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001570 RID: 5488
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

using System;
using boardgames.menus.ui;
using boardgames.ranked.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;

namespace boardgames.ranked.menus
{
	// Token: 0x0200002A RID: 42
	public class RankedQueueTimerInitializer : Subscriber<RankedQueueData>
	{
		// Token: 0x06000182 RID: 386 RVA: 0x00007A6C File Offset: 0x00005C6C
		// Note: this type is marked as 'beforefieldinit'.
		static RankedQueueTimerInitializer()
		{
			Il2CppClassPointerStore<RankedQueueTimerInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.menus", "RankedQueueTimerInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedQueueTimerInitializer>.NativeClassPtr);
			RankedQueueTimerInitializer.NativeFieldInfoPtr_timerLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedQueueTimerInitializer>.NativeClassPtr, "timerLabel");
			RankedQueueTimerInitializer.NativeFieldInfoPtr_gamesStartingLoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedQueueTimerInitializer>.NativeClassPtr, "gamesStartingLoc");
			RankedQueueTimerInitializer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedQueueTimerInitializer>.NativeClassPtr, 100663428);
			RankedQueueTimerInitializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedQueueTimerInitializer>.NativeClassPtr, 100663429);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00007AEC File Offset: 0x00005CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225699, XrefRangeEnd = 1225723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RankedQueueTimerInitializer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00007B28 File Offset: 0x00005D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225723, XrefRangeEnd = 1225729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedQueueTimerInitializer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedQueueTimerInitializer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedQueueTimerInitializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002E63 File Offset: 0x00001063
		public RankedQueueTimerInitializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00007B64 File Offset: 0x00005D64
		// (set) Token: 0x06000187 RID: 391 RVA: 0x00002E6C File Offset: 0x0000106C
		public unsafe TMP_Text timerLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedQueueTimerInitializer.NativeFieldInfoPtr_timerLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedQueueTimerInitializer.NativeFieldInfoPtr_timerLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00007B94 File Offset: 0x00005D94
		// (set) Token: 0x06000189 RID: 393 RVA: 0x00002E8B File Offset: 0x0000108B
		public unsafe string gamesStartingLoc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedQueueTimerInitializer.NativeFieldInfoPtr_gamesStartingLoc);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedQueueTimerInitializer.NativeFieldInfoPtr_gamesStartingLoc), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeFieldInfoPtr_timerLabel;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeFieldInfoPtr_gamesStartingLoc;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000042 RID: 66
		[ObfuscatedName("boardgames.ranked.menus.RankedQueueTimerInitializer+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x0600023B RID: 571 RVA: 0x00009B04 File Offset: 0x00007D04
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<RankedQueueTimerInitializer.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RankedQueueTimerInitializer>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedQueueTimerInitializer.__c__DisplayClass2_0>.NativeClassPtr);
				RankedQueueTimerInitializer.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedQueueTimerInitializer.__c__DisplayClass2_0>.NativeClassPtr, "<>4__this");
				RankedQueueTimerInitializer.__c__DisplayClass2_0.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedQueueTimerInitializer.__c__DisplayClass2_0>.NativeClassPtr, "timer");
				RankedQueueTimerInitializer.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedQueueTimerInitializer.__c__DisplayClass2_0>.NativeClassPtr, 100663430);
				RankedQueueTimerInitializer.__c__DisplayClass2_0.NativeMethodInfoPtr__modelChanged_b__0_Internal_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedQueueTimerInitializer.__c__DisplayClass2_0>.NativeClassPtr, 100663431);
				RankedQueueTimerInitializer.__c__DisplayClass2_0.NativeMethodInfoPtr__modelChanged_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedQueueTimerInitializer.__c__DisplayClass2_0>.NativeClassPtr, 100663432);
			}

			// Token: 0x0600023C RID: 572 RVA: 0x00009B94 File Offset: 0x00007D94
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedQueueTimerInitializer.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedQueueTimerInitializer.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600023D RID: 573 RVA: 0x00009BD0 File Offset: 0x00007DD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225650, XrefRangeEnd = 1225657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TimeSpan _modelChanged_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedQueueTimerInitializer.__c__DisplayClass2_0.NativeMethodInfoPtr__modelChanged_b__0_Internal_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600023E RID: 574 RVA: 0x00009C0C File Offset: 0x00007E0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225657, XrefRangeEnd = 1225699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _modelChanged_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedQueueTimerInitializer.__c__DisplayClass2_0.NativeMethodInfoPtr__modelChanged_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600023F RID: 575 RVA: 0x000033DA File Offset: 0x000015DA
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700009E RID: 158
			// (get) Token: 0x06000240 RID: 576 RVA: 0x00009C40 File Offset: 0x00007E40
			// (set) Token: 0x06000241 RID: 577 RVA: 0x000033E3 File Offset: 0x000015E3
			public unsafe RankedQueueTimerInitializer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedQueueTimerInitializer.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RankedQueueTimerInitializer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedQueueTimerInitializer.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700009F RID: 159
			// (get) Token: 0x06000242 RID: 578 RVA: 0x00009C70 File Offset: 0x00007E70
			// (set) Token: 0x06000243 RID: 579 RVA: 0x00003402 File Offset: 0x00001602
			public unsafe TimerDisplay timer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedQueueTimerInitializer.__c__DisplayClass2_0.NativeFieldInfoPtr_timer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerDisplay>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedQueueTimerInitializer.__c__DisplayClass2_0.NativeFieldInfoPtr_timer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000137 RID: 311
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000138 RID: 312
			private static readonly IntPtr NativeFieldInfoPtr_timer;

			// Token: 0x04000139 RID: 313
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400013A RID: 314
			private static readonly IntPtr NativeMethodInfoPtr__modelChanged_b__0_Internal_TimeSpan_0;

			// Token: 0x0400013B RID: 315
			private static readonly IntPtr NativeMethodInfoPtr__modelChanged_b__1_Internal_Void_0;
		}
	}
}

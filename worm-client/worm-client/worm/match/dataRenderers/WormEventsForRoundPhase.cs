using System;
using dwd.core.match.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Events;
using worm.canis.actions.phases;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x0200011E RID: 286
	public class WormEventsForRoundPhase : VersionedView<WormRoundPhaseData>
	{
		// Token: 0x06000D12 RID: 3346 RVA: 0x0003FBC4 File Offset: 0x0003DDC4
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventsForRoundPhase()
		{
			Il2CppClassPointerStore<WormEventsForRoundPhase>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormEventsForRoundPhase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsForRoundPhase>.NativeClassPtr);
			WormEventsForRoundPhase.NativeFieldInfoPtr_cacheRoundPhase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForRoundPhase>.NativeClassPtr, "cacheRoundPhase");
			WormEventsForRoundPhase.NativeFieldInfoPtr_phaseEventPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForRoundPhase>.NativeClassPtr, "phaseEventPairs");
			WormEventsForRoundPhase.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForRoundPhase>.NativeClassPtr, "entitiesProvider");
			WormEventsForRoundPhase.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForRoundPhase>.NativeClassPtr, 100665083);
			WormEventsForRoundPhase.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForRoundPhase>.NativeClassPtr, 100665084);
			WormEventsForRoundPhase.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForRoundPhase>.NativeClassPtr, 100665085);
			WormEventsForRoundPhase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForRoundPhase>.NativeClassPtr, 100665086);
			WormEventsForRoundPhase.NativeMethodInfoPtr__dirtyUpdate_b__6_0_Private_Boolean_PhaseEventPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForRoundPhase>.NativeClassPtr, 100665087);
			WormEventsForRoundPhase.NativeMethodInfoPtr__dirtyUpdate_b__6_1_Private_Boolean_PhaseEventPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForRoundPhase>.NativeClassPtr, 100665088);
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x0003FCA8 File Offset: 0x0003DEA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705221, XrefRangeEnd = 705228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventsForRoundPhase.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x0003FCE4 File Offset: 0x0003DEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705228, XrefRangeEnd = 705235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventsForRoundPhase.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x0003FD20 File Offset: 0x0003DF20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705235, XrefRangeEnd = 705291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventsForRoundPhase.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x0003FD5C File Offset: 0x0003DF5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705291, XrefRangeEnd = 705298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventsForRoundPhase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsForRoundPhase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForRoundPhase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x0003FD98 File Offset: 0x0003DF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705298, XrefRangeEnd = 705300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _dirtyUpdate_b__6_0(WormEventsForRoundPhase.PhaseEventPair phasePair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(phasePair);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForRoundPhase.NativeMethodInfoPtr__dirtyUpdate_b__6_0_Private_Boolean_PhaseEventPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x0003FDE8 File Offset: 0x0003DFE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705300, XrefRangeEnd = 705301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _dirtyUpdate_b__6_1(WormEventsForRoundPhase.PhaseEventPair phasePair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(phasePair);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForRoundPhase.NativeMethodInfoPtr__dirtyUpdate_b__6_1_Private_Boolean_PhaseEventPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x00008E92 File Offset: 0x00007092
		public WormEventsForRoundPhase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000D1A RID: 3354 RVA: 0x0003FE38 File Offset: 0x0003E038
		// (set) Token: 0x06000D1B RID: 3355 RVA: 0x00008E9B File Offset: 0x0000709B
		public Nullable<RoundState> cacheRoundPhase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForRoundPhase.NativeFieldInfoPtr_cacheRoundPhase);
				return new Nullable<RoundState>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<RoundState>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForRoundPhase.NativeFieldInfoPtr_cacheRoundPhase), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<RoundState>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000D1C RID: 3356 RVA: 0x0003FE68 File Offset: 0x0003E068
		// (set) Token: 0x06000D1D RID: 3357 RVA: 0x00008EC9 File Offset: 0x000070C9
		public unsafe Il2CppReferenceArray<WormEventsForRoundPhase.PhaseEventPair> phaseEventPairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForRoundPhase.NativeFieldInfoPtr_phaseEventPairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WormEventsForRoundPhase.PhaseEventPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForRoundPhase.NativeFieldInfoPtr_phaseEventPairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000D1E RID: 3358 RVA: 0x0003FE98 File Offset: 0x0003E098
		// (set) Token: 0x06000D1F RID: 3359 RVA: 0x00008EE8 File Offset: 0x000070E8
		public unsafe EntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForRoundPhase.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForRoundPhase.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeFieldInfoPtr_cacheRoundPhase;

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeFieldInfoPtr_phaseEventPairs;

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__6_0_Private_Boolean_PhaseEventPair_0;

		// Token: 0x0400079A RID: 1946
		private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__6_1_Private_Boolean_PhaseEventPair_0;

		// Token: 0x0200037E RID: 894
		[Serializable]
		public class PhaseEventPair : Object
		{
			// Token: 0x060023F5 RID: 9205 RVA: 0x0008503C File Offset: 0x0008323C
			// Note: this type is marked as 'beforefieldinit'.
			static PhaseEventPair()
			{
				Il2CppClassPointerStore<WormEventsForRoundPhase.PhaseEventPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEventsForRoundPhase>.NativeClassPtr, "PhaseEventPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsForRoundPhase.PhaseEventPair>.NativeClassPtr);
				WormEventsForRoundPhase.PhaseEventPair.NativeFieldInfoPtr_OnEnterRoundPhase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForRoundPhase.PhaseEventPair>.NativeClassPtr, "OnEnterRoundPhase");
				WormEventsForRoundPhase.PhaseEventPair.NativeFieldInfoPtr_OnExitRoundPhase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForRoundPhase.PhaseEventPair>.NativeClassPtr, "OnExitRoundPhase");
				WormEventsForRoundPhase.PhaseEventPair.NativeFieldInfoPtr_RoundPhase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForRoundPhase.PhaseEventPair>.NativeClassPtr, "RoundPhase");
				WormEventsForRoundPhase.PhaseEventPair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForRoundPhase.PhaseEventPair>.NativeClassPtr, 100665089);
			}

			// Token: 0x060023F6 RID: 9206 RVA: 0x000850B8 File Offset: 0x000832B8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PhaseEventPair()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsForRoundPhase.PhaseEventPair>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForRoundPhase.PhaseEventPair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023F7 RID: 9207 RVA: 0x0001410D File Offset: 0x0001230D
			public PhaseEventPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009F0 RID: 2544
			// (get) Token: 0x060023F8 RID: 9208 RVA: 0x000850F4 File Offset: 0x000832F4
			// (set) Token: 0x060023F9 RID: 9209 RVA: 0x00014116 File Offset: 0x00012316
			public unsafe UnityEvent OnEnterRoundPhase
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForRoundPhase.PhaseEventPair.NativeFieldInfoPtr_OnEnterRoundPhase);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForRoundPhase.PhaseEventPair.NativeFieldInfoPtr_OnEnterRoundPhase), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009F1 RID: 2545
			// (get) Token: 0x060023FA RID: 9210 RVA: 0x00085124 File Offset: 0x00083324
			// (set) Token: 0x060023FB RID: 9211 RVA: 0x00014135 File Offset: 0x00012335
			public unsafe UnityEvent OnExitRoundPhase
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForRoundPhase.PhaseEventPair.NativeFieldInfoPtr_OnExitRoundPhase);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForRoundPhase.PhaseEventPair.NativeFieldInfoPtr_OnExitRoundPhase), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009F2 RID: 2546
			// (get) Token: 0x060023FC RID: 9212 RVA: 0x00085154 File Offset: 0x00083354
			// (set) Token: 0x060023FD RID: 9213 RVA: 0x00014154 File Offset: 0x00012354
			public unsafe RoundState RoundPhase
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForRoundPhase.PhaseEventPair.NativeFieldInfoPtr_RoundPhase);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForRoundPhase.PhaseEventPair.NativeFieldInfoPtr_RoundPhase)) = value;
				}
			}

			// Token: 0x0400149F RID: 5279
			private static readonly IntPtr NativeFieldInfoPtr_OnEnterRoundPhase;

			// Token: 0x040014A0 RID: 5280
			private static readonly IntPtr NativeFieldInfoPtr_OnExitRoundPhase;

			// Token: 0x040014A1 RID: 5281
			private static readonly IntPtr NativeFieldInfoPtr_RoundPhase;

			// Token: 0x040014A2 RID: 5282
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

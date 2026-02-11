using System;
using dwd.core.animation;
using dwd.core.commands;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;

namespace worm.client.match.render
{
	// Token: 0x02000299 RID: 665
	public class AnimatedPileRefresher : Observer
	{
		// Token: 0x06001B12 RID: 6930 RVA: 0x0006B2E0 File Offset: 0x000694E0
		// Note: this type is marked as 'beforefieldinit'.
		static AnimatedPileRefresher()
		{
			Il2CppClassPointerStore<AnimatedPileRefresher>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.client.match.render", "AnimatedPileRefresher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatedPileRefresher>.NativeClassPtr);
			AnimatedPileRefresher.NativeFieldInfoPtr_ignoreRealChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatedPileRefresher>.NativeClassPtr, "ignoreRealChildren");
			AnimatedPileRefresher.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatedPileRefresher>.NativeClassPtr, "container");
			AnimatedPileRefresher.NativeFieldInfoPtr_currentOutros = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatedPileRefresher>.NativeClassPtr, "currentOutros");
			AnimatedPileRefresher.NativeFieldInfoPtr_currentIntros = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatedPileRefresher>.NativeClassPtr, "currentIntros");
			AnimatedPileRefresher.NativeFieldInfoPtr_refreshCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatedPileRefresher>.NativeClassPtr, "refreshCoroutine");
			AnimatedPileRefresher.NativeFieldInfoPtr_needsRefreshWithEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatedPileRefresher>.NativeClassPtr, "needsRefreshWithEntities");
			AnimatedPileRefresher.NativeMethodInfoPtr_get_IsRefreshing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatedPileRefresher>.NativeClassPtr, 100667227);
			AnimatedPileRefresher.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatedPileRefresher>.NativeClassPtr, 100667228);
			AnimatedPileRefresher.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatedPileRefresher>.NativeClassPtr, 100667229);
			AnimatedPileRefresher.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatedPileRefresher>.NativeClassPtr, 100667230);
			AnimatedPileRefresher.NativeMethodInfoPtr_Event_Refresh_Public_Void_IEnumerable_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatedPileRefresher>.NativeClassPtr, 100667231);
			AnimatedPileRefresher.NativeMethodInfoPtr_Refresh_Private_IEnumerator_IReadOnlyList_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatedPileRefresher>.NativeClassPtr, 100667232);
			AnimatedPileRefresher.NativeMethodInfoPtr_RestartIfNeeded_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatedPileRefresher>.NativeClassPtr, 100667233);
			AnimatedPileRefresher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatedPileRefresher>.NativeClassPtr, 100667234);
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06001B13 RID: 6931 RVA: 0x0006B428 File Offset: 0x00069628
		public unsafe bool IsRefreshing
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 389902, RefRangeEnd = 389904, XrefRangeStart = 389902, XrefRangeEnd = 389904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatedPileRefresher.NativeMethodInfoPtr_get_IsRefreshing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x0006B464 File Offset: 0x00069664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724146, XrefRangeEnd = 724151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimatedPileRefresher.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x0006B4A0 File Offset: 0x000696A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724151, XrefRangeEnd = 724155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatedPileRefresher.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B16 RID: 6934 RVA: 0x0006B4D4 File Offset: 0x000696D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724155, XrefRangeEnd = 724167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimatedPileRefresher.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x0006B510 File Offset: 0x00069710
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 724175, RefRangeEnd = 724177, XrefRangeStart = 724167, XrefRangeEnd = 724175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Refresh(IEnumerable<EntityComponent> displayEntities)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(displayEntities);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatedPileRefresher.NativeMethodInfoPtr_Event_Refresh_Public_Void_IEnumerable_1_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x0006B554 File Offset: 0x00069754
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 724183, RefRangeEnd = 724188, XrefRangeStart = 724177, XrefRangeEnd = 724183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Refresh(IReadOnlyList<EntityComponent> displayEntities)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(displayEntities);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatedPileRefresher.NativeMethodInfoPtr_Refresh_Private_IEnumerator_IReadOnlyList_1_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x0006B5A4 File Offset: 0x000697A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724188, XrefRangeEnd = 724192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RestartIfNeeded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatedPileRefresher.NativeMethodInfoPtr_RestartIfNeeded_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x0006B5E0 File Offset: 0x000697E0
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimatedPileRefresher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimatedPileRefresher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatedPileRefresher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x0000FB52 File Offset: 0x0000DD52
		public AnimatedPileRefresher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06001B1C RID: 6940 RVA: 0x0006B61C File Offset: 0x0006981C
		// (set) Token: 0x06001B1D RID: 6941 RVA: 0x0000FB5B File Offset: 0x0000DD5B
		public unsafe bool ignoreRealChildren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedPileRefresher.NativeFieldInfoPtr_ignoreRealChildren);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedPileRefresher.NativeFieldInfoPtr_ignoreRealChildren)) = value;
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06001B1E RID: 6942 RVA: 0x0006B644 File Offset: 0x00069844
		// (set) Token: 0x06001B1F RID: 6943 RVA: 0x0000FB76 File Offset: 0x0000DD76
		public unsafe ContainerView container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedPileRefresher.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedPileRefresher.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06001B20 RID: 6944 RVA: 0x0006B674 File Offset: 0x00069874
		// (set) Token: 0x06001B21 RID: 6945 RVA: 0x0000FB95 File Offset: 0x0000DD95
		public unsafe Command currentOutros
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedPileRefresher.NativeFieldInfoPtr_currentOutros);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedPileRefresher.NativeFieldInfoPtr_currentOutros), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06001B22 RID: 6946 RVA: 0x0006B6A4 File Offset: 0x000698A4
		// (set) Token: 0x06001B23 RID: 6947 RVA: 0x0000FBB4 File Offset: 0x0000DDB4
		public unsafe Command currentIntros
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedPileRefresher.NativeFieldInfoPtr_currentIntros);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedPileRefresher.NativeFieldInfoPtr_currentIntros), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06001B24 RID: 6948 RVA: 0x0006B6D4 File Offset: 0x000698D4
		// (set) Token: 0x06001B25 RID: 6949 RVA: 0x0000FBD3 File Offset: 0x0000DDD3
		public unsafe Coroutine refreshCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedPileRefresher.NativeFieldInfoPtr_refreshCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedPileRefresher.NativeFieldInfoPtr_refreshCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06001B26 RID: 6950 RVA: 0x0006B704 File Offset: 0x00069904
		// (set) Token: 0x06001B27 RID: 6951 RVA: 0x0000FBF2 File Offset: 0x0000DDF2
		public unsafe IReadOnlyList<EntityComponent> needsRefreshWithEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedPileRefresher.NativeFieldInfoPtr_needsRefreshWithEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedPileRefresher.NativeFieldInfoPtr_needsRefreshWithEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F9E RID: 3998
		private static readonly IntPtr NativeFieldInfoPtr_ignoreRealChildren;

		// Token: 0x04000F9F RID: 3999
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x04000FA0 RID: 4000
		private static readonly IntPtr NativeFieldInfoPtr_currentOutros;

		// Token: 0x04000FA1 RID: 4001
		private static readonly IntPtr NativeFieldInfoPtr_currentIntros;

		// Token: 0x04000FA2 RID: 4002
		private static readonly IntPtr NativeFieldInfoPtr_refreshCoroutine;

		// Token: 0x04000FA3 RID: 4003
		private static readonly IntPtr NativeFieldInfoPtr_needsRefreshWithEntities;

		// Token: 0x04000FA4 RID: 4004
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRefreshing_Public_get_Boolean_0;

		// Token: 0x04000FA5 RID: 4005
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000FA6 RID: 4006
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000FA7 RID: 4007
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x04000FA8 RID: 4008
		private static readonly IntPtr NativeMethodInfoPtr_Event_Refresh_Public_Void_IEnumerable_1_EntityComponent_0;

		// Token: 0x04000FA9 RID: 4009
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_IEnumerator_IReadOnlyList_1_EntityComponent_0;

		// Token: 0x04000FAA RID: 4010
		private static readonly IntPtr NativeMethodInfoPtr_RestartIfNeeded_Private_Boolean_0;

		// Token: 0x04000FAB RID: 4011
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000436 RID: 1078
		[ObfuscatedName("worm.client.match.render.AnimatedPileRefresher+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06002CD9 RID: 11481 RVA: 0x000A0148 File Offset: 0x0009E348
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AnimatedPileRefresher.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimatedPileRefresher>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatedPileRefresher.__c>.NativeClassPtr);
				AnimatedPileRefresher.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatedPileRefresher.__c>.NativeClassPtr, "<>9");
				AnimatedPileRefresher.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatedPileRefresher.__c>.NativeClassPtr, "<>9__12_0");
				AnimatedPileRefresher.__c.NativeFieldInfoPtr___9__12_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatedPileRefresher.__c>.NativeClassPtr, "<>9__12_3");
				AnimatedPileRefresher.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatedPileRefresher.__c>.NativeClassPtr, 100667236);
				AnimatedPileRefresher.__c.NativeMethodInfoPtr__Refresh_b__12_0_Internal_Command_ValueTuple_2_UnitView_TriggeredBlockingAnimation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatedPileRefresher.__c>.NativeClassPtr, 100667237);
				AnimatedPileRefresher.__c.NativeMethodInfoPtr__Refresh_b__12_3_Internal_Command_ValueTuple_2_UnitView_TriggeredBlockingAnimation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatedPileRefresher.__c>.NativeClassPtr, 100667238);
			}

			// Token: 0x06002CDA RID: 11482 RVA: 0x000A01EC File Offset: 0x0009E3EC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimatedPileRefresher.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatedPileRefresher.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002CDB RID: 11483 RVA: 0x000A0228 File Offset: 0x0009E428
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724000, XrefRangeEnd = 724017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Command _Refresh_b__12_0(ValueTuple<UnitView, TriggeredBlockingAnimation> v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(v));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatedPileRefresher.__c.NativeMethodInfoPtr__Refresh_b__12_0_Internal_Command_ValueTuple_2_UnitView_TriggeredBlockingAnimation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
				}
			}

			// Token: 0x06002CDC RID: 11484 RVA: 0x000A0280 File Offset: 0x0009E480
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724017, XrefRangeEnd = 724020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Command _Refresh_b__12_3(ValueTuple<UnitView, TriggeredBlockingAnimation> v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(v));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatedPileRefresher.__c.NativeMethodInfoPtr__Refresh_b__12_3_Internal_Command_ValueTuple_2_UnitView_TriggeredBlockingAnimation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
				}
			}

			// Token: 0x06002CDD RID: 11485 RVA: 0x00018564 File Offset: 0x00016764
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CE0 RID: 3296
			// (get) Token: 0x06002CDE RID: 11486 RVA: 0x000A02D8 File Offset: 0x0009E4D8
			// (set) Token: 0x06002CDF RID: 11487 RVA: 0x0001856D File Offset: 0x0001676D
			public unsafe static AnimatedPileRefresher.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AnimatedPileRefresher.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimatedPileRefresher.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AnimatedPileRefresher.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CE1 RID: 3297
			// (get) Token: 0x06002CE0 RID: 11488 RVA: 0x000A0300 File Offset: 0x0009E500
			// (set) Token: 0x06002CE1 RID: 11489 RVA: 0x0001857F File Offset: 0x0001677F
			public unsafe static Func<ValueTuple<UnitView, TriggeredBlockingAnimation>, Command> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AnimatedPileRefresher.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<UnitView, TriggeredBlockingAnimation>, Command>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AnimatedPileRefresher.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CE2 RID: 3298
			// (get) Token: 0x06002CE2 RID: 11490 RVA: 0x000A0328 File Offset: 0x0009E528
			// (set) Token: 0x06002CE3 RID: 11491 RVA: 0x00018591 File Offset: 0x00016791
			public unsafe static Func<ValueTuple<UnitView, TriggeredBlockingAnimation>, Command> __9__12_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AnimatedPileRefresher.__c.NativeFieldInfoPtr___9__12_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<UnitView, TriggeredBlockingAnimation>, Command>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AnimatedPileRefresher.__c.NativeFieldInfoPtr___9__12_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A19 RID: 6681
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001A1A RID: 6682
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x04001A1B RID: 6683
			private static readonly IntPtr NativeFieldInfoPtr___9__12_3;

			// Token: 0x04001A1C RID: 6684
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001A1D RID: 6685
			private static readonly IntPtr NativeMethodInfoPtr__Refresh_b__12_0_Internal_Command_ValueTuple_2_UnitView_TriggeredBlockingAnimation_0;

			// Token: 0x04001A1E RID: 6686
			private static readonly IntPtr NativeMethodInfoPtr__Refresh_b__12_3_Internal_Command_ValueTuple_2_UnitView_TriggeredBlockingAnimation_0;
		}

		// Token: 0x02000437 RID: 1079
		[ObfuscatedName("worm.client.match.render.AnimatedPileRefresher+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002CE4 RID: 11492 RVA: 0x000A0350 File Offset: 0x0009E550
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<AnimatedPileRefresher.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimatedPileRefresher>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatedPileRefresher.__c__DisplayClass12_0>.NativeClassPtr);
				AnimatedPileRefresher.__c__DisplayClass12_0.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatedPileRefresher.__c__DisplayClass12_0>.NativeClassPtr, "current");
				AnimatedPileRefresher.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatedPileRefresher.__c__DisplayClass12_0>.NativeClassPtr, 100667239);
				AnimatedPileRefresher.__c__DisplayClass12_0.NativeMethodInfoPtr__Refresh_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatedPileRefresher.__c__DisplayClass12_0>.NativeClassPtr, 100667240);
			}

			// Token: 0x06002CE5 RID: 11493 RVA: 0x000A03B8 File Offset: 0x0009E5B8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimatedPileRefresher.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatedPileRefresher.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002CE6 RID: 11494 RVA: 0x000A03F4 File Offset: 0x0009E5F4
			[CallerCount(0)]
			public unsafe bool _Refresh_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatedPileRefresher.__c__DisplayClass12_0.NativeMethodInfoPtr__Refresh_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002CE7 RID: 11495 RVA: 0x000185A3 File Offset: 0x000167A3
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CE3 RID: 3299
			// (get) Token: 0x06002CE8 RID: 11496 RVA: 0x000A0430 File Offset: 0x0009E630
			// (set) Token: 0x06002CE9 RID: 11497 RVA: 0x000185AC File Offset: 0x000167AC
			public unsafe Command current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedPileRefresher.__c__DisplayClass12_0.NativeFieldInfoPtr_current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedPileRefresher.__c__DisplayClass12_0.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A1F RID: 6687
			private static readonly IntPtr NativeFieldInfoPtr_current;

			// Token: 0x04001A20 RID: 6688
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001A21 RID: 6689
			private static readonly IntPtr NativeMethodInfoPtr__Refresh_b__1_Internal_Boolean_0;
		}

		// Token: 0x02000438 RID: 1080
		[ObfuscatedName("worm.client.match.render.AnimatedPileRefresher+<>c__DisplayClass12_1")]
		public sealed class __c__DisplayClass12_1 : global::Il2CppSystem.Object
		{
			// Token: 0x06002CEA RID: 11498 RVA: 0x000A0460 File Offset: 0x0009E660
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_1()
			{
				Il2CppClassPointerStore<AnimatedPileRefresher.__c__DisplayClass12_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimatedPileRefresher>.NativeClassPtr, "<>c__DisplayClass12_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatedPileRefresher.__c__DisplayClass12_1>.NativeClassPtr);
				AnimatedPileRefresher.__c__DisplayClass12_1.NativeFieldInfoPtr_v = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatedPileRefresher.__c__DisplayClass12_1>.NativeClassPtr, "v");
				AnimatedPileRefresher.__c__DisplayClass12_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatedPileRefresher.__c__DisplayClass12_1>.NativeClassPtr, 100667241);
				AnimatedPileRefresher.__c__DisplayClass12_1.NativeMethodInfoPtr__Refresh_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatedPileRefresher.__c__DisplayClass12_1>.NativeClassPtr, 100667242);
			}

			// Token: 0x06002CEB RID: 11499 RVA: 0x000A04C8 File Offset: 0x0009E6C8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimatedPileRefresher.__c__DisplayClass12_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatedPileRefresher.__c__DisplayClass12_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002CEC RID: 11500 RVA: 0x000A0504 File Offset: 0x0009E704
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724020, XrefRangeEnd = 724031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Refresh_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatedPileRefresher.__c__DisplayClass12_1.NativeMethodInfoPtr__Refresh_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002CED RID: 11501 RVA: 0x000185CB File Offset: 0x000167CB
			public __c__DisplayClass12_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CE4 RID: 3300
			// (get) Token: 0x06002CEE RID: 11502 RVA: 0x000A0538 File Offset: 0x0009E738
			// (set) Token: 0x06002CEF RID: 11503 RVA: 0x000185D4 File Offset: 0x000167D4
			public ValueTuple<UnitView, TriggeredBlockingAnimation> v
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedPileRefresher.__c__DisplayClass12_1.NativeFieldInfoPtr_v);
					return new ValueTuple<UnitView, TriggeredBlockingAnimation>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<UnitView, TriggeredBlockingAnimation>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedPileRefresher.__c__DisplayClass12_1.NativeFieldInfoPtr_v), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<UnitView, TriggeredBlockingAnimation>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001A22 RID: 6690
			private static readonly IntPtr NativeFieldInfoPtr_v;

			// Token: 0x04001A23 RID: 6691
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001A24 RID: 6692
			private static readonly IntPtr NativeMethodInfoPtr__Refresh_b__2_Internal_Void_0;
		}

		// Token: 0x02000439 RID: 1081
		[ObfuscatedName("worm.client.match.render.AnimatedPileRefresher+<>c__DisplayClass12_2")]
		public sealed class __c__DisplayClass12_2 : global::Il2CppSystem.Object
		{
			// Token: 0x06002CF0 RID: 11504 RVA: 0x000A0568 File Offset: 0x0009E768
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_2()
			{
				Il2CppClassPointerStore<AnimatedPileRefresher.__c__DisplayClass12_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimatedPileRefresher>.NativeClassPtr, "<>c__DisplayClass12_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatedPileRefresher.__c__DisplayClass12_2>.NativeClassPtr);
				AnimatedPileRefresher.__c__DisplayClass12_2.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatedPileRefresher.__c__DisplayClass12_2>.NativeClassPtr, "current");
				AnimatedPileRefresher.__c__DisplayClass12_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatedPileRefresher.__c__DisplayClass12_2>.NativeClassPtr, 100667243);
				AnimatedPileRefresher.__c__DisplayClass12_2.NativeMethodInfoPtr__Refresh_b__4_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatedPileRefresher.__c__DisplayClass12_2>.NativeClassPtr, 100667244);
			}

			// Token: 0x06002CF1 RID: 11505 RVA: 0x000A05D0 File Offset: 0x0009E7D0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_2()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimatedPileRefresher.__c__DisplayClass12_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatedPileRefresher.__c__DisplayClass12_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002CF2 RID: 11506 RVA: 0x000A060C File Offset: 0x0009E80C
			[CallerCount(0)]
			public unsafe bool _Refresh_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatedPileRefresher.__c__DisplayClass12_2.NativeMethodInfoPtr__Refresh_b__4_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002CF3 RID: 11507 RVA: 0x00018602 File Offset: 0x00016802
			public __c__DisplayClass12_2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CE5 RID: 3301
			// (get) Token: 0x06002CF4 RID: 11508 RVA: 0x000A0648 File Offset: 0x0009E848
			// (set) Token: 0x06002CF5 RID: 11509 RVA: 0x0001860B File Offset: 0x0001680B
			public unsafe Command current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedPileRefresher.__c__DisplayClass12_2.NativeFieldInfoPtr_current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedPileRefresher.__c__DisplayClass12_2.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A25 RID: 6693
			private static readonly IntPtr NativeFieldInfoPtr_current;

			// Token: 0x04001A26 RID: 6694
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001A27 RID: 6695
			private static readonly IntPtr NativeMethodInfoPtr__Refresh_b__4_Internal_Boolean_0;
		}

		// Token: 0x0200043A RID: 1082
		[ObfuscatedName("worm.client.match.render.AnimatedPileRefresher+<Refresh>d__12")]
		public sealed class _Refresh_d__12 : global::Il2CppSystem.Object
		{
			// Token: 0x06002CF6 RID: 11510 RVA: 0x000A0678 File Offset: 0x0009E878
			// Note: this type is marked as 'beforefieldinit'.
			static _Refresh_d__12()
			{
				Il2CppClassPointerStore<AnimatedPileRefresher._Refresh_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimatedPileRefresher>.NativeClassPtr, "<Refresh>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatedPileRefresher._Refresh_d__12>.NativeClassPtr);
				AnimatedPileRefresher._Refresh_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatedPileRefresher._Refresh_d__12>.NativeClassPtr, "<>1__state");
				AnimatedPileRefresher._Refresh_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatedPileRefresher._Refresh_d__12>.NativeClassPtr, "<>2__current");
				AnimatedPileRefresher._Refresh_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatedPileRefresher._Refresh_d__12>.NativeClassPtr, "<>4__this");
				AnimatedPileRefresher._Refresh_d__12.NativeFieldInfoPtr_displayEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatedPileRefresher._Refresh_d__12>.NativeClassPtr, "displayEntities");
				AnimatedPileRefresher._Refresh_d__12.NativeFieldInfoPtr__toAnimate_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatedPileRefresher._Refresh_d__12>.NativeClassPtr, "<toAnimate>5__2");
				AnimatedPileRefresher._Refresh_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatedPileRefresher._Refresh_d__12>.NativeClassPtr, 100667245);
				AnimatedPileRefresher._Refresh_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatedPileRefresher._Refresh_d__12>.NativeClassPtr, 100667246);
				AnimatedPileRefresher._Refresh_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatedPileRefresher._Refresh_d__12>.NativeClassPtr, 100667247);
				AnimatedPileRefresher._Refresh_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatedPileRefresher._Refresh_d__12>.NativeClassPtr, 100667248);
				AnimatedPileRefresher._Refresh_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatedPileRefresher._Refresh_d__12>.NativeClassPtr, 100667249);
				AnimatedPileRefresher._Refresh_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatedPileRefresher._Refresh_d__12>.NativeClassPtr, 100667250);
			}

			// Token: 0x06002CF7 RID: 11511 RVA: 0x000A0780 File Offset: 0x0009E980
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Refresh_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimatedPileRefresher._Refresh_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatedPileRefresher._Refresh_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002CF8 RID: 11512 RVA: 0x000A07C8 File Offset: 0x0009E9C8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatedPileRefresher._Refresh_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002CF9 RID: 11513 RVA: 0x000A07FC File Offset: 0x0009E9FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724031, XrefRangeEnd = 724141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatedPileRefresher._Refresh_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000CEB RID: 3307
			// (get) Token: 0x06002CFA RID: 11514 RVA: 0x000A0838 File Offset: 0x0009EA38
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatedPileRefresher._Refresh_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002CFB RID: 11515 RVA: 0x000A0878 File Offset: 0x0009EA78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724141, XrefRangeEnd = 724146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatedPileRefresher._Refresh_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000CEC RID: 3308
			// (get) Token: 0x06002CFC RID: 11516 RVA: 0x000A08AC File Offset: 0x0009EAAC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatedPileRefresher._Refresh_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002CFD RID: 11517 RVA: 0x0001862A File Offset: 0x0001682A
			public _Refresh_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CE6 RID: 3302
			// (get) Token: 0x06002CFE RID: 11518 RVA: 0x000A08EC File Offset: 0x0009EAEC
			// (set) Token: 0x06002CFF RID: 11519 RVA: 0x00018633 File Offset: 0x00016833
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedPileRefresher._Refresh_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedPileRefresher._Refresh_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000CE7 RID: 3303
			// (get) Token: 0x06002D00 RID: 11520 RVA: 0x000A0914 File Offset: 0x0009EB14
			// (set) Token: 0x06002D01 RID: 11521 RVA: 0x0001864E File Offset: 0x0001684E
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedPileRefresher._Refresh_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedPileRefresher._Refresh_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CE8 RID: 3304
			// (get) Token: 0x06002D02 RID: 11522 RVA: 0x000A0944 File Offset: 0x0009EB44
			// (set) Token: 0x06002D03 RID: 11523 RVA: 0x0001866D File Offset: 0x0001686D
			public unsafe AnimatedPileRefresher __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedPileRefresher._Refresh_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimatedPileRefresher>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedPileRefresher._Refresh_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CE9 RID: 3305
			// (get) Token: 0x06002D04 RID: 11524 RVA: 0x000A0974 File Offset: 0x0009EB74
			// (set) Token: 0x06002D05 RID: 11525 RVA: 0x0001868C File Offset: 0x0001688C
			public unsafe IReadOnlyList<EntityComponent> displayEntities
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedPileRefresher._Refresh_d__12.NativeFieldInfoPtr_displayEntities);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<EntityComponent>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedPileRefresher._Refresh_d__12.NativeFieldInfoPtr_displayEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CEA RID: 3306
			// (get) Token: 0x06002D06 RID: 11526 RVA: 0x000A09A4 File Offset: 0x0009EBA4
			// (set) Token: 0x06002D07 RID: 11527 RVA: 0x000186AB File Offset: 0x000168AB
			public unsafe List<ValueTuple<UnitView, TriggeredBlockingAnimation>> _toAnimate_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedPileRefresher._Refresh_d__12.NativeFieldInfoPtr__toAnimate_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<UnitView, TriggeredBlockingAnimation>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedPileRefresher._Refresh_d__12.NativeFieldInfoPtr__toAnimate_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A28 RID: 6696
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001A29 RID: 6697
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001A2A RID: 6698
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001A2B RID: 6699
			private static readonly IntPtr NativeFieldInfoPtr_displayEntities;

			// Token: 0x04001A2C RID: 6700
			private static readonly IntPtr NativeFieldInfoPtr__toAnimate_5__2;

			// Token: 0x04001A2D RID: 6701
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001A2E RID: 6702
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A2F RID: 6703
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001A30 RID: 6704
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001A31 RID: 6705
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A32 RID: 6706
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

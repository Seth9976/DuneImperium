using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x0200011C RID: 284
	public class WormEventsForLeaderArchetypeSubscriber : VersionedSubscriber<WormLeaderData>
	{
		// Token: 0x06000D01 RID: 3329 RVA: 0x0003F8CC File Offset: 0x0003DACC
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventsForLeaderArchetypeSubscriber()
		{
			Il2CppClassPointerStore<WormEventsForLeaderArchetypeSubscriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormEventsForLeaderArchetypeSubscriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsForLeaderArchetypeSubscriber>.NativeClassPtr);
			WormEventsForLeaderArchetypeSubscriber.NativeFieldInfoPtr_archetypeEventPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForLeaderArchetypeSubscriber>.NativeClassPtr, "archetypeEventPairs");
			WormEventsForLeaderArchetypeSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForLeaderArchetypeSubscriber>.NativeClassPtr, 100665077);
			WormEventsForLeaderArchetypeSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForLeaderArchetypeSubscriber>.NativeClassPtr, 100665078);
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x0003F938 File Offset: 0x0003DB38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705152, XrefRangeEnd = 705178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventsForLeaderArchetypeSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x0003F974 File Offset: 0x0003DB74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705178, XrefRangeEnd = 705188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventsForLeaderArchetypeSubscriber()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsForLeaderArchetypeSubscriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForLeaderArchetypeSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x00008E08 File Offset: 0x00007008
		public WormEventsForLeaderArchetypeSubscriber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000D05 RID: 3333 RVA: 0x0003F9B0 File Offset: 0x0003DBB0
		// (set) Token: 0x06000D06 RID: 3334 RVA: 0x00008E11 File Offset: 0x00007011
		public unsafe List<WormEventsForLeaderArchetypeSubscriber.ArchetypeEventPair> archetypeEventPairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForLeaderArchetypeSubscriber.NativeFieldInfoPtr_archetypeEventPairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormEventsForLeaderArchetypeSubscriber.ArchetypeEventPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForLeaderArchetypeSubscriber.NativeFieldInfoPtr_archetypeEventPairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000789 RID: 1929
		private static readonly IntPtr NativeFieldInfoPtr_archetypeEventPairs;

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200037D RID: 893
		[Serializable]
		public class ArchetypeEventPair : Object
		{
			// Token: 0x060023EE RID: 9198 RVA: 0x00084F38 File Offset: 0x00083138
			// Note: this type is marked as 'beforefieldinit'.
			static ArchetypeEventPair()
			{
				Il2CppClassPointerStore<WormEventsForLeaderArchetypeSubscriber.ArchetypeEventPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEventsForLeaderArchetypeSubscriber>.NativeClassPtr, "ArchetypeEventPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsForLeaderArchetypeSubscriber.ArchetypeEventPair>.NativeClassPtr);
				WormEventsForLeaderArchetypeSubscriber.ArchetypeEventPair.NativeFieldInfoPtr_ArchetypeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForLeaderArchetypeSubscriber.ArchetypeEventPair>.NativeClassPtr, "ArchetypeID");
				WormEventsForLeaderArchetypeSubscriber.ArchetypeEventPair.NativeFieldInfoPtr_OnAssignArchetype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForLeaderArchetypeSubscriber.ArchetypeEventPair>.NativeClassPtr, "OnAssignArchetype");
				WormEventsForLeaderArchetypeSubscriber.ArchetypeEventPair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForLeaderArchetypeSubscriber.ArchetypeEventPair>.NativeClassPtr, 100665079);
			}

			// Token: 0x060023EF RID: 9199 RVA: 0x00084FA0 File Offset: 0x000831A0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArchetypeEventPair()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsForLeaderArchetypeSubscriber.ArchetypeEventPair>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForLeaderArchetypeSubscriber.ArchetypeEventPair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023F0 RID: 9200 RVA: 0x000140C6 File Offset: 0x000122C6
			public ArchetypeEventPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009EE RID: 2542
			// (get) Token: 0x060023F1 RID: 9201 RVA: 0x00084FDC File Offset: 0x000831DC
			// (set) Token: 0x060023F2 RID: 9202 RVA: 0x000140CF File Offset: 0x000122CF
			public unsafe ArchetypeID ArchetypeID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForLeaderArchetypeSubscriber.ArchetypeEventPair.NativeFieldInfoPtr_ArchetypeID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForLeaderArchetypeSubscriber.ArchetypeEventPair.NativeFieldInfoPtr_ArchetypeID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009EF RID: 2543
			// (get) Token: 0x060023F3 RID: 9203 RVA: 0x0008500C File Offset: 0x0008320C
			// (set) Token: 0x060023F4 RID: 9204 RVA: 0x000140EE File Offset: 0x000122EE
			public unsafe UnityEvent OnAssignArchetype
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForLeaderArchetypeSubscriber.ArchetypeEventPair.NativeFieldInfoPtr_OnAssignArchetype);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForLeaderArchetypeSubscriber.ArchetypeEventPair.NativeFieldInfoPtr_OnAssignArchetype), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400149C RID: 5276
			private static readonly IntPtr NativeFieldInfoPtr_ArchetypeID;

			// Token: 0x0400149D RID: 5277
			private static readonly IntPtr NativeFieldInfoPtr_OnAssignArchetype;

			// Token: 0x0400149E RID: 5278
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

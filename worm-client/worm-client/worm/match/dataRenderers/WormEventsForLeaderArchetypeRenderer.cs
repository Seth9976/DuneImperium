using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;
using voodoo;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x0200011B RID: 283
	public class WormEventsForLeaderArchetypeRenderer : VersionedDataComponentObserver<WormLeaderData>
	{
		// Token: 0x06000CF9 RID: 3321 RVA: 0x0003F774 File Offset: 0x0003D974
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventsForLeaderArchetypeRenderer()
		{
			Il2CppClassPointerStore<WormEventsForLeaderArchetypeRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormEventsForLeaderArchetypeRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsForLeaderArchetypeRenderer>.NativeClassPtr);
			WormEventsForLeaderArchetypeRenderer.NativeFieldInfoPtr_archetypeEventPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForLeaderArchetypeRenderer>.NativeClassPtr, "archetypeEventPairs");
			WormEventsForLeaderArchetypeRenderer.NativeFieldInfoPtr_cacheArchetypeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForLeaderArchetypeRenderer>.NativeClassPtr, "cacheArchetypeID");
			WormEventsForLeaderArchetypeRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForLeaderArchetypeRenderer>.NativeClassPtr, 100665074);
			WormEventsForLeaderArchetypeRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForLeaderArchetypeRenderer>.NativeClassPtr, 100665075);
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x0003F7F4 File Offset: 0x0003D9F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705113, XrefRangeEnd = 705142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventsForLeaderArchetypeRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x0003F830 File Offset: 0x0003DA30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705142, XrefRangeEnd = 705152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventsForLeaderArchetypeRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsForLeaderArchetypeRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForLeaderArchetypeRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x00008DC1 File Offset: 0x00006FC1
		public WormEventsForLeaderArchetypeRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000CFD RID: 3325 RVA: 0x0003F86C File Offset: 0x0003DA6C
		// (set) Token: 0x06000CFE RID: 3326 RVA: 0x00008DCA File Offset: 0x00006FCA
		public unsafe List<WormEventsForLeaderArchetypeRenderer.ArchetypeEventPair> archetypeEventPairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForLeaderArchetypeRenderer.NativeFieldInfoPtr_archetypeEventPairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormEventsForLeaderArchetypeRenderer.ArchetypeEventPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForLeaderArchetypeRenderer.NativeFieldInfoPtr_archetypeEventPairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000CFF RID: 3327 RVA: 0x0003F89C File Offset: 0x0003DA9C
		// (set) Token: 0x06000D00 RID: 3328 RVA: 0x00008DE9 File Offset: 0x00006FE9
		public unsafe ArchetypeID cacheArchetypeID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForLeaderArchetypeRenderer.NativeFieldInfoPtr_cacheArchetypeID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForLeaderArchetypeRenderer.NativeFieldInfoPtr_cacheArchetypeID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000785 RID: 1925
		private static readonly IntPtr NativeFieldInfoPtr_archetypeEventPairs;

		// Token: 0x04000786 RID: 1926
		private static readonly IntPtr NativeFieldInfoPtr_cacheArchetypeID;

		// Token: 0x04000787 RID: 1927
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x04000788 RID: 1928
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200037C RID: 892
		[Serializable]
		public class ArchetypeEventPair : Object
		{
			// Token: 0x060023E7 RID: 9191 RVA: 0x00084E34 File Offset: 0x00083034
			// Note: this type is marked as 'beforefieldinit'.
			static ArchetypeEventPair()
			{
				Il2CppClassPointerStore<WormEventsForLeaderArchetypeRenderer.ArchetypeEventPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEventsForLeaderArchetypeRenderer>.NativeClassPtr, "ArchetypeEventPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsForLeaderArchetypeRenderer.ArchetypeEventPair>.NativeClassPtr);
				WormEventsForLeaderArchetypeRenderer.ArchetypeEventPair.NativeFieldInfoPtr_ArchetypeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForLeaderArchetypeRenderer.ArchetypeEventPair>.NativeClassPtr, "ArchetypeID");
				WormEventsForLeaderArchetypeRenderer.ArchetypeEventPair.NativeFieldInfoPtr_OnAssignArchetype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForLeaderArchetypeRenderer.ArchetypeEventPair>.NativeClassPtr, "OnAssignArchetype");
				WormEventsForLeaderArchetypeRenderer.ArchetypeEventPair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForLeaderArchetypeRenderer.ArchetypeEventPair>.NativeClassPtr, 100665076);
			}

			// Token: 0x060023E8 RID: 9192 RVA: 0x00084E9C File Offset: 0x0008309C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArchetypeEventPair()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsForLeaderArchetypeRenderer.ArchetypeEventPair>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForLeaderArchetypeRenderer.ArchetypeEventPair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023E9 RID: 9193 RVA: 0x0001407F File Offset: 0x0001227F
			public ArchetypeEventPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009EC RID: 2540
			// (get) Token: 0x060023EA RID: 9194 RVA: 0x00084ED8 File Offset: 0x000830D8
			// (set) Token: 0x060023EB RID: 9195 RVA: 0x00014088 File Offset: 0x00012288
			public unsafe ArchetypeID ArchetypeID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForLeaderArchetypeRenderer.ArchetypeEventPair.NativeFieldInfoPtr_ArchetypeID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForLeaderArchetypeRenderer.ArchetypeEventPair.NativeFieldInfoPtr_ArchetypeID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009ED RID: 2541
			// (get) Token: 0x060023EC RID: 9196 RVA: 0x00084F08 File Offset: 0x00083108
			// (set) Token: 0x060023ED RID: 9197 RVA: 0x000140A7 File Offset: 0x000122A7
			public unsafe UnityEvent OnAssignArchetype
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForLeaderArchetypeRenderer.ArchetypeEventPair.NativeFieldInfoPtr_OnAssignArchetype);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForLeaderArchetypeRenderer.ArchetypeEventPair.NativeFieldInfoPtr_OnAssignArchetype), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001499 RID: 5273
			private static readonly IntPtr NativeFieldInfoPtr_ArchetypeID;

			// Token: 0x0400149A RID: 5274
			private static readonly IntPtr NativeFieldInfoPtr_OnAssignArchetype;

			// Token: 0x0400149B RID: 5275
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

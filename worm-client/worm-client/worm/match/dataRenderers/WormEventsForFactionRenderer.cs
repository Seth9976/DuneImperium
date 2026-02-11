using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;
using voodoo;
using worm.canis.data.enums;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x02000119 RID: 281
	public class WormEventsForFactionRenderer : VersionedDataComponentObserver<WormFactionData>
	{
		// Token: 0x06000CE7 RID: 3303 RVA: 0x0003F420 File Offset: 0x0003D620
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventsForFactionRenderer()
		{
			Il2CppClassPointerStore<WormEventsForFactionRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormEventsForFactionRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsForFactionRenderer>.NativeClassPtr);
			WormEventsForFactionRenderer.NativeFieldInfoPtr_factionEventPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForFactionRenderer>.NativeClassPtr, "factionEventPairs");
			WormEventsForFactionRenderer.NativeFieldInfoPtr_cacheFactions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForFactionRenderer>.NativeClassPtr, "cacheFactions");
			WormEventsForFactionRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForFactionRenderer>.NativeClassPtr, 100665061);
			WormEventsForFactionRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForFactionRenderer>.NativeClassPtr, 100665062);
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x0003F4A0 File Offset: 0x0003D6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705032, XrefRangeEnd = 705055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventsForFactionRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x0003F4DC File Offset: 0x0003D6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705055, XrefRangeEnd = 705065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventsForFactionRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsForFactionRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForFactionRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x00008D24 File Offset: 0x00006F24
		public WormEventsForFactionRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000CEB RID: 3307 RVA: 0x0003F518 File Offset: 0x0003D718
		// (set) Token: 0x06000CEC RID: 3308 RVA: 0x00008D2D File Offset: 0x00006F2D
		public unsafe List<WormEventsForFactionRenderer.FactionEventPair> factionEventPairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForFactionRenderer.NativeFieldInfoPtr_factionEventPairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormEventsForFactionRenderer.FactionEventPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForFactionRenderer.NativeFieldInfoPtr_factionEventPairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000CED RID: 3309 RVA: 0x0003F548 File Offset: 0x0003D748
		// (set) Token: 0x06000CEE RID: 3310 RVA: 0x00008D4C File Offset: 0x00006F4C
		public Nullable<Factions> cacheFactions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForFactionRenderer.NativeFieldInfoPtr_cacheFactions);
				return new Nullable<Factions>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Factions>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForFactionRenderer.NativeFieldInfoPtr_cacheFactions), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Factions>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400077B RID: 1915
		private static readonly IntPtr NativeFieldInfoPtr_factionEventPairs;

		// Token: 0x0400077C RID: 1916
		private static readonly IntPtr NativeFieldInfoPtr_cacheFactions;

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200037A RID: 890
		[Serializable]
		public class FactionEventPair : Object
		{
			// Token: 0x060023D0 RID: 9168 RVA: 0x00084A20 File Offset: 0x00082C20
			// Note: this type is marked as 'beforefieldinit'.
			static FactionEventPair()
			{
				Il2CppClassPointerStore<WormEventsForFactionRenderer.FactionEventPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEventsForFactionRenderer>.NativeClassPtr, "FactionEventPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsForFactionRenderer.FactionEventPair>.NativeClassPtr);
				WormEventsForFactionRenderer.FactionEventPair.NativeFieldInfoPtr_Faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForFactionRenderer.FactionEventPair>.NativeClassPtr, "Faction");
				WormEventsForFactionRenderer.FactionEventPair.NativeFieldInfoPtr_OnAssignFaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForFactionRenderer.FactionEventPair>.NativeClassPtr, "OnAssignFaction");
				WormEventsForFactionRenderer.FactionEventPair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForFactionRenderer.FactionEventPair>.NativeClassPtr, 100665063);
			}

			// Token: 0x060023D1 RID: 9169 RVA: 0x00084A88 File Offset: 0x00082C88
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FactionEventPair()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsForFactionRenderer.FactionEventPair>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForFactionRenderer.FactionEventPair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023D2 RID: 9170 RVA: 0x00013FBB File Offset: 0x000121BB
			public FactionEventPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009E4 RID: 2532
			// (get) Token: 0x060023D3 RID: 9171 RVA: 0x00084AC4 File Offset: 0x00082CC4
			// (set) Token: 0x060023D4 RID: 9172 RVA: 0x00013FC4 File Offset: 0x000121C4
			public unsafe Factions Faction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForFactionRenderer.FactionEventPair.NativeFieldInfoPtr_Faction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForFactionRenderer.FactionEventPair.NativeFieldInfoPtr_Faction)) = value;
				}
			}

			// Token: 0x170009E5 RID: 2533
			// (get) Token: 0x060023D5 RID: 9173 RVA: 0x00084AEC File Offset: 0x00082CEC
			// (set) Token: 0x060023D6 RID: 9174 RVA: 0x00013FDF File Offset: 0x000121DF
			public unsafe UnityEvent OnAssignFaction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForFactionRenderer.FactionEventPair.NativeFieldInfoPtr_OnAssignFaction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForFactionRenderer.FactionEventPair.NativeFieldInfoPtr_OnAssignFaction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400148C RID: 5260
			private static readonly IntPtr NativeFieldInfoPtr_Faction;

			// Token: 0x0400148D RID: 5261
			private static readonly IntPtr NativeFieldInfoPtr_OnAssignFaction;

			// Token: 0x0400148E RID: 5262
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

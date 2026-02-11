using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001F1 RID: 497
	public class WormEventsForRegisteredParentName : MonoBehaviour
	{
		// Token: 0x060015FE RID: 5630 RVA: 0x0005AF20 File Offset: 0x00059120
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventsForRegisteredParentName()
		{
			Il2CppClassPointerStore<WormEventsForRegisteredParentName>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormEventsForRegisteredParentName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsForRegisteredParentName>.NativeClassPtr);
			WormEventsForRegisteredParentName.NativeFieldInfoPtr_matchParentEntityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForRegisteredParentName>.NativeClassPtr, "matchParentEntityName");
			WormEventsForRegisteredParentName.NativeFieldInfoPtr_viewLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForRegisteredParentName>.NativeClassPtr, "viewLayer");
			WormEventsForRegisteredParentName.NativeFieldInfoPtr_onMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForRegisteredParentName>.NativeClassPtr, "onMatch");
			WormEventsForRegisteredParentName.NativeFieldInfoPtr_viewManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForRegisteredParentName>.NativeClassPtr, "viewManager");
			WormEventsForRegisteredParentName.NativeFieldInfoPtr_lastParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForRegisteredParentName>.NativeClassPtr, "lastParent");
			WormEventsForRegisteredParentName.NativeFieldInfoPtr_view = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForRegisteredParentName>.NativeClassPtr, "view");
			WormEventsForRegisteredParentName.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForRegisteredParentName>.NativeClassPtr, 100666329);
			WormEventsForRegisteredParentName.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForRegisteredParentName>.NativeClassPtr, 100666330);
			WormEventsForRegisteredParentName.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForRegisteredParentName>.NativeClassPtr, 100666331);
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x0005B004 File Offset: 0x00059204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715982, XrefRangeEnd = 715989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForRegisteredParentName.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x0005B038 File Offset: 0x00059238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715989, XrefRangeEnd = 716020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForRegisteredParentName.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x0005B06C File Offset: 0x0005926C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716020, XrefRangeEnd = 716029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventsForRegisteredParentName()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsForRegisteredParentName>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForRegisteredParentName.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x0000D476 File Offset: 0x0000B676
		public WormEventsForRegisteredParentName(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06001603 RID: 5635 RVA: 0x0005B0A8 File Offset: 0x000592A8
		// (set) Token: 0x06001604 RID: 5636 RVA: 0x0000D47F File Offset: 0x0000B67F
		public unsafe string matchParentEntityName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForRegisteredParentName.NativeFieldInfoPtr_matchParentEntityName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForRegisteredParentName.NativeFieldInfoPtr_matchParentEntityName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06001605 RID: 5637 RVA: 0x0005B0D0 File Offset: 0x000592D0
		// (set) Token: 0x06001606 RID: 5638 RVA: 0x0000D49E File Offset: 0x0000B69E
		public unsafe int viewLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForRegisteredParentName.NativeFieldInfoPtr_viewLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForRegisteredParentName.NativeFieldInfoPtr_viewLayer)) = value;
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06001607 RID: 5639 RVA: 0x0005B0F8 File Offset: 0x000592F8
		// (set) Token: 0x06001608 RID: 5640 RVA: 0x0000D4B9 File Offset: 0x0000B6B9
		public unsafe BoolUnityEvents onMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForRegisteredParentName.NativeFieldInfoPtr_onMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolUnityEvents>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForRegisteredParentName.NativeFieldInfoPtr_onMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06001609 RID: 5641 RVA: 0x0005B128 File Offset: 0x00059328
		// (set) Token: 0x0600160A RID: 5642 RVA: 0x0000D4D8 File Offset: 0x0000B6D8
		public unsafe ViewManager viewManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForRegisteredParentName.NativeFieldInfoPtr_viewManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ViewManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForRegisteredParentName.NativeFieldInfoPtr_viewManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x0600160B RID: 5643 RVA: 0x0005B158 File Offset: 0x00059358
		// (set) Token: 0x0600160C RID: 5644 RVA: 0x0000D4F7 File Offset: 0x0000B6F7
		public unsafe EntityView lastParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForRegisteredParentName.NativeFieldInfoPtr_lastParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForRegisteredParentName.NativeFieldInfoPtr_lastParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x0600160D RID: 5645 RVA: 0x0005B188 File Offset: 0x00059388
		// (set) Token: 0x0600160E RID: 5646 RVA: 0x0000D516 File Offset: 0x0000B716
		public unsafe EntityView view
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForRegisteredParentName.NativeFieldInfoPtr_view);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForRegisteredParentName.NativeFieldInfoPtr_view), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CC4 RID: 3268
		private static readonly IntPtr NativeFieldInfoPtr_matchParentEntityName;

		// Token: 0x04000CC5 RID: 3269
		private static readonly IntPtr NativeFieldInfoPtr_viewLayer;

		// Token: 0x04000CC6 RID: 3270
		private static readonly IntPtr NativeFieldInfoPtr_onMatch;

		// Token: 0x04000CC7 RID: 3271
		private static readonly IntPtr NativeFieldInfoPtr_viewManager;

		// Token: 0x04000CC8 RID: 3272
		private static readonly IntPtr NativeFieldInfoPtr_lastParent;

		// Token: 0x04000CC9 RID: 3273
		private static readonly IntPtr NativeFieldInfoPtr_view;

		// Token: 0x04000CCA RID: 3274
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000CCB RID: 3275
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000CCC RID: 3276
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using dwd.core.match.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine.Events;

namespace worm.match.dataRenderers
{
	// Token: 0x020000F7 RID: 247
	public class WormAgentRenderer : Observer
	{
		// Token: 0x06000AE1 RID: 2785 RVA: 0x00039280 File Offset: 0x00037480
		// Note: this type is marked as 'beforefieldinit'.
		static WormAgentRenderer()
		{
			Il2CppClassPointerStore<WormAgentRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormAgentRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAgentRenderer>.NativeClassPtr);
			WormAgentRenderer.NativeFieldInfoPtr_imageNameEventPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAgentRenderer>.NativeClassPtr, "imageNameEventPairs");
			WormAgentRenderer.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAgentRenderer>.NativeClassPtr, "entitiesProvider");
			WormAgentRenderer.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAgentRenderer>.NativeClassPtr, "initialized");
			WormAgentRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAgentRenderer>.NativeClassPtr, 100664794);
			WormAgentRenderer.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAgentRenderer>.NativeClassPtr, 100664795);
			WormAgentRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAgentRenderer>.NativeClassPtr, 100664796);
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x00039328 File Offset: 0x00037528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702182, XrefRangeEnd = 702185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAgentRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x00039364 File Offset: 0x00037564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702185, XrefRangeEnd = 702226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAgentRenderer.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00039398 File Offset: 0x00037598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702226, XrefRangeEnd = 702234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAgentRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAgentRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAgentRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x00007B3E File Offset: 0x00005D3E
		public WormAgentRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x000393D4 File Offset: 0x000375D4
		// (set) Token: 0x06000AE7 RID: 2791 RVA: 0x00007B47 File Offset: 0x00005D47
		public unsafe List<WormAgentRenderer.ImageNameEventPair> imageNameEventPairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAgentRenderer.NativeFieldInfoPtr_imageNameEventPairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormAgentRenderer.ImageNameEventPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAgentRenderer.NativeFieldInfoPtr_imageNameEventPairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x00039404 File Offset: 0x00037604
		// (set) Token: 0x06000AE9 RID: 2793 RVA: 0x00007B66 File Offset: 0x00005D66
		public unsafe EntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAgentRenderer.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAgentRenderer.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000AEA RID: 2794 RVA: 0x00039434 File Offset: 0x00037634
		// (set) Token: 0x06000AEB RID: 2795 RVA: 0x00007B85 File Offset: 0x00005D85
		public unsafe bool initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAgentRenderer.NativeFieldInfoPtr_initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAgentRenderer.NativeFieldInfoPtr_initialized)) = value;
			}
		}

		// Token: 0x04000647 RID: 1607
		private static readonly IntPtr NativeFieldInfoPtr_imageNameEventPairs;

		// Token: 0x04000648 RID: 1608
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x04000649 RID: 1609
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x0400064A RID: 1610
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400064B RID: 1611
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400064C RID: 1612
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000358 RID: 856
		[Serializable]
		public class ImageNameEventPair : Object
		{
			// Token: 0x06002294 RID: 8852 RVA: 0x00081264 File Offset: 0x0007F464
			// Note: this type is marked as 'beforefieldinit'.
			static ImageNameEventPair()
			{
				Il2CppClassPointerStore<WormAgentRenderer.ImageNameEventPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAgentRenderer>.NativeClassPtr, "ImageNameEventPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAgentRenderer.ImageNameEventPair>.NativeClassPtr);
				WormAgentRenderer.ImageNameEventPair.NativeFieldInfoPtr_imageName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAgentRenderer.ImageNameEventPair>.NativeClassPtr, "imageName");
				WormAgentRenderer.ImageNameEventPair.NativeFieldInfoPtr_onAssignImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAgentRenderer.ImageNameEventPair>.NativeClassPtr, "onAssignImage");
				WormAgentRenderer.ImageNameEventPair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAgentRenderer.ImageNameEventPair>.NativeClassPtr, 100664797);
			}

			// Token: 0x06002295 RID: 8853 RVA: 0x000812CC File Offset: 0x0007F4CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702173, XrefRangeEnd = 702182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ImageNameEventPair()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAgentRenderer.ImageNameEventPair>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAgentRenderer.ImageNameEventPair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002296 RID: 8854 RVA: 0x000135EB File Offset: 0x000117EB
			public ImageNameEventPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700098B RID: 2443
			// (get) Token: 0x06002297 RID: 8855 RVA: 0x00081308 File Offset: 0x0007F508
			// (set) Token: 0x06002298 RID: 8856 RVA: 0x000135F4 File Offset: 0x000117F4
			public unsafe string imageName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAgentRenderer.ImageNameEventPair.NativeFieldInfoPtr_imageName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAgentRenderer.ImageNameEventPair.NativeFieldInfoPtr_imageName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700098C RID: 2444
			// (get) Token: 0x06002299 RID: 8857 RVA: 0x00081330 File Offset: 0x0007F530
			// (set) Token: 0x0600229A RID: 8858 RVA: 0x00013613 File Offset: 0x00011813
			public unsafe UnityEvent onAssignImage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAgentRenderer.ImageNameEventPair.NativeFieldInfoPtr_onAssignImage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAgentRenderer.ImageNameEventPair.NativeFieldInfoPtr_onAssignImage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013E4 RID: 5092
			private static readonly IntPtr NativeFieldInfoPtr_imageName;

			// Token: 0x040013E5 RID: 5093
			private static readonly IntPtr NativeFieldInfoPtr_onAssignImage;

			// Token: 0x040013E6 RID: 5094
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

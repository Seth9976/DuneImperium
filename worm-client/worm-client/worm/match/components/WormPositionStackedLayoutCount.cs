using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace worm.match.components
{
	// Token: 0x02000209 RID: 521
	public class WormPositionStackedLayoutCount : MonoBehaviour
	{
		// Token: 0x06001711 RID: 5905 RVA: 0x0005E0E4 File Offset: 0x0005C2E4
		// Note: this type is marked as 'beforefieldinit'.
		static WormPositionStackedLayoutCount()
		{
			Il2CppClassPointerStore<WormPositionStackedLayoutCount>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormPositionStackedLayoutCount");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPositionStackedLayoutCount>.NativeClassPtr);
			WormPositionStackedLayoutCount.NativeFieldInfoPtr_slotLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPositionStackedLayoutCount>.NativeClassPtr, "slotLayout");
			WormPositionStackedLayoutCount.NativeFieldInfoPtr_countTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPositionStackedLayoutCount>.NativeClassPtr, "countTransform");
			WormPositionStackedLayoutCount.NativeFieldInfoPtr_xPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPositionStackedLayoutCount>.NativeClassPtr, "xPadding");
			WormPositionStackedLayoutCount.NativeFieldInfoPtr_slotTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPositionStackedLayoutCount>.NativeClassPtr, "slotTransform");
			WormPositionStackedLayoutCount.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPositionStackedLayoutCount>.NativeClassPtr, 100666495);
			WormPositionStackedLayoutCount.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPositionStackedLayoutCount>.NativeClassPtr, 100666496);
			WormPositionStackedLayoutCount.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPositionStackedLayoutCount>.NativeClassPtr, 100666497);
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x0005E1A0 File Offset: 0x0005C3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717076, XrefRangeEnd = 717081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPositionStackedLayoutCount.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x0005E1D4 File Offset: 0x0005C3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717081, XrefRangeEnd = 717089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPositionStackedLayoutCount.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x0005E208 File Offset: 0x0005C408
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPositionStackedLayoutCount()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPositionStackedLayoutCount>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPositionStackedLayoutCount.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x0000DD70 File Offset: 0x0000BF70
		public WormPositionStackedLayoutCount(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06001716 RID: 5910 RVA: 0x0005E244 File Offset: 0x0005C444
		// (set) Token: 0x06001717 RID: 5911 RVA: 0x0000DD79 File Offset: 0x0000BF79
		public unsafe LayoutElement slotLayout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPositionStackedLayoutCount.NativeFieldInfoPtr_slotLayout);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LayoutElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPositionStackedLayoutCount.NativeFieldInfoPtr_slotLayout), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001718 RID: 5912 RVA: 0x0005E274 File Offset: 0x0005C474
		// (set) Token: 0x06001719 RID: 5913 RVA: 0x0000DD98 File Offset: 0x0000BF98
		public unsafe RectTransform countTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPositionStackedLayoutCount.NativeFieldInfoPtr_countTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPositionStackedLayoutCount.NativeFieldInfoPtr_countTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x0600171A RID: 5914 RVA: 0x0005E2A4 File Offset: 0x0005C4A4
		// (set) Token: 0x0600171B RID: 5915 RVA: 0x0000DDB7 File Offset: 0x0000BFB7
		public unsafe float xPadding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPositionStackedLayoutCount.NativeFieldInfoPtr_xPadding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPositionStackedLayoutCount.NativeFieldInfoPtr_xPadding)) = value;
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x0600171C RID: 5916 RVA: 0x0005E2CC File Offset: 0x0005C4CC
		// (set) Token: 0x0600171D RID: 5917 RVA: 0x0000DDD2 File Offset: 0x0000BFD2
		public unsafe RectTransform slotTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPositionStackedLayoutCount.NativeFieldInfoPtr_slotTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPositionStackedLayoutCount.NativeFieldInfoPtr_slotTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D62 RID: 3426
		private static readonly IntPtr NativeFieldInfoPtr_slotLayout;

		// Token: 0x04000D63 RID: 3427
		private static readonly IntPtr NativeFieldInfoPtr_countTransform;

		// Token: 0x04000D64 RID: 3428
		private static readonly IntPtr NativeFieldInfoPtr_xPadding;

		// Token: 0x04000D65 RID: 3429
		private static readonly IntPtr NativeFieldInfoPtr_slotTransform;

		// Token: 0x04000D66 RID: 3430
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000D67 RID: 3431
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000D68 RID: 3432
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

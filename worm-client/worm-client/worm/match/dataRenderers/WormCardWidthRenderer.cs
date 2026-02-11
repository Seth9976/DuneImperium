using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine.UI;

namespace worm.match.dataRenderers
{
	// Token: 0x02000101 RID: 257
	public class WormCardWidthRenderer : Observer
	{
		// Token: 0x06000B85 RID: 2949 RVA: 0x0003AFDC File Offset: 0x000391DC
		// Note: this type is marked as 'beforefieldinit'.
		static WormCardWidthRenderer()
		{
			Il2CppClassPointerStore<WormCardWidthRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormCardWidthRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormCardWidthRenderer>.NativeClassPtr);
			WormCardWidthRenderer.NativeFieldInfoPtr_regularWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCardWidthRenderer>.NativeClassPtr, "regularWidth");
			WormCardWidthRenderer.NativeFieldInfoPtr_hagalWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCardWidthRenderer>.NativeClassPtr, "hagalWidth");
			WormCardWidthRenderer.NativeFieldInfoPtr_layout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCardWidthRenderer>.NativeClassPtr, "layout");
			WormCardWidthRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCardWidthRenderer>.NativeClassPtr, 100664886);
			WormCardWidthRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCardWidthRenderer>.NativeClassPtr, 100664887);
			WormCardWidthRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCardWidthRenderer>.NativeClassPtr, 100664888);
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x0003B084 File Offset: 0x00039284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703273, XrefRangeEnd = 703278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormCardWidthRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x0003B0C0 File Offset: 0x000392C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703278, XrefRangeEnd = 703286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormCardWidthRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x0003B0FC File Offset: 0x000392FC
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormCardWidthRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormCardWidthRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCardWidthRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x0000814B File Offset: 0x0000634B
		public WormCardWidthRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000B8A RID: 2954 RVA: 0x0003B138 File Offset: 0x00039338
		// (set) Token: 0x06000B8B RID: 2955 RVA: 0x00008154 File Offset: 0x00006354
		public unsafe float regularWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardWidthRenderer.NativeFieldInfoPtr_regularWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardWidthRenderer.NativeFieldInfoPtr_regularWidth)) = value;
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000B8C RID: 2956 RVA: 0x0003B160 File Offset: 0x00039360
		// (set) Token: 0x06000B8D RID: 2957 RVA: 0x0000816F File Offset: 0x0000636F
		public unsafe float hagalWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardWidthRenderer.NativeFieldInfoPtr_hagalWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardWidthRenderer.NativeFieldInfoPtr_hagalWidth)) = value;
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000B8E RID: 2958 RVA: 0x0003B188 File Offset: 0x00039388
		// (set) Token: 0x06000B8F RID: 2959 RVA: 0x0000818A File Offset: 0x0000638A
		public unsafe LayoutElement layout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardWidthRenderer.NativeFieldInfoPtr_layout);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LayoutElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardWidthRenderer.NativeFieldInfoPtr_layout), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006A6 RID: 1702
		private static readonly IntPtr NativeFieldInfoPtr_regularWidth;

		// Token: 0x040006A7 RID: 1703
		private static readonly IntPtr NativeFieldInfoPtr_hagalWidth;

		// Token: 0x040006A8 RID: 1704
		private static readonly IntPtr NativeFieldInfoPtr_layout;

		// Token: 0x040006A9 RID: 1705
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040006AA RID: 1706
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x040006AB RID: 1707
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

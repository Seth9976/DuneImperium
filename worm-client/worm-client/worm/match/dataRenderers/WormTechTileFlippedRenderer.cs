using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using voodoo;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x0200016A RID: 362
	public class WormTechTileFlippedRenderer : VersionedDataComponentObserver<WormTechTileFlippedData>
	{
		// Token: 0x06001024 RID: 4132 RVA: 0x000488A4 File Offset: 0x00046AA4
		// Note: this type is marked as 'beforefieldinit'.
		static WormTechTileFlippedRenderer()
		{
			Il2CppClassPointerStore<WormTechTileFlippedRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormTechTileFlippedRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTechTileFlippedRenderer>.NativeClassPtr);
			WormTechTileFlippedRenderer.NativeFieldInfoPtr_anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTechTileFlippedRenderer>.NativeClassPtr, "anim");
			WormTechTileFlippedRenderer.NativeFieldInfoPtr_Flipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTechTileFlippedRenderer>.NativeClassPtr, "Flipped");
			WormTechTileFlippedRenderer.NativeFieldInfoPtr_FlipImmediate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTechTileFlippedRenderer>.NativeClassPtr, "FlipImmediate");
			WormTechTileFlippedRenderer.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTileFlippedRenderer>.NativeClassPtr, 100665483);
			WormTechTileFlippedRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTileFlippedRenderer>.NativeClassPtr, 100665484);
			WormTechTileFlippedRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTileFlippedRenderer>.NativeClassPtr, 100665485);
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x0004894C File Offset: 0x00046B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709022, XrefRangeEnd = 709033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechTileFlippedRenderer.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x00048980 File Offset: 0x00046B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709033, XrefRangeEnd = 709045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTechTileFlippedRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x000489BC File Offset: 0x00046BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709045, XrefRangeEnd = 709048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTechTileFlippedRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTechTileFlippedRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechTileFlippedRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x0000A7ED File Offset: 0x000089ED
		public WormTechTileFlippedRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06001029 RID: 4137 RVA: 0x000489F8 File Offset: 0x00046BF8
		// (set) Token: 0x0600102A RID: 4138 RVA: 0x0000A7F6 File Offset: 0x000089F6
		public unsafe Animator anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechTileFlippedRenderer.NativeFieldInfoPtr_anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechTileFlippedRenderer.NativeFieldInfoPtr_anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x0600102B RID: 4139 RVA: 0x00048A28 File Offset: 0x00046C28
		// (set) Token: 0x0600102C RID: 4140 RVA: 0x0000A815 File Offset: 0x00008A15
		public unsafe static int Flipped
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormTechTileFlippedRenderer.NativeFieldInfoPtr_Flipped, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTechTileFlippedRenderer.NativeFieldInfoPtr_Flipped, (void*)(&value));
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x0600102D RID: 4141 RVA: 0x00048A44 File Offset: 0x00046C44
		// (set) Token: 0x0600102E RID: 4142 RVA: 0x0000A823 File Offset: 0x00008A23
		public unsafe static int FlipImmediate
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormTechTileFlippedRenderer.NativeFieldInfoPtr_FlipImmediate, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTechTileFlippedRenderer.NativeFieldInfoPtr_FlipImmediate, (void*)(&value));
			}
		}

		// Token: 0x04000948 RID: 2376
		private static readonly IntPtr NativeFieldInfoPtr_anim;

		// Token: 0x04000949 RID: 2377
		private static readonly IntPtr NativeFieldInfoPtr_Flipped;

		// Token: 0x0400094A RID: 2378
		private static readonly IntPtr NativeFieldInfoPtr_FlipImmediate;

		// Token: 0x0400094B RID: 2379
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400094C RID: 2380
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x0400094D RID: 2381
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

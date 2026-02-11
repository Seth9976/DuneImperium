using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using voodoo;

namespace worm.match.dataRenderers
{
	// Token: 0x02000106 RID: 262
	public class WormColorAnimatorRenderer : VersionedDataComponentObserver<BasicDescription>
	{
		// Token: 0x06000BB9 RID: 3001 RVA: 0x0003B954 File Offset: 0x00039B54
		// Note: this type is marked as 'beforefieldinit'.
		static WormColorAnimatorRenderer()
		{
			Il2CppClassPointerStore<WormColorAnimatorRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormColorAnimatorRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormColorAnimatorRenderer>.NativeClassPtr);
			WormColorAnimatorRenderer.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormColorAnimatorRenderer>.NativeClassPtr, "animator");
			WormColorAnimatorRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormColorAnimatorRenderer>.NativeClassPtr, 100664909);
			WormColorAnimatorRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormColorAnimatorRenderer>.NativeClassPtr, 100664910);
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x0003B9C0 File Offset: 0x00039BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703613, XrefRangeEnd = 703616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormColorAnimatorRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x0003B9FC File Offset: 0x00039BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703616, XrefRangeEnd = 703619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormColorAnimatorRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormColorAnimatorRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormColorAnimatorRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x00008303 File Offset: 0x00006503
		public WormColorAnimatorRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000BBD RID: 3005 RVA: 0x0003BA38 File Offset: 0x00039C38
		// (set) Token: 0x06000BBE RID: 3006 RVA: 0x0000830C File Offset: 0x0000650C
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormColorAnimatorRenderer.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormColorAnimatorRenderer.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

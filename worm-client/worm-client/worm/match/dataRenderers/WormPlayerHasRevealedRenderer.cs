using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using voodoo;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x0200014C RID: 332
	public class WormPlayerHasRevealedRenderer : VersionedDataComponentObserver<WormHasRevealedData>
	{
		// Token: 0x06000EE2 RID: 3810 RVA: 0x00044E24 File Offset: 0x00043024
		// Note: this type is marked as 'beforefieldinit'.
		static WormPlayerHasRevealedRenderer()
		{
			Il2CppClassPointerStore<WormPlayerHasRevealedRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormPlayerHasRevealedRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerHasRevealedRenderer>.NativeClassPtr);
			WormPlayerHasRevealedRenderer.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerHasRevealedRenderer>.NativeClassPtr, "animator");
			WormPlayerHasRevealedRenderer.NativeFieldInfoPtr_RevealParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerHasRevealedRenderer>.NativeClassPtr, "RevealParam");
			WormPlayerHasRevealedRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerHasRevealedRenderer>.NativeClassPtr, 100665302);
			WormPlayerHasRevealedRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerHasRevealedRenderer>.NativeClassPtr, 100665303);
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x00044EA4 File Offset: 0x000430A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707078, XrefRangeEnd = 707085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayerHasRevealedRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x00044EE0 File Offset: 0x000430E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707085, XrefRangeEnd = 707088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayerHasRevealedRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerHasRevealedRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerHasRevealedRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x00009D64 File Offset: 0x00007F64
		public WormPlayerHasRevealedRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000EE6 RID: 3814 RVA: 0x00044F1C File Offset: 0x0004311C
		// (set) Token: 0x06000EE7 RID: 3815 RVA: 0x00009D6D File Offset: 0x00007F6D
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerHasRevealedRenderer.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerHasRevealedRenderer.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000EE8 RID: 3816 RVA: 0x00044F4C File Offset: 0x0004314C
		// (set) Token: 0x06000EE9 RID: 3817 RVA: 0x00009D8C File Offset: 0x00007F8C
		public unsafe static int RevealParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormPlayerHasRevealedRenderer.NativeFieldInfoPtr_RevealParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPlayerHasRevealedRenderer.NativeFieldInfoPtr_RevealParam, (void*)(&value));
			}
		}

		// Token: 0x04000893 RID: 2195
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x04000894 RID: 2196
		private static readonly IntPtr NativeFieldInfoPtr_RevealParam;

		// Token: 0x04000895 RID: 2197
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x04000896 RID: 2198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace worm.match.dataRenderers
{
	// Token: 0x02000138 RID: 312
	public class WormHasDreadnoughtRenderer : VersionedView<IAttribute<Nullable<bool>>>
	{
		// Token: 0x06000E0F RID: 3599 RVA: 0x000428A8 File Offset: 0x00040AA8
		// Note: this type is marked as 'beforefieldinit'.
		static WormHasDreadnoughtRenderer()
		{
			Il2CppClassPointerStore<WormHasDreadnoughtRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormHasDreadnoughtRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormHasDreadnoughtRenderer>.NativeClassPtr);
			WormHasDreadnoughtRenderer.NativeFieldInfoPtr_dreadnoughtObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHasDreadnoughtRenderer>.NativeClassPtr, "dreadnoughtObject");
			WormHasDreadnoughtRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHasDreadnoughtRenderer>.NativeClassPtr, 100665203);
			WormHasDreadnoughtRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHasDreadnoughtRenderer>.NativeClassPtr, 100665204);
			WormHasDreadnoughtRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHasDreadnoughtRenderer>.NativeClassPtr, 100665205);
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x00042928 File Offset: 0x00040B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706195, XrefRangeEnd = 706208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormHasDreadnoughtRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x00042964 File Offset: 0x00040B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706208, XrefRangeEnd = 706214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormHasDreadnoughtRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x000429A0 File Offset: 0x00040BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706214, XrefRangeEnd = 706217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormHasDreadnoughtRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormHasDreadnoughtRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHasDreadnoughtRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x00009676 File Offset: 0x00007876
		public WormHasDreadnoughtRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000E14 RID: 3604 RVA: 0x000429DC File Offset: 0x00040BDC
		// (set) Token: 0x06000E15 RID: 3605 RVA: 0x0000967F File Offset: 0x0000787F
		public unsafe GameObject dreadnoughtObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHasDreadnoughtRenderer.NativeFieldInfoPtr_dreadnoughtObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHasDreadnoughtRenderer.NativeFieldInfoPtr_dreadnoughtObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400081E RID: 2078
		private static readonly IntPtr NativeFieldInfoPtr_dreadnoughtObject;

		// Token: 0x0400081F RID: 2079
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000820 RID: 2080
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000821 RID: 2081
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine.UI;

namespace worm.match.dataRenderers
{
	// Token: 0x0200014E RID: 334
	public class WormPlayerLeaderSelectedRenderer : Observer
	{
		// Token: 0x06000EF0 RID: 3824 RVA: 0x0004507C File Offset: 0x0004327C
		// Note: this type is marked as 'beforefieldinit'.
		static WormPlayerLeaderSelectedRenderer()
		{
			Il2CppClassPointerStore<WormPlayerLeaderSelectedRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormPlayerLeaderSelectedRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerLeaderSelectedRenderer>.NativeClassPtr);
			WormPlayerLeaderSelectedRenderer.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerLeaderSelectedRenderer>.NativeClassPtr, "image");
			WormPlayerLeaderSelectedRenderer.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerLeaderSelectedRenderer>.NativeClassPtr, "entities");
			WormPlayerLeaderSelectedRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerLeaderSelectedRenderer>.NativeClassPtr, 100665312);
			WormPlayerLeaderSelectedRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerLeaderSelectedRenderer>.NativeClassPtr, 100665313);
			WormPlayerLeaderSelectedRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerLeaderSelectedRenderer>.NativeClassPtr, 100665314);
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x00045110 File Offset: 0x00043310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707185, XrefRangeEnd = 707198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayerLeaderSelectedRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x0004514C File Offset: 0x0004334C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707198, XrefRangeEnd = 707206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayerLeaderSelectedRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x00045188 File Offset: 0x00043388
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayerLeaderSelectedRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerLeaderSelectedRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerLeaderSelectedRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x00009DC2 File Offset: 0x00007FC2
		public WormPlayerLeaderSelectedRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000EF5 RID: 3829 RVA: 0x000451C4 File Offset: 0x000433C4
		// (set) Token: 0x06000EF6 RID: 3830 RVA: 0x00009DCB File Offset: 0x00007FCB
		public unsafe Image image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerLeaderSelectedRenderer.NativeFieldInfoPtr_image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerLeaderSelectedRenderer.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000EF7 RID: 3831 RVA: 0x000451F4 File Offset: 0x000433F4
		// (set) Token: 0x06000EF8 RID: 3832 RVA: 0x00009DEA File Offset: 0x00007FEA
		public unsafe WormEntities entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerLeaderSelectedRenderer.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEntities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerLeaderSelectedRenderer.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400089A RID: 2202
		private static readonly IntPtr NativeFieldInfoPtr_image;

		// Token: 0x0400089B RID: 2203
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x0400089C RID: 2204
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400089D RID: 2205
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x0400089E RID: 2206
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

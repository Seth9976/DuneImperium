using System;
using boardgames.match.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using worm.canis.data.enums;

namespace worm.match.dataRenderers
{
	// Token: 0x0200013B RID: 315
	public class WormHideForHagalRenderer : Observer
	{
		// Token: 0x06000E28 RID: 3624 RVA: 0x00042D50 File Offset: 0x00040F50
		// Note: this type is marked as 'beforefieldinit'.
		static WormHideForHagalRenderer()
		{
			Il2CppClassPointerStore<WormHideForHagalRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormHideForHagalRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormHideForHagalRenderer>.NativeClassPtr);
			WormHideForHagalRenderer.NativeFieldInfoPtr_hideInModes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHideForHagalRenderer>.NativeClassPtr, "hideInModes");
			WormHideForHagalRenderer.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHideForHagalRenderer>.NativeClassPtr, "entitiesProvider");
			WormHideForHagalRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHideForHagalRenderer>.NativeClassPtr, 100665218);
			WormHideForHagalRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHideForHagalRenderer>.NativeClassPtr, 100665219);
			WormHideForHagalRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHideForHagalRenderer>.NativeClassPtr, 100665220);
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x00042DE4 File Offset: 0x00040FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706275, XrefRangeEnd = 706279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormHideForHagalRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x00042E20 File Offset: 0x00041020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706279, XrefRangeEnd = 706317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormHideForHagalRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x00042E5C File Offset: 0x0004105C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706317, XrefRangeEnd = 706325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormHideForHagalRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormHideForHagalRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHideForHagalRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x00009728 File Offset: 0x00007928
		public WormHideForHagalRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000E2D RID: 3629 RVA: 0x00042E98 File Offset: 0x00041098
		// (set) Token: 0x06000E2E RID: 3630 RVA: 0x00009731 File Offset: 0x00007931
		public unsafe Il2CppStructArray<HagalModes> hideInModes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHideForHagalRenderer.NativeFieldInfoPtr_hideInModes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<HagalModes>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHideForHagalRenderer.NativeFieldInfoPtr_hideInModes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000E2F RID: 3631 RVA: 0x00042EC8 File Offset: 0x000410C8
		// (set) Token: 0x06000E30 RID: 3632 RVA: 0x00009750 File Offset: 0x00007950
		public unsafe DBGEntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHideForHagalRenderer.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHideForHagalRenderer.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeFieldInfoPtr_hideInModes;

		// Token: 0x0400082D RID: 2093
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x0400082E RID: 2094
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400082F RID: 2095
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x04000830 RID: 2096
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

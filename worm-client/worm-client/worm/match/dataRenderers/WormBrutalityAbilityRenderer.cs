using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace worm.match.dataRenderers
{
	// Token: 0x020000FD RID: 253
	public class WormBrutalityAbilityRenderer : VersionedView<EntityComponent>
	{
		// Token: 0x06000B51 RID: 2897 RVA: 0x0003A6BC File Offset: 0x000388BC
		// Note: this type is marked as 'beforefieldinit'.
		static WormBrutalityAbilityRenderer()
		{
			Il2CppClassPointerStore<WormBrutalityAbilityRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormBrutalityAbilityRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormBrutalityAbilityRenderer>.NativeClassPtr);
			WormBrutalityAbilityRenderer.NativeFieldInfoPtr_oneTroop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBrutalityAbilityRenderer>.NativeClassPtr, "oneTroop");
			WormBrutalityAbilityRenderer.NativeFieldInfoPtr_twoTroops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBrutalityAbilityRenderer>.NativeClassPtr, "twoTroops");
			WormBrutalityAbilityRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBrutalityAbilityRenderer>.NativeClassPtr, 100664863);
			WormBrutalityAbilityRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBrutalityAbilityRenderer>.NativeClassPtr, 100664864);
			WormBrutalityAbilityRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBrutalityAbilityRenderer>.NativeClassPtr, 100664865);
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x0003A750 File Offset: 0x00038950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703043, XrefRangeEnd = 703060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormBrutalityAbilityRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x0003A78C File Offset: 0x0003898C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703060, XrefRangeEnd = 703068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormBrutalityAbilityRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x0003A7C8 File Offset: 0x000389C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703068, XrefRangeEnd = 703071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormBrutalityAbilityRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormBrutalityAbilityRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBrutalityAbilityRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00007F4B File Offset: 0x0000614B
		public WormBrutalityAbilityRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000B56 RID: 2902 RVA: 0x0003A804 File Offset: 0x00038A04
		// (set) Token: 0x06000B57 RID: 2903 RVA: 0x00007F54 File Offset: 0x00006154
		public unsafe GameObject oneTroop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBrutalityAbilityRenderer.NativeFieldInfoPtr_oneTroop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBrutalityAbilityRenderer.NativeFieldInfoPtr_oneTroop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000B58 RID: 2904 RVA: 0x0003A834 File Offset: 0x00038A34
		// (set) Token: 0x06000B59 RID: 2905 RVA: 0x00007F73 File Offset: 0x00006173
		public unsafe GameObject twoTroops
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBrutalityAbilityRenderer.NativeFieldInfoPtr_twoTroops);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBrutalityAbilityRenderer.NativeFieldInfoPtr_twoTroops), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000689 RID: 1673
		private static readonly IntPtr NativeFieldInfoPtr_oneTroop;

		// Token: 0x0400068A RID: 1674
		private static readonly IntPtr NativeFieldInfoPtr_twoTroops;

		// Token: 0x0400068B RID: 1675
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400068C RID: 1676
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400068D RID: 1677
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

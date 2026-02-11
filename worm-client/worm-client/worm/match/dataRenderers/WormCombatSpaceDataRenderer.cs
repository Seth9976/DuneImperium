using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using voodoo;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x02000109 RID: 265
	public class WormCombatSpaceDataRenderer : VersionedDataComponentObserver<WormCombatSpaceData>
	{
		// Token: 0x06000BD0 RID: 3024 RVA: 0x0003BDEC File Offset: 0x00039FEC
		// Note: this type is marked as 'beforefieldinit'.
		static WormCombatSpaceDataRenderer()
		{
			Il2CppClassPointerStore<WormCombatSpaceDataRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormCombatSpaceDataRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormCombatSpaceDataRenderer>.NativeClassPtr);
			WormCombatSpaceDataRenderer.NativeFieldInfoPtr_combatSpaceIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCombatSpaceDataRenderer>.NativeClassPtr, "combatSpaceIcon");
			WormCombatSpaceDataRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCombatSpaceDataRenderer>.NativeClassPtr, 100664924);
			WormCombatSpaceDataRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCombatSpaceDataRenderer>.NativeClassPtr, 100664925);
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x0003BE58 File Offset: 0x0003A058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703690, XrefRangeEnd = 703696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormCombatSpaceDataRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x0003BE94 File Offset: 0x0003A094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703696, XrefRangeEnd = 703699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormCombatSpaceDataRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormCombatSpaceDataRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCombatSpaceDataRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x0000839A File Offset: 0x0000659A
		public WormCombatSpaceDataRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000BD4 RID: 3028 RVA: 0x0003BED0 File Offset: 0x0003A0D0
		// (set) Token: 0x06000BD5 RID: 3029 RVA: 0x000083A3 File Offset: 0x000065A3
		public unsafe GameObject combatSpaceIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCombatSpaceDataRenderer.NativeFieldInfoPtr_combatSpaceIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCombatSpaceDataRenderer.NativeFieldInfoPtr_combatSpaceIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeFieldInfoPtr_combatSpaceIcon;

		// Token: 0x040006D1 RID: 1745
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x040006D2 RID: 1746
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

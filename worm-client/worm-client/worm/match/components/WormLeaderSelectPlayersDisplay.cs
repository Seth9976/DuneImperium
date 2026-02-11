using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x02000200 RID: 512
	public class WormLeaderSelectPlayersDisplay : MonoBehaviour
	{
		// Token: 0x060016AF RID: 5807 RVA: 0x0005CEF4 File Offset: 0x0005B0F4
		// Note: this type is marked as 'beforefieldinit'.
		static WormLeaderSelectPlayersDisplay()
		{
			Il2CppClassPointerStore<WormLeaderSelectPlayersDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormLeaderSelectPlayersDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormLeaderSelectPlayersDisplay>.NativeClassPtr);
			WormLeaderSelectPlayersDisplay.NativeFieldInfoPtr_playerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectPlayersDisplay>.NativeClassPtr, "playerPrefab");
			WormLeaderSelectPlayersDisplay.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectPlayersDisplay>.NativeClassPtr, "container");
			WormLeaderSelectPlayersDisplay.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectPlayersDisplay>.NativeClassPtr, 100666457);
			WormLeaderSelectPlayersDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectPlayersDisplay>.NativeClassPtr, 100666458);
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x0005CF74 File Offset: 0x0005B174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716821, XrefRangeEnd = 716864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectPlayersDisplay.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x0005CFA8 File Offset: 0x0005B1A8
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormLeaderSelectPlayersDisplay()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormLeaderSelectPlayersDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectPlayersDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x0000DA3F File Offset: 0x0000BC3F
		public WormLeaderSelectPlayersDisplay(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x060016B3 RID: 5811 RVA: 0x0005CFE4 File Offset: 0x0005B1E4
		// (set) Token: 0x060016B4 RID: 5812 RVA: 0x0000DA48 File Offset: 0x0000BC48
		public unsafe EntityView playerPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectPlayersDisplay.NativeFieldInfoPtr_playerPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectPlayersDisplay.NativeFieldInfoPtr_playerPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x060016B5 RID: 5813 RVA: 0x0005D014 File Offset: 0x0005B214
		// (set) Token: 0x060016B6 RID: 5814 RVA: 0x0000DA67 File Offset: 0x0000BC67
		public unsafe Transform container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectPlayersDisplay.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectPlayersDisplay.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D2A RID: 3370
		private static readonly IntPtr NativeFieldInfoPtr_playerPrefab;

		// Token: 0x04000D2B RID: 3371
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x04000D2C RID: 3372
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000D2D RID: 3373
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001F3 RID: 499
	public class WormFremenBondFTTLoader : MonoBehaviour
	{
		// Token: 0x06001616 RID: 5654 RVA: 0x0005B324 File Offset: 0x00059524
		// Note: this type is marked as 'beforefieldinit'.
		static WormFremenBondFTTLoader()
		{
			Il2CppClassPointerStore<WormFremenBondFTTLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormFremenBondFTTLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormFremenBondFTTLoader>.NativeClassPtr);
			WormFremenBondFTTLoader.NativeFieldInfoPtr_cardView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFremenBondFTTLoader>.NativeClassPtr, "cardView");
			WormFremenBondFTTLoader.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFremenBondFTTLoader>.NativeClassPtr, 100666341);
			WormFremenBondFTTLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFremenBondFTTLoader>.NativeClassPtr, 100666342);
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x0005B390 File Offset: 0x00059590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716047, XrefRangeEnd = 716051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFremenBondFTTLoader.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x0005B3C4 File Offset: 0x000595C4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormFremenBondFTTLoader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormFremenBondFTTLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFremenBondFTTLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x0000D55D File Offset: 0x0000B75D
		public WormFremenBondFTTLoader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x0600161A RID: 5658 RVA: 0x0005B400 File Offset: 0x00059600
		// (set) Token: 0x0600161B RID: 5659 RVA: 0x0000D566 File Offset: 0x0000B766
		public unsafe EntityView cardView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFremenBondFTTLoader.NativeFieldInfoPtr_cardView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFremenBondFTTLoader.NativeFieldInfoPtr_cardView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CD1 RID: 3281
		private static readonly IntPtr NativeFieldInfoPtr_cardView;

		// Token: 0x04000CD2 RID: 3282
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000CD3 RID: 3283
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

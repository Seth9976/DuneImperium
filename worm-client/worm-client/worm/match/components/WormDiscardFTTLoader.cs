using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001E6 RID: 486
	public class WormDiscardFTTLoader : MonoBehaviour
	{
		// Token: 0x06001577 RID: 5495 RVA: 0x000594A0 File Offset: 0x000576A0
		// Note: this type is marked as 'beforefieldinit'.
		static WormDiscardFTTLoader()
		{
			Il2CppClassPointerStore<WormDiscardFTTLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormDiscardFTTLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormDiscardFTTLoader>.NativeClassPtr);
			WormDiscardFTTLoader.NativeFieldInfoPtr_cardView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDiscardFTTLoader>.NativeClassPtr, "cardView");
			WormDiscardFTTLoader.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardFTTLoader>.NativeClassPtr, 100666257);
			WormDiscardFTTLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardFTTLoader>.NativeClassPtr, 100666258);
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x0005950C File Offset: 0x0005770C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715303, XrefRangeEnd = 715307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDiscardFTTLoader.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x00059540 File Offset: 0x00057740
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormDiscardFTTLoader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormDiscardFTTLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDiscardFTTLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x0000D076 File Offset: 0x0000B276
		public WormDiscardFTTLoader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x0600157B RID: 5499 RVA: 0x0005957C File Offset: 0x0005777C
		// (set) Token: 0x0600157C RID: 5500 RVA: 0x0000D07F File Offset: 0x0000B27F
		public unsafe EntityView cardView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardFTTLoader.NativeFieldInfoPtr_cardView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardFTTLoader.NativeFieldInfoPtr_cardView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C73 RID: 3187
		private static readonly IntPtr NativeFieldInfoPtr_cardView;

		// Token: 0x04000C74 RID: 3188
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000C75 RID: 3189
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

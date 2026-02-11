using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace worm.match.components.stingers
{
	// Token: 0x0200022F RID: 559
	public class WormStingerRevealPreviewInitializer : MonoBehaviour
	{
		// Token: 0x0600185F RID: 6239 RVA: 0x00062158 File Offset: 0x00060358
		// Note: this type is marked as 'beforefieldinit'.
		static WormStingerRevealPreviewInitializer()
		{
			Il2CppClassPointerStore<WormStingerRevealPreviewInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components.stingers", "WormStingerRevealPreviewInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormStingerRevealPreviewInitializer>.NativeClassPtr);
			WormStingerRevealPreviewInitializer.NativeFieldInfoPtr_persuasionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormStingerRevealPreviewInitializer>.NativeClassPtr, "persuasionText");
			WormStingerRevealPreviewInitializer.NativeFieldInfoPtr_strengthText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormStingerRevealPreviewInitializer>.NativeClassPtr, "strengthText");
			WormStingerRevealPreviewInitializer.NativeMethodInfoPtr_InitViews_Public_Virtual_Final_New_Void_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerRevealPreviewInitializer>.NativeClassPtr, 100666670);
			WormStingerRevealPreviewInitializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerRevealPreviewInitializer>.NativeClassPtr, 100666671);
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x000621D8 File Offset: 0x000603D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718343, XrefRangeEnd = 718365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitViews(IHasAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStingerRevealPreviewInitializer.NativeMethodInfoPtr_InitViews_Public_Virtual_Final_New_Void_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x0006221C File Offset: 0x0006041C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormStingerRevealPreviewInitializer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormStingerRevealPreviewInitializer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStingerRevealPreviewInitializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x0000E738 File Offset: 0x0000C938
		public WormStingerRevealPreviewInitializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06001863 RID: 6243 RVA: 0x00062258 File Offset: 0x00060458
		// (set) Token: 0x06001864 RID: 6244 RVA: 0x0000E741 File Offset: 0x0000C941
		public unsafe TMP_Text persuasionText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerRevealPreviewInitializer.NativeFieldInfoPtr_persuasionText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerRevealPreviewInitializer.NativeFieldInfoPtr_persuasionText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06001865 RID: 6245 RVA: 0x00062288 File Offset: 0x00060488
		// (set) Token: 0x06001866 RID: 6246 RVA: 0x0000E760 File Offset: 0x0000C960
		public unsafe TMP_Text strengthText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerRevealPreviewInitializer.NativeFieldInfoPtr_strengthText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerRevealPreviewInitializer.NativeFieldInfoPtr_strengthText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E20 RID: 3616
		private static readonly IntPtr NativeFieldInfoPtr_persuasionText;

		// Token: 0x04000E21 RID: 3617
		private static readonly IntPtr NativeFieldInfoPtr_strengthText;

		// Token: 0x04000E22 RID: 3618
		private static readonly IntPtr NativeMethodInfoPtr_InitViews_Public_Virtual_Final_New_Void_IHasAttributes_0;

		// Token: 0x04000E23 RID: 3619
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

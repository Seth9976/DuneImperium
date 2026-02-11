using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine.UI;

namespace boardgames.menus.behaviours
{
	// Token: 0x020001BC RID: 444
	public class SelectedChallengeDifficultyRenderer : VersionedSubscriber<ChallengeDifficultyData>
	{
		// Token: 0x06001401 RID: 5121 RVA: 0x0005E3F4 File Offset: 0x0005C5F4
		// Note: this type is marked as 'beforefieldinit'.
		static SelectedChallengeDifficultyRenderer()
		{
			Il2CppClassPointerStore<SelectedChallengeDifficultyRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.behaviours", "SelectedChallengeDifficultyRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectedChallengeDifficultyRenderer>.NativeClassPtr);
			SelectedChallengeDifficultyRenderer.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedChallengeDifficultyRenderer>.NativeClassPtr, "text");
			SelectedChallengeDifficultyRenderer.NativeFieldInfoPtr_difficultyBackerImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedChallengeDifficultyRenderer>.NativeClassPtr, "difficultyBackerImage");
			SelectedChallengeDifficultyRenderer.NativeFieldInfoPtr_imageFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedChallengeDifficultyRenderer>.NativeClassPtr, "imageFormat");
			SelectedChallengeDifficultyRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedChallengeDifficultyRenderer>.NativeClassPtr, 100666236);
			SelectedChallengeDifficultyRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedChallengeDifficultyRenderer>.NativeClassPtr, 100666237);
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x0005E488 File Offset: 0x0005C688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519899, XrefRangeEnd = 519933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectedChallengeDifficultyRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x0005E4C4 File Offset: 0x0005C6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519933, XrefRangeEnd = 519939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectedChallengeDifficultyRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectedChallengeDifficultyRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedChallengeDifficultyRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x0000B65D File Offset: 0x0000985D
		public SelectedChallengeDifficultyRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001405 RID: 5125 RVA: 0x0005E500 File Offset: 0x0005C700
		// (set) Token: 0x06001406 RID: 5126 RVA: 0x0000B666 File Offset: 0x00009866
		public unsafe TMP_Text text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedChallengeDifficultyRenderer.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedChallengeDifficultyRenderer.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001407 RID: 5127 RVA: 0x0005E530 File Offset: 0x0005C730
		// (set) Token: 0x06001408 RID: 5128 RVA: 0x0000B685 File Offset: 0x00009885
		public unsafe Image difficultyBackerImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedChallengeDifficultyRenderer.NativeFieldInfoPtr_difficultyBackerImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedChallengeDifficultyRenderer.NativeFieldInfoPtr_difficultyBackerImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06001409 RID: 5129 RVA: 0x0005E560 File Offset: 0x0005C760
		// (set) Token: 0x0600140A RID: 5130 RVA: 0x0000B6A4 File Offset: 0x000098A4
		public unsafe string imageFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedChallengeDifficultyRenderer.NativeFieldInfoPtr_imageFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedChallengeDifficultyRenderer.NativeFieldInfoPtr_imageFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000C57 RID: 3159
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04000C58 RID: 3160
		private static readonly IntPtr NativeFieldInfoPtr_difficultyBackerImage;

		// Token: 0x04000C59 RID: 3161
		private static readonly IntPtr NativeFieldInfoPtr_imageFormat;

		// Token: 0x04000C5A RID: 3162
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000C5B RID: 3163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

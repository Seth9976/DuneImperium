using System;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace lotus
{
	// Token: 0x020000B2 RID: 178
	public class EmoteSelectPrompt : DismissablePrompt
	{
		// Token: 0x0600090A RID: 2314 RVA: 0x0002D96C File Offset: 0x0002BB6C
		// Note: this type is marked as 'beforefieldinit'.
		static EmoteSelectPrompt()
		{
			Il2CppClassPointerStore<EmoteSelectPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "EmoteSelectPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmoteSelectPrompt>.NativeClassPtr);
			EmoteSelectPrompt.NativeFieldInfoPtr_emoteType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmoteSelectPrompt>.NativeClassPtr, "emoteType");
			EmoteSelectPrompt.NativeFieldInfoPtr_emoteMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmoteSelectPrompt>.NativeClassPtr, "emoteMessage");
			EmoteSelectPrompt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmoteSelectPrompt>.NativeClassPtr, 100664713);
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x0002D9D8 File Offset: 0x0002BBD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992114, XrefRangeEnd = 992115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmoteSelectPrompt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmoteSelectPrompt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmoteSelectPrompt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x000062C6 File Offset: 0x000044C6
		public EmoteSelectPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x0600090D RID: 2317 RVA: 0x0002DA14 File Offset: 0x0002BC14
		// (set) Token: 0x0600090E RID: 2318 RVA: 0x000062CF File Offset: 0x000044CF
		public unsafe string emoteType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmoteSelectPrompt.NativeFieldInfoPtr_emoteType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmoteSelectPrompt.NativeFieldInfoPtr_emoteType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x0600090F RID: 2319 RVA: 0x0002DA3C File Offset: 0x0002BC3C
		// (set) Token: 0x06000910 RID: 2320 RVA: 0x000062EE File Offset: 0x000044EE
		public unsafe string emoteMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmoteSelectPrompt.NativeFieldInfoPtr_emoteMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmoteSelectPrompt.NativeFieldInfoPtr_emoteMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeFieldInfoPtr_emoteType;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeFieldInfoPtr_emoteMessage;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.menus.prompts
{
	// Token: 0x020001CD RID: 461
	public class ContinueOfflineGamePromptBehaviour : PromptBehaviour<ContinueGamePrompt>
	{
		// Token: 0x06001504 RID: 5380 RVA: 0x00061B74 File Offset: 0x0005FD74
		// Note: this type is marked as 'beforefieldinit'.
		static ContinueOfflineGamePromptBehaviour()
		{
			Il2CppClassPointerStore<ContinueOfflineGamePromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "ContinueOfflineGamePromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContinueOfflineGamePromptBehaviour>.NativeClassPtr);
			ContinueOfflineGamePromptBehaviour.NativeMethodInfoPtr_Event_NewGame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueOfflineGamePromptBehaviour>.NativeClassPtr, 100666401);
			ContinueOfflineGamePromptBehaviour.NativeMethodInfoPtr_Event_Continue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueOfflineGamePromptBehaviour>.NativeClassPtr, 100666402);
			ContinueOfflineGamePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueOfflineGamePromptBehaviour>.NativeClassPtr, 100666403);
		}

		// Token: 0x06001505 RID: 5381 RVA: 0x00061BE0 File Offset: 0x0005FDE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521976, XrefRangeEnd = 521979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_NewGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueOfflineGamePromptBehaviour.NativeMethodInfoPtr_Event_NewGame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001506 RID: 5382 RVA: 0x00061C14 File Offset: 0x0005FE14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521979, XrefRangeEnd = 521982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Continue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueOfflineGamePromptBehaviour.NativeMethodInfoPtr_Event_Continue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x00061C48 File Offset: 0x0005FE48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521982, XrefRangeEnd = 521985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContinueOfflineGamePromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContinueOfflineGamePromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueOfflineGamePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x0000BDDB File Offset: 0x00009FDB
		public ContinueOfflineGamePromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D08 RID: 3336
		private static readonly IntPtr NativeMethodInfoPtr_Event_NewGame_Public_Void_0;

		// Token: 0x04000D09 RID: 3337
		private static readonly IntPtr NativeMethodInfoPtr_Event_Continue_Public_Void_0;

		// Token: 0x04000D0A RID: 3338
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

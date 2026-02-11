using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000DE RID: 222
	public class WormOnlinePlayPromptBehaviour : MonoBehaviour
	{
		// Token: 0x06000980 RID: 2432 RVA: 0x00035344 File Offset: 0x00033544
		// Note: this type is marked as 'beforefieldinit'.
		static WormOnlinePlayPromptBehaviour()
		{
			Il2CppClassPointerStore<WormOnlinePlayPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormOnlinePlayPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormOnlinePlayPromptBehaviour>.NativeClassPtr);
			WormOnlinePlayPromptBehaviour.NativeMethodInfoPtr_Event_Lobby_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOnlinePlayPromptBehaviour>.NativeClassPtr, 100664613);
			WormOnlinePlayPromptBehaviour.NativeMethodInfoPtr_Event_Events_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOnlinePlayPromptBehaviour>.NativeClassPtr, 100664614);
			WormOnlinePlayPromptBehaviour.NativeMethodInfoPtr_Event_Back_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOnlinePlayPromptBehaviour>.NativeClassPtr, 100664615);
			WormOnlinePlayPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOnlinePlayPromptBehaviour>.NativeClassPtr, 100664616);
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x000353C4 File Offset: 0x000335C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700137, XrefRangeEnd = 700147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Lobby()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOnlinePlayPromptBehaviour.NativeMethodInfoPtr_Event_Lobby_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x000353F8 File Offset: 0x000335F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700147, XrefRangeEnd = 700157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Events()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOnlinePlayPromptBehaviour.NativeMethodInfoPtr_Event_Events_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x0003542C File Offset: 0x0003362C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700157, XrefRangeEnd = 700162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Back()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOnlinePlayPromptBehaviour.NativeMethodInfoPtr_Event_Back_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00035460 File Offset: 0x00033660
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormOnlinePlayPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormOnlinePlayPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOnlinePlayPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x00006E41 File Offset: 0x00005041
		public WormOnlinePlayPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeMethodInfoPtr_Event_Lobby_Public_Void_0;

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeMethodInfoPtr_Event_Events_Public_Void_0;

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeMethodInfoPtr_Event_Back_Public_Void_0;

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

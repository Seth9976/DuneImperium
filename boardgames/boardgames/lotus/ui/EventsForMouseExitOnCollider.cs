using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace lotus.ui
{
	// Token: 0x020000DD RID: 221
	public class EventsForMouseExitOnCollider : EventsForMouseOnCollider
	{
		// Token: 0x06000B09 RID: 2825 RVA: 0x00034310 File Offset: 0x00032510
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForMouseExitOnCollider()
		{
			Il2CppClassPointerStore<EventsForMouseExitOnCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus.ui", "EventsForMouseExitOnCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForMouseExitOnCollider>.NativeClassPtr);
			EventsForMouseExitOnCollider.NativeMethodInfoPtr_OnMouseExit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForMouseExitOnCollider>.NativeClassPtr, 100665061);
			EventsForMouseExitOnCollider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForMouseExitOnCollider>.NativeClassPtr, 100665062);
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x00034368 File Offset: 0x00032568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMouseExit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForMouseExitOnCollider.NativeMethodInfoPtr_OnMouseExit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x0003439C File Offset: 0x0003259C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForMouseExitOnCollider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForMouseExitOnCollider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForMouseExitOnCollider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x000070EB File Offset: 0x000052EB
		public EventsForMouseExitOnCollider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeMethodInfoPtr_OnMouseExit_Private_Void_0;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

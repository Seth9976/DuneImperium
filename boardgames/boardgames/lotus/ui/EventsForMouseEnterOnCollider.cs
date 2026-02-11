using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace lotus.ui
{
	// Token: 0x020000DC RID: 220
	public class EventsForMouseEnterOnCollider : EventsForMouseOnCollider
	{
		// Token: 0x06000B05 RID: 2821 RVA: 0x00034248 File Offset: 0x00032448
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForMouseEnterOnCollider()
		{
			Il2CppClassPointerStore<EventsForMouseEnterOnCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus.ui", "EventsForMouseEnterOnCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForMouseEnterOnCollider>.NativeClassPtr);
			EventsForMouseEnterOnCollider.NativeMethodInfoPtr_OnMouseEnter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForMouseEnterOnCollider>.NativeClassPtr, 100665059);
			EventsForMouseEnterOnCollider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForMouseEnterOnCollider>.NativeClassPtr, 100665060);
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x000342A0 File Offset: 0x000324A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMouseEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForMouseEnterOnCollider.NativeMethodInfoPtr_OnMouseEnter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x000342D4 File Offset: 0x000324D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForMouseEnterOnCollider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForMouseEnterOnCollider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForMouseEnterOnCollider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x000070E2 File Offset: 0x000052E2
		public EventsForMouseEnterOnCollider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeMethodInfoPtr_OnMouseEnter_Private_Void_0;

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

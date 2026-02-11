using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace lotus.ui
{
	// Token: 0x020000DB RID: 219
	public class EventsForMouseDragOnCollider : EventsForMouseOnCollider
	{
		// Token: 0x06000B01 RID: 2817 RVA: 0x00034180 File Offset: 0x00032380
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForMouseDragOnCollider()
		{
			Il2CppClassPointerStore<EventsForMouseDragOnCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus.ui", "EventsForMouseDragOnCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForMouseDragOnCollider>.NativeClassPtr);
			EventsForMouseDragOnCollider.NativeMethodInfoPtr_OnMouseDrag_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForMouseDragOnCollider>.NativeClassPtr, 100665057);
			EventsForMouseDragOnCollider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForMouseDragOnCollider>.NativeClassPtr, 100665058);
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x000341D8 File Offset: 0x000323D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMouseDrag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForMouseDragOnCollider.NativeMethodInfoPtr_OnMouseDrag_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x0003420C File Offset: 0x0003240C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForMouseDragOnCollider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForMouseDragOnCollider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForMouseDragOnCollider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x000070D9 File Offset: 0x000052D9
		public EventsForMouseDragOnCollider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeMethodInfoPtr_OnMouseDrag_Private_Void_0;

		// Token: 0x040006C8 RID: 1736
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

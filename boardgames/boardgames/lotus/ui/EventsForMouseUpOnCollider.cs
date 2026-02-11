using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace lotus.ui
{
	// Token: 0x020000DF RID: 223
	public class EventsForMouseUpOnCollider : EventsForMouseOnCollider
	{
		// Token: 0x06000B12 RID: 2834 RVA: 0x0003449C File Offset: 0x0003269C
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForMouseUpOnCollider()
		{
			Il2CppClassPointerStore<EventsForMouseUpOnCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus.ui", "EventsForMouseUpOnCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForMouseUpOnCollider>.NativeClassPtr);
			EventsForMouseUpOnCollider.NativeMethodInfoPtr_OnMouseUp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForMouseUpOnCollider>.NativeClassPtr, 100665064);
			EventsForMouseUpOnCollider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForMouseUpOnCollider>.NativeClassPtr, 100665065);
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x000344F4 File Offset: 0x000326F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMouseUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForMouseUpOnCollider.NativeMethodInfoPtr_OnMouseUp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x00034528 File Offset: 0x00032728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForMouseUpOnCollider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForMouseUpOnCollider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForMouseUpOnCollider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x0000711C File Offset: 0x0000531C
		public EventsForMouseUpOnCollider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeMethodInfoPtr_OnMouseUp_Private_Void_0;

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace lotus.ui
{
	// Token: 0x020000DA RID: 218
	public class EventsForMouseDownOnCollider : EventsForMouseOnCollider
	{
		// Token: 0x06000AFD RID: 2813 RVA: 0x000340B8 File Offset: 0x000322B8
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForMouseDownOnCollider()
		{
			Il2CppClassPointerStore<EventsForMouseDownOnCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus.ui", "EventsForMouseDownOnCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForMouseDownOnCollider>.NativeClassPtr);
			EventsForMouseDownOnCollider.NativeMethodInfoPtr_OnMouseDown_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForMouseDownOnCollider>.NativeClassPtr, 100665055);
			EventsForMouseDownOnCollider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForMouseDownOnCollider>.NativeClassPtr, 100665056);
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x00034110 File Offset: 0x00032310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994414, XrefRangeEnd = 994416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMouseDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForMouseDownOnCollider.NativeMethodInfoPtr_OnMouseDown_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x00034144 File Offset: 0x00032344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994416, XrefRangeEnd = 994422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForMouseDownOnCollider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForMouseDownOnCollider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForMouseDownOnCollider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x000070D0 File Offset: 0x000052D0
		public EventsForMouseDownOnCollider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeMethodInfoPtr_OnMouseDown_Private_Void_0;

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

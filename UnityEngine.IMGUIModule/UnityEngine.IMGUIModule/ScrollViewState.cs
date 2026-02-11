using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200001A RID: 26
	public class ScrollViewState : Object
	{
		// Token: 0x06000528 RID: 1320 RVA: 0x0000449E File Offset: 0x0000269E
		// Note: this type is marked as 'beforefieldinit'.
		static ScrollViewState()
		{
			Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "ScrollViewState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr);
			ScrollViewState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr, 100663656);
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00012C08 File Offset: 0x00010E08
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScrollViewState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollViewState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x000044D7 File Offset: 0x000026D7
		public ScrollViewState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x000044E0 File Offset: 0x000026E0
		public void ScrollTo(Rect pos)
		{
			this.ScrollTowards(pos, float.PositiveInfinity);
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x000044F0 File Offset: 0x000026F0
		public bool ScrollTowards(Rect pos, float maxDelta)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x000044FD File Offset: 0x000026FD
		public Vector2 ScrollNeeded(Rect pos)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

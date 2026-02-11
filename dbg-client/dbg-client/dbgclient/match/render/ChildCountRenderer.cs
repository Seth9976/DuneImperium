using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using TMPro;

namespace dbgclient.match.render
{
	// Token: 0x020000A4 RID: 164
	public class ChildCountRenderer : Observer
	{
		// Token: 0x06000675 RID: 1653 RVA: 0x00032148 File Offset: 0x00030348
		// Note: this type is marked as 'beforefieldinit'.
		static ChildCountRenderer()
		{
			Il2CppClassPointerStore<ChildCountRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.match.render", "ChildCountRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChildCountRenderer>.NativeClassPtr);
			ChildCountRenderer.NativeFieldInfoPtr_countText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChildCountRenderer>.NativeClassPtr, "countText");
			ChildCountRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildCountRenderer>.NativeClassPtr, 100664315);
			ChildCountRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildCountRenderer>.NativeClassPtr, 100664316);
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x000321B4 File Offset: 0x000303B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503334, XrefRangeEnd = 503356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChildCountRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x000321F0 File Offset: 0x000303F0
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChildCountRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChildCountRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChildCountRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00004EA7 File Offset: 0x000030A7
		public ChildCountRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x0003222C File Offset: 0x0003042C
		// (set) Token: 0x0600067A RID: 1658 RVA: 0x00004EB0 File Offset: 0x000030B0
		public unsafe TMP_Text countText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildCountRenderer.NativeFieldInfoPtr_countText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildCountRenderer.NativeFieldInfoPtr_countText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeFieldInfoPtr_countText;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

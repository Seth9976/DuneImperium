using System;
using dwd.core.direBytes.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace lib.direbytes
{
	// Token: 0x02000006 RID: 6
	public class DireBytesURLRenderer : Subscriber<UrlData>
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00003A64 File Offset: 0x00001C64
		// Note: this type is marked as 'beforefieldinit'.
		static DireBytesURLRenderer()
		{
			Il2CppClassPointerStore<DireBytesURLRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("direbytes.dll", "lib.direbytes", "DireBytesURLRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireBytesURLRenderer>.NativeClassPtr);
			DireBytesURLRenderer.NativeMethodInfoPtr_Event_OnClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesURLRenderer>.NativeClassPtr, 100663303);
			DireBytesURLRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesURLRenderer>.NativeClassPtr, 100663304);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003ABC File Offset: 0x00001CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233310, XrefRangeEnd = 1233346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_OnClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesURLRenderer.NativeMethodInfoPtr_Event_OnClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00003AF0 File Offset: 0x00001CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233346, XrefRangeEnd = 1233349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DireBytesURLRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireBytesURLRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesURLRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000020E7 File Offset: 0x000002E7
		public DireBytesURLRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_Event_OnClick_Public_Void_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

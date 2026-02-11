using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace zen.src.menus
{
	// Token: 0x02000056 RID: 86
	public class DefaultDialogRenderer : DialogRenderer
	{
		// Token: 0x06000468 RID: 1128 RVA: 0x0000405B File Offset: 0x0000225B
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultDialogRenderer()
		{
			Il2CppClassPointerStore<DefaultDialogRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.menus", "DefaultDialogRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultDialogRenderer>.NativeClassPtr);
			DefaultDialogRenderer.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultDialogRenderer>.NativeClassPtr, 100663857);
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0001DC80 File Offset: 0x0001BE80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 985903, RefRangeEnd = 985904, XrefRangeStart = 985903, XrefRangeEnd = 985904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultDialogRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultDialogRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultDialogRenderer.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00004094 File Offset: 0x00002294
		public DefaultDialogRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

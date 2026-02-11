using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace zen.src.menus
{
	// Token: 0x0200005A RID: 90
	public class ErrorDialog : ConfirmDialog
	{
		// Token: 0x060004B1 RID: 1201 RVA: 0x00004245 File Offset: 0x00002445
		// Note: this type is marked as 'beforefieldinit'.
		static ErrorDialog()
		{
			Il2CppClassPointerStore<ErrorDialog>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.menus", "ErrorDialog");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ErrorDialog>.NativeClassPtr);
			ErrorDialog.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorDialog>.NativeClassPtr, 100663942);
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0001ED24 File Offset: 0x0001CF24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 985903, RefRangeEnd = 985904, XrefRangeStart = 985903, XrefRangeEnd = 985904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ErrorDialog()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ErrorDialog>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorDialog.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x0000427E File Offset: 0x0000247E
		public ErrorDialog(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.selectionfilters
{
	// Token: 0x02000057 RID: 87
	public class SelectionMessageFilter : Object
	{
		// Token: 0x06000524 RID: 1316 RVA: 0x000043E4 File Offset: 0x000025E4
		// Note: this type is marked as 'beforefieldinit'.
		static SelectionMessageFilter()
		{
			Il2CppClassPointerStore<SelectionMessageFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.selectionfilters", "SelectionMessageFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionMessageFilter>.NativeClassPtr);
			SelectionMessageFilter.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionMessageFilter>.NativeClassPtr, 100664351);
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x0002D5E4 File Offset: 0x0002B7E4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionMessageFilter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionMessageFilter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionMessageFilter.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x0000441D File Offset: 0x0000261D
		public SelectionMessageFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

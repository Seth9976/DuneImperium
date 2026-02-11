using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dbgclient.voodoo.layout
{
	// Token: 0x0200008D RID: 141
	public class TransformLayoutHorizontal : TransformLayout
	{
		// Token: 0x06000589 RID: 1417 RVA: 0x0002F1A4 File Offset: 0x0002D3A4
		// Note: this type is marked as 'beforefieldinit'.
		static TransformLayoutHorizontal()
		{
			Il2CppClassPointerStore<TransformLayoutHorizontal>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.voodoo.layout", "TransformLayoutHorizontal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformLayoutHorizontal>.NativeClassPtr);
			TransformLayoutHorizontal.NativeMethodInfoPtr_RebuildLayout_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformLayoutHorizontal>.NativeClassPtr, 100664137);
			TransformLayoutHorizontal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformLayoutHorizontal>.NativeClassPtr, 100664138);
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0002F1FC File Offset: 0x0002D3FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501901, XrefRangeEnd = 501943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RebuildLayout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransformLayoutHorizontal.NativeMethodInfoPtr_RebuildLayout_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x0002F238 File Offset: 0x0002D438
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransformLayoutHorizontal()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransformLayoutHorizontal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformLayoutHorizontal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x000047DE File Offset: 0x000029DE
		public TransformLayoutHorizontal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeMethodInfoPtr_RebuildLayout_Protected_Virtual_Void_0;

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

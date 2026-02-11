using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	public class RejectDragAndDropMaterial : Attribute
	{
		// Token: 0x06000011 RID: 17 RVA: 0x0000213A File Offset: 0x0000033A
		// Note: this type is marked as 'beforefieldinit'.
		static RejectDragAndDropMaterial()
		{
			Il2CppClassPointerStore<RejectDragAndDropMaterial>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine", "RejectDragAndDropMaterial");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RejectDragAndDropMaterial>.NativeClassPtr);
			RejectDragAndDropMaterial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RejectDragAndDropMaterial>.NativeClassPtr, 100663300);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000029F4 File Offset: 0x00000BF4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RejectDragAndDropMaterial()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RejectDragAndDropMaterial>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RejectDragAndDropMaterial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002173 File Offset: 0x00000373
		public RejectDragAndDropMaterial(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

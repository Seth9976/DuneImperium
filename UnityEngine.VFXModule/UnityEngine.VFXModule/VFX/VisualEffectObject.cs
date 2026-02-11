using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.VFX
{
	// Token: 0x0200000A RID: 10
	public class VisualEffectObject : Object
	{
		// Token: 0x060000DB RID: 219 RVA: 0x000028CE File Offset: 0x00000ACE
		// Note: this type is marked as 'beforefieldinit'.
		static VisualEffectObject()
		{
			Il2CppClassPointerStore<VisualEffectObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VFXModule.dll", "UnityEngine.VFX", "VisualEffectObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualEffectObject>.NativeClassPtr);
			VisualEffectObject.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectObject>.NativeClassPtr, 100663325);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00004BF0 File Offset: 0x00002DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269811, XrefRangeEnd = 1269815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualEffectObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualEffectObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualEffectObject.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002907 File Offset: 0x00000B07
		public VisualEffectObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

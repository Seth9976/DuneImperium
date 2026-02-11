using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Bindings
{
	// Token: 0x0200001C RID: 28
	public class PreventReadOnlyInstanceModificationAttribute : Attribute
	{
		// Token: 0x060000B8 RID: 184 RVA: 0x000026A8 File Offset: 0x000008A8
		// Note: this type is marked as 'beforefieldinit'.
		static PreventReadOnlyInstanceModificationAttribute()
		{
			Il2CppClassPointerStore<PreventReadOnlyInstanceModificationAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "PreventReadOnlyInstanceModificationAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreventReadOnlyInstanceModificationAttribute>.NativeClassPtr);
			PreventReadOnlyInstanceModificationAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreventReadOnlyInstanceModificationAttribute>.NativeClassPtr, 100663357);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000045DC File Offset: 0x000027DC
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PreventReadOnlyInstanceModificationAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreventReadOnlyInstanceModificationAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreventReadOnlyInstanceModificationAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000026E1 File Offset: 0x000008E1
		public PreventReadOnlyInstanceModificationAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

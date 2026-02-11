using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020000DF RID: 223
	public sealed class ReloadGroupAttribute : Attribute
	{
		// Token: 0x0600104B RID: 4171 RVA: 0x000089B1 File Offset: 0x00006BB1
		// Note: this type is marked as 'beforefieldinit'.
		static ReloadGroupAttribute()
		{
			Il2CppClassPointerStore<ReloadGroupAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ReloadGroupAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReloadGroupAttribute>.NativeClassPtr);
			ReloadGroupAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReloadGroupAttribute>.NativeClassPtr, 100665715);
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x0004B4EC File Offset: 0x000496EC
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReloadGroupAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReloadGroupAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReloadGroupAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x000089EA File Offset: 0x00006BEA
		public ReloadGroupAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C6F RID: 3183
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

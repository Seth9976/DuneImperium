using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200003C RID: 60
	public class AdditionalPropertyAttribute : Attribute
	{
		// Token: 0x060004DB RID: 1243 RVA: 0x00004037 File Offset: 0x00002237
		// Note: this type is marked as 'beforefieldinit'.
		static AdditionalPropertyAttribute()
		{
			Il2CppClassPointerStore<AdditionalPropertyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "AdditionalPropertyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdditionalPropertyAttribute>.NativeClassPtr);
			AdditionalPropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalPropertyAttribute>.NativeClassPtr, 100663891);
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x0001F3B0 File Offset: 0x0001D5B0
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdditionalPropertyAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdditionalPropertyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditionalPropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00004070 File Offset: 0x00002270
		public AdditionalPropertyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

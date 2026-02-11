using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Internal
{
	// Token: 0x020001DB RID: 475
	[Serializable]
	public class ExcludeFromDocsAttribute : Attribute
	{
		// Token: 0x06002178 RID: 8568 RVA: 0x0000CCD5 File Offset: 0x0000AED5
		// Note: this type is marked as 'beforefieldinit'.
		static ExcludeFromDocsAttribute()
		{
			Il2CppClassPointerStore<ExcludeFromDocsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Internal", "ExcludeFromDocsAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExcludeFromDocsAttribute>.NativeClassPtr);
			ExcludeFromDocsAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExcludeFromDocsAttribute>.NativeClassPtr, 100667820);
		}

		// Token: 0x06002179 RID: 8569 RVA: 0x00093550 File Offset: 0x00091750
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExcludeFromDocsAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExcludeFromDocsAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExcludeFromDocsAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600217A RID: 8570 RVA: 0x0000CD0E File Offset: 0x0000AF0E
		public ExcludeFromDocsAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001C7F RID: 7295
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

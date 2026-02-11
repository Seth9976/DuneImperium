using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x0200038D RID: 909
	public sealed class PreserveSigAttribute : Attribute
	{
		// Token: 0x060037BB RID: 14267 RVA: 0x0001462B File Offset: 0x0001282B
		// Note: this type is marked as 'beforefieldinit'.
		static PreserveSigAttribute()
		{
			Il2CppClassPointerStore<PreserveSigAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "PreserveSigAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreserveSigAttribute>.NativeClassPtr);
			PreserveSigAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreserveSigAttribute>.NativeClassPtr, 100671636);
		}

		// Token: 0x060037BC RID: 14268 RVA: 0x00110470 File Offset: 0x0010E670
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PreserveSigAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreserveSigAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreserveSigAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037BD RID: 14269 RVA: 0x00014664 File Offset: 0x00012864
		public PreserveSigAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002D91 RID: 11665
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

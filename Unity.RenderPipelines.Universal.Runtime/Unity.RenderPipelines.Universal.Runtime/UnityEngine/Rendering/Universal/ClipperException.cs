using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000024 RID: 36
	public class ClipperException : Exception
	{
		// Token: 0x06000254 RID: 596 RVA: 0x00002FBC File Offset: 0x000011BC
		// Note: this type is marked as 'beforefieldinit'.
		static ClipperException()
		{
			Il2CppClassPointerStore<ClipperException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ClipperException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipperException>.NativeClassPtr);
			ClipperException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperException>.NativeClassPtr, 100663599);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0001E1C0 File Offset: 0x0001C3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 599535, XrefRangeEnd = 599539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClipperException(string description)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipperException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(description);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002FF5 File Offset: 0x000011F5
		public ClipperException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x0200010B RID: 267
	[Serializable]
	public class NoInterpVector4Parameter : VolumeParameter<Vector4>
	{
		// Token: 0x060011E8 RID: 4584 RVA: 0x00009456 File Offset: 0x00007656
		// Note: this type is marked as 'beforefieldinit'.
		static NoInterpVector4Parameter()
		{
			Il2CppClassPointerStore<NoInterpVector4Parameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "NoInterpVector4Parameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoInterpVector4Parameter>.NativeClassPtr);
			NoInterpVector4Parameter.NativeMethodInfoPtr__ctor_Public_Void_Vector4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpVector4Parameter>.NativeClassPtr, 100665916);
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x00051674 File Offset: 0x0004F874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979035, XrefRangeEnd = 979038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoInterpVector4Parameter(Vector4 value, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoInterpVector4Parameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoInterpVector4Parameter.NativeMethodInfoPtr__ctor_Public_Void_Vector4_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x0000948F File Offset: 0x0000768F
		public NoInterpVector4Parameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D70 RID: 3440
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector4_Boolean_0;
	}
}

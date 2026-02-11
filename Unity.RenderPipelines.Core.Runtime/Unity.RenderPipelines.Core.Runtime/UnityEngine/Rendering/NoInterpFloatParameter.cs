using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x020000FB RID: 251
	[Serializable]
	public class NoInterpFloatParameter : VolumeParameter<float>
	{
		// Token: 0x0600117D RID: 4477 RVA: 0x00009135 File Offset: 0x00007335
		// Note: this type is marked as 'beforefieldinit'.
		static NoInterpFloatParameter()
		{
			Il2CppClassPointerStore<NoInterpFloatParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "NoInterpFloatParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoInterpFloatParameter>.NativeClassPtr);
			NoInterpFloatParameter.NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpFloatParameter>.NativeClassPtr, 100665877);
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x0004FF34 File Offset: 0x0004E134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978921, XrefRangeEnd = 978924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoInterpFloatParameter(float value, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoInterpFloatParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoInterpFloatParameter.NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x0000916E File Offset: 0x0000736E
		public NoInterpFloatParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D37 RID: 3383
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_0;
	}
}

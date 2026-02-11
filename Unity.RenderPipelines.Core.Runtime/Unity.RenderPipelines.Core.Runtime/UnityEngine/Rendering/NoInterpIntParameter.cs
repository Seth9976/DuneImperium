using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x020000F3 RID: 243
	[Serializable]
	public class NoInterpIntParameter : VolumeParameter<int>
	{
		// Token: 0x06001148 RID: 4424 RVA: 0x00008FDC File Offset: 0x000071DC
		// Note: this type is marked as 'beforefieldinit'.
		static NoInterpIntParameter()
		{
			Il2CppClassPointerStore<NoInterpIntParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "NoInterpIntParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoInterpIntParameter>.NativeClassPtr);
			NoInterpIntParameter.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpIntParameter>.NativeClassPtr, 100665856);
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x0004F378 File Offset: 0x0004D578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978896, XrefRangeEnd = 978899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoInterpIntParameter(int value, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoInterpIntParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoInterpIntParameter.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x00009015 File Offset: 0x00007215
		public NoInterpIntParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D1A RID: 3354
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0;
	}
}

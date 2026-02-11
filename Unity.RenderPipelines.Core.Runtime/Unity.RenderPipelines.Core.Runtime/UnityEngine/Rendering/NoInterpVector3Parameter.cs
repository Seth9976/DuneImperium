using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x02000109 RID: 265
	[Serializable]
	public class NoInterpVector3Parameter : VolumeParameter<Vector3>
	{
		// Token: 0x060011E1 RID: 4577 RVA: 0x0000940B File Offset: 0x0000760B
		// Note: this type is marked as 'beforefieldinit'.
		static NoInterpVector3Parameter()
		{
			Il2CppClassPointerStore<NoInterpVector3Parameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "NoInterpVector3Parameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoInterpVector3Parameter>.NativeClassPtr);
			NoInterpVector3Parameter.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpVector3Parameter>.NativeClassPtr, 100665913);
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x00051504 File Offset: 0x0004F704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979023, XrefRangeEnd = 979026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoInterpVector3Parameter(Vector3 value, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoInterpVector3Parameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoInterpVector3Parameter.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x00009444 File Offset: 0x00007644
		public NoInterpVector3Parameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D6D RID: 3437
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Boolean_0;
	}
}

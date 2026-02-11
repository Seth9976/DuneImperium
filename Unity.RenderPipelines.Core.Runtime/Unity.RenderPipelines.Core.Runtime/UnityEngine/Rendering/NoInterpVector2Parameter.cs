using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x02000107 RID: 263
	[Serializable]
	public class NoInterpVector2Parameter : VolumeParameter<Vector2>
	{
		// Token: 0x060011DA RID: 4570 RVA: 0x000093C0 File Offset: 0x000075C0
		// Note: this type is marked as 'beforefieldinit'.
		static NoInterpVector2Parameter()
		{
			Il2CppClassPointerStore<NoInterpVector2Parameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "NoInterpVector2Parameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoInterpVector2Parameter>.NativeClassPtr);
			NoInterpVector2Parameter.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpVector2Parameter>.NativeClassPtr, 100665910);
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x00051394 File Offset: 0x0004F594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979017, XrefRangeEnd = 979020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoInterpVector2Parameter(Vector2 value, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoInterpVector2Parameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoInterpVector2Parameter.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x000093F9 File Offset: 0x000075F9
		public NoInterpVector2Parameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D6A RID: 3434
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_Boolean_0;
	}
}

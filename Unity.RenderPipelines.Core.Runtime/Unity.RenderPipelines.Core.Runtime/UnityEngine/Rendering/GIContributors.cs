using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000095 RID: 149
	[StructLayout(2)]
	public struct GIContributors
	{
		// Token: 0x06000B26 RID: 2854 RVA: 0x00006C29 File Offset: 0x00004E29
		// Note: this type is marked as 'beforefieldinit'.
		static GIContributors()
		{
			Il2CppClassPointerStore<GIContributors>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "GIContributors");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GIContributors>.NativeClassPtr);
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x00006C4E File Offset: 0x00004E4E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GIContributors>.NativeClassPtr, ref this));
		}
	}
}

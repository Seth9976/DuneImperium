using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020000B3 RID: 179
	[StructLayout(2)]
	public struct ShaderGenUInt4
	{
		// Token: 0x06000CB7 RID: 3255 RVA: 0x00007A3B File Offset: 0x00005C3B
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderGenUInt4()
		{
			Il2CppClassPointerStore<ShaderGenUInt4>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ShaderGenUInt4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderGenUInt4>.NativeClassPtr);
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x00007A60 File Offset: 0x00005C60
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShaderGenUInt4>.NativeClassPtr, ref this));
		}
	}
}

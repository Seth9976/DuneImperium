using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	// Token: 0x0200002E RID: 46
	[StructLayout(2)]
	public struct FastMemoryDesc
	{
		// Token: 0x060003E7 RID: 999 RVA: 0x0001C3E0 File Offset: 0x0001A5E0
		// Note: this type is marked as 'beforefieldinit'.
		static FastMemoryDesc()
		{
			Il2CppClassPointerStore<FastMemoryDesc>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering.RenderGraphModule", "FastMemoryDesc");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FastMemoryDesc>.NativeClassPtr);
			FastMemoryDesc.NativeFieldInfoPtr_inFastMemory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastMemoryDesc>.NativeClassPtr, "inFastMemory");
			FastMemoryDesc.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastMemoryDesc>.NativeClassPtr, "flags");
			FastMemoryDesc.NativeFieldInfoPtr_residencyFraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastMemoryDesc>.NativeClassPtr, "residencyFraction");
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00003892 File Offset: 0x00001A92
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FastMemoryDesc>.NativeClassPtr, ref this));
		}

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeFieldInfoPtr_inFastMemory;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeFieldInfoPtr_residencyFraction;

		// Token: 0x040002CC RID: 716
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool inFastMemory;

		// Token: 0x040002CD RID: 717
		[FieldOffset(4)]
		public FastMemoryFlags flags;

		// Token: 0x040002CE RID: 718
		[FieldOffset(8)]
		public float residencyFraction;
	}
}

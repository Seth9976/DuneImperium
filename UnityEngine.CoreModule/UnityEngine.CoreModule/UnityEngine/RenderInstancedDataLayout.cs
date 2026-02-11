using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200009D RID: 157
	[StructLayout(2)]
	public struct RenderInstancedDataLayout
	{
		// Token: 0x060009CF RID: 2511 RVA: 0x00035A08 File Offset: 0x00033C08
		// Note: this type is marked as 'beforefieldinit'.
		static RenderInstancedDataLayout()
		{
			Il2CppClassPointerStore<RenderInstancedDataLayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RenderInstancedDataLayout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderInstancedDataLayout>.NativeClassPtr);
			RenderInstancedDataLayout.NativeFieldInfoPtr__size_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderInstancedDataLayout>.NativeClassPtr, "<size>k__BackingField");
			RenderInstancedDataLayout.NativeFieldInfoPtr__offsetObjectToWorld_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderInstancedDataLayout>.NativeClassPtr, "<offsetObjectToWorld>k__BackingField");
			RenderInstancedDataLayout.NativeFieldInfoPtr__offsetPrevObjectToWorld_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderInstancedDataLayout>.NativeClassPtr, "<offsetPrevObjectToWorld>k__BackingField");
			RenderInstancedDataLayout.NativeFieldInfoPtr__offsetRenderingLayerMask_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderInstancedDataLayout>.NativeClassPtr, "<offsetRenderingLayerMask>k__BackingField");
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00005B67 File Offset: 0x00003D67
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderInstancedDataLayout>.NativeClassPtr, ref this));
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x00005B79 File Offset: 0x00003D79
		public int size
		{
			get
			{
				return this._size_k__BackingField;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x00005B81 File Offset: 0x00003D81
		public int offsetObjectToWorld
		{
			get
			{
				return this._offsetObjectToWorld_k__BackingField;
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060009D3 RID: 2515 RVA: 0x00005B89 File Offset: 0x00003D89
		public int offsetPrevObjectToWorld
		{
			get
			{
				return this._offsetPrevObjectToWorld_k__BackingField;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060009D4 RID: 2516 RVA: 0x00005B91 File Offset: 0x00003D91
		public int offsetRenderingLayerMask
		{
			get
			{
				return this._offsetRenderingLayerMask_k__BackingField;
			}
		}

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeFieldInfoPtr__size_k__BackingField;

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeFieldInfoPtr__offsetObjectToWorld_k__BackingField;

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeFieldInfoPtr__offsetPrevObjectToWorld_k__BackingField;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeFieldInfoPtr__offsetRenderingLayerMask_k__BackingField;

		// Token: 0x0400079A RID: 1946
		[FieldOffset(0)]
		public readonly int _size_k__BackingField;

		// Token: 0x0400079B RID: 1947
		[FieldOffset(4)]
		public readonly int _offsetObjectToWorld_k__BackingField;

		// Token: 0x0400079C RID: 1948
		[FieldOffset(8)]
		public readonly int _offsetPrevObjectToWorld_k__BackingField;

		// Token: 0x0400079D RID: 1949
		[FieldOffset(12)]
		public readonly int _offsetRenderingLayerMask_k__BackingField;
	}
}

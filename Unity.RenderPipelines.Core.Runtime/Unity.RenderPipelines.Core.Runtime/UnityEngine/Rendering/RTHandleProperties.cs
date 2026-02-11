using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020000BD RID: 189
	[StructLayout(2)]
	public struct RTHandleProperties
	{
		// Token: 0x06000D63 RID: 3427 RVA: 0x0003DE04 File Offset: 0x0003C004
		// Note: this type is marked as 'beforefieldinit'.
		static RTHandleProperties()
		{
			Il2CppClassPointerStore<RTHandleProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "RTHandleProperties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTHandleProperties>.NativeClassPtr);
			RTHandleProperties.NativeFieldInfoPtr_previousViewportSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandleProperties>.NativeClassPtr, "previousViewportSize");
			RTHandleProperties.NativeFieldInfoPtr_previousRenderTargetSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandleProperties>.NativeClassPtr, "previousRenderTargetSize");
			RTHandleProperties.NativeFieldInfoPtr_currentViewportSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandleProperties>.NativeClassPtr, "currentViewportSize");
			RTHandleProperties.NativeFieldInfoPtr_currentRenderTargetSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandleProperties>.NativeClassPtr, "currentRenderTargetSize");
			RTHandleProperties.NativeFieldInfoPtr_rtHandleScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandleProperties>.NativeClassPtr, "rtHandleScale");
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x00007DB4 File Offset: 0x00005FB4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RTHandleProperties>.NativeClassPtr, ref this));
		}

		// Token: 0x04000A05 RID: 2565
		private static readonly IntPtr NativeFieldInfoPtr_previousViewportSize;

		// Token: 0x04000A06 RID: 2566
		private static readonly IntPtr NativeFieldInfoPtr_previousRenderTargetSize;

		// Token: 0x04000A07 RID: 2567
		private static readonly IntPtr NativeFieldInfoPtr_currentViewportSize;

		// Token: 0x04000A08 RID: 2568
		private static readonly IntPtr NativeFieldInfoPtr_currentRenderTargetSize;

		// Token: 0x04000A09 RID: 2569
		private static readonly IntPtr NativeFieldInfoPtr_rtHandleScale;

		// Token: 0x04000A0A RID: 2570
		[FieldOffset(0)]
		public Vector2Int previousViewportSize;

		// Token: 0x04000A0B RID: 2571
		[FieldOffset(8)]
		public Vector2Int previousRenderTargetSize;

		// Token: 0x04000A0C RID: 2572
		[FieldOffset(16)]
		public Vector2Int currentViewportSize;

		// Token: 0x04000A0D RID: 2573
		[FieldOffset(24)]
		public Vector2Int currentRenderTargetSize;

		// Token: 0x04000A0E RID: 2574
		[FieldOffset(32)]
		public Vector4 rtHandleScale;
	}
}

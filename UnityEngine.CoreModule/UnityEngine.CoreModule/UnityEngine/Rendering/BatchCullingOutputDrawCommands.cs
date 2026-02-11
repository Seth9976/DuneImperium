using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000223 RID: 547
	[StructLayout(2)]
	public struct BatchCullingOutputDrawCommands
	{
		// Token: 0x060024A6 RID: 9382 RVA: 0x0009D75C File Offset: 0x0009B95C
		// Note: this type is marked as 'beforefieldinit'.
		static BatchCullingOutputDrawCommands()
		{
			Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchCullingOutputDrawCommands");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr);
			BatchCullingOutputDrawCommands.NativeFieldInfoPtr_drawCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, "drawCommands");
			BatchCullingOutputDrawCommands.NativeFieldInfoPtr_visibleInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, "visibleInstances");
			BatchCullingOutputDrawCommands.NativeFieldInfoPtr_drawRanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, "drawRanges");
			BatchCullingOutputDrawCommands.NativeFieldInfoPtr_instanceSortingPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, "instanceSortingPositions");
			BatchCullingOutputDrawCommands.NativeFieldInfoPtr_drawCommandPickingInstanceIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, "drawCommandPickingInstanceIDs");
			BatchCullingOutputDrawCommands.NativeFieldInfoPtr_drawCommandCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, "drawCommandCount");
			BatchCullingOutputDrawCommands.NativeFieldInfoPtr_visibleInstanceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, "visibleInstanceCount");
			BatchCullingOutputDrawCommands.NativeFieldInfoPtr_drawRangeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, "drawRangeCount");
			BatchCullingOutputDrawCommands.NativeFieldInfoPtr_instanceSortingPositionFloatCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, "instanceSortingPositionFloatCount");
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x0000E62E File Offset: 0x0000C82E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, ref this));
		}

		// Token: 0x0400203B RID: 8251
		private static readonly IntPtr NativeFieldInfoPtr_drawCommands;

		// Token: 0x0400203C RID: 8252
		private static readonly IntPtr NativeFieldInfoPtr_visibleInstances;

		// Token: 0x0400203D RID: 8253
		private static readonly IntPtr NativeFieldInfoPtr_drawRanges;

		// Token: 0x0400203E RID: 8254
		private static readonly IntPtr NativeFieldInfoPtr_instanceSortingPositions;

		// Token: 0x0400203F RID: 8255
		private static readonly IntPtr NativeFieldInfoPtr_drawCommandPickingInstanceIDs;

		// Token: 0x04002040 RID: 8256
		private static readonly IntPtr NativeFieldInfoPtr_drawCommandCount;

		// Token: 0x04002041 RID: 8257
		private static readonly IntPtr NativeFieldInfoPtr_visibleInstanceCount;

		// Token: 0x04002042 RID: 8258
		private static readonly IntPtr NativeFieldInfoPtr_drawRangeCount;

		// Token: 0x04002043 RID: 8259
		private static readonly IntPtr NativeFieldInfoPtr_instanceSortingPositionFloatCount;

		// Token: 0x04002044 RID: 8260
		[FieldOffset(0)]
		public IntPtr drawCommands;

		// Token: 0x04002045 RID: 8261
		[FieldOffset(8)]
		public IntPtr visibleInstances;

		// Token: 0x04002046 RID: 8262
		[FieldOffset(16)]
		public IntPtr drawRanges;

		// Token: 0x04002047 RID: 8263
		[FieldOffset(24)]
		public IntPtr instanceSortingPositions;

		// Token: 0x04002048 RID: 8264
		[FieldOffset(32)]
		public IntPtr drawCommandPickingInstanceIDs;

		// Token: 0x04002049 RID: 8265
		[FieldOffset(40)]
		public int drawCommandCount;

		// Token: 0x0400204A RID: 8266
		[FieldOffset(44)]
		public int visibleInstanceCount;

		// Token: 0x0400204B RID: 8267
		[FieldOffset(48)]
		public int drawRangeCount;

		// Token: 0x0400204C RID: 8268
		[FieldOffset(52)]
		public int instanceSortingPositionFloatCount;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000FE RID: 254
	[StructLayout(2)]
	public struct TileData
	{
		// Token: 0x0600147B RID: 5243 RVA: 0x0005B7C0 File Offset: 0x000599C0
		// Note: this type is marked as 'beforefieldinit'.
		static TileData()
		{
			Il2CppClassPointerStore<TileData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "TileData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileData>.NativeClassPtr);
			TileData.NativeFieldInfoPtr_tileID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileData>.NativeClassPtr, "tileID");
			TileData.NativeFieldInfoPtr_listBitMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileData>.NativeClassPtr, "listBitMask");
			TileData.NativeFieldInfoPtr_relLightOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileData>.NativeClassPtr, "relLightOffset");
			TileData.NativeFieldInfoPtr_unused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileData>.NativeClassPtr, "unused");
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x0000C129 File Offset: 0x0000A329
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileData>.NativeClassPtr, ref this));
		}

		// Token: 0x04000EF0 RID: 3824
		private static readonly IntPtr NativeFieldInfoPtr_tileID;

		// Token: 0x04000EF1 RID: 3825
		private static readonly IntPtr NativeFieldInfoPtr_listBitMask;

		// Token: 0x04000EF2 RID: 3826
		private static readonly IntPtr NativeFieldInfoPtr_relLightOffset;

		// Token: 0x04000EF3 RID: 3827
		private static readonly IntPtr NativeFieldInfoPtr_unused;

		// Token: 0x04000EF4 RID: 3828
		[FieldOffset(0)]
		public uint tileID;

		// Token: 0x04000EF5 RID: 3829
		[FieldOffset(4)]
		public uint listBitMask;

		// Token: 0x04000EF6 RID: 3830
		[FieldOffset(8)]
		public uint relLightOffset;

		// Token: 0x04000EF7 RID: 3831
		[FieldOffset(12)]
		public uint unused;
	}
}

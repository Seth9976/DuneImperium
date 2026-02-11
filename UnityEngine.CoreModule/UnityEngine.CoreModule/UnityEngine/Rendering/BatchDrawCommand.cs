using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000220 RID: 544
	[StructLayout(2)]
	public struct BatchDrawCommand
	{
		// Token: 0x06002496 RID: 9366 RVA: 0x0009D550 File Offset: 0x0009B750
		// Note: this type is marked as 'beforefieldinit'.
		static BatchDrawCommand()
		{
			Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchDrawCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr);
			BatchDrawCommand.NativeFieldInfoPtr_visibleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, "visibleOffset");
			BatchDrawCommand.NativeFieldInfoPtr_visibleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, "visibleCount");
			BatchDrawCommand.NativeFieldInfoPtr_batchID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, "batchID");
			BatchDrawCommand.NativeFieldInfoPtr_materialID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, "materialID");
			BatchDrawCommand.NativeFieldInfoPtr_meshID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, "meshID");
			BatchDrawCommand.NativeFieldInfoPtr_submeshIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, "submeshIndex");
			BatchDrawCommand.NativeFieldInfoPtr_splitVisibilityMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, "splitVisibilityMask");
			BatchDrawCommand.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, "flags");
			BatchDrawCommand.NativeFieldInfoPtr_sortingPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, "sortingPosition");
		}

		// Token: 0x06002497 RID: 9367 RVA: 0x0000E583 File Offset: 0x0000C783
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, ref this));
		}

		// Token: 0x04002015 RID: 8213
		private static readonly IntPtr NativeFieldInfoPtr_visibleOffset;

		// Token: 0x04002016 RID: 8214
		private static readonly IntPtr NativeFieldInfoPtr_visibleCount;

		// Token: 0x04002017 RID: 8215
		private static readonly IntPtr NativeFieldInfoPtr_batchID;

		// Token: 0x04002018 RID: 8216
		private static readonly IntPtr NativeFieldInfoPtr_materialID;

		// Token: 0x04002019 RID: 8217
		private static readonly IntPtr NativeFieldInfoPtr_meshID;

		// Token: 0x0400201A RID: 8218
		private static readonly IntPtr NativeFieldInfoPtr_submeshIndex;

		// Token: 0x0400201B RID: 8219
		private static readonly IntPtr NativeFieldInfoPtr_splitVisibilityMask;

		// Token: 0x0400201C RID: 8220
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x0400201D RID: 8221
		private static readonly IntPtr NativeFieldInfoPtr_sortingPosition;

		// Token: 0x0400201E RID: 8222
		[FieldOffset(0)]
		public uint visibleOffset;

		// Token: 0x0400201F RID: 8223
		[FieldOffset(4)]
		public uint visibleCount;

		// Token: 0x04002020 RID: 8224
		[FieldOffset(8)]
		public BatchID batchID;

		// Token: 0x04002021 RID: 8225
		[FieldOffset(12)]
		public BatchMaterialID materialID;

		// Token: 0x04002022 RID: 8226
		[FieldOffset(16)]
		public BatchMeshID meshID;

		// Token: 0x04002023 RID: 8227
		[FieldOffset(20)]
		public ushort submeshIndex;

		// Token: 0x04002024 RID: 8228
		[FieldOffset(22)]
		public ushort splitVisibilityMask;

		// Token: 0x04002025 RID: 8229
		[FieldOffset(24)]
		public BatchDrawCommandFlags flags;

		// Token: 0x04002026 RID: 8230
		[FieldOffset(28)]
		public int sortingPosition;
	}
}

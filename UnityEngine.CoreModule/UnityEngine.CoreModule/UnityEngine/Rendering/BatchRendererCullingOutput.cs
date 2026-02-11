using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Jobs;

namespace UnityEngine.Rendering
{
	// Token: 0x02000227 RID: 551
	[StructLayout(2)]
	public struct BatchRendererCullingOutput
	{
		// Token: 0x060024CD RID: 9421 RVA: 0x0009DD88 File Offset: 0x0009BF88
		// Note: this type is marked as 'beforefieldinit'.
		static BatchRendererCullingOutput()
		{
			Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchRendererCullingOutput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr);
			BatchRendererCullingOutput.NativeFieldInfoPtr_cullingJobsFence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "cullingJobsFence");
			BatchRendererCullingOutput.NativeFieldInfoPtr_localToWorldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "localToWorldMatrix");
			BatchRendererCullingOutput.NativeFieldInfoPtr_cullingPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "cullingPlanes");
			BatchRendererCullingOutput.NativeFieldInfoPtr_cullingPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "cullingPlaneCount");
			BatchRendererCullingOutput.NativeFieldInfoPtr_receiverPlaneOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "receiverPlaneOffset");
			BatchRendererCullingOutput.NativeFieldInfoPtr_receiverPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "receiverPlaneCount");
			BatchRendererCullingOutput.NativeFieldInfoPtr_cullingSplits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "cullingSplits");
			BatchRendererCullingOutput.NativeFieldInfoPtr_cullingSplitCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "cullingSplitCount");
			BatchRendererCullingOutput.NativeFieldInfoPtr_viewType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "viewType");
			BatchRendererCullingOutput.NativeFieldInfoPtr_projectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "projectionType");
			BatchRendererCullingOutput.NativeFieldInfoPtr_cullingFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "cullingFlags");
			BatchRendererCullingOutput.NativeFieldInfoPtr_viewID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "viewID");
			BatchRendererCullingOutput.NativeFieldInfoPtr_cullingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "cullingLayerMask");
			BatchRendererCullingOutput.NativeFieldInfoPtr_sceneCullingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "sceneCullingMask");
			BatchRendererCullingOutput.NativeFieldInfoPtr_drawCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "drawCommands");
		}

		// Token: 0x060024CE RID: 9422 RVA: 0x0000E874 File Offset: 0x0000CA74
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, ref this));
		}

		// Token: 0x0400206A RID: 8298
		private static readonly IntPtr NativeFieldInfoPtr_cullingJobsFence;

		// Token: 0x0400206B RID: 8299
		private static readonly IntPtr NativeFieldInfoPtr_localToWorldMatrix;

		// Token: 0x0400206C RID: 8300
		private static readonly IntPtr NativeFieldInfoPtr_cullingPlanes;

		// Token: 0x0400206D RID: 8301
		private static readonly IntPtr NativeFieldInfoPtr_cullingPlaneCount;

		// Token: 0x0400206E RID: 8302
		private static readonly IntPtr NativeFieldInfoPtr_receiverPlaneOffset;

		// Token: 0x0400206F RID: 8303
		private static readonly IntPtr NativeFieldInfoPtr_receiverPlaneCount;

		// Token: 0x04002070 RID: 8304
		private static readonly IntPtr NativeFieldInfoPtr_cullingSplits;

		// Token: 0x04002071 RID: 8305
		private static readonly IntPtr NativeFieldInfoPtr_cullingSplitCount;

		// Token: 0x04002072 RID: 8306
		private static readonly IntPtr NativeFieldInfoPtr_viewType;

		// Token: 0x04002073 RID: 8307
		private static readonly IntPtr NativeFieldInfoPtr_projectionType;

		// Token: 0x04002074 RID: 8308
		private static readonly IntPtr NativeFieldInfoPtr_cullingFlags;

		// Token: 0x04002075 RID: 8309
		private static readonly IntPtr NativeFieldInfoPtr_viewID;

		// Token: 0x04002076 RID: 8310
		private static readonly IntPtr NativeFieldInfoPtr_cullingLayerMask;

		// Token: 0x04002077 RID: 8311
		private static readonly IntPtr NativeFieldInfoPtr_sceneCullingMask;

		// Token: 0x04002078 RID: 8312
		private static readonly IntPtr NativeFieldInfoPtr_drawCommands;

		// Token: 0x04002079 RID: 8313
		[FieldOffset(0)]
		public Unity.Jobs.JobHandle cullingJobsFence;

		// Token: 0x0400207A RID: 8314
		[FieldOffset(16)]
		public Matrix4x4 localToWorldMatrix;

		// Token: 0x0400207B RID: 8315
		[FieldOffset(80)]
		public IntPtr cullingPlanes;

		// Token: 0x0400207C RID: 8316
		[FieldOffset(88)]
		public int cullingPlaneCount;

		// Token: 0x0400207D RID: 8317
		[FieldOffset(92)]
		public int receiverPlaneOffset;

		// Token: 0x0400207E RID: 8318
		[FieldOffset(96)]
		public int receiverPlaneCount;

		// Token: 0x0400207F RID: 8319
		[FieldOffset(104)]
		public IntPtr cullingSplits;

		// Token: 0x04002080 RID: 8320
		[FieldOffset(112)]
		public int cullingSplitCount;

		// Token: 0x04002081 RID: 8321
		[FieldOffset(116)]
		public BatchCullingViewType viewType;

		// Token: 0x04002082 RID: 8322
		[FieldOffset(120)]
		public BatchCullingProjectionType projectionType;

		// Token: 0x04002083 RID: 8323
		[FieldOffset(124)]
		public BatchCullingFlags cullingFlags;

		// Token: 0x04002084 RID: 8324
		[FieldOffset(128)]
		public ulong viewID;

		// Token: 0x04002085 RID: 8325
		[FieldOffset(136)]
		public uint cullingLayerMask;

		// Token: 0x04002086 RID: 8326
		[FieldOffset(144)]
		public ulong sceneCullingMask;

		// Token: 0x04002087 RID: 8327
		[FieldOffset(152)]
		public IntPtr drawCommands;
	}
}

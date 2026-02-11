using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.U2D
{
	// Token: 0x0200026A RID: 618
	[StructLayout(2)]
	public struct SpriteIntermediateRendererInfo
	{
		// Token: 0x06002AFA RID: 11002 RVA: 0x000AE144 File Offset: 0x000AC344
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteIntermediateRendererInfo()
		{
			Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.U2D", "SpriteIntermediateRendererInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr);
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_SpriteID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "SpriteID");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_TextureID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "TextureID");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_MaterialID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "MaterialID");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "Color");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "Transform");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_Bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "Bounds");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_Layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "Layer");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_SortingLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "SortingLayer");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_SortingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "SortingOrder");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_SceneCullingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "SceneCullingMask");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_IndexData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "IndexData");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_VertexData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "VertexData");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "IndexCount");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_VertexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "VertexCount");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_ShaderChannelMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "ShaderChannelMask");
		}

		// Token: 0x06002AFB RID: 11003 RVA: 0x00010D1A File Offset: 0x0000EF1A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x04002569 RID: 9577
		private static readonly IntPtr NativeFieldInfoPtr_SpriteID;

		// Token: 0x0400256A RID: 9578
		private static readonly IntPtr NativeFieldInfoPtr_TextureID;

		// Token: 0x0400256B RID: 9579
		private static readonly IntPtr NativeFieldInfoPtr_MaterialID;

		// Token: 0x0400256C RID: 9580
		private static readonly IntPtr NativeFieldInfoPtr_Color;

		// Token: 0x0400256D RID: 9581
		private static readonly IntPtr NativeFieldInfoPtr_Transform;

		// Token: 0x0400256E RID: 9582
		private static readonly IntPtr NativeFieldInfoPtr_Bounds;

		// Token: 0x0400256F RID: 9583
		private static readonly IntPtr NativeFieldInfoPtr_Layer;

		// Token: 0x04002570 RID: 9584
		private static readonly IntPtr NativeFieldInfoPtr_SortingLayer;

		// Token: 0x04002571 RID: 9585
		private static readonly IntPtr NativeFieldInfoPtr_SortingOrder;

		// Token: 0x04002572 RID: 9586
		private static readonly IntPtr NativeFieldInfoPtr_SceneCullingMask;

		// Token: 0x04002573 RID: 9587
		private static readonly IntPtr NativeFieldInfoPtr_IndexData;

		// Token: 0x04002574 RID: 9588
		private static readonly IntPtr NativeFieldInfoPtr_VertexData;

		// Token: 0x04002575 RID: 9589
		private static readonly IntPtr NativeFieldInfoPtr_IndexCount;

		// Token: 0x04002576 RID: 9590
		private static readonly IntPtr NativeFieldInfoPtr_VertexCount;

		// Token: 0x04002577 RID: 9591
		private static readonly IntPtr NativeFieldInfoPtr_ShaderChannelMask;

		// Token: 0x04002578 RID: 9592
		[FieldOffset(0)]
		public int SpriteID;

		// Token: 0x04002579 RID: 9593
		[FieldOffset(4)]
		public int TextureID;

		// Token: 0x0400257A RID: 9594
		[FieldOffset(8)]
		public int MaterialID;

		// Token: 0x0400257B RID: 9595
		[FieldOffset(12)]
		public Color Color;

		// Token: 0x0400257C RID: 9596
		[FieldOffset(28)]
		public Matrix4x4 Transform;

		// Token: 0x0400257D RID: 9597
		[FieldOffset(92)]
		public Bounds Bounds;

		// Token: 0x0400257E RID: 9598
		[FieldOffset(116)]
		public int Layer;

		// Token: 0x0400257F RID: 9599
		[FieldOffset(120)]
		public int SortingLayer;

		// Token: 0x04002580 RID: 9600
		[FieldOffset(124)]
		public int SortingOrder;

		// Token: 0x04002581 RID: 9601
		[FieldOffset(128)]
		public ulong SceneCullingMask;

		// Token: 0x04002582 RID: 9602
		[FieldOffset(136)]
		public IntPtr IndexData;

		// Token: 0x04002583 RID: 9603
		[FieldOffset(144)]
		public IntPtr VertexData;

		// Token: 0x04002584 RID: 9604
		[FieldOffset(152)]
		public int IndexCount;

		// Token: 0x04002585 RID: 9605
		[FieldOffset(156)]
		public int VertexCount;

		// Token: 0x04002586 RID: 9606
		[FieldOffset(160)]
		public int ShaderChannelMask;
	}
}

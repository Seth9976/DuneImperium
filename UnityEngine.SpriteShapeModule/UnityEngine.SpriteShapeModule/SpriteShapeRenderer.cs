using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Rendering;

namespace UnityEngine.U2D
{
	// Token: 0x02000002 RID: 2
	public class SpriteShapeRenderer : Renderer
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002168 File Offset: 0x00000368
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteShapeRenderer()
		{
			Il2CppClassPointerStore<SpriteShapeRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SpriteShapeModule.dll", "UnityEngine.U2D", "SpriteShapeRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteShapeRenderer>.NativeClassPtr);
			SpriteShapeRenderer.get_maskInteractionDelegateField = IL2CPP.ResolveICall<SpriteShapeRenderer.get_maskInteractionDelegate>("UnityEngine.U2D.SpriteShapeRenderer::get_maskInteraction");
			SpriteShapeRenderer.set_maskInteractionDelegateField = IL2CPP.ResolveICall<SpriteShapeRenderer.set_maskInteractionDelegate>("UnityEngine.U2D.SpriteShapeRenderer::set_maskInteraction");
			SpriteShapeRenderer.SetSegmentCountDelegateField = IL2CPP.ResolveICall<SpriteShapeRenderer.SetSegmentCountDelegate>("UnityEngine.U2D.SpriteShapeRenderer::SetSegmentCount");
			SpriteShapeRenderer.SetMeshDataCountDelegateField = IL2CPP.ResolveICall<SpriteShapeRenderer.SetMeshDataCountDelegate>("UnityEngine.U2D.SpriteShapeRenderer::SetMeshDataCount");
			SpriteShapeRenderer.SetMeshChannelInfoDelegateField = IL2CPP.ResolveICall<SpriteShapeRenderer.SetMeshChannelInfoDelegate>("UnityEngine.U2D.SpriteShapeRenderer::SetMeshChannelInfo");
			SpriteShapeRenderer.get_color_InjectedDelegateField = IL2CPP.ResolveICall<SpriteShapeRenderer.get_color_InjectedDelegate>("UnityEngine.U2D.SpriteShapeRenderer::get_color_Injected");
			SpriteShapeRenderer.set_color_InjectedDelegateField = IL2CPP.ResolveICall<SpriteShapeRenderer.set_color_InjectedDelegate>("UnityEngine.U2D.SpriteShapeRenderer::set_color_Injected");
			SpriteShapeRenderer.GetDataInfo_InjectedDelegateField = IL2CPP.ResolveICall<SpriteShapeRenderer.GetDataInfo_InjectedDelegate>("UnityEngine.U2D.SpriteShapeRenderer::GetDataInfo_Injected");
			SpriteShapeRenderer.GetChannelInfo_InjectedDelegateField = IL2CPP.ResolveICall<SpriteShapeRenderer.GetChannelInfo_InjectedDelegate>("UnityEngine.U2D.SpriteShapeRenderer::GetChannelInfo_Injected");
			SpriteShapeRenderer.SetLocalAABB_InjectedDelegateField = IL2CPP.ResolveICall<SpriteShapeRenderer.SetLocalAABB_InjectedDelegate>("UnityEngine.U2D.SpriteShapeRenderer::SetLocalAABB_Injected");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		public SpriteShapeRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002230 File Offset: 0x00000430
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002059 File Offset: 0x00000259
		public Color color
		{
			get
			{
				Color color;
				this.get_color_Injected(out color);
				return color;
			}
			set
			{
				this.set_color_Injected(ref value);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002063 File Offset: 0x00000263
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002075 File Offset: 0x00000275
		public SpriteMaskInteraction maskInteraction
		{
			get
			{
				return SpriteShapeRenderer.get_maskInteractionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteShapeRenderer.set_maskInteractionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002248 File Offset: 0x00000448
		public NativeArray<T> GetNativeDataArray<T>(SpriteShapeDataType dataType) where T : struct
		{
			SpriteChannelInfo dataInfo = this.GetDataInfo(dataType);
			return NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<T>(dataInfo.buffer, dataInfo.count, Allocator.Invalid);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002278 File Offset: 0x00000478
		public unsafe NativeSlice<T> GetChannelDataArray<T>(SpriteShapeDataType dataType, VertexAttribute channel) where T : struct
		{
			SpriteChannelInfo channelInfo = this.GetChannelInfo(channel);
			byte* ptr = (byte*)channelInfo.buffer + channelInfo.offset;
			return NativeSliceUnsafeUtility.ConvertExistingDataToNativeSlice<T>((void*)ptr, channelInfo.stride, channelInfo.count);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002088 File Offset: 0x00000288
		public void SetSegmentCount(int geomCount)
		{
			SpriteShapeRenderer.SetSegmentCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), geomCount);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000209B File Offset: 0x0000029B
		public void SetMeshDataCount(int vertexCount, int indexCount)
		{
			SpriteShapeRenderer.SetMeshDataCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), vertexCount, indexCount);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020AF File Offset: 0x000002AF
		public void SetMeshChannelInfo(int vertexCount, int indexCount, int hotChannelMask)
		{
			SpriteShapeRenderer.SetMeshChannelInfoDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), vertexCount, indexCount, hotChannelMask);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000022B8 File Offset: 0x000004B8
		public SpriteChannelInfo GetDataInfo(SpriteShapeDataType arrayType)
		{
			SpriteChannelInfo spriteChannelInfo;
			this.GetDataInfo_Injected(arrayType, out spriteChannelInfo);
			return spriteChannelInfo;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000022D0 File Offset: 0x000004D0
		public SpriteChannelInfo GetChannelInfo(VertexAttribute channel)
		{
			SpriteChannelInfo spriteChannelInfo;
			this.GetChannelInfo_Injected(channel, out spriteChannelInfo);
			return spriteChannelInfo;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020C4 File Offset: 0x000002C4
		public void SetLocalAABB(Bounds bounds)
		{
			this.SetLocalAABB_Injected(ref bounds);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000022E8 File Offset: 0x000004E8
		public NativeArray<Bounds> GetBounds()
		{
			return this.GetNativeDataArray<Bounds>(SpriteShapeDataType.BoundingBox);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000020CE File Offset: 0x000002CE
		public void GetChannels(int dataSize, out NativeArray<ushort> indices, out NativeSlice<Vector3> vertices, out NativeSlice<Vector2> texcoords)
		{
			this.SetMeshDataCount(dataSize, dataSize);
			indices = this.GetNativeDataArray<ushort>(SpriteShapeDataType.Index);
			vertices = this.GetChannelDataArray<Vector3>(SpriteShapeDataType.ChannelVertex, VertexAttribute.Position);
			texcoords = this.GetChannelDataArray<Vector2>(SpriteShapeDataType.ChannelTexCoord0, VertexAttribute.TexCoord0);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002304 File Offset: 0x00000504
		public void GetChannels(int dataSize, out NativeArray<ushort> indices, out NativeSlice<Vector3> vertices, out NativeSlice<Vector2> texcoords, out NativeSlice<Color32> colors)
		{
			this.SetMeshChannelInfo(dataSize, dataSize, 8);
			indices = this.GetNativeDataArray<ushort>(SpriteShapeDataType.Index);
			vertices = this.GetChannelDataArray<Vector3>(SpriteShapeDataType.ChannelVertex, VertexAttribute.Position);
			texcoords = this.GetChannelDataArray<Vector2>(SpriteShapeDataType.ChannelTexCoord0, VertexAttribute.TexCoord0);
			colors = this.GetChannelDataArray<Color32>(SpriteShapeDataType.ChannelColor, VertexAttribute.Color);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002358 File Offset: 0x00000558
		public void GetChannels(int dataSize, out NativeArray<ushort> indices, out NativeSlice<Vector3> vertices, out NativeSlice<Vector2> texcoords, out NativeSlice<Vector4> tangents)
		{
			this.SetMeshChannelInfo(dataSize, dataSize, 4);
			indices = this.GetNativeDataArray<ushort>(SpriteShapeDataType.Index);
			vertices = this.GetChannelDataArray<Vector3>(SpriteShapeDataType.ChannelVertex, VertexAttribute.Position);
			texcoords = this.GetChannelDataArray<Vector2>(SpriteShapeDataType.ChannelTexCoord0, VertexAttribute.TexCoord0);
			tangents = this.GetChannelDataArray<Vector4>(SpriteShapeDataType.ChannelTangent, VertexAttribute.Tangent);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000023AC File Offset: 0x000005AC
		public void GetChannels(int dataSize, out NativeArray<ushort> indices, out NativeSlice<Vector3> vertices, out NativeSlice<Vector2> texcoords, out NativeSlice<Color32> colors, out NativeSlice<Vector4> tangents)
		{
			this.SetMeshChannelInfo(dataSize, dataSize, 12);
			indices = this.GetNativeDataArray<ushort>(SpriteShapeDataType.Index);
			vertices = this.GetChannelDataArray<Vector3>(SpriteShapeDataType.ChannelVertex, VertexAttribute.Position);
			texcoords = this.GetChannelDataArray<Vector2>(SpriteShapeDataType.ChannelTexCoord0, VertexAttribute.TexCoord0);
			colors = this.GetChannelDataArray<Color32>(SpriteShapeDataType.ChannelColor, VertexAttribute.Color);
			tangents = this.GetChannelDataArray<Vector4>(SpriteShapeDataType.ChannelTangent, VertexAttribute.Tangent);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002410 File Offset: 0x00000610
		public void GetChannels(int dataSize, out NativeArray<ushort> indices, out NativeSlice<Vector3> vertices, out NativeSlice<Vector2> texcoords, out NativeSlice<Vector4> tangents, out NativeSlice<Vector3> normals)
		{
			this.SetMeshChannelInfo(dataSize, dataSize, 6);
			indices = this.GetNativeDataArray<ushort>(SpriteShapeDataType.Index);
			vertices = this.GetChannelDataArray<Vector3>(SpriteShapeDataType.ChannelVertex, VertexAttribute.Position);
			texcoords = this.GetChannelDataArray<Vector2>(SpriteShapeDataType.ChannelTexCoord0, VertexAttribute.TexCoord0);
			tangents = this.GetChannelDataArray<Vector4>(SpriteShapeDataType.ChannelTangent, VertexAttribute.Tangent);
			normals = this.GetChannelDataArray<Vector3>(SpriteShapeDataType.ChannelNormal, VertexAttribute.Normal);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002470 File Offset: 0x00000670
		public void GetChannels(int dataSize, out NativeArray<ushort> indices, out NativeSlice<Vector3> vertices, out NativeSlice<Vector2> texcoords, out NativeSlice<Color32> colors, out NativeSlice<Vector4> tangents, out NativeSlice<Vector3> normals)
		{
			this.SetMeshChannelInfo(dataSize, dataSize, 14);
			indices = this.GetNativeDataArray<ushort>(SpriteShapeDataType.Index);
			vertices = this.GetChannelDataArray<Vector3>(SpriteShapeDataType.ChannelVertex, VertexAttribute.Position);
			texcoords = this.GetChannelDataArray<Vector2>(SpriteShapeDataType.ChannelTexCoord0, VertexAttribute.TexCoord0);
			colors = this.GetChannelDataArray<Color32>(SpriteShapeDataType.ChannelColor, VertexAttribute.Color);
			tangents = this.GetChannelDataArray<Vector4>(SpriteShapeDataType.ChannelTangent, VertexAttribute.Tangent);
			normals = this.GetChannelDataArray<Vector3>(SpriteShapeDataType.ChannelNormal, VertexAttribute.Normal);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002104 File Offset: 0x00000304
		public void get_color_Injected(out Color ret)
		{
			SpriteShapeRenderer.get_color_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002117 File Offset: 0x00000317
		public void set_color_Injected(ref Color value)
		{
			SpriteShapeRenderer.set_color_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000212A File Offset: 0x0000032A
		public void GetDataInfo_Injected(SpriteShapeDataType arrayType, out SpriteChannelInfo ret)
		{
			SpriteShapeRenderer.GetDataInfo_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), arrayType, out ret);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000213E File Offset: 0x0000033E
		public void GetChannelInfo_Injected(VertexAttribute channel, out SpriteChannelInfo ret)
		{
			SpriteShapeRenderer.GetChannelInfo_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), channel, out ret);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002152 File Offset: 0x00000352
		public void SetLocalAABB_Injected(ref Bounds bounds)
		{
			SpriteShapeRenderer.SetLocalAABB_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref bounds);
		}

		// Token: 0x04000001 RID: 1
		private static readonly SpriteShapeRenderer.get_maskInteractionDelegate get_maskInteractionDelegateField;

		// Token: 0x04000002 RID: 2
		private static readonly SpriteShapeRenderer.set_maskInteractionDelegate set_maskInteractionDelegateField;

		// Token: 0x04000003 RID: 3
		private static readonly SpriteShapeRenderer.SetSegmentCountDelegate SetSegmentCountDelegateField;

		// Token: 0x04000004 RID: 4
		private static readonly SpriteShapeRenderer.SetMeshDataCountDelegate SetMeshDataCountDelegateField;

		// Token: 0x04000005 RID: 5
		private static readonly SpriteShapeRenderer.SetMeshChannelInfoDelegate SetMeshChannelInfoDelegateField;

		// Token: 0x04000006 RID: 6
		private static readonly SpriteShapeRenderer.get_color_InjectedDelegate get_color_InjectedDelegateField;

		// Token: 0x04000007 RID: 7
		private static readonly SpriteShapeRenderer.set_color_InjectedDelegate set_color_InjectedDelegateField;

		// Token: 0x04000008 RID: 8
		private static readonly SpriteShapeRenderer.GetDataInfo_InjectedDelegate GetDataInfo_InjectedDelegateField;

		// Token: 0x04000009 RID: 9
		private static readonly SpriteShapeRenderer.GetChannelInfo_InjectedDelegate GetChannelInfo_InjectedDelegateField;

		// Token: 0x0400000A RID: 10
		private static readonly SpriteShapeRenderer.SetLocalAABB_InjectedDelegate SetLocalAABB_InjectedDelegateField;

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x0600001C RID: 28
		private delegate SpriteMaskInteraction get_maskInteractionDelegate(IntPtr @this);

		// Token: 0x02000006 RID: 6
		// (Invoke) Token: 0x0600001E RID: 30
		private delegate void set_maskInteractionDelegate(IntPtr @this, SpriteMaskInteraction value);

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x06000020 RID: 32
		private delegate void SetSegmentCountDelegate(IntPtr @this, int geomCount);

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x06000022 RID: 34
		private delegate void SetMeshDataCountDelegate(IntPtr @this, int vertexCount, int indexCount);

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x06000024 RID: 36
		private delegate void SetMeshChannelInfoDelegate(IntPtr @this, int vertexCount, int indexCount, int hotChannelMask);

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x06000026 RID: 38
		private delegate void get_color_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x06000028 RID: 40
		private delegate void set_color_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x0600002A RID: 42
		private delegate void GetDataInfo_InjectedDelegate(IntPtr @this, SpriteShapeDataType arrayType, [Out] IntPtr ret);

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x0600002C RID: 44
		private delegate void GetChannelInfo_InjectedDelegate(IntPtr @this, VertexAttribute channel, [Out] IntPtr ret);

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x0600002E RID: 46
		private delegate void SetLocalAABB_InjectedDelegate(IntPtr @this, IntPtr bounds);
	}
}

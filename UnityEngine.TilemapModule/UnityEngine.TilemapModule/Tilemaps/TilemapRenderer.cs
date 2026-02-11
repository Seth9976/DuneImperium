using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.U2D;

namespace UnityEngine.Tilemaps
{
	// Token: 0x02000008 RID: 8
	public sealed class TilemapRenderer : Renderer
	{
		// Token: 0x060000E4 RID: 228 RVA: 0x00004A9C File Offset: 0x00002C9C
		// Note: this type is marked as 'beforefieldinit'.
		static TilemapRenderer()
		{
			Il2CppClassPointerStore<TilemapRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TilemapModule.dll", "UnityEngine.Tilemaps", "TilemapRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TilemapRenderer>.NativeClassPtr);
			TilemapRenderer.NativeMethodInfoPtr_RegisterSpriteAtlasRegistered_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilemapRenderer>.NativeClassPtr, 100663338);
			TilemapRenderer.NativeMethodInfoPtr_UnregisterSpriteAtlasRegistered_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilemapRenderer>.NativeClassPtr, 100663339);
			TilemapRenderer.NativeMethodInfoPtr_OnSpriteAtlasRegistered_Internal_Void_SpriteAtlas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilemapRenderer>.NativeClassPtr, 100663340);
			TilemapRenderer.get_maxChunkCountDelegateField = IL2CPP.ResolveICall<TilemapRenderer.get_maxChunkCountDelegate>("UnityEngine.Tilemaps.TilemapRenderer::get_maxChunkCount");
			TilemapRenderer.set_maxChunkCountDelegateField = IL2CPP.ResolveICall<TilemapRenderer.set_maxChunkCountDelegate>("UnityEngine.Tilemaps.TilemapRenderer::set_maxChunkCount");
			TilemapRenderer.get_maxFrameAgeDelegateField = IL2CPP.ResolveICall<TilemapRenderer.get_maxFrameAgeDelegate>("UnityEngine.Tilemaps.TilemapRenderer::get_maxFrameAge");
			TilemapRenderer.set_maxFrameAgeDelegateField = IL2CPP.ResolveICall<TilemapRenderer.set_maxFrameAgeDelegate>("UnityEngine.Tilemaps.TilemapRenderer::set_maxFrameAge");
			TilemapRenderer.get_sortOrderDelegateField = IL2CPP.ResolveICall<TilemapRenderer.get_sortOrderDelegate>("UnityEngine.Tilemaps.TilemapRenderer::get_sortOrder");
			TilemapRenderer.set_sortOrderDelegateField = IL2CPP.ResolveICall<TilemapRenderer.set_sortOrderDelegate>("UnityEngine.Tilemaps.TilemapRenderer::set_sortOrder");
			TilemapRenderer.get_modeDelegateField = IL2CPP.ResolveICall<TilemapRenderer.get_modeDelegate>("UnityEngine.Tilemaps.TilemapRenderer::get_mode");
			TilemapRenderer.set_modeDelegateField = IL2CPP.ResolveICall<TilemapRenderer.set_modeDelegate>("UnityEngine.Tilemaps.TilemapRenderer::set_mode");
			TilemapRenderer.get_detectChunkCullingBoundsDelegateField = IL2CPP.ResolveICall<TilemapRenderer.get_detectChunkCullingBoundsDelegate>("UnityEngine.Tilemaps.TilemapRenderer::get_detectChunkCullingBounds");
			TilemapRenderer.set_detectChunkCullingBoundsDelegateField = IL2CPP.ResolveICall<TilemapRenderer.set_detectChunkCullingBoundsDelegate>("UnityEngine.Tilemaps.TilemapRenderer::set_detectChunkCullingBounds");
			TilemapRenderer.get_maskInteractionDelegateField = IL2CPP.ResolveICall<TilemapRenderer.get_maskInteractionDelegate>("UnityEngine.Tilemaps.TilemapRenderer::get_maskInteraction");
			TilemapRenderer.set_maskInteractionDelegateField = IL2CPP.ResolveICall<TilemapRenderer.set_maskInteractionDelegate>("UnityEngine.Tilemaps.TilemapRenderer::set_maskInteraction");
			TilemapRenderer.get_chunkSize_InjectedDelegateField = IL2CPP.ResolveICall<TilemapRenderer.get_chunkSize_InjectedDelegate>("UnityEngine.Tilemaps.TilemapRenderer::get_chunkSize_Injected");
			TilemapRenderer.set_chunkSize_InjectedDelegateField = IL2CPP.ResolveICall<TilemapRenderer.set_chunkSize_InjectedDelegate>("UnityEngine.Tilemaps.TilemapRenderer::set_chunkSize_Injected");
			TilemapRenderer.get_chunkCullingBounds_InjectedDelegateField = IL2CPP.ResolveICall<TilemapRenderer.get_chunkCullingBounds_InjectedDelegate>("UnityEngine.Tilemaps.TilemapRenderer::get_chunkCullingBounds_Injected");
			TilemapRenderer.set_chunkCullingBounds_InjectedDelegateField = IL2CPP.ResolveICall<TilemapRenderer.set_chunkCullingBounds_InjectedDelegate>("UnityEngine.Tilemaps.TilemapRenderer::set_chunkCullingBounds_Injected");
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00004BF8 File Offset: 0x00002DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268954, XrefRangeEnd = 1268961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterSpriteAtlasRegistered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TilemapRenderer.NativeMethodInfoPtr_RegisterSpriteAtlasRegistered_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00004C2C File Offset: 0x00002E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268961, XrefRangeEnd = 1268968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterSpriteAtlasRegistered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TilemapRenderer.NativeMethodInfoPtr_UnregisterSpriteAtlasRegistered_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00004C60 File Offset: 0x00002E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268968, XrefRangeEnd = 1268970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSpriteAtlasRegistered(SpriteAtlas atlas)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(atlas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TilemapRenderer.NativeMethodInfoPtr_OnSpriteAtlasRegistered_Internal_Void_SpriteAtlas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002911 File Offset: 0x00000B11
		public TilemapRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00004CA4 File Offset: 0x00002EA4
		// (set) Token: 0x060000EA RID: 234 RVA: 0x0000291A File Offset: 0x00000B1A
		public Vector3Int chunkSize
		{
			get
			{
				Vector3Int vector3Int;
				this.get_chunkSize_Injected(out vector3Int);
				return vector3Int;
			}
			set
			{
				this.set_chunkSize_Injected(ref value);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00004CBC File Offset: 0x00002EBC
		// (set) Token: 0x060000EC RID: 236 RVA: 0x00002924 File Offset: 0x00000B24
		public Vector3 chunkCullingBounds
		{
			get
			{
				Vector3 vector;
				this.get_chunkCullingBounds_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_chunkCullingBounds_Injected(ref value);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000ED RID: 237 RVA: 0x0000292E File Offset: 0x00000B2E
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00002940 File Offset: 0x00000B40
		public int maxChunkCount
		{
			get
			{
				return TilemapRenderer.get_maxChunkCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TilemapRenderer.set_maxChunkCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00002953 File Offset: 0x00000B53
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x00002965 File Offset: 0x00000B65
		public int maxFrameAge
		{
			get
			{
				return TilemapRenderer.get_maxFrameAgeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TilemapRenderer.set_maxFrameAgeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00002978 File Offset: 0x00000B78
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x0000298A File Offset: 0x00000B8A
		public TilemapRenderer.SortOrder sortOrder
		{
			get
			{
				return TilemapRenderer.get_sortOrderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TilemapRenderer.set_sortOrderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x0000299D File Offset: 0x00000B9D
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x000029AF File Offset: 0x00000BAF
		public TilemapRenderer.Mode mode
		{
			get
			{
				return TilemapRenderer.get_modeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TilemapRenderer.set_modeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x000029C2 File Offset: 0x00000BC2
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x000029D4 File Offset: 0x00000BD4
		public TilemapRenderer.DetectChunkCullingBounds detectChunkCullingBounds
		{
			get
			{
				return TilemapRenderer.get_detectChunkCullingBoundsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TilemapRenderer.set_detectChunkCullingBoundsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x000029E7 File Offset: 0x00000BE7
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x000029F9 File Offset: 0x00000BF9
		public SpriteMaskInteraction maskInteraction
		{
			get
			{
				return TilemapRenderer.get_maskInteractionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TilemapRenderer.set_maskInteractionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002A0C File Offset: 0x00000C0C
		public void get_chunkSize_Injected(out Vector3Int ret)
		{
			TilemapRenderer.get_chunkSize_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002A1F File Offset: 0x00000C1F
		public void set_chunkSize_Injected(ref Vector3Int value)
		{
			TilemapRenderer.set_chunkSize_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002A32 File Offset: 0x00000C32
		public void get_chunkCullingBounds_Injected(out Vector3 ret)
		{
			TilemapRenderer.get_chunkCullingBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002A45 File Offset: 0x00000C45
		public void set_chunkCullingBounds_Injected(ref Vector3 value)
		{
			TilemapRenderer.set_chunkCullingBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_RegisterSpriteAtlasRegistered_Internal_Void_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterSpriteAtlasRegistered_Internal_Void_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_OnSpriteAtlasRegistered_Internal_Void_SpriteAtlas_0;

		// Token: 0x04000087 RID: 135
		private static readonly TilemapRenderer.get_maxChunkCountDelegate get_maxChunkCountDelegateField;

		// Token: 0x04000088 RID: 136
		private static readonly TilemapRenderer.set_maxChunkCountDelegate set_maxChunkCountDelegateField;

		// Token: 0x04000089 RID: 137
		private static readonly TilemapRenderer.get_maxFrameAgeDelegate get_maxFrameAgeDelegateField;

		// Token: 0x0400008A RID: 138
		private static readonly TilemapRenderer.set_maxFrameAgeDelegate set_maxFrameAgeDelegateField;

		// Token: 0x0400008B RID: 139
		private static readonly TilemapRenderer.get_sortOrderDelegate get_sortOrderDelegateField;

		// Token: 0x0400008C RID: 140
		private static readonly TilemapRenderer.set_sortOrderDelegate set_sortOrderDelegateField;

		// Token: 0x0400008D RID: 141
		private static readonly TilemapRenderer.get_modeDelegate get_modeDelegateField;

		// Token: 0x0400008E RID: 142
		private static readonly TilemapRenderer.set_modeDelegate set_modeDelegateField;

		// Token: 0x0400008F RID: 143
		private static readonly TilemapRenderer.get_detectChunkCullingBoundsDelegate get_detectChunkCullingBoundsDelegateField;

		// Token: 0x04000090 RID: 144
		private static readonly TilemapRenderer.set_detectChunkCullingBoundsDelegate set_detectChunkCullingBoundsDelegateField;

		// Token: 0x04000091 RID: 145
		private static readonly TilemapRenderer.get_maskInteractionDelegate get_maskInteractionDelegateField;

		// Token: 0x04000092 RID: 146
		private static readonly TilemapRenderer.set_maskInteractionDelegate set_maskInteractionDelegateField;

		// Token: 0x04000093 RID: 147
		private static readonly TilemapRenderer.get_chunkSize_InjectedDelegate get_chunkSize_InjectedDelegateField;

		// Token: 0x04000094 RID: 148
		private static readonly TilemapRenderer.set_chunkSize_InjectedDelegate set_chunkSize_InjectedDelegateField;

		// Token: 0x04000095 RID: 149
		private static readonly TilemapRenderer.get_chunkCullingBounds_InjectedDelegate get_chunkCullingBounds_InjectedDelegateField;

		// Token: 0x04000096 RID: 150
		private static readonly TilemapRenderer.set_chunkCullingBounds_InjectedDelegate set_chunkCullingBounds_InjectedDelegateField;

		// Token: 0x02000054 RID: 84
		public enum SortOrder
		{
			// Token: 0x040000DD RID: 221
			BottomLeft,
			// Token: 0x040000DE RID: 222
			BottomRight,
			// Token: 0x040000DF RID: 223
			TopLeft,
			// Token: 0x040000E0 RID: 224
			TopRight
		}

		// Token: 0x02000055 RID: 85
		public enum Mode
		{
			// Token: 0x040000E2 RID: 226
			Chunk,
			// Token: 0x040000E3 RID: 227
			Individual
		}

		// Token: 0x02000056 RID: 86
		public enum DetectChunkCullingBounds
		{
			// Token: 0x040000E5 RID: 229
			Auto,
			// Token: 0x040000E6 RID: 230
			Manual
		}

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x060001EA RID: 490
		private delegate int get_maxChunkCountDelegate(IntPtr @this);

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x060001EC RID: 492
		private delegate void set_maxChunkCountDelegate(IntPtr @this, int value);

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x060001EE RID: 494
		private delegate int get_maxFrameAgeDelegate(IntPtr @this);

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x060001F0 RID: 496
		private delegate void set_maxFrameAgeDelegate(IntPtr @this, int value);

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x060001F2 RID: 498
		private delegate TilemapRenderer.SortOrder get_sortOrderDelegate(IntPtr @this);

		// Token: 0x0200005C RID: 92
		// (Invoke) Token: 0x060001F4 RID: 500
		private delegate void set_sortOrderDelegate(IntPtr @this, TilemapRenderer.SortOrder value);

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x060001F6 RID: 502
		private delegate TilemapRenderer.Mode get_modeDelegate(IntPtr @this);

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x060001F8 RID: 504
		private delegate void set_modeDelegate(IntPtr @this, TilemapRenderer.Mode value);

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x060001FA RID: 506
		private delegate TilemapRenderer.DetectChunkCullingBounds get_detectChunkCullingBoundsDelegate(IntPtr @this);

		// Token: 0x02000060 RID: 96
		// (Invoke) Token: 0x060001FC RID: 508
		private delegate void set_detectChunkCullingBoundsDelegate(IntPtr @this, TilemapRenderer.DetectChunkCullingBounds value);

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x060001FE RID: 510
		private delegate SpriteMaskInteraction get_maskInteractionDelegate(IntPtr @this);

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x06000200 RID: 512
		private delegate void set_maskInteractionDelegate(IntPtr @this, SpriteMaskInteraction value);

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x06000202 RID: 514
		private delegate void get_chunkSize_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x06000204 RID: 516
		private delegate void set_chunkSize_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x06000206 RID: 518
		private delegate void get_chunkCullingBounds_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x06000208 RID: 520
		private delegate void set_chunkCullingBounds_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}

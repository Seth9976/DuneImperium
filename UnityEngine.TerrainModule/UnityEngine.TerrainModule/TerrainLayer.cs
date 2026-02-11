using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000015 RID: 21
	public sealed class TerrainLayer : Object
	{
		// Token: 0x0600017D RID: 381 RVA: 0x00003114 File Offset: 0x00001314
		public static void Internal_Create(TerrainLayer layer)
		{
			TerrainLayer.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(layer));
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600017E RID: 382 RVA: 0x0000619C File Offset: 0x0000439C
		// (set) Token: 0x0600017F RID: 383 RVA: 0x00003126 File Offset: 0x00001326
		public Texture2D diffuseTexture
		{
			get
			{
				IntPtr intPtr = TerrainLayer.get_diffuseTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				TerrainLayer.set_diffuseTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000180 RID: 384 RVA: 0x000061C8 File Offset: 0x000043C8
		// (set) Token: 0x06000181 RID: 385 RVA: 0x0000313E File Offset: 0x0000133E
		public Texture2D normalMapTexture
		{
			get
			{
				IntPtr intPtr = TerrainLayer.get_normalMapTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				TerrainLayer.set_normalMapTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000182 RID: 386 RVA: 0x000061F4 File Offset: 0x000043F4
		// (set) Token: 0x06000183 RID: 387 RVA: 0x00003156 File Offset: 0x00001356
		public Texture2D maskMapTexture
		{
			get
			{
				IntPtr intPtr = TerrainLayer.get_maskMapTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				TerrainLayer.set_maskMapTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00006220 File Offset: 0x00004420
		// (set) Token: 0x06000185 RID: 389 RVA: 0x0000316E File Offset: 0x0000136E
		public Vector2 tileSize
		{
			get
			{
				Vector2 vector;
				this.get_tileSize_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_tileSize_Injected(ref value);
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00006238 File Offset: 0x00004438
		// (set) Token: 0x06000187 RID: 391 RVA: 0x00003178 File Offset: 0x00001378
		public Vector2 tileOffset
		{
			get
			{
				Vector2 vector;
				this.get_tileOffset_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_tileOffset_Injected(ref value);
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00006250 File Offset: 0x00004450
		// (set) Token: 0x06000189 RID: 393 RVA: 0x00003182 File Offset: 0x00001382
		public Color specular
		{
			get
			{
				Color color;
				this.get_specular_Injected(out color);
				return color;
			}
			set
			{
				this.set_specular_Injected(ref value);
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600018A RID: 394 RVA: 0x0000318C File Offset: 0x0000138C
		// (set) Token: 0x0600018B RID: 395 RVA: 0x0000319E File Offset: 0x0000139E
		public float metallic
		{
			get
			{
				return TerrainLayer.get_metallicDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TerrainLayer.set_metallicDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600018C RID: 396 RVA: 0x000031B1 File Offset: 0x000013B1
		// (set) Token: 0x0600018D RID: 397 RVA: 0x000031C3 File Offset: 0x000013C3
		public float smoothness
		{
			get
			{
				return TerrainLayer.get_smoothnessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TerrainLayer.set_smoothnessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600018E RID: 398 RVA: 0x000031D6 File Offset: 0x000013D6
		// (set) Token: 0x0600018F RID: 399 RVA: 0x000031E8 File Offset: 0x000013E8
		public float normalScale
		{
			get
			{
				return TerrainLayer.get_normalScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TerrainLayer.set_normalScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00006268 File Offset: 0x00004468
		// (set) Token: 0x06000191 RID: 401 RVA: 0x000031FB File Offset: 0x000013FB
		public Vector4 diffuseRemapMin
		{
			get
			{
				Vector4 vector;
				this.get_diffuseRemapMin_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_diffuseRemapMin_Injected(ref value);
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00006280 File Offset: 0x00004480
		// (set) Token: 0x06000193 RID: 403 RVA: 0x00003205 File Offset: 0x00001405
		public Vector4 diffuseRemapMax
		{
			get
			{
				Vector4 vector;
				this.get_diffuseRemapMax_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_diffuseRemapMax_Injected(ref value);
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00006298 File Offset: 0x00004498
		// (set) Token: 0x06000195 RID: 405 RVA: 0x0000320F File Offset: 0x0000140F
		public Vector4 maskMapRemapMin
		{
			get
			{
				Vector4 vector;
				this.get_maskMapRemapMin_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_maskMapRemapMin_Injected(ref value);
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000196 RID: 406 RVA: 0x000062B0 File Offset: 0x000044B0
		// (set) Token: 0x06000197 RID: 407 RVA: 0x00003219 File Offset: 0x00001419
		public Vector4 maskMapRemapMax
		{
			get
			{
				Vector4 vector;
				this.get_maskMapRemapMax_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_maskMapRemapMax_Injected(ref value);
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00003223 File Offset: 0x00001423
		public void get_tileSize_Injected(out Vector2 ret)
		{
			TerrainLayer.get_tileSize_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00003236 File Offset: 0x00001436
		public void set_tileSize_Injected(ref Vector2 value)
		{
			TerrainLayer.set_tileSize_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00003249 File Offset: 0x00001449
		public void get_tileOffset_Injected(out Vector2 ret)
		{
			TerrainLayer.get_tileOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000325C File Offset: 0x0000145C
		public void set_tileOffset_Injected(ref Vector2 value)
		{
			TerrainLayer.set_tileOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000326F File Offset: 0x0000146F
		public void get_specular_Injected(out Color ret)
		{
			TerrainLayer.get_specular_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00003282 File Offset: 0x00001482
		public void set_specular_Injected(ref Color value)
		{
			TerrainLayer.set_specular_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00003295 File Offset: 0x00001495
		public void get_diffuseRemapMin_Injected(out Vector4 ret)
		{
			TerrainLayer.get_diffuseRemapMin_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000032A8 File Offset: 0x000014A8
		public void set_diffuseRemapMin_Injected(ref Vector4 value)
		{
			TerrainLayer.set_diffuseRemapMin_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000032BB File Offset: 0x000014BB
		public void get_diffuseRemapMax_Injected(out Vector4 ret)
		{
			TerrainLayer.get_diffuseRemapMax_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000032CE File Offset: 0x000014CE
		public void set_diffuseRemapMax_Injected(ref Vector4 value)
		{
			TerrainLayer.set_diffuseRemapMax_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000032E1 File Offset: 0x000014E1
		public void get_maskMapRemapMin_Injected(out Vector4 ret)
		{
			TerrainLayer.get_maskMapRemapMin_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x000032F4 File Offset: 0x000014F4
		public void set_maskMapRemapMin_Injected(ref Vector4 value)
		{
			TerrainLayer.set_maskMapRemapMin_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00003307 File Offset: 0x00001507
		public void get_maskMapRemapMax_Injected(out Vector4 ret)
		{
			TerrainLayer.get_maskMapRemapMax_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000331A File Offset: 0x0000151A
		public void set_maskMapRemapMax_Injected(ref Vector4 value)
		{
			TerrainLayer.set_maskMapRemapMax_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000101 RID: 257
		private static readonly TerrainLayer.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<TerrainLayer.Internal_CreateDelegate>("UnityEngine.TerrainLayer::Internal_Create");

		// Token: 0x04000102 RID: 258
		private static readonly TerrainLayer.get_diffuseTextureDelegate get_diffuseTextureDelegateField = IL2CPP.ResolveICall<TerrainLayer.get_diffuseTextureDelegate>("UnityEngine.TerrainLayer::get_diffuseTexture");

		// Token: 0x04000103 RID: 259
		private static readonly TerrainLayer.set_diffuseTextureDelegate set_diffuseTextureDelegateField = IL2CPP.ResolveICall<TerrainLayer.set_diffuseTextureDelegate>("UnityEngine.TerrainLayer::set_diffuseTexture");

		// Token: 0x04000104 RID: 260
		private static readonly TerrainLayer.get_normalMapTextureDelegate get_normalMapTextureDelegateField = IL2CPP.ResolveICall<TerrainLayer.get_normalMapTextureDelegate>("UnityEngine.TerrainLayer::get_normalMapTexture");

		// Token: 0x04000105 RID: 261
		private static readonly TerrainLayer.set_normalMapTextureDelegate set_normalMapTextureDelegateField = IL2CPP.ResolveICall<TerrainLayer.set_normalMapTextureDelegate>("UnityEngine.TerrainLayer::set_normalMapTexture");

		// Token: 0x04000106 RID: 262
		private static readonly TerrainLayer.get_maskMapTextureDelegate get_maskMapTextureDelegateField = IL2CPP.ResolveICall<TerrainLayer.get_maskMapTextureDelegate>("UnityEngine.TerrainLayer::get_maskMapTexture");

		// Token: 0x04000107 RID: 263
		private static readonly TerrainLayer.set_maskMapTextureDelegate set_maskMapTextureDelegateField = IL2CPP.ResolveICall<TerrainLayer.set_maskMapTextureDelegate>("UnityEngine.TerrainLayer::set_maskMapTexture");

		// Token: 0x04000108 RID: 264
		private static readonly TerrainLayer.get_metallicDelegate get_metallicDelegateField = IL2CPP.ResolveICall<TerrainLayer.get_metallicDelegate>("UnityEngine.TerrainLayer::get_metallic");

		// Token: 0x04000109 RID: 265
		private static readonly TerrainLayer.set_metallicDelegate set_metallicDelegateField = IL2CPP.ResolveICall<TerrainLayer.set_metallicDelegate>("UnityEngine.TerrainLayer::set_metallic");

		// Token: 0x0400010A RID: 266
		private static readonly TerrainLayer.get_smoothnessDelegate get_smoothnessDelegateField = IL2CPP.ResolveICall<TerrainLayer.get_smoothnessDelegate>("UnityEngine.TerrainLayer::get_smoothness");

		// Token: 0x0400010B RID: 267
		private static readonly TerrainLayer.set_smoothnessDelegate set_smoothnessDelegateField = IL2CPP.ResolveICall<TerrainLayer.set_smoothnessDelegate>("UnityEngine.TerrainLayer::set_smoothness");

		// Token: 0x0400010C RID: 268
		private static readonly TerrainLayer.get_normalScaleDelegate get_normalScaleDelegateField = IL2CPP.ResolveICall<TerrainLayer.get_normalScaleDelegate>("UnityEngine.TerrainLayer::get_normalScale");

		// Token: 0x0400010D RID: 269
		private static readonly TerrainLayer.set_normalScaleDelegate set_normalScaleDelegateField = IL2CPP.ResolveICall<TerrainLayer.set_normalScaleDelegate>("UnityEngine.TerrainLayer::set_normalScale");

		// Token: 0x0400010E RID: 270
		private static readonly TerrainLayer.get_tileSize_InjectedDelegate get_tileSize_InjectedDelegateField = IL2CPP.ResolveICall<TerrainLayer.get_tileSize_InjectedDelegate>("UnityEngine.TerrainLayer::get_tileSize_Injected");

		// Token: 0x0400010F RID: 271
		private static readonly TerrainLayer.set_tileSize_InjectedDelegate set_tileSize_InjectedDelegateField = IL2CPP.ResolveICall<TerrainLayer.set_tileSize_InjectedDelegate>("UnityEngine.TerrainLayer::set_tileSize_Injected");

		// Token: 0x04000110 RID: 272
		private static readonly TerrainLayer.get_tileOffset_InjectedDelegate get_tileOffset_InjectedDelegateField = IL2CPP.ResolveICall<TerrainLayer.get_tileOffset_InjectedDelegate>("UnityEngine.TerrainLayer::get_tileOffset_Injected");

		// Token: 0x04000111 RID: 273
		private static readonly TerrainLayer.set_tileOffset_InjectedDelegate set_tileOffset_InjectedDelegateField = IL2CPP.ResolveICall<TerrainLayer.set_tileOffset_InjectedDelegate>("UnityEngine.TerrainLayer::set_tileOffset_Injected");

		// Token: 0x04000112 RID: 274
		private static readonly TerrainLayer.get_specular_InjectedDelegate get_specular_InjectedDelegateField = IL2CPP.ResolveICall<TerrainLayer.get_specular_InjectedDelegate>("UnityEngine.TerrainLayer::get_specular_Injected");

		// Token: 0x04000113 RID: 275
		private static readonly TerrainLayer.set_specular_InjectedDelegate set_specular_InjectedDelegateField = IL2CPP.ResolveICall<TerrainLayer.set_specular_InjectedDelegate>("UnityEngine.TerrainLayer::set_specular_Injected");

		// Token: 0x04000114 RID: 276
		private static readonly TerrainLayer.get_diffuseRemapMin_InjectedDelegate get_diffuseRemapMin_InjectedDelegateField = IL2CPP.ResolveICall<TerrainLayer.get_diffuseRemapMin_InjectedDelegate>("UnityEngine.TerrainLayer::get_diffuseRemapMin_Injected");

		// Token: 0x04000115 RID: 277
		private static readonly TerrainLayer.set_diffuseRemapMin_InjectedDelegate set_diffuseRemapMin_InjectedDelegateField = IL2CPP.ResolveICall<TerrainLayer.set_diffuseRemapMin_InjectedDelegate>("UnityEngine.TerrainLayer::set_diffuseRemapMin_Injected");

		// Token: 0x04000116 RID: 278
		private static readonly TerrainLayer.get_diffuseRemapMax_InjectedDelegate get_diffuseRemapMax_InjectedDelegateField = IL2CPP.ResolveICall<TerrainLayer.get_diffuseRemapMax_InjectedDelegate>("UnityEngine.TerrainLayer::get_diffuseRemapMax_Injected");

		// Token: 0x04000117 RID: 279
		private static readonly TerrainLayer.set_diffuseRemapMax_InjectedDelegate set_diffuseRemapMax_InjectedDelegateField = IL2CPP.ResolveICall<TerrainLayer.set_diffuseRemapMax_InjectedDelegate>("UnityEngine.TerrainLayer::set_diffuseRemapMax_Injected");

		// Token: 0x04000118 RID: 280
		private static readonly TerrainLayer.get_maskMapRemapMin_InjectedDelegate get_maskMapRemapMin_InjectedDelegateField = IL2CPP.ResolveICall<TerrainLayer.get_maskMapRemapMin_InjectedDelegate>("UnityEngine.TerrainLayer::get_maskMapRemapMin_Injected");

		// Token: 0x04000119 RID: 281
		private static readonly TerrainLayer.set_maskMapRemapMin_InjectedDelegate set_maskMapRemapMin_InjectedDelegateField = IL2CPP.ResolveICall<TerrainLayer.set_maskMapRemapMin_InjectedDelegate>("UnityEngine.TerrainLayer::set_maskMapRemapMin_Injected");

		// Token: 0x0400011A RID: 282
		private static readonly TerrainLayer.get_maskMapRemapMax_InjectedDelegate get_maskMapRemapMax_InjectedDelegateField = IL2CPP.ResolveICall<TerrainLayer.get_maskMapRemapMax_InjectedDelegate>("UnityEngine.TerrainLayer::get_maskMapRemapMax_Injected");

		// Token: 0x0400011B RID: 283
		private static readonly TerrainLayer.set_maskMapRemapMax_InjectedDelegate set_maskMapRemapMax_InjectedDelegateField = IL2CPP.ResolveICall<TerrainLayer.set_maskMapRemapMax_InjectedDelegate>("UnityEngine.TerrainLayer::set_maskMapRemapMax_Injected");

		// Token: 0x020000C8 RID: 200
		// (Invoke) Token: 0x0600035A RID: 858
		private delegate void Internal_CreateDelegate(IntPtr layer);

		// Token: 0x020000C9 RID: 201
		// (Invoke) Token: 0x0600035C RID: 860
		private delegate IntPtr get_diffuseTextureDelegate(IntPtr @this);

		// Token: 0x020000CA RID: 202
		// (Invoke) Token: 0x0600035E RID: 862
		private delegate void set_diffuseTextureDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000CB RID: 203
		// (Invoke) Token: 0x06000360 RID: 864
		private delegate IntPtr get_normalMapTextureDelegate(IntPtr @this);

		// Token: 0x020000CC RID: 204
		// (Invoke) Token: 0x06000362 RID: 866
		private delegate void set_normalMapTextureDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000CD RID: 205
		// (Invoke) Token: 0x06000364 RID: 868
		private delegate IntPtr get_maskMapTextureDelegate(IntPtr @this);

		// Token: 0x020000CE RID: 206
		// (Invoke) Token: 0x06000366 RID: 870
		private delegate void set_maskMapTextureDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000CF RID: 207
		// (Invoke) Token: 0x06000368 RID: 872
		private delegate float get_metallicDelegate(IntPtr @this);

		// Token: 0x020000D0 RID: 208
		// (Invoke) Token: 0x0600036A RID: 874
		private delegate void set_metallicDelegate(IntPtr @this, float value);

		// Token: 0x020000D1 RID: 209
		// (Invoke) Token: 0x0600036C RID: 876
		private delegate float get_smoothnessDelegate(IntPtr @this);

		// Token: 0x020000D2 RID: 210
		// (Invoke) Token: 0x0600036E RID: 878
		private delegate void set_smoothnessDelegate(IntPtr @this, float value);

		// Token: 0x020000D3 RID: 211
		// (Invoke) Token: 0x06000370 RID: 880
		private delegate float get_normalScaleDelegate(IntPtr @this);

		// Token: 0x020000D4 RID: 212
		// (Invoke) Token: 0x06000372 RID: 882
		private delegate void set_normalScaleDelegate(IntPtr @this, float value);

		// Token: 0x020000D5 RID: 213
		// (Invoke) Token: 0x06000374 RID: 884
		private delegate void get_tileSize_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000D6 RID: 214
		// (Invoke) Token: 0x06000376 RID: 886
		private delegate void set_tileSize_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000D7 RID: 215
		// (Invoke) Token: 0x06000378 RID: 888
		private delegate void get_tileOffset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000D8 RID: 216
		// (Invoke) Token: 0x0600037A RID: 890
		private delegate void set_tileOffset_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000D9 RID: 217
		// (Invoke) Token: 0x0600037C RID: 892
		private delegate void get_specular_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000DA RID: 218
		// (Invoke) Token: 0x0600037E RID: 894
		private delegate void set_specular_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000DB RID: 219
		// (Invoke) Token: 0x06000380 RID: 896
		private delegate void get_diffuseRemapMin_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000DC RID: 220
		// (Invoke) Token: 0x06000382 RID: 898
		private delegate void set_diffuseRemapMin_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000DD RID: 221
		// (Invoke) Token: 0x06000384 RID: 900
		private delegate void get_diffuseRemapMax_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000DE RID: 222
		// (Invoke) Token: 0x06000386 RID: 902
		private delegate void set_diffuseRemapMax_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000DF RID: 223
		// (Invoke) Token: 0x06000388 RID: 904
		private delegate void get_maskMapRemapMin_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000E0 RID: 224
		// (Invoke) Token: 0x0600038A RID: 906
		private delegate void set_maskMapRemapMin_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000E1 RID: 225
		// (Invoke) Token: 0x0600038C RID: 908
		private delegate void get_maskMapRemapMax_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000E2 RID: 226
		// (Invoke) Token: 0x0600038E RID: 910
		private delegate void set_maskMapRemapMax_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}

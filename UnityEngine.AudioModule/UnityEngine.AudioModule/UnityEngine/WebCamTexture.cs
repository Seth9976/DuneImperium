using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000025 RID: 37
	public sealed class WebCamTexture : Texture
	{
		// Token: 0x060001E7 RID: 487 RVA: 0x00002FD5 File Offset: 0x000011D5
		public void Play()
		{
			WebCamTexture.PlayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002FE7 File Offset: 0x000011E7
		public void Pause()
		{
			WebCamTexture.PauseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00002FF9 File Offset: 0x000011F9
		public void Stop()
		{
			WebCamTexture.StopDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001EA RID: 490 RVA: 0x0000300B File Offset: 0x0000120B
		public bool isPlaying
		{
			get
			{
				return WebCamTexture.get_isPlayingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001EB RID: 491 RVA: 0x0000828C File Offset: 0x0000648C
		// (set) Token: 0x060001EC RID: 492 RVA: 0x0000301D File Offset: 0x0000121D
		public string deviceName
		{
			get
			{
				IntPtr intPtr = WebCamTexture.get_deviceNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				WebCamTexture.set_deviceNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001ED RID: 493 RVA: 0x00003035 File Offset: 0x00001235
		// (set) Token: 0x060001EE RID: 494 RVA: 0x00003047 File Offset: 0x00001247
		public float requestedFPS
		{
			get
			{
				return WebCamTexture.get_requestedFPSDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				WebCamTexture.set_requestedFPSDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001EF RID: 495 RVA: 0x0000305A File Offset: 0x0000125A
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x0000306C File Offset: 0x0000126C
		public int requestedWidth
		{
			get
			{
				return WebCamTexture.get_requestedWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				WebCamTexture.set_requestedWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x0000307F File Offset: 0x0000127F
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x00003091 File Offset: 0x00001291
		public int requestedHeight
		{
			get
			{
				return WebCamTexture.get_requestedHeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				WebCamTexture.set_requestedHeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x000030A4 File Offset: 0x000012A4
		public int videoRotationAngle
		{
			get
			{
				return WebCamTexture.get_videoRotationAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x000030B6 File Offset: 0x000012B6
		public bool videoVerticallyMirrored
		{
			get
			{
				return WebCamTexture.get_videoVerticallyMirroredDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x000030C8 File Offset: 0x000012C8
		public bool didUpdateThisFrame
		{
			get
			{
				return WebCamTexture.get_didUpdateThisFrameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x000082B0 File Offset: 0x000064B0
		public Color GetPixel(int x, int y)
		{
			Color color;
			this.GetPixel_Injected(x, y, out color);
			return color;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x000082C8 File Offset: 0x000064C8
		public Il2CppStructArray<Color> GetPixels()
		{
			return this.GetPixels(0, 0, this.width, this.height);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x000082F0 File Offset: 0x000064F0
		public Il2CppStructArray<Color> GetPixels(int x, int y, int blockWidth, int blockHeight)
		{
			IntPtr intPtr = WebCamTexture.GetPixelsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), x, y, blockWidth, blockHeight);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00008324 File Offset: 0x00006524
		public Il2CppStructArray<Color32> GetPixels32()
		{
			return this.GetPixels32(null);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00008340 File Offset: 0x00006540
		public Il2CppStructArray<Color32> GetPixels32(Il2CppStructArray<Color32> colors)
		{
			IntPtr intPtr = WebCamTexture.GetPixels32DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(colors));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(intPtr2) : null;
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001FB RID: 507 RVA: 0x00008374 File Offset: 0x00006574
		// (set) Token: 0x060001FC RID: 508 RVA: 0x000030DA File Offset: 0x000012DA
		public Nullable<Vector2> autoFocusPoint
		{
			get
			{
				return (this.internalAutoFocusPoint.x < 0f) ? null : new Nullable<Vector2>(this.internalAutoFocusPoint);
			}
			set
			{
				this.internalAutoFocusPoint = ((!value.HasValue) ? new Vector2(-1f, -1f) : value.Value);
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001FD RID: 509 RVA: 0x000083B0 File Offset: 0x000065B0
		// (set) Token: 0x060001FE RID: 510 RVA: 0x00003105 File Offset: 0x00001305
		public Vector2 internalAutoFocusPoint
		{
			get
			{
				Vector2 vector;
				this.get_internalAutoFocusPoint_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_internalAutoFocusPoint_Injected(ref value);
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001FF RID: 511 RVA: 0x0000310F File Offset: 0x0000130F
		public bool isDepth
		{
			get
			{
				return WebCamTexture.get_isDepthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00003121 File Offset: 0x00001321
		public static void Internal_CreateWebCamTexture(WebCamTexture self, string scriptingDevice, int requestedWidth, int requestedHeight, int maxFramerate)
		{
			WebCamTexture.Internal_CreateWebCamTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self), IL2CPP.ManagedStringToIl2Cpp(scriptingDevice), requestedWidth, requestedHeight, maxFramerate);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000313D File Offset: 0x0000133D
		public void GetPixel_Injected(int x, int y, out Color ret)
		{
			WebCamTexture.GetPixel_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), x, y, out ret);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00003152 File Offset: 0x00001352
		public void get_internalAutoFocusPoint_Injected(out Vector2 ret)
		{
			WebCamTexture.get_internalAutoFocusPoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00003165 File Offset: 0x00001365
		public void set_internalAutoFocusPoint_Injected(ref Vector2 value)
		{
			WebCamTexture.set_internalAutoFocusPoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x040001A8 RID: 424
		private static readonly WebCamTexture.PlayDelegate PlayDelegateField = IL2CPP.ResolveICall<WebCamTexture.PlayDelegate>("UnityEngine.WebCamTexture::Play");

		// Token: 0x040001A9 RID: 425
		private static readonly WebCamTexture.PauseDelegate PauseDelegateField = IL2CPP.ResolveICall<WebCamTexture.PauseDelegate>("UnityEngine.WebCamTexture::Pause");

		// Token: 0x040001AA RID: 426
		private static readonly WebCamTexture.StopDelegate StopDelegateField = IL2CPP.ResolveICall<WebCamTexture.StopDelegate>("UnityEngine.WebCamTexture::Stop");

		// Token: 0x040001AB RID: 427
		private static readonly WebCamTexture.get_isPlayingDelegate get_isPlayingDelegateField = IL2CPP.ResolveICall<WebCamTexture.get_isPlayingDelegate>("UnityEngine.WebCamTexture::get_isPlaying");

		// Token: 0x040001AC RID: 428
		private static readonly WebCamTexture.get_deviceNameDelegate get_deviceNameDelegateField = IL2CPP.ResolveICall<WebCamTexture.get_deviceNameDelegate>("UnityEngine.WebCamTexture::get_deviceName");

		// Token: 0x040001AD RID: 429
		private static readonly WebCamTexture.set_deviceNameDelegate set_deviceNameDelegateField = IL2CPP.ResolveICall<WebCamTexture.set_deviceNameDelegate>("UnityEngine.WebCamTexture::set_deviceName");

		// Token: 0x040001AE RID: 430
		private static readonly WebCamTexture.get_requestedFPSDelegate get_requestedFPSDelegateField = IL2CPP.ResolveICall<WebCamTexture.get_requestedFPSDelegate>("UnityEngine.WebCamTexture::get_requestedFPS");

		// Token: 0x040001AF RID: 431
		private static readonly WebCamTexture.set_requestedFPSDelegate set_requestedFPSDelegateField = IL2CPP.ResolveICall<WebCamTexture.set_requestedFPSDelegate>("UnityEngine.WebCamTexture::set_requestedFPS");

		// Token: 0x040001B0 RID: 432
		private static readonly WebCamTexture.get_requestedWidthDelegate get_requestedWidthDelegateField = IL2CPP.ResolveICall<WebCamTexture.get_requestedWidthDelegate>("UnityEngine.WebCamTexture::get_requestedWidth");

		// Token: 0x040001B1 RID: 433
		private static readonly WebCamTexture.set_requestedWidthDelegate set_requestedWidthDelegateField = IL2CPP.ResolveICall<WebCamTexture.set_requestedWidthDelegate>("UnityEngine.WebCamTexture::set_requestedWidth");

		// Token: 0x040001B2 RID: 434
		private static readonly WebCamTexture.get_requestedHeightDelegate get_requestedHeightDelegateField = IL2CPP.ResolveICall<WebCamTexture.get_requestedHeightDelegate>("UnityEngine.WebCamTexture::get_requestedHeight");

		// Token: 0x040001B3 RID: 435
		private static readonly WebCamTexture.set_requestedHeightDelegate set_requestedHeightDelegateField = IL2CPP.ResolveICall<WebCamTexture.set_requestedHeightDelegate>("UnityEngine.WebCamTexture::set_requestedHeight");

		// Token: 0x040001B4 RID: 436
		private static readonly WebCamTexture.get_videoRotationAngleDelegate get_videoRotationAngleDelegateField = IL2CPP.ResolveICall<WebCamTexture.get_videoRotationAngleDelegate>("UnityEngine.WebCamTexture::get_videoRotationAngle");

		// Token: 0x040001B5 RID: 437
		private static readonly WebCamTexture.get_videoVerticallyMirroredDelegate get_videoVerticallyMirroredDelegateField = IL2CPP.ResolveICall<WebCamTexture.get_videoVerticallyMirroredDelegate>("UnityEngine.WebCamTexture::get_videoVerticallyMirrored");

		// Token: 0x040001B6 RID: 438
		private static readonly WebCamTexture.get_didUpdateThisFrameDelegate get_didUpdateThisFrameDelegateField = IL2CPP.ResolveICall<WebCamTexture.get_didUpdateThisFrameDelegate>("UnityEngine.WebCamTexture::get_didUpdateThisFrame");

		// Token: 0x040001B7 RID: 439
		private static readonly WebCamTexture.GetPixelsDelegate GetPixelsDelegateField = IL2CPP.ResolveICall<WebCamTexture.GetPixelsDelegate>("UnityEngine.WebCamTexture::GetPixels");

		// Token: 0x040001B8 RID: 440
		private static readonly WebCamTexture.GetPixels32Delegate GetPixels32DelegateField = IL2CPP.ResolveICall<WebCamTexture.GetPixels32Delegate>("UnityEngine.WebCamTexture::GetPixels32");

		// Token: 0x040001B9 RID: 441
		private static readonly WebCamTexture.get_isDepthDelegate get_isDepthDelegateField = IL2CPP.ResolveICall<WebCamTexture.get_isDepthDelegate>("UnityEngine.WebCamTexture::get_isDepth");

		// Token: 0x040001BA RID: 442
		private static readonly WebCamTexture.Internal_CreateWebCamTextureDelegate Internal_CreateWebCamTextureDelegateField = IL2CPP.ResolveICall<WebCamTexture.Internal_CreateWebCamTextureDelegate>("UnityEngine.WebCamTexture::Internal_CreateWebCamTexture");

		// Token: 0x040001BB RID: 443
		private static readonly WebCamTexture.GetPixel_InjectedDelegate GetPixel_InjectedDelegateField = IL2CPP.ResolveICall<WebCamTexture.GetPixel_InjectedDelegate>("UnityEngine.WebCamTexture::GetPixel_Injected");

		// Token: 0x040001BC RID: 444
		private static readonly WebCamTexture.get_internalAutoFocusPoint_InjectedDelegate get_internalAutoFocusPoint_InjectedDelegateField = IL2CPP.ResolveICall<WebCamTexture.get_internalAutoFocusPoint_InjectedDelegate>("UnityEngine.WebCamTexture::get_internalAutoFocusPoint_Injected");

		// Token: 0x040001BD RID: 445
		private static readonly WebCamTexture.set_internalAutoFocusPoint_InjectedDelegate set_internalAutoFocusPoint_InjectedDelegateField = IL2CPP.ResolveICall<WebCamTexture.set_internalAutoFocusPoint_InjectedDelegate>("UnityEngine.WebCamTexture::set_internalAutoFocusPoint_Injected");

		// Token: 0x020000E2 RID: 226
		// (Invoke) Token: 0x06000391 RID: 913
		private delegate void PlayDelegate(IntPtr @this);

		// Token: 0x020000E3 RID: 227
		// (Invoke) Token: 0x06000393 RID: 915
		private delegate void PauseDelegate(IntPtr @this);

		// Token: 0x020000E4 RID: 228
		// (Invoke) Token: 0x06000395 RID: 917
		private delegate void StopDelegate(IntPtr @this);

		// Token: 0x020000E5 RID: 229
		// (Invoke) Token: 0x06000397 RID: 919
		private delegate bool get_isPlayingDelegate(IntPtr @this);

		// Token: 0x020000E6 RID: 230
		// (Invoke) Token: 0x06000399 RID: 921
		private delegate IntPtr get_deviceNameDelegate(IntPtr @this);

		// Token: 0x020000E7 RID: 231
		// (Invoke) Token: 0x0600039B RID: 923
		private delegate void set_deviceNameDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000E8 RID: 232
		// (Invoke) Token: 0x0600039D RID: 925
		private delegate float get_requestedFPSDelegate(IntPtr @this);

		// Token: 0x020000E9 RID: 233
		// (Invoke) Token: 0x0600039F RID: 927
		private delegate void set_requestedFPSDelegate(IntPtr @this, float value);

		// Token: 0x020000EA RID: 234
		// (Invoke) Token: 0x060003A1 RID: 929
		private delegate int get_requestedWidthDelegate(IntPtr @this);

		// Token: 0x020000EB RID: 235
		// (Invoke) Token: 0x060003A3 RID: 931
		private delegate void set_requestedWidthDelegate(IntPtr @this, int value);

		// Token: 0x020000EC RID: 236
		// (Invoke) Token: 0x060003A5 RID: 933
		private delegate int get_requestedHeightDelegate(IntPtr @this);

		// Token: 0x020000ED RID: 237
		// (Invoke) Token: 0x060003A7 RID: 935
		private delegate void set_requestedHeightDelegate(IntPtr @this, int value);

		// Token: 0x020000EE RID: 238
		// (Invoke) Token: 0x060003A9 RID: 937
		private delegate int get_videoRotationAngleDelegate(IntPtr @this);

		// Token: 0x020000EF RID: 239
		// (Invoke) Token: 0x060003AB RID: 939
		private delegate bool get_videoVerticallyMirroredDelegate(IntPtr @this);

		// Token: 0x020000F0 RID: 240
		// (Invoke) Token: 0x060003AD RID: 941
		private delegate bool get_didUpdateThisFrameDelegate(IntPtr @this);

		// Token: 0x020000F1 RID: 241
		// (Invoke) Token: 0x060003AF RID: 943
		private delegate IntPtr GetPixelsDelegate(IntPtr @this, int x, int y, int blockWidth, int blockHeight);

		// Token: 0x020000F2 RID: 242
		// (Invoke) Token: 0x060003B1 RID: 945
		private delegate IntPtr GetPixels32Delegate(IntPtr @this, IntPtr colors);

		// Token: 0x020000F3 RID: 243
		// (Invoke) Token: 0x060003B3 RID: 947
		private delegate bool get_isDepthDelegate(IntPtr @this);

		// Token: 0x020000F4 RID: 244
		// (Invoke) Token: 0x060003B5 RID: 949
		private delegate void Internal_CreateWebCamTextureDelegate(IntPtr self, IntPtr scriptingDevice, int requestedWidth, int requestedHeight, int maxFramerate);

		// Token: 0x020000F5 RID: 245
		// (Invoke) Token: 0x060003B7 RID: 951
		private delegate void GetPixel_InjectedDelegate(IntPtr @this, int x, int y, [Out] IntPtr ret);

		// Token: 0x020000F6 RID: 246
		// (Invoke) Token: 0x060003B9 RID: 953
		private delegate void get_internalAutoFocusPoint_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000F7 RID: 247
		// (Invoke) Token: 0x060003BB RID: 955
		private delegate void set_internalAutoFocusPoint_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}

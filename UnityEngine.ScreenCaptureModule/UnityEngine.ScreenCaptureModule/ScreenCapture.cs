using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public static class ScreenCapture : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020A4 File Offset: 0x000002A4
		// Note: this type is marked as 'beforefieldinit'.
		static ScreenCapture()
		{
			Il2CppClassPointerStore<ScreenCapture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.ScreenCaptureModule.dll", "UnityEngine", "ScreenCapture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenCapture>.NativeClassPtr);
			ScreenCapture.NativeMethodInfoPtr_CaptureScreenshotAsTexture_Public_Static_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenCapture>.NativeClassPtr, 100663297);
			ScreenCapture.NativeMethodInfoPtr_CaptureScreenshotAsTexture_Private_Static_Texture2D_Int32_StereoScreenCaptureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenCapture>.NativeClassPtr, 100663298);
			ScreenCapture.CaptureScreenshotIntoRenderTextureDelegateField = IL2CPP.ResolveICall<ScreenCapture.CaptureScreenshotIntoRenderTextureDelegate>("UnityEngine.ScreenCapture::CaptureScreenshotIntoRenderTexture");
			ScreenCapture.CaptureScreenshotDelegateField = IL2CPP.ResolveICall<ScreenCapture.CaptureScreenshotDelegate>("UnityEngine.ScreenCapture::CaptureScreenshot");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000211C File Offset: 0x0000031C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1273094, RefRangeEnd = 1273095, XrefRangeStart = 1273092, XrefRangeEnd = 1273094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Texture2D CaptureScreenshotAsTexture()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenCapture.NativeMethodInfoPtr_CaptureScreenshotAsTexture_Public_Static_Texture2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002150 File Offset: 0x00000350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273095, XrefRangeEnd = 1273097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Texture2D CaptureScreenshotAsTexture(int superSize, ScreenCapture.StereoScreenCaptureMode stereoScreenCaptureMode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref superSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stereoScreenCaptureMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenCapture.NativeMethodInfoPtr_CaptureScreenshotAsTexture_Private_Static_Texture2D_Int32_StereoScreenCaptureMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		public ScreenCapture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002059 File Offset: 0x00000259
		public static void CaptureScreenshot(string filename)
		{
			ScreenCapture.CaptureScreenshot(filename, 1, ScreenCapture.StereoScreenCaptureMode.LeftEye);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002065 File Offset: 0x00000265
		public static void CaptureScreenshot(string filename, int superSize)
		{
			ScreenCapture.CaptureScreenshot(filename, superSize, ScreenCapture.StereoScreenCaptureMode.LeftEye);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002071 File Offset: 0x00000271
		public static void CaptureScreenshot(string filename, ScreenCapture.StereoScreenCaptureMode stereoCaptureMode)
		{
			ScreenCapture.CaptureScreenshot(filename, 1, stereoCaptureMode);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000021A0 File Offset: 0x000003A0
		public static Texture2D CaptureScreenshotAsTexture(int superSize)
		{
			return ScreenCapture.CaptureScreenshotAsTexture(superSize, ScreenCapture.StereoScreenCaptureMode.LeftEye);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000021BC File Offset: 0x000003BC
		public static Texture2D CaptureScreenshotAsTexture(ScreenCapture.StereoScreenCaptureMode stereoCaptureMode)
		{
			return ScreenCapture.CaptureScreenshotAsTexture(1, stereoCaptureMode);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000207D File Offset: 0x0000027D
		public static void CaptureScreenshotIntoRenderTexture(RenderTexture renderTexture)
		{
			ScreenCapture.CaptureScreenshotIntoRenderTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtr(renderTexture));
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000208F File Offset: 0x0000028F
		public static void CaptureScreenshot(string filename, int superSize, ScreenCapture.StereoScreenCaptureMode CaptureMode)
		{
			ScreenCapture.CaptureScreenshotDelegateField(IL2CPP.ManagedStringToIl2Cpp(filename), superSize, CaptureMode);
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeMethodInfoPtr_CaptureScreenshotAsTexture_Public_Static_Texture2D_0;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_CaptureScreenshotAsTexture_Private_Static_Texture2D_Int32_StereoScreenCaptureMode_0;

		// Token: 0x04000003 RID: 3
		private static readonly ScreenCapture.CaptureScreenshotIntoRenderTextureDelegate CaptureScreenshotIntoRenderTextureDelegateField;

		// Token: 0x04000004 RID: 4
		private static readonly ScreenCapture.CaptureScreenshotDelegate CaptureScreenshotDelegateField;

		// Token: 0x02000003 RID: 3
		public enum StereoScreenCaptureMode
		{
			// Token: 0x04000006 RID: 6
			LeftEye = 1,
			// Token: 0x04000007 RID: 7
			RightEye,
			// Token: 0x04000008 RID: 8
			BothEyes
		}

		// Token: 0x02000004 RID: 4
		// (Invoke) Token: 0x0600000D RID: 13
		private delegate void CaptureScreenshotIntoRenderTextureDelegate(IntPtr renderTexture);

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x0600000F RID: 15
		private delegate void CaptureScreenshotDelegate(IntPtr filename, int superSize, ScreenCapture.StereoScreenCaptureMode CaptureMode);
	}
}

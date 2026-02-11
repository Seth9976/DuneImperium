using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Apple
{
	// Token: 0x02000377 RID: 887
	public class FrameCapture
	{
		// Token: 0x06002FB5 RID: 12213 RVA: 0x000135A4 File Offset: 0x000117A4
		public static bool IsDestinationSupportedImpl(FrameCaptureDestination dest)
		{
			return FrameCapture.IsDestinationSupportedImplDelegateField(dest);
		}

		// Token: 0x06002FB6 RID: 12214 RVA: 0x000135B1 File Offset: 0x000117B1
		public static void BeginCaptureImpl(FrameCaptureDestination dest, string path)
		{
			FrameCapture.BeginCaptureImplDelegateField(dest, IL2CPP.ManagedStringToIl2Cpp(path));
		}

		// Token: 0x06002FB7 RID: 12215 RVA: 0x000135C4 File Offset: 0x000117C4
		public static void EndCaptureImpl()
		{
			FrameCapture.EndCaptureImplDelegateField();
		}

		// Token: 0x06002FB8 RID: 12216 RVA: 0x000135D0 File Offset: 0x000117D0
		public static void CaptureNextFrameImpl(FrameCaptureDestination dest, string path)
		{
			FrameCapture.CaptureNextFrameImplDelegateField(dest, IL2CPP.ManagedStringToIl2Cpp(path));
		}

		// Token: 0x06002FB9 RID: 12217 RVA: 0x000B5F78 File Offset: 0x000B4178
		public static bool IsDestinationSupported(FrameCaptureDestination dest)
		{
			bool flag = dest != FrameCaptureDestination.DevTools && dest != FrameCaptureDestination.GPUTraceDocument;
			if (flag)
			{
				throw new ArgumentException("dest", "Argument dest has bad value (not one of FrameCaptureDestination enum values)");
			}
			return FrameCapture.IsDestinationSupportedImpl(dest);
		}

		// Token: 0x06002FBA RID: 12218 RVA: 0x000B5FB4 File Offset: 0x000B41B4
		public static void BeginCaptureToXcode()
		{
			bool flag = !FrameCapture.IsDestinationSupported(FrameCaptureDestination.DevTools);
			if (flag)
			{
				throw new InvalidOperationException("Frame Capture with DevTools is not supported.");
			}
			FrameCapture.BeginCaptureImpl(FrameCaptureDestination.DevTools, null);
		}

		// Token: 0x06002FBB RID: 12219 RVA: 0x000135E3 File Offset: 0x000117E3
		public static void BeginCaptureToFile(string path)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002FBC RID: 12220 RVA: 0x000135F0 File Offset: 0x000117F0
		public static void EndCapture()
		{
			FrameCapture.EndCaptureImpl();
		}

		// Token: 0x06002FBD RID: 12221 RVA: 0x000B5FE4 File Offset: 0x000B41E4
		public static void CaptureNextFrameToXcode()
		{
			bool flag = !FrameCapture.IsDestinationSupported(FrameCaptureDestination.DevTools);
			if (flag)
			{
				throw new InvalidOperationException("Frame Capture with DevTools is not supported.");
			}
			FrameCapture.CaptureNextFrameImpl(FrameCaptureDestination.DevTools, null);
		}

		// Token: 0x06002FBE RID: 12222 RVA: 0x000135F9 File Offset: 0x000117F9
		public static void CaptureNextFrameToFile(string path)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04002AB0 RID: 10928
		private static readonly FrameCapture.IsDestinationSupportedImplDelegate IsDestinationSupportedImplDelegateField = IL2CPP.ResolveICall<FrameCapture.IsDestinationSupportedImplDelegate>("UnityEngine.Apple.FrameCapture::IsDestinationSupportedImpl");

		// Token: 0x04002AB1 RID: 10929
		private static readonly FrameCapture.BeginCaptureImplDelegate BeginCaptureImplDelegateField = IL2CPP.ResolveICall<FrameCapture.BeginCaptureImplDelegate>("UnityEngine.Apple.FrameCapture::BeginCaptureImpl");

		// Token: 0x04002AB2 RID: 10930
		private static readonly FrameCapture.EndCaptureImplDelegate EndCaptureImplDelegateField = IL2CPP.ResolveICall<FrameCapture.EndCaptureImplDelegate>("UnityEngine.Apple.FrameCapture::EndCaptureImpl");

		// Token: 0x04002AB3 RID: 10931
		private static readonly FrameCapture.CaptureNextFrameImplDelegate CaptureNextFrameImplDelegateField = IL2CPP.ResolveICall<FrameCapture.CaptureNextFrameImplDelegate>("UnityEngine.Apple.FrameCapture::CaptureNextFrameImpl");

		// Token: 0x02000BD7 RID: 3031
		// (Invoke) Token: 0x0600409B RID: 16539
		private delegate bool IsDestinationSupportedImplDelegate(FrameCaptureDestination dest);

		// Token: 0x02000BD8 RID: 3032
		// (Invoke) Token: 0x0600409D RID: 16541
		private delegate void BeginCaptureImplDelegate(FrameCaptureDestination dest, IntPtr path);

		// Token: 0x02000BD9 RID: 3033
		// (Invoke) Token: 0x0600409F RID: 16543
		private delegate void EndCaptureImplDelegate();

		// Token: 0x02000BDA RID: 3034
		// (Invoke) Token: 0x060040A1 RID: 16545
		private delegate void CaptureNextFrameImplDelegate(FrameCaptureDestination dest, IntPtr path);
	}
}

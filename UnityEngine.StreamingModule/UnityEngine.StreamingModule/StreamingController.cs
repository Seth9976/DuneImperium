using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public class StreamingController : Behaviour
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000003 RID: 3 RVA: 0x00002062 File Offset: 0x00000262
		public float streamingMipmapBias
		{
			get
			{
				return StreamingController.get_streamingMipmapBiasDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				StreamingController.set_streamingMipmapBiasDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002075 File Offset: 0x00000275
		public void SetPreloading([Optional] float timeoutSeconds, [Optional] bool activateCameraOnTimeout, [Optional] Camera disableCameraCuttingFrom)
		{
			StreamingController.SetPreloadingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), timeoutSeconds, activateCameraOnTimeout, IL2CPP.Il2CppObjectBaseToPtr(disableCameraCuttingFrom));
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000208F File Offset: 0x0000028F
		public void CancelPreloading()
		{
			StreamingController.CancelPreloadingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020A1 File Offset: 0x000002A1
		public bool IsPreloading()
		{
			return StreamingController.IsPreloadingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x04000001 RID: 1
		private static readonly StreamingController.get_streamingMipmapBiasDelegate get_streamingMipmapBiasDelegateField = IL2CPP.ResolveICall<StreamingController.get_streamingMipmapBiasDelegate>("UnityEngine.StreamingController::get_streamingMipmapBias");

		// Token: 0x04000002 RID: 2
		private static readonly StreamingController.set_streamingMipmapBiasDelegate set_streamingMipmapBiasDelegateField = IL2CPP.ResolveICall<StreamingController.set_streamingMipmapBiasDelegate>("UnityEngine.StreamingController::set_streamingMipmapBias");

		// Token: 0x04000003 RID: 3
		private static readonly StreamingController.SetPreloadingDelegate SetPreloadingDelegateField = IL2CPP.ResolveICall<StreamingController.SetPreloadingDelegate>("UnityEngine.StreamingController::SetPreloading");

		// Token: 0x04000004 RID: 4
		private static readonly StreamingController.CancelPreloadingDelegate CancelPreloadingDelegateField = IL2CPP.ResolveICall<StreamingController.CancelPreloadingDelegate>("UnityEngine.StreamingController::CancelPreloading");

		// Token: 0x04000005 RID: 5
		private static readonly StreamingController.IsPreloadingDelegate IsPreloadingDelegateField = IL2CPP.ResolveICall<StreamingController.IsPreloadingDelegate>("UnityEngine.StreamingController::IsPreloading");

		// Token: 0x02000003 RID: 3
		// (Invoke) Token: 0x06000008 RID: 8
		private delegate float get_streamingMipmapBiasDelegate(IntPtr @this);

		// Token: 0x02000004 RID: 4
		// (Invoke) Token: 0x0600000A RID: 10
		private delegate void set_streamingMipmapBiasDelegate(IntPtr @this, float value);

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x0600000C RID: 12
		private delegate void SetPreloadingDelegate(IntPtr @this, float timeoutSeconds, bool activateCameraOnTimeout, IntPtr disableCameraCuttingFrom);

		// Token: 0x02000006 RID: 6
		// (Invoke) Token: 0x0600000E RID: 14
		private delegate void CancelPreloadingDelegate(IntPtr @this);

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x06000010 RID: 16
		private delegate bool IsPreloadingDelegate(IntPtr @this);
	}
}

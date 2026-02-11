using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.ResourceManagement.AsyncOperations
{
	// Token: 0x02000053 RID: 83
	[StructLayout(2)]
	public struct DownloadStatus
	{
		// Token: 0x060004D0 RID: 1232 RVA: 0x000183D0 File Offset: 0x000165D0
		// Note: this type is marked as 'beforefieldinit'.
		static DownloadStatus()
		{
			Il2CppClassPointerStore<DownloadStatus>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.AsyncOperations", "DownloadStatus");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DownloadStatus>.NativeClassPtr);
			DownloadStatus.NativeFieldInfoPtr_TotalBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadStatus>.NativeClassPtr, "TotalBytes");
			DownloadStatus.NativeFieldInfoPtr_DownloadedBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadStatus>.NativeClassPtr, "DownloadedBytes");
			DownloadStatus.NativeFieldInfoPtr_IsDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadStatus>.NativeClassPtr, "IsDone");
			DownloadStatus.NativeMethodInfoPtr_get_Percent_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadStatus>.NativeClassPtr, 100664132);
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x00018450 File Offset: 0x00016650
		public unsafe float Percent
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadStatus.NativeMethodInfoPtr_get_Percent_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00003C06 File Offset: 0x00001E06
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DownloadStatus>.NativeClassPtr, ref this));
		}

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeFieldInfoPtr_TotalBytes;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeFieldInfoPtr_DownloadedBytes;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeFieldInfoPtr_IsDone;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeMethodInfoPtr_get_Percent_Public_get_Single_0;

		// Token: 0x04000374 RID: 884
		[FieldOffset(0)]
		public long TotalBytes;

		// Token: 0x04000375 RID: 885
		[FieldOffset(8)]
		public long DownloadedBytes;

		// Token: 0x04000376 RID: 886
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool IsDone;
	}
}

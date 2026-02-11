using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001F9 RID: 505
	[StructLayout(2)]
	public struct DownloadProgress
	{
		// Token: 0x06001958 RID: 6488 RVA: 0x0007AF68 File Offset: 0x00079168
		// Note: this type is marked as 'beforefieldinit'.
		static DownloadProgress()
		{
			Il2CppClassPointerStore<DownloadProgress>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "DownloadProgress");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DownloadProgress>.NativeClassPtr);
			DownloadProgress.NativeFieldInfoPtr_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadProgress>.NativeClassPtr, "Active");
			DownloadProgress.NativeFieldInfoPtr_BytesDownloaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadProgress>.NativeClassPtr, "BytesDownloaded");
			DownloadProgress.NativeFieldInfoPtr_BytesTotal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadProgress>.NativeClassPtr, "BytesTotal");
			DownloadProgress.NativeMethodInfoPtr_get_BytesRemaining_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadProgress>.NativeClassPtr, 100667921);
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06001959 RID: 6489 RVA: 0x0007AFE8 File Offset: 0x000791E8
		public unsafe ulong BytesRemaining
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadProgress.NativeMethodInfoPtr_get_BytesRemaining_Public_get_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x00008383 File Offset: 0x00006583
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DownloadProgress>.NativeClassPtr, ref this));
		}

		// Token: 0x04001E92 RID: 7826
		private static readonly IntPtr NativeFieldInfoPtr_Active;

		// Token: 0x04001E93 RID: 7827
		private static readonly IntPtr NativeFieldInfoPtr_BytesDownloaded;

		// Token: 0x04001E94 RID: 7828
		private static readonly IntPtr NativeFieldInfoPtr_BytesTotal;

		// Token: 0x04001E95 RID: 7829
		private static readonly IntPtr NativeMethodInfoPtr_get_BytesRemaining_Public_get_UInt64_0;

		// Token: 0x04001E96 RID: 7830
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool Active;

		// Token: 0x04001E97 RID: 7831
		[FieldOffset(8)]
		public ulong BytesDownloaded;

		// Token: 0x04001E98 RID: 7832
		[FieldOffset(16)]
		public ulong BytesTotal;
	}
}

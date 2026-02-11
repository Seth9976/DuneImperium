using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Jobs;
using UnityEngine;

namespace Unity.IO.Archive
{
	// Token: 0x02000032 RID: 50
	public static class ArchiveFileInterface : global::Il2CppSystem.Object
	{
		// Token: 0x060001CB RID: 459 RVA: 0x0001AB84 File Offset: 0x00018D84
		// Note: this type is marked as 'beforefieldinit'.
		static ArchiveFileInterface()
		{
			Il2CppClassPointerStore<ArchiveFileInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.Archive", "ArchiveFileInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchiveFileInterface>.NativeClassPtr);
			ArchiveFileInterface.Archive_GetStatus_InjectedDelegateField = IL2CPP.ResolveICall<ArchiveFileInterface.Archive_GetStatus_InjectedDelegate>("Unity.IO.Archive.ArchiveFileInterface::Archive_GetStatus_Injected");
			ArchiveFileInterface.Archive_GetJobHandle_InjectedDelegateField = IL2CPP.ResolveICall<ArchiveFileInterface.Archive_GetJobHandle_InjectedDelegate>("Unity.IO.Archive.ArchiveFileInterface::Archive_GetJobHandle_Injected");
			ArchiveFileInterface.Archive_IsValid_InjectedDelegateField = IL2CPP.ResolveICall<ArchiveFileInterface.Archive_IsValid_InjectedDelegate>("Unity.IO.Archive.ArchiveFileInterface::Archive_IsValid_Injected");
			ArchiveFileInterface.Archive_UnmountAsync_InjectedDelegateField = IL2CPP.ResolveICall<ArchiveFileInterface.Archive_UnmountAsync_InjectedDelegate>("Unity.IO.Archive.ArchiveFileInterface::Archive_UnmountAsync_Injected");
			ArchiveFileInterface.Archive_GetMountPath_InjectedDelegateField = IL2CPP.ResolveICall<ArchiveFileInterface.Archive_GetMountPath_InjectedDelegate>("Unity.IO.Archive.ArchiveFileInterface::Archive_GetMountPath_Injected");
			ArchiveFileInterface.Archive_GetCompression_InjectedDelegateField = IL2CPP.ResolveICall<ArchiveFileInterface.Archive_GetCompression_InjectedDelegate>("Unity.IO.Archive.ArchiveFileInterface::Archive_GetCompression_Injected");
			ArchiveFileInterface.Archive_IsStreamed_InjectedDelegateField = IL2CPP.ResolveICall<ArchiveFileInterface.Archive_IsStreamed_InjectedDelegate>("Unity.IO.Archive.ArchiveFileInterface::Archive_IsStreamed_Injected");
			ArchiveFileInterface.Archive_GetFileInfo_InjectedDelegateField = IL2CPP.ResolveICall<ArchiveFileInterface.Archive_GetFileInfo_InjectedDelegate>("Unity.IO.Archive.ArchiveFileInterface::Archive_GetFileInfo_Injected");
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002F35 File Offset: 0x00001135
		public ArchiveFileInterface(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002F3E File Offset: 0x0000113E
		public static ArchiveStatus Archive_GetStatus(ArchiveHandle handle)
		{
			return ArchiveFileInterface.Archive_GetStatus_Injected(ref handle);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0001AC2C File Offset: 0x00018E2C
		public static Unity.Jobs.JobHandle Archive_GetJobHandle(ArchiveHandle handle)
		{
			Unity.Jobs.JobHandle jobHandle;
			ArchiveFileInterface.Archive_GetJobHandle_Injected(ref handle, out jobHandle);
			return jobHandle;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00002F47 File Offset: 0x00001147
		public static bool Archive_IsValid(ArchiveHandle handle)
		{
			return ArchiveFileInterface.Archive_IsValid_Injected(ref handle);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0001AC44 File Offset: 0x00018E44
		public static Unity.Jobs.JobHandle Archive_UnmountAsync(ArchiveHandle handle)
		{
			Unity.Jobs.JobHandle jobHandle;
			ArchiveFileInterface.Archive_UnmountAsync_Injected(ref handle, out jobHandle);
			return jobHandle;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00002F50 File Offset: 0x00001150
		public static string Archive_GetMountPath(ArchiveHandle handle)
		{
			return ArchiveFileInterface.Archive_GetMountPath_Injected(ref handle);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00002F59 File Offset: 0x00001159
		public static global::UnityEngine.CompressionType Archive_GetCompression(ArchiveHandle handle)
		{
			return ArchiveFileInterface.Archive_GetCompression_Injected(ref handle);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002F62 File Offset: 0x00001162
		public static bool Archive_IsStreamed(ArchiveHandle handle)
		{
			return ArchiveFileInterface.Archive_IsStreamed_Injected(ref handle);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00002F6B File Offset: 0x0000116B
		public static Il2CppReferenceArray<ArchiveFileInfo> Archive_GetFileInfo(ArchiveHandle handle)
		{
			return ArchiveFileInterface.Archive_GetFileInfo_Injected(ref handle);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002F74 File Offset: 0x00001174
		public static ArchiveStatus Archive_GetStatus_Injected(ref ArchiveHandle handle)
		{
			return ArchiveFileInterface.Archive_GetStatus_InjectedDelegateField(ref handle);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002F81 File Offset: 0x00001181
		public static void Archive_GetJobHandle_Injected(ref ArchiveHandle handle, out Unity.Jobs.JobHandle ret)
		{
			ArchiveFileInterface.Archive_GetJobHandle_InjectedDelegateField(ref handle, out ret);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002F8F File Offset: 0x0000118F
		public static bool Archive_IsValid_Injected(ref ArchiveHandle handle)
		{
			return ArchiveFileInterface.Archive_IsValid_InjectedDelegateField(ref handle);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002F9C File Offset: 0x0000119C
		public static void Archive_UnmountAsync_Injected(ref ArchiveHandle handle, out Unity.Jobs.JobHandle ret)
		{
			ArchiveFileInterface.Archive_UnmountAsync_InjectedDelegateField(ref handle, out ret);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0001AC5C File Offset: 0x00018E5C
		public static string Archive_GetMountPath_Injected(ref ArchiveHandle handle)
		{
			IntPtr intPtr = ArchiveFileInterface.Archive_GetMountPath_InjectedDelegateField(ref handle);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002FAA File Offset: 0x000011AA
		public static global::UnityEngine.CompressionType Archive_GetCompression_Injected(ref ArchiveHandle handle)
		{
			return ArchiveFileInterface.Archive_GetCompression_InjectedDelegateField(ref handle);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00002FB7 File Offset: 0x000011B7
		public static bool Archive_IsStreamed_Injected(ref ArchiveHandle handle)
		{
			return ArchiveFileInterface.Archive_IsStreamed_InjectedDelegateField(ref handle);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0001AC7C File Offset: 0x00018E7C
		public static Il2CppReferenceArray<ArchiveFileInfo> Archive_GetFileInfo_Injected(ref ArchiveHandle handle)
		{
			IntPtr intPtr = ArchiveFileInterface.Archive_GetFileInfo_InjectedDelegateField(ref handle);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ArchiveFileInfo>>(intPtr2) : null;
		}

		// Token: 0x0400017A RID: 378
		private static readonly ArchiveFileInterface.Archive_GetStatus_InjectedDelegate Archive_GetStatus_InjectedDelegateField;

		// Token: 0x0400017B RID: 379
		private static readonly ArchiveFileInterface.Archive_GetJobHandle_InjectedDelegate Archive_GetJobHandle_InjectedDelegateField;

		// Token: 0x0400017C RID: 380
		private static readonly ArchiveFileInterface.Archive_IsValid_InjectedDelegate Archive_IsValid_InjectedDelegateField;

		// Token: 0x0400017D RID: 381
		private static readonly ArchiveFileInterface.Archive_UnmountAsync_InjectedDelegate Archive_UnmountAsync_InjectedDelegateField;

		// Token: 0x0400017E RID: 382
		private static readonly ArchiveFileInterface.Archive_GetMountPath_InjectedDelegate Archive_GetMountPath_InjectedDelegateField;

		// Token: 0x0400017F RID: 383
		private static readonly ArchiveFileInterface.Archive_GetCompression_InjectedDelegate Archive_GetCompression_InjectedDelegateField;

		// Token: 0x04000180 RID: 384
		private static readonly ArchiveFileInterface.Archive_IsStreamed_InjectedDelegate Archive_IsStreamed_InjectedDelegateField;

		// Token: 0x04000181 RID: 385
		private static readonly ArchiveFileInterface.Archive_GetFileInfo_InjectedDelegate Archive_GetFileInfo_InjectedDelegateField;

		// Token: 0x020003B9 RID: 953
		// (Invoke) Token: 0x0600304D RID: 12365
		private delegate ArchiveStatus Archive_GetStatus_InjectedDelegate(IntPtr handle);

		// Token: 0x020003BA RID: 954
		// (Invoke) Token: 0x0600304F RID: 12367
		private delegate void Archive_GetJobHandle_InjectedDelegate(IntPtr handle, [Out] IntPtr ret);

		// Token: 0x020003BB RID: 955
		// (Invoke) Token: 0x06003051 RID: 12369
		private delegate bool Archive_IsValid_InjectedDelegate(IntPtr handle);

		// Token: 0x020003BC RID: 956
		// (Invoke) Token: 0x06003053 RID: 12371
		private delegate void Archive_UnmountAsync_InjectedDelegate(IntPtr handle, [Out] IntPtr ret);

		// Token: 0x020003BD RID: 957
		// (Invoke) Token: 0x06003055 RID: 12373
		private delegate IntPtr Archive_GetMountPath_InjectedDelegate(IntPtr handle);

		// Token: 0x020003BE RID: 958
		// (Invoke) Token: 0x06003057 RID: 12375
		private delegate global::UnityEngine.CompressionType Archive_GetCompression_InjectedDelegate(IntPtr handle);

		// Token: 0x020003BF RID: 959
		// (Invoke) Token: 0x06003059 RID: 12377
		private delegate bool Archive_IsStreamed_InjectedDelegate(IntPtr handle);

		// Token: 0x020003C0 RID: 960
		// (Invoke) Token: 0x0600305B RID: 12379
		private delegate IntPtr Archive_GetFileInfo_InjectedDelegate(IntPtr handle);
	}
}

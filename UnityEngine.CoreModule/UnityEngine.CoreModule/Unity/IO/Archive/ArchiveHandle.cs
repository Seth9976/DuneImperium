using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Unity.Jobs;
using UnityEngine;

namespace Unity.IO.Archive
{
	// Token: 0x02000031 RID: 49
	[StructLayout(2)]
	public struct ArchiveHandle
	{
		// Token: 0x060001C1 RID: 449 RVA: 0x00002EEA File Offset: 0x000010EA
		// Note: this type is marked as 'beforefieldinit'.
		static ArchiveHandle()
		{
			Il2CppClassPointerStore<ArchiveHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.Archive", "ArchiveHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchiveHandle>.NativeClassPtr);
			ArchiveHandle.NativeFieldInfoPtr_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchiveHandle>.NativeClassPtr, "Handle");
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002F23 File Offset: 0x00001123
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ArchiveHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x0001AA5C File Offset: 0x00018C5C
		public ArchiveStatus Status
		{
			get
			{
				this.ThrowIfInvalid();
				return ArchiveFileInterface.Archive_GetStatus(this);
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x0001AA80 File Offset: 0x00018C80
		public Unity.Jobs.JobHandle JobHandle
		{
			get
			{
				this.ThrowIfInvalid();
				return ArchiveFileInterface.Archive_GetJobHandle(this);
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0001AAA4 File Offset: 0x00018CA4
		public Unity.Jobs.JobHandle Unmount()
		{
			this.ThrowIfInvalid();
			return ArchiveFileInterface.Archive_UnmountAsync(this);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0001AAC8 File Offset: 0x00018CC8
		public void ThrowIfInvalid()
		{
			bool flag = !ArchiveFileInterface.Archive_IsValid(this);
			if (flag)
			{
				throw new InvalidOperationException("The archive has already been unmounted.");
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0001AAF4 File Offset: 0x00018CF4
		public string GetMountPath()
		{
			this.ThrowIfInvalid();
			return ArchiveFileInterface.Archive_GetMountPath(this);
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x0001AB18 File Offset: 0x00018D18
		public global::UnityEngine.CompressionType Compression
		{
			get
			{
				this.ThrowIfInvalid();
				return ArchiveFileInterface.Archive_GetCompression(this);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x0001AB3C File Offset: 0x00018D3C
		public bool IsStreamed
		{
			get
			{
				this.ThrowIfInvalid();
				return ArchiveFileInterface.Archive_IsStreamed(this);
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0001AB60 File Offset: 0x00018D60
		public Il2CppReferenceArray<ArchiveFileInfo> GetFileInfo()
		{
			this.ThrowIfInvalid();
			return ArchiveFileInterface.Archive_GetFileInfo(this);
		}

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeFieldInfoPtr_Handle;

		// Token: 0x04000179 RID: 377
		[FieldOffset(0)]
		public ulong Handle;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.IO
{
	// Token: 0x02000549 RID: 1353
	[StructLayout(2)]
	public struct MonoIOStat
	{
		// Token: 0x06005370 RID: 21360 RVA: 0x00184B2C File Offset: 0x00182D2C
		// Note: this type is marked as 'beforefieldinit'.
		static MonoIOStat()
		{
			Il2CppClassPointerStore<MonoIOStat>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "MonoIOStat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoIOStat>.NativeClassPtr);
			MonoIOStat.NativeFieldInfoPtr_fileAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoIOStat>.NativeClassPtr, "fileAttributes");
			MonoIOStat.NativeFieldInfoPtr_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoIOStat>.NativeClassPtr, "Length");
			MonoIOStat.NativeFieldInfoPtr_CreationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoIOStat>.NativeClassPtr, "CreationTime");
			MonoIOStat.NativeFieldInfoPtr_LastAccessTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoIOStat>.NativeClassPtr, "LastAccessTime");
			MonoIOStat.NativeFieldInfoPtr_LastWriteTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoIOStat>.NativeClassPtr, "LastWriteTime");
		}

		// Token: 0x06005371 RID: 21361 RVA: 0x0001D93A File Offset: 0x0001BB3A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MonoIOStat>.NativeClassPtr, ref this));
		}

		// Token: 0x04004443 RID: 17475
		private static readonly IntPtr NativeFieldInfoPtr_fileAttributes;

		// Token: 0x04004444 RID: 17476
		private static readonly IntPtr NativeFieldInfoPtr_Length;

		// Token: 0x04004445 RID: 17477
		private static readonly IntPtr NativeFieldInfoPtr_CreationTime;

		// Token: 0x04004446 RID: 17478
		private static readonly IntPtr NativeFieldInfoPtr_LastAccessTime;

		// Token: 0x04004447 RID: 17479
		private static readonly IntPtr NativeFieldInfoPtr_LastWriteTime;

		// Token: 0x04004448 RID: 17480
		[FieldOffset(0)]
		public FileAttributes fileAttributes;

		// Token: 0x04004449 RID: 17481
		[FieldOffset(8)]
		public long Length;

		// Token: 0x0400444A RID: 17482
		[FieldOffset(16)]
		public long CreationTime;

		// Token: 0x0400444B RID: 17483
		[FieldOffset(24)]
		public long LastAccessTime;

		// Token: 0x0400444C RID: 17484
		[FieldOffset(32)]
		public long LastWriteTime;
	}
}

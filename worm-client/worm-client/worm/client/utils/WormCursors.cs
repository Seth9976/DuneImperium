using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace worm.client.utils
{
	// Token: 0x02000293 RID: 659
	public static class WormCursors : Object
	{
		// Token: 0x06001AAE RID: 6830 RVA: 0x0006A548 File Offset: 0x00068748
		// Note: this type is marked as 'beforefieldinit'.
		static WormCursors()
		{
			Il2CppClassPointerStore<WormCursors>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.client.utils", "WormCursors");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormCursors>.NativeClassPtr);
			WormCursors.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCursors>.NativeClassPtr, "Default");
			WormCursors.NativeFieldInfoPtr_NoUndo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCursors>.NativeClassPtr, "NoUndo");
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x0000F81D File Offset: 0x0000DA1D
		public WormCursors(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06001AB0 RID: 6832 RVA: 0x0006A5A0 File Offset: 0x000687A0
		// (set) Token: 0x06001AB1 RID: 6833 RVA: 0x0000F826 File Offset: 0x0000DA26
		public unsafe static string Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormCursors.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormCursors.NativeFieldInfoPtr_Default, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06001AB2 RID: 6834 RVA: 0x0006A5C0 File Offset: 0x000687C0
		// (set) Token: 0x06001AB3 RID: 6835 RVA: 0x0000F838 File Offset: 0x0000DA38
		public unsafe static string NoUndo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormCursors.NativeFieldInfoPtr_NoUndo, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormCursors.NativeFieldInfoPtr_NoUndo, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000F6C RID: 3948
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x04000F6D RID: 3949
		private static readonly IntPtr NativeFieldInfoPtr_NoUndo;
	}
}

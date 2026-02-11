using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200020C RID: 524
	[StructLayout(2)]
	public struct Ugc
	{
		// Token: 0x06001A94 RID: 6804 RVA: 0x00008AEA File Offset: 0x00006CEA
		// Note: this type is marked as 'beforefieldinit'.
		static Ugc()
		{
			Il2CppClassPointerStore<Ugc>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "Ugc");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ugc>.NativeClassPtr);
			Ugc.NativeFieldInfoPtr_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ugc>.NativeClassPtr, "Handle");
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x00008B23 File Offset: 0x00006D23
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Ugc>.NativeClassPtr, ref this));
		}

		// Token: 0x04001F93 RID: 8083
		private static readonly IntPtr NativeFieldInfoPtr_Handle;

		// Token: 0x04001F94 RID: 8084
		[FieldOffset(0)]
		public UGCHandle_t Handle;
	}
}

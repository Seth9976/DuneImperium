using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal.LibTessDotNet
{
	// Token: 0x0200010D RID: 269
	[StructLayout(2)]
	public struct PQHandle
	{
		// Token: 0x06001675 RID: 5749 RVA: 0x0006060C File Offset: 0x0005E80C
		// Note: this type is marked as 'beforefieldinit'.
		static PQHandle()
		{
			Il2CppClassPointerStore<PQHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.LibTessDotNet", "PQHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PQHandle>.NativeClassPtr);
			PQHandle.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PQHandle>.NativeClassPtr, "Invalid");
			PQHandle.NativeFieldInfoPtr__handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PQHandle>.NativeClassPtr, "_handle");
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x0000CF6E File Offset: 0x0000B16E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PQHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06001677 RID: 5751 RVA: 0x00060664 File Offset: 0x0005E864
		// (set) Token: 0x06001678 RID: 5752 RVA: 0x0000CF80 File Offset: 0x0000B180
		public unsafe static int Invalid
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PQHandle.NativeFieldInfoPtr_Invalid, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PQHandle.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x04001057 RID: 4183
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x04001058 RID: 4184
		private static readonly IntPtr NativeFieldInfoPtr__handle;

		// Token: 0x04001059 RID: 4185
		[FieldOffset(0)]
		public int _handle;
	}
}

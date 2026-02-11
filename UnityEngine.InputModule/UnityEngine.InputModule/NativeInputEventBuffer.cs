using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngineInternal.Input
{
	// Token: 0x02000003 RID: 3
	[StructLayout(2)]
	public struct NativeInputEventBuffer
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002264 File Offset: 0x00000464
		// Note: this type is marked as 'beforefieldinit'.
		static NativeInputEventBuffer()
		{
			Il2CppClassPointerStore<NativeInputEventBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputModule.dll", "UnityEngineInternal.Input", "NativeInputEventBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeInputEventBuffer>.NativeClassPtr);
			NativeInputEventBuffer.NativeFieldInfoPtr_eventBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputEventBuffer>.NativeClassPtr, "eventBuffer");
			NativeInputEventBuffer.NativeFieldInfoPtr_eventCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputEventBuffer>.NativeClassPtr, "eventCount");
			NativeInputEventBuffer.NativeFieldInfoPtr_sizeInBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputEventBuffer>.NativeClassPtr, "sizeInBytes");
			NativeInputEventBuffer.NativeFieldInfoPtr_capacityInBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputEventBuffer>.NativeClassPtr, "capacityInBytes");
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002059 File Offset: 0x00000259
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeInputEventBuffer>.NativeClassPtr, ref this));
		}

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_eventBuffer;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeFieldInfoPtr_eventCount;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeFieldInfoPtr_sizeInBytes;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeFieldInfoPtr_capacityInBytes;

		// Token: 0x04000007 RID: 7
		[FieldOffset(0)]
		public IntPtr eventBuffer;

		// Token: 0x04000008 RID: 8
		[FieldOffset(8)]
		public int eventCount;

		// Token: 0x04000009 RID: 9
		[FieldOffset(12)]
		public int sizeInBytes;

		// Token: 0x0400000A RID: 10
		[FieldOffset(16)]
		public int capacityInBytes;

		// Token: 0x0400000B RID: 11
		public const int structSize = 20;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000222 RID: 546
	[StructLayout(2)]
	public struct BatchDrawRange
	{
		// Token: 0x060024A4 RID: 9380 RVA: 0x0009D6F0 File Offset: 0x0009B8F0
		// Note: this type is marked as 'beforefieldinit'.
		static BatchDrawRange()
		{
			Il2CppClassPointerStore<BatchDrawRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchDrawRange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchDrawRange>.NativeClassPtr);
			BatchDrawRange.NativeFieldInfoPtr_drawCommandsBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawRange>.NativeClassPtr, "drawCommandsBegin");
			BatchDrawRange.NativeFieldInfoPtr_drawCommandsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawRange>.NativeClassPtr, "drawCommandsCount");
			BatchDrawRange.NativeFieldInfoPtr_filterSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawRange>.NativeClassPtr, "filterSettings");
		}

		// Token: 0x060024A5 RID: 9381 RVA: 0x0000E61C File Offset: 0x0000C81C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchDrawRange>.NativeClassPtr, ref this));
		}

		// Token: 0x04002035 RID: 8245
		private static readonly IntPtr NativeFieldInfoPtr_drawCommandsBegin;

		// Token: 0x04002036 RID: 8246
		private static readonly IntPtr NativeFieldInfoPtr_drawCommandsCount;

		// Token: 0x04002037 RID: 8247
		private static readonly IntPtr NativeFieldInfoPtr_filterSettings;

		// Token: 0x04002038 RID: 8248
		[FieldOffset(0)]
		public uint drawCommandsBegin;

		// Token: 0x04002039 RID: 8249
		[FieldOffset(4)]
		public uint drawCommandsCount;

		// Token: 0x0400203A RID: 8250
		[FieldOffset(8)]
		public BatchFilterSettings filterSettings;
	}
}

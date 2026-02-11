using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Collections.Concurrent
{
	// Token: 0x020004D2 RID: 1234
	[StructLayout(2)]
	public struct PaddedHeadAndTail
	{
		// Token: 0x06004C24 RID: 19492 RVA: 0x0015FA0C File Offset: 0x0015DC0C
		// Note: this type is marked as 'beforefieldinit'.
		static PaddedHeadAndTail()
		{
			Il2CppClassPointerStore<PaddedHeadAndTail>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Concurrent", "PaddedHeadAndTail");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PaddedHeadAndTail>.NativeClassPtr);
			PaddedHeadAndTail.NativeFieldInfoPtr_Head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaddedHeadAndTail>.NativeClassPtr, "Head");
			PaddedHeadAndTail.NativeFieldInfoPtr_Tail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaddedHeadAndTail>.NativeClassPtr, "Tail");
		}

		// Token: 0x06004C25 RID: 19493 RVA: 0x0001BCD8 File Offset: 0x00019ED8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PaddedHeadAndTail>.NativeClassPtr, ref this));
		}

		// Token: 0x04003E48 RID: 15944
		private static readonly IntPtr NativeFieldInfoPtr_Head;

		// Token: 0x04003E49 RID: 15945
		private static readonly IntPtr NativeFieldInfoPtr_Tail;

		// Token: 0x04003E4A RID: 15946
		[FieldOffset(128)]
		public int Head;

		// Token: 0x04003E4B RID: 15947
		[FieldOffset(256)]
		public int Tail;
	}
}

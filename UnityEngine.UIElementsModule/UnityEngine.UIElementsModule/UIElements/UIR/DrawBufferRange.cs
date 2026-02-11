using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000242 RID: 578
	[StructLayout(2)]
	public struct DrawBufferRange
	{
		// Token: 0x06002A89 RID: 10889 RVA: 0x000B9098 File Offset: 0x000B7298
		// Note: this type is marked as 'beforefieldinit'.
		static DrawBufferRange()
		{
			Il2CppClassPointerStore<DrawBufferRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "DrawBufferRange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawBufferRange>.NativeClassPtr);
			DrawBufferRange.NativeFieldInfoPtr_firstIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawBufferRange>.NativeClassPtr, "firstIndex");
			DrawBufferRange.NativeFieldInfoPtr_indexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawBufferRange>.NativeClassPtr, "indexCount");
			DrawBufferRange.NativeFieldInfoPtr_minIndexVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawBufferRange>.NativeClassPtr, "minIndexVal");
			DrawBufferRange.NativeFieldInfoPtr_vertsReferenced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawBufferRange>.NativeClassPtr, "vertsReferenced");
		}

		// Token: 0x06002A8A RID: 10890 RVA: 0x0001125C File Offset: 0x0000F45C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DrawBufferRange>.NativeClassPtr, ref this));
		}

		// Token: 0x04001E47 RID: 7751
		private static readonly IntPtr NativeFieldInfoPtr_firstIndex;

		// Token: 0x04001E48 RID: 7752
		private static readonly IntPtr NativeFieldInfoPtr_indexCount;

		// Token: 0x04001E49 RID: 7753
		private static readonly IntPtr NativeFieldInfoPtr_minIndexVal;

		// Token: 0x04001E4A RID: 7754
		private static readonly IntPtr NativeFieldInfoPtr_vertsReferenced;

		// Token: 0x04001E4B RID: 7755
		[FieldOffset(0)]
		public int firstIndex;

		// Token: 0x04001E4C RID: 7756
		[FieldOffset(4)]
		public int indexCount;

		// Token: 0x04001E4D RID: 7757
		[FieldOffset(8)]
		public int minIndexVal;

		// Token: 0x04001E4E RID: 7758
		[FieldOffset(12)]
		public int vertsReferenced;
	}
}

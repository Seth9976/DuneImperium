using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000257 RID: 599
	[StructLayout(2)]
	public struct CopyClosingMeshJobData
	{
		// Token: 0x06002C45 RID: 11333 RVA: 0x000BEC64 File Offset: 0x000BCE64
		// Note: this type is marked as 'beforefieldinit'.
		static CopyClosingMeshJobData()
		{
			Il2CppClassPointerStore<CopyClosingMeshJobData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "CopyClosingMeshJobData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyClosingMeshJobData>.NativeClassPtr);
			CopyClosingMeshJobData.NativeFieldInfoPtr_vertSrc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyClosingMeshJobData>.NativeClassPtr, "vertSrc");
			CopyClosingMeshJobData.NativeFieldInfoPtr_vertDst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyClosingMeshJobData>.NativeClassPtr, "vertDst");
			CopyClosingMeshJobData.NativeFieldInfoPtr_vertCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyClosingMeshJobData>.NativeClassPtr, "vertCount");
			CopyClosingMeshJobData.NativeFieldInfoPtr_indexSrc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyClosingMeshJobData>.NativeClassPtr, "indexSrc");
			CopyClosingMeshJobData.NativeFieldInfoPtr_indexDst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyClosingMeshJobData>.NativeClassPtr, "indexDst");
			CopyClosingMeshJobData.NativeFieldInfoPtr_indexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyClosingMeshJobData>.NativeClassPtr, "indexCount");
			CopyClosingMeshJobData.NativeFieldInfoPtr_indexOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyClosingMeshJobData>.NativeClassPtr, "indexOffset");
		}

		// Token: 0x06002C46 RID: 11334 RVA: 0x00011FCA File Offset: 0x000101CA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CopyClosingMeshJobData>.NativeClassPtr, ref this));
		}

		// Token: 0x04001FB6 RID: 8118
		private static readonly IntPtr NativeFieldInfoPtr_vertSrc;

		// Token: 0x04001FB7 RID: 8119
		private static readonly IntPtr NativeFieldInfoPtr_vertDst;

		// Token: 0x04001FB8 RID: 8120
		private static readonly IntPtr NativeFieldInfoPtr_vertCount;

		// Token: 0x04001FB9 RID: 8121
		private static readonly IntPtr NativeFieldInfoPtr_indexSrc;

		// Token: 0x04001FBA RID: 8122
		private static readonly IntPtr NativeFieldInfoPtr_indexDst;

		// Token: 0x04001FBB RID: 8123
		private static readonly IntPtr NativeFieldInfoPtr_indexCount;

		// Token: 0x04001FBC RID: 8124
		private static readonly IntPtr NativeFieldInfoPtr_indexOffset;

		// Token: 0x04001FBD RID: 8125
		[FieldOffset(0)]
		public IntPtr vertSrc;

		// Token: 0x04001FBE RID: 8126
		[FieldOffset(8)]
		public IntPtr vertDst;

		// Token: 0x04001FBF RID: 8127
		[FieldOffset(16)]
		public int vertCount;

		// Token: 0x04001FC0 RID: 8128
		[FieldOffset(24)]
		public IntPtr indexSrc;

		// Token: 0x04001FC1 RID: 8129
		[FieldOffset(32)]
		public IntPtr indexDst;

		// Token: 0x04001FC2 RID: 8130
		[FieldOffset(40)]
		public int indexCount;

		// Token: 0x04001FC3 RID: 8131
		[FieldOffset(44)]
		public int indexOffset;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000255 RID: 597
	[StructLayout(2)]
	public struct NudgeJobData
	{
		// Token: 0x06002C41 RID: 11329 RVA: 0x000BE9FC File Offset: 0x000BCBFC
		// Note: this type is marked as 'beforefieldinit'.
		static NudgeJobData()
		{
			Il2CppClassPointerStore<NudgeJobData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "NudgeJobData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NudgeJobData>.NativeClassPtr);
			NudgeJobData.NativeFieldInfoPtr_src = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NudgeJobData>.NativeClassPtr, "src");
			NudgeJobData.NativeFieldInfoPtr_dst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NudgeJobData>.NativeClassPtr, "dst");
			NudgeJobData.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NudgeJobData>.NativeClassPtr, "count");
			NudgeJobData.NativeFieldInfoPtr_closingSrc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NudgeJobData>.NativeClassPtr, "closingSrc");
			NudgeJobData.NativeFieldInfoPtr_closingDst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NudgeJobData>.NativeClassPtr, "closingDst");
			NudgeJobData.NativeFieldInfoPtr_closingCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NudgeJobData>.NativeClassPtr, "closingCount");
			NudgeJobData.NativeFieldInfoPtr_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NudgeJobData>.NativeClassPtr, "transform");
			NudgeJobData.NativeFieldInfoPtr_vertsBeforeUVDisplacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NudgeJobData>.NativeClassPtr, "vertsBeforeUVDisplacement");
			NudgeJobData.NativeFieldInfoPtr_vertsAfterUVDisplacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NudgeJobData>.NativeClassPtr, "vertsAfterUVDisplacement");
		}

		// Token: 0x06002C42 RID: 11330 RVA: 0x00011FA6 File Offset: 0x000101A6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NudgeJobData>.NativeClassPtr, ref this));
		}

		// Token: 0x04001F82 RID: 8066
		private static readonly IntPtr NativeFieldInfoPtr_src;

		// Token: 0x04001F83 RID: 8067
		private static readonly IntPtr NativeFieldInfoPtr_dst;

		// Token: 0x04001F84 RID: 8068
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04001F85 RID: 8069
		private static readonly IntPtr NativeFieldInfoPtr_closingSrc;

		// Token: 0x04001F86 RID: 8070
		private static readonly IntPtr NativeFieldInfoPtr_closingDst;

		// Token: 0x04001F87 RID: 8071
		private static readonly IntPtr NativeFieldInfoPtr_closingCount;

		// Token: 0x04001F88 RID: 8072
		private static readonly IntPtr NativeFieldInfoPtr_transform;

		// Token: 0x04001F89 RID: 8073
		private static readonly IntPtr NativeFieldInfoPtr_vertsBeforeUVDisplacement;

		// Token: 0x04001F8A RID: 8074
		private static readonly IntPtr NativeFieldInfoPtr_vertsAfterUVDisplacement;

		// Token: 0x04001F8B RID: 8075
		[FieldOffset(0)]
		public IntPtr src;

		// Token: 0x04001F8C RID: 8076
		[FieldOffset(8)]
		public IntPtr dst;

		// Token: 0x04001F8D RID: 8077
		[FieldOffset(16)]
		public int count;

		// Token: 0x04001F8E RID: 8078
		[FieldOffset(24)]
		public IntPtr closingSrc;

		// Token: 0x04001F8F RID: 8079
		[FieldOffset(32)]
		public IntPtr closingDst;

		// Token: 0x04001F90 RID: 8080
		[FieldOffset(40)]
		public int closingCount;

		// Token: 0x04001F91 RID: 8081
		[FieldOffset(44)]
		public Matrix4x4 transform;

		// Token: 0x04001F92 RID: 8082
		[FieldOffset(108)]
		public int vertsBeforeUVDisplacement;

		// Token: 0x04001F93 RID: 8083
		[FieldOffset(112)]
		public int vertsAfterUVDisplacement;
	}
}

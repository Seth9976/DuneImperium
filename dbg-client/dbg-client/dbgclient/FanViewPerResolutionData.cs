using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dbgclient
{
	// Token: 0x02000084 RID: 132
	[Serializable]
	[StructLayout(2)]
	public struct FanViewPerResolutionData
	{
		// Token: 0x06000511 RID: 1297 RVA: 0x0002D5EC File Offset: 0x0002B7EC
		// Note: this type is marked as 'beforefieldinit'.
		static FanViewPerResolutionData()
		{
			Il2CppClassPointerStore<FanViewPerResolutionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient", "FanViewPerResolutionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FanViewPerResolutionData>.NativeClassPtr);
			FanViewPerResolutionData.NativeFieldInfoPtr_resolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FanViewPerResolutionData>.NativeClassPtr, "resolution");
			FanViewPerResolutionData.NativeFieldInfoPtr_unitSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FanViewPerResolutionData>.NativeClassPtr, "unitSpacing");
			FanViewPerResolutionData.NativeFieldInfoPtr_maxArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FanViewPerResolutionData>.NativeClassPtr, "maxArea");
			FanViewPerResolutionData.NativeFieldInfoPtr_rectTransformDefinesMaxArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FanViewPerResolutionData>.NativeClassPtr, "rectTransformDefinesMaxArea");
			FanViewPerResolutionData.NativeFieldInfoPtr_zSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FanViewPerResolutionData>.NativeClassPtr, "zSpacing");
			FanViewPerResolutionData.NativeFieldInfoPtr_positionRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FanViewPerResolutionData>.NativeClassPtr, "positionRadius");
			FanViewPerResolutionData.NativeFieldInfoPtr_rotationRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FanViewPerResolutionData>.NativeClassPtr, "rotationRadius");
			FanViewPerResolutionData.NativeFieldInfoPtr_rotationSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FanViewPerResolutionData>.NativeClassPtr, "rotationSpacing");
			FanViewPerResolutionData.NativeFieldInfoPtr_alignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FanViewPerResolutionData>.NativeClassPtr, "alignment");
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x000044E7 File Offset: 0x000026E7
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FanViewPerResolutionData>.NativeClassPtr, ref this));
		}

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeFieldInfoPtr_resolution;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeFieldInfoPtr_unitSpacing;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeFieldInfoPtr_maxArea;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeFieldInfoPtr_rectTransformDefinesMaxArea;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeFieldInfoPtr_zSpacing;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeFieldInfoPtr_positionRadius;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeFieldInfoPtr_rotationRadius;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeFieldInfoPtr_rotationSpacing;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeFieldInfoPtr_alignment;

		// Token: 0x04000314 RID: 788
		[FieldOffset(0)]
		public EnumResolution resolution;

		// Token: 0x04000315 RID: 789
		[FieldOffset(4)]
		public float unitSpacing;

		// Token: 0x04000316 RID: 790
		[FieldOffset(8)]
		public float maxArea;

		// Token: 0x04000317 RID: 791
		[FieldOffset(12)]
		[MarshalAs(4)]
		public bool rectTransformDefinesMaxArea;

		// Token: 0x04000318 RID: 792
		[FieldOffset(16)]
		public float zSpacing;

		// Token: 0x04000319 RID: 793
		[FieldOffset(20)]
		public float positionRadius;

		// Token: 0x0400031A RID: 794
		[FieldOffset(24)]
		public float rotationRadius;

		// Token: 0x0400031B RID: 795
		[FieldOffset(28)]
		public float rotationSpacing;

		// Token: 0x0400031C RID: 796
		[FieldOffset(32)]
		public Alignment alignment;
	}
}

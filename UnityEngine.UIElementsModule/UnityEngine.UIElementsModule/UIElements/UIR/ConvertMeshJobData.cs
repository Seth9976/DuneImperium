using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000256 RID: 598
	[StructLayout(2)]
	public struct ConvertMeshJobData
	{
		// Token: 0x06002C43 RID: 11331 RVA: 0x000BEAE0 File Offset: 0x000BCCE0
		// Note: this type is marked as 'beforefieldinit'.
		static ConvertMeshJobData()
		{
			Il2CppClassPointerStore<ConvertMeshJobData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "ConvertMeshJobData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConvertMeshJobData>.NativeClassPtr);
			ConvertMeshJobData.NativeFieldInfoPtr_vertSrc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConvertMeshJobData>.NativeClassPtr, "vertSrc");
			ConvertMeshJobData.NativeFieldInfoPtr_vertDst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConvertMeshJobData>.NativeClassPtr, "vertDst");
			ConvertMeshJobData.NativeFieldInfoPtr_vertCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConvertMeshJobData>.NativeClassPtr, "vertCount");
			ConvertMeshJobData.NativeFieldInfoPtr_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConvertMeshJobData>.NativeClassPtr, "transform");
			ConvertMeshJobData.NativeFieldInfoPtr_transformUVs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConvertMeshJobData>.NativeClassPtr, "transformUVs");
			ConvertMeshJobData.NativeFieldInfoPtr_xformClipPages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConvertMeshJobData>.NativeClassPtr, "xformClipPages");
			ConvertMeshJobData.NativeFieldInfoPtr_ids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConvertMeshJobData>.NativeClassPtr, "ids");
			ConvertMeshJobData.NativeFieldInfoPtr_addFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConvertMeshJobData>.NativeClassPtr, "addFlags");
			ConvertMeshJobData.NativeFieldInfoPtr_opacityPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConvertMeshJobData>.NativeClassPtr, "opacityPage");
			ConvertMeshJobData.NativeFieldInfoPtr_textCoreSettingsPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConvertMeshJobData>.NativeClassPtr, "textCoreSettingsPage");
			ConvertMeshJobData.NativeFieldInfoPtr_isText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConvertMeshJobData>.NativeClassPtr, "isText");
			ConvertMeshJobData.NativeFieldInfoPtr_textureId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConvertMeshJobData>.NativeClassPtr, "textureId");
			ConvertMeshJobData.NativeFieldInfoPtr_indexSrc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConvertMeshJobData>.NativeClassPtr, "indexSrc");
			ConvertMeshJobData.NativeFieldInfoPtr_indexDst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConvertMeshJobData>.NativeClassPtr, "indexDst");
			ConvertMeshJobData.NativeFieldInfoPtr_indexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConvertMeshJobData>.NativeClassPtr, "indexCount");
			ConvertMeshJobData.NativeFieldInfoPtr_indexOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConvertMeshJobData>.NativeClassPtr, "indexOffset");
			ConvertMeshJobData.NativeFieldInfoPtr_flipIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConvertMeshJobData>.NativeClassPtr, "flipIndices");
		}

		// Token: 0x06002C44 RID: 11332 RVA: 0x00011FB8 File Offset: 0x000101B8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConvertMeshJobData>.NativeClassPtr, ref this));
		}

		// Token: 0x04001F94 RID: 8084
		private static readonly IntPtr NativeFieldInfoPtr_vertSrc;

		// Token: 0x04001F95 RID: 8085
		private static readonly IntPtr NativeFieldInfoPtr_vertDst;

		// Token: 0x04001F96 RID: 8086
		private static readonly IntPtr NativeFieldInfoPtr_vertCount;

		// Token: 0x04001F97 RID: 8087
		private static readonly IntPtr NativeFieldInfoPtr_transform;

		// Token: 0x04001F98 RID: 8088
		private static readonly IntPtr NativeFieldInfoPtr_transformUVs;

		// Token: 0x04001F99 RID: 8089
		private static readonly IntPtr NativeFieldInfoPtr_xformClipPages;

		// Token: 0x04001F9A RID: 8090
		private static readonly IntPtr NativeFieldInfoPtr_ids;

		// Token: 0x04001F9B RID: 8091
		private static readonly IntPtr NativeFieldInfoPtr_addFlags;

		// Token: 0x04001F9C RID: 8092
		private static readonly IntPtr NativeFieldInfoPtr_opacityPage;

		// Token: 0x04001F9D RID: 8093
		private static readonly IntPtr NativeFieldInfoPtr_textCoreSettingsPage;

		// Token: 0x04001F9E RID: 8094
		private static readonly IntPtr NativeFieldInfoPtr_isText;

		// Token: 0x04001F9F RID: 8095
		private static readonly IntPtr NativeFieldInfoPtr_textureId;

		// Token: 0x04001FA0 RID: 8096
		private static readonly IntPtr NativeFieldInfoPtr_indexSrc;

		// Token: 0x04001FA1 RID: 8097
		private static readonly IntPtr NativeFieldInfoPtr_indexDst;

		// Token: 0x04001FA2 RID: 8098
		private static readonly IntPtr NativeFieldInfoPtr_indexCount;

		// Token: 0x04001FA3 RID: 8099
		private static readonly IntPtr NativeFieldInfoPtr_indexOffset;

		// Token: 0x04001FA4 RID: 8100
		private static readonly IntPtr NativeFieldInfoPtr_flipIndices;

		// Token: 0x04001FA5 RID: 8101
		[FieldOffset(0)]
		public IntPtr vertSrc;

		// Token: 0x04001FA6 RID: 8102
		[FieldOffset(8)]
		public IntPtr vertDst;

		// Token: 0x04001FA7 RID: 8103
		[FieldOffset(16)]
		public int vertCount;

		// Token: 0x04001FA8 RID: 8104
		[FieldOffset(20)]
		public Matrix4x4 transform;

		// Token: 0x04001FA9 RID: 8105
		[FieldOffset(84)]
		public int transformUVs;

		// Token: 0x04001FAA RID: 8106
		[FieldOffset(88)]
		public Color32 xformClipPages;

		// Token: 0x04001FAB RID: 8107
		[FieldOffset(92)]
		public Color32 ids;

		// Token: 0x04001FAC RID: 8108
		[FieldOffset(96)]
		public Color32 addFlags;

		// Token: 0x04001FAD RID: 8109
		[FieldOffset(100)]
		public Color32 opacityPage;

		// Token: 0x04001FAE RID: 8110
		[FieldOffset(104)]
		public Color32 textCoreSettingsPage;

		// Token: 0x04001FAF RID: 8111
		[FieldOffset(108)]
		public int isText;

		// Token: 0x04001FB0 RID: 8112
		[FieldOffset(112)]
		public float textureId;

		// Token: 0x04001FB1 RID: 8113
		[FieldOffset(120)]
		public IntPtr indexSrc;

		// Token: 0x04001FB2 RID: 8114
		[FieldOffset(128)]
		public IntPtr indexDst;

		// Token: 0x04001FB3 RID: 8115
		[FieldOffset(136)]
		public int indexCount;

		// Token: 0x04001FB4 RID: 8116
		[FieldOffset(140)]
		public int indexOffset;

		// Token: 0x04001FB5 RID: 8117
		[FieldOffset(144)]
		public int flipIndices;
	}
}

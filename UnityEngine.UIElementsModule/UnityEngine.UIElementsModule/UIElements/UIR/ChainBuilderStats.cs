using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000260 RID: 608
	[StructLayout(2)]
	public struct ChainBuilderStats
	{
		// Token: 0x06002CB1 RID: 11441 RVA: 0x000C062C File Offset: 0x000BE82C
		// Note: this type is marked as 'beforefieldinit'.
		static ChainBuilderStats()
		{
			Il2CppClassPointerStore<ChainBuilderStats>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "ChainBuilderStats");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChainBuilderStats>.NativeClassPtr);
			ChainBuilderStats.NativeFieldInfoPtr_elementsAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainBuilderStats>.NativeClassPtr, "elementsAdded");
			ChainBuilderStats.NativeFieldInfoPtr_elementsRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainBuilderStats>.NativeClassPtr, "elementsRemoved");
			ChainBuilderStats.NativeFieldInfoPtr_recursiveClipUpdates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainBuilderStats>.NativeClassPtr, "recursiveClipUpdates");
			ChainBuilderStats.NativeFieldInfoPtr_recursiveClipUpdatesExpanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainBuilderStats>.NativeClassPtr, "recursiveClipUpdatesExpanded");
			ChainBuilderStats.NativeFieldInfoPtr_nonRecursiveClipUpdates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainBuilderStats>.NativeClassPtr, "nonRecursiveClipUpdates");
			ChainBuilderStats.NativeFieldInfoPtr_recursiveTransformUpdates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainBuilderStats>.NativeClassPtr, "recursiveTransformUpdates");
			ChainBuilderStats.NativeFieldInfoPtr_recursiveTransformUpdatesExpanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainBuilderStats>.NativeClassPtr, "recursiveTransformUpdatesExpanded");
			ChainBuilderStats.NativeFieldInfoPtr_recursiveOpacityUpdates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainBuilderStats>.NativeClassPtr, "recursiveOpacityUpdates");
			ChainBuilderStats.NativeFieldInfoPtr_recursiveOpacityUpdatesExpanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainBuilderStats>.NativeClassPtr, "recursiveOpacityUpdatesExpanded");
			ChainBuilderStats.NativeFieldInfoPtr_opacityIdUpdates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainBuilderStats>.NativeClassPtr, "opacityIdUpdates");
			ChainBuilderStats.NativeFieldInfoPtr_colorUpdates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainBuilderStats>.NativeClassPtr, "colorUpdates");
			ChainBuilderStats.NativeFieldInfoPtr_colorUpdatesExpanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainBuilderStats>.NativeClassPtr, "colorUpdatesExpanded");
			ChainBuilderStats.NativeFieldInfoPtr_recursiveVisualUpdates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainBuilderStats>.NativeClassPtr, "recursiveVisualUpdates");
			ChainBuilderStats.NativeFieldInfoPtr_recursiveVisualUpdatesExpanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainBuilderStats>.NativeClassPtr, "recursiveVisualUpdatesExpanded");
			ChainBuilderStats.NativeFieldInfoPtr_nonRecursiveVisualUpdates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainBuilderStats>.NativeClassPtr, "nonRecursiveVisualUpdates");
			ChainBuilderStats.NativeFieldInfoPtr_dirtyProcessed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainBuilderStats>.NativeClassPtr, "dirtyProcessed");
			ChainBuilderStats.NativeFieldInfoPtr_nudgeTransformed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainBuilderStats>.NativeClassPtr, "nudgeTransformed");
			ChainBuilderStats.NativeFieldInfoPtr_boneTransformed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainBuilderStats>.NativeClassPtr, "boneTransformed");
			ChainBuilderStats.NativeFieldInfoPtr_skipTransformed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainBuilderStats>.NativeClassPtr, "skipTransformed");
			ChainBuilderStats.NativeFieldInfoPtr_visualUpdateTransformed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainBuilderStats>.NativeClassPtr, "visualUpdateTransformed");
			ChainBuilderStats.NativeFieldInfoPtr_updatedMeshAllocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainBuilderStats>.NativeClassPtr, "updatedMeshAllocations");
			ChainBuilderStats.NativeFieldInfoPtr_newMeshAllocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainBuilderStats>.NativeClassPtr, "newMeshAllocations");
			ChainBuilderStats.NativeFieldInfoPtr_groupTransformElementsChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainBuilderStats>.NativeClassPtr, "groupTransformElementsChanged");
			ChainBuilderStats.NativeFieldInfoPtr_immedateRenderersActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainBuilderStats>.NativeClassPtr, "immedateRenderersActive");
		}

		// Token: 0x06002CB2 RID: 11442 RVA: 0x0001228E File Offset: 0x0001048E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChainBuilderStats>.NativeClassPtr, ref this));
		}

		// Token: 0x04002004 RID: 8196
		private static readonly IntPtr NativeFieldInfoPtr_elementsAdded;

		// Token: 0x04002005 RID: 8197
		private static readonly IntPtr NativeFieldInfoPtr_elementsRemoved;

		// Token: 0x04002006 RID: 8198
		private static readonly IntPtr NativeFieldInfoPtr_recursiveClipUpdates;

		// Token: 0x04002007 RID: 8199
		private static readonly IntPtr NativeFieldInfoPtr_recursiveClipUpdatesExpanded;

		// Token: 0x04002008 RID: 8200
		private static readonly IntPtr NativeFieldInfoPtr_nonRecursiveClipUpdates;

		// Token: 0x04002009 RID: 8201
		private static readonly IntPtr NativeFieldInfoPtr_recursiveTransformUpdates;

		// Token: 0x0400200A RID: 8202
		private static readonly IntPtr NativeFieldInfoPtr_recursiveTransformUpdatesExpanded;

		// Token: 0x0400200B RID: 8203
		private static readonly IntPtr NativeFieldInfoPtr_recursiveOpacityUpdates;

		// Token: 0x0400200C RID: 8204
		private static readonly IntPtr NativeFieldInfoPtr_recursiveOpacityUpdatesExpanded;

		// Token: 0x0400200D RID: 8205
		private static readonly IntPtr NativeFieldInfoPtr_opacityIdUpdates;

		// Token: 0x0400200E RID: 8206
		private static readonly IntPtr NativeFieldInfoPtr_colorUpdates;

		// Token: 0x0400200F RID: 8207
		private static readonly IntPtr NativeFieldInfoPtr_colorUpdatesExpanded;

		// Token: 0x04002010 RID: 8208
		private static readonly IntPtr NativeFieldInfoPtr_recursiveVisualUpdates;

		// Token: 0x04002011 RID: 8209
		private static readonly IntPtr NativeFieldInfoPtr_recursiveVisualUpdatesExpanded;

		// Token: 0x04002012 RID: 8210
		private static readonly IntPtr NativeFieldInfoPtr_nonRecursiveVisualUpdates;

		// Token: 0x04002013 RID: 8211
		private static readonly IntPtr NativeFieldInfoPtr_dirtyProcessed;

		// Token: 0x04002014 RID: 8212
		private static readonly IntPtr NativeFieldInfoPtr_nudgeTransformed;

		// Token: 0x04002015 RID: 8213
		private static readonly IntPtr NativeFieldInfoPtr_boneTransformed;

		// Token: 0x04002016 RID: 8214
		private static readonly IntPtr NativeFieldInfoPtr_skipTransformed;

		// Token: 0x04002017 RID: 8215
		private static readonly IntPtr NativeFieldInfoPtr_visualUpdateTransformed;

		// Token: 0x04002018 RID: 8216
		private static readonly IntPtr NativeFieldInfoPtr_updatedMeshAllocations;

		// Token: 0x04002019 RID: 8217
		private static readonly IntPtr NativeFieldInfoPtr_newMeshAllocations;

		// Token: 0x0400201A RID: 8218
		private static readonly IntPtr NativeFieldInfoPtr_groupTransformElementsChanged;

		// Token: 0x0400201B RID: 8219
		private static readonly IntPtr NativeFieldInfoPtr_immedateRenderersActive;

		// Token: 0x0400201C RID: 8220
		[FieldOffset(0)]
		public uint elementsAdded;

		// Token: 0x0400201D RID: 8221
		[FieldOffset(4)]
		public uint elementsRemoved;

		// Token: 0x0400201E RID: 8222
		[FieldOffset(8)]
		public uint recursiveClipUpdates;

		// Token: 0x0400201F RID: 8223
		[FieldOffset(12)]
		public uint recursiveClipUpdatesExpanded;

		// Token: 0x04002020 RID: 8224
		[FieldOffset(16)]
		public uint nonRecursiveClipUpdates;

		// Token: 0x04002021 RID: 8225
		[FieldOffset(20)]
		public uint recursiveTransformUpdates;

		// Token: 0x04002022 RID: 8226
		[FieldOffset(24)]
		public uint recursiveTransformUpdatesExpanded;

		// Token: 0x04002023 RID: 8227
		[FieldOffset(28)]
		public uint recursiveOpacityUpdates;

		// Token: 0x04002024 RID: 8228
		[FieldOffset(32)]
		public uint recursiveOpacityUpdatesExpanded;

		// Token: 0x04002025 RID: 8229
		[FieldOffset(36)]
		public uint opacityIdUpdates;

		// Token: 0x04002026 RID: 8230
		[FieldOffset(40)]
		public uint colorUpdates;

		// Token: 0x04002027 RID: 8231
		[FieldOffset(44)]
		public uint colorUpdatesExpanded;

		// Token: 0x04002028 RID: 8232
		[FieldOffset(48)]
		public uint recursiveVisualUpdates;

		// Token: 0x04002029 RID: 8233
		[FieldOffset(52)]
		public uint recursiveVisualUpdatesExpanded;

		// Token: 0x0400202A RID: 8234
		[FieldOffset(56)]
		public uint nonRecursiveVisualUpdates;

		// Token: 0x0400202B RID: 8235
		[FieldOffset(60)]
		public uint dirtyProcessed;

		// Token: 0x0400202C RID: 8236
		[FieldOffset(64)]
		public uint nudgeTransformed;

		// Token: 0x0400202D RID: 8237
		[FieldOffset(68)]
		public uint boneTransformed;

		// Token: 0x0400202E RID: 8238
		[FieldOffset(72)]
		public uint skipTransformed;

		// Token: 0x0400202F RID: 8239
		[FieldOffset(76)]
		public uint visualUpdateTransformed;

		// Token: 0x04002030 RID: 8240
		[FieldOffset(80)]
		public uint updatedMeshAllocations;

		// Token: 0x04002031 RID: 8241
		[FieldOffset(84)]
		public uint newMeshAllocations;

		// Token: 0x04002032 RID: 8242
		[FieldOffset(88)]
		public uint groupTransformElementsChanged;

		// Token: 0x04002033 RID: 8243
		[FieldOffset(92)]
		public uint immedateRenderersActive;
	}
}

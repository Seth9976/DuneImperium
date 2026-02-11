using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000030 RID: 48
	[StructLayout(2)]
	public struct LayerBatch
	{
		// Token: 0x06000396 RID: 918 RVA: 0x0002265C File Offset: 0x0002085C
		// Note: this type is marked as 'beforefieldinit'.
		static LayerBatch()
		{
			Il2CppClassPointerStore<LayerBatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "LayerBatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayerBatch>.NativeClassPtr);
			LayerBatch.NativeFieldInfoPtr_startLayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayerBatch>.NativeClassPtr, "startLayerID");
			LayerBatch.NativeFieldInfoPtr_endLayerValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayerBatch>.NativeClassPtr, "endLayerValue");
			LayerBatch.NativeFieldInfoPtr_layerRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayerBatch>.NativeClassPtr, "layerRange");
			LayerBatch.NativeFieldInfoPtr_lightStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayerBatch>.NativeClassPtr, "lightStats");
			LayerBatch.NativeFieldInfoPtr_useNormals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayerBatch>.NativeClassPtr, "useNormals");
			LayerBatch.NativeFieldInfoPtr_renderTargetIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayerBatch>.NativeClassPtr, "renderTargetIds");
			LayerBatch.NativeFieldInfoPtr_renderTargetUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayerBatch>.NativeClassPtr, "renderTargetUsed");
			LayerBatch.NativeMethodInfoPtr_InitRTIds_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerBatch>.NativeClassPtr, 100663750);
			LayerBatch.NativeMethodInfoPtr_GetRTId_Public_RenderTargetIdentifier_CommandBuffer_RenderTextureDescriptor_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerBatch>.NativeClassPtr, 100663751);
			LayerBatch.NativeMethodInfoPtr_ReleaseRT_Public_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerBatch>.NativeClassPtr, 100663752);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00022754 File Offset: 0x00020954
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 600865, RefRangeEnd = 600867, XrefRangeStart = 600856, XrefRangeEnd = 600865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitRTIds(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerBatch.NativeMethodInfoPtr_InitRTIds_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00022788 File Offset: 0x00020988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 600867, XrefRangeEnd = 600869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTargetIdentifier GetRTId(CommandBuffer cmd, RenderTextureDescriptor desc, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref desc;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerBatch.NativeMethodInfoPtr_GetRTId_Public_RenderTargetIdentifier_CommandBuffer_RenderTextureDescriptor_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x000227E8 File Offset: 0x000209E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 600869, XrefRangeEnd = 600870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseRT(CommandBuffer cmd)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerBatch.NativeMethodInfoPtr_ReleaseRT_Public_Void_CommandBuffer_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600039A RID: 922 RVA: 0x000038A2 File Offset: 0x00001AA2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LayerBatch>.NativeClassPtr, ref this));
		}

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeFieldInfoPtr_startLayerID;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeFieldInfoPtr_endLayerValue;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeFieldInfoPtr_layerRange;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeFieldInfoPtr_lightStats;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeFieldInfoPtr_useNormals;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeFieldInfoPtr_renderTargetIds;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeFieldInfoPtr_renderTargetUsed;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr_InitRTIds_Public_Void_Int32_0;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr_GetRTId_Public_RenderTargetIdentifier_CommandBuffer_RenderTextureDescriptor_Int32_0;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseRT_Public_Void_CommandBuffer_0;

		// Token: 0x040002C2 RID: 706
		[FieldOffset(0)]
		public int startLayerID;

		// Token: 0x040002C3 RID: 707
		[FieldOffset(4)]
		public int endLayerValue;

		// Token: 0x040002C4 RID: 708
		[FieldOffset(8)]
		public SortingLayerRange layerRange;

		// Token: 0x040002C5 RID: 709
		[FieldOffset(12)]
		public LightStats lightStats;

		// Token: 0x040002C6 RID: 710
		[FieldOffset(32)]
		[MarshalAs(4)]
		public bool useNormals;

		// Token: 0x040002C7 RID: 711
		[FieldOffset(36)]
		public LayerBatch._renderTargetIds_e__FixedBuffer renderTargetIds;

		// Token: 0x040002C8 RID: 712
		[FieldOffset(52)]
		public LayerBatch._renderTargetUsed_e__FixedBuffer renderTargetUsed;

		// Token: 0x0200015D RID: 349
		[ObfuscatedName("UnityEngine.Rendering.Universal.LayerBatch+<renderTargetIds>e__FixedBuffer")]
		[StructLayout(2)]
		public struct _renderTargetIds_e__FixedBuffer
		{
			// Token: 0x06001B87 RID: 7047 RVA: 0x0000F91A File Offset: 0x0000DB1A
			// Note: this type is marked as 'beforefieldinit'.
			static _renderTargetIds_e__FixedBuffer()
			{
				Il2CppClassPointerStore<LayerBatch._renderTargetIds_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LayerBatch>.NativeClassPtr, "<renderTargetIds>e__FixedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayerBatch._renderTargetIds_e__FixedBuffer>.NativeClassPtr);
				LayerBatch._renderTargetIds_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayerBatch._renderTargetIds_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
			}

			// Token: 0x06001B88 RID: 7048 RVA: 0x0000F94E File Offset: 0x0000DB4E
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LayerBatch._renderTargetIds_e__FixedBuffer>.NativeClassPtr, ref this));
			}

			// Token: 0x04001414 RID: 5140
			private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

			// Token: 0x04001415 RID: 5141
			[FieldOffset(0)]
			public int FixedElementField;
		}

		// Token: 0x0200015E RID: 350
		[ObfuscatedName("UnityEngine.Rendering.Universal.LayerBatch+<renderTargetUsed>e__FixedBuffer")]
		[StructLayout(2)]
		public struct _renderTargetUsed_e__FixedBuffer
		{
			// Token: 0x06001B89 RID: 7049 RVA: 0x0000F960 File Offset: 0x0000DB60
			// Note: this type is marked as 'beforefieldinit'.
			static _renderTargetUsed_e__FixedBuffer()
			{
				Il2CppClassPointerStore<LayerBatch._renderTargetUsed_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LayerBatch>.NativeClassPtr, "<renderTargetUsed>e__FixedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayerBatch._renderTargetUsed_e__FixedBuffer>.NativeClassPtr);
				LayerBatch._renderTargetUsed_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayerBatch._renderTargetUsed_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
			}

			// Token: 0x06001B8A RID: 7050 RVA: 0x0000F994 File Offset: 0x0000DB94
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LayerBatch._renderTargetUsed_e__FixedBuffer>.NativeClassPtr, ref this));
			}

			// Token: 0x04001416 RID: 5142
			private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

			// Token: 0x04001417 RID: 5143
			[FieldOffset(0)]
			[MarshalAs(4)]
			public bool FixedElementField;
		}
	}
}

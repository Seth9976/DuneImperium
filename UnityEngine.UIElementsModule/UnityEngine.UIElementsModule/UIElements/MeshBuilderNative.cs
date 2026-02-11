using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000150 RID: 336
	public static class MeshBuilderNative : Object
	{
		// Token: 0x060018A2 RID: 6306 RVA: 0x00073E00 File Offset: 0x00072000
		// Note: this type is marked as 'beforefieldinit'.
		static MeshBuilderNative()
		{
			Il2CppClassPointerStore<MeshBuilderNative>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MeshBuilderNative");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshBuilderNative>.NativeClassPtr);
			MeshBuilderNative.NativeMethodInfoPtr_MakeBorder_Public_Static_MeshWriteDataInterface_NativeBorderParams_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshBuilderNative>.NativeClassPtr, 100666925);
			MeshBuilderNative.NativeMethodInfoPtr_MakeSolidRect_Public_Static_MeshWriteDataInterface_NativeRectParams_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshBuilderNative>.NativeClassPtr, 100666926);
			MeshBuilderNative.NativeMethodInfoPtr_MakeTexturedRect_Public_Static_MeshWriteDataInterface_NativeRectParams_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshBuilderNative>.NativeClassPtr, 100666927);
			MeshBuilderNative.NativeMethodInfoPtr_MakeVectorGraphicsStretchBackground_Public_Static_MeshWriteDataInterface_Il2CppStructArray_1_Vertex_Il2CppStructArray_1_UInt16_Single_Single_Rect_Rect_ScaleMode_Color_NativeColorPage_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshBuilderNative>.NativeClassPtr, 100666928);
			MeshBuilderNative.NativeMethodInfoPtr_MakeVectorGraphics9SliceBackground_Public_Static_MeshWriteDataInterface_Il2CppStructArray_1_Vertex_Il2CppStructArray_1_UInt16_Single_Single_Rect_Vector4_Color_NativeColorPage_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshBuilderNative>.NativeClassPtr, 100666929);
			MeshBuilderNative.NativeMethodInfoPtr_MakeBorder_Injected_Private_Static_Void_byref_NativeBorderParams_Single_byref_MeshWriteDataInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshBuilderNative>.NativeClassPtr, 100666930);
			MeshBuilderNative.NativeMethodInfoPtr_MakeSolidRect_Injected_Private_Static_Void_byref_NativeRectParams_Single_byref_MeshWriteDataInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshBuilderNative>.NativeClassPtr, 100666931);
			MeshBuilderNative.NativeMethodInfoPtr_MakeTexturedRect_Injected_Private_Static_Void_byref_NativeRectParams_Single_byref_MeshWriteDataInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshBuilderNative>.NativeClassPtr, 100666932);
			MeshBuilderNative.NativeMethodInfoPtr_MakeVectorGraphicsStretchBackground_Injected_Private_Static_Void_Il2CppStructArray_1_Vertex_Il2CppStructArray_1_UInt16_Single_Single_byref_Rect_byref_Rect_ScaleMode_byref_Color_byref_NativeColorPage_Int32_byref_Int32_byref_Int32_byref_MeshWriteDataInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshBuilderNative>.NativeClassPtr, 100666933);
			MeshBuilderNative.NativeMethodInfoPtr_MakeVectorGraphics9SliceBackground_Injected_Private_Static_Void_Il2CppStructArray_1_Vertex_Il2CppStructArray_1_UInt16_Single_Single_byref_Rect_byref_Vector4_byref_Color_byref_NativeColorPage_Int32_byref_MeshWriteDataInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshBuilderNative>.NativeClassPtr, 100666934);
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x00073EF8 File Offset: 0x000720F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 320330, RefRangeEnd = 320332, XrefRangeStart = 320328, XrefRangeEnd = 320330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MeshWriteDataInterface MakeBorder(MeshBuilderNative.NativeBorderParams borderParams, float posZ)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref borderParams;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref posZ;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshBuilderNative.NativeMethodInfoPtr_MakeBorder_Public_Static_MeshWriteDataInterface_NativeBorderParams_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x00073F44 File Offset: 0x00072144
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 320334, RefRangeEnd = 320336, XrefRangeStart = 320332, XrefRangeEnd = 320334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MeshWriteDataInterface MakeSolidRect(MeshBuilderNative.NativeRectParams rectParams, float posZ)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rectParams;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref posZ;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshBuilderNative.NativeMethodInfoPtr_MakeSolidRect_Public_Static_MeshWriteDataInterface_NativeRectParams_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x00073F90 File Offset: 0x00072190
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320338, RefRangeEnd = 320339, XrefRangeStart = 320336, XrefRangeEnd = 320338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MeshWriteDataInterface MakeTexturedRect(MeshBuilderNative.NativeRectParams rectParams, float posZ)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rectParams;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref posZ;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshBuilderNative.NativeMethodInfoPtr_MakeTexturedRect_Public_Static_MeshWriteDataInterface_NativeRectParams_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x00073FDC File Offset: 0x000721DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320341, RefRangeEnd = 320342, XrefRangeStart = 320339, XrefRangeEnd = 320341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MeshWriteDataInterface MakeVectorGraphicsStretchBackground(Il2CppStructArray<Vertex> svgVertices, Il2CppStructArray<ushort> svgIndices, float svgWidth, float svgHeight, Rect targetRect, Rect sourceUV, ScaleMode scaleMode, Color tint, MeshBuilderNative.NativeColorPage colorPage, int settingIndexOffset, ref int finalVertexCount, ref int finalIndexCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(svgVertices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(svgIndices);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref svgWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref svgHeight;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetRect;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceUV;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleMode;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tint;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorPage;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref settingIndexOffset;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &finalVertexCount;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &finalIndexCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshBuilderNative.NativeMethodInfoPtr_MakeVectorGraphicsStretchBackground_Public_Static_MeshWriteDataInterface_Il2CppStructArray_1_Vertex_Il2CppStructArray_1_UInt16_Single_Single_Rect_Rect_ScaleMode_Color_NativeColorPage_Int32_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x000740C4 File Offset: 0x000722C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320344, RefRangeEnd = 320345, XrefRangeStart = 320342, XrefRangeEnd = 320344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MeshWriteDataInterface MakeVectorGraphics9SliceBackground(Il2CppStructArray<Vertex> svgVertices, Il2CppStructArray<ushort> svgIndices, float svgWidth, float svgHeight, Rect targetRect, Vector4 sliceLTRB, Color tint, MeshBuilderNative.NativeColorPage colorPage, int settingIndexOffset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(svgVertices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(svgIndices);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref svgWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref svgHeight;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetRect;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sliceLTRB;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tint;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorPage;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref settingIndexOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshBuilderNative.NativeMethodInfoPtr_MakeVectorGraphics9SliceBackground_Public_Static_MeshWriteDataInterface_Il2CppStructArray_1_Vertex_Il2CppStructArray_1_UInt16_Single_Single_Rect_Vector4_Color_NativeColorPage_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x0007417C File Offset: 0x0007237C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320345, XrefRangeEnd = 320347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MakeBorder_Injected(ref MeshBuilderNative.NativeBorderParams borderParams, float posZ, out MeshWriteDataInterface ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &borderParams;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref posZ;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshBuilderNative.NativeMethodInfoPtr_MakeBorder_Injected_Private_Static_Void_byref_NativeBorderParams_Single_byref_MeshWriteDataInterface_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x000741CC File Offset: 0x000723CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320347, XrefRangeEnd = 320349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MakeSolidRect_Injected(ref MeshBuilderNative.NativeRectParams rectParams, float posZ, out MeshWriteDataInterface ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &rectParams;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref posZ;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshBuilderNative.NativeMethodInfoPtr_MakeSolidRect_Injected_Private_Static_Void_byref_NativeRectParams_Single_byref_MeshWriteDataInterface_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x0007421C File Offset: 0x0007241C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320349, XrefRangeEnd = 320351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MakeTexturedRect_Injected(ref MeshBuilderNative.NativeRectParams rectParams, float posZ, out MeshWriteDataInterface ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &rectParams;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref posZ;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshBuilderNative.NativeMethodInfoPtr_MakeTexturedRect_Injected_Private_Static_Void_byref_NativeRectParams_Single_byref_MeshWriteDataInterface_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x0007426C File Offset: 0x0007246C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320351, XrefRangeEnd = 320353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MakeVectorGraphicsStretchBackground_Injected(Il2CppStructArray<Vertex> svgVertices, Il2CppStructArray<ushort> svgIndices, float svgWidth, float svgHeight, ref Rect targetRect, ref Rect sourceUV, ScaleMode scaleMode, ref Color tint, ref MeshBuilderNative.NativeColorPage colorPage, int settingIndexOffset, ref int finalVertexCount, ref int finalIndexCount, out MeshWriteDataInterface ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(svgVertices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(svgIndices);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref svgWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref svgHeight;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &targetRect;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &sourceUV;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleMode;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &tint;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &colorPage;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref settingIndexOffset;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &finalVertexCount;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &finalIndexCount;
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshBuilderNative.NativeMethodInfoPtr_MakeVectorGraphicsStretchBackground_Injected_Private_Static_Void_Il2CppStructArray_1_Vertex_Il2CppStructArray_1_UInt16_Single_Single_byref_Rect_byref_Rect_ScaleMode_byref_Color_byref_NativeColorPage_Int32_byref_Int32_byref_Int32_byref_MeshWriteDataInterface_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x0007435C File Offset: 0x0007255C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320353, XrefRangeEnd = 320355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MakeVectorGraphics9SliceBackground_Injected(Il2CppStructArray<Vertex> svgVertices, Il2CppStructArray<ushort> svgIndices, float svgWidth, float svgHeight, ref Rect targetRect, ref Vector4 sliceLTRB, ref Color tint, ref MeshBuilderNative.NativeColorPage colorPage, int settingIndexOffset, out MeshWriteDataInterface ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(svgVertices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(svgIndices);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref svgWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref svgHeight;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &targetRect;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &sliceLTRB;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &tint;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &colorPage;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref settingIndexOffset;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshBuilderNative.NativeMethodInfoPtr_MakeVectorGraphics9SliceBackground_Injected_Private_Static_Void_Il2CppStructArray_1_Vertex_Il2CppStructArray_1_UInt16_Single_Single_byref_Rect_byref_Vector4_byref_Color_byref_NativeColorPage_Int32_byref_MeshWriteDataInterface_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x0000B530 File Offset: 0x00009730
		public MeshBuilderNative(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010EC RID: 4332
		private static readonly IntPtr NativeMethodInfoPtr_MakeBorder_Public_Static_MeshWriteDataInterface_NativeBorderParams_Single_0;

		// Token: 0x040010ED RID: 4333
		private static readonly IntPtr NativeMethodInfoPtr_MakeSolidRect_Public_Static_MeshWriteDataInterface_NativeRectParams_Single_0;

		// Token: 0x040010EE RID: 4334
		private static readonly IntPtr NativeMethodInfoPtr_MakeTexturedRect_Public_Static_MeshWriteDataInterface_NativeRectParams_Single_0;

		// Token: 0x040010EF RID: 4335
		private static readonly IntPtr NativeMethodInfoPtr_MakeVectorGraphicsStretchBackground_Public_Static_MeshWriteDataInterface_Il2CppStructArray_1_Vertex_Il2CppStructArray_1_UInt16_Single_Single_Rect_Rect_ScaleMode_Color_NativeColorPage_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x040010F0 RID: 4336
		private static readonly IntPtr NativeMethodInfoPtr_MakeVectorGraphics9SliceBackground_Public_Static_MeshWriteDataInterface_Il2CppStructArray_1_Vertex_Il2CppStructArray_1_UInt16_Single_Single_Rect_Vector4_Color_NativeColorPage_Int32_0;

		// Token: 0x040010F1 RID: 4337
		private static readonly IntPtr NativeMethodInfoPtr_MakeBorder_Injected_Private_Static_Void_byref_NativeBorderParams_Single_byref_MeshWriteDataInterface_0;

		// Token: 0x040010F2 RID: 4338
		private static readonly IntPtr NativeMethodInfoPtr_MakeSolidRect_Injected_Private_Static_Void_byref_NativeRectParams_Single_byref_MeshWriteDataInterface_0;

		// Token: 0x040010F3 RID: 4339
		private static readonly IntPtr NativeMethodInfoPtr_MakeTexturedRect_Injected_Private_Static_Void_byref_NativeRectParams_Single_byref_MeshWriteDataInterface_0;

		// Token: 0x040010F4 RID: 4340
		private static readonly IntPtr NativeMethodInfoPtr_MakeVectorGraphicsStretchBackground_Injected_Private_Static_Void_Il2CppStructArray_1_Vertex_Il2CppStructArray_1_UInt16_Single_Single_byref_Rect_byref_Rect_ScaleMode_byref_Color_byref_NativeColorPage_Int32_byref_Int32_byref_Int32_byref_MeshWriteDataInterface_0;

		// Token: 0x040010F5 RID: 4341
		private static readonly IntPtr NativeMethodInfoPtr_MakeVectorGraphics9SliceBackground_Injected_Private_Static_Void_Il2CppStructArray_1_Vertex_Il2CppStructArray_1_UInt16_Single_Single_byref_Rect_byref_Vector4_byref_Color_byref_NativeColorPage_Int32_byref_MeshWriteDataInterface_0;

		// Token: 0x040010F6 RID: 4342
		public const float kEpsilon = 0.001f;

		// Token: 0x0200048D RID: 1165
		[StructLayout(2)]
		public struct NativeColorPage
		{
			// Token: 0x06003C5C RID: 15452 RVA: 0x000F1BA8 File Offset: 0x000EFDA8
			// Note: this type is marked as 'beforefieldinit'.
			static NativeColorPage()
			{
				Il2CppClassPointerStore<MeshBuilderNative.NativeColorPage>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshBuilderNative>.NativeClassPtr, "NativeColorPage");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshBuilderNative.NativeColorPage>.NativeClassPtr);
				MeshBuilderNative.NativeColorPage.NativeFieldInfoPtr_isValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeColorPage>.NativeClassPtr, "isValid");
				MeshBuilderNative.NativeColorPage.NativeFieldInfoPtr_pageAndID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeColorPage>.NativeClassPtr, "pageAndID");
			}

			// Token: 0x06003C5D RID: 15453 RVA: 0x00019484 File Offset: 0x00017684
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MeshBuilderNative.NativeColorPage>.NativeClassPtr, ref this));
			}

			// Token: 0x04002A6F RID: 10863
			private static readonly IntPtr NativeFieldInfoPtr_isValid;

			// Token: 0x04002A70 RID: 10864
			private static readonly IntPtr NativeFieldInfoPtr_pageAndID;

			// Token: 0x04002A71 RID: 10865
			[FieldOffset(0)]
			public int isValid;

			// Token: 0x04002A72 RID: 10866
			[FieldOffset(4)]
			public Color32 pageAndID;
		}

		// Token: 0x0200048E RID: 1166
		[StructLayout(2)]
		public struct NativeBorderParams
		{
			// Token: 0x06003C5E RID: 15454 RVA: 0x000F1BFC File Offset: 0x000EFDFC
			// Note: this type is marked as 'beforefieldinit'.
			static NativeBorderParams()
			{
				Il2CppClassPointerStore<MeshBuilderNative.NativeBorderParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshBuilderNative>.NativeClassPtr, "NativeBorderParams");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshBuilderNative.NativeBorderParams>.NativeClassPtr);
				MeshBuilderNative.NativeBorderParams.NativeFieldInfoPtr_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeBorderParams>.NativeClassPtr, "rect");
				MeshBuilderNative.NativeBorderParams.NativeFieldInfoPtr_leftColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeBorderParams>.NativeClassPtr, "leftColor");
				MeshBuilderNative.NativeBorderParams.NativeFieldInfoPtr_topColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeBorderParams>.NativeClassPtr, "topColor");
				MeshBuilderNative.NativeBorderParams.NativeFieldInfoPtr_rightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeBorderParams>.NativeClassPtr, "rightColor");
				MeshBuilderNative.NativeBorderParams.NativeFieldInfoPtr_bottomColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeBorderParams>.NativeClassPtr, "bottomColor");
				MeshBuilderNative.NativeBorderParams.NativeFieldInfoPtr_leftWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeBorderParams>.NativeClassPtr, "leftWidth");
				MeshBuilderNative.NativeBorderParams.NativeFieldInfoPtr_topWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeBorderParams>.NativeClassPtr, "topWidth");
				MeshBuilderNative.NativeBorderParams.NativeFieldInfoPtr_rightWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeBorderParams>.NativeClassPtr, "rightWidth");
				MeshBuilderNative.NativeBorderParams.NativeFieldInfoPtr_bottomWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeBorderParams>.NativeClassPtr, "bottomWidth");
				MeshBuilderNative.NativeBorderParams.NativeFieldInfoPtr_topLeftRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeBorderParams>.NativeClassPtr, "topLeftRadius");
				MeshBuilderNative.NativeBorderParams.NativeFieldInfoPtr_topRightRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeBorderParams>.NativeClassPtr, "topRightRadius");
				MeshBuilderNative.NativeBorderParams.NativeFieldInfoPtr_bottomRightRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeBorderParams>.NativeClassPtr, "bottomRightRadius");
				MeshBuilderNative.NativeBorderParams.NativeFieldInfoPtr_bottomLeftRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeBorderParams>.NativeClassPtr, "bottomLeftRadius");
				MeshBuilderNative.NativeBorderParams.NativeFieldInfoPtr_leftColorPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeBorderParams>.NativeClassPtr, "leftColorPage");
				MeshBuilderNative.NativeBorderParams.NativeFieldInfoPtr_topColorPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeBorderParams>.NativeClassPtr, "topColorPage");
				MeshBuilderNative.NativeBorderParams.NativeFieldInfoPtr_rightColorPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeBorderParams>.NativeClassPtr, "rightColorPage");
				MeshBuilderNative.NativeBorderParams.NativeFieldInfoPtr_bottomColorPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeBorderParams>.NativeClassPtr, "bottomColorPage");
			}

			// Token: 0x06003C5F RID: 15455 RVA: 0x00019496 File Offset: 0x00017696
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MeshBuilderNative.NativeBorderParams>.NativeClassPtr, ref this));
			}

			// Token: 0x04002A73 RID: 10867
			private static readonly IntPtr NativeFieldInfoPtr_rect;

			// Token: 0x04002A74 RID: 10868
			private static readonly IntPtr NativeFieldInfoPtr_leftColor;

			// Token: 0x04002A75 RID: 10869
			private static readonly IntPtr NativeFieldInfoPtr_topColor;

			// Token: 0x04002A76 RID: 10870
			private static readonly IntPtr NativeFieldInfoPtr_rightColor;

			// Token: 0x04002A77 RID: 10871
			private static readonly IntPtr NativeFieldInfoPtr_bottomColor;

			// Token: 0x04002A78 RID: 10872
			private static readonly IntPtr NativeFieldInfoPtr_leftWidth;

			// Token: 0x04002A79 RID: 10873
			private static readonly IntPtr NativeFieldInfoPtr_topWidth;

			// Token: 0x04002A7A RID: 10874
			private static readonly IntPtr NativeFieldInfoPtr_rightWidth;

			// Token: 0x04002A7B RID: 10875
			private static readonly IntPtr NativeFieldInfoPtr_bottomWidth;

			// Token: 0x04002A7C RID: 10876
			private static readonly IntPtr NativeFieldInfoPtr_topLeftRadius;

			// Token: 0x04002A7D RID: 10877
			private static readonly IntPtr NativeFieldInfoPtr_topRightRadius;

			// Token: 0x04002A7E RID: 10878
			private static readonly IntPtr NativeFieldInfoPtr_bottomRightRadius;

			// Token: 0x04002A7F RID: 10879
			private static readonly IntPtr NativeFieldInfoPtr_bottomLeftRadius;

			// Token: 0x04002A80 RID: 10880
			private static readonly IntPtr NativeFieldInfoPtr_leftColorPage;

			// Token: 0x04002A81 RID: 10881
			private static readonly IntPtr NativeFieldInfoPtr_topColorPage;

			// Token: 0x04002A82 RID: 10882
			private static readonly IntPtr NativeFieldInfoPtr_rightColorPage;

			// Token: 0x04002A83 RID: 10883
			private static readonly IntPtr NativeFieldInfoPtr_bottomColorPage;

			// Token: 0x04002A84 RID: 10884
			[FieldOffset(0)]
			public Rect rect;

			// Token: 0x04002A85 RID: 10885
			[FieldOffset(16)]
			public Color leftColor;

			// Token: 0x04002A86 RID: 10886
			[FieldOffset(32)]
			public Color topColor;

			// Token: 0x04002A87 RID: 10887
			[FieldOffset(48)]
			public Color rightColor;

			// Token: 0x04002A88 RID: 10888
			[FieldOffset(64)]
			public Color bottomColor;

			// Token: 0x04002A89 RID: 10889
			[FieldOffset(80)]
			public float leftWidth;

			// Token: 0x04002A8A RID: 10890
			[FieldOffset(84)]
			public float topWidth;

			// Token: 0x04002A8B RID: 10891
			[FieldOffset(88)]
			public float rightWidth;

			// Token: 0x04002A8C RID: 10892
			[FieldOffset(92)]
			public float bottomWidth;

			// Token: 0x04002A8D RID: 10893
			[FieldOffset(96)]
			public Vector2 topLeftRadius;

			// Token: 0x04002A8E RID: 10894
			[FieldOffset(104)]
			public Vector2 topRightRadius;

			// Token: 0x04002A8F RID: 10895
			[FieldOffset(112)]
			public Vector2 bottomRightRadius;

			// Token: 0x04002A90 RID: 10896
			[FieldOffset(120)]
			public Vector2 bottomLeftRadius;

			// Token: 0x04002A91 RID: 10897
			[FieldOffset(128)]
			public MeshBuilderNative.NativeColorPage leftColorPage;

			// Token: 0x04002A92 RID: 10898
			[FieldOffset(136)]
			public MeshBuilderNative.NativeColorPage topColorPage;

			// Token: 0x04002A93 RID: 10899
			[FieldOffset(144)]
			public MeshBuilderNative.NativeColorPage rightColorPage;

			// Token: 0x04002A94 RID: 10900
			[FieldOffset(152)]
			public MeshBuilderNative.NativeColorPage bottomColorPage;
		}

		// Token: 0x0200048F RID: 1167
		[StructLayout(2)]
		public struct NativeRectParams
		{
			// Token: 0x06003C60 RID: 15456 RVA: 0x000F1D7C File Offset: 0x000EFF7C
			// Note: this type is marked as 'beforefieldinit'.
			static NativeRectParams()
			{
				Il2CppClassPointerStore<MeshBuilderNative.NativeRectParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshBuilderNative>.NativeClassPtr, "NativeRectParams");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshBuilderNative.NativeRectParams>.NativeClassPtr);
				MeshBuilderNative.NativeRectParams.NativeFieldInfoPtr_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeRectParams>.NativeClassPtr, "rect");
				MeshBuilderNative.NativeRectParams.NativeFieldInfoPtr_subRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeRectParams>.NativeClassPtr, "subRect");
				MeshBuilderNative.NativeRectParams.NativeFieldInfoPtr_uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeRectParams>.NativeClassPtr, "uv");
				MeshBuilderNative.NativeRectParams.NativeFieldInfoPtr_uvRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeRectParams>.NativeClassPtr, "uvRegion");
				MeshBuilderNative.NativeRectParams.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeRectParams>.NativeClassPtr, "color");
				MeshBuilderNative.NativeRectParams.NativeFieldInfoPtr_scaleMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeRectParams>.NativeClassPtr, "scaleMode");
				MeshBuilderNative.NativeRectParams.NativeFieldInfoPtr_topLeftRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeRectParams>.NativeClassPtr, "topLeftRadius");
				MeshBuilderNative.NativeRectParams.NativeFieldInfoPtr_topRightRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeRectParams>.NativeClassPtr, "topRightRadius");
				MeshBuilderNative.NativeRectParams.NativeFieldInfoPtr_bottomRightRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeRectParams>.NativeClassPtr, "bottomRightRadius");
				MeshBuilderNative.NativeRectParams.NativeFieldInfoPtr_bottomLeftRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeRectParams>.NativeClassPtr, "bottomLeftRadius");
				MeshBuilderNative.NativeRectParams.NativeFieldInfoPtr_backgroundRepeatRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeRectParams>.NativeClassPtr, "backgroundRepeatRect");
				MeshBuilderNative.NativeRectParams.NativeFieldInfoPtr_contentSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeRectParams>.NativeClassPtr, "contentSize");
				MeshBuilderNative.NativeRectParams.NativeFieldInfoPtr_textureSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeRectParams>.NativeClassPtr, "textureSize");
				MeshBuilderNative.NativeRectParams.NativeFieldInfoPtr_texturePixelsPerPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeRectParams>.NativeClassPtr, "texturePixelsPerPoint");
				MeshBuilderNative.NativeRectParams.NativeFieldInfoPtr_leftSlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeRectParams>.NativeClassPtr, "leftSlice");
				MeshBuilderNative.NativeRectParams.NativeFieldInfoPtr_topSlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeRectParams>.NativeClassPtr, "topSlice");
				MeshBuilderNative.NativeRectParams.NativeFieldInfoPtr_rightSlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeRectParams>.NativeClassPtr, "rightSlice");
				MeshBuilderNative.NativeRectParams.NativeFieldInfoPtr_bottomSlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeRectParams>.NativeClassPtr, "bottomSlice");
				MeshBuilderNative.NativeRectParams.NativeFieldInfoPtr_sliceScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeRectParams>.NativeClassPtr, "sliceScale");
				MeshBuilderNative.NativeRectParams.NativeFieldInfoPtr_rectInset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeRectParams>.NativeClassPtr, "rectInset");
				MeshBuilderNative.NativeRectParams.NativeFieldInfoPtr_colorPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshBuilderNative.NativeRectParams>.NativeClassPtr, "colorPage");
			}

			// Token: 0x06003C61 RID: 15457 RVA: 0x000194A8 File Offset: 0x000176A8
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MeshBuilderNative.NativeRectParams>.NativeClassPtr, ref this));
			}

			// Token: 0x04002A95 RID: 10901
			private static readonly IntPtr NativeFieldInfoPtr_rect;

			// Token: 0x04002A96 RID: 10902
			private static readonly IntPtr NativeFieldInfoPtr_subRect;

			// Token: 0x04002A97 RID: 10903
			private static readonly IntPtr NativeFieldInfoPtr_uv;

			// Token: 0x04002A98 RID: 10904
			private static readonly IntPtr NativeFieldInfoPtr_uvRegion;

			// Token: 0x04002A99 RID: 10905
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x04002A9A RID: 10906
			private static readonly IntPtr NativeFieldInfoPtr_scaleMode;

			// Token: 0x04002A9B RID: 10907
			private static readonly IntPtr NativeFieldInfoPtr_topLeftRadius;

			// Token: 0x04002A9C RID: 10908
			private static readonly IntPtr NativeFieldInfoPtr_topRightRadius;

			// Token: 0x04002A9D RID: 10909
			private static readonly IntPtr NativeFieldInfoPtr_bottomRightRadius;

			// Token: 0x04002A9E RID: 10910
			private static readonly IntPtr NativeFieldInfoPtr_bottomLeftRadius;

			// Token: 0x04002A9F RID: 10911
			private static readonly IntPtr NativeFieldInfoPtr_backgroundRepeatRect;

			// Token: 0x04002AA0 RID: 10912
			private static readonly IntPtr NativeFieldInfoPtr_contentSize;

			// Token: 0x04002AA1 RID: 10913
			private static readonly IntPtr NativeFieldInfoPtr_textureSize;

			// Token: 0x04002AA2 RID: 10914
			private static readonly IntPtr NativeFieldInfoPtr_texturePixelsPerPoint;

			// Token: 0x04002AA3 RID: 10915
			private static readonly IntPtr NativeFieldInfoPtr_leftSlice;

			// Token: 0x04002AA4 RID: 10916
			private static readonly IntPtr NativeFieldInfoPtr_topSlice;

			// Token: 0x04002AA5 RID: 10917
			private static readonly IntPtr NativeFieldInfoPtr_rightSlice;

			// Token: 0x04002AA6 RID: 10918
			private static readonly IntPtr NativeFieldInfoPtr_bottomSlice;

			// Token: 0x04002AA7 RID: 10919
			private static readonly IntPtr NativeFieldInfoPtr_sliceScale;

			// Token: 0x04002AA8 RID: 10920
			private static readonly IntPtr NativeFieldInfoPtr_rectInset;

			// Token: 0x04002AA9 RID: 10921
			private static readonly IntPtr NativeFieldInfoPtr_colorPage;

			// Token: 0x04002AAA RID: 10922
			[FieldOffset(0)]
			public Rect rect;

			// Token: 0x04002AAB RID: 10923
			[FieldOffset(16)]
			public Rect subRect;

			// Token: 0x04002AAC RID: 10924
			[FieldOffset(32)]
			public Rect uv;

			// Token: 0x04002AAD RID: 10925
			[FieldOffset(48)]
			public Rect uvRegion;

			// Token: 0x04002AAE RID: 10926
			[FieldOffset(64)]
			public Color color;

			// Token: 0x04002AAF RID: 10927
			[FieldOffset(80)]
			public ScaleMode scaleMode;

			// Token: 0x04002AB0 RID: 10928
			[FieldOffset(84)]
			public Vector2 topLeftRadius;

			// Token: 0x04002AB1 RID: 10929
			[FieldOffset(92)]
			public Vector2 topRightRadius;

			// Token: 0x04002AB2 RID: 10930
			[FieldOffset(100)]
			public Vector2 bottomRightRadius;

			// Token: 0x04002AB3 RID: 10931
			[FieldOffset(108)]
			public Vector2 bottomLeftRadius;

			// Token: 0x04002AB4 RID: 10932
			[FieldOffset(116)]
			public Rect backgroundRepeatRect;

			// Token: 0x04002AB5 RID: 10933
			[FieldOffset(132)]
			public Vector2 contentSize;

			// Token: 0x04002AB6 RID: 10934
			[FieldOffset(140)]
			public Vector2 textureSize;

			// Token: 0x04002AB7 RID: 10935
			[FieldOffset(148)]
			public float texturePixelsPerPoint;

			// Token: 0x04002AB8 RID: 10936
			[FieldOffset(152)]
			public int leftSlice;

			// Token: 0x04002AB9 RID: 10937
			[FieldOffset(156)]
			public int topSlice;

			// Token: 0x04002ABA RID: 10938
			[FieldOffset(160)]
			public int rightSlice;

			// Token: 0x04002ABB RID: 10939
			[FieldOffset(164)]
			public int bottomSlice;

			// Token: 0x04002ABC RID: 10940
			[FieldOffset(168)]
			public float sliceScale;

			// Token: 0x04002ABD RID: 10941
			[FieldOffset(172)]
			public Vector4 rectInset;

			// Token: 0x04002ABE RID: 10942
			[FieldOffset(188)]
			public MeshBuilderNative.NativeColorPage colorPage;
		}
	}
}

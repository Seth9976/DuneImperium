using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Profiling;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements
{
	// Token: 0x0200016F RID: 367
	public class MeshGenerationContext : Object
	{
		// Token: 0x06001B0B RID: 6923 RVA: 0x0007C9B4 File Offset: 0x0007ABB4
		// Note: this type is marked as 'beforefieldinit'.
		static MeshGenerationContext()
		{
			Il2CppClassPointerStore<MeshGenerationContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MeshGenerationContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshGenerationContext>.NativeClassPtr);
			MeshGenerationContext.NativeFieldInfoPtr_m_Painter2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContext>.NativeClassPtr, "m_Painter2D");
			MeshGenerationContext.NativeFieldInfoPtr_s_AllocateMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContext>.NativeClassPtr, "s_AllocateMarker");
			MeshGenerationContext.NativeFieldInfoPtr_s_DrawVectorImageMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContext>.NativeClassPtr, "s_DrawVectorImageMarker");
			MeshGenerationContext.NativeFieldInfoPtr_painter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContext>.NativeClassPtr, "painter");
			MeshGenerationContext.NativeMethodInfoPtr_get_painter2D_Public_get_Painter2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationContext>.NativeClassPtr, 100667259);
			MeshGenerationContext.NativeMethodInfoPtr_get_hasPainter2D_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationContext>.NativeClassPtr, 100667260);
			MeshGenerationContext.NativeMethodInfoPtr__ctor_Internal_Void_IStylePainter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationContext>.NativeClassPtr, 100667261);
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06001B0C RID: 6924 RVA: 0x0007CA70 File Offset: 0x0007AC70
		public unsafe Painter2D painter2D
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 322832, RefRangeEnd = 322834, XrefRangeStart = 322823, XrefRangeEnd = 322832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationContext.NativeMethodInfoPtr_get_painter2D_Public_get_Painter2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Painter2D>(intPtr3) : null;
			}
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06001B0D RID: 6925 RVA: 0x0007CAB0 File Offset: 0x0007ACB0
		public unsafe bool hasPainter2D
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 322834, RefRangeEnd = 322836, XrefRangeStart = 322834, XrefRangeEnd = 322834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationContext.NativeMethodInfoPtr_get_hasPainter2D_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x0007CAEC File Offset: 0x0007ACEC
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 320067, RefRangeEnd = 320078, XrefRangeStart = 320067, XrefRangeEnd = 320078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshGenerationContext(IStylePainter painter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshGenerationContext>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(painter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationContext.NativeMethodInfoPtr__ctor_Internal_Void_IStylePainter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x0000C494 File Offset: 0x0000A694
		public MeshGenerationContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06001B10 RID: 6928 RVA: 0x0007CB38 File Offset: 0x0007AD38
		// (set) Token: 0x06001B11 RID: 6929 RVA: 0x0000C49D File Offset: 0x0000A69D
		public unsafe Painter2D m_Painter2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContext.NativeFieldInfoPtr_m_Painter2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Painter2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContext.NativeFieldInfoPtr_m_Painter2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06001B12 RID: 6930 RVA: 0x0007CB68 File Offset: 0x0007AD68
		// (set) Token: 0x06001B13 RID: 6931 RVA: 0x0000C4BC File Offset: 0x0000A6BC
		public unsafe static ProfilerMarker s_AllocateMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(MeshGenerationContext.NativeFieldInfoPtr_s_AllocateMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MeshGenerationContext.NativeFieldInfoPtr_s_AllocateMarker, (void*)(&value));
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06001B14 RID: 6932 RVA: 0x0007CB84 File Offset: 0x0007AD84
		// (set) Token: 0x06001B15 RID: 6933 RVA: 0x0000C4CA File Offset: 0x0000A6CA
		public unsafe static ProfilerMarker s_DrawVectorImageMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(MeshGenerationContext.NativeFieldInfoPtr_s_DrawVectorImageMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MeshGenerationContext.NativeFieldInfoPtr_s_DrawVectorImageMarker, (void*)(&value));
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06001B16 RID: 6934 RVA: 0x0007CBA0 File Offset: 0x0007ADA0
		// (set) Token: 0x06001B17 RID: 6935 RVA: 0x0000C4D8 File Offset: 0x0000A6D8
		public unsafe IStylePainter painter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContext.NativeFieldInfoPtr_painter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStylePainter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContext.NativeFieldInfoPtr_painter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06001B18 RID: 6936 RVA: 0x0007CBD0 File Offset: 0x0007ADD0
		public VisualElement visualElement
		{
			get
			{
				return this.painter.visualElement;
			}
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x0007CBF0 File Offset: 0x0007ADF0
		public MeshWriteData Allocate(int vertexCount, int indexCount, [Optional] Texture texture)
		{
			MeshWriteData meshWriteData;
			using (MeshGenerationContext.s_AllocateMarker.Auto())
			{
				meshWriteData = this.painter.DrawMesh(vertexCount, indexCount, texture, null, MeshGenerationContext.MeshFlags.None);
			}
			return meshWriteData;
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x0007CC40 File Offset: 0x0007AE40
		public MeshWriteData Allocate(int vertexCount, int indexCount, Texture texture, Material material, MeshGenerationContext.MeshFlags flags)
		{
			MeshWriteData meshWriteData;
			using (MeshGenerationContext.s_AllocateMarker.Auto())
			{
				meshWriteData = this.painter.DrawMesh(vertexCount, indexCount, texture, material, flags);
			}
			return meshWriteData;
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x0007CC94 File Offset: 0x0007AE94
		public void DrawVectorImage(VectorImage vectorImage, Vector2 offset, Angle rotationAngle, Vector2 scale)
		{
			using (MeshGenerationContext.s_DrawVectorImageMarker.Auto())
			{
				this.painter.DrawVectorImage(vectorImage, offset, rotationAngle, scale);
			}
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x0007CCE4 File Offset: 0x0007AEE4
		public void DrawText(string text, Vector2 pos, float fontSize, Color color, [Optional] FontAsset font)
		{
			bool flag = font == null;
			if (flag)
			{
				font = TextUtilities.GetFontAsset(this.visualElement);
			}
			this.painter.DrawText(text, pos, fontSize, color, font);
		}

		// Token: 0x040012C6 RID: 4806
		private static readonly IntPtr NativeFieldInfoPtr_m_Painter2D;

		// Token: 0x040012C7 RID: 4807
		private static readonly IntPtr NativeFieldInfoPtr_s_AllocateMarker;

		// Token: 0x040012C8 RID: 4808
		private static readonly IntPtr NativeFieldInfoPtr_s_DrawVectorImageMarker;

		// Token: 0x040012C9 RID: 4809
		private static readonly IntPtr NativeFieldInfoPtr_painter;

		// Token: 0x040012CA RID: 4810
		private static readonly IntPtr NativeMethodInfoPtr_get_painter2D_Public_get_Painter2D_0;

		// Token: 0x040012CB RID: 4811
		private static readonly IntPtr NativeMethodInfoPtr_get_hasPainter2D_Internal_get_Boolean_0;

		// Token: 0x040012CC RID: 4812
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IStylePainter_0;

		// Token: 0x02000497 RID: 1175
		[Flags]
		public enum MeshFlags
		{
			// Token: 0x04002B1E RID: 11038
			None = 0,
			// Token: 0x04002B1F RID: 11039
			UVisDisplacement = 1,
			// Token: 0x04002B20 RID: 11040
			SkipDynamicAtlas = 2
		}
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Profiling;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements
{
	// Token: 0x02000170 RID: 368
	public class Painter2D : Object
	{
		// Token: 0x06001B1D RID: 6941 RVA: 0x0007CD20 File Offset: 0x0007AF20
		// Note: this type is marked as 'beforefieldinit'.
		static Painter2D()
		{
			Il2CppClassPointerStore<Painter2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Painter2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Painter2D>.NativeClassPtr);
			Painter2D.NativeFieldInfoPtr_m_Ctx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Painter2D>.NativeClassPtr, "m_Ctx");
			Painter2D.NativeFieldInfoPtr_m_DetachedAllocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Painter2D>.NativeClassPtr, "m_DetachedAllocator");
			Painter2D.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Painter2D>.NativeClassPtr, "m_Handle");
			Painter2D.NativeFieldInfoPtr_m_Disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Painter2D>.NativeClassPtr, "m_Disposed");
			Painter2D.NativeFieldInfoPtr__isPainterActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Painter2D>.NativeClassPtr, "<isPainterActive>k__BackingField");
			Painter2D.NativeFieldInfoPtr_s_MaxArcRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Painter2D>.NativeClassPtr, "s_MaxArcRadius");
			Painter2D.NativeFieldInfoPtr_s_StrokeMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Painter2D>.NativeClassPtr, "s_StrokeMarker");
			Painter2D.NativeFieldInfoPtr_s_FillMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Painter2D>.NativeClassPtr, "s_FillMarker");
			Painter2D.NativeMethodInfoPtr__ctor_Internal_Void_MeshGenerationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Painter2D>.NativeClassPtr, 100667263);
			Painter2D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Painter2D>.NativeClassPtr, 100667264);
			Painter2D.NativeMethodInfoPtr_Reset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Painter2D>.NativeClassPtr, 100667265);
			Painter2D.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Painter2D>.NativeClassPtr, 100667266);
			Painter2D.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Painter2D>.NativeClassPtr, 100667267);
			Painter2D.NativeMethodInfoPtr_set_isPainterActive_Internal_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Painter2D>.NativeClassPtr, 100667268);
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x0007CE68 File Offset: 0x0007B068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322836, XrefRangeEnd = 322846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Painter2D(MeshGenerationContext ctx)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Painter2D>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Painter2D.NativeMethodInfoPtr__ctor_Internal_Void_MeshGenerationContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x0007CEB4 File Offset: 0x0007B0B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322846, XrefRangeEnd = 322867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Painter2D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Painter2D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Painter2D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x0007CEF0 File Offset: 0x0007B0F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322884, RefRangeEnd = 322885, XrefRangeStart = 322867, XrefRangeEnd = 322884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Painter2D.NativeMethodInfoPtr_Reset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x0007CF24 File Offset: 0x0007B124
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322893, RefRangeEnd = 322894, XrefRangeStart = 322885, XrefRangeEnd = 322893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Painter2D.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x0007CF58 File Offset: 0x0007B158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322894, XrefRangeEnd = 322898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Painter2D.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06001B46 RID: 6982 RVA: 0x0000C6C1 File Offset: 0x0000A8C1
		// (set) Token: 0x06001B23 RID: 6947 RVA: 0x0007CF98 File Offset: 0x0007B198
		public unsafe static bool isPainterActive
		{
			get
			{
				return Painter2D._isPainterActive_k__BackingField;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322898, XrefRangeEnd = 322902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Painter2D.NativeMethodInfoPtr_set_isPainterActive_Internal_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x0000C4F7 File Offset: 0x0000A6F7
		public Painter2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06001B25 RID: 6949 RVA: 0x0007CFCC File Offset: 0x0007B1CC
		// (set) Token: 0x06001B26 RID: 6950 RVA: 0x0000C500 File Offset: 0x0000A700
		public unsafe MeshGenerationContext m_Ctx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Painter2D.NativeFieldInfoPtr_m_Ctx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshGenerationContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Painter2D.NativeFieldInfoPtr_m_Ctx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06001B27 RID: 6951 RVA: 0x0007CFFC File Offset: 0x0007B1FC
		// (set) Token: 0x06001B28 RID: 6952 RVA: 0x0000C51F File Offset: 0x0000A71F
		public unsafe UnityEngine.UIElements.UIR.DetachedAllocator m_DetachedAllocator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Painter2D.NativeFieldInfoPtr_m_DetachedAllocator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.UIElements.UIR.DetachedAllocator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Painter2D.NativeFieldInfoPtr_m_DetachedAllocator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06001B29 RID: 6953 RVA: 0x0007D02C File Offset: 0x0007B22C
		// (set) Token: 0x06001B2A RID: 6954 RVA: 0x0000C53E File Offset: 0x0000A73E
		public unsafe SafeHandleAccess m_Handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Painter2D.NativeFieldInfoPtr_m_Handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Painter2D.NativeFieldInfoPtr_m_Handle)) = value;
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06001B2B RID: 6955 RVA: 0x0007D054 File Offset: 0x0007B254
		// (set) Token: 0x06001B2C RID: 6956 RVA: 0x0000C559 File Offset: 0x0000A759
		public unsafe bool m_Disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Painter2D.NativeFieldInfoPtr_m_Disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Painter2D.NativeFieldInfoPtr_m_Disposed)) = value;
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06001B2D RID: 6957 RVA: 0x0007D07C File Offset: 0x0007B27C
		// (set) Token: 0x06001B2E RID: 6958 RVA: 0x0000C574 File Offset: 0x0000A774
		public unsafe static bool _isPainterActive_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Painter2D.NativeFieldInfoPtr__isPainterActive_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Painter2D.NativeFieldInfoPtr__isPainterActive_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06001B2F RID: 6959 RVA: 0x0007D098 File Offset: 0x0007B298
		// (set) Token: 0x06001B30 RID: 6960 RVA: 0x0000C582 File Offset: 0x0000A782
		public unsafe static float s_MaxArcRadius
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Painter2D.NativeFieldInfoPtr_s_MaxArcRadius, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Painter2D.NativeFieldInfoPtr_s_MaxArcRadius, (void*)(&value));
			}
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06001B31 RID: 6961 RVA: 0x0007D0B4 File Offset: 0x0007B2B4
		// (set) Token: 0x06001B32 RID: 6962 RVA: 0x0000C590 File Offset: 0x0000A790
		public unsafe static ProfilerMarker s_StrokeMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(Painter2D.NativeFieldInfoPtr_s_StrokeMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Painter2D.NativeFieldInfoPtr_s_StrokeMarker, (void*)(&value));
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06001B33 RID: 6963 RVA: 0x0007D0D0 File Offset: 0x0007B2D0
		// (set) Token: 0x06001B34 RID: 6964 RVA: 0x0000C59E File Offset: 0x0000A79E
		public unsafe static ProfilerMarker s_FillMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(Painter2D.NativeFieldInfoPtr_s_FillMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Painter2D.NativeFieldInfoPtr_s_FillMarker, (void*)(&value));
			}
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06001B35 RID: 6965 RVA: 0x0000C5AC File Offset: 0x0000A7AC
		public bool isDetached
		{
			get
			{
				return this.m_DetachedAllocator != null;
			}
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x0007D0EC File Offset: 0x0007B2EC
		public MeshWriteData Allocate(int vertexCount, int indexCount)
		{
			bool isDetached = this.isDetached;
			MeshWriteData meshWriteData;
			if (isDetached)
			{
				meshWriteData = this.m_DetachedAllocator.Alloc(vertexCount, indexCount);
			}
			else
			{
				meshWriteData = this.m_Ctx.Allocate(vertexCount, indexCount, null);
			}
			return meshWriteData;
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x0007D128 File Offset: 0x0007B328
		public void Clear()
		{
			bool flag = !this.isDetached;
			if (flag)
			{
				Debug.LogError("Clear() cannot be called on a Painter2D associated with a MeshGenerationContext. You should create your own instance of Painter2D instead.");
			}
			else
			{
				this.m_DetachedAllocator.Clear();
				this.Reset();
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06001B38 RID: 6968 RVA: 0x0000C5B7 File Offset: 0x0000A7B7
		// (set) Token: 0x06001B39 RID: 6969 RVA: 0x0000C5C9 File Offset: 0x0000A7C9
		public float lineWidth
		{
			get
			{
				return UIPainter2D.GetLineWidth(this.m_Handle);
			}
			set
			{
				UIPainter2D.SetLineWidth(this.m_Handle, value);
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06001B3A RID: 6970 RVA: 0x0000C5DD File Offset: 0x0000A7DD
		// (set) Token: 0x06001B3B RID: 6971 RVA: 0x0000C5EF File Offset: 0x0000A7EF
		public Color strokeColor
		{
			get
			{
				return UIPainter2D.GetStrokeColor(this.m_Handle);
			}
			set
			{
				UIPainter2D.SetStrokeColor(this.m_Handle, value);
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06001B3C RID: 6972 RVA: 0x0000C603 File Offset: 0x0000A803
		// (set) Token: 0x06001B3D RID: 6973 RVA: 0x0000C615 File Offset: 0x0000A815
		public Gradient strokeGradient
		{
			get
			{
				return UIPainter2D.GetStrokeGradient(this.m_Handle);
			}
			set
			{
				UIPainter2D.SetStrokeGradient(this.m_Handle, value);
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06001B3E RID: 6974 RVA: 0x0000C629 File Offset: 0x0000A829
		// (set) Token: 0x06001B3F RID: 6975 RVA: 0x0000C63B File Offset: 0x0000A83B
		public Color fillColor
		{
			get
			{
				return UIPainter2D.GetFillColor(this.m_Handle);
			}
			set
			{
				UIPainter2D.SetFillColor(this.m_Handle, value);
			}
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06001B40 RID: 6976 RVA: 0x0000C64F File Offset: 0x0000A84F
		// (set) Token: 0x06001B41 RID: 6977 RVA: 0x0000C661 File Offset: 0x0000A861
		public LineJoin lineJoin
		{
			get
			{
				return UIPainter2D.GetLineJoin(this.m_Handle);
			}
			set
			{
				UIPainter2D.SetLineJoin(this.m_Handle, value);
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06001B42 RID: 6978 RVA: 0x0000C675 File Offset: 0x0000A875
		// (set) Token: 0x06001B43 RID: 6979 RVA: 0x0000C687 File Offset: 0x0000A887
		public LineCap lineCap
		{
			get
			{
				return UIPainter2D.GetLineCap(this.m_Handle);
			}
			set
			{
				UIPainter2D.SetLineCap(this.m_Handle, value);
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06001B44 RID: 6980 RVA: 0x0000C69B File Offset: 0x0000A89B
		// (set) Token: 0x06001B45 RID: 6981 RVA: 0x0000C6AD File Offset: 0x0000A8AD
		public float miterLimit
		{
			get
			{
				return UIPainter2D.GetMiterLimit(this.m_Handle);
			}
			set
			{
				UIPainter2D.SetMiterLimit(this.m_Handle, value);
			}
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x0007D164 File Offset: 0x0007B364
		public bool ValidateState()
		{
			bool flag = this.isDetached || Painter2D.isPainterActive;
			bool flag2 = !flag;
			if (flag2)
			{
				Debug.LogError("Cannot issue vector graphics commands outside of generateVisualContent callback");
			}
			return flag;
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06001B48 RID: 6984 RVA: 0x0007D19C File Offset: 0x0007B39C
		public static float maxArcRadius
		{
			get
			{
				bool flag = Painter2D.s_MaxArcRadius < 0f;
				if (flag)
				{
					bool flag2 = !UnityEngine.UIElements.UIR.UIRenderDevice.vertexTexturingIsAvailable;
					if (flag2)
					{
						Painter2D.s_MaxArcRadius = 1000f;
					}
					else
					{
						Painter2D.s_MaxArcRadius = 100000f;
					}
				}
				return Painter2D.s_MaxArcRadius;
			}
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x0007D1E8 File Offset: 0x0007B3E8
		public void BeginPath()
		{
			bool flag = !this.ValidateState();
			if (!flag)
			{
				UIPainter2D.BeginPath(this.m_Handle);
			}
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x0007D218 File Offset: 0x0007B418
		public void ClosePath()
		{
			bool flag = !this.ValidateState();
			if (!flag)
			{
				UIPainter2D.ClosePath(this.m_Handle);
			}
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x0007D248 File Offset: 0x0007B448
		public void MoveTo(Vector2 pos)
		{
			bool flag = !this.ValidateState();
			if (!flag)
			{
				UIPainter2D.MoveTo(this.m_Handle, pos);
			}
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x0007D278 File Offset: 0x0007B478
		public void LineTo(Vector2 pos)
		{
			bool flag = !this.ValidateState();
			if (!flag)
			{
				UIPainter2D.LineTo(this.m_Handle, pos);
			}
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x0007D2A8 File Offset: 0x0007B4A8
		public void ArcTo(Vector2 p1, Vector2 p2, float radius)
		{
			bool flag = !this.ValidateState();
			if (!flag)
			{
				UIPainter2D.ArcTo(this.m_Handle, p1, p2, radius);
			}
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x0007D2DC File Offset: 0x0007B4DC
		public void Arc(Vector2 center, float radius, Angle startAngle, Angle endAngle, [Optional] ArcDirection direction)
		{
			bool flag = !this.ValidateState();
			if (!flag)
			{
				UIPainter2D.Arc(this.m_Handle, center, radius, startAngle.ToRadians(), endAngle.ToRadians(), direction);
			}
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x0007D31C File Offset: 0x0007B51C
		public void BezierCurveTo(Vector2 p1, Vector2 p2, Vector2 p3)
		{
			bool flag = !this.ValidateState();
			if (!flag)
			{
				UIPainter2D.BezierCurveTo(this.m_Handle, p1, p2, p3);
			}
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x0007D350 File Offset: 0x0007B550
		public void QuadraticCurveTo(Vector2 p1, Vector2 p2)
		{
			bool flag = !this.ValidateState();
			if (!flag)
			{
				UIPainter2D.QuadraticCurveTo(this.m_Handle, p1, p2);
			}
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x0007D380 File Offset: 0x0007B580
		public unsafe void Stroke()
		{
			using (Painter2D.s_StrokeMarker.Auto())
			{
				bool flag = !this.ValidateState();
				if (!flag)
				{
					MeshWriteDataInterface meshWriteDataInterface = UIPainter2D.Stroke(this.m_Handle);
					bool flag2 = meshWriteDataInterface.vertexCount == 0;
					if (!flag2)
					{
						MeshWriteData meshWriteData = this.Allocate(meshWriteDataInterface.vertexCount, meshWriteDataInterface.indexCount);
						NativeSlice<Vertex> nativeSlice = UnityEngine.UIElements.UIR.UIRenderDevice.PtrToSlice<Vertex>((void*)meshWriteDataInterface.vertices, meshWriteDataInterface.vertexCount);
						NativeSlice<ushort> nativeSlice2 = UnityEngine.UIElements.UIR.UIRenderDevice.PtrToSlice<ushort>((void*)meshWriteDataInterface.indices, meshWriteDataInterface.indexCount);
						meshWriteData.SetAllVertices(nativeSlice);
						meshWriteData.SetAllIndices(nativeSlice2);
					}
				}
			}
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x0007D44C File Offset: 0x0007B64C
		public unsafe void Fill([Optional] FillRule fillRule)
		{
			using (Painter2D.s_FillMarker.Auto())
			{
				bool flag = !this.ValidateState();
				if (!flag)
				{
					MeshWriteDataInterface meshWriteDataInterface = UIPainter2D.Fill(this.m_Handle, fillRule);
					bool flag2 = meshWriteDataInterface.vertexCount == 0;
					if (!flag2)
					{
						MeshWriteData meshWriteData = this.Allocate(meshWriteDataInterface.vertexCount, meshWriteDataInterface.indexCount);
						NativeSlice<Vertex> nativeSlice = UnityEngine.UIElements.UIR.UIRenderDevice.PtrToSlice<Vertex>((void*)meshWriteDataInterface.vertices, meshWriteDataInterface.vertexCount);
						NativeSlice<ushort> nativeSlice2 = UnityEngine.UIElements.UIR.UIRenderDevice.PtrToSlice<ushort>((void*)meshWriteDataInterface.indices, meshWriteDataInterface.indexCount);
						meshWriteData.SetAllVertices(nativeSlice);
						meshWriteData.SetAllIndices(nativeSlice2);
					}
				}
			}
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x0000C6C8 File Offset: 0x0000A8C8
		public bool SaveToVectorImage(VectorImage vectorImage)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040012CD RID: 4813
		private static readonly IntPtr NativeFieldInfoPtr_m_Ctx;

		// Token: 0x040012CE RID: 4814
		private static readonly IntPtr NativeFieldInfoPtr_m_DetachedAllocator;

		// Token: 0x040012CF RID: 4815
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x040012D0 RID: 4816
		private static readonly IntPtr NativeFieldInfoPtr_m_Disposed;

		// Token: 0x040012D1 RID: 4817
		private static readonly IntPtr NativeFieldInfoPtr__isPainterActive_k__BackingField;

		// Token: 0x040012D2 RID: 4818
		private static readonly IntPtr NativeFieldInfoPtr_s_MaxArcRadius;

		// Token: 0x040012D3 RID: 4819
		private static readonly IntPtr NativeFieldInfoPtr_s_StrokeMarker;

		// Token: 0x040012D4 RID: 4820
		private static readonly IntPtr NativeFieldInfoPtr_s_FillMarker;

		// Token: 0x040012D5 RID: 4821
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_MeshGenerationContext_0;

		// Token: 0x040012D6 RID: 4822
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040012D7 RID: 4823
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Void_0;

		// Token: 0x040012D8 RID: 4824
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040012D9 RID: 4825
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

		// Token: 0x040012DA RID: 4826
		private static readonly IntPtr NativeMethodInfoPtr_set_isPainterActive_Internal_Static_set_Void_Boolean_0;
	}
}

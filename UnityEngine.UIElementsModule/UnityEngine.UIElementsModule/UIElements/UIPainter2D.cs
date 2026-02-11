using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200014F RID: 335
	public static class UIPainter2D : Object
	{
		// Token: 0x06001877 RID: 6263 RVA: 0x00073AD4 File Offset: 0x00071CD4
		// Note: this type is marked as 'beforefieldinit'.
		static UIPainter2D()
		{
			Il2CppClassPointerStore<UIPainter2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UIPainter2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPainter2D>.NativeClassPtr);
			UIPainter2D.NativeMethodInfoPtr_Create_Public_Static_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPainter2D>.NativeClassPtr, 100666922);
			UIPainter2D.NativeMethodInfoPtr_Destroy_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPainter2D>.NativeClassPtr, 100666923);
			UIPainter2D.NativeMethodInfoPtr_Reset_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPainter2D>.NativeClassPtr, 100666924);
			UIPainter2D.GetLineWidthDelegateField = IL2CPP.ResolveICall<UIPainter2D.GetLineWidthDelegate>("UnityEngine.UIElements.UIPainter2D::GetLineWidth");
			UIPainter2D.SetLineWidthDelegateField = IL2CPP.ResolveICall<UIPainter2D.SetLineWidthDelegate>("UnityEngine.UIElements.UIPainter2D::SetLineWidth");
			UIPainter2D.GetStrokeGradientDelegateField = IL2CPP.ResolveICall<UIPainter2D.GetStrokeGradientDelegate>("UnityEngine.UIElements.UIPainter2D::GetStrokeGradient");
			UIPainter2D.SetStrokeGradientDelegateField = IL2CPP.ResolveICall<UIPainter2D.SetStrokeGradientDelegate>("UnityEngine.UIElements.UIPainter2D::SetStrokeGradient");
			UIPainter2D.GetLineJoinDelegateField = IL2CPP.ResolveICall<UIPainter2D.GetLineJoinDelegate>("UnityEngine.UIElements.UIPainter2D::GetLineJoin");
			UIPainter2D.SetLineJoinDelegateField = IL2CPP.ResolveICall<UIPainter2D.SetLineJoinDelegate>("UnityEngine.UIElements.UIPainter2D::SetLineJoin");
			UIPainter2D.GetLineCapDelegateField = IL2CPP.ResolveICall<UIPainter2D.GetLineCapDelegate>("UnityEngine.UIElements.UIPainter2D::GetLineCap");
			UIPainter2D.SetLineCapDelegateField = IL2CPP.ResolveICall<UIPainter2D.SetLineCapDelegate>("UnityEngine.UIElements.UIPainter2D::SetLineCap");
			UIPainter2D.GetMiterLimitDelegateField = IL2CPP.ResolveICall<UIPainter2D.GetMiterLimitDelegate>("UnityEngine.UIElements.UIPainter2D::GetMiterLimit");
			UIPainter2D.SetMiterLimitDelegateField = IL2CPP.ResolveICall<UIPainter2D.SetMiterLimitDelegate>("UnityEngine.UIElements.UIPainter2D::SetMiterLimit");
			UIPainter2D.BeginPathDelegateField = IL2CPP.ResolveICall<UIPainter2D.BeginPathDelegate>("UnityEngine.UIElements.UIPainter2D::BeginPath");
			UIPainter2D.ClosePathDelegateField = IL2CPP.ResolveICall<UIPainter2D.ClosePathDelegate>("UnityEngine.UIElements.UIPainter2D::ClosePath");
			UIPainter2D.GetStrokeColor_InjectedDelegateField = IL2CPP.ResolveICall<UIPainter2D.GetStrokeColor_InjectedDelegate>("UnityEngine.UIElements.UIPainter2D::GetStrokeColor_Injected");
			UIPainter2D.SetStrokeColor_InjectedDelegateField = IL2CPP.ResolveICall<UIPainter2D.SetStrokeColor_InjectedDelegate>("UnityEngine.UIElements.UIPainter2D::SetStrokeColor_Injected");
			UIPainter2D.GetFillColor_InjectedDelegateField = IL2CPP.ResolveICall<UIPainter2D.GetFillColor_InjectedDelegate>("UnityEngine.UIElements.UIPainter2D::GetFillColor_Injected");
			UIPainter2D.SetFillColor_InjectedDelegateField = IL2CPP.ResolveICall<UIPainter2D.SetFillColor_InjectedDelegate>("UnityEngine.UIElements.UIPainter2D::SetFillColor_Injected");
			UIPainter2D.MoveTo_InjectedDelegateField = IL2CPP.ResolveICall<UIPainter2D.MoveTo_InjectedDelegate>("UnityEngine.UIElements.UIPainter2D::MoveTo_Injected");
			UIPainter2D.LineTo_InjectedDelegateField = IL2CPP.ResolveICall<UIPainter2D.LineTo_InjectedDelegate>("UnityEngine.UIElements.UIPainter2D::LineTo_Injected");
			UIPainter2D.ArcTo_InjectedDelegateField = IL2CPP.ResolveICall<UIPainter2D.ArcTo_InjectedDelegate>("UnityEngine.UIElements.UIPainter2D::ArcTo_Injected");
			UIPainter2D.Arc_InjectedDelegateField = IL2CPP.ResolveICall<UIPainter2D.Arc_InjectedDelegate>("UnityEngine.UIElements.UIPainter2D::Arc_Injected");
			UIPainter2D.BezierCurveTo_InjectedDelegateField = IL2CPP.ResolveICall<UIPainter2D.BezierCurveTo_InjectedDelegate>("UnityEngine.UIElements.UIPainter2D::BezierCurveTo_Injected");
			UIPainter2D.QuadraticCurveTo_InjectedDelegateField = IL2CPP.ResolveICall<UIPainter2D.QuadraticCurveTo_InjectedDelegate>("UnityEngine.UIElements.UIPainter2D::QuadraticCurveTo_Injected");
			UIPainter2D.GetBBox_InjectedDelegateField = IL2CPP.ResolveICall<UIPainter2D.GetBBox_InjectedDelegate>("UnityEngine.UIElements.UIPainter2D::GetBBox_Injected");
			UIPainter2D.Stroke_InjectedDelegateField = IL2CPP.ResolveICall<UIPainter2D.Stroke_InjectedDelegate>("UnityEngine.UIElements.UIPainter2D::Stroke_Injected");
			UIPainter2D.Fill_InjectedDelegateField = IL2CPP.ResolveICall<UIPainter2D.Fill_InjectedDelegate>("UnityEngine.UIElements.UIPainter2D::Fill_Injected");
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x00073CB8 File Offset: 0x00071EB8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 320315, RefRangeEnd = 320318, XrefRangeStart = 320313, XrefRangeEnd = 320315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Create(bool computeBBox = false)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref computeBBox;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPainter2D.NativeMethodInfoPtr_Create_Public_Static_IntPtr_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x00073CF8 File Offset: 0x00071EF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 320320, RefRangeEnd = 320322, XrefRangeStart = 320318, XrefRangeEnd = 320320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Destroy(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPainter2D.NativeMethodInfoPtr_Destroy_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x00073D2C File Offset: 0x00071F2C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 320324, RefRangeEnd = 320328, XrefRangeStart = 320322, XrefRangeEnd = 320324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Reset(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPainter2D.NativeMethodInfoPtr_Reset_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x0000B36D File Offset: 0x0000956D
		public UIPainter2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x0000B376 File Offset: 0x00009576
		public static float GetLineWidth(IntPtr handle)
		{
			return UIPainter2D.GetLineWidthDelegateField(handle);
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x0000B383 File Offset: 0x00009583
		public static void SetLineWidth(IntPtr handle, float value)
		{
			UIPainter2D.SetLineWidthDelegateField(handle, value);
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x00073D60 File Offset: 0x00071F60
		public static Color GetStrokeColor(IntPtr handle)
		{
			Color color;
			UIPainter2D.GetStrokeColor_Injected(handle, out color);
			return color;
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x0000B391 File Offset: 0x00009591
		public static void SetStrokeColor(IntPtr handle, Color value)
		{
			UIPainter2D.SetStrokeColor_Injected(handle, ref value);
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x00073D78 File Offset: 0x00071F78
		public static Gradient GetStrokeGradient(IntPtr handle)
		{
			IntPtr intPtr = UIPainter2D.GetStrokeGradientDelegateField(handle);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x0000B39B File Offset: 0x0000959B
		public static void SetStrokeGradient(IntPtr handle, Gradient gradient)
		{
			UIPainter2D.SetStrokeGradientDelegateField(handle, IL2CPP.Il2CppObjectBaseToPtr(gradient));
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x00073DA0 File Offset: 0x00071FA0
		public static Color GetFillColor(IntPtr handle)
		{
			Color color;
			UIPainter2D.GetFillColor_Injected(handle, out color);
			return color;
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x0000B3AE File Offset: 0x000095AE
		public static void SetFillColor(IntPtr handle, Color value)
		{
			UIPainter2D.SetFillColor_Injected(handle, ref value);
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x0000B3B8 File Offset: 0x000095B8
		public static LineJoin GetLineJoin(IntPtr handle)
		{
			return UIPainter2D.GetLineJoinDelegateField(handle);
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x0000B3C5 File Offset: 0x000095C5
		public static void SetLineJoin(IntPtr handle, LineJoin value)
		{
			UIPainter2D.SetLineJoinDelegateField(handle, value);
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x0000B3D3 File Offset: 0x000095D3
		public static LineCap GetLineCap(IntPtr handle)
		{
			return UIPainter2D.GetLineCapDelegateField(handle);
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x0000B3E0 File Offset: 0x000095E0
		public static void SetLineCap(IntPtr handle, LineCap value)
		{
			UIPainter2D.SetLineCapDelegateField(handle, value);
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x0000B3EE File Offset: 0x000095EE
		public static float GetMiterLimit(IntPtr handle)
		{
			return UIPainter2D.GetMiterLimitDelegateField(handle);
		}

		// Token: 0x06001889 RID: 6281 RVA: 0x0000B3FB File Offset: 0x000095FB
		public static void SetMiterLimit(IntPtr handle, float value)
		{
			UIPainter2D.SetMiterLimitDelegateField(handle, value);
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x0000B409 File Offset: 0x00009609
		public static void BeginPath(IntPtr handle)
		{
			UIPainter2D.BeginPathDelegateField(handle);
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x0000B416 File Offset: 0x00009616
		public static void MoveTo(IntPtr handle, Vector2 pos)
		{
			UIPainter2D.MoveTo_Injected(handle, ref pos);
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x0000B420 File Offset: 0x00009620
		public static void LineTo(IntPtr handle, Vector2 pos)
		{
			UIPainter2D.LineTo_Injected(handle, ref pos);
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x0000B42A File Offset: 0x0000962A
		public static void ArcTo(IntPtr handle, Vector2 p1, Vector2 p2, float radius)
		{
			UIPainter2D.ArcTo_Injected(handle, ref p1, ref p2, radius);
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x0000B437 File Offset: 0x00009637
		public static void Arc(IntPtr handle, Vector2 center, float radius, float startAngleRads, float endAngleRads, ArcDirection direction)
		{
			UIPainter2D.Arc_Injected(handle, ref center, radius, startAngleRads, endAngleRads, direction);
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x0000B447 File Offset: 0x00009647
		public static void BezierCurveTo(IntPtr handle, Vector2 p1, Vector2 p2, Vector2 p3)
		{
			UIPainter2D.BezierCurveTo_Injected(handle, ref p1, ref p2, ref p3);
		}

		// Token: 0x06001890 RID: 6288 RVA: 0x0000B455 File Offset: 0x00009655
		public static void QuadraticCurveTo(IntPtr handle, Vector2 p1, Vector2 p2)
		{
			UIPainter2D.QuadraticCurveTo_Injected(handle, ref p1, ref p2);
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x0000B461 File Offset: 0x00009661
		public static void ClosePath(IntPtr handle)
		{
			UIPainter2D.ClosePathDelegateField(handle);
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x00073DB8 File Offset: 0x00071FB8
		public static Rect GetBBox(IntPtr handle)
		{
			Rect rect;
			UIPainter2D.GetBBox_Injected(handle, out rect);
			return rect;
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x00073DD0 File Offset: 0x00071FD0
		public static MeshWriteDataInterface Stroke(IntPtr handle)
		{
			MeshWriteDataInterface meshWriteDataInterface;
			UIPainter2D.Stroke_Injected(handle, out meshWriteDataInterface);
			return meshWriteDataInterface;
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x00073DE8 File Offset: 0x00071FE8
		public static MeshWriteDataInterface Fill(IntPtr handle, FillRule fillRule)
		{
			MeshWriteDataInterface meshWriteDataInterface;
			UIPainter2D.Fill_Injected(handle, fillRule, out meshWriteDataInterface);
			return meshWriteDataInterface;
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x0000B46E File Offset: 0x0000966E
		public static void GetStrokeColor_Injected(IntPtr handle, out Color ret)
		{
			UIPainter2D.GetStrokeColor_InjectedDelegateField(handle, out ret);
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x0000B47C File Offset: 0x0000967C
		public static void SetStrokeColor_Injected(IntPtr handle, ref Color value)
		{
			UIPainter2D.SetStrokeColor_InjectedDelegateField(handle, ref value);
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x0000B48A File Offset: 0x0000968A
		public static void GetFillColor_Injected(IntPtr handle, out Color ret)
		{
			UIPainter2D.GetFillColor_InjectedDelegateField(handle, out ret);
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x0000B498 File Offset: 0x00009698
		public static void SetFillColor_Injected(IntPtr handle, ref Color value)
		{
			UIPainter2D.SetFillColor_InjectedDelegateField(handle, ref value);
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x0000B4A6 File Offset: 0x000096A6
		public static void MoveTo_Injected(IntPtr handle, ref Vector2 pos)
		{
			UIPainter2D.MoveTo_InjectedDelegateField(handle, ref pos);
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x0000B4B4 File Offset: 0x000096B4
		public static void LineTo_Injected(IntPtr handle, ref Vector2 pos)
		{
			UIPainter2D.LineTo_InjectedDelegateField(handle, ref pos);
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x0000B4C2 File Offset: 0x000096C2
		public static void ArcTo_Injected(IntPtr handle, ref Vector2 p1, ref Vector2 p2, float radius)
		{
			UIPainter2D.ArcTo_InjectedDelegateField(handle, ref p1, ref p2, radius);
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x0000B4D2 File Offset: 0x000096D2
		public static void Arc_Injected(IntPtr handle, ref Vector2 center, float radius, float startAngleRads, float endAngleRads, ArcDirection direction)
		{
			UIPainter2D.Arc_InjectedDelegateField(handle, ref center, radius, startAngleRads, endAngleRads, direction);
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x0000B4E6 File Offset: 0x000096E6
		public static void BezierCurveTo_Injected(IntPtr handle, ref Vector2 p1, ref Vector2 p2, ref Vector2 p3)
		{
			UIPainter2D.BezierCurveTo_InjectedDelegateField(handle, ref p1, ref p2, ref p3);
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x0000B4F6 File Offset: 0x000096F6
		public static void QuadraticCurveTo_Injected(IntPtr handle, ref Vector2 p1, ref Vector2 p2)
		{
			UIPainter2D.QuadraticCurveTo_InjectedDelegateField(handle, ref p1, ref p2);
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x0000B505 File Offset: 0x00009705
		public static void GetBBox_Injected(IntPtr handle, out Rect ret)
		{
			UIPainter2D.GetBBox_InjectedDelegateField(handle, out ret);
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x0000B513 File Offset: 0x00009713
		public static void Stroke_Injected(IntPtr handle, out MeshWriteDataInterface ret)
		{
			UIPainter2D.Stroke_InjectedDelegateField(handle, out ret);
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x0000B521 File Offset: 0x00009721
		public static void Fill_Injected(IntPtr handle, FillRule fillRule, out MeshWriteDataInterface ret)
		{
			UIPainter2D.Fill_InjectedDelegateField(handle, fillRule, out ret);
		}

		// Token: 0x040010D0 RID: 4304
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_IntPtr_Boolean_0;

		// Token: 0x040010D1 RID: 4305
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_IntPtr_0;

		// Token: 0x040010D2 RID: 4306
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Static_Void_IntPtr_0;

		// Token: 0x040010D3 RID: 4307
		private static readonly UIPainter2D.GetLineWidthDelegate GetLineWidthDelegateField;

		// Token: 0x040010D4 RID: 4308
		private static readonly UIPainter2D.SetLineWidthDelegate SetLineWidthDelegateField;

		// Token: 0x040010D5 RID: 4309
		private static readonly UIPainter2D.GetStrokeGradientDelegate GetStrokeGradientDelegateField;

		// Token: 0x040010D6 RID: 4310
		private static readonly UIPainter2D.SetStrokeGradientDelegate SetStrokeGradientDelegateField;

		// Token: 0x040010D7 RID: 4311
		private static readonly UIPainter2D.GetLineJoinDelegate GetLineJoinDelegateField;

		// Token: 0x040010D8 RID: 4312
		private static readonly UIPainter2D.SetLineJoinDelegate SetLineJoinDelegateField;

		// Token: 0x040010D9 RID: 4313
		private static readonly UIPainter2D.GetLineCapDelegate GetLineCapDelegateField;

		// Token: 0x040010DA RID: 4314
		private static readonly UIPainter2D.SetLineCapDelegate SetLineCapDelegateField;

		// Token: 0x040010DB RID: 4315
		private static readonly UIPainter2D.GetMiterLimitDelegate GetMiterLimitDelegateField;

		// Token: 0x040010DC RID: 4316
		private static readonly UIPainter2D.SetMiterLimitDelegate SetMiterLimitDelegateField;

		// Token: 0x040010DD RID: 4317
		private static readonly UIPainter2D.BeginPathDelegate BeginPathDelegateField;

		// Token: 0x040010DE RID: 4318
		private static readonly UIPainter2D.ClosePathDelegate ClosePathDelegateField;

		// Token: 0x040010DF RID: 4319
		private static readonly UIPainter2D.GetStrokeColor_InjectedDelegate GetStrokeColor_InjectedDelegateField;

		// Token: 0x040010E0 RID: 4320
		private static readonly UIPainter2D.SetStrokeColor_InjectedDelegate SetStrokeColor_InjectedDelegateField;

		// Token: 0x040010E1 RID: 4321
		private static readonly UIPainter2D.GetFillColor_InjectedDelegate GetFillColor_InjectedDelegateField;

		// Token: 0x040010E2 RID: 4322
		private static readonly UIPainter2D.SetFillColor_InjectedDelegate SetFillColor_InjectedDelegateField;

		// Token: 0x040010E3 RID: 4323
		private static readonly UIPainter2D.MoveTo_InjectedDelegate MoveTo_InjectedDelegateField;

		// Token: 0x040010E4 RID: 4324
		private static readonly UIPainter2D.LineTo_InjectedDelegate LineTo_InjectedDelegateField;

		// Token: 0x040010E5 RID: 4325
		private static readonly UIPainter2D.ArcTo_InjectedDelegate ArcTo_InjectedDelegateField;

		// Token: 0x040010E6 RID: 4326
		private static readonly UIPainter2D.Arc_InjectedDelegate Arc_InjectedDelegateField;

		// Token: 0x040010E7 RID: 4327
		private static readonly UIPainter2D.BezierCurveTo_InjectedDelegate BezierCurveTo_InjectedDelegateField;

		// Token: 0x040010E8 RID: 4328
		private static readonly UIPainter2D.QuadraticCurveTo_InjectedDelegate QuadraticCurveTo_InjectedDelegateField;

		// Token: 0x040010E9 RID: 4329
		private static readonly UIPainter2D.GetBBox_InjectedDelegate GetBBox_InjectedDelegateField;

		// Token: 0x040010EA RID: 4330
		private static readonly UIPainter2D.Stroke_InjectedDelegate Stroke_InjectedDelegateField;

		// Token: 0x040010EB RID: 4331
		private static readonly UIPainter2D.Fill_InjectedDelegate Fill_InjectedDelegateField;

		// Token: 0x02000474 RID: 1140
		// (Invoke) Token: 0x06003C2B RID: 15403
		private delegate float GetLineWidthDelegate(IntPtr handle);

		// Token: 0x02000475 RID: 1141
		// (Invoke) Token: 0x06003C2D RID: 15405
		private delegate void SetLineWidthDelegate(IntPtr handle, float value);

		// Token: 0x02000476 RID: 1142
		// (Invoke) Token: 0x06003C2F RID: 15407
		private delegate IntPtr GetStrokeGradientDelegate(IntPtr handle);

		// Token: 0x02000477 RID: 1143
		// (Invoke) Token: 0x06003C31 RID: 15409
		private delegate void SetStrokeGradientDelegate(IntPtr handle, IntPtr gradient);

		// Token: 0x02000478 RID: 1144
		// (Invoke) Token: 0x06003C33 RID: 15411
		private delegate LineJoin GetLineJoinDelegate(IntPtr handle);

		// Token: 0x02000479 RID: 1145
		// (Invoke) Token: 0x06003C35 RID: 15413
		private delegate void SetLineJoinDelegate(IntPtr handle, LineJoin value);

		// Token: 0x0200047A RID: 1146
		// (Invoke) Token: 0x06003C37 RID: 15415
		private delegate LineCap GetLineCapDelegate(IntPtr handle);

		// Token: 0x0200047B RID: 1147
		// (Invoke) Token: 0x06003C39 RID: 15417
		private delegate void SetLineCapDelegate(IntPtr handle, LineCap value);

		// Token: 0x0200047C RID: 1148
		// (Invoke) Token: 0x06003C3B RID: 15419
		private delegate float GetMiterLimitDelegate(IntPtr handle);

		// Token: 0x0200047D RID: 1149
		// (Invoke) Token: 0x06003C3D RID: 15421
		private delegate void SetMiterLimitDelegate(IntPtr handle, float value);

		// Token: 0x0200047E RID: 1150
		// (Invoke) Token: 0x06003C3F RID: 15423
		private delegate void BeginPathDelegate(IntPtr handle);

		// Token: 0x0200047F RID: 1151
		// (Invoke) Token: 0x06003C41 RID: 15425
		private delegate void ClosePathDelegate(IntPtr handle);

		// Token: 0x02000480 RID: 1152
		// (Invoke) Token: 0x06003C43 RID: 15427
		private delegate void GetStrokeColor_InjectedDelegate(IntPtr handle, [Out] IntPtr ret);

		// Token: 0x02000481 RID: 1153
		// (Invoke) Token: 0x06003C45 RID: 15429
		private delegate void SetStrokeColor_InjectedDelegate(IntPtr handle, IntPtr value);

		// Token: 0x02000482 RID: 1154
		// (Invoke) Token: 0x06003C47 RID: 15431
		private delegate void GetFillColor_InjectedDelegate(IntPtr handle, [Out] IntPtr ret);

		// Token: 0x02000483 RID: 1155
		// (Invoke) Token: 0x06003C49 RID: 15433
		private delegate void SetFillColor_InjectedDelegate(IntPtr handle, IntPtr value);

		// Token: 0x02000484 RID: 1156
		// (Invoke) Token: 0x06003C4B RID: 15435
		private delegate void MoveTo_InjectedDelegate(IntPtr handle, IntPtr pos);

		// Token: 0x02000485 RID: 1157
		// (Invoke) Token: 0x06003C4D RID: 15437
		private delegate void LineTo_InjectedDelegate(IntPtr handle, IntPtr pos);

		// Token: 0x02000486 RID: 1158
		// (Invoke) Token: 0x06003C4F RID: 15439
		private delegate void ArcTo_InjectedDelegate(IntPtr handle, IntPtr p1, IntPtr p2, float radius);

		// Token: 0x02000487 RID: 1159
		// (Invoke) Token: 0x06003C51 RID: 15441
		private delegate void Arc_InjectedDelegate(IntPtr handle, IntPtr center, float radius, float startAngleRads, float endAngleRads, ArcDirection direction);

		// Token: 0x02000488 RID: 1160
		// (Invoke) Token: 0x06003C53 RID: 15443
		private delegate void BezierCurveTo_InjectedDelegate(IntPtr handle, IntPtr p1, IntPtr p2, IntPtr p3);

		// Token: 0x02000489 RID: 1161
		// (Invoke) Token: 0x06003C55 RID: 15445
		private delegate void QuadraticCurveTo_InjectedDelegate(IntPtr handle, IntPtr p1, IntPtr p2);

		// Token: 0x0200048A RID: 1162
		// (Invoke) Token: 0x06003C57 RID: 15447
		private delegate void GetBBox_InjectedDelegate(IntPtr handle, [Out] IntPtr ret);

		// Token: 0x0200048B RID: 1163
		// (Invoke) Token: 0x06003C59 RID: 15449
		private delegate void Stroke_InjectedDelegate(IntPtr handle, [Out] IntPtr ret);

		// Token: 0x0200048C RID: 1164
		// (Invoke) Token: 0x06003C5B RID: 15451
		private delegate void Fill_InjectedDelegate(IntPtr handle, FillRule fillRule, [Out] IntPtr ret);
	}
}

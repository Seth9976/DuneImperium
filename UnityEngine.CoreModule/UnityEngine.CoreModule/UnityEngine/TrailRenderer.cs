using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine
{
	// Token: 0x020000A1 RID: 161
	public sealed class TrailRenderer : Renderer
	{
		// Token: 0x06000A56 RID: 2646 RVA: 0x000365F8 File Offset: 0x000347F8
		// Note: this type is marked as 'beforefieldinit'.
		static TrailRenderer()
		{
			Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "TrailRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr);
			TrailRenderer.NativeMethodInfoPtr_get_time_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664417);
			TrailRenderer.NativeMethodInfoPtr_set_time_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664418);
			TrailRenderer.NativeMethodInfoPtr_get_startWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664419);
			TrailRenderer.NativeMethodInfoPtr_set_startWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664420);
			TrailRenderer.NativeMethodInfoPtr_get_endWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664421);
			TrailRenderer.NativeMethodInfoPtr_set_endWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664422);
			TrailRenderer.get_widthMultiplierDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_widthMultiplierDelegate>("UnityEngine.TrailRenderer::get_widthMultiplier");
			TrailRenderer.set_widthMultiplierDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_widthMultiplierDelegate>("UnityEngine.TrailRenderer::set_widthMultiplier");
			TrailRenderer.get_autodestructDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_autodestructDelegate>("UnityEngine.TrailRenderer::get_autodestruct");
			TrailRenderer.set_autodestructDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_autodestructDelegate>("UnityEngine.TrailRenderer::set_autodestruct");
			TrailRenderer.get_emittingDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_emittingDelegate>("UnityEngine.TrailRenderer::get_emitting");
			TrailRenderer.set_emittingDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_emittingDelegate>("UnityEngine.TrailRenderer::set_emitting");
			TrailRenderer.get_numCornerVerticesDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_numCornerVerticesDelegate>("UnityEngine.TrailRenderer::get_numCornerVertices");
			TrailRenderer.set_numCornerVerticesDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_numCornerVerticesDelegate>("UnityEngine.TrailRenderer::set_numCornerVertices");
			TrailRenderer.get_numCapVerticesDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_numCapVerticesDelegate>("UnityEngine.TrailRenderer::get_numCapVertices");
			TrailRenderer.set_numCapVerticesDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_numCapVerticesDelegate>("UnityEngine.TrailRenderer::set_numCapVertices");
			TrailRenderer.get_minVertexDistanceDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_minVertexDistanceDelegate>("UnityEngine.TrailRenderer::get_minVertexDistance");
			TrailRenderer.set_minVertexDistanceDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_minVertexDistanceDelegate>("UnityEngine.TrailRenderer::set_minVertexDistance");
			TrailRenderer.get_positionCountDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_positionCountDelegate>("UnityEngine.TrailRenderer::get_positionCount");
			TrailRenderer.get_shadowBiasDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_shadowBiasDelegate>("UnityEngine.TrailRenderer::get_shadowBias");
			TrailRenderer.set_shadowBiasDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_shadowBiasDelegate>("UnityEngine.TrailRenderer::set_shadowBias");
			TrailRenderer.get_generateLightingDataDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_generateLightingDataDelegate>("UnityEngine.TrailRenderer::get_generateLightingData");
			TrailRenderer.set_generateLightingDataDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_generateLightingDataDelegate>("UnityEngine.TrailRenderer::set_generateLightingData");
			TrailRenderer.get_textureModeDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_textureModeDelegate>("UnityEngine.TrailRenderer::get_textureMode");
			TrailRenderer.set_textureModeDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_textureModeDelegate>("UnityEngine.TrailRenderer::set_textureMode");
			TrailRenderer.get_alignmentDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_alignmentDelegate>("UnityEngine.TrailRenderer::get_alignment");
			TrailRenderer.set_alignmentDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_alignmentDelegate>("UnityEngine.TrailRenderer::set_alignment");
			TrailRenderer.get_maskInteractionDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_maskInteractionDelegate>("UnityEngine.TrailRenderer::get_maskInteraction");
			TrailRenderer.set_maskInteractionDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_maskInteractionDelegate>("UnityEngine.TrailRenderer::set_maskInteraction");
			TrailRenderer.ClearDelegateField = IL2CPP.ResolveICall<TrailRenderer.ClearDelegate>("UnityEngine.TrailRenderer::Clear");
			TrailRenderer.BakeMeshDelegateField = IL2CPP.ResolveICall<TrailRenderer.BakeMeshDelegate>("UnityEngine.TrailRenderer::BakeMesh");
			TrailRenderer.GetWidthCurveCopyDelegateField = IL2CPP.ResolveICall<TrailRenderer.GetWidthCurveCopyDelegate>("UnityEngine.TrailRenderer::GetWidthCurveCopy");
			TrailRenderer.SetWidthCurveDelegateField = IL2CPP.ResolveICall<TrailRenderer.SetWidthCurveDelegate>("UnityEngine.TrailRenderer::SetWidthCurve");
			TrailRenderer.GetColorGradientCopyDelegateField = IL2CPP.ResolveICall<TrailRenderer.GetColorGradientCopyDelegate>("UnityEngine.TrailRenderer::GetColorGradientCopy");
			TrailRenderer.SetColorGradientDelegateField = IL2CPP.ResolveICall<TrailRenderer.SetColorGradientDelegate>("UnityEngine.TrailRenderer::SetColorGradient");
			TrailRenderer.GetPositionsDelegateField = IL2CPP.ResolveICall<TrailRenderer.GetPositionsDelegate>("UnityEngine.TrailRenderer::GetPositions");
			TrailRenderer.GetVisiblePositionsDelegateField = IL2CPP.ResolveICall<TrailRenderer.GetVisiblePositionsDelegate>("UnityEngine.TrailRenderer::GetVisiblePositions");
			TrailRenderer.SetPositionsDelegateField = IL2CPP.ResolveICall<TrailRenderer.SetPositionsDelegate>("UnityEngine.TrailRenderer::SetPositions");
			TrailRenderer.AddPositionsDelegateField = IL2CPP.ResolveICall<TrailRenderer.AddPositionsDelegate>("UnityEngine.TrailRenderer::AddPositions");
			TrailRenderer.SetPositionsWithNativeContainerDelegateField = IL2CPP.ResolveICall<TrailRenderer.SetPositionsWithNativeContainerDelegate>("UnityEngine.TrailRenderer::SetPositionsWithNativeContainer");
			TrailRenderer.GetPositionsWithNativeContainerDelegateField = IL2CPP.ResolveICall<TrailRenderer.GetPositionsWithNativeContainerDelegate>("UnityEngine.TrailRenderer::GetPositionsWithNativeContainer");
			TrailRenderer.GetVisiblePositionsWithNativeContainerDelegateField = IL2CPP.ResolveICall<TrailRenderer.GetVisiblePositionsWithNativeContainerDelegate>("UnityEngine.TrailRenderer::GetVisiblePositionsWithNativeContainer");
			TrailRenderer.AddPositionsWithNativeContainerDelegateField = IL2CPP.ResolveICall<TrailRenderer.AddPositionsWithNativeContainerDelegate>("UnityEngine.TrailRenderer::AddPositionsWithNativeContainer");
			TrailRenderer.get_startColor_InjectedDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_startColor_InjectedDelegate>("UnityEngine.TrailRenderer::get_startColor_Injected");
			TrailRenderer.set_startColor_InjectedDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_startColor_InjectedDelegate>("UnityEngine.TrailRenderer::set_startColor_Injected");
			TrailRenderer.get_endColor_InjectedDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_endColor_InjectedDelegate>("UnityEngine.TrailRenderer::get_endColor_Injected");
			TrailRenderer.set_endColor_InjectedDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_endColor_InjectedDelegate>("UnityEngine.TrailRenderer::set_endColor_Injected");
			TrailRenderer.SetPosition_InjectedDelegateField = IL2CPP.ResolveICall<TrailRenderer.SetPosition_InjectedDelegate>("UnityEngine.TrailRenderer::SetPosition_Injected");
			TrailRenderer.GetPosition_InjectedDelegateField = IL2CPP.ResolveICall<TrailRenderer.GetPosition_InjectedDelegate>("UnityEngine.TrailRenderer::GetPosition_Injected");
			TrailRenderer.get_textureScale_InjectedDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_textureScale_InjectedDelegate>("UnityEngine.TrailRenderer::get_textureScale_Injected");
			TrailRenderer.set_textureScale_InjectedDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_textureScale_InjectedDelegate>("UnityEngine.TrailRenderer::set_textureScale_Injected");
			TrailRenderer.AddPosition_InjectedDelegateField = IL2CPP.ResolveICall<TrailRenderer.AddPosition_InjectedDelegate>("UnityEngine.TrailRenderer::AddPosition_Injected");
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x00036954 File Offset: 0x00034B54
		// (set) Token: 0x06000A58 RID: 2648 RVA: 0x00036990 File Offset: 0x00034B90
		public unsafe float time
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 650226, RefRangeEnd = 650227, XrefRangeStart = 650224, XrefRangeEnd = 650226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_time_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 650229, RefRangeEnd = 650230, XrefRangeStart = 650227, XrefRangeEnd = 650229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_time_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x000369D0 File Offset: 0x00034BD0
		// (set) Token: 0x06000A5A RID: 2650 RVA: 0x00036A0C File Offset: 0x00034C0C
		public unsafe float startWidth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 650232, RefRangeEnd = 650233, XrefRangeStart = 650230, XrefRangeEnd = 650232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_startWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 650235, RefRangeEnd = 650236, XrefRangeStart = 650233, XrefRangeEnd = 650235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_startWidth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x00036A4C File Offset: 0x00034C4C
		// (set) Token: 0x06000A5C RID: 2652 RVA: 0x00036A88 File Offset: 0x00034C88
		public unsafe float endWidth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 650238, RefRangeEnd = 650239, XrefRangeStart = 650236, XrefRangeEnd = 650238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_endWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 650241, RefRangeEnd = 650242, XrefRangeStart = 650239, XrefRangeEnd = 650241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_endWidth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x000060DD File Offset: 0x000042DD
		public TrailRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x00036AC8 File Offset: 0x00034CC8
		public int numPositions
		{
			get
			{
				return this.positionCount;
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000A5F RID: 2655 RVA: 0x000060E6 File Offset: 0x000042E6
		// (set) Token: 0x06000A60 RID: 2656 RVA: 0x000060F8 File Offset: 0x000042F8
		public float widthMultiplier
		{
			get
			{
				return TrailRenderer.get_widthMultiplierDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_widthMultiplierDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x0000610B File Offset: 0x0000430B
		// (set) Token: 0x06000A62 RID: 2658 RVA: 0x0000611D File Offset: 0x0000431D
		public bool autodestruct
		{
			get
			{
				return TrailRenderer.get_autodestructDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_autodestructDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x00006130 File Offset: 0x00004330
		// (set) Token: 0x06000A64 RID: 2660 RVA: 0x00006142 File Offset: 0x00004342
		public bool emitting
		{
			get
			{
				return TrailRenderer.get_emittingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_emittingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x00006155 File Offset: 0x00004355
		// (set) Token: 0x06000A66 RID: 2662 RVA: 0x00006167 File Offset: 0x00004367
		public int numCornerVertices
		{
			get
			{
				return TrailRenderer.get_numCornerVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_numCornerVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x0000617A File Offset: 0x0000437A
		// (set) Token: 0x06000A68 RID: 2664 RVA: 0x0000618C File Offset: 0x0000438C
		public int numCapVertices
		{
			get
			{
				return TrailRenderer.get_numCapVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_numCapVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000A69 RID: 2665 RVA: 0x0000619F File Offset: 0x0000439F
		// (set) Token: 0x06000A6A RID: 2666 RVA: 0x000061B1 File Offset: 0x000043B1
		public float minVertexDistance
		{
			get
			{
				return TrailRenderer.get_minVertexDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_minVertexDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x00036AE0 File Offset: 0x00034CE0
		// (set) Token: 0x06000A6C RID: 2668 RVA: 0x000061C4 File Offset: 0x000043C4
		public Color startColor
		{
			get
			{
				Color color;
				this.get_startColor_Injected(out color);
				return color;
			}
			set
			{
				this.set_startColor_Injected(ref value);
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000A6D RID: 2669 RVA: 0x00036AF8 File Offset: 0x00034CF8
		// (set) Token: 0x06000A6E RID: 2670 RVA: 0x000061CE File Offset: 0x000043CE
		public Color endColor
		{
			get
			{
				Color color;
				this.get_endColor_Injected(out color);
				return color;
			}
			set
			{
				this.set_endColor_Injected(ref value);
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x000061D8 File Offset: 0x000043D8
		public int positionCount
		{
			get
			{
				return TrailRenderer.get_positionCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x000061EA File Offset: 0x000043EA
		public void SetPosition(int index, Vector3 position)
		{
			this.SetPosition_Injected(index, ref position);
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00036B10 File Offset: 0x00034D10
		public Vector3 GetPosition(int index)
		{
			Vector3 vector;
			this.GetPosition_Injected(index, out vector);
			return vector;
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000A72 RID: 2674 RVA: 0x00036B28 File Offset: 0x00034D28
		// (set) Token: 0x06000A73 RID: 2675 RVA: 0x000061F5 File Offset: 0x000043F5
		public Vector2 textureScale
		{
			get
			{
				Vector2 vector;
				this.get_textureScale_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_textureScale_Injected(ref value);
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000A74 RID: 2676 RVA: 0x000061FF File Offset: 0x000043FF
		// (set) Token: 0x06000A75 RID: 2677 RVA: 0x00006211 File Offset: 0x00004411
		public float shadowBias
		{
			get
			{
				return TrailRenderer.get_shadowBiasDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_shadowBiasDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000A76 RID: 2678 RVA: 0x00006224 File Offset: 0x00004424
		// (set) Token: 0x06000A77 RID: 2679 RVA: 0x00006236 File Offset: 0x00004436
		public bool generateLightingData
		{
			get
			{
				return TrailRenderer.get_generateLightingDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_generateLightingDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000A78 RID: 2680 RVA: 0x00006249 File Offset: 0x00004449
		// (set) Token: 0x06000A79 RID: 2681 RVA: 0x0000625B File Offset: 0x0000445B
		public LineTextureMode textureMode
		{
			get
			{
				return TrailRenderer.get_textureModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_textureModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000A7A RID: 2682 RVA: 0x0000626E File Offset: 0x0000446E
		// (set) Token: 0x06000A7B RID: 2683 RVA: 0x00006280 File Offset: 0x00004480
		public LineAlignment alignment
		{
			get
			{
				return TrailRenderer.get_alignmentDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_alignmentDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000A7C RID: 2684 RVA: 0x00006293 File Offset: 0x00004493
		// (set) Token: 0x06000A7D RID: 2685 RVA: 0x000062A5 File Offset: 0x000044A5
		public SpriteMaskInteraction maskInteraction
		{
			get
			{
				return TrailRenderer.get_maskInteractionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_maskInteractionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x000062B8 File Offset: 0x000044B8
		public void Clear()
		{
			TrailRenderer.ClearDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x000062CA File Offset: 0x000044CA
		public void BakeMesh(Mesh mesh, [Optional] bool useTransform)
		{
			this.BakeMesh(mesh, Camera.main, useTransform);
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x000062DB File Offset: 0x000044DB
		public void BakeMesh(Mesh mesh, Camera camera, [Optional] bool useTransform)
		{
			TrailRenderer.BakeMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(mesh), IL2CPP.Il2CppObjectBaseToPtr(camera), useTransform);
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x00036B40 File Offset: 0x00034D40
		// (set) Token: 0x06000A82 RID: 2690 RVA: 0x000062FA File Offset: 0x000044FA
		public AnimationCurve widthCurve
		{
			get
			{
				return this.GetWidthCurveCopy();
			}
			set
			{
				this.SetWidthCurve(value);
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x00036B58 File Offset: 0x00034D58
		// (set) Token: 0x06000A84 RID: 2692 RVA: 0x00006305 File Offset: 0x00004505
		public Gradient colorGradient
		{
			get
			{
				return this.GetColorGradientCopy();
			}
			set
			{
				this.SetColorGradient(value);
			}
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x00036B70 File Offset: 0x00034D70
		public AnimationCurve GetWidthCurveCopy()
		{
			IntPtr intPtr = TrailRenderer.GetWidthCurveCopyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x00006310 File Offset: 0x00004510
		public void SetWidthCurve(AnimationCurve curve)
		{
			TrailRenderer.SetWidthCurveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(curve));
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x00036B9C File Offset: 0x00034D9C
		public Gradient GetColorGradientCopy()
		{
			IntPtr intPtr = TrailRenderer.GetColorGradientCopyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x00006328 File Offset: 0x00004528
		public void SetColorGradient(Gradient curve)
		{
			TrailRenderer.SetColorGradientDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(curve));
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00006340 File Offset: 0x00004540
		public int GetPositions([Out] Il2CppStructArray<Vector3> positions)
		{
			return TrailRenderer.GetPositionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(positions));
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x00006358 File Offset: 0x00004558
		public int GetVisiblePositions([Out] Il2CppStructArray<Vector3> positions)
		{
			return TrailRenderer.GetVisiblePositionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(positions));
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x00006370 File Offset: 0x00004570
		public void SetPositions(Il2CppStructArray<Vector3> positions)
		{
			TrailRenderer.SetPositionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(positions));
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x00006388 File Offset: 0x00004588
		public void AddPosition(Vector3 position)
		{
			this.AddPosition_Injected(ref position);
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x00006392 File Offset: 0x00004592
		public void AddPositions(Il2CppStructArray<Vector3> positions)
		{
			TrailRenderer.AddPositionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(positions));
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x000063AA File Offset: 0x000045AA
		public void SetPositions(Unity.Collections.NativeArray<Vector3> positions)
		{
			this.SetPositionsWithNativeContainer((IntPtr)positions.GetUnsafeReadOnlyPtr<Vector3>(), positions.Length);
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x000063C8 File Offset: 0x000045C8
		public void SetPositions(Unity.Collections.NativeSlice<Vector3> positions)
		{
			this.SetPositionsWithNativeContainer((IntPtr)positions.GetUnsafeReadOnlyPtr<Vector3>(), positions.Length);
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00036BC8 File Offset: 0x00034DC8
		public int GetPositions([Out] Unity.Collections.NativeArray<Vector3> positions)
		{
			return this.GetPositionsWithNativeContainer((IntPtr)positions.GetUnsafePtr<Vector3>(), positions.Length);
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x00036BF4 File Offset: 0x00034DF4
		public int GetPositions([Out] Unity.Collections.NativeSlice<Vector3> positions)
		{
			return this.GetPositionsWithNativeContainer((IntPtr)positions.GetUnsafePtr<Vector3>(), positions.Length);
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00036C20 File Offset: 0x00034E20
		public int GetVisiblePositions([Out] Unity.Collections.NativeArray<Vector3> positions)
		{
			return this.GetVisiblePositionsWithNativeContainer((IntPtr)positions.GetUnsafePtr<Vector3>(), positions.Length);
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00036C4C File Offset: 0x00034E4C
		public int GetVisiblePositions([Out] Unity.Collections.NativeSlice<Vector3> positions)
		{
			return this.GetVisiblePositionsWithNativeContainer((IntPtr)positions.GetUnsafePtr<Vector3>(), positions.Length);
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x000063E6 File Offset: 0x000045E6
		public void AddPositions([Out] Unity.Collections.NativeArray<Vector3> positions)
		{
			this.AddPositionsWithNativeContainer((IntPtr)positions.GetUnsafePtr<Vector3>(), positions.Length);
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x00006404 File Offset: 0x00004604
		public void AddPositions([Out] Unity.Collections.NativeSlice<Vector3> positions)
		{
			this.AddPositionsWithNativeContainer((IntPtr)positions.GetUnsafePtr<Vector3>(), positions.Length);
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00006422 File Offset: 0x00004622
		public void SetPositionsWithNativeContainer(IntPtr positions, int count)
		{
			TrailRenderer.SetPositionsWithNativeContainerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), positions, count);
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x00006436 File Offset: 0x00004636
		public int GetPositionsWithNativeContainer(IntPtr positions, int length)
		{
			return TrailRenderer.GetPositionsWithNativeContainerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), positions, length);
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x0000644A File Offset: 0x0000464A
		public int GetVisiblePositionsWithNativeContainer(IntPtr positions, int length)
		{
			return TrailRenderer.GetVisiblePositionsWithNativeContainerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), positions, length);
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x0000645E File Offset: 0x0000465E
		public void AddPositionsWithNativeContainer(IntPtr positions, int length)
		{
			TrailRenderer.AddPositionsWithNativeContainerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), positions, length);
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x00006472 File Offset: 0x00004672
		public void get_startColor_Injected(out Color ret)
		{
			TrailRenderer.get_startColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x00006485 File Offset: 0x00004685
		public void set_startColor_Injected(ref Color value)
		{
			TrailRenderer.set_startColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x00006498 File Offset: 0x00004698
		public void get_endColor_Injected(out Color ret)
		{
			TrailRenderer.get_endColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x000064AB File Offset: 0x000046AB
		public void set_endColor_Injected(ref Color value)
		{
			TrailRenderer.set_endColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x000064BE File Offset: 0x000046BE
		public void SetPosition_Injected(int index, ref Vector3 position)
		{
			TrailRenderer.SetPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, ref position);
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x000064D2 File Offset: 0x000046D2
		public void GetPosition_Injected(int index, out Vector3 ret)
		{
			TrailRenderer.GetPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, out ret);
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x000064E6 File Offset: 0x000046E6
		public void get_textureScale_Injected(out Vector2 ret)
		{
			TrailRenderer.get_textureScale_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x000064F9 File Offset: 0x000046F9
		public void set_textureScale_Injected(ref Vector2 value)
		{
			TrailRenderer.set_textureScale_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x0000650C File Offset: 0x0000470C
		public void AddPosition_Injected(ref Vector3 position)
		{
			TrailRenderer.AddPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position);
		}

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeMethodInfoPtr_get_time_Public_get_Single_0;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeMethodInfoPtr_set_time_Public_set_Void_Single_0;

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeMethodInfoPtr_get_startWidth_Public_get_Single_0;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeMethodInfoPtr_set_startWidth_Public_set_Void_Single_0;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeMethodInfoPtr_get_endWidth_Public_get_Single_0;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeMethodInfoPtr_set_endWidth_Public_set_Void_Single_0;

		// Token: 0x04000814 RID: 2068
		private static readonly TrailRenderer.get_widthMultiplierDelegate get_widthMultiplierDelegateField;

		// Token: 0x04000815 RID: 2069
		private static readonly TrailRenderer.set_widthMultiplierDelegate set_widthMultiplierDelegateField;

		// Token: 0x04000816 RID: 2070
		private static readonly TrailRenderer.get_autodestructDelegate get_autodestructDelegateField;

		// Token: 0x04000817 RID: 2071
		private static readonly TrailRenderer.set_autodestructDelegate set_autodestructDelegateField;

		// Token: 0x04000818 RID: 2072
		private static readonly TrailRenderer.get_emittingDelegate get_emittingDelegateField;

		// Token: 0x04000819 RID: 2073
		private static readonly TrailRenderer.set_emittingDelegate set_emittingDelegateField;

		// Token: 0x0400081A RID: 2074
		private static readonly TrailRenderer.get_numCornerVerticesDelegate get_numCornerVerticesDelegateField;

		// Token: 0x0400081B RID: 2075
		private static readonly TrailRenderer.set_numCornerVerticesDelegate set_numCornerVerticesDelegateField;

		// Token: 0x0400081C RID: 2076
		private static readonly TrailRenderer.get_numCapVerticesDelegate get_numCapVerticesDelegateField;

		// Token: 0x0400081D RID: 2077
		private static readonly TrailRenderer.set_numCapVerticesDelegate set_numCapVerticesDelegateField;

		// Token: 0x0400081E RID: 2078
		private static readonly TrailRenderer.get_minVertexDistanceDelegate get_minVertexDistanceDelegateField;

		// Token: 0x0400081F RID: 2079
		private static readonly TrailRenderer.set_minVertexDistanceDelegate set_minVertexDistanceDelegateField;

		// Token: 0x04000820 RID: 2080
		private static readonly TrailRenderer.get_positionCountDelegate get_positionCountDelegateField;

		// Token: 0x04000821 RID: 2081
		private static readonly TrailRenderer.get_shadowBiasDelegate get_shadowBiasDelegateField;

		// Token: 0x04000822 RID: 2082
		private static readonly TrailRenderer.set_shadowBiasDelegate set_shadowBiasDelegateField;

		// Token: 0x04000823 RID: 2083
		private static readonly TrailRenderer.get_generateLightingDataDelegate get_generateLightingDataDelegateField;

		// Token: 0x04000824 RID: 2084
		private static readonly TrailRenderer.set_generateLightingDataDelegate set_generateLightingDataDelegateField;

		// Token: 0x04000825 RID: 2085
		private static readonly TrailRenderer.get_textureModeDelegate get_textureModeDelegateField;

		// Token: 0x04000826 RID: 2086
		private static readonly TrailRenderer.set_textureModeDelegate set_textureModeDelegateField;

		// Token: 0x04000827 RID: 2087
		private static readonly TrailRenderer.get_alignmentDelegate get_alignmentDelegateField;

		// Token: 0x04000828 RID: 2088
		private static readonly TrailRenderer.set_alignmentDelegate set_alignmentDelegateField;

		// Token: 0x04000829 RID: 2089
		private static readonly TrailRenderer.get_maskInteractionDelegate get_maskInteractionDelegateField;

		// Token: 0x0400082A RID: 2090
		private static readonly TrailRenderer.set_maskInteractionDelegate set_maskInteractionDelegateField;

		// Token: 0x0400082B RID: 2091
		private static readonly TrailRenderer.ClearDelegate ClearDelegateField;

		// Token: 0x0400082C RID: 2092
		private static readonly TrailRenderer.BakeMeshDelegate BakeMeshDelegateField;

		// Token: 0x0400082D RID: 2093
		private static readonly TrailRenderer.GetWidthCurveCopyDelegate GetWidthCurveCopyDelegateField;

		// Token: 0x0400082E RID: 2094
		private static readonly TrailRenderer.SetWidthCurveDelegate SetWidthCurveDelegateField;

		// Token: 0x0400082F RID: 2095
		private static readonly TrailRenderer.GetColorGradientCopyDelegate GetColorGradientCopyDelegateField;

		// Token: 0x04000830 RID: 2096
		private static readonly TrailRenderer.SetColorGradientDelegate SetColorGradientDelegateField;

		// Token: 0x04000831 RID: 2097
		private static readonly TrailRenderer.GetPositionsDelegate GetPositionsDelegateField;

		// Token: 0x04000832 RID: 2098
		private static readonly TrailRenderer.GetVisiblePositionsDelegate GetVisiblePositionsDelegateField;

		// Token: 0x04000833 RID: 2099
		private static readonly TrailRenderer.SetPositionsDelegate SetPositionsDelegateField;

		// Token: 0x04000834 RID: 2100
		private static readonly TrailRenderer.AddPositionsDelegate AddPositionsDelegateField;

		// Token: 0x04000835 RID: 2101
		private static readonly TrailRenderer.SetPositionsWithNativeContainerDelegate SetPositionsWithNativeContainerDelegateField;

		// Token: 0x04000836 RID: 2102
		private static readonly TrailRenderer.GetPositionsWithNativeContainerDelegate GetPositionsWithNativeContainerDelegateField;

		// Token: 0x04000837 RID: 2103
		private static readonly TrailRenderer.GetVisiblePositionsWithNativeContainerDelegate GetVisiblePositionsWithNativeContainerDelegateField;

		// Token: 0x04000838 RID: 2104
		private static readonly TrailRenderer.AddPositionsWithNativeContainerDelegate AddPositionsWithNativeContainerDelegateField;

		// Token: 0x04000839 RID: 2105
		private static readonly TrailRenderer.get_startColor_InjectedDelegate get_startColor_InjectedDelegateField;

		// Token: 0x0400083A RID: 2106
		private static readonly TrailRenderer.set_startColor_InjectedDelegate set_startColor_InjectedDelegateField;

		// Token: 0x0400083B RID: 2107
		private static readonly TrailRenderer.get_endColor_InjectedDelegate get_endColor_InjectedDelegateField;

		// Token: 0x0400083C RID: 2108
		private static readonly TrailRenderer.set_endColor_InjectedDelegate set_endColor_InjectedDelegateField;

		// Token: 0x0400083D RID: 2109
		private static readonly TrailRenderer.SetPosition_InjectedDelegate SetPosition_InjectedDelegateField;

		// Token: 0x0400083E RID: 2110
		private static readonly TrailRenderer.GetPosition_InjectedDelegate GetPosition_InjectedDelegateField;

		// Token: 0x0400083F RID: 2111
		private static readonly TrailRenderer.get_textureScale_InjectedDelegate get_textureScale_InjectedDelegateField;

		// Token: 0x04000840 RID: 2112
		private static readonly TrailRenderer.set_textureScale_InjectedDelegate set_textureScale_InjectedDelegateField;

		// Token: 0x04000841 RID: 2113
		private static readonly TrailRenderer.AddPosition_InjectedDelegate AddPosition_InjectedDelegateField;

		// Token: 0x0200057D RID: 1405
		// (Invoke) Token: 0x0600340B RID: 13323
		private delegate float get_widthMultiplierDelegate(IntPtr @this);

		// Token: 0x0200057E RID: 1406
		// (Invoke) Token: 0x0600340D RID: 13325
		private delegate void set_widthMultiplierDelegate(IntPtr @this, float value);

		// Token: 0x0200057F RID: 1407
		// (Invoke) Token: 0x0600340F RID: 13327
		private delegate bool get_autodestructDelegate(IntPtr @this);

		// Token: 0x02000580 RID: 1408
		// (Invoke) Token: 0x06003411 RID: 13329
		private delegate void set_autodestructDelegate(IntPtr @this, bool value);

		// Token: 0x02000581 RID: 1409
		// (Invoke) Token: 0x06003413 RID: 13331
		private delegate bool get_emittingDelegate(IntPtr @this);

		// Token: 0x02000582 RID: 1410
		// (Invoke) Token: 0x06003415 RID: 13333
		private delegate void set_emittingDelegate(IntPtr @this, bool value);

		// Token: 0x02000583 RID: 1411
		// (Invoke) Token: 0x06003417 RID: 13335
		private delegate int get_numCornerVerticesDelegate(IntPtr @this);

		// Token: 0x02000584 RID: 1412
		// (Invoke) Token: 0x06003419 RID: 13337
		private delegate void set_numCornerVerticesDelegate(IntPtr @this, int value);

		// Token: 0x02000585 RID: 1413
		// (Invoke) Token: 0x0600341B RID: 13339
		private delegate int get_numCapVerticesDelegate(IntPtr @this);

		// Token: 0x02000586 RID: 1414
		// (Invoke) Token: 0x0600341D RID: 13341
		private delegate void set_numCapVerticesDelegate(IntPtr @this, int value);

		// Token: 0x02000587 RID: 1415
		// (Invoke) Token: 0x0600341F RID: 13343
		private delegate float get_minVertexDistanceDelegate(IntPtr @this);

		// Token: 0x02000588 RID: 1416
		// (Invoke) Token: 0x06003421 RID: 13345
		private delegate void set_minVertexDistanceDelegate(IntPtr @this, float value);

		// Token: 0x02000589 RID: 1417
		// (Invoke) Token: 0x06003423 RID: 13347
		private delegate int get_positionCountDelegate(IntPtr @this);

		// Token: 0x0200058A RID: 1418
		// (Invoke) Token: 0x06003425 RID: 13349
		private delegate float get_shadowBiasDelegate(IntPtr @this);

		// Token: 0x0200058B RID: 1419
		// (Invoke) Token: 0x06003427 RID: 13351
		private delegate void set_shadowBiasDelegate(IntPtr @this, float value);

		// Token: 0x0200058C RID: 1420
		// (Invoke) Token: 0x06003429 RID: 13353
		private delegate bool get_generateLightingDataDelegate(IntPtr @this);

		// Token: 0x0200058D RID: 1421
		// (Invoke) Token: 0x0600342B RID: 13355
		private delegate void set_generateLightingDataDelegate(IntPtr @this, bool value);

		// Token: 0x0200058E RID: 1422
		// (Invoke) Token: 0x0600342D RID: 13357
		private delegate LineTextureMode get_textureModeDelegate(IntPtr @this);

		// Token: 0x0200058F RID: 1423
		// (Invoke) Token: 0x0600342F RID: 13359
		private delegate void set_textureModeDelegate(IntPtr @this, LineTextureMode value);

		// Token: 0x02000590 RID: 1424
		// (Invoke) Token: 0x06003431 RID: 13361
		private delegate LineAlignment get_alignmentDelegate(IntPtr @this);

		// Token: 0x02000591 RID: 1425
		// (Invoke) Token: 0x06003433 RID: 13363
		private delegate void set_alignmentDelegate(IntPtr @this, LineAlignment value);

		// Token: 0x02000592 RID: 1426
		// (Invoke) Token: 0x06003435 RID: 13365
		private delegate SpriteMaskInteraction get_maskInteractionDelegate(IntPtr @this);

		// Token: 0x02000593 RID: 1427
		// (Invoke) Token: 0x06003437 RID: 13367
		private delegate void set_maskInteractionDelegate(IntPtr @this, SpriteMaskInteraction value);

		// Token: 0x02000594 RID: 1428
		// (Invoke) Token: 0x06003439 RID: 13369
		private delegate void ClearDelegate(IntPtr @this);

		// Token: 0x02000595 RID: 1429
		// (Invoke) Token: 0x0600343B RID: 13371
		private delegate void BakeMeshDelegate(IntPtr @this, IntPtr mesh, IntPtr camera, bool useTransform);

		// Token: 0x02000596 RID: 1430
		// (Invoke) Token: 0x0600343D RID: 13373
		private delegate IntPtr GetWidthCurveCopyDelegate(IntPtr @this);

		// Token: 0x02000597 RID: 1431
		// (Invoke) Token: 0x0600343F RID: 13375
		private delegate void SetWidthCurveDelegate(IntPtr @this, IntPtr curve);

		// Token: 0x02000598 RID: 1432
		// (Invoke) Token: 0x06003441 RID: 13377
		private delegate IntPtr GetColorGradientCopyDelegate(IntPtr @this);

		// Token: 0x02000599 RID: 1433
		// (Invoke) Token: 0x06003443 RID: 13379
		private delegate void SetColorGradientDelegate(IntPtr @this, IntPtr curve);

		// Token: 0x0200059A RID: 1434
		// (Invoke) Token: 0x06003445 RID: 13381
		private delegate int GetPositionsDelegate(IntPtr @this, [Out] IntPtr positions);

		// Token: 0x0200059B RID: 1435
		// (Invoke) Token: 0x06003447 RID: 13383
		private delegate int GetVisiblePositionsDelegate(IntPtr @this, [Out] IntPtr positions);

		// Token: 0x0200059C RID: 1436
		// (Invoke) Token: 0x06003449 RID: 13385
		private delegate void SetPositionsDelegate(IntPtr @this, IntPtr positions);

		// Token: 0x0200059D RID: 1437
		// (Invoke) Token: 0x0600344B RID: 13387
		private delegate void AddPositionsDelegate(IntPtr @this, IntPtr positions);

		// Token: 0x0200059E RID: 1438
		// (Invoke) Token: 0x0600344D RID: 13389
		private delegate void SetPositionsWithNativeContainerDelegate(IntPtr @this, IntPtr positions, int count);

		// Token: 0x0200059F RID: 1439
		// (Invoke) Token: 0x0600344F RID: 13391
		private delegate int GetPositionsWithNativeContainerDelegate(IntPtr @this, IntPtr positions, int length);

		// Token: 0x020005A0 RID: 1440
		// (Invoke) Token: 0x06003451 RID: 13393
		private delegate int GetVisiblePositionsWithNativeContainerDelegate(IntPtr @this, IntPtr positions, int length);

		// Token: 0x020005A1 RID: 1441
		// (Invoke) Token: 0x06003453 RID: 13395
		private delegate void AddPositionsWithNativeContainerDelegate(IntPtr @this, IntPtr positions, int length);

		// Token: 0x020005A2 RID: 1442
		// (Invoke) Token: 0x06003455 RID: 13397
		private delegate void get_startColor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020005A3 RID: 1443
		// (Invoke) Token: 0x06003457 RID: 13399
		private delegate void set_startColor_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020005A4 RID: 1444
		// (Invoke) Token: 0x06003459 RID: 13401
		private delegate void get_endColor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020005A5 RID: 1445
		// (Invoke) Token: 0x0600345B RID: 13403
		private delegate void set_endColor_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020005A6 RID: 1446
		// (Invoke) Token: 0x0600345D RID: 13405
		private delegate void SetPosition_InjectedDelegate(IntPtr @this, int index, IntPtr position);

		// Token: 0x020005A7 RID: 1447
		// (Invoke) Token: 0x0600345F RID: 13407
		private delegate void GetPosition_InjectedDelegate(IntPtr @this, int index, [Out] IntPtr ret);

		// Token: 0x020005A8 RID: 1448
		// (Invoke) Token: 0x06003461 RID: 13409
		private delegate void get_textureScale_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020005A9 RID: 1449
		// (Invoke) Token: 0x06003463 RID: 13411
		private delegate void set_textureScale_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020005AA RID: 1450
		// (Invoke) Token: 0x06003465 RID: 13413
		private delegate void AddPosition_InjectedDelegate(IntPtr @this, IntPtr position);
	}
}

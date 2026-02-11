using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200008D RID: 141
	public class ProbeVolumeDebug : Object
	{
		// Token: 0x06000A87 RID: 2695 RVA: 0x000340E4 File Offset: 0x000322E4
		// Note: this type is marked as 'beforefieldinit'.
		static ProbeVolumeDebug()
		{
			Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeVolumeDebug");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr);
			ProbeVolumeDebug.NativeFieldInfoPtr_drawProbes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "drawProbes");
			ProbeVolumeDebug.NativeFieldInfoPtr_drawBricks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "drawBricks");
			ProbeVolumeDebug.NativeFieldInfoPtr_drawCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "drawCells");
			ProbeVolumeDebug.NativeFieldInfoPtr_realtimeSubdivision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "realtimeSubdivision");
			ProbeVolumeDebug.NativeFieldInfoPtr_subdivisionCellUpdatePerFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "subdivisionCellUpdatePerFrame");
			ProbeVolumeDebug.NativeFieldInfoPtr_subdivisionDelayInSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "subdivisionDelayInSeconds");
			ProbeVolumeDebug.NativeFieldInfoPtr_probeShading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "probeShading");
			ProbeVolumeDebug.NativeFieldInfoPtr_probeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "probeSize");
			ProbeVolumeDebug.NativeFieldInfoPtr_subdivisionViewCullingDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "subdivisionViewCullingDistance");
			ProbeVolumeDebug.NativeFieldInfoPtr_probeCullingDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "probeCullingDistance");
			ProbeVolumeDebug.NativeFieldInfoPtr_maxSubdivToVisualize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "maxSubdivToVisualize");
			ProbeVolumeDebug.NativeFieldInfoPtr_minSubdivToVisualize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "minSubdivToVisualize");
			ProbeVolumeDebug.NativeFieldInfoPtr_exposureCompensation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "exposureCompensation");
			ProbeVolumeDebug.NativeFieldInfoPtr_drawVirtualOffsetPush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "drawVirtualOffsetPush");
			ProbeVolumeDebug.NativeFieldInfoPtr_offsetSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "offsetSize");
			ProbeVolumeDebug.NativeFieldInfoPtr_freezeStreaming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "freezeStreaming");
			ProbeVolumeDebug.NativeFieldInfoPtr_otherStateIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "otherStateIndex");
			ProbeVolumeDebug.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, 100664958);
			ProbeVolumeDebug.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, 100664959);
			ProbeVolumeDebug.NativeMethodInfoPtr_GetReset_Public_Virtual_Final_New_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, 100664960);
			ProbeVolumeDebug.NativeMethodInfoPtr__GetReset_b__19_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, 100664961);
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x000342B8 File Offset: 0x000324B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 969633, RefRangeEnd = 969634, XrefRangeStart = 969632, XrefRangeEnd = 969633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProbeVolumeDebug()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeDebug.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x000342F4 File Offset: 0x000324F4
		[CallerCount(0)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeDebug.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x00034328 File Offset: 0x00032528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969634, XrefRangeEnd = 969640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Action GetReset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeDebug.NativeMethodInfoPtr_GetReset_Public_Virtual_Final_New_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x00034368 File Offset: 0x00032568
		[CallerCount(0)]
		public unsafe void _GetReset_b__19_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeDebug.NativeMethodInfoPtr__GetReset_b__19_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x000065ED File Offset: 0x000047ED
		public ProbeVolumeDebug(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x0003439C File Offset: 0x0003259C
		// (set) Token: 0x06000A8E RID: 2702 RVA: 0x000065F6 File Offset: 0x000047F6
		public unsafe bool drawProbes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeDebug.NativeFieldInfoPtr_drawProbes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeDebug.NativeFieldInfoPtr_drawProbes)) = value;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x000343C4 File Offset: 0x000325C4
		// (set) Token: 0x06000A90 RID: 2704 RVA: 0x00006611 File Offset: 0x00004811
		public unsafe bool drawBricks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeDebug.NativeFieldInfoPtr_drawBricks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeDebug.NativeFieldInfoPtr_drawBricks)) = value;
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x000343EC File Offset: 0x000325EC
		// (set) Token: 0x06000A92 RID: 2706 RVA: 0x0000662C File Offset: 0x0000482C
		public unsafe bool drawCells
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeDebug.NativeFieldInfoPtr_drawCells);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeDebug.NativeFieldInfoPtr_drawCells)) = value;
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x00034414 File Offset: 0x00032614
		// (set) Token: 0x06000A94 RID: 2708 RVA: 0x00006647 File Offset: 0x00004847
		public unsafe bool realtimeSubdivision
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeDebug.NativeFieldInfoPtr_realtimeSubdivision);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeDebug.NativeFieldInfoPtr_realtimeSubdivision)) = value;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x0003443C File Offset: 0x0003263C
		// (set) Token: 0x06000A96 RID: 2710 RVA: 0x00006662 File Offset: 0x00004862
		public unsafe int subdivisionCellUpdatePerFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeDebug.NativeFieldInfoPtr_subdivisionCellUpdatePerFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeDebug.NativeFieldInfoPtr_subdivisionCellUpdatePerFrame)) = value;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x00034464 File Offset: 0x00032664
		// (set) Token: 0x06000A98 RID: 2712 RVA: 0x0000667D File Offset: 0x0000487D
		public unsafe float subdivisionDelayInSeconds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeDebug.NativeFieldInfoPtr_subdivisionDelayInSeconds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeDebug.NativeFieldInfoPtr_subdivisionDelayInSeconds)) = value;
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x0003448C File Offset: 0x0003268C
		// (set) Token: 0x06000A9A RID: 2714 RVA: 0x00006698 File Offset: 0x00004898
		public unsafe DebugProbeShadingMode probeShading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeDebug.NativeFieldInfoPtr_probeShading);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeDebug.NativeFieldInfoPtr_probeShading)) = value;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x000344B4 File Offset: 0x000326B4
		// (set) Token: 0x06000A9C RID: 2716 RVA: 0x000066B3 File Offset: 0x000048B3
		public unsafe float probeSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeDebug.NativeFieldInfoPtr_probeSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeDebug.NativeFieldInfoPtr_probeSize)) = value;
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x000344DC File Offset: 0x000326DC
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x000066CE File Offset: 0x000048CE
		public unsafe float subdivisionViewCullingDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeDebug.NativeFieldInfoPtr_subdivisionViewCullingDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeDebug.NativeFieldInfoPtr_subdivisionViewCullingDistance)) = value;
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x00034504 File Offset: 0x00032704
		// (set) Token: 0x06000AA0 RID: 2720 RVA: 0x000066E9 File Offset: 0x000048E9
		public unsafe float probeCullingDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeDebug.NativeFieldInfoPtr_probeCullingDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeDebug.NativeFieldInfoPtr_probeCullingDistance)) = value;
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x0003452C File Offset: 0x0003272C
		// (set) Token: 0x06000AA2 RID: 2722 RVA: 0x00006704 File Offset: 0x00004904
		public unsafe int maxSubdivToVisualize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeDebug.NativeFieldInfoPtr_maxSubdivToVisualize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeDebug.NativeFieldInfoPtr_maxSubdivToVisualize)) = value;
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x00034554 File Offset: 0x00032754
		// (set) Token: 0x06000AA4 RID: 2724 RVA: 0x0000671F File Offset: 0x0000491F
		public unsafe int minSubdivToVisualize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeDebug.NativeFieldInfoPtr_minSubdivToVisualize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeDebug.NativeFieldInfoPtr_minSubdivToVisualize)) = value;
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x0003457C File Offset: 0x0003277C
		// (set) Token: 0x06000AA6 RID: 2726 RVA: 0x0000673A File Offset: 0x0000493A
		public unsafe float exposureCompensation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeDebug.NativeFieldInfoPtr_exposureCompensation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeDebug.NativeFieldInfoPtr_exposureCompensation)) = value;
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x000345A4 File Offset: 0x000327A4
		// (set) Token: 0x06000AA8 RID: 2728 RVA: 0x00006755 File Offset: 0x00004955
		public unsafe bool drawVirtualOffsetPush
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeDebug.NativeFieldInfoPtr_drawVirtualOffsetPush);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeDebug.NativeFieldInfoPtr_drawVirtualOffsetPush)) = value;
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x000345CC File Offset: 0x000327CC
		// (set) Token: 0x06000AAA RID: 2730 RVA: 0x00006770 File Offset: 0x00004970
		public unsafe float offsetSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeDebug.NativeFieldInfoPtr_offsetSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeDebug.NativeFieldInfoPtr_offsetSize)) = value;
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x000345F4 File Offset: 0x000327F4
		// (set) Token: 0x06000AAC RID: 2732 RVA: 0x0000678B File Offset: 0x0000498B
		public unsafe bool freezeStreaming
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeDebug.NativeFieldInfoPtr_freezeStreaming);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeDebug.NativeFieldInfoPtr_freezeStreaming)) = value;
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x0003461C File Offset: 0x0003281C
		// (set) Token: 0x06000AAE RID: 2734 RVA: 0x000067A6 File Offset: 0x000049A6
		public unsafe int otherStateIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeDebug.NativeFieldInfoPtr_otherStateIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeDebug.NativeFieldInfoPtr_otherStateIndex)) = value;
			}
		}

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeFieldInfoPtr_drawProbes;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeFieldInfoPtr_drawBricks;

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeFieldInfoPtr_drawCells;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeFieldInfoPtr_realtimeSubdivision;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeFieldInfoPtr_subdivisionCellUpdatePerFrame;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeFieldInfoPtr_subdivisionDelayInSeconds;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeFieldInfoPtr_probeShading;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeFieldInfoPtr_probeSize;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeFieldInfoPtr_subdivisionViewCullingDistance;

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeFieldInfoPtr_probeCullingDistance;

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeFieldInfoPtr_maxSubdivToVisualize;

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeFieldInfoPtr_minSubdivToVisualize;

		// Token: 0x040007DB RID: 2011
		private static readonly IntPtr NativeFieldInfoPtr_exposureCompensation;

		// Token: 0x040007DC RID: 2012
		private static readonly IntPtr NativeFieldInfoPtr_drawVirtualOffsetPush;

		// Token: 0x040007DD RID: 2013
		private static readonly IntPtr NativeFieldInfoPtr_offsetSize;

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeFieldInfoPtr_freezeStreaming;

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeFieldInfoPtr_otherStateIndex;

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeMethodInfoPtr_GetReset_Public_Virtual_Final_New_Action_0;

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeMethodInfoPtr__GetReset_b__19_0_Private_Void_0;
	}
}

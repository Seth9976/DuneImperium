using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x02000060 RID: 96
	public class DebugFrameTiming : Object
	{
		// Token: 0x0600067B RID: 1659 RVA: 0x00026320 File Offset: 0x00024520
		// Note: this type is marked as 'beforefieldinit'.
		static DebugFrameTiming()
		{
			Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "DebugFrameTiming");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr);
			DebugFrameTiming.NativeFieldInfoPtr_k_FpsFormatString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, "k_FpsFormatString");
			DebugFrameTiming.NativeFieldInfoPtr_k_MsFormatString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, "k_MsFormatString");
			DebugFrameTiming.NativeFieldInfoPtr_k_RefreshRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, "k_RefreshRate");
			DebugFrameTiming.NativeFieldInfoPtr_m_FrameHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, "m_FrameHistory");
			DebugFrameTiming.NativeFieldInfoPtr_m_BottleneckHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, "m_BottleneckHistory");
			DebugFrameTiming.NativeFieldInfoPtr__bottleneckHistorySize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, "<bottleneckHistorySize>k__BackingField");
			DebugFrameTiming.NativeFieldInfoPtr__sampleHistorySize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, "<sampleHistorySize>k__BackingField");
			DebugFrameTiming.NativeFieldInfoPtr_m_Timing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, "m_Timing");
			DebugFrameTiming.NativeFieldInfoPtr_m_Sample = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, "m_Sample");
			DebugFrameTiming.NativeMethodInfoPtr_get_bottleneckHistorySize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664187);
			DebugFrameTiming.NativeMethodInfoPtr_set_bottleneckHistorySize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664188);
			DebugFrameTiming.NativeMethodInfoPtr_get_sampleHistorySize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664189);
			DebugFrameTiming.NativeMethodInfoPtr_set_sampleHistorySize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664190);
			DebugFrameTiming.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664191);
			DebugFrameTiming.NativeMethodInfoPtr_UpdateFrameTiming_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664192);
			DebugFrameTiming.NativeMethodInfoPtr_RegisterDebugUI_Public_Void_List_1_Widget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664193);
			DebugFrameTiming.NativeMethodInfoPtr_Reset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664194);
			DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_0_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664195);
			DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_1_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664196);
			DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_2_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664197);
			DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_3_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664198);
			DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_4_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664199);
			DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_5_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664200);
			DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_6_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664201);
			DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_7_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664202);
			DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_8_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664203);
			DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_9_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664204);
			DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_10_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664205);
			DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_11_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664206);
			DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_12_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664207);
			DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_13_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664208);
			DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_14_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664209);
			DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_15_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664210);
			DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_16_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664211);
			DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_17_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664212);
			DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_18_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664213);
			DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_19_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664214);
			DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_20_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664215);
			DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_21_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr, 100664216);
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x0002665C File Offset: 0x0002485C
		// (set) Token: 0x0600067D RID: 1661 RVA: 0x00026698 File Offset: 0x00024898
		public unsafe int bottleneckHistorySize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugFrameTiming.NativeMethodInfoPtr_get_bottleneckHistorySize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 287294, RefRangeEnd = 287297, XrefRangeStart = 287294, XrefRangeEnd = 287297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugFrameTiming.NativeMethodInfoPtr_set_bottleneckHistorySize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x000266D8 File Offset: 0x000248D8
		// (set) Token: 0x0600067F RID: 1663 RVA: 0x00026714 File Offset: 0x00024914
		public unsafe int sampleHistorySize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugFrameTiming.NativeMethodInfoPtr_get_sampleHistorySize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugFrameTiming.NativeMethodInfoPtr_set_sampleHistorySize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00026754 File Offset: 0x00024954
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 962001, RefRangeEnd = 962003, XrefRangeStart = 961986, XrefRangeEnd = 962001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugFrameTiming()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugFrameTiming>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugFrameTiming.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00026790 File Offset: 0x00024990
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 962024, RefRangeEnd = 962026, XrefRangeStart = 962003, XrefRangeEnd = 962024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFrameTiming()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugFrameTiming.NativeMethodInfoPtr_UpdateFrameTiming_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x000267C4 File Offset: 0x000249C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 962507, RefRangeEnd = 962508, XrefRangeStart = 962026, XrefRangeEnd = 962507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterDebugUI(List<DebugUI.Widget> list)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugFrameTiming.NativeMethodInfoPtr_RegisterDebugUI_Public_Void_List_1_Widget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00026808 File Offset: 0x00024A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962508, XrefRangeEnd = 962511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugFrameTiming.NativeMethodInfoPtr_Reset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0002683C File Offset: 0x00024A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962511, XrefRangeEnd = 962514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _RegisterDebugUI_b__17_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_0_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0002687C File Offset: 0x00024A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962514, XrefRangeEnd = 962517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _RegisterDebugUI_b__17_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_1_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x000268BC File Offset: 0x00024ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962517, XrefRangeEnd = 962520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _RegisterDebugUI_b__17_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_2_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x000268FC File Offset: 0x00024AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962520, XrefRangeEnd = 962523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _RegisterDebugUI_b__17_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_3_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0002693C File Offset: 0x00024B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962523, XrefRangeEnd = 962526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _RegisterDebugUI_b__17_4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_4_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0002697C File Offset: 0x00024B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962526, XrefRangeEnd = 962529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _RegisterDebugUI_b__17_5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_5_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x000269BC File Offset: 0x00024BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962529, XrefRangeEnd = 962532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _RegisterDebugUI_b__17_6()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_6_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x000269FC File Offset: 0x00024BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962532, XrefRangeEnd = 962535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _RegisterDebugUI_b__17_7()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_7_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00026A3C File Offset: 0x00024C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962535, XrefRangeEnd = 962538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _RegisterDebugUI_b__17_8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_8_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x00026A7C File Offset: 0x00024C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962538, XrefRangeEnd = 962541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _RegisterDebugUI_b__17_9()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_9_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00026ABC File Offset: 0x00024CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962541, XrefRangeEnd = 962544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _RegisterDebugUI_b__17_10()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_10_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00026AFC File Offset: 0x00024CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962544, XrefRangeEnd = 962547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _RegisterDebugUI_b__17_11()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_11_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x00026B3C File Offset: 0x00024D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962547, XrefRangeEnd = 962550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _RegisterDebugUI_b__17_12()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_12_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00026B7C File Offset: 0x00024D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962550, XrefRangeEnd = 962553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _RegisterDebugUI_b__17_13()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_13_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00026BBC File Offset: 0x00024DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962553, XrefRangeEnd = 962556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _RegisterDebugUI_b__17_14()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_14_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00026BFC File Offset: 0x00024DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962556, XrefRangeEnd = 962559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _RegisterDebugUI_b__17_15()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_15_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00026C3C File Offset: 0x00024E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962559, XrefRangeEnd = 962562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _RegisterDebugUI_b__17_16()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_16_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00026C7C File Offset: 0x00024E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962562, XrefRangeEnd = 962565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _RegisterDebugUI_b__17_17()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_17_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00026CBC File Offset: 0x00024EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962565, XrefRangeEnd = 962568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _RegisterDebugUI_b__17_18()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_18_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00026CFC File Offset: 0x00024EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962568, XrefRangeEnd = 962571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _RegisterDebugUI_b__17_19()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_19_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00026D3C File Offset: 0x00024F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962571, XrefRangeEnd = 962574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _RegisterDebugUI_b__17_20()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_20_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00026D7C File Offset: 0x00024F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962574, XrefRangeEnd = 962577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _RegisterDebugUI_b__17_21()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugFrameTiming.NativeMethodInfoPtr__RegisterDebugUI_b__17_21_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00004906 File Offset: 0x00002B06
		public DebugFrameTiming(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x00026DBC File Offset: 0x00024FBC
		// (set) Token: 0x0600069C RID: 1692 RVA: 0x0000490F File Offset: 0x00002B0F
		public unsafe static string k_FpsFormatString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DebugFrameTiming.NativeFieldInfoPtr_k_FpsFormatString, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugFrameTiming.NativeFieldInfoPtr_k_FpsFormatString, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x00026DDC File Offset: 0x00024FDC
		// (set) Token: 0x0600069E RID: 1694 RVA: 0x00004921 File Offset: 0x00002B21
		public unsafe static string k_MsFormatString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DebugFrameTiming.NativeFieldInfoPtr_k_MsFormatString, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugFrameTiming.NativeFieldInfoPtr_k_MsFormatString, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x00026DFC File Offset: 0x00024FFC
		// (set) Token: 0x060006A0 RID: 1696 RVA: 0x00004933 File Offset: 0x00002B33
		public unsafe static float k_RefreshRate
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DebugFrameTiming.NativeFieldInfoPtr_k_RefreshRate, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugFrameTiming.NativeFieldInfoPtr_k_RefreshRate, (void*)(&value));
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x00026E18 File Offset: 0x00025018
		// (set) Token: 0x060006A2 RID: 1698 RVA: 0x00004941 File Offset: 0x00002B41
		public unsafe FrameTimeSampleHistory m_FrameHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugFrameTiming.NativeFieldInfoPtr_m_FrameHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FrameTimeSampleHistory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugFrameTiming.NativeFieldInfoPtr_m_FrameHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060006A3 RID: 1699 RVA: 0x00026E48 File Offset: 0x00025048
		// (set) Token: 0x060006A4 RID: 1700 RVA: 0x00004960 File Offset: 0x00002B60
		public unsafe BottleneckHistory m_BottleneckHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugFrameTiming.NativeFieldInfoPtr_m_BottleneckHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BottleneckHistory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugFrameTiming.NativeFieldInfoPtr_m_BottleneckHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060006A5 RID: 1701 RVA: 0x00026E78 File Offset: 0x00025078
		// (set) Token: 0x060006A6 RID: 1702 RVA: 0x0000497F File Offset: 0x00002B7F
		public unsafe int _bottleneckHistorySize_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugFrameTiming.NativeFieldInfoPtr__bottleneckHistorySize_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugFrameTiming.NativeFieldInfoPtr__bottleneckHistorySize_k__BackingField)) = value;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060006A7 RID: 1703 RVA: 0x00026EA0 File Offset: 0x000250A0
		// (set) Token: 0x060006A8 RID: 1704 RVA: 0x0000499A File Offset: 0x00002B9A
		public unsafe int _sampleHistorySize_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugFrameTiming.NativeFieldInfoPtr__sampleHistorySize_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugFrameTiming.NativeFieldInfoPtr__sampleHistorySize_k__BackingField)) = value;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x00026EC8 File Offset: 0x000250C8
		// (set) Token: 0x060006AA RID: 1706 RVA: 0x000049B5 File Offset: 0x00002BB5
		public unsafe Il2CppStructArray<FrameTiming> m_Timing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugFrameTiming.NativeFieldInfoPtr_m_Timing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<FrameTiming>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugFrameTiming.NativeFieldInfoPtr_m_Timing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x00026EF8 File Offset: 0x000250F8
		// (set) Token: 0x060006AC RID: 1708 RVA: 0x000049D4 File Offset: 0x00002BD4
		public unsafe FrameTimeSample m_Sample
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugFrameTiming.NativeFieldInfoPtr_m_Sample);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugFrameTiming.NativeFieldInfoPtr_m_Sample)) = value;
			}
		}

		// Token: 0x040004BF RID: 1215
		private static readonly IntPtr NativeFieldInfoPtr_k_FpsFormatString;

		// Token: 0x040004C0 RID: 1216
		private static readonly IntPtr NativeFieldInfoPtr_k_MsFormatString;

		// Token: 0x040004C1 RID: 1217
		private static readonly IntPtr NativeFieldInfoPtr_k_RefreshRate;

		// Token: 0x040004C2 RID: 1218
		private static readonly IntPtr NativeFieldInfoPtr_m_FrameHistory;

		// Token: 0x040004C3 RID: 1219
		private static readonly IntPtr NativeFieldInfoPtr_m_BottleneckHistory;

		// Token: 0x040004C4 RID: 1220
		private static readonly IntPtr NativeFieldInfoPtr__bottleneckHistorySize_k__BackingField;

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeFieldInfoPtr__sampleHistorySize_k__BackingField;

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeFieldInfoPtr_m_Timing;

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeFieldInfoPtr_m_Sample;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeMethodInfoPtr_get_bottleneckHistorySize_Public_get_Int32_0;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeMethodInfoPtr_set_bottleneckHistorySize_Public_set_Void_Int32_0;

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeMethodInfoPtr_get_sampleHistorySize_Public_get_Int32_0;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeMethodInfoPtr_set_sampleHistorySize_Public_set_Void_Int32_0;

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFrameTiming_Public_Void_0;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDebugUI_Public_Void_List_1_Widget_0;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Void_0;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_0_Private_Object_0;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_1_Private_Object_0;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_2_Private_Object_0;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_3_Private_Object_0;

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_4_Private_Object_0;

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_5_Private_Object_0;

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_6_Private_Object_0;

		// Token: 0x040004D7 RID: 1239
		private static readonly IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_7_Private_Object_0;

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_8_Private_Object_0;

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_9_Private_Object_0;

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_10_Private_Object_0;

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_11_Private_Object_0;

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_12_Private_Object_0;

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_13_Private_Object_0;

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_14_Private_Object_0;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_15_Private_Object_0;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_16_Private_Object_0;

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_17_Private_Object_0;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_18_Private_Object_0;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_19_Private_Object_0;

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_20_Private_Object_0;

		// Token: 0x040004E5 RID: 1253
		private static readonly IntPtr NativeMethodInfoPtr__RegisterDebugUI_b__17_21_Private_Object_0;
	}
}

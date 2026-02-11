using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Profiling;
using Unity.Profiling.LowLevel.Unsafe;

namespace UnityEngine.Profiling
{
	// Token: 0x0200018C RID: 396
	public sealed class Recorder : Object
	{
		// Token: 0x06001DBA RID: 7610 RVA: 0x0008764C File Offset: 0x0008584C
		// Note: this type is marked as 'beforefieldinit'.
		static Recorder()
		{
			Il2CppClassPointerStore<Recorder>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Profiling", "Recorder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Recorder>.NativeClassPtr);
			Recorder.NativeFieldInfoPtr_s_RecorderDefaultOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recorder>.NativeClassPtr, "s_RecorderDefaultOptions");
			Recorder.NativeFieldInfoPtr_s_InvalidRecorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recorder>.NativeClassPtr, "s_InvalidRecorder");
			Recorder.NativeFieldInfoPtr_m_RecorderCPU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recorder>.NativeClassPtr, "m_RecorderCPU");
			Recorder.NativeFieldInfoPtr_m_RecorderGPU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recorder>.NativeClassPtr, "m_RecorderGPU");
			Recorder.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100667420);
			Recorder.NativeMethodInfoPtr__ctor_Internal_Void_ProfilerRecorderHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100667421);
			Recorder.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100667422);
			Recorder.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100667423);
			Recorder.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100667424);
			Recorder.NativeMethodInfoPtr_get_elapsedNanoseconds_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100667425);
			Recorder.NativeMethodInfoPtr_get_gpuElapsedNanoseconds_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100667426);
			Recorder.NativeMethodInfoPtr_get_sampleBlockCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100667427);
			Recorder.NativeMethodInfoPtr_get_gpuSampleBlockCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100667428);
			Recorder.NativeMethodInfoPtr_SetEnabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100667429);
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x00087794 File Offset: 0x00085994
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Recorder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Recorder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recorder.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DBC RID: 7612 RVA: 0x000877D0 File Offset: 0x000859D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677574, XrefRangeEnd = 677579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Recorder(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle handle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Recorder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recorder.NativeMethodInfoPtr__ctor_Internal_Void_ProfilerRecorderHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DBD RID: 7613 RVA: 0x00087818 File Offset: 0x00085A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677579, XrefRangeEnd = 677584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recorder.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06001DBE RID: 7614 RVA: 0x0008784C File Offset: 0x00085A4C
		// (set) Token: 0x06001DBF RID: 7615 RVA: 0x00087888 File Offset: 0x00085A88
		public unsafe bool enabled
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 677585, RefRangeEnd = 677591, XrefRangeStart = 677584, XrefRangeEnd = 677585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recorder.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 677597, RefRangeEnd = 677603, XrefRangeStart = 677591, XrefRangeEnd = 677597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recorder.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06001DC0 RID: 7616 RVA: 0x000878C8 File Offset: 0x00085AC8
		public unsafe long elapsedNanoseconds
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 677605, RefRangeEnd = 677607, XrefRangeStart = 677603, XrefRangeEnd = 677605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recorder.NativeMethodInfoPtr_get_elapsedNanoseconds_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06001DC1 RID: 7617 RVA: 0x00087904 File Offset: 0x00085B04
		public unsafe long gpuElapsedNanoseconds
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 677609, RefRangeEnd = 677610, XrefRangeStart = 677607, XrefRangeEnd = 677609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recorder.NativeMethodInfoPtr_get_gpuElapsedNanoseconds_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06001DC2 RID: 7618 RVA: 0x00087940 File Offset: 0x00085B40
		public unsafe int sampleBlockCount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 677613, RefRangeEnd = 677615, XrefRangeStart = 677610, XrefRangeEnd = 677613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recorder.NativeMethodInfoPtr_get_sampleBlockCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06001DC3 RID: 7619 RVA: 0x0008797C File Offset: 0x00085B7C
		public unsafe int gpuSampleBlockCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 677618, RefRangeEnd = 677619, XrefRangeStart = 677615, XrefRangeEnd = 677618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recorder.NativeMethodInfoPtr_get_gpuSampleBlockCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x000879B8 File Offset: 0x00085BB8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 677597, RefRangeEnd = 677603, XrefRangeStart = 677597, XrefRangeEnd = 677603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEnabled(bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recorder.NativeMethodInfoPtr_SetEnabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x0000B25A File Offset: 0x0000945A
		public Recorder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06001DC6 RID: 7622 RVA: 0x000879F8 File Offset: 0x00085BF8
		// (set) Token: 0x06001DC7 RID: 7623 RVA: 0x0000B263 File Offset: 0x00009463
		public unsafe static Unity.Profiling.ProfilerRecorderOptions s_RecorderDefaultOptions
		{
			get
			{
				Unity.Profiling.ProfilerRecorderOptions profilerRecorderOptions;
				IL2CPP.il2cpp_field_static_get_value(Recorder.NativeFieldInfoPtr_s_RecorderDefaultOptions, (void*)(&profilerRecorderOptions));
				return profilerRecorderOptions;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Recorder.NativeFieldInfoPtr_s_RecorderDefaultOptions, (void*)(&value));
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06001DC8 RID: 7624 RVA: 0x00087A14 File Offset: 0x00085C14
		// (set) Token: 0x06001DC9 RID: 7625 RVA: 0x0000B271 File Offset: 0x00009471
		public unsafe static Recorder s_InvalidRecorder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Recorder.NativeFieldInfoPtr_s_InvalidRecorder, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Recorder>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Recorder.NativeFieldInfoPtr_s_InvalidRecorder, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06001DCA RID: 7626 RVA: 0x00087A3C File Offset: 0x00085C3C
		// (set) Token: 0x06001DCB RID: 7627 RVA: 0x0000B283 File Offset: 0x00009483
		public unsafe Unity.Profiling.ProfilerRecorder m_RecorderCPU
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recorder.NativeFieldInfoPtr_m_RecorderCPU);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recorder.NativeFieldInfoPtr_m_RecorderCPU)) = value;
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06001DCC RID: 7628 RVA: 0x00087A64 File Offset: 0x00085C64
		// (set) Token: 0x06001DCD RID: 7629 RVA: 0x0000B29E File Offset: 0x0000949E
		public unsafe Unity.Profiling.ProfilerRecorder m_RecorderGPU
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recorder.NativeFieldInfoPtr_m_RecorderGPU);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recorder.NativeFieldInfoPtr_m_RecorderGPU)) = value;
			}
		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x00087A8C File Offset: 0x00085C8C
		public static Recorder Get(string samplerName)
		{
			Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle profilerRecorderHandle = Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle.Get(Unity.Profiling.ProfilerCategory.Any, samplerName);
			bool flag = !profilerRecorderHandle.Valid;
			Recorder recorder;
			if (flag)
			{
				recorder = Recorder.s_InvalidRecorder;
			}
			else
			{
				recorder = new Recorder(profilerRecorderHandle);
			}
			return recorder;
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06001DCF RID: 7631 RVA: 0x0000B2B9 File Offset: 0x000094B9
		public bool isValid
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06001DD0 RID: 7632 RVA: 0x0000B2C6 File Offset: 0x000094C6
		public void FilterToCurrentThread()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x0000B2D3 File Offset: 0x000094D3
		public void CollectFromAllThreads()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04001A3D RID: 6717
		private static readonly IntPtr NativeFieldInfoPtr_s_RecorderDefaultOptions;

		// Token: 0x04001A3E RID: 6718
		private static readonly IntPtr NativeFieldInfoPtr_s_InvalidRecorder;

		// Token: 0x04001A3F RID: 6719
		private static readonly IntPtr NativeFieldInfoPtr_m_RecorderCPU;

		// Token: 0x04001A40 RID: 6720
		private static readonly IntPtr NativeFieldInfoPtr_m_RecorderGPU;

		// Token: 0x04001A41 RID: 6721
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04001A42 RID: 6722
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ProfilerRecorderHandle_0;

		// Token: 0x04001A43 RID: 6723
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04001A44 RID: 6724
		private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

		// Token: 0x04001A45 RID: 6725
		private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;

		// Token: 0x04001A46 RID: 6726
		private static readonly IntPtr NativeMethodInfoPtr_get_elapsedNanoseconds_Public_get_Int64_0;

		// Token: 0x04001A47 RID: 6727
		private static readonly IntPtr NativeMethodInfoPtr_get_gpuElapsedNanoseconds_Public_get_Int64_0;

		// Token: 0x04001A48 RID: 6728
		private static readonly IntPtr NativeMethodInfoPtr_get_sampleBlockCount_Public_get_Int32_0;

		// Token: 0x04001A49 RID: 6729
		private static readonly IntPtr NativeMethodInfoPtr_get_gpuSampleBlockCount_Public_get_Int32_0;

		// Token: 0x04001A4A RID: 6730
		private static readonly IntPtr NativeMethodInfoPtr_SetEnabled_Private_Void_Boolean_0;
	}
}

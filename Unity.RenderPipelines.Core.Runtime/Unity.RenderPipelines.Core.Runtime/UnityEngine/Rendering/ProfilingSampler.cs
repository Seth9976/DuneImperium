using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine.Profiling;

namespace UnityEngine.Rendering
{
	// Token: 0x02000078 RID: 120
	public class ProfilingSampler : Object
	{
		// Token: 0x060007E4 RID: 2020 RVA: 0x0002B34C File Offset: 0x0002954C
		// Note: this type is marked as 'beforefieldinit'.
		static ProfilingSampler()
		{
			Il2CppClassPointerStore<ProfilingSampler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProfilingSampler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilingSampler>.NativeClassPtr);
			ProfilingSampler.NativeFieldInfoPtr__sampler_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilingSampler>.NativeClassPtr, "<sampler>k__BackingField");
			ProfilingSampler.NativeFieldInfoPtr__inlineSampler_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilingSampler>.NativeClassPtr, "<inlineSampler>k__BackingField");
			ProfilingSampler.NativeFieldInfoPtr__name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilingSampler>.NativeClassPtr, "<name>k__BackingField");
			ProfilingSampler.NativeFieldInfoPtr_m_Recorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilingSampler>.NativeClassPtr, "m_Recorder");
			ProfilingSampler.NativeFieldInfoPtr_m_InlineRecorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilingSampler>.NativeClassPtr, "m_InlineRecorder");
			ProfilingSampler.NativeMethodInfoPtr_Get_Public_Static_ProfilingSampler_TEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilingSampler>.NativeClassPtr, 100664556);
			ProfilingSampler.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilingSampler>.NativeClassPtr, 100664557);
			ProfilingSampler.NativeMethodInfoPtr_Begin_Public_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilingSampler>.NativeClassPtr, 100664558);
			ProfilingSampler.NativeMethodInfoPtr_End_Public_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilingSampler>.NativeClassPtr, 100664559);
			ProfilingSampler.NativeMethodInfoPtr_IsValid_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilingSampler>.NativeClassPtr, 100664560);
			ProfilingSampler.NativeMethodInfoPtr_get_sampler_Internal_get_CustomSampler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilingSampler>.NativeClassPtr, 100664561);
			ProfilingSampler.NativeMethodInfoPtr_set_sampler_Private_set_Void_CustomSampler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilingSampler>.NativeClassPtr, 100664562);
			ProfilingSampler.NativeMethodInfoPtr_get_inlineSampler_Internal_get_CustomSampler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilingSampler>.NativeClassPtr, 100664563);
			ProfilingSampler.NativeMethodInfoPtr_set_inlineSampler_Private_set_Void_CustomSampler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilingSampler>.NativeClassPtr, 100664564);
			ProfilingSampler.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilingSampler>.NativeClassPtr, 100664565);
			ProfilingSampler.NativeMethodInfoPtr_set_name_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilingSampler>.NativeClassPtr, 100664566);
			ProfilingSampler.NativeMethodInfoPtr_set_enableRecording_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilingSampler>.NativeClassPtr, 100664567);
			ProfilingSampler.NativeMethodInfoPtr_get_gpuElapsedTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilingSampler>.NativeClassPtr, 100664568);
			ProfilingSampler.NativeMethodInfoPtr_get_gpuSampleCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilingSampler>.NativeClassPtr, 100664569);
			ProfilingSampler.NativeMethodInfoPtr_get_cpuElapsedTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilingSampler>.NativeClassPtr, 100664570);
			ProfilingSampler.NativeMethodInfoPtr_get_cpuSampleCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilingSampler>.NativeClassPtr, 100664571);
			ProfilingSampler.NativeMethodInfoPtr_get_inlineCpuElapsedTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilingSampler>.NativeClassPtr, 100664572);
			ProfilingSampler.NativeMethodInfoPtr_get_inlineCpuSampleCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilingSampler>.NativeClassPtr, 100664573);
			ProfilingSampler.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilingSampler>.NativeClassPtr, 100664574);
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x0002B55C File Offset: 0x0002975C
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 964962, RefRangeEnd = 965001, XrefRangeStart = 964957, XrefRangeEnd = 964962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProfilingSampler Get<TEnum>(TEnum marker) where TEnum : Enum
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TEnum).IsValueType)
				{
					TEnum tenum = marker;
					intPtr = ((tenum is string) ? IL2CPP.ManagedStringToIl2Cpp(tenum as string) : IL2CPP.Il2CppObjectBaseToPtr(tenum as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref marker;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ProfilingSampler.MethodInfoStoreGeneric_Get_Public_Static_ProfilingSampler_TEnum_0<TEnum>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr4) : null;
			}
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x0002B5D8 File Offset: 0x000297D8
		[CallerCount(56)]
		[CachedScanResults(RefRangeStart = 965020, RefRangeEnd = 965076, XrefRangeStart = 965001, XrefRangeEnd = 965020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfilingSampler(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfilingSampler>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilingSampler.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x0002B624 File Offset: 0x00029824
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 965079, RefRangeEnd = 965080, XrefRangeStart = 965076, XrefRangeEnd = 965079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Begin(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilingSampler.NativeMethodInfoPtr_Begin_Public_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x0002B668 File Offset: 0x00029868
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 965083, RefRangeEnd = 965084, XrefRangeStart = 965080, XrefRangeEnd = 965083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void End(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilingSampler.NativeMethodInfoPtr_End_Public_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x0002B6AC File Offset: 0x000298AC
		[CallerCount(0)]
		public unsafe bool IsValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilingSampler.NativeMethodInfoPtr_IsValid_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x0002B6E8 File Offset: 0x000298E8
		// (set) Token: 0x060007EB RID: 2027 RVA: 0x0002B728 File Offset: 0x00029928
		public unsafe CustomSampler sampler
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilingSampler.NativeMethodInfoPtr_get_sampler_Internal_get_CustomSampler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomSampler>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilingSampler.NativeMethodInfoPtr_set_sampler_Private_set_Void_CustomSampler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x0002B76C File Offset: 0x0002996C
		// (set) Token: 0x060007ED RID: 2029 RVA: 0x0002B7AC File Offset: 0x000299AC
		public unsafe CustomSampler inlineSampler
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilingSampler.NativeMethodInfoPtr_get_inlineSampler_Internal_get_CustomSampler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomSampler>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilingSampler.NativeMethodInfoPtr_set_inlineSampler_Private_set_Void_CustomSampler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x0002B7F0 File Offset: 0x000299F0
		// (set) Token: 0x060007EF RID: 2031 RVA: 0x0002B828 File Offset: 0x00029A28
		public unsafe string name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilingSampler.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilingSampler.NativeMethodInfoPtr_set_name_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700023E RID: 574
		// (set) Token: 0x060007F0 RID: 2032 RVA: 0x0002B86C File Offset: 0x00029A6C
		public unsafe bool enableRecording
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965084, XrefRangeEnd = 965115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilingSampler.NativeMethodInfoPtr_set_enableRecording_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x0002B8AC File Offset: 0x00029AAC
		public unsafe float gpuElapsedTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965115, XrefRangeEnd = 965117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilingSampler.NativeMethodInfoPtr_get_gpuElapsedTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x0002B8E8 File Offset: 0x00029AE8
		public unsafe int gpuSampleCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965117, XrefRangeEnd = 965119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilingSampler.NativeMethodInfoPtr_get_gpuSampleCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x0002B924 File Offset: 0x00029B24
		public unsafe float cpuElapsedTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965119, XrefRangeEnd = 965121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilingSampler.NativeMethodInfoPtr_get_cpuElapsedTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060007F4 RID: 2036 RVA: 0x0002B960 File Offset: 0x00029B60
		public unsafe int cpuSampleCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965121, XrefRangeEnd = 965123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilingSampler.NativeMethodInfoPtr_get_cpuSampleCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x0002B99C File Offset: 0x00029B9C
		public unsafe float inlineCpuElapsedTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965123, XrefRangeEnd = 965125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilingSampler.NativeMethodInfoPtr_get_inlineCpuElapsedTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x0002B9D8 File Offset: 0x00029BD8
		public unsafe int inlineCpuSampleCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965125, XrefRangeEnd = 965127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilingSampler.NativeMethodInfoPtr_get_inlineCpuSampleCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x0002BA14 File Offset: 0x00029C14
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfilingSampler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfilingSampler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilingSampler.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x000051D3 File Offset: 0x000033D3
		public ProfilingSampler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060007F9 RID: 2041 RVA: 0x0002BA50 File Offset: 0x00029C50
		// (set) Token: 0x060007FA RID: 2042 RVA: 0x000051DC File Offset: 0x000033DC
		public unsafe CustomSampler _sampler_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfilingSampler.NativeFieldInfoPtr__sampler_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomSampler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfilingSampler.NativeFieldInfoPtr__sampler_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060007FB RID: 2043 RVA: 0x0002BA80 File Offset: 0x00029C80
		// (set) Token: 0x060007FC RID: 2044 RVA: 0x000051FB File Offset: 0x000033FB
		public unsafe CustomSampler _inlineSampler_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfilingSampler.NativeFieldInfoPtr__inlineSampler_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomSampler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfilingSampler.NativeFieldInfoPtr__inlineSampler_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060007FD RID: 2045 RVA: 0x0002BAB0 File Offset: 0x00029CB0
		// (set) Token: 0x060007FE RID: 2046 RVA: 0x0000521A File Offset: 0x0000341A
		public unsafe string _name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfilingSampler.NativeFieldInfoPtr__name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfilingSampler.NativeFieldInfoPtr__name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060007FF RID: 2047 RVA: 0x0002BAD8 File Offset: 0x00029CD8
		// (set) Token: 0x06000800 RID: 2048 RVA: 0x00005239 File Offset: 0x00003439
		public unsafe Recorder m_Recorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfilingSampler.NativeFieldInfoPtr_m_Recorder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Recorder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfilingSampler.NativeFieldInfoPtr_m_Recorder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x0002BB08 File Offset: 0x00029D08
		// (set) Token: 0x06000802 RID: 2050 RVA: 0x00005258 File Offset: 0x00003458
		public unsafe Recorder m_InlineRecorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfilingSampler.NativeFieldInfoPtr_m_InlineRecorder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Recorder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfilingSampler.NativeFieldInfoPtr_m_InlineRecorder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeFieldInfoPtr__sampler_k__BackingField;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeFieldInfoPtr__inlineSampler_k__BackingField;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeFieldInfoPtr__name_k__BackingField;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeFieldInfoPtr_m_Recorder;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeFieldInfoPtr_m_InlineRecorder;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_ProfilingSampler_TEnum_0;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Void_CommandBuffer_0;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Void_CommandBuffer_0;

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Internal_Boolean_0;

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeMethodInfoPtr_get_sampler_Internal_get_CustomSampler_0;

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeMethodInfoPtr_set_sampler_Private_set_Void_CustomSampler_0;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeMethodInfoPtr_get_inlineSampler_Internal_get_CustomSampler_0;

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeMethodInfoPtr_set_inlineSampler_Private_set_Void_CustomSampler_0;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Private_set_Void_String_0;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeMethodInfoPtr_set_enableRecording_Public_set_Void_Boolean_0;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeMethodInfoPtr_get_gpuElapsedTime_Public_get_Single_0;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeMethodInfoPtr_get_gpuSampleCount_Public_get_Int32_0;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeMethodInfoPtr_get_cpuElapsedTime_Public_get_Single_0;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeMethodInfoPtr_get_cpuSampleCount_Public_get_Int32_0;

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeMethodInfoPtr_get_inlineCpuElapsedTime_Public_get_Single_0;

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeMethodInfoPtr_get_inlineCpuSampleCount_Public_get_Int32_0;

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x020001B5 RID: 437
		private sealed class MethodInfoStoreGeneric_Get_Public_Static_ProfilingSampler_TEnum_0<TEnum>
		{
			// Token: 0x04001188 RID: 4488
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ProfilingSampler.NativeMethodInfoPtr_Get_Public_Static_ProfilingSampler_TEnum_0, Il2CppClassPointerStore<ProfilingSampler>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr)) }))));
		}
	}
}

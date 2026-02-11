using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Unity.Profiling.LowLevel.Unsafe;

namespace UnityEngine.Profiling
{
	// Token: 0x0200018E RID: 398
	public sealed class CustomSampler : Sampler
	{
		// Token: 0x06001DDE RID: 7646 RVA: 0x00087D98 File Offset: 0x00085F98
		// Note: this type is marked as 'beforefieldinit'.
		static CustomSampler()
		{
			Il2CppClassPointerStore<CustomSampler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Profiling", "CustomSampler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomSampler>.NativeClassPtr);
			CustomSampler.NativeFieldInfoPtr_s_InvalidCustomSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomSampler>.NativeClassPtr, "s_InvalidCustomSampler");
			CustomSampler.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSampler>.NativeClassPtr, 100667435);
			CustomSampler.NativeMethodInfoPtr_Create_Public_Static_CustomSampler_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSampler>.NativeClassPtr, 100667437);
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x00087E04 File Offset: 0x00086004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677636, XrefRangeEnd = 677644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomSampler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomSampler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomSampler.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x00087E40 File Offset: 0x00086040
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 677653, RefRangeEnd = 677657, XrefRangeStart = 677644, XrefRangeEnd = 677653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CustomSampler Create(string name, bool collectGpuData = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref collectGpuData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomSampler.NativeMethodInfoPtr_Create_Public_Static_CustomSampler_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomSampler>(intPtr3) : null;
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x0000B316 File Offset: 0x00009516
		public CustomSampler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06001DE2 RID: 7650 RVA: 0x00087E94 File Offset: 0x00086094
		// (set) Token: 0x06001DE3 RID: 7651 RVA: 0x0000B31F File Offset: 0x0000951F
		public unsafe static CustomSampler s_InvalidCustomSampler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CustomSampler.NativeFieldInfoPtr_s_InvalidCustomSampler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CustomSampler.NativeFieldInfoPtr_s_InvalidCustomSampler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06001DE4 RID: 7652 RVA: 0x0000B331 File Offset: 0x00009531
		public void Begin()
		{
			Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility.BeginSample(base.m_Ptr);
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x0000B340 File Offset: 0x00009540
		public void Begin(Object targetObject)
		{
			Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility.Internal_BeginWithObject(base.m_Ptr, targetObject);
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x0000B350 File Offset: 0x00009550
		public void End()
		{
			Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility.EndSample(base.m_Ptr);
		}

		// Token: 0x04001A50 RID: 6736
		private static readonly IntPtr NativeFieldInfoPtr_s_InvalidCustomSampler;

		// Token: 0x04001A51 RID: 6737
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04001A52 RID: 6738
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_CustomSampler_String_Boolean_0;
	}
}

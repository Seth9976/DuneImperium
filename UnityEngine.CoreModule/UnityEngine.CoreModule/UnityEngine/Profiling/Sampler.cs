using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Profiling.LowLevel.Unsafe;

namespace UnityEngine.Profiling
{
	// Token: 0x0200018D RID: 397
	public class Sampler : Object
	{
		// Token: 0x06001DD2 RID: 7634 RVA: 0x00087AC8 File Offset: 0x00085CC8
		// Note: this type is marked as 'beforefieldinit'.
		static Sampler()
		{
			Il2CppClassPointerStore<Sampler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Profiling", "Sampler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sampler>.NativeClassPtr);
			Sampler.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "m_Ptr");
			Sampler.NativeFieldInfoPtr_s_InvalidSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "s_InvalidSampler");
			Sampler.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100667431);
			Sampler.NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100667432);
			Sampler.NativeMethodInfoPtr_GetRecorder_Public_Recorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100667433);
		}

		// Token: 0x06001DD3 RID: 7635 RVA: 0x00087B5C File Offset: 0x00085D5C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sampler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sampler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06001DD4 RID: 7636 RVA: 0x00087B98 File Offset: 0x00085D98
		public unsafe bool isValid
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 677620, RefRangeEnd = 677622, XrefRangeStart = 677619, XrefRangeEnd = 677620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DD5 RID: 7637 RVA: 0x00087BD4 File Offset: 0x00085DD4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 677632, RefRangeEnd = 677636, XrefRangeStart = 677622, XrefRangeEnd = 677632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Recorder GetRecorder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_GetRecorder_Public_Recorder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Recorder>(intPtr3) : null;
		}

		// Token: 0x06001DD6 RID: 7638 RVA: 0x0000B2E0 File Offset: 0x000094E0
		public Sampler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001DD7 RID: 7639 RVA: 0x00087C14 File Offset: 0x00085E14
		// (set) Token: 0x06001DD8 RID: 7640 RVA: 0x0000B2E9 File Offset: 0x000094E9
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001DD9 RID: 7641 RVA: 0x00087C3C File Offset: 0x00085E3C
		// (set) Token: 0x06001DDA RID: 7642 RVA: 0x0000B304 File Offset: 0x00009504
		public unsafe static Sampler s_InvalidSampler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Sampler.NativeFieldInfoPtr_s_InvalidSampler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Sampler.NativeFieldInfoPtr_s_InvalidSampler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x00087C64 File Offset: 0x00085E64
		public static Sampler Get(string name)
		{
			IntPtr marker = Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility.GetMarker(name);
			bool flag = marker == IntPtr.Zero;
			Sampler sampler;
			if (flag)
			{
				sampler = Sampler.s_InvalidSampler;
			}
			else
			{
				sampler = new Sampler(marker);
			}
			return sampler;
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x00087C9C File Offset: 0x00085E9C
		public static int GetNames(List<string> names)
		{
			List<Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle> list = new List<Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle>();
			Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle.GetAvailable(list);
			bool flag = names != null;
			if (flag)
			{
				bool flag2 = names.Count < list.Count;
				if (flag2)
				{
					names.Capacity = list.Count;
					for (int i = names.Count; i < list.Count; i++)
					{
						names.Add(null);
					}
				}
				int num = 0;
				List<Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle>.Enumerator enumerator = list.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle profilerRecorderHandle = enumerator.Current;
						names[num] = Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle.GetDescription(profilerRecorderHandle).Name;
						num++;
					}
				}
				finally
				{
					enumerator.Dispose();
				}
			}
			return list.Count;
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06001DDD RID: 7645 RVA: 0x00087D78 File Offset: 0x00085F78
		public string name
		{
			get
			{
				return Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility.Internal_GetName(this.m_Ptr);
			}
		}

		// Token: 0x04001A4B RID: 6731
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04001A4C RID: 6732
		private static readonly IntPtr NativeFieldInfoPtr_s_InvalidSampler;

		// Token: 0x04001A4D RID: 6733
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04001A4E RID: 6734
		private static readonly IntPtr NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0;

		// Token: 0x04001A4F RID: 6735
		private static readonly IntPtr NativeMethodInfoPtr_GetRecorder_Public_Recorder_0;
	}
}

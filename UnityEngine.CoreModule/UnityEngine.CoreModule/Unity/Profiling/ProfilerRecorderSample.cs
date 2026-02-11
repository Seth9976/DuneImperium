using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Profiling
{
	// Token: 0x0200001C RID: 28
	[StructLayout(2)]
	public struct ProfilerRecorderSample
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x00018558 File Offset: 0x00016758
		// Note: this type is marked as 'beforefieldinit'.
		static ProfilerRecorderSample()
		{
			Il2CppClassPointerStore<ProfilerRecorderSample>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling", "ProfilerRecorderSample");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerRecorderSample>.NativeClassPtr);
			ProfilerRecorderSample.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderSample>.NativeClassPtr, "value");
			ProfilerRecorderSample.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderSample>.NativeClassPtr, "count");
			ProfilerRecorderSample.NativeFieldInfoPtr_refValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderSample>.NativeClassPtr, "refValue");
			ProfilerRecorderSample.NativeMethodInfoPtr_get_Count_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderSample>.NativeClassPtr, 100663371);
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x000185D8 File Offset: 0x000167D8
		public unsafe long Count
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorderSample.NativeMethodInfoPtr_get_Count_Public_get_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000025E4 File Offset: 0x000007E4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerRecorderSample>.NativeClassPtr, ref this));
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x000025F6 File Offset: 0x000007F6
		public long Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeFieldInfoPtr_refValue;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int64_0;

		// Token: 0x04000096 RID: 150
		[FieldOffset(0)]
		public long value;

		// Token: 0x04000097 RID: 151
		[FieldOffset(8)]
		public long count;

		// Token: 0x04000098 RID: 152
		[FieldOffset(16)]
		public long refValue;
	}
}

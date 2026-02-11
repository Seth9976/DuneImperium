using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000198 RID: 408
	public static class PlatformHelper : Object
	{
		// Token: 0x06001A88 RID: 6792 RVA: 0x000A21F8 File Offset: 0x000A03F8
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformHelper()
		{
			Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "PlatformHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr);
			PlatformHelper.NativeFieldInfoPtr_s_processorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr, "s_processorCount");
			PlatformHelper.NativeFieldInfoPtr_s_lastProcessorCountRefreshTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr, "s_lastProcessorCountRefreshTicks");
			PlatformHelper.NativeFieldInfoPtr_IsSingleProcessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr, "IsSingleProcessor");
			PlatformHelper.NativeMethodInfoPtr_get_ProcessorCount_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr, 100667911);
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06001A89 RID: 6793 RVA: 0x000A2278 File Offset: 0x000A0478
		public unsafe static int ProcessorCount
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1352272, RefRangeEnd = 1352281, XrefRangeStart = 1352262, XrefRangeEnd = 1352272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformHelper.NativeMethodInfoPtr_get_ProcessorCount_Internal_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x00008732 File Offset: 0x00006932
		public PlatformHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06001A8B RID: 6795 RVA: 0x000A22A8 File Offset: 0x000A04A8
		// (set) Token: 0x06001A8C RID: 6796 RVA: 0x0000873B File Offset: 0x0000693B
		public unsafe static int s_processorCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PlatformHelper.NativeFieldInfoPtr_s_processorCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformHelper.NativeFieldInfoPtr_s_processorCount, (void*)(&value));
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06001A8D RID: 6797 RVA: 0x000A22C4 File Offset: 0x000A04C4
		// (set) Token: 0x06001A8E RID: 6798 RVA: 0x00008749 File Offset: 0x00006949
		public unsafe static int s_lastProcessorCountRefreshTicks
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PlatformHelper.NativeFieldInfoPtr_s_lastProcessorCountRefreshTicks, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformHelper.NativeFieldInfoPtr_s_lastProcessorCountRefreshTicks, (void*)(&value));
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06001A8F RID: 6799 RVA: 0x000A22E0 File Offset: 0x000A04E0
		// (set) Token: 0x06001A90 RID: 6800 RVA: 0x00008757 File Offset: 0x00006957
		public unsafe static bool IsSingleProcessor
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(PlatformHelper.NativeFieldInfoPtr_IsSingleProcessor, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformHelper.NativeFieldInfoPtr_IsSingleProcessor, (void*)(&value));
			}
		}

		// Token: 0x04001882 RID: 6274
		private static readonly IntPtr NativeFieldInfoPtr_s_processorCount;

		// Token: 0x04001883 RID: 6275
		private static readonly IntPtr NativeFieldInfoPtr_s_lastProcessorCountRefreshTicks;

		// Token: 0x04001884 RID: 6276
		private static readonly IntPtr NativeFieldInfoPtr_IsSingleProcessor;

		// Token: 0x04001885 RID: 6277
		private static readonly IntPtr NativeMethodInfoPtr_get_ProcessorCount_Internal_Static_get_Int32_0;
	}
}

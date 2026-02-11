using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dwd.core.data
{
	// Token: 0x020001C9 RID: 457
	public static class ReflectionTypeInitializer : Object
	{
		// Token: 0x06001961 RID: 6497 RVA: 0x00078B8C File Offset: 0x00076D8C
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionTypeInitializer()
		{
			Il2CppClassPointerStore<ReflectionTypeInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data", "ReflectionTypeInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionTypeInitializer>.NativeClassPtr);
			ReflectionTypeInitializer.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionTypeInitializer>.NativeClassPtr, "initialized");
			ReflectionTypeInitializer.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTypeInitializer>.NativeClassPtr, 100667332);
		}

		// Token: 0x06001962 RID: 6498 RVA: 0x00078BE4 File Offset: 0x00076DE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 881323, RefRangeEnd = 881324, XrefRangeStart = 881185, XrefRangeEnd = 881323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTypeInitializer.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x0000B238 File Offset: 0x00009438
		public ReflectionTypeInitializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x00078C0C File Offset: 0x00076E0C
		// (set) Token: 0x06001965 RID: 6501 RVA: 0x0000B241 File Offset: 0x00009441
		public unsafe static bool initialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ReflectionTypeInitializer.NativeFieldInfoPtr_initialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectionTypeInitializer.NativeFieldInfoPtr_initialized, (void*)(&value));
			}
		}

		// Token: 0x040011D7 RID: 4567
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x040011D8 RID: 4568
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
	}
}

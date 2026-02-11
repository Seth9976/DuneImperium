using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Internal.Runtime.Augments
{
	// Token: 0x02000052 RID: 82
	public class RuntimeAugments : Object
	{
		// Token: 0x06000420 RID: 1056 RVA: 0x0003602C File Offset: 0x0003422C
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeAugments()
		{
			Il2CppClassPointerStore<RuntimeAugments>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Internal.Runtime.Augments", "RuntimeAugments");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeAugments>.NativeClassPtr);
			RuntimeAugments.NativeFieldInfoPtr_s_reflectionExecutionDomainCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeAugments>.NativeClassPtr, "s_reflectionExecutionDomainCallbacks");
			RuntimeAugments.NativeMethodInfoPtr_ReportUnhandledException_Public_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAugments>.NativeClassPtr, 100663918);
			RuntimeAugments.NativeMethodInfoPtr_get_Callbacks_Internal_Static_get_ReflectionExecutionDomainCallbacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAugments>.NativeClassPtr, 100663919);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00036098 File Offset: 0x00034298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1281165, RefRangeEnd = 1281166, XrefRangeStart = 1281154, XrefRangeEnd = 1281165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReportUnhandledException(Exception exception)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeAugments.NativeMethodInfoPtr_ReportUnhandledException_Public_Static_Void_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x000360D0 File Offset: 0x000342D0
		public unsafe static ReflectionExecutionDomainCallbacks Callbacks
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281166, XrefRangeEnd = 1281170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeAugments.NativeMethodInfoPtr_get_Callbacks_Internal_Static_get_ReflectionExecutionDomainCallbacks_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReflectionExecutionDomainCallbacks>(intPtr3) : null;
			}
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x000037EF File Offset: 0x000019EF
		public RuntimeAugments(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x00036104 File Offset: 0x00034304
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x000037F8 File Offset: 0x000019F8
		public unsafe static ReflectionExecutionDomainCallbacks s_reflectionExecutionDomainCallbacks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeAugments.NativeFieldInfoPtr_s_reflectionExecutionDomainCallbacks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionExecutionDomainCallbacks>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeAugments.NativeFieldInfoPtr_s_reflectionExecutionDomainCallbacks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeFieldInfoPtr_s_reflectionExecutionDomainCallbacks;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeMethodInfoPtr_ReportUnhandledException_Public_Static_Void_Exception_0;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeMethodInfoPtr_get_Callbacks_Internal_Static_get_ReflectionExecutionDomainCallbacks_0;
	}
}

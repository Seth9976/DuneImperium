using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.util
{
	// Token: 0x02000097 RID: 151
	public static class ThreadUtil : Object
	{
		// Token: 0x06000A78 RID: 2680 RVA: 0x0003B518 File Offset: 0x00039718
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadUtil()
		{
			Il2CppClassPointerStore<ThreadUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.util", "ThreadUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadUtil>.NativeClassPtr);
			ThreadUtil.NativeMethodInfoPtr_AddUnhandledExceptionHandling_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadUtil>.NativeClassPtr, 100664750);
			ThreadUtil.NativeMethodInfoPtr_RemoveUnhandledExceptionHandling_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadUtil>.NativeClassPtr, 100664751);
			ThreadUtil.NativeMethodInfoPtr_LogUnhandledException_Private_Static_Void_Object_UnhandledExceptionEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadUtil>.NativeClassPtr, 100664752);
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x0003B584 File Offset: 0x00039784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862820, XrefRangeEnd = 862834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddUnhandledExceptionHandling()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadUtil.NativeMethodInfoPtr_AddUnhandledExceptionHandling_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x0003B5AC File Offset: 0x000397AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862834, XrefRangeEnd = 862848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveUnhandledExceptionHandling()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadUtil.NativeMethodInfoPtr_RemoveUnhandledExceptionHandling_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x0003B5D4 File Offset: 0x000397D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862848, XrefRangeEnd = 862855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogUnhandledException(Object sender, UnhandledExceptionEventArgs args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadUtil.NativeMethodInfoPtr_LogUnhandledException_Private_Static_Void_Object_UnhandledExceptionEventArgs_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x00005BDD File Offset: 0x00003DDD
		public ThreadUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeMethodInfoPtr_AddUnhandledExceptionHandling_Public_Static_Void_0;

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeMethodInfoPtr_RemoveUnhandledExceptionHandling_Public_Static_Void_0;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeMethodInfoPtr_LogUnhandledException_Private_Static_Void_Object_UnhandledExceptionEventArgs_0;

		// Token: 0x0200028F RID: 655
		[ObfuscatedName("dwd.core.util.ThreadUtil+<>O")]
		public static class __O : Object
		{
			// Token: 0x06001F6B RID: 8043 RVA: 0x0000D63E File Offset: 0x0000B83E
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<ThreadUtil.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThreadUtil>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadUtil.__O>.NativeClassPtr);
				ThreadUtil.__O.NativeFieldInfoPtr__0___LogUnhandledException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadUtil.__O>.NativeClassPtr, "<0>__LogUnhandledException");
			}

			// Token: 0x06001F6C RID: 8044 RVA: 0x0000D672 File Offset: 0x0000B872
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700089E RID: 2206
			// (get) Token: 0x06001F6D RID: 8045 RVA: 0x0008E974 File Offset: 0x0008CB74
			// (set) Token: 0x06001F6E RID: 8046 RVA: 0x0000D67B File Offset: 0x0000B87B
			public unsafe static UnhandledExceptionEventHandler _0___LogUnhandledException
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ThreadUtil.__O.NativeFieldInfoPtr__0___LogUnhandledException, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnhandledExceptionEventHandler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ThreadUtil.__O.NativeFieldInfoPtr__0___LogUnhandledException, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400160B RID: 5643
			private static readonly IntPtr NativeFieldInfoPtr__0___LogUnhandledException;
		}
	}
}

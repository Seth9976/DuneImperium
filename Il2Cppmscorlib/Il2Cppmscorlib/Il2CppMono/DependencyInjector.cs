using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono
{
	// Token: 0x02000006 RID: 6
	public static class DependencyInjector : Object
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00025A94 File Offset: 0x00023C94
		// Note: this type is marked as 'beforefieldinit'.
		static DependencyInjector()
		{
			Il2CppClassPointerStore<DependencyInjector>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "DependencyInjector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DependencyInjector>.NativeClassPtr);
			DependencyInjector.NativeFieldInfoPtr_locker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DependencyInjector>.NativeClassPtr, "locker");
			DependencyInjector.NativeFieldInfoPtr_systemDependency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DependencyInjector>.NativeClassPtr, "systemDependency");
			DependencyInjector.NativeMethodInfoPtr_get_SystemProvider_Internal_Static_get_ISystemDependencyProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DependencyInjector>.NativeClassPtr, 100663376);
			DependencyInjector.NativeMethodInfoPtr_Register_Internal_Static_Void_ISystemDependencyProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DependencyInjector>.NativeClassPtr, 100663377);
			DependencyInjector.NativeMethodInfoPtr_ReflectionLoad_Private_Static_ISystemDependencyProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DependencyInjector>.NativeClassPtr, 100663378);
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00025B28 File Offset: 0x00023D28
		public unsafe static ISystemDependencyProvider SystemProvider
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1275859, RefRangeEnd = 1275860, XrefRangeStart = 1275816, XrefRangeEnd = 1275859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DependencyInjector.NativeMethodInfoPtr_get_SystemProvider_Internal_Static_get_ISystemDependencyProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISystemDependencyProvider>(intPtr3) : null;
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00025B5C File Offset: 0x00023D5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1275877, RefRangeEnd = 1275879, XrefRangeStart = 1275860, XrefRangeEnd = 1275877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Register(ISystemDependencyProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DependencyInjector.NativeMethodInfoPtr_Register_Internal_Static_Void_ISystemDependencyProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00025B94 File Offset: 0x00023D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275879, XrefRangeEnd = 1275897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ISystemDependencyProvider ReflectionLoad()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DependencyInjector.NativeMethodInfoPtr_ReflectionLoad_Private_Static_ISystemDependencyProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISystemDependencyProvider>(intPtr3) : null;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000020DD File Offset: 0x000002DD
		public DependencyInjector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00025BC8 File Offset: 0x00023DC8
		// (set) Token: 0x0600001C RID: 28 RVA: 0x000020E6 File Offset: 0x000002E6
		public unsafe static Object locker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DependencyInjector.NativeFieldInfoPtr_locker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DependencyInjector.NativeFieldInfoPtr_locker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00025BF0 File Offset: 0x00023DF0
		// (set) Token: 0x0600001E RID: 30 RVA: 0x000020F8 File Offset: 0x000002F8
		public unsafe static ISystemDependencyProvider systemDependency
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DependencyInjector.NativeFieldInfoPtr_systemDependency, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISystemDependencyProvider>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DependencyInjector.NativeFieldInfoPtr_systemDependency, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr_locker;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr_systemDependency;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_get_SystemProvider_Internal_Static_get_ISystemDependencyProvider_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_Register_Internal_Static_Void_ISystemDependencyProvider_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_ReflectionLoad_Private_Static_ISystemDependencyProvider_0;
	}
}

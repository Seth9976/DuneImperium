using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Win32
{
	// Token: 0x0200003C RID: 60
	public static class Registry : Object
	{
		// Token: 0x0600037B RID: 891 RVA: 0x00033694 File Offset: 0x00031894
		// Note: this type is marked as 'beforefieldinit'.
		static Registry()
		{
			Il2CppClassPointerStore<Registry>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32", "Registry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Registry>.NativeClassPtr);
			Registry.NativeFieldInfoPtr_CurrentUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "CurrentUser");
			Registry.NativeFieldInfoPtr_LocalMachine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "LocalMachine");
			Registry.NativeFieldInfoPtr_ClassesRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "ClassesRoot");
			Registry.NativeFieldInfoPtr_Users = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "Users");
			Registry.NativeFieldInfoPtr_PerformanceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "PerformanceData");
			Registry.NativeFieldInfoPtr_CurrentConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "CurrentConfig");
			Registry.NativeFieldInfoPtr_DynData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "DynData");
		}

		// Token: 0x0600037C RID: 892 RVA: 0x000035BA File Offset: 0x000017BA
		public Registry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600037D RID: 893 RVA: 0x00033750 File Offset: 0x00031950
		// (set) Token: 0x0600037E RID: 894 RVA: 0x000035C3 File Offset: 0x000017C3
		public unsafe static RegistryKey CurrentUser
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Registry.NativeFieldInfoPtr_CurrentUser, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Registry.NativeFieldInfoPtr_CurrentUser, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600037F RID: 895 RVA: 0x00033778 File Offset: 0x00031978
		// (set) Token: 0x06000380 RID: 896 RVA: 0x000035D5 File Offset: 0x000017D5
		public unsafe static RegistryKey LocalMachine
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Registry.NativeFieldInfoPtr_LocalMachine, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Registry.NativeFieldInfoPtr_LocalMachine, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000381 RID: 897 RVA: 0x000337A0 File Offset: 0x000319A0
		// (set) Token: 0x06000382 RID: 898 RVA: 0x000035E7 File Offset: 0x000017E7
		public unsafe static RegistryKey ClassesRoot
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Registry.NativeFieldInfoPtr_ClassesRoot, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Registry.NativeFieldInfoPtr_ClassesRoot, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000383 RID: 899 RVA: 0x000337C8 File Offset: 0x000319C8
		// (set) Token: 0x06000384 RID: 900 RVA: 0x000035F9 File Offset: 0x000017F9
		public unsafe static RegistryKey Users
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Registry.NativeFieldInfoPtr_Users, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Registry.NativeFieldInfoPtr_Users, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000385 RID: 901 RVA: 0x000337F0 File Offset: 0x000319F0
		// (set) Token: 0x06000386 RID: 902 RVA: 0x0000360B File Offset: 0x0000180B
		public unsafe static RegistryKey PerformanceData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Registry.NativeFieldInfoPtr_PerformanceData, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Registry.NativeFieldInfoPtr_PerformanceData, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000387 RID: 903 RVA: 0x00033818 File Offset: 0x00031A18
		// (set) Token: 0x06000388 RID: 904 RVA: 0x0000361D File Offset: 0x0000181D
		public unsafe static RegistryKey CurrentConfig
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Registry.NativeFieldInfoPtr_CurrentConfig, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Registry.NativeFieldInfoPtr_CurrentConfig, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000389 RID: 905 RVA: 0x00033840 File Offset: 0x00031A40
		// (set) Token: 0x0600038A RID: 906 RVA: 0x0000362F File Offset: 0x0000182F
		public unsafe static RegistryKey DynData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Registry.NativeFieldInfoPtr_DynData, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Registry.NativeFieldInfoPtr_DynData, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeFieldInfoPtr_CurrentUser;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeFieldInfoPtr_LocalMachine;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeFieldInfoPtr_ClassesRoot;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeFieldInfoPtr_Users;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeFieldInfoPtr_PerformanceData;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeFieldInfoPtr_CurrentConfig;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeFieldInfoPtr_DynData;
	}
}

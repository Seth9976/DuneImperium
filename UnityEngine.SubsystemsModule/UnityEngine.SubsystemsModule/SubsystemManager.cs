using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.SubsystemsImplementation;

namespace UnityEngine
{
	// Token: 0x0200000C RID: 12
	public static class SubsystemManager : Object
	{
		// Token: 0x0600003C RID: 60 RVA: 0x00002E14 File Offset: 0x00001014
		// Note: this type is marked as 'beforefieldinit'.
		static SubsystemManager()
		{
			Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SubsystemsModule.dll", "UnityEngine", "SubsystemManager");
			SubsystemManager.NativeFieldInfoPtr_beforeReloadSubsystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, "beforeReloadSubsystems");
			SubsystemManager.NativeFieldInfoPtr_afterReloadSubsystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, "afterReloadSubsystems");
			SubsystemManager.NativeFieldInfoPtr_s_IntegratedSubsystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, "s_IntegratedSubsystems");
			SubsystemManager.NativeFieldInfoPtr_s_StandaloneSubsystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, "s_StandaloneSubsystems");
			SubsystemManager.NativeFieldInfoPtr_s_DeprecatedSubsystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, "s_DeprecatedSubsystems");
			SubsystemManager.NativeFieldInfoPtr_reloadSubsytemsStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, "reloadSubsytemsStarted");
			SubsystemManager.NativeFieldInfoPtr_reloadSubsytemsCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, "reloadSubsytemsCompleted");
			SubsystemManager.NativeMethodInfoPtr_ReloadSubsystemsStarted_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, 100663312);
			SubsystemManager.NativeMethodInfoPtr_ReloadSubsystemsCompleted_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, 100663313);
			SubsystemManager.NativeMethodInfoPtr_InitializeIntegratedSubsystem_Private_Static_Void_IntPtr_IntegratedSubsystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, 100663314);
			SubsystemManager.NativeMethodInfoPtr_ClearSubsystems_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, 100663315);
			SubsystemManager.NativeMethodInfoPtr_StaticConstructScriptingClassMap_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, 100663316);
			SubsystemManager.NativeMethodInfoPtr_GetSubsystems_Public_Static_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, 100663318);
			SubsystemManager.NativeMethodInfoPtr_AddSubsystemSubset_Private_Static_Void_List_1_TBaseTypeInList_List_1_TQueryType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, 100663319);
			SubsystemManager.NativeMethodInfoPtr_GetIntegratedSubsystemByPtr_Internal_Static_IntegratedSubsystem_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, 100663320);
			SubsystemManager.NativeMethodInfoPtr_GetInstances_Public_Static_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, 100663321);
			SubsystemManager.ReportSingleSubsystemAnalyticsDelegateField = IL2CPP.ResolveICall<SubsystemManager.ReportSingleSubsystemAnalyticsDelegate>("UnityEngine.SubsystemManager::ReportSingleSubsystemAnalytics");
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002F8C File Offset: 0x0000118C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270160, XrefRangeEnd = 1270171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReloadSubsystemsStarted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubsystemManager.NativeMethodInfoPtr_ReloadSubsystemsStarted_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002FB4 File Offset: 0x000011B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270171, XrefRangeEnd = 1270182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReloadSubsystemsCompleted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubsystemManager.NativeMethodInfoPtr_ReloadSubsystemsCompleted_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002FDC File Offset: 0x000011DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270182, XrefRangeEnd = 1270194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeIntegratedSubsystem(IntPtr ptr, IntegratedSubsystem subsystem)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subsystem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubsystemManager.NativeMethodInfoPtr_InitializeIntegratedSubsystem_Private_Static_Void_IntPtr_IntegratedSubsystem_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003020 File Offset: 0x00001220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270194, XrefRangeEnd = 1270223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearSubsystems()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubsystemManager.NativeMethodInfoPtr_ClearSubsystems_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003048 File Offset: 0x00001248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270223, XrefRangeEnd = 1270255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StaticConstructScriptingClassMap()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubsystemManager.NativeMethodInfoPtr_StaticConstructScriptingClassMap_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003070 File Offset: 0x00001270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270255, XrefRangeEnd = 1270267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSubsystems<T>(List<T> subsystems)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(subsystems);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubsystemManager.MethodInfoStoreGeneric_GetSubsystems_Public_Static_Void_List_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000030A8 File Offset: 0x000012A8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1270282, RefRangeEnd = 1270288, XrefRangeStart = 1270267, XrefRangeEnd = 1270282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddSubsystemSubset<TBaseTypeInList, TQueryType>(List<TBaseTypeInList> copyFrom, List<TQueryType> copyTo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(copyFrom);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(copyTo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubsystemManager.MethodInfoStoreGeneric_AddSubsystemSubset_Private_Static_Void_List_1_TBaseTypeInList_List_1_TQueryType_0<TBaseTypeInList, TQueryType>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000030F0 File Offset: 0x000012F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1270309, RefRangeEnd = 1270311, XrefRangeStart = 1270288, XrefRangeEnd = 1270309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntegratedSubsystem GetIntegratedSubsystemByPtr(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubsystemManager.NativeMethodInfoPtr_GetIntegratedSubsystemByPtr_Internal_Static_IntegratedSubsystem_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntegratedSubsystem>(intPtr3) : null;
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003130 File Offset: 0x00001330
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1270335, RefRangeEnd = 1270338, XrefRangeStart = 1270311, XrefRangeEnd = 1270335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetInstances<T>(List<T> subsystems)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(subsystems);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubsystemManager.MethodInfoStoreGeneric_GetInstances_Public_Static_Void_List_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002264 File Offset: 0x00000464
		public SubsystemManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00003168 File Offset: 0x00001368
		// (set) Token: 0x06000048 RID: 72 RVA: 0x0000226D File Offset: 0x0000046D
		public unsafe static Action beforeReloadSubsystems
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubsystemManager.NativeFieldInfoPtr_beforeReloadSubsystems, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubsystemManager.NativeFieldInfoPtr_beforeReloadSubsystems, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00003190 File Offset: 0x00001390
		// (set) Token: 0x0600004A RID: 74 RVA: 0x0000227F File Offset: 0x0000047F
		public unsafe static Action afterReloadSubsystems
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubsystemManager.NativeFieldInfoPtr_afterReloadSubsystems, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubsystemManager.NativeFieldInfoPtr_afterReloadSubsystems, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600004B RID: 75 RVA: 0x000031B8 File Offset: 0x000013B8
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00002291 File Offset: 0x00000491
		public unsafe static List<IntegratedSubsystem> s_IntegratedSubsystems
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubsystemManager.NativeFieldInfoPtr_s_IntegratedSubsystems, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IntegratedSubsystem>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubsystemManager.NativeFieldInfoPtr_s_IntegratedSubsystems, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600004D RID: 77 RVA: 0x000031E0 File Offset: 0x000013E0
		// (set) Token: 0x0600004E RID: 78 RVA: 0x000022A3 File Offset: 0x000004A3
		public unsafe static List<UnityEngine.SubsystemsImplementation.SubsystemWithProvider> s_StandaloneSubsystems
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubsystemManager.NativeFieldInfoPtr_s_StandaloneSubsystems, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnityEngine.SubsystemsImplementation.SubsystemWithProvider>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubsystemManager.NativeFieldInfoPtr_s_StandaloneSubsystems, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00003208 File Offset: 0x00001408
		// (set) Token: 0x06000050 RID: 80 RVA: 0x000022B5 File Offset: 0x000004B5
		public unsafe static List<Subsystem> s_DeprecatedSubsystems
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubsystemManager.NativeFieldInfoPtr_s_DeprecatedSubsystems, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Subsystem>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubsystemManager.NativeFieldInfoPtr_s_DeprecatedSubsystems, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00003230 File Offset: 0x00001430
		// (set) Token: 0x06000052 RID: 82 RVA: 0x000022C7 File Offset: 0x000004C7
		public unsafe static Action reloadSubsytemsStarted
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubsystemManager.NativeFieldInfoPtr_reloadSubsytemsStarted, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubsystemManager.NativeFieldInfoPtr_reloadSubsytemsStarted, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00003258 File Offset: 0x00001458
		// (set) Token: 0x06000054 RID: 84 RVA: 0x000022D9 File Offset: 0x000004D9
		public unsafe static Action reloadSubsytemsCompleted
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubsystemManager.NativeFieldInfoPtr_reloadSubsytemsCompleted, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubsystemManager.NativeFieldInfoPtr_reloadSubsytemsCompleted, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000022EB File Offset: 0x000004EB
		public static void ReportSingleSubsystemAnalytics(string id)
		{
			SubsystemManager.ReportSingleSubsystemAnalyticsDelegateField(IL2CPP.ManagedStringToIl2Cpp(id));
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000022FD File Offset: 0x000004FD
		public static void GetAllSubsystemDescriptors(List<ISubsystemDescriptor> descriptors)
		{
			UnityEngine.SubsystemsImplementation.SubsystemDescriptorStore.GetAllSubsystemDescriptors(descriptors);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002307 File Offset: 0x00000507
		public static void GetSubsystemDescriptors<T>(List<T> descriptors)
		{
			UnityEngine.SubsystemsImplementation.SubsystemDescriptorStore.GetSubsystemDescriptors<T>(descriptors);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002311 File Offset: 0x00000511
		public static void add_beforeReloadSubsystems(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000231E File Offset: 0x0000051E
		public static void remove_beforeReloadSubsystems(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000232B File Offset: 0x0000052B
		public static void add_afterReloadSubsystems(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002338 File Offset: 0x00000538
		public static void remove_afterReloadSubsystems(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003280 File Offset: 0x00001480
		public static void RemoveIntegratedSubsystemByPtr(IntPtr ptr)
		{
			for (int i = 0; i < SubsystemManager.s_IntegratedSubsystems.Count; i++)
			{
				bool flag = SubsystemManager.s_IntegratedSubsystems[i].m_Ptr != ptr;
				if (!flag)
				{
					SubsystemManager.s_IntegratedSubsystems[i].m_Ptr = IntPtr.Zero;
					SubsystemManager.s_IntegratedSubsystems.RemoveAt(i);
					break;
				}
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002345 File Offset: 0x00000545
		public static void AddStandaloneSubsystem(UnityEngine.SubsystemsImplementation.SubsystemWithProvider subsystem)
		{
			SubsystemManager.s_StandaloneSubsystems.Add(subsystem);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000032E8 File Offset: 0x000014E8
		public static bool RemoveStandaloneSubsystem(UnityEngine.SubsystemsImplementation.SubsystemWithProvider subsystem)
		{
			return SubsystemManager.s_StandaloneSubsystems.Remove(subsystem);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00003308 File Offset: 0x00001508
		public static UnityEngine.SubsystemsImplementation.SubsystemWithProvider FindStandaloneSubsystemByDescriptor(UnityEngine.SubsystemsImplementation.SubsystemDescriptorWithProvider descriptor)
		{
			List<UnityEngine.SubsystemsImplementation.SubsystemWithProvider>.Enumerator enumerator = SubsystemManager.s_StandaloneSubsystems.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					UnityEngine.SubsystemsImplementation.SubsystemWithProvider subsystemWithProvider = enumerator.Current;
					bool flag = subsystemWithProvider.descriptor == descriptor;
					if (flag)
					{
						return subsystemWithProvider;
					}
				}
			}
			finally
			{
				enumerator.Dispose();
			}
			return null;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002354 File Offset: 0x00000554
		public static void AddDeprecatedSubsystem(Subsystem subsystem)
		{
			SubsystemManager.s_DeprecatedSubsystems.Add(subsystem);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002362 File Offset: 0x00000562
		public static bool RemoveDeprecatedSubsystem(Subsystem subsystem)
		{
			return SubsystemManager.s_DeprecatedSubsystems.Remove(subsystem);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000236F File Offset: 0x0000056F
		public static Subsystem FindDeprecatedSubsystemByDescriptor(SubsystemDescriptor descriptor)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000237C File Offset: 0x0000057C
		public static void add_reloadSubsytemsStarted(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002389 File Offset: 0x00000589
		public static void remove_reloadSubsytemsStarted(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002396 File Offset: 0x00000596
		public static void add_reloadSubsytemsCompleted(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000023A3 File Offset: 0x000005A3
		public static void remove_reloadSubsytemsCompleted(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeFieldInfoPtr_beforeReloadSubsystems;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeFieldInfoPtr_afterReloadSubsystems;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr_s_IntegratedSubsystems;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeFieldInfoPtr_s_StandaloneSubsystems;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeFieldInfoPtr_s_DeprecatedSubsystems;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeFieldInfoPtr_reloadSubsytemsStarted;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeFieldInfoPtr_reloadSubsytemsCompleted;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_ReloadSubsystemsStarted_Private_Static_Void_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_ReloadSubsystemsCompleted_Private_Static_Void_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_InitializeIntegratedSubsystem_Private_Static_Void_IntPtr_IntegratedSubsystem_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_ClearSubsystems_Private_Static_Void_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_StaticConstructScriptingClassMap_Private_Static_Void_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_GetSubsystems_Public_Static_Void_List_1_T_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_AddSubsystemSubset_Private_Static_Void_List_1_TBaseTypeInList_List_1_TQueryType_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_GetIntegratedSubsystemByPtr_Internal_Static_IntegratedSubsystem_IntPtr_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_GetInstances_Public_Static_Void_List_1_T_0;

		// Token: 0x04000027 RID: 39
		private static readonly SubsystemManager.ReportSingleSubsystemAnalyticsDelegate ReportSingleSubsystemAnalyticsDelegateField;

		// Token: 0x0200001A RID: 26
		private sealed class MethodInfoStoreGeneric_GetSubsystems_Public_Static_Void_List_1_T_0<T>
		{
			// Token: 0x0400003B RID: 59
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SubsystemManager.NativeMethodInfoPtr_GetSubsystems_Public_Static_Void_List_1_T_0, Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200001B RID: 27
		private sealed class MethodInfoStoreGeneric_AddSubsystemSubset_Private_Static_Void_List_1_TBaseTypeInList_List_1_TQueryType_0<TBaseTypeInList, TQueryType>
		{
			// Token: 0x0400003C RID: 60
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SubsystemManager.NativeMethodInfoPtr_AddSubsystemSubset_Private_Static_Void_List_1_TBaseTypeInList_List_1_TQueryType_0, Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TBaseTypeInList>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TQueryType>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200001C RID: 28
		private sealed class MethodInfoStoreGeneric_GetInstances_Public_Static_Void_List_1_T_0<T>
		{
			// Token: 0x0400003D RID: 61
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SubsystemManager.NativeMethodInfoPtr_GetInstances_Public_Static_Void_List_1_T_0, Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x060000A4 RID: 164
		private delegate void ReportSingleSubsystemAnalyticsDelegate(IntPtr id);
	}
}

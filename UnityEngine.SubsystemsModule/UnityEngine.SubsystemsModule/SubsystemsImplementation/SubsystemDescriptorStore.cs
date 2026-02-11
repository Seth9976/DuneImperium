using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.SubsystemsImplementation
{
	// Token: 0x0200000D RID: 13
	public static class SubsystemDescriptorStore : Object
	{
		// Token: 0x06000067 RID: 103 RVA: 0x00003370 File Offset: 0x00001570
		// Note: this type is marked as 'beforefieldinit'.
		static SubsystemDescriptorStore()
		{
			Il2CppClassPointerStore<SubsystemDescriptorStore>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SubsystemsModule.dll", "UnityEngine.SubsystemsImplementation", "SubsystemDescriptorStore");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubsystemDescriptorStore>.NativeClassPtr);
			SubsystemDescriptorStore.NativeFieldInfoPtr_s_IntegratedDescriptors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemDescriptorStore>.NativeClassPtr, "s_IntegratedDescriptors");
			SubsystemDescriptorStore.NativeFieldInfoPtr_s_StandaloneDescriptors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemDescriptorStore>.NativeClassPtr, "s_StandaloneDescriptors");
			SubsystemDescriptorStore.NativeFieldInfoPtr_s_DeprecatedDescriptors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemDescriptorStore>.NativeClassPtr, "s_DeprecatedDescriptors");
			SubsystemDescriptorStore.NativeMethodInfoPtr_InitializeManagedDescriptor_Internal_Static_Void_IntPtr_IntegratedSubsystemDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemDescriptorStore>.NativeClassPtr, 100663322);
			SubsystemDescriptorStore.NativeMethodInfoPtr_ClearManagedDescriptors_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemDescriptorStore>.NativeClassPtr, 100663323);
			SubsystemDescriptorStore.NativeMethodInfoPtr_ReportSingleSubsystemAnalytics_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemDescriptorStore>.NativeClassPtr, 100663324);
			SubsystemDescriptorStore.NativeMethodInfoPtr_RegisterDescriptor_Internal_Static_Void_TDescriptor_List_1_TBaseTypeInList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemDescriptorStore>.NativeClassPtr, 100663325);
			SubsystemDescriptorStore.NativeMethodInfoPtr_RegisterDeprecatedDescriptor_Internal_Static_Void_SubsystemDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemDescriptorStore>.NativeClassPtr, 100663326);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003440 File Offset: 0x00001640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270338, XrefRangeEnd = 1270348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeManagedDescriptor(IntPtr ptr, IntegratedSubsystemDescriptor desc)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(desc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubsystemDescriptorStore.NativeMethodInfoPtr_InitializeManagedDescriptor_Internal_Static_Void_IntPtr_IntegratedSubsystemDescriptor_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00003484 File Offset: 0x00001684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270348, XrefRangeEnd = 1270371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearManagedDescriptors()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubsystemDescriptorStore.NativeMethodInfoPtr_ClearManagedDescriptors_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000034AC File Offset: 0x000016AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270371, XrefRangeEnd = 1270401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReportSingleSubsystemAnalytics(string id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubsystemDescriptorStore.NativeMethodInfoPtr_ReportSingleSubsystemAnalytics_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000034E4 File Offset: 0x000016E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1270425, RefRangeEnd = 1270427, XrefRangeStart = 1270401, XrefRangeEnd = 1270425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterDescriptor<TDescriptor, TBaseTypeInList>(TDescriptor descriptor, List<TBaseTypeInList> storeInList) where TDescriptor : TBaseTypeInList
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TDescriptor).IsValueType)
				{
					TDescriptor tdescriptor = descriptor;
					intPtr = ((tdescriptor is string) ? IL2CPP.ManagedStringToIl2Cpp(tdescriptor as string) : IL2CPP.Il2CppObjectBaseToPtr(tdescriptor as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref descriptor;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(storeInList);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SubsystemDescriptorStore.MethodInfoStoreGeneric_RegisterDescriptor_Internal_Static_Void_TDescriptor_List_1_TBaseTypeInList_0<TDescriptor, TBaseTypeInList>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003564 File Offset: 0x00001764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270427, XrefRangeEnd = 1270434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterDeprecatedDescriptor(SubsystemDescriptor descriptor)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(descriptor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubsystemDescriptorStore.NativeMethodInfoPtr_RegisterDeprecatedDescriptor_Internal_Static_Void_SubsystemDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000023B0 File Offset: 0x000005B0
		public SubsystemDescriptorStore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600006E RID: 110 RVA: 0x0000359C File Offset: 0x0000179C
		// (set) Token: 0x0600006F RID: 111 RVA: 0x000023B9 File Offset: 0x000005B9
		public unsafe static List<IntegratedSubsystemDescriptor> s_IntegratedDescriptors
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubsystemDescriptorStore.NativeFieldInfoPtr_s_IntegratedDescriptors, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IntegratedSubsystemDescriptor>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubsystemDescriptorStore.NativeFieldInfoPtr_s_IntegratedDescriptors, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000035C4 File Offset: 0x000017C4
		// (set) Token: 0x06000071 RID: 113 RVA: 0x000023CB File Offset: 0x000005CB
		public unsafe static List<SubsystemDescriptorWithProvider> s_StandaloneDescriptors
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubsystemDescriptorStore.NativeFieldInfoPtr_s_StandaloneDescriptors, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SubsystemDescriptorWithProvider>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubsystemDescriptorStore.NativeFieldInfoPtr_s_StandaloneDescriptors, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000035EC File Offset: 0x000017EC
		// (set) Token: 0x06000073 RID: 115 RVA: 0x000023DD File Offset: 0x000005DD
		public unsafe static List<SubsystemDescriptor> s_DeprecatedDescriptors
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubsystemDescriptorStore.NativeFieldInfoPtr_s_DeprecatedDescriptors, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SubsystemDescriptor>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubsystemDescriptorStore.NativeFieldInfoPtr_s_DeprecatedDescriptors, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000023EF File Offset: 0x000005EF
		public static void RegisterDescriptor(SubsystemDescriptorWithProvider descriptor)
		{
			descriptor.ThrowIfInvalid();
			SubsystemDescriptorStore.RegisterDescriptor<SubsystemDescriptorWithProvider, SubsystemDescriptorWithProvider>(descriptor, SubsystemDescriptorStore.s_StandaloneDescriptors);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00003614 File Offset: 0x00001814
		public static void GetAllSubsystemDescriptors(List<ISubsystemDescriptor> descriptors)
		{
			descriptors.Clear();
			int num = SubsystemDescriptorStore.s_IntegratedDescriptors.Count + SubsystemDescriptorStore.s_StandaloneDescriptors.Count + SubsystemDescriptorStore.s_DeprecatedDescriptors.Count;
			bool flag = descriptors.Capacity < num;
			if (flag)
			{
				descriptors.Capacity = num;
			}
			SubsystemDescriptorStore.AddDescriptorSubset<IntegratedSubsystemDescriptor>(SubsystemDescriptorStore.s_IntegratedDescriptors, descriptors);
			SubsystemDescriptorStore.AddDescriptorSubset<SubsystemDescriptorWithProvider>(SubsystemDescriptorStore.s_StandaloneDescriptors, descriptors);
			SubsystemDescriptorStore.AddDescriptorSubset<SubsystemDescriptor>(SubsystemDescriptorStore.s_DeprecatedDescriptors, descriptors);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00003684 File Offset: 0x00001884
		public static void AddDescriptorSubset<TBaseTypeInList>(List<TBaseTypeInList> copyFrom, List<ISubsystemDescriptor> copyTo)
		{
			List<TBaseTypeInList>.Enumerator enumerator = copyFrom.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					TBaseTypeInList tbaseTypeInList = enumerator.Current;
					copyTo.Add(tbaseTypeInList);
				}
			}
			finally
			{
				enumerator.Dispose();
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002405 File Offset: 0x00000605
		public static void GetSubsystemDescriptors<T>(List<T> descriptors)
		{
			descriptors.Clear();
			SubsystemDescriptorStore.AddDescriptorSubset<IntegratedSubsystemDescriptor, T>(SubsystemDescriptorStore.s_IntegratedDescriptors, descriptors);
			SubsystemDescriptorStore.AddDescriptorSubset<SubsystemDescriptorWithProvider, T>(SubsystemDescriptorStore.s_StandaloneDescriptors, descriptors);
			SubsystemDescriptorStore.AddDescriptorSubset<SubsystemDescriptor, T>(SubsystemDescriptorStore.s_DeprecatedDescriptors, descriptors);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000036DC File Offset: 0x000018DC
		public static void AddDescriptorSubset<TBaseTypeInList, TQueryType>(List<TBaseTypeInList> copyFrom, List<TQueryType> copyTo)
		{
			List<TBaseTypeInList>.Enumerator enumerator = copyFrom.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					TBaseTypeInList tbaseTypeInList = enumerator.Current;
					TQueryType tqueryType;
					bool flag;
					if (tbaseTypeInList.TryCast<TQueryType>() != null)
					{
						tqueryType = tbaseTypeInList.TryCast<TQueryType>().Cast<TQueryType>();
						flag = true;
					}
					else
					{
						flag = false;
					}
					bool flag2 = flag;
					if (flag2)
					{
						copyTo.Add(tqueryType);
					}
				}
			}
			finally
			{
				enumerator.Dispose();
			}
		}

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeFieldInfoPtr_s_IntegratedDescriptors;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeFieldInfoPtr_s_StandaloneDescriptors;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeFieldInfoPtr_s_DeprecatedDescriptors;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_InitializeManagedDescriptor_Internal_Static_Void_IntPtr_IntegratedSubsystemDescriptor_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_ClearManagedDescriptors_Internal_Static_Void_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_ReportSingleSubsystemAnalytics_Private_Static_Void_String_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDescriptor_Internal_Static_Void_TDescriptor_List_1_TBaseTypeInList_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDeprecatedDescriptor_Internal_Static_Void_SubsystemDescriptor_0;

		// Token: 0x0200001E RID: 30
		private sealed class MethodInfoStoreGeneric_RegisterDescriptor_Internal_Static_Void_TDescriptor_List_1_TBaseTypeInList_0<TDescriptor, TBaseTypeInList>
		{
			// Token: 0x0400003E RID: 62
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SubsystemDescriptorStore.NativeMethodInfoPtr_RegisterDescriptor_Internal_Static_Void_TDescriptor_List_1_TBaseTypeInList_0, Il2CppClassPointerStore<SubsystemDescriptorStore>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDescriptor>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TBaseTypeInList>.NativeClassPtr))
			}))));
		}
	}
}

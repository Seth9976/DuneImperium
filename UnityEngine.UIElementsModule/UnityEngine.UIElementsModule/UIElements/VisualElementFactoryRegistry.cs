using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements
{
	// Token: 0x02000215 RID: 533
	public class VisualElementFactoryRegistry : Object
	{
		// Token: 0x06002885 RID: 10373 RVA: 0x000B1C3C File Offset: 0x000AFE3C
		// Note: this type is marked as 'beforefieldinit'.
		static VisualElementFactoryRegistry()
		{
			Il2CppClassPointerStore<VisualElementFactoryRegistry>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "VisualElementFactoryRegistry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualElementFactoryRegistry>.NativeClassPtr);
			VisualElementFactoryRegistry.NativeFieldInfoPtr_s_Factories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementFactoryRegistry>.NativeClassPtr, "s_Factories");
			VisualElementFactoryRegistry.NativeFieldInfoPtr_s_MovedTypesFactories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementFactoryRegistry>.NativeClassPtr, "s_MovedTypesFactories");
			VisualElementFactoryRegistry.NativeMethodInfoPtr_GetMovedUIControlTypeName_Private_Static_String_Type_MovedFromAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFactoryRegistry>.NativeClassPtr, 100669368);
			VisualElementFactoryRegistry.NativeMethodInfoPtr_get_factories_Internal_Static_get_Dictionary_2_String_List_1_IUxmlFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFactoryRegistry>.NativeClassPtr, 100669369);
			VisualElementFactoryRegistry.NativeMethodInfoPtr_RegisterFactory_Protected_Static_Void_IUxmlFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFactoryRegistry>.NativeClassPtr, 100669370);
			VisualElementFactoryRegistry.NativeMethodInfoPtr_TryGetValue_Internal_Static_Boolean_String_byref_List_1_IUxmlFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFactoryRegistry>.NativeClassPtr, 100669371);
			VisualElementFactoryRegistry.NativeMethodInfoPtr_RegisterEngineFactories_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFactoryRegistry>.NativeClassPtr, 100669372);
			VisualElementFactoryRegistry.NativeMethodInfoPtr_RegisterUserFactories_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFactoryRegistry>.NativeClassPtr, 100669373);
		}

		// Token: 0x06002886 RID: 10374 RVA: 0x000B1D0C File Offset: 0x000AFF0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 344443, XrefRangeEnd = 344463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetMovedUIControlTypeName(Type type, MovedFromAttribute attr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementFactoryRegistry.NativeMethodInfoPtr_GetMovedUIControlTypeName_Private_Static_String_Type_MovedFromAttribute_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x06002887 RID: 10375 RVA: 0x000B1D5C File Offset: 0x000AFF5C
		public unsafe static Dictionary<string, List<IUxmlFactory>> factories
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 344485, RefRangeEnd = 344490, XrefRangeStart = 344463, XrefRangeEnd = 344485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementFactoryRegistry.NativeMethodInfoPtr_get_factories_Internal_Static_get_Dictionary_2_String_List_1_IUxmlFactory_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, List<IUxmlFactory>>>(intPtr3) : null;
			}
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x000B1D90 File Offset: 0x000AFF90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 344554, RefRangeEnd = 344557, XrefRangeStart = 344490, XrefRangeEnd = 344554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterFactory(IUxmlFactory factory)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(factory);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementFactoryRegistry.NativeMethodInfoPtr_RegisterFactory_Protected_Static_Void_IUxmlFactory_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x000B1DC8 File Offset: 0x000AFFC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 344565, RefRangeEnd = 344566, XrefRangeStart = 344557, XrefRangeEnd = 344565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetValue(string fullTypeName, out List<IUxmlFactory> factoryList)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullTypeName);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(VisualElementFactoryRegistry.NativeMethodInfoPtr_TryGetValue_Internal_Static_Boolean_String_byref_List_1_IUxmlFactory_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			factoryList = ((intPtr4 == 0) ? null : new List<IUxmlFactory>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x000B1E2C File Offset: 0x000B002C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 344893, RefRangeEnd = 344894, XrefRangeStart = 344566, XrefRangeEnd = 344893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterEngineFactories()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementFactoryRegistry.NativeMethodInfoPtr_RegisterEngineFactories_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x000B1E54 File Offset: 0x000B0054
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 344929, RefRangeEnd = 344930, XrefRangeStart = 344894, XrefRangeEnd = 344929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterUserFactories()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementFactoryRegistry.NativeMethodInfoPtr_RegisterUserFactories_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600288C RID: 10380 RVA: 0x000105E2 File Offset: 0x0000E7E2
		public VisualElementFactoryRegistry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x0600288D RID: 10381 RVA: 0x000B1E7C File Offset: 0x000B007C
		// (set) Token: 0x0600288E RID: 10382 RVA: 0x000105EB File Offset: 0x0000E7EB
		public unsafe static Dictionary<string, List<IUxmlFactory>> s_Factories
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VisualElementFactoryRegistry.NativeFieldInfoPtr_s_Factories, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, List<IUxmlFactory>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualElementFactoryRegistry.NativeFieldInfoPtr_s_Factories, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x0600288F RID: 10383 RVA: 0x000B1EA4 File Offset: 0x000B00A4
		// (set) Token: 0x06002890 RID: 10384 RVA: 0x000105FD File Offset: 0x0000E7FD
		public unsafe static Dictionary<string, List<IUxmlFactory>> s_MovedTypesFactories
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VisualElementFactoryRegistry.NativeFieldInfoPtr_s_MovedTypesFactories, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, List<IUxmlFactory>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualElementFactoryRegistry.NativeFieldInfoPtr_s_MovedTypesFactories, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06002891 RID: 10385 RVA: 0x000B1ECC File Offset: 0x000B00CC
		public static bool TryGetValue(Type type, out List<IUxmlFactory> factoryList)
		{
			Dictionary<string, List<IUxmlFactory>>.ValueCollection.Enumerator enumerator = VisualElementFactoryRegistry.factories.Values.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					List<IUxmlFactory> list = enumerator.Current;
					bool flag = list[0].uxmlType == type;
					if (flag)
					{
						factoryList = list;
						return true;
					}
				}
			}
			finally
			{
				enumerator.Dispose();
			}
			factoryList = null;
			return false;
		}

		// Token: 0x04001C9C RID: 7324
		private static readonly IntPtr NativeFieldInfoPtr_s_Factories;

		// Token: 0x04001C9D RID: 7325
		private static readonly IntPtr NativeFieldInfoPtr_s_MovedTypesFactories;

		// Token: 0x04001C9E RID: 7326
		private static readonly IntPtr NativeMethodInfoPtr_GetMovedUIControlTypeName_Private_Static_String_Type_MovedFromAttribute_0;

		// Token: 0x04001C9F RID: 7327
		private static readonly IntPtr NativeMethodInfoPtr_get_factories_Internal_Static_get_Dictionary_2_String_List_1_IUxmlFactory_0;

		// Token: 0x04001CA0 RID: 7328
		private static readonly IntPtr NativeMethodInfoPtr_RegisterFactory_Protected_Static_Void_IUxmlFactory_0;

		// Token: 0x04001CA1 RID: 7329
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Internal_Static_Boolean_String_byref_List_1_IUxmlFactory_0;

		// Token: 0x04001CA2 RID: 7330
		private static readonly IntPtr NativeMethodInfoPtr_RegisterEngineFactories_Private_Static_Void_0;

		// Token: 0x04001CA3 RID: 7331
		private static readonly IntPtr NativeMethodInfoPtr_RegisterUserFactories_Internal_Static_Void_0;
	}
}

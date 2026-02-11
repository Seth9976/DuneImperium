using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000211 RID: 529
	public class UxmlObjectFactoryRegistry : Object
	{
		// Token: 0x06002850 RID: 10320 RVA: 0x000B1290 File Offset: 0x000AF490
		// Note: this type is marked as 'beforefieldinit'.
		static UxmlObjectFactoryRegistry()
		{
			Il2CppClassPointerStore<UxmlObjectFactoryRegistry>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UxmlObjectFactoryRegistry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlObjectFactoryRegistry>.NativeClassPtr);
			UxmlObjectFactoryRegistry.NativeFieldInfoPtr_s_Factories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlObjectFactoryRegistry>.NativeClassPtr, "s_Factories");
			UxmlObjectFactoryRegistry.NativeMethodInfoPtr_get_factories_Internal_Static_get_Dictionary_2_String_List_1_IBaseUxmlObjectFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlObjectFactoryRegistry>.NativeClassPtr, 100669348);
			UxmlObjectFactoryRegistry.NativeMethodInfoPtr_RegisterFactory_Protected_Static_Void_IBaseUxmlObjectFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlObjectFactoryRegistry>.NativeClassPtr, 100669349);
			UxmlObjectFactoryRegistry.NativeMethodInfoPtr_TryGetFactories_Internal_Static_Boolean_String_byref_List_1_IBaseUxmlObjectFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlObjectFactoryRegistry>.NativeClassPtr, 100669350);
			UxmlObjectFactoryRegistry.NativeMethodInfoPtr_RegisterEngineFactories_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlObjectFactoryRegistry>.NativeClassPtr, 100669351);
			UxmlObjectFactoryRegistry.NativeMethodInfoPtr_RegisterUserFactories_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlObjectFactoryRegistry>.NativeClassPtr, 100669352);
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x06002851 RID: 10321 RVA: 0x000B1338 File Offset: 0x000AF538
		public unsafe static Dictionary<string, List<IBaseUxmlObjectFactory>> factories
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 344241, RefRangeEnd = 344245, XrefRangeStart = 344227, XrefRangeEnd = 344241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlObjectFactoryRegistry.NativeMethodInfoPtr_get_factories_Internal_Static_get_Dictionary_2_String_List_1_IBaseUxmlObjectFactory_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, List<IBaseUxmlObjectFactory>>>(intPtr3) : null;
			}
		}

		// Token: 0x06002852 RID: 10322 RVA: 0x000B136C File Offset: 0x000AF56C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 344272, RefRangeEnd = 344275, XrefRangeStart = 344245, XrefRangeEnd = 344272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterFactory(IBaseUxmlObjectFactory factory)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(factory);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlObjectFactoryRegistry.NativeMethodInfoPtr_RegisterFactory_Protected_Static_Void_IBaseUxmlObjectFactory_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002853 RID: 10323 RVA: 0x000B13A4 File Offset: 0x000AF5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 344275, XrefRangeEnd = 344280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetFactories(string fullTypeName, out List<IBaseUxmlObjectFactory> factoryList)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UxmlObjectFactoryRegistry.NativeMethodInfoPtr_TryGetFactories_Internal_Static_Boolean_String_byref_List_1_IBaseUxmlObjectFactory_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			factoryList = ((intPtr4 == 0) ? null : new List<IBaseUxmlObjectFactory>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002854 RID: 10324 RVA: 0x000B1408 File Offset: 0x000AF608
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 344317, RefRangeEnd = 344318, XrefRangeStart = 344280, XrefRangeEnd = 344317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterEngineFactories()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlObjectFactoryRegistry.NativeMethodInfoPtr_RegisterEngineFactories_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002855 RID: 10325 RVA: 0x000B1430 File Offset: 0x000AF630
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 344353, RefRangeEnd = 344354, XrefRangeStart = 344318, XrefRangeEnd = 344353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterUserFactories()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlObjectFactoryRegistry.NativeMethodInfoPtr_RegisterUserFactories_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002856 RID: 10326 RVA: 0x00010470 File Offset: 0x0000E670
		public UxmlObjectFactoryRegistry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x06002857 RID: 10327 RVA: 0x000B1458 File Offset: 0x000AF658
		// (set) Token: 0x06002858 RID: 10328 RVA: 0x00010479 File Offset: 0x0000E679
		public unsafe static Dictionary<string, List<IBaseUxmlObjectFactory>> s_Factories
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UxmlObjectFactoryRegistry.NativeFieldInfoPtr_s_Factories, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, List<IBaseUxmlObjectFactory>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UxmlObjectFactoryRegistry.NativeFieldInfoPtr_s_Factories, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C7E RID: 7294
		private static readonly IntPtr NativeFieldInfoPtr_s_Factories;

		// Token: 0x04001C7F RID: 7295
		private static readonly IntPtr NativeMethodInfoPtr_get_factories_Internal_Static_get_Dictionary_2_String_List_1_IBaseUxmlObjectFactory_0;

		// Token: 0x04001C80 RID: 7296
		private static readonly IntPtr NativeMethodInfoPtr_RegisterFactory_Protected_Static_Void_IBaseUxmlObjectFactory_0;

		// Token: 0x04001C81 RID: 7297
		private static readonly IntPtr NativeMethodInfoPtr_TryGetFactories_Internal_Static_Boolean_String_byref_List_1_IBaseUxmlObjectFactory_0;

		// Token: 0x04001C82 RID: 7298
		private static readonly IntPtr NativeMethodInfoPtr_RegisterEngineFactories_Private_Static_Void_0;

		// Token: 0x04001C83 RID: 7299
		private static readonly IntPtr NativeMethodInfoPtr_RegisterUserFactories_Private_Static_Void_0;
	}
}

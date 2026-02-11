using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace InControl
{
	// Token: 0x0200006D RID: 109
	public static class Reflector : Object
	{
		// Token: 0x06000A1B RID: 2587 RVA: 0x0002BF8C File Offset: 0x0002A18C
		// Note: this type is marked as 'beforefieldinit'.
		static Reflector()
		{
			Il2CppClassPointerStore<Reflector>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "Reflector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Reflector>.NativeClassPtr);
			Reflector.NativeFieldInfoPtr_ignoreAssemblies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Reflector>.NativeClassPtr, "ignoreAssemblies");
			Reflector.NativeFieldInfoPtr_assemblyTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Reflector>.NativeClassPtr, "assemblyTypes");
			Reflector.NativeMethodInfoPtr_get_AllAssemblyTypes_Public_Static_get_IEnumerable_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Reflector>.NativeClassPtr, 100664661);
			Reflector.NativeMethodInfoPtr_IgnoreAssemblyWithName_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Reflector>.NativeClassPtr, 100664662);
			Reflector.NativeMethodInfoPtr_GetAllAssemblyTypes_Private_Static_IEnumerable_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Reflector>.NativeClassPtr, 100664663);
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x0002C020 File Offset: 0x0002A220
		public unsafe static IEnumerable<Type> AllAssemblyTypes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790414, XrefRangeEnd = 790423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Reflector.NativeMethodInfoPtr_get_AllAssemblyTypes_Public_Static_get_IEnumerable_1_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x0002C054 File Offset: 0x0002A254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790423, XrefRangeEnd = 790429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IgnoreAssemblyWithName(string assemblyName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Reflector.NativeMethodInfoPtr_IgnoreAssemblyWithName_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x0002C098 File Offset: 0x0002A298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 790451, RefRangeEnd = 790452, XrefRangeStart = 790429, XrefRangeEnd = 790451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Type> GetAllAssemblyTypes()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Reflector.NativeMethodInfoPtr_GetAllAssemblyTypes_Private_Static_IEnumerable_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Type>>(intPtr3) : null;
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x00005DC3 File Offset: 0x00003FC3
		public Reflector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x0002C0CC File Offset: 0x0002A2CC
		// (set) Token: 0x06000A21 RID: 2593 RVA: 0x00005DCC File Offset: 0x00003FCC
		public unsafe static Il2CppStringArray ignoreAssemblies
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Reflector.NativeFieldInfoPtr_ignoreAssemblies, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Reflector.NativeFieldInfoPtr_ignoreAssemblies, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x0002C0F4 File Offset: 0x0002A2F4
		// (set) Token: 0x06000A23 RID: 2595 RVA: 0x00005DDE File Offset: 0x00003FDE
		public unsafe static IEnumerable<Type> assemblyTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Reflector.NativeFieldInfoPtr_assemblyTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Reflector.NativeFieldInfoPtr_assemblyTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000974 RID: 2420
		private static readonly IntPtr NativeFieldInfoPtr_ignoreAssemblies;

		// Token: 0x04000975 RID: 2421
		private static readonly IntPtr NativeFieldInfoPtr_assemblyTypes;

		// Token: 0x04000976 RID: 2422
		private static readonly IntPtr NativeMethodInfoPtr_get_AllAssemblyTypes_Public_Static_get_IEnumerable_1_Type_0;

		// Token: 0x04000977 RID: 2423
		private static readonly IntPtr NativeMethodInfoPtr_IgnoreAssemblyWithName_Private_Static_Boolean_String_0;

		// Token: 0x04000978 RID: 2424
		private static readonly IntPtr NativeMethodInfoPtr_GetAllAssemblyTypes_Private_Static_IEnumerable_1_Type_0;
	}
}

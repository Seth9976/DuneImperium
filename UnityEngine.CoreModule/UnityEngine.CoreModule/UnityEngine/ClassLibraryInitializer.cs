using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x02000132 RID: 306
	public static class ClassLibraryInitializer : Object
	{
		// Token: 0x060017C8 RID: 6088 RVA: 0x0007063C File Offset: 0x0006E83C
		// Note: this type is marked as 'beforefieldinit'.
		static ClassLibraryInitializer()
		{
			Il2CppClassPointerStore<ClassLibraryInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ClassLibraryInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClassLibraryInitializer>.NativeClassPtr);
			ClassLibraryInitializer.NativeMethodInfoPtr_Init_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassLibraryInitializer>.NativeClassPtr, 100666537);
			ClassLibraryInitializer.NativeMethodInfoPtr_InitStdErrWithHandle_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassLibraryInitializer>.NativeClassPtr, 100666538);
			ClassLibraryInitializer.NativeMethodInfoPtr_InitAssemblyRedirections_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassLibraryInitializer>.NativeClassPtr, 100666539);
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x000706A8 File Offset: 0x0006E8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 661802, XrefRangeEnd = 661803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassLibraryInitializer.NativeMethodInfoPtr_Init_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017CA RID: 6090 RVA: 0x000706D0 File Offset: 0x0006E8D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 661803, XrefRangeEnd = 661819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitStdErrWithHandle(IntPtr fileHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fileHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassLibraryInitializer.NativeMethodInfoPtr_InitStdErrWithHandle_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017CB RID: 6091 RVA: 0x00070704 File Offset: 0x0006E904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 661819, XrefRangeEnd = 661837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitAssemblyRedirections()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassLibraryInitializer.NativeMethodInfoPtr_InitAssemblyRedirections_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017CC RID: 6092 RVA: 0x00009729 File Offset: 0x00007929
		public ClassLibraryInitializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001560 RID: 5472
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Static_Void_0;

		// Token: 0x04001561 RID: 5473
		private static readonly IntPtr NativeMethodInfoPtr_InitStdErrWithHandle_Private_Static_Void_IntPtr_0;

		// Token: 0x04001562 RID: 5474
		private static readonly IntPtr NativeMethodInfoPtr_InitAssemblyRedirections_Private_Static_Void_0;

		// Token: 0x02000726 RID: 1830
		[ObfuscatedName("UnityEngine.ClassLibraryInitializer+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003717 RID: 14103 RVA: 0x000BAA90 File Offset: 0x000B8C90
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ClassLibraryInitializer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClassLibraryInitializer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClassLibraryInitializer.__c>.NativeClassPtr);
				ClassLibraryInitializer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassLibraryInitializer.__c>.NativeClassPtr, "<>9");
				ClassLibraryInitializer.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassLibraryInitializer.__c>.NativeClassPtr, "<>9__2_0");
				ClassLibraryInitializer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassLibraryInitializer.__c>.NativeClassPtr, 100666541);
				ClassLibraryInitializer.__c.NativeMethodInfoPtr__InitAssemblyRedirections_b__2_0_Internal_Assembly_Object_ResolveEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassLibraryInitializer.__c>.NativeClassPtr, 100666542);
			}

			// Token: 0x06003718 RID: 14104 RVA: 0x000BAB0C File Offset: 0x000B8D0C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClassLibraryInitializer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassLibraryInitializer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003719 RID: 14105 RVA: 0x000BAB48 File Offset: 0x000B8D48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 661795, XrefRangeEnd = 661802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Assembly _InitAssemblyRedirections_b__2_0(Object _, ResolveEventArgs args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassLibraryInitializer.__c.NativeMethodInfoPtr__InitAssemblyRedirections_b__2_0_Internal_Assembly_Object_ResolveEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}

			// Token: 0x0600371A RID: 14106 RVA: 0x00013E14 File Offset: 0x00012014
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A1A RID: 2586
			// (get) Token: 0x0600371B RID: 14107 RVA: 0x000BABAC File Offset: 0x000B8DAC
			// (set) Token: 0x0600371C RID: 14108 RVA: 0x00013E1D File Offset: 0x0001201D
			public unsafe static ClassLibraryInitializer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ClassLibraryInitializer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClassLibraryInitializer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ClassLibraryInitializer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A1B RID: 2587
			// (get) Token: 0x0600371D RID: 14109 RVA: 0x000BABD4 File Offset: 0x000B8DD4
			// (set) Token: 0x0600371E RID: 14110 RVA: 0x00013E2F File Offset: 0x0001202F
			public unsafe static ResolveEventHandler __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ClassLibraryInitializer.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResolveEventHandler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ClassLibraryInitializer.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C32 RID: 11314
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002C33 RID: 11315
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04002C34 RID: 11316
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002C35 RID: 11317
			private static readonly IntPtr NativeMethodInfoPtr__InitAssemblyRedirections_b__2_0_Internal_Assembly_Object_ResolveEventArgs_0;
		}

		// Token: 0x02000727 RID: 1831
		[Serializable]
		public sealed class <>c
		{
		}
	}
}

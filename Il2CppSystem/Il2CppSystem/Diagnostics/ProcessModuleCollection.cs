using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x0200009F RID: 159
	public class ProcessModuleCollection : ReadOnlyCollectionBase
	{
		// Token: 0x06000BD7 RID: 3031 RVA: 0x00048938 File Offset: 0x00046B38
		// Note: this type is marked as 'beforefieldinit'.
		static ProcessModuleCollection()
		{
			Il2CppClassPointerStore<ProcessModuleCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Diagnostics", "ProcessModuleCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProcessModuleCollection>.NativeClassPtr);
			ProcessModuleCollection.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_ProcessModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessModuleCollection>.NativeClassPtr, 100665018);
			ProcessModuleCollection.NativeMethodInfoPtr_get_Item_Public_get_ProcessModule_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessModuleCollection>.NativeClassPtr, 100665019);
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x00048990 File Offset: 0x00046B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451685, XrefRangeEnd = 451688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProcessModuleCollection(Il2CppReferenceArray<ProcessModule> processModules)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProcessModuleCollection>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(processModules);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProcessModuleCollection.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_ProcessModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000380 RID: 896
		public unsafe ProcessModule this[int index]
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 451691, RefRangeEnd = 451693, XrefRangeStart = 451688, XrefRangeEnd = 451691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProcessModuleCollection.NativeMethodInfoPtr_get_Item_Public_get_ProcessModule_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProcessModule>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x000064F8 File Offset: 0x000046F8
		public ProcessModuleCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000962 RID: 2402
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_ProcessModule_0;

		// Token: 0x04000963 RID: 2403
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_ProcessModule_Int32_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.prefabs
{
	// Token: 0x02000102 RID: 258
	public class FlavorProvider : ScriptableObject
	{
		// Token: 0x06000F14 RID: 3860 RVA: 0x0004F878 File Offset: 0x0004DA78
		// Note: this type is marked as 'beforefieldinit'.
		static FlavorProvider()
		{
			Il2CppClassPointerStore<FlavorProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.prefabs", "FlavorProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlavorProvider>.NativeClassPtr);
			FlavorProvider.NativeMethodInfoPtr_GetFlavors_Public_Abstract_Virtual_New_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavorProvider>.NativeClassPtr, 100665490);
			FlavorProvider.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavorProvider>.NativeClassPtr, 100665491);
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x0004F8D0 File Offset: 0x0004DAD0
		[CallerCount(0)]
		public unsafe virtual IEnumerable<string> GetFlavors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlavorProvider.NativeMethodInfoPtr_GetFlavors_Public_Abstract_Virtual_New_IEnumerable_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x0004F91C File Offset: 0x0004DB1C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 338035, RefRangeEnd = 338045, XrefRangeStart = 338035, XrefRangeEnd = 338045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlavorProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlavorProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavorProvider.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x000071CD File Offset: 0x000053CD
		public FlavorProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AD5 RID: 2773
		private static readonly IntPtr NativeMethodInfoPtr_GetFlavors_Public_Abstract_Virtual_New_IEnumerable_1_String_0;

		// Token: 0x04000AD6 RID: 2774
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

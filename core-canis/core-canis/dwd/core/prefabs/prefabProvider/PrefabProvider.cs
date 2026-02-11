using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.prefabs.prefabProvider
{
	// Token: 0x02000110 RID: 272
	public class PrefabProvider : MonoBehaviour
	{
		// Token: 0x06000F79 RID: 3961 RVA: 0x00051224 File Offset: 0x0004F424
		// Note: this type is marked as 'beforefieldinit'.
		static PrefabProvider()
		{
			Il2CppClassPointerStore<PrefabProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.prefabs.prefabProvider", "PrefabProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabProvider>.NativeClassPtr);
			PrefabProvider.NativeMethodInfoPtr_GetPrefabForData_Public_Abstract_Virtual_New_SubscriptionProvider_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabProvider>.NativeClassPtr, 100665545);
			PrefabProvider.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabProvider>.NativeClassPtr, 100665546);
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x0005127C File Offset: 0x0004F47C
		[CallerCount(0)]
		public unsafe virtual SubscriptionProvider GetPrefabForData(DataComposition data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrefabProvider.NativeMethodInfoPtr_GetPrefabForData_Public_Abstract_Virtual_New_SubscriptionProvider_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr3) : null;
			}
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x000512D8 File Offset: 0x0004F4D8
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrefabProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabProvider.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x000073E9 File Offset: 0x000055E9
		public PrefabProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B0F RID: 2831
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefabForData_Public_Abstract_Virtual_New_SubscriptionProvider_DataComposition_0;

		// Token: 0x04000B10 RID: 2832
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

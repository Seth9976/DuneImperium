using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace dwd.core.platformdependent
{
	// Token: 0x0200000D RID: 13
	[Serializable]
	public class PlatformDependentAdjustment : global::Il2CppSystem.Object
	{
		// Token: 0x0600004E RID: 78 RVA: 0x00003F78 File Offset: 0x00002178
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformDependentAdjustment()
		{
			Il2CppClassPointerStore<PlatformDependentAdjustment>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-platformdependent.dll", "dwd.core.platformdependent", "PlatformDependentAdjustment");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformDependentAdjustment>.NativeClassPtr);
			PlatformDependentAdjustment.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentAdjustment>.NativeClassPtr, 100663335);
			PlatformDependentAdjustment.NativeMethodInfoPtr_ApplyAdjustment_Public_Abstract_Virtual_New_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentAdjustment>.NativeClassPtr, 100663336);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003FD0 File Offset: 0x000021D0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformDependentAdjustment()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDependentAdjustment>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentAdjustment.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000400C File Offset: 0x0000220C
		[CallerCount(0)]
		public unsafe virtual void ApplyAdjustment(GameObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformDependentAdjustment.NativeMethodInfoPtr_ApplyAdjustment_Public_Abstract_Virtual_New_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000225E File Offset: 0x0000045E
		public PlatformDependentAdjustment(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_ApplyAdjustment_Public_Abstract_Virtual_New_Void_GameObject_0;
	}
}

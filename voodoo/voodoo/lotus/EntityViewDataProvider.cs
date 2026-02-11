using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace lotus
{
	// Token: 0x02000053 RID: 83
	public class EntityViewDataProvider : MonoBehaviour
	{
		// Token: 0x0600050D RID: 1293 RVA: 0x00019DE0 File Offset: 0x00017FE0
		// Note: this type is marked as 'beforefieldinit'.
		static EntityViewDataProvider()
		{
			Il2CppClassPointerStore<EntityViewDataProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "EntityViewDataProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityViewDataProvider>.NativeClassPtr);
			EntityViewDataProvider.NativeMethodInfoPtr_ProvideData_Public_Virtual_New_EntityComponent_EntityInitializationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityViewDataProvider>.NativeClassPtr, 100663913);
			EntityViewDataProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityViewDataProvider>.NativeClassPtr, 100663914);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00019E38 File Offset: 0x00018038
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual EntityComponent ProvideData(EntityInitializationContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityViewDataProvider.NativeMethodInfoPtr_ProvideData_Public_Virtual_New_EntityComponent_EntityInitializationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
			}
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00019E94 File Offset: 0x00018094
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityViewDataProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityViewDataProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityViewDataProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00004863 File Offset: 0x00002A63
		public EntityViewDataProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeMethodInfoPtr_ProvideData_Public_Virtual_New_EntityComponent_EntityInitializationContext_0;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

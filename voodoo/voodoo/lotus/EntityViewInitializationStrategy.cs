using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace lotus
{
	// Token: 0x02000054 RID: 84
	public class EntityViewInitializationStrategy : MonoBehaviour
	{
		// Token: 0x06000511 RID: 1297 RVA: 0x00019ED0 File Offset: 0x000180D0
		// Note: this type is marked as 'beforefieldinit'.
		static EntityViewInitializationStrategy()
		{
			Il2CppClassPointerStore<EntityViewInitializationStrategy>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "EntityViewInitializationStrategy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityViewInitializationStrategy>.NativeClassPtr);
			EntityViewInitializationStrategy.NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_EntityView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityViewInitializationStrategy>.NativeClassPtr, 100663915);
			EntityViewInitializationStrategy.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityViewInitializationStrategy>.NativeClassPtr, 100663916);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00019F28 File Offset: 0x00018128
		[CallerCount(0)]
		public unsafe virtual void Init(EntityView ec)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ec);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityViewInitializationStrategy.NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_EntityView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00019F78 File Offset: 0x00018178
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityViewInitializationStrategy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityViewInitializationStrategy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityViewInitializationStrategy.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0000486C File Offset: 0x00002A6C
		public EntityViewInitializationStrategy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_EntityView_0;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

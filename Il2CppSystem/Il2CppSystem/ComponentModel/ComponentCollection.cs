using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x020000E5 RID: 229
	public class ComponentCollection : ReadOnlyCollectionBase
	{
		// Token: 0x06000F2A RID: 3882 RVA: 0x0000779B File Offset: 0x0000599B
		// Note: this type is marked as 'beforefieldinit'.
		static ComponentCollection()
		{
			Il2CppClassPointerStore<ComponentCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "ComponentCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComponentCollection>.NativeClassPtr);
			ComponentCollection.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_IComponent_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentCollection>.NativeClassPtr, 100665494);
		}

		// Token: 0x170004A0 RID: 1184
		public unsafe virtual IComponent this[string name]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456187, XrefRangeEnd = 456213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComponentCollection.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_IComponent_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IComponent>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x000077D4 File Offset: 0x000059D4
		public ComponentCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C5F RID: 3167
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_IComponent_String_0;
	}
}

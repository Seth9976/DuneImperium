using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace dwd.core.prefabs
{
	// Token: 0x02000104 RID: 260
	public class IPrefabMetadata<MetaType> : Il2CppObjectBase where MetaType : new()
	{
		// Token: 0x06000F1B RID: 3867 RVA: 0x0004FA60 File Offset: 0x0004DC60
		// Note: this type is marked as 'beforefieldinit'.
		static IPrefabMetadata()
		{
			Il2CppClassPointerStore<IPrefabMetadata<MetaType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.prefabs", "IPrefabMetadata`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MetaType>.NativeClassPtr)) })).TypeHandle.value);
			IPrefabMetadata<MetaType>.NativeMethodInfoPtr_GetMetadata_Public_Abstract_Virtual_New_MetaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPrefabMetadata<MetaType>>.NativeClassPtr, 100665493);
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x0004FAD8 File Offset: 0x0004DCD8
		[CallerCount(0)]
		public unsafe virtual MetaType GetMetadata()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPrefabMetadata<MetaType>.NativeMethodInfoPtr_GetMetadata_Public_Abstract_Virtual_New_MetaType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<MetaType>(intPtr, false, true);
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x000071DF File Offset: 0x000053DF
		public IPrefabMetadata(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AD8 RID: 2776
		private static readonly IntPtr NativeMethodInfoPtr_GetMetadata_Public_Abstract_Virtual_New_MetaType_0;
	}
}

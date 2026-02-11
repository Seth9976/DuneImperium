using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.AddressableAssets
{
	// Token: 0x02000014 RID: 20
	public class IKeyEvaluator : Il2CppObjectBase
	{
		// Token: 0x060001D9 RID: 473 RVA: 0x0000DB24 File Offset: 0x0000BD24
		// Note: this type is marked as 'beforefieldinit'.
		static IKeyEvaluator()
		{
			Il2CppClassPointerStore<IKeyEvaluator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine.AddressableAssets", "IKeyEvaluator");
			IKeyEvaluator.NativeMethodInfoPtr_get_RuntimeKey_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IKeyEvaluator>.NativeClassPtr, 100663716);
			IKeyEvaluator.NativeMethodInfoPtr_RuntimeKeyIsValid_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IKeyEvaluator>.NativeClassPtr, 100663717);
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001DA RID: 474 RVA: 0x0000DB74 File Offset: 0x0000BD74
		public unsafe virtual Object RuntimeKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IKeyEvaluator.NativeMethodInfoPtr_get_RuntimeKey_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000DBC0 File Offset: 0x0000BDC0
		[CallerCount(0)]
		public unsafe virtual bool RuntimeKeyIsValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IKeyEvaluator.NativeMethodInfoPtr_RuntimeKeyIsValid_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002772 File Offset: 0x00000972
		public IKeyEvaluator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr_get_RuntimeKey_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_RuntimeKeyIsValid_Public_Abstract_Virtual_New_Boolean_0;
	}
}

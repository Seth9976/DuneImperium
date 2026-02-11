using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Linq.Expressions;

namespace Il2CppSystem.Dynamic
{
	// Token: 0x02000120 RID: 288
	public class IDynamicMetaObjectProvider : Il2CppObjectBase
	{
		// Token: 0x0600111A RID: 4378 RVA: 0x00007400 File Offset: 0x00005600
		// Note: this type is marked as 'beforefieldinit'.
		static IDynamicMetaObjectProvider()
		{
			Il2CppClassPointerStore<IDynamicMetaObjectProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Dynamic", "IDynamicMetaObjectProvider");
			IDynamicMetaObjectProvider.NativeMethodInfoPtr_GetMetaObject_Public_Abstract_Virtual_New_DynamicMetaObject_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDynamicMetaObjectProvider>.NativeClassPtr, 100666550);
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x00059854 File Offset: 0x00057A54
		[CallerCount(0)]
		public unsafe virtual DynamicMetaObject GetMetaObject(Expression parameter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDynamicMetaObjectProvider.NativeMethodInfoPtr_GetMetaObject_Public_Abstract_Virtual_New_DynamicMetaObject_Expression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
			}
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x0000742F File Offset: 0x0000562F
		public IDynamicMetaObjectProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C4A RID: 3146
		private static readonly IntPtr NativeMethodInfoPtr_GetMetaObject_Public_Abstract_Virtual_New_DynamicMetaObject_Expression_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Linq
{
	// Token: 0x0200001C RID: 28
	public class IGrouping<TKey, TElement> : Il2CppObjectBase
	{
		// Token: 0x06000119 RID: 281 RVA: 0x00015014 File Offset: 0x00013214
		// Note: this type is marked as 'beforefieldinit'.
		static IGrouping()
		{
			Il2CppClassPointerStore<IGrouping<TKey, TElement>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq", "IGrouping`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr))
			})).TypeHandle.value);
			IGrouping<TKey, TElement>.NativeMethodInfoPtr_get_Key_Public_Abstract_Virtual_New_get_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGrouping<TKey, TElement>>.NativeClassPtr, 100663726);
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600011A RID: 282 RVA: 0x0001509C File Offset: 0x0001329C
		public unsafe virtual TKey Key
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGrouping<TKey, TElement>.NativeMethodInfoPtr_get_Key_Public_Abstract_Virtual_New_get_TKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TKey>(intPtr, false, true);
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000022CD File Offset: 0x000004CD
		public IGrouping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Abstract_Virtual_New_get_TKey_0;
	}
}

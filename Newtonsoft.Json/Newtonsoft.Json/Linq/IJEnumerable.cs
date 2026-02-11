using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000B5 RID: 181
	public class IJEnumerable<T> : Il2CppObjectBase where T : JToken
	{
		// Token: 0x06000FEB RID: 4075 RVA: 0x00059908 File Offset: 0x00057B08
		// Note: this type is marked as 'beforefieldinit'.
		static IJEnumerable()
		{
			Il2CppClassPointerStore<IJEnumerable<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Linq", "IJEnumerable`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IJEnumerable<T>.NativeMethodInfoPtr_get_Item_Public_Abstract_Virtual_New_get_IJEnumerable_1_JToken_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJEnumerable<T>>.NativeClassPtr, 100666137);
		}

		// Token: 0x1700045F RID: 1119
		public unsafe virtual IJEnumerable<JToken> this[Object key]
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IJEnumerable<T>.NativeMethodInfoPtr_get_Item_Public_Abstract_Virtual_New_get_IJEnumerable_1_JToken_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IJEnumerable<JToken>>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x000075D0 File Offset: 0x000057D0
		public IJEnumerable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CC0 RID: 3264
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Abstract_Virtual_New_get_IJEnumerable_1_JToken_Object_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Canis.attributes
{
	// Token: 0x0200000F RID: 15
	public class IAttribute<V> : Il2CppObjectBase
	{
		// Token: 0x06000143 RID: 323 RVA: 0x00006828 File Offset: 0x00004A28
		// Note: this type is marked as 'beforefieldinit'.
		static IAttribute()
		{
			Il2CppClassPointerStore<IAttribute<V>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Attributes.dll", "Canis.attributes", "IAttribute`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr)) })).TypeHandle.value);
			IAttribute<V>.NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttribute<V>>.NativeClassPtr, 100663350);
			IAttribute<V>.NativeMethodInfoPtr_get_ModValue_Public_Abstract_Virtual_New_get_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttribute<V>>.NativeClassPtr, 100663351);
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000144 RID: 324 RVA: 0x000068B4 File Offset: 0x00004AB4
		public unsafe virtual V Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAttribute<V>.NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_V_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<V>(intPtr, false, true);
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000145 RID: 325 RVA: 0x000068F8 File Offset: 0x00004AF8
		public unsafe virtual V ModValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAttribute<V>.NativeMethodInfoPtr_get_ModValue_Public_Abstract_Virtual_New_get_V_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<V>(intPtr, false, true);
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002A2C File Offset: 0x00000C2C
		public IAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_V_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_get_ModValue_Public_Abstract_Virtual_New_get_V_0;
	}
}

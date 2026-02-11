using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Canis.attributes
{
	// Token: 0x02000015 RID: 21
	public class IHasAttributes : Il2CppObjectBase
	{
		// Token: 0x06000160 RID: 352 RVA: 0x00006FF4 File Offset: 0x000051F4
		// Note: this type is marked as 'beforefieldinit'.
		static IHasAttributes()
		{
			Il2CppClassPointerStore<IHasAttributes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Attributes.dll", "Canis.attributes", "IHasAttributes");
			IHasAttributes.NativeMethodInfoPtr_GetAttribute_Public_Abstract_Virtual_New_IAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasAttributes>.NativeClassPtr, 100663367);
			IHasAttributes.NativeMethodInfoPtr_GetAttribute_Public_Abstract_Virtual_New_IAttribute_1_V_AttributeDefinition_1_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasAttributes>.NativeClassPtr, 100663368);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00007044 File Offset: 0x00005244
		[CallerCount(0)]
		public unsafe virtual IAttribute GetAttribute(int key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasAttributes.NativeMethodInfoPtr_GetAttribute_Public_Abstract_Virtual_New_IAttribute_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000709C File Offset: 0x0000529C
		[CallerCount(0)]
		public unsafe virtual IAttribute<V> GetAttribute<V>(AttributeDefinition<V> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasAttributes.MethodInfoStoreGeneric_GetAttribute_Public_Abstract_Virtual_New_IAttribute_1_V_AttributeDefinition_1_V_0<V>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute<V>>(intPtr3) : null;
			}
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002A9B File Offset: 0x00000C9B
		public IHasAttributes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Abstract_Virtual_New_IAttribute_Int32_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Abstract_Virtual_New_IAttribute_1_V_AttributeDefinition_1_V_0;

		// Token: 0x02000034 RID: 52
		private sealed class MethodInfoStoreGeneric_GetAttribute_Public_Abstract_Virtual_New_IAttribute_1_V_AttributeDefinition_1_V_0<V>
		{
			// Token: 0x040001DC RID: 476
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IHasAttributes.NativeMethodInfoPtr_GetAttribute_Public_Abstract_Virtual_New_IAttribute_1_V_AttributeDefinition_1_V_0, Il2CppClassPointerStore<IHasAttributes>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr)) }))));
		}
	}
}

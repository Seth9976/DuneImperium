using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.attributes
{
	// Token: 0x02000012 RID: 18
	public class IAttributeDefinition : Il2CppObjectBase
	{
		// Token: 0x0600014F RID: 335 RVA: 0x00006B80 File Offset: 0x00004D80
		// Note: this type is marked as 'beforefieldinit'.
		static IAttributeDefinition()
		{
			Il2CppClassPointerStore<IAttributeDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Attributes.dll", "Canis.attributes", "IAttributeDefinition");
			IAttributeDefinition.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttributeDefinition>.NativeClassPtr, 100663356);
			IAttributeDefinition.NativeMethodInfoPtr_get_Key_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttributeDefinition>.NativeClassPtr, 100663357);
			IAttributeDefinition.NativeMethodInfoPtr_get_ValueType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttributeDefinition>.NativeClassPtr, 100663358);
			IAttributeDefinition.NativeMethodInfoPtr_Factory_Public_Abstract_Virtual_New_IMutableAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttributeDefinition>.NativeClassPtr, 100663359);
			IAttributeDefinition.NativeMethodInfoPtr_Factory_Public_Abstract_Virtual_New_IMutableAttribute_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttributeDefinition>.NativeClassPtr, 100663360);
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00006C0C File Offset: 0x00004E0C
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAttributeDefinition.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00006C50 File Offset: 0x00004E50
		public unsafe virtual int Key
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAttributeDefinition.NativeMethodInfoPtr_get_Key_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00006C98 File Offset: 0x00004E98
		public unsafe virtual Type ValueType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAttributeDefinition.NativeMethodInfoPtr_get_ValueType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00006CE4 File Offset: 0x00004EE4
		[CallerCount(0)]
		public unsafe virtual IMutableAttribute Factory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAttributeDefinition.NativeMethodInfoPtr_Factory_Public_Abstract_Virtual_New_IMutableAttribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMutableAttribute>(intPtr3) : null;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00006D30 File Offset: 0x00004F30
		[CallerCount(0)]
		public unsafe virtual IMutableAttribute Factory(Object value, Object modValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAttributeDefinition.NativeMethodInfoPtr_Factory_Public_Abstract_Virtual_New_IMutableAttribute_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMutableAttribute>(intPtr3) : null;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002A47 File Offset: 0x00000C47
		public IAttributeDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_Factory_Public_Abstract_Virtual_New_IMutableAttribute_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_Factory_Public_Abstract_Virtual_New_IMutableAttribute_Object_Object_0;
	}
}

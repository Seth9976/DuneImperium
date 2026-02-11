using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.attributes
{
	// Token: 0x0200000E RID: 14
	public class IAttribute : Il2CppObjectBase
	{
		// Token: 0x0600013C RID: 316 RVA: 0x00006624 File Offset: 0x00004824
		// Note: this type is marked as 'beforefieldinit'.
		static IAttribute()
		{
			Il2CppClassPointerStore<IAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Attributes.dll", "Canis.attributes", "IAttribute");
			IAttribute.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttribute>.NativeClassPtr, 100663345);
			IAttribute.NativeMethodInfoPtr_get_ValueType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttribute>.NativeClassPtr, 100663346);
			IAttribute.NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttribute>.NativeClassPtr, 100663347);
			IAttribute.NativeMethodInfoPtr_get_ModValue_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttribute>.NativeClassPtr, 100663348);
			IAttribute.NativeMethodInfoPtr_get_AsReadOnly_Public_Abstract_Virtual_New_get_ReadOnlyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttribute>.NativeClassPtr, 100663349);
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600013D RID: 317 RVA: 0x000066B0 File Offset: 0x000048B0
		public unsafe virtual int Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAttribute.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600013E RID: 318 RVA: 0x000066F8 File Offset: 0x000048F8
		public unsafe virtual Type ValueType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAttribute.NativeMethodInfoPtr_get_ValueType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00006744 File Offset: 0x00004944
		public unsafe virtual Object Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAttribute.NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00006790 File Offset: 0x00004990
		public unsafe virtual Object ModValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAttribute.NativeMethodInfoPtr_get_ModValue_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000141 RID: 321 RVA: 0x000067DC File Offset: 0x000049DC
		public unsafe virtual ReadOnlyAttribute AsReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAttribute.NativeMethodInfoPtr_get_AsReadOnly_Public_Abstract_Virtual_New_get_ReadOnlyAttribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002A23 File Offset: 0x00000C23
		public IAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_get_ModValue_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_get_AsReadOnly_Public_Abstract_Virtual_New_get_ReadOnlyAttribute_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel.Design
{
	// Token: 0x02000150 RID: 336
	public class IDictionaryService : Il2CppObjectBase
	{
		// Token: 0x06001478 RID: 5240 RVA: 0x0006B810 File Offset: 0x00069A10
		// Note: this type is marked as 'beforefieldinit'.
		static IDictionaryService()
		{
			Il2CppClassPointerStore<IDictionaryService>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel.Design", "IDictionaryService");
			IDictionaryService.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDictionaryService>.NativeClassPtr, 100666351);
			IDictionaryService.NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDictionaryService>.NativeClassPtr, 100666352);
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x0006B860 File Offset: 0x00069A60
		[CallerCount(0)]
		public unsafe virtual Object GetValue(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDictionaryService.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x0006B8BC File Offset: 0x00069ABC
		[CallerCount(0)]
		public unsafe virtual void SetValue(Object key, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDictionaryService.NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x0000918D File Offset: 0x0000738D
		public IDictionaryService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001017 RID: 4119
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Object_Object_0;

		// Token: 0x04001018 RID: 4120
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Object_Object_0;
	}
}

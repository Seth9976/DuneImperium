using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200007D RID: 125
	public class ISerializationBinder : Il2CppObjectBase
	{
		// Token: 0x06000A57 RID: 2647 RVA: 0x00042330 File Offset: 0x00040530
		// Note: this type is marked as 'beforefieldinit'.
		static ISerializationBinder()
		{
			Il2CppClassPointerStore<ISerializationBinder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "ISerializationBinder");
			ISerializationBinder.NativeMethodInfoPtr_BindToType_Public_Abstract_Virtual_New_Type_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISerializationBinder>.NativeClassPtr, 100665286);
			ISerializationBinder.NativeMethodInfoPtr_BindToName_Public_Abstract_Virtual_New_Void_Type_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISerializationBinder>.NativeClassPtr, 100665287);
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00042380 File Offset: 0x00040580
		[CallerCount(0)]
		public unsafe virtual Type BindToType(string assemblyName, string typeName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(typeName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISerializationBinder.NativeMethodInfoPtr_BindToType_Public_Abstract_Virtual_New_Type_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x000423F0 File Offset: 0x000405F0
		[CallerCount(0)]
		public unsafe virtual void BindToName(Type serializedType, out string assemblyName, out string typeName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializedType);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISerializationBinder.NativeMethodInfoPtr_BindToName_Public_Abstract_Virtual_New_Void_Type_byref_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			assemblyName = IL2CPP.Il2CppStringToManaged(intPtr);
			typeName = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00005270 File Offset: 0x00003470
		public ISerializationBinder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000893 RID: 2195
		private static readonly IntPtr NativeMethodInfoPtr_BindToType_Public_Abstract_Virtual_New_Type_String_String_0;

		// Token: 0x04000894 RID: 2196
		private static readonly IntPtr NativeMethodInfoPtr_BindToName_Public_Abstract_Virtual_New_Void_Type_byref_String_byref_String_0;
	}
}

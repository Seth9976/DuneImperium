using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.UIElements
{
	// Token: 0x02000144 RID: 324
	public class ISerializableJsonDictionary : Il2CppObjectBase
	{
		// Token: 0x0600182C RID: 6188 RVA: 0x000728A4 File Offset: 0x00070AA4
		// Note: this type is marked as 'beforefieldinit'.
		static ISerializableJsonDictionary()
		{
			Il2CppClassPointerStore<ISerializableJsonDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ISerializableJsonDictionary");
			ISerializableJsonDictionary.NativeMethodInfoPtr_Set_Public_Abstract_Virtual_New_Void_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISerializableJsonDictionary>.NativeClassPtr, 100666879);
			ISerializableJsonDictionary.NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISerializableJsonDictionary>.NativeClassPtr, 100666880);
			ISerializableJsonDictionary.NativeMethodInfoPtr_Overwrite_Public_Abstract_Virtual_New_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISerializableJsonDictionary>.NativeClassPtr, 100666881);
			ISerializableJsonDictionary.NativeMethodInfoPtr_ContainsKey_Public_Abstract_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISerializableJsonDictionary>.NativeClassPtr, 100666882);
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x0007291C File Offset: 0x00070B1C
		[CallerCount(0)]
		public unsafe virtual void Set<T>(string key, T value) where T : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISerializableJsonDictionary.MethodInfoStoreGeneric_Set_Public_Abstract_Virtual_New_Void_String_T_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x000729B4 File Offset: 0x00070BB4
		[CallerCount(0)]
		public unsafe virtual T Get<T>(string key) where T : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISerializableJsonDictionary.MethodInfoStoreGeneric_Get_Public_Abstract_Virtual_New_T_String_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x00072A0C File Offset: 0x00070C0C
		[CallerCount(0)]
		public unsafe virtual void Overwrite(Object obj, string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISerializableJsonDictionary.NativeMethodInfoPtr_Overwrite_Public_Abstract_Virtual_New_Void_Object_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x00072A6C File Offset: 0x00070C6C
		[CallerCount(0)]
		public unsafe virtual bool ContainsKey(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISerializableJsonDictionary.NativeMethodInfoPtr_ContainsKey_Public_Abstract_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x0000B233 File Offset: 0x00009433
		public ISerializableJsonDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001082 RID: 4226
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Abstract_Virtual_New_Void_String_T_0;

		// Token: 0x04001083 RID: 4227
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_T_String_0;

		// Token: 0x04001084 RID: 4228
		private static readonly IntPtr NativeMethodInfoPtr_Overwrite_Public_Abstract_Virtual_New_Void_Object_String_0;

		// Token: 0x04001085 RID: 4229
		private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Abstract_Virtual_New_Boolean_String_0;

		// Token: 0x02000471 RID: 1137
		private sealed class MethodInfoStoreGeneric_Set_Public_Abstract_Virtual_New_Void_String_T_0<T>
		{
			// Token: 0x04002A6C RID: 10860
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ISerializableJsonDictionary.NativeMethodInfoPtr_Set_Public_Abstract_Virtual_New_Void_String_T_0, Il2CppClassPointerStore<ISerializableJsonDictionary>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000472 RID: 1138
		private sealed class MethodInfoStoreGeneric_Get_Public_Abstract_Virtual_New_T_String_0<T>
		{
			// Token: 0x04002A6D RID: 10861
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ISerializableJsonDictionary.NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_T_String_0, Il2CppClassPointerStore<ISerializableJsonDictionary>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}

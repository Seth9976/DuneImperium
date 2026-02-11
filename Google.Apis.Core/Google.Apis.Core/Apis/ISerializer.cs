using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Reflection;

namespace Google.Apis
{
	// Token: 0x02000004 RID: 4
	public class ISerializer : Il2CppObjectBase
	{
		// Token: 0x06000018 RID: 24 RVA: 0x000046B8 File Offset: 0x000028B8
		// Note: this type is marked as 'beforefieldinit'.
		static ISerializer()
		{
			Il2CppClassPointerStore<ISerializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis", "ISerializer");
			ISerializer.NativeMethodInfoPtr_get_Format_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISerializer>.NativeClassPtr, 100663308);
			ISerializer.NativeMethodInfoPtr_Serialize_Public_Abstract_Virtual_New_Void_Object_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISerializer>.NativeClassPtr, 100663309);
			ISerializer.NativeMethodInfoPtr_Serialize_Public_Abstract_Virtual_New_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISerializer>.NativeClassPtr, 100663310);
			ISerializer.NativeMethodInfoPtr_Deserialize_Public_Abstract_Virtual_New_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISerializer>.NativeClassPtr, 100663311);
			ISerializer.NativeMethodInfoPtr_Deserialize_Public_Abstract_Virtual_New_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISerializer>.NativeClassPtr, 100663312);
			ISerializer.NativeMethodInfoPtr_Deserialize_Public_Abstract_Virtual_New_T_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISerializer>.NativeClassPtr, 100663313);
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00004758 File Offset: 0x00002958
		public unsafe virtual string Format
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISerializer.NativeMethodInfoPtr_get_Format_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000479C File Offset: 0x0000299C
		[CallerCount(0)]
		public unsafe virtual void Serialize(Object obj, Stream target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISerializer.NativeMethodInfoPtr_Serialize_Public_Abstract_Virtual_New_Void_Object_Stream_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000047FC File Offset: 0x000029FC
		[CallerCount(0)]
		public unsafe virtual string Serialize(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISerializer.NativeMethodInfoPtr_Serialize_Public_Abstract_Virtual_New_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00004850 File Offset: 0x00002A50
		[CallerCount(0)]
		public unsafe virtual T Deserialize<T>(string input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISerializer.MethodInfoStoreGeneric_Deserialize_Public_Abstract_Virtual_New_T_String_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000048A8 File Offset: 0x00002AA8
		[CallerCount(0)]
		public unsafe virtual Object Deserialize(string input, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISerializer.NativeMethodInfoPtr_Deserialize_Public_Abstract_Virtual_New_Object_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00004918 File Offset: 0x00002B18
		[CallerCount(0)]
		public unsafe virtual T Deserialize<T>(Stream input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISerializer.MethodInfoStoreGeneric_Deserialize_Public_Abstract_Virtual_New_T_Stream_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000020CD File Offset: 0x000002CD
		public ISerializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_get_Format_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Abstract_Virtual_New_Void_Object_Stream_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Abstract_Virtual_New_String_Object_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Abstract_Virtual_New_T_String_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Abstract_Virtual_New_Object_String_Type_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Abstract_Virtual_New_T_Stream_0;

		// Token: 0x02000040 RID: 64
		private sealed class MethodInfoStoreGeneric_Deserialize_Public_Abstract_Virtual_New_T_String_0<T>
		{
			// Token: 0x040001CD RID: 461
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ISerializer.NativeMethodInfoPtr_Deserialize_Public_Abstract_Virtual_New_T_String_0, Il2CppClassPointerStore<ISerializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000041 RID: 65
		private sealed class MethodInfoStoreGeneric_Deserialize_Public_Abstract_Virtual_New_T_Stream_0<T>
		{
			// Token: 0x040001CE RID: 462
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ISerializer.NativeMethodInfoPtr_Deserialize_Public_Abstract_Virtual_New_T_Stream_0, Il2CppClassPointerStore<ISerializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}

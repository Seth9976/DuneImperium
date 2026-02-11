using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace dwd.core.session
{
	// Token: 0x020000F5 RID: 245
	public class ISessionWriter : Il2CppObjectBase
	{
		// Token: 0x06000E73 RID: 3699 RVA: 0x0004CE84 File Offset: 0x0004B084
		// Note: this type is marked as 'beforefieldinit'.
		static ISessionWriter()
		{
			Il2CppClassPointerStore<ISessionWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.session", "ISessionWriter");
			ISessionWriter.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISessionWriter>.NativeClassPtr, 100665386);
			ISessionWriter.NativeMethodInfoPtr_WriteSimpleMessage_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISessionWriter>.NativeClassPtr, 100665387);
			ISessionWriter.NativeMethodInfoPtr_AddListener_Public_Abstract_Virtual_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISessionWriter>.NativeClassPtr, 100665388);
			ISessionWriter.NativeMethodInfoPtr_AddListener_Public_Abstract_Virtual_New_Void_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISessionWriter>.NativeClassPtr, 100665389);
			ISessionWriter.NativeMethodInfoPtr_RemoveListener_Public_Abstract_Virtual_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISessionWriter>.NativeClassPtr, 100665390);
			ISessionWriter.NativeMethodInfoPtr_RemoveListener_Public_Abstract_Virtual_New_Void_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISessionWriter>.NativeClassPtr, 100665391);
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x0004CF24 File Offset: 0x0004B124
		[CallerCount(0)]
		public unsafe virtual void Write(Object message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISessionWriter.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x0004CF74 File Offset: 0x0004B174
		[CallerCount(0)]
		public unsafe virtual void WriteSimpleMessage(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISessionWriter.NativeMethodInfoPtr_WriteSimpleMessage_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x0004CFC4 File Offset: 0x0004B1C4
		[CallerCount(0)]
		public unsafe virtual void AddListener<T>(Action listener) where T : DWDEvent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISessionWriter.MethodInfoStoreGeneric_AddListener_Public_Abstract_Virtual_New_Void_Action_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x0004D014 File Offset: 0x0004B214
		[CallerCount(0)]
		public unsafe virtual void AddListener<T>(Action<T> listener) where T : DWDEvent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISessionWriter.MethodInfoStoreGeneric_AddListener_Public_Abstract_Virtual_New_Void_Action_1_T_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x0004D064 File Offset: 0x0004B264
		[CallerCount(0)]
		public unsafe virtual void RemoveListener<T>(Action listener) where T : DWDEvent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISessionWriter.MethodInfoStoreGeneric_RemoveListener_Public_Abstract_Virtual_New_Void_Action_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x0004D0B4 File Offset: 0x0004B2B4
		[CallerCount(0)]
		public unsafe virtual void RemoveListener<T>(Action<T> listener) where T : DWDEvent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISessionWriter.MethodInfoStoreGeneric_RemoveListener_Public_Abstract_Virtual_New_Void_Action_1_T_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x00006E99 File Offset: 0x00005099
		public ISessionWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A62 RID: 2658
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_Object_0;

		// Token: 0x04000A63 RID: 2659
		private static readonly IntPtr NativeMethodInfoPtr_WriteSimpleMessage_Public_Abstract_Virtual_New_Void_String_0;

		// Token: 0x04000A64 RID: 2660
		private static readonly IntPtr NativeMethodInfoPtr_AddListener_Public_Abstract_Virtual_New_Void_Action_0;

		// Token: 0x04000A65 RID: 2661
		private static readonly IntPtr NativeMethodInfoPtr_AddListener_Public_Abstract_Virtual_New_Void_Action_1_T_0;

		// Token: 0x04000A66 RID: 2662
		private static readonly IntPtr NativeMethodInfoPtr_RemoveListener_Public_Abstract_Virtual_New_Void_Action_0;

		// Token: 0x04000A67 RID: 2663
		private static readonly IntPtr NativeMethodInfoPtr_RemoveListener_Public_Abstract_Virtual_New_Void_Action_1_T_0;

		// Token: 0x020002AE RID: 686
		private sealed class MethodInfoStoreGeneric_AddListener_Public_Abstract_Virtual_New_Void_Action_0<T>
		{
			// Token: 0x04001689 RID: 5769
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ISessionWriter.NativeMethodInfoPtr_AddListener_Public_Abstract_Virtual_New_Void_Action_0, Il2CppClassPointerStore<ISessionWriter>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020002AF RID: 687
		private sealed class MethodInfoStoreGeneric_AddListener_Public_Abstract_Virtual_New_Void_Action_1_T_0<T>
		{
			// Token: 0x0400168A RID: 5770
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ISessionWriter.NativeMethodInfoPtr_AddListener_Public_Abstract_Virtual_New_Void_Action_1_T_0, Il2CppClassPointerStore<ISessionWriter>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020002B0 RID: 688
		private sealed class MethodInfoStoreGeneric_RemoveListener_Public_Abstract_Virtual_New_Void_Action_0<T>
		{
			// Token: 0x0400168B RID: 5771
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ISessionWriter.NativeMethodInfoPtr_RemoveListener_Public_Abstract_Virtual_New_Void_Action_0, Il2CppClassPointerStore<ISessionWriter>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020002B1 RID: 689
		private sealed class MethodInfoStoreGeneric_RemoveListener_Public_Abstract_Virtual_New_Void_Action_1_T_0<T>
		{
			// Token: 0x0400168C RID: 5772
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ISessionWriter.NativeMethodInfoPtr_RemoveListener_Public_Abstract_Virtual_New_Void_Action_1_T_0, Il2CppClassPointerStore<ISessionWriter>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Events
{
	// Token: 0x020001A3 RID: 419
	public class BaseInvokableCall : Object
	{
		// Token: 0x06001F1A RID: 7962 RVA: 0x0008AEB8 File Offset: 0x000890B8
		// Note: this type is marked as 'beforefieldinit'.
		static BaseInvokableCall()
		{
			Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "BaseInvokableCall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr);
			BaseInvokableCall.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr, 100667559);
			BaseInvokableCall.NativeMethodInfoPtr__ctor_Protected_Void_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr, 100667560);
			BaseInvokableCall.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr, 100667561);
			BaseInvokableCall.NativeMethodInfoPtr_ThrowOnInvalidArg_Protected_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr, 100667562);
			BaseInvokableCall.NativeMethodInfoPtr_AllowInvoke_Protected_Static_Boolean_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr, 100667563);
			BaseInvokableCall.NativeMethodInfoPtr_Find_Public_Abstract_Virtual_New_Boolean_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr, 100667564);
		}

		// Token: 0x06001F1B RID: 7963 RVA: 0x0008AF60 File Offset: 0x00089160
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseInvokableCall()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInvokableCall.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F1C RID: 7964 RVA: 0x0008AF9C File Offset: 0x0008919C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 678116, RefRangeEnd = 678128, XrefRangeStart = 678112, XrefRangeEnd = 678116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseInvokableCall(Object target, MethodInfo function)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(function);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInvokableCall.NativeMethodInfoPtr__ctor_Protected_Void_Object_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F1D RID: 7965 RVA: 0x0008AFFC File Offset: 0x000891FC
		[CallerCount(0)]
		public unsafe virtual void Invoke(Il2CppReferenceArray<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInvokableCall.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Void_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F1E RID: 7966 RVA: 0x0008B04C File Offset: 0x0008924C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 678131, RefRangeEnd = 678137, XrefRangeStart = 678128, XrefRangeEnd = 678131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowOnInvalidArg<T>(Object arg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInvokableCall.MethodInfoStoreGeneric_ThrowOnInvalidArg_Protected_Static_Void_Object_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F1F RID: 7967 RVA: 0x0008B084 File Offset: 0x00089284
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 678141, RefRangeEnd = 678149, XrefRangeStart = 678137, XrefRangeEnd = 678141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AllowInvoke(Delegate @delegate)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@delegate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInvokableCall.NativeMethodInfoPtr_AllowInvoke_Protected_Static_Boolean_Delegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F20 RID: 7968 RVA: 0x0008B0C8 File Offset: 0x000892C8
		[CallerCount(0)]
		public unsafe virtual bool Find(Object targetObj, MethodInfo method)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInvokableCall.NativeMethodInfoPtr_Find_Public_Abstract_Virtual_New_Boolean_Object_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F21 RID: 7969 RVA: 0x0000BD4C File Offset: 0x00009F4C
		public BaseInvokableCall(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001B28 RID: 6952
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001B29 RID: 6953
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Object_MethodInfo_0;

		// Token: 0x04001B2A RID: 6954
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Void_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04001B2B RID: 6955
		private static readonly IntPtr NativeMethodInfoPtr_ThrowOnInvalidArg_Protected_Static_Void_Object_0;

		// Token: 0x04001B2C RID: 6956
		private static readonly IntPtr NativeMethodInfoPtr_AllowInvoke_Protected_Static_Boolean_Delegate_0;

		// Token: 0x04001B2D RID: 6957
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Abstract_Virtual_New_Boolean_Object_MethodInfo_0;

		// Token: 0x0200087D RID: 2173
		private sealed class MethodInfoStoreGeneric_ThrowOnInvalidArg_Protected_Static_Void_Object_0<T>
		{
			// Token: 0x04002CF3 RID: 11507
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BaseInvokableCall.NativeMethodInfoPtr_ThrowOnInvalidArg_Protected_Static_Void_Object_0, Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Google.Apis.Logging
{
	// Token: 0x0200001A RID: 26
	public class ILogger : Il2CppObjectBase
	{
		// Token: 0x06000115 RID: 277 RVA: 0x00008314 File Offset: 0x00006514
		// Note: this type is marked as 'beforefieldinit'.
		static ILogger()
		{
			Il2CppClassPointerStore<ILogger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Logging", "ILogger");
			ILogger.NativeMethodInfoPtr_get_IsDebugEnabled_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILogger>.NativeClassPtr, 100663458);
			ILogger.NativeMethodInfoPtr_ForType_Public_Abstract_Virtual_New_ILogger_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILogger>.NativeClassPtr, 100663459);
			ILogger.NativeMethodInfoPtr_ForType_Public_Abstract_Virtual_New_ILogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILogger>.NativeClassPtr, 100663460);
			ILogger.NativeMethodInfoPtr_Debug_Public_Abstract_Virtual_New_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILogger>.NativeClassPtr, 100663461);
			ILogger.NativeMethodInfoPtr_Info_Public_Abstract_Virtual_New_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILogger>.NativeClassPtr, 100663462);
			ILogger.NativeMethodInfoPtr_Warning_Public_Abstract_Virtual_New_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILogger>.NativeClassPtr, 100663463);
			ILogger.NativeMethodInfoPtr_Error_Public_Abstract_Virtual_New_Void_Exception_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILogger>.NativeClassPtr, 100663464);
			ILogger.NativeMethodInfoPtr_Error_Public_Abstract_Virtual_New_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILogger>.NativeClassPtr, 100663465);
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000116 RID: 278 RVA: 0x000083DC File Offset: 0x000065DC
		public unsafe virtual bool IsDebugEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILogger.NativeMethodInfoPtr_get_IsDebugEnabled_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00008424 File Offset: 0x00006624
		[CallerCount(0)]
		public unsafe virtual ILogger ForType(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILogger.NativeMethodInfoPtr_ForType_Public_Abstract_Virtual_New_ILogger_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr3) : null;
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00008480 File Offset: 0x00006680
		[CallerCount(0)]
		public unsafe virtual ILogger ForType<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILogger.MethodInfoStoreGeneric_ForType_Public_Abstract_Virtual_New_ILogger_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr3) : null;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000084CC File Offset: 0x000066CC
		[CallerCount(0)]
		public unsafe virtual void Debug(string message, [Optional] Il2CppReferenceArray<Object> formatArgs)
		{
			if (formatArgs == null)
			{
				formatArgs = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatArgs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILogger.NativeMethodInfoPtr_Debug_Public_Abstract_Virtual_New_Void_String_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00008538 File Offset: 0x00006738
		[CallerCount(0)]
		public unsafe virtual void Info(string message, [Optional] Il2CppReferenceArray<Object> formatArgs)
		{
			if (formatArgs == null)
			{
				formatArgs = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatArgs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILogger.NativeMethodInfoPtr_Info_Public_Abstract_Virtual_New_Void_String_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000085A4 File Offset: 0x000067A4
		[CallerCount(0)]
		public unsafe virtual void Warning(string message, [Optional] Il2CppReferenceArray<Object> formatArgs)
		{
			if (formatArgs == null)
			{
				formatArgs = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatArgs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILogger.NativeMethodInfoPtr_Warning_Public_Abstract_Virtual_New_Void_String_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00008610 File Offset: 0x00006810
		[CallerCount(0)]
		public unsafe virtual void Error(Exception exception, string message, [Optional] Il2CppReferenceArray<Object> formatArgs)
		{
			if (formatArgs == null)
			{
				formatArgs = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatArgs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILogger.NativeMethodInfoPtr_Error_Public_Abstract_Virtual_New_Void_Exception_String_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00008690 File Offset: 0x00006890
		[CallerCount(0)]
		public unsafe virtual void Error(string message, [Optional] Il2CppReferenceArray<Object> formatArgs)
		{
			if (formatArgs == null)
			{
				formatArgs = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatArgs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILogger.NativeMethodInfoPtr_Error_Public_Abstract_Virtual_New_Void_String_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000265E File Offset: 0x0000085E
		public virtual void Debug(string message, params Object[] formatArgs)
		{
			this.Debug(message, new Il2CppReferenceArray<Object>(formatArgs));
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000266D File Offset: 0x0000086D
		public virtual void Info(string message, params Object[] formatArgs)
		{
			this.Info(message, new Il2CppReferenceArray<Object>(formatArgs));
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000267C File Offset: 0x0000087C
		public virtual void Warning(string message, params Object[] formatArgs)
		{
			this.Warning(message, new Il2CppReferenceArray<Object>(formatArgs));
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000268B File Offset: 0x0000088B
		public virtual void Error(Exception exception, string message, params Object[] formatArgs)
		{
			this.Error(exception, message, new Il2CppReferenceArray<Object>(formatArgs));
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000269B File Offset: 0x0000089B
		public virtual void Error(string message, params Object[] formatArgs)
		{
			this.Error(message, new Il2CppReferenceArray<Object>(formatArgs));
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000026AA File Offset: 0x000008AA
		public ILogger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDebugEnabled_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_ForType_Public_Abstract_Virtual_New_ILogger_Type_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_ForType_Public_Abstract_Virtual_New_ILogger_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_Debug_Public_Abstract_Virtual_New_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_Info_Public_Abstract_Virtual_New_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_Warning_Public_Abstract_Virtual_New_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_Error_Public_Abstract_Virtual_New_Void_Exception_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_Error_Public_Abstract_Virtual_New_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x02000050 RID: 80
		private sealed class MethodInfoStoreGeneric_ForType_Public_Abstract_Virtual_New_ILogger_0<T>
		{
			// Token: 0x040001F9 RID: 505
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ILogger.NativeMethodInfoPtr_ForType_Public_Abstract_Virtual_New_ILogger_0, Il2CppClassPointerStore<ILogger>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}

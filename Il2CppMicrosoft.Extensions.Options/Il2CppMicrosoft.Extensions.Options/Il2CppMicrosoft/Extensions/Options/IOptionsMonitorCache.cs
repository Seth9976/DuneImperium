using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.Options
{
	// Token: 0x02000014 RID: 20
	public class IOptionsMonitorCache<TOptions> : Il2CppObjectBase where TOptions : class
	{
		// Token: 0x0600004C RID: 76 RVA: 0x00003780 File Offset: 0x00001980
		// Note: this type is marked as 'beforefieldinit'.
		static IOptionsMonitorCache()
		{
			Il2CppClassPointerStore<IOptionsMonitorCache<TOptions>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Microsoft.Extensions.Options.dll", "Microsoft.Extensions.Options", "IOptionsMonitorCache`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOptions>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IOptionsMonitorCache<TOptions>>.NativeClassPtr);
			IOptionsMonitorCache<TOptions>.NativeMethodInfoPtr_GetOrAdd_Public_Abstract_Virtual_New_TOptions_String_Func_1_TOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOptionsMonitorCache<TOptions>>.NativeClassPtr, 100663320);
			IOptionsMonitorCache<TOptions>.NativeMethodInfoPtr_TryRemove_Public_Abstract_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOptionsMonitorCache<TOptions>>.NativeClassPtr, 100663321);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003814 File Offset: 0x00001A14
		[CallerCount(0)]
		public unsafe virtual TOptions GetOrAdd(string name, Func<TOptions> createOptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(createOptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IOptionsMonitorCache<TOptions>.NativeMethodInfoPtr_GetOrAdd_Public_Abstract_Virtual_New_TOptions_String_Func_1_TOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TOptions>(intPtr, false, true);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000387C File Offset: 0x00001A7C
		[CallerCount(0)]
		public unsafe virtual bool TryRemove(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IOptionsMonitorCache<TOptions>.NativeMethodInfoPtr_TryRemove_Public_Abstract_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000225E File Offset: 0x0000045E
		public IOptionsMonitorCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_GetOrAdd_Public_Abstract_Virtual_New_TOptions_String_Func_1_TOptions_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_TryRemove_Public_Abstract_Virtual_New_Boolean_String_0;
	}
}

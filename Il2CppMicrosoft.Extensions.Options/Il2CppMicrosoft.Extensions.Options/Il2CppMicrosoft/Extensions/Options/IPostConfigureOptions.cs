using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.Options
{
	// Token: 0x02000016 RID: 22
	public class IPostConfigureOptions<TOptions> : Il2CppObjectBase where TOptions : class
	{
		// Token: 0x06000052 RID: 82 RVA: 0x00003940 File Offset: 0x00001B40
		// Note: this type is marked as 'beforefieldinit'.
		static IPostConfigureOptions()
		{
			Il2CppClassPointerStore<IPostConfigureOptions<TOptions>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Microsoft.Extensions.Options.dll", "Microsoft.Extensions.Options", "IPostConfigureOptions`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOptions>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPostConfigureOptions<TOptions>>.NativeClassPtr);
			IPostConfigureOptions<TOptions>.NativeMethodInfoPtr_PostConfigure_Public_Abstract_Virtual_New_Void_String_TOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPostConfigureOptions<TOptions>>.NativeClassPtr, 100663322);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000039C0 File Offset: 0x00001BC0
		[CallerCount(0)]
		public unsafe virtual void PostConfigure(string name, TOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TOptions).IsValueType)
			{
				TOptions toptions = options;
				intPtr = ((toptions is string) ? IL2CPP.ManagedStringToIl2Cpp(toptions as string) : IL2CPP.Il2CppObjectBaseToPtr(toptions as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref options;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPostConfigureOptions<TOptions>.NativeMethodInfoPtr_PostConfigure_Public_Abstract_Virtual_New_Void_String_TOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002270 File Offset: 0x00000470
		public IPostConfigureOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_PostConfigure_Public_Abstract_Virtual_New_Void_String_TOptions_0;
	}
}

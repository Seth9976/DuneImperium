using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.Options
{
	// Token: 0x0200000E RID: 14
	public class IConfigureNamedOptions<TOptions> : Il2CppObjectBase where TOptions : class
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00003170 File Offset: 0x00001370
		// Note: this type is marked as 'beforefieldinit'.
		static IConfigureNamedOptions()
		{
			Il2CppClassPointerStore<IConfigureNamedOptions<TOptions>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Microsoft.Extensions.Options.dll", "Microsoft.Extensions.Options", "IConfigureNamedOptions`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOptions>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IConfigureNamedOptions<TOptions>>.NativeClassPtr);
			IConfigureNamedOptions<TOptions>.NativeMethodInfoPtr_Configure_Public_Abstract_Virtual_New_Void_String_TOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigureNamedOptions<TOptions>>.NativeClassPtr, 100663312);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000031F0 File Offset: 0x000013F0
		[CallerCount(0)]
		public unsafe virtual void Configure(string name, TOptions options)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigureNamedOptions<TOptions>.NativeMethodInfoPtr_Configure_Public_Abstract_Virtual_New_Void_String_TOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002228 File Offset: 0x00000428
		public IConfigureNamedOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Abstract_Virtual_New_Void_String_TOptions_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.Options
{
	// Token: 0x02000017 RID: 23
	public class IValidateOptions<TOptions> : Il2CppObjectBase where TOptions : class
	{
		// Token: 0x06000055 RID: 85 RVA: 0x00003A58 File Offset: 0x00001C58
		// Note: this type is marked as 'beforefieldinit'.
		static IValidateOptions()
		{
			Il2CppClassPointerStore<IValidateOptions<TOptions>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Microsoft.Extensions.Options.dll", "Microsoft.Extensions.Options", "IValidateOptions`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOptions>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IValidateOptions<TOptions>>.NativeClassPtr);
			IValidateOptions<TOptions>.NativeMethodInfoPtr_Validate_Public_Abstract_Virtual_New_ValidateOptionsResult_String_TOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IValidateOptions<TOptions>>.NativeClassPtr, 100663323);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003AD8 File Offset: 0x00001CD8
		[CallerCount(0)]
		public unsafe virtual ValidateOptionsResult Validate(string name, TOptions options)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IValidateOptions<TOptions>.NativeMethodInfoPtr_Validate_Public_Abstract_Virtual_New_ValidateOptionsResult_String_TOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<ValidateOptionsResult>(intPtr4) : null;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002279 File Offset: 0x00000479
		public IValidateOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Public_Abstract_Virtual_New_ValidateOptionsResult_String_TOptions_0;
	}
}

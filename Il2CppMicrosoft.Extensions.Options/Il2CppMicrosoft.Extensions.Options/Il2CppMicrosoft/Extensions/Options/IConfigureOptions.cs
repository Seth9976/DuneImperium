using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.Options
{
	// Token: 0x0200000F RID: 15
	public class IConfigureOptions<TOptions> : Il2CppObjectBase where TOptions : class
	{
		// Token: 0x0600003B RID: 59 RVA: 0x00003288 File Offset: 0x00001488
		// Note: this type is marked as 'beforefieldinit'.
		static IConfigureOptions()
		{
			Il2CppClassPointerStore<IConfigureOptions<TOptions>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Microsoft.Extensions.Options.dll", "Microsoft.Extensions.Options", "IConfigureOptions`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOptions>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IConfigureOptions<TOptions>>.NativeClassPtr);
			IConfigureOptions<TOptions>.NativeMethodInfoPtr_Configure_Public_Abstract_Virtual_New_Void_TOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigureOptions<TOptions>>.NativeClassPtr, 100663313);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003308 File Offset: 0x00001508
		[CallerCount(0)]
		public unsafe virtual void Configure(TOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigureOptions<TOptions>.NativeMethodInfoPtr_Configure_Public_Abstract_Virtual_New_Void_TOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002231 File Offset: 0x00000431
		public IConfigureOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Abstract_Virtual_New_Void_TOptions_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.Options
{
	// Token: 0x02000012 RID: 18
	public class IOptionsFactory<TOptions> : Il2CppObjectBase where TOptions : class
	{
		// Token: 0x06000045 RID: 69 RVA: 0x00003574 File Offset: 0x00001774
		// Note: this type is marked as 'beforefieldinit'.
		static IOptionsFactory()
		{
			Il2CppClassPointerStore<IOptionsFactory<TOptions>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Microsoft.Extensions.Options.dll", "Microsoft.Extensions.Options", "IOptionsFactory`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOptions>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IOptionsFactory<TOptions>>.NativeClassPtr);
			IOptionsFactory<TOptions>.NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_TOptions_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOptionsFactory<TOptions>>.NativeClassPtr, 100663317);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000035F4 File Offset: 0x000017F4
		[CallerCount(0)]
		public unsafe virtual TOptions Create(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IOptionsFactory<TOptions>.NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_TOptions_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TOptions>(intPtr, false, true);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000224C File Offset: 0x0000044C
		public IOptionsFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_TOptions_String_0;
	}
}

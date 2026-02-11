using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.Options
{
	// Token: 0x02000010 RID: 16
	public class IOptions<TOptions> : Il2CppObjectBase where TOptions : class
	{
		// Token: 0x0600003E RID: 62 RVA: 0x0000338C File Offset: 0x0000158C
		// Note: this type is marked as 'beforefieldinit'.
		static IOptions()
		{
			Il2CppClassPointerStore<IOptions<TOptions>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Microsoft.Extensions.Options.dll", "Microsoft.Extensions.Options", "IOptions`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOptions>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IOptions<TOptions>>.NativeClassPtr);
			IOptions<TOptions>.NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_TOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOptions<TOptions>>.NativeClassPtr, 100663314);
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600003F RID: 63 RVA: 0x0000340C File Offset: 0x0000160C
		public unsafe virtual TOptions Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IOptions<TOptions>.NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_TOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TOptions>(intPtr, false, true);
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000223A File Offset: 0x0000043A
		public IOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_TOptions_0;
	}
}

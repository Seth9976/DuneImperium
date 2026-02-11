using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Extensions.Primitives;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.Options
{
	// Token: 0x02000011 RID: 17
	public class IOptionsChangeTokenSource<TOptions> : Il2CppObjectBase
	{
		// Token: 0x06000041 RID: 65 RVA: 0x00003450 File Offset: 0x00001650
		// Note: this type is marked as 'beforefieldinit'.
		static IOptionsChangeTokenSource()
		{
			Il2CppClassPointerStore<IOptionsChangeTokenSource<TOptions>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Microsoft.Extensions.Options.dll", "Microsoft.Extensions.Options", "IOptionsChangeTokenSource`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOptions>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IOptionsChangeTokenSource<TOptions>>.NativeClassPtr);
			IOptionsChangeTokenSource<TOptions>.NativeMethodInfoPtr_GetChangeToken_Public_Abstract_Virtual_New_IChangeToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOptionsChangeTokenSource<TOptions>>.NativeClassPtr, 100663315);
			IOptionsChangeTokenSource<TOptions>.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOptionsChangeTokenSource<TOptions>>.NativeClassPtr, 100663316);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000034E4 File Offset: 0x000016E4
		[CallerCount(0)]
		public unsafe virtual IChangeToken GetChangeToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IOptionsChangeTokenSource<TOptions>.NativeMethodInfoPtr_GetChangeToken_Public_Abstract_Virtual_New_IChangeToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IChangeToken>(intPtr3) : null;
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00003530 File Offset: 0x00001730
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IOptionsChangeTokenSource<TOptions>.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002243 File Offset: 0x00000443
		public IOptionsChangeTokenSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_GetChangeToken_Public_Abstract_Virtual_New_IChangeToken_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.Options
{
	// Token: 0x02000013 RID: 19
	public class IOptionsMonitor<TOptions> : Il2CppObjectBase
	{
		// Token: 0x06000048 RID: 72 RVA: 0x0000364C File Offset: 0x0000184C
		// Note: this type is marked as 'beforefieldinit'.
		static IOptionsMonitor()
		{
			Il2CppClassPointerStore<IOptionsMonitor<TOptions>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Microsoft.Extensions.Options.dll", "Microsoft.Extensions.Options", "IOptionsMonitor`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOptions>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IOptionsMonitor<TOptions>>.NativeClassPtr);
			IOptionsMonitor<TOptions>.NativeMethodInfoPtr_get_CurrentValue_Public_Abstract_Virtual_New_get_TOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOptionsMonitor<TOptions>>.NativeClassPtr, 100663318);
			IOptionsMonitor<TOptions>.NativeMethodInfoPtr_OnChange_Public_Abstract_Virtual_New_IDisposable_Action_2_TOptions_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOptionsMonitor<TOptions>>.NativeClassPtr, 100663319);
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000049 RID: 73 RVA: 0x000036E0 File Offset: 0x000018E0
		public unsafe virtual TOptions CurrentValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IOptionsMonitor<TOptions>.NativeMethodInfoPtr_get_CurrentValue_Public_Abstract_Virtual_New_get_TOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TOptions>(intPtr, false, true);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003724 File Offset: 0x00001924
		[CallerCount(0)]
		public unsafe virtual IDisposable OnChange(Action<TOptions, string> listener)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IOptionsMonitor<TOptions>.NativeMethodInfoPtr_OnChange_Public_Abstract_Virtual_New_IDisposable_Action_2_TOptions_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDisposable>(intPtr3) : null;
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002255 File Offset: 0x00000455
		public IOptionsMonitor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentValue_Public_Abstract_Virtual_New_get_TOptions_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_OnChange_Public_Abstract_Virtual_New_IDisposable_Action_2_TOptions_String_0;
	}
}

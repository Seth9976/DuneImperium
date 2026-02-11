using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.ui.prompt.prompts
{
	// Token: 0x02000022 RID: 34
	public class IYieldablePrompt : Il2CppObjectBase
	{
		// Token: 0x06000153 RID: 339 RVA: 0x00007E9C File Offset: 0x0000609C
		// Note: this type is marked as 'beforefieldinit'.
		static IYieldablePrompt()
		{
			Il2CppClassPointerStore<IYieldablePrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.prompts", "IYieldablePrompt");
			IYieldablePrompt.NativeMethodInfoPtr_YieldsTo_Public_Abstract_Virtual_New_Boolean_IPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IYieldablePrompt>.NativeClassPtr, 100663418);
			IYieldablePrompt.NativeMethodInfoPtr_get_DismissOnYield_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IYieldablePrompt>.NativeClassPtr, 100663419);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00007EEC File Offset: 0x000060EC
		[CallerCount(0)]
		public unsafe virtual bool YieldsTo(IPrompt otherPrompt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(otherPrompt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IYieldablePrompt.NativeMethodInfoPtr_YieldsTo_Public_Abstract_Virtual_New_Boolean_IPrompt_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00007F44 File Offset: 0x00006144
		public unsafe virtual bool DismissOnYield
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IYieldablePrompt.NativeMethodInfoPtr_get_DismissOnYield_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002AEA File Offset: 0x00000CEA
		public IYieldablePrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_YieldsTo_Public_Abstract_Virtual_New_Boolean_IPrompt_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_get_DismissOnYield_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}

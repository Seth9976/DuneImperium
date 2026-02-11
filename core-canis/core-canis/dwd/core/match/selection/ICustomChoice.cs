using System;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.match.selection
{
	// Token: 0x02000133 RID: 307
	public class ICustomChoice : Il2CppObjectBase
	{
		// Token: 0x06001177 RID: 4471 RVA: 0x000080C8 File Offset: 0x000062C8
		// Note: this type is marked as 'beforefieldinit'.
		static ICustomChoice()
		{
			Il2CppClassPointerStore<ICustomChoice>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "ICustomChoice");
			ICustomChoice.NativeMethodInfoPtr_get_Choices_Public_Abstract_Virtual_New_get_IList_1_LocalizableText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomChoice>.NativeClassPtr, 100665854);
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06001178 RID: 4472 RVA: 0x0005945C File Offset: 0x0005765C
		public unsafe virtual IList<LocalizableText> Choices
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomChoice.NativeMethodInfoPtr_get_Choices_Public_Abstract_Virtual_New_get_IList_1_LocalizableText_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<LocalizableText>>(intPtr3) : null;
			}
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x000080F7 File Offset: 0x000062F7
		public ICustomChoice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C6D RID: 3181
		private static readonly IntPtr NativeMethodInfoPtr_get_Choices_Public_Abstract_Virtual_New_get_IList_1_LocalizableText_0;
	}
}

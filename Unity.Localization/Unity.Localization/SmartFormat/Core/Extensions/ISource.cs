using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Localization.SmartFormat.Core.Extensions
{
	// Token: 0x0200008D RID: 141
	public class ISource : Il2CppObjectBase
	{
		// Token: 0x060006DE RID: 1758 RVA: 0x000049C8 File Offset: 0x00002BC8
		// Note: this type is marked as 'beforefieldinit'.
		static ISource()
		{
			Il2CppClassPointerStore<ISource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Core.Extensions", "ISource");
			ISource.NativeMethodInfoPtr_TryEvaluateSelector_Public_Abstract_Virtual_New_Boolean_ISelectorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISource>.NativeClassPtr, 100664543);
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x000236D4 File Offset: 0x000218D4
		[CallerCount(0)]
		public unsafe virtual bool TryEvaluateSelector(ISelectorInfo selectorInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectorInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISource.NativeMethodInfoPtr_TryEvaluateSelector_Public_Abstract_Virtual_New_Boolean_ISelectorInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x000049F7 File Offset: 0x00002BF7
		public ISource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeMethodInfoPtr_TryEvaluateSelector_Public_Abstract_Virtual_New_Boolean_ISelectorInfo_0;
	}
}

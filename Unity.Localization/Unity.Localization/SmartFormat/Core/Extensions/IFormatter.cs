using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Localization.SmartFormat.Core.Extensions
{
	// Token: 0x02000089 RID: 137
	public class IFormatter : Il2CppObjectBase
	{
		// Token: 0x060006C0 RID: 1728 RVA: 0x00022DD0 File Offset: 0x00020FD0
		// Note: this type is marked as 'beforefieldinit'.
		static IFormatter()
		{
			Il2CppClassPointerStore<IFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Core.Extensions", "IFormatter");
			IFormatter.NativeMethodInfoPtr_get_Names_Public_Abstract_Virtual_New_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFormatter>.NativeClassPtr, 100664521);
			IFormatter.NativeMethodInfoPtr_set_Names_Public_Abstract_Virtual_New_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFormatter>.NativeClassPtr, 100664522);
			IFormatter.NativeMethodInfoPtr_TryEvaluateFormat_Public_Abstract_Virtual_New_Boolean_IFormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFormatter>.NativeClassPtr, 100664523);
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x00022E34 File Offset: 0x00021034
		// (set) Token: 0x060006C2 RID: 1730 RVA: 0x00022E80 File Offset: 0x00021080
		public unsafe virtual Il2CppStringArray Names
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFormatter.NativeMethodInfoPtr_get_Names_Public_Abstract_Virtual_New_get_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFormatter.NativeMethodInfoPtr_set_Names_Public_Abstract_Virtual_New_set_Void_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00022ED0 File Offset: 0x000210D0
		[CallerCount(0)]
		public unsafe virtual bool TryEvaluateFormat(IFormattingInfo formattingInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formattingInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFormatter.NativeMethodInfoPtr_TryEvaluateFormat_Public_Abstract_Virtual_New_Boolean_IFormattingInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00004975 File Offset: 0x00002B75
		public IFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeMethodInfoPtr_get_Names_Public_Abstract_Virtual_New_get_Il2CppStringArray_0;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeMethodInfoPtr_set_Names_Public_Abstract_Virtual_New_set_Void_Il2CppStringArray_0;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeMethodInfoPtr_TryEvaluateFormat_Public_Abstract_Virtual_New_Boolean_IFormattingInfo_0;
	}
}

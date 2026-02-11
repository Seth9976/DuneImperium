using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Localization.Tables;

namespace UnityEngine.Localization.Settings
{
	// Token: 0x02000093 RID: 147
	public class ITablePostprocessor : Il2CppObjectBase
	{
		// Token: 0x060006ED RID: 1773 RVA: 0x00004A41 File Offset: 0x00002C41
		// Note: this type is marked as 'beforefieldinit'.
		static ITablePostprocessor()
		{
			Il2CppClassPointerStore<ITablePostprocessor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Settings", "ITablePostprocessor");
			ITablePostprocessor.NativeMethodInfoPtr_PostprocessTable_Public_Abstract_Virtual_New_Void_LocalizationTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITablePostprocessor>.NativeClassPtr, 100664552);
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00023B54 File Offset: 0x00021D54
		[CallerCount(0)]
		public unsafe virtual void PostprocessTable(LocalizationTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITablePostprocessor.NativeMethodInfoPtr_PostprocessTable_Public_Abstract_Virtual_New_Void_LocalizationTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00004A70 File Offset: 0x00002C70
		public ITablePostprocessor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeMethodInfoPtr_PostprocessTable_Public_Abstract_Virtual_New_Void_LocalizationTable_0;
	}
}

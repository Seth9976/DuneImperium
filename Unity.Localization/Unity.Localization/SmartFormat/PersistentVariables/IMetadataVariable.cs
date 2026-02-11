using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Localization.SmartFormat.PersistentVariables
{
	// Token: 0x02000054 RID: 84
	public class IMetadataVariable : Il2CppObjectBase
	{
		// Token: 0x0600045F RID: 1119 RVA: 0x00003AE1 File Offset: 0x00001CE1
		// Note: this type is marked as 'beforefieldinit'.
		static IMetadataVariable()
		{
			Il2CppClassPointerStore<IMetadataVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.PersistentVariables", "IMetadataVariable");
			IMetadataVariable.NativeMethodInfoPtr_get_VariableName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMetadataVariable>.NativeClassPtr, 100664116);
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x00019EC4 File Offset: 0x000180C4
		public unsafe virtual string VariableName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMetadataVariable.NativeMethodInfoPtr_get_VariableName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00003B10 File Offset: 0x00001D10
		public IMetadataVariable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeMethodInfoPtr_get_VariableName_Public_Abstract_Virtual_New_get_String_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Localization.SmartFormat.PersistentVariables;

namespace UnityEngine.Localization.SmartFormat.GlobalVariables
{
	// Token: 0x02000061 RID: 97
	[Serializable]
	public class IntGlobalVariable : IntVariable
	{
		// Token: 0x060004A3 RID: 1187 RVA: 0x00003D36 File Offset: 0x00001F36
		// Note: this type is marked as 'beforefieldinit'.
		static IntGlobalVariable()
		{
			Il2CppClassPointerStore<IntGlobalVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.GlobalVariables", "IntGlobalVariable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntGlobalVariable>.NativeClassPtr);
			IntGlobalVariable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntGlobalVariable>.NativeClassPtr, 100664167);
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0001ACA8 File Offset: 0x00018EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntGlobalVariable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntGlobalVariable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntGlobalVariable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00003D6F File Offset: 0x00001F6F
		public IntGlobalVariable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

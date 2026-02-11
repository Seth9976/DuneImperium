using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Localization.SmartFormat.PersistentVariables;

namespace UnityEngine.Localization.SmartFormat.GlobalVariables
{
	// Token: 0x0200005D RID: 93
	public class GlobalVariablesGroup : VariablesGroupAsset
	{
		// Token: 0x06000497 RID: 1175 RVA: 0x00003C67 File Offset: 0x00001E67
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalVariablesGroup()
		{
			Il2CppClassPointerStore<GlobalVariablesGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.GlobalVariables", "GlobalVariablesGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalVariablesGroup>.NativeClassPtr);
			GlobalVariablesGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalVariablesGroup>.NativeClassPtr, 100664163);
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0001AB38 File Offset: 0x00018D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GlobalVariablesGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalVariablesGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalVariablesGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00003CA0 File Offset: 0x00001EA0
		public GlobalVariablesGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

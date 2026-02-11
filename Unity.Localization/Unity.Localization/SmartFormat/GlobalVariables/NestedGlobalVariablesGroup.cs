using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Localization.SmartFormat.PersistentVariables;

namespace UnityEngine.Localization.SmartFormat.GlobalVariables
{
	// Token: 0x0200005C RID: 92
	public class NestedGlobalVariablesGroup : NestedVariablesGroup
	{
		// Token: 0x06000494 RID: 1172 RVA: 0x00003C25 File Offset: 0x00001E25
		// Note: this type is marked as 'beforefieldinit'.
		static NestedGlobalVariablesGroup()
		{
			Il2CppClassPointerStore<NestedGlobalVariablesGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.GlobalVariables", "NestedGlobalVariablesGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NestedGlobalVariablesGroup>.NativeClassPtr);
			NestedGlobalVariablesGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NestedGlobalVariablesGroup>.NativeClassPtr, 100664162);
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0001AAFC File Offset: 0x00018CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NestedGlobalVariablesGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NestedGlobalVariablesGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NestedGlobalVariablesGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00003C5E File Offset: 0x00001E5E
		public NestedGlobalVariablesGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

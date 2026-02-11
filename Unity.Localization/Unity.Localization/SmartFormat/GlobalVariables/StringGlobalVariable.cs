using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Localization.SmartFormat.PersistentVariables;

namespace UnityEngine.Localization.SmartFormat.GlobalVariables
{
	// Token: 0x02000060 RID: 96
	[Serializable]
	public class StringGlobalVariable : StringVariable
	{
		// Token: 0x060004A0 RID: 1184 RVA: 0x00003CF4 File Offset: 0x00001EF4
		// Note: this type is marked as 'beforefieldinit'.
		static StringGlobalVariable()
		{
			Il2CppClassPointerStore<StringGlobalVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.GlobalVariables", "StringGlobalVariable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringGlobalVariable>.NativeClassPtr);
			StringGlobalVariable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringGlobalVariable>.NativeClassPtr, 100664166);
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0001AC6C File Offset: 0x00018E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringGlobalVariable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringGlobalVariable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringGlobalVariable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00003D2D File Offset: 0x00001F2D
		public StringGlobalVariable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

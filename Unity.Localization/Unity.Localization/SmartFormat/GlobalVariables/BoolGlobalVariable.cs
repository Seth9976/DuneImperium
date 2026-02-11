using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Localization.SmartFormat.PersistentVariables;

namespace UnityEngine.Localization.SmartFormat.GlobalVariables
{
	// Token: 0x02000062 RID: 98
	[Serializable]
	public class BoolGlobalVariable : BoolVariable
	{
		// Token: 0x060004A6 RID: 1190 RVA: 0x00003D78 File Offset: 0x00001F78
		// Note: this type is marked as 'beforefieldinit'.
		static BoolGlobalVariable()
		{
			Il2CppClassPointerStore<BoolGlobalVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.GlobalVariables", "BoolGlobalVariable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoolGlobalVariable>.NativeClassPtr);
			BoolGlobalVariable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolGlobalVariable>.NativeClassPtr, 100664168);
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x0001ACE4 File Offset: 0x00018EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoolGlobalVariable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolGlobalVariable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolGlobalVariable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00003DB1 File Offset: 0x00001FB1
		public BoolGlobalVariable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

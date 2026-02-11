using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Localization.SmartFormat.PersistentVariables;

namespace UnityEngine.Localization.SmartFormat.GlobalVariables
{
	// Token: 0x0200005F RID: 95
	[Serializable]
	public class FloatGlobalVariable : FloatVariable
	{
		// Token: 0x0600049D RID: 1181 RVA: 0x00003CB2 File Offset: 0x00001EB2
		// Note: this type is marked as 'beforefieldinit'.
		static FloatGlobalVariable()
		{
			Il2CppClassPointerStore<FloatGlobalVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.GlobalVariables", "FloatGlobalVariable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatGlobalVariable>.NativeClassPtr);
			FloatGlobalVariable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatGlobalVariable>.NativeClassPtr, 100664165);
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x0001AC30 File Offset: 0x00018E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FloatGlobalVariable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatGlobalVariable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatGlobalVariable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00003CEB File Offset: 0x00001EEB
		public FloatGlobalVariable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

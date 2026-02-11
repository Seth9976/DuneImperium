using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.SmartFormat.Extensions
{
	// Token: 0x02000068 RID: 104
	[Serializable]
	public class GlobalVariablesSource : PersistentVariablesSource
	{
		// Token: 0x060004CA RID: 1226 RVA: 0x00003E14 File Offset: 0x00002014
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalVariablesSource()
		{
			Il2CppClassPointerStore<GlobalVariablesSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Extensions", "GlobalVariablesSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalVariablesSource>.NativeClassPtr);
			GlobalVariablesSource.NativeMethodInfoPtr__ctor_Public_Void_SmartFormatter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalVariablesSource>.NativeClassPtr, 100664191);
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x0001B5C8 File Offset: 0x000197C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1071864, RefRangeEnd = 1071865, XrefRangeStart = 1071845, XrefRangeEnd = 1071864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GlobalVariablesSource(SmartFormatter formatter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalVariablesSource>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalVariablesSource.NativeMethodInfoPtr__ctor_Public_Void_SmartFormatter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00003E4D File Offset: 0x0000204D
		public GlobalVariablesSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SmartFormatter_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dbgclient.input
{
	// Token: 0x020000AE RID: 174
	public class InputValidatorInitializer : MonoBehaviour
	{
		// Token: 0x0600070A RID: 1802 RVA: 0x00033B20 File Offset: 0x00031D20
		// Note: this type is marked as 'beforefieldinit'.
		static InputValidatorInitializer()
		{
			Il2CppClassPointerStore<InputValidatorInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.input", "InputValidatorInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputValidatorInitializer>.NativeClassPtr);
			InputValidatorInitializer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputValidatorInitializer>.NativeClassPtr, 100664378);
			InputValidatorInitializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputValidatorInitializer>.NativeClassPtr, 100664379);
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00033B78 File Offset: 0x00031D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503969, XrefRangeEnd = 503980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputValidatorInitializer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00033BAC File Offset: 0x00031DAC
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputValidatorInitializer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputValidatorInitializer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputValidatorInitializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x000053F7 File Offset: 0x000035F7
		public InputValidatorInitializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

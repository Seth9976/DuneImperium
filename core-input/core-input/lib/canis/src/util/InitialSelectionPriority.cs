using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace lib.canis.src.util
{
	// Token: 0x0200000F RID: 15
	public class InitialSelectionPriority : MonoBehaviour
	{
		// Token: 0x0600005D RID: 93 RVA: 0x0000853C File Offset: 0x0000673C
		// Note: this type is marked as 'beforefieldinit'.
		static InitialSelectionPriority()
		{
			Il2CppClassPointerStore<InitialSelectionPriority>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "lib.canis.src.util", "InitialSelectionPriority");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitialSelectionPriority>.NativeClassPtr);
			InitialSelectionPriority.NativeMethodInfoPtr_get_Priority_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialSelectionPriority>.NativeClassPtr, 100663345);
			InitialSelectionPriority.NativeMethodInfoPtr_getPriority_Protected_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialSelectionPriority>.NativeClassPtr, 100663346);
			InitialSelectionPriority.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialSelectionPriority>.NativeClassPtr, 100663347);
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600005E RID: 94 RVA: 0x000085A8 File Offset: 0x000067A8
		public unsafe int Priority
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 660290, RefRangeEnd = 660296, XrefRangeStart = 660290, XrefRangeEnd = 660296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitialSelectionPriority.NativeMethodInfoPtr_get_Priority_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000085E4 File Offset: 0x000067E4
		[CallerCount(0)]
		public unsafe virtual int getPriority()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InitialSelectionPriority.NativeMethodInfoPtr_getPriority_Protected_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000862C File Offset: 0x0000682C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InitialSelectionPriority()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitialSelectionPriority>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitialSelectionPriority.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002275 File Offset: 0x00000475
		public InitialSelectionPriority(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_get_Priority_Public_get_Int32_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_getPriority_Protected_Abstract_Virtual_New_Int32_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

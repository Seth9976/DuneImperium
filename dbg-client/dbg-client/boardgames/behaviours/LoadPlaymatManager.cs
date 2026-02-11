using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using UnityEngine;

namespace boardgames.behaviours
{
	// Token: 0x020002A7 RID: 679
	public class LoadPlaymatManager : MonoBehaviour
	{
		// Token: 0x0600204B RID: 8267 RVA: 0x00089374 File Offset: 0x00087574
		// Note: this type is marked as 'beforefieldinit'.
		static LoadPlaymatManager()
		{
			Il2CppClassPointerStore<LoadPlaymatManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.behaviours", "LoadPlaymatManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadPlaymatManager>.NativeClassPtr);
			LoadPlaymatManager.NativeMethodInfoPtr_OnLoadIntoPlaymat_Public_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPlaymatManager>.NativeClassPtr, 100668658);
			LoadPlaymatManager.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPlaymatManager>.NativeClassPtr, 100668659);
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x000893CC File Offset: 0x000875CC
		[CallerCount(0)]
		public unsafe virtual IEnumerator OnLoadIntoPlaymat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadPlaymatManager.NativeMethodInfoPtr_OnLoadIntoPlaymat_Public_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x00089418 File Offset: 0x00087618
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadPlaymatManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadPlaymatManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadPlaymatManager.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x00010F16 File Offset: 0x0000F116
		public LoadPlaymatManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001468 RID: 5224
		private static readonly IntPtr NativeMethodInfoPtr_OnLoadIntoPlaymat_Public_Abstract_Virtual_New_IEnumerator_0;

		// Token: 0x04001469 RID: 5225
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

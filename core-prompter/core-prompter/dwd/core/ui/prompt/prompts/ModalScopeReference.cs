using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.ui.prompt.prompts
{
	// Token: 0x02000011 RID: 17
	public class ModalScopeReference : MonoBehaviour
	{
		// Token: 0x06000087 RID: 135 RVA: 0x00005D0C File Offset: 0x00003F0C
		// Note: this type is marked as 'beforefieldinit'.
		static ModalScopeReference()
		{
			Il2CppClassPointerStore<ModalScopeReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.prompts", "ModalScopeReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModalScopeReference>.NativeClassPtr);
			ModalScopeReference.NativeFieldInfoPtr_scope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModalScopeReference>.NativeClassPtr, "scope");
			ModalScopeReference.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModalScopeReference>.NativeClassPtr, 100663367);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00005D64 File Offset: 0x00003F64
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ModalScopeReference()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModalScopeReference>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModalScopeReference.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002418 File Offset: 0x00000618
		public ModalScopeReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00005DA0 File Offset: 0x00003FA0
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00002421 File Offset: 0x00000621
		public unsafe ModalScope scope
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModalScopeReference.NativeFieldInfoPtr_scope);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModalScope>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModalScopeReference.NativeFieldInfoPtr_scope), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeFieldInfoPtr_scope;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

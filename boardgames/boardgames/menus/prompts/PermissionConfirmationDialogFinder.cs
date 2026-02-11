using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace boardgames.menus.prompts
{
	// Token: 0x02000151 RID: 337
	public class PermissionConfirmationDialogFinder : MonoBehaviour
	{
		// Token: 0x0600114B RID: 4427 RVA: 0x0000A149 File Offset: 0x00008349
		// Note: this type is marked as 'beforefieldinit'.
		static PermissionConfirmationDialogFinder()
		{
			Il2CppClassPointerStore<PermissionConfirmationDialogFinder>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.menus.prompts", "PermissionConfirmationDialogFinder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PermissionConfirmationDialogFinder>.NativeClassPtr);
			PermissionConfirmationDialogFinder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionConfirmationDialogFinder>.NativeClassPtr, 100665839);
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x000461DC File Offset: 0x000443DC
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PermissionConfirmationDialogFinder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PermissionConfirmationDialogFinder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PermissionConfirmationDialogFinder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x0000A182 File Offset: 0x00008382
		public PermissionConfirmationDialogFinder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A85 RID: 2693
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

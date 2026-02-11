using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace lib.canis.dbg_client.voodoo
{
	// Token: 0x02000034 RID: 52
	public class PassAndPlayResetView : MonoBehaviour
	{
		// Token: 0x060001E4 RID: 484 RVA: 0x00023938 File Offset: 0x00021B38
		// Note: this type is marked as 'beforefieldinit'.
		static PassAndPlayResetView()
		{
			Il2CppClassPointerStore<PassAndPlayResetView>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "lib.canis.dbg_client.voodoo", "PassAndPlayResetView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PassAndPlayResetView>.NativeClassPtr);
			PassAndPlayResetView.NativeFieldInfoPtr_UILoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassAndPlayResetView>.NativeClassPtr, "UILoader");
			PassAndPlayResetView.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassAndPlayResetView>.NativeClassPtr, 100663605);
			PassAndPlayResetView.NativeMethodInfoPtr_InitFromContext_Public_Virtual_New_Void_EntityInitializationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassAndPlayResetView>.NativeClassPtr, 100663606);
			PassAndPlayResetView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassAndPlayResetView>.NativeClassPtr, 100663607);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x000239B8 File Offset: 0x00021BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497944, XrefRangeEnd = 497984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PassAndPlayResetView.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x000239F4 File Offset: 0x00021BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497984, XrefRangeEnd = 497985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitFromContext(EntityInitializationContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PassAndPlayResetView.NativeMethodInfoPtr_InitFromContext_Public_Virtual_New_Void_EntityInitializationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00023A44 File Offset: 0x00021C44
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PassAndPlayResetView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PassAndPlayResetView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassAndPlayResetView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002CF9 File Offset: 0x00000EF9
		public PassAndPlayResetView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x00023A80 File Offset: 0x00021C80
		// (set) Token: 0x060001EA RID: 490 RVA: 0x00002D02 File Offset: 0x00000F02
		public unsafe VoodooView UILoader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassAndPlayResetView.NativeFieldInfoPtr_UILoader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassAndPlayResetView.NativeFieldInfoPtr_UILoader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeFieldInfoPtr_UILoader;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_InitFromContext_Public_Virtual_New_Void_EntityInitializationContext_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

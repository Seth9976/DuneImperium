using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.ui
{
	// Token: 0x0200011B RID: 283
	public class DisconnectWarningDisplay : MonoBehaviour
	{
		// Token: 0x06000EB9 RID: 3769 RVA: 0x0003DC68 File Offset: 0x0003BE68
		// Note: this type is marked as 'beforefieldinit'.
		static DisconnectWarningDisplay()
		{
			Il2CppClassPointerStore<DisconnectWarningDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.ui", "DisconnectWarningDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisconnectWarningDisplay>.NativeClassPtr);
			DisconnectWarningDisplay.NativeFieldInfoPtr_warningAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisconnectWarningDisplay>.NativeClassPtr, "warningAnim");
			DisconnectWarningDisplay.NativeFieldInfoPtr_warningParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisconnectWarningDisplay>.NativeClassPtr, "warningParam");
			DisconnectWarningDisplay.NativeMethodInfoPtr_ToggleDisconnectWarning_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisconnectWarningDisplay>.NativeClassPtr, 100665401);
			DisconnectWarningDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisconnectWarningDisplay>.NativeClassPtr, 100665402);
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x0003DCE8 File Offset: 0x0003BEE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996745, XrefRangeEnd = 996750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleDisconnectWarning(bool showWarning)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref showWarning;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisconnectWarningDisplay.NativeMethodInfoPtr_ToggleDisconnectWarning_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x0003DD28 File Offset: 0x0003BF28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996750, XrefRangeEnd = 996755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DisconnectWarningDisplay()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisconnectWarningDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisconnectWarningDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x00008E22 File Offset: 0x00007022
		public DisconnectWarningDisplay(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000EBD RID: 3773 RVA: 0x0003DD64 File Offset: 0x0003BF64
		// (set) Token: 0x06000EBE RID: 3774 RVA: 0x00008E2B File Offset: 0x0000702B
		public unsafe Animator warningAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisconnectWarningDisplay.NativeFieldInfoPtr_warningAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisconnectWarningDisplay.NativeFieldInfoPtr_warningAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000EBF RID: 3775 RVA: 0x0003DD94 File Offset: 0x0003BF94
		// (set) Token: 0x06000EC0 RID: 3776 RVA: 0x00008E4A File Offset: 0x0000704A
		public unsafe string warningParam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisconnectWarningDisplay.NativeFieldInfoPtr_warningParam);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisconnectWarningDisplay.NativeFieldInfoPtr_warningParam), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040008E7 RID: 2279
		private static readonly IntPtr NativeFieldInfoPtr_warningAnim;

		// Token: 0x040008E8 RID: 2280
		private static readonly IntPtr NativeFieldInfoPtr_warningParam;

		// Token: 0x040008E9 RID: 2281
		private static readonly IntPtr NativeMethodInfoPtr_ToggleDisconnectWarning_Public_Void_Boolean_0;

		// Token: 0x040008EA RID: 2282
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.ui.ugui
{
	// Token: 0x0200000E RID: 14
	public class SetFocus : MonoBehaviour
	{
		// Token: 0x060000BB RID: 187 RVA: 0x00004C84 File Offset: 0x00002E84
		// Note: this type is marked as 'beforefieldinit'.
		static SetFocus()
		{
			Il2CppClassPointerStore<SetFocus>.NativeClassPtr = IL2CPP.GetIl2CppClass("console.dll", "dwd.core.ui.ugui", "SetFocus");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetFocus>.NativeClassPtr);
			SetFocus.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetFocus>.NativeClassPtr, "Target");
			SetFocus.NativeMethodInfoPtr_Focus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetFocus>.NativeClassPtr, 100663358);
			SetFocus.NativeMethodInfoPtr_UnFocus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetFocus>.NativeClassPtr, 100663359);
			SetFocus.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetFocus>.NativeClassPtr, 100663360);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00004D04 File Offset: 0x00002F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255955, XrefRangeEnd = 1255976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Focus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetFocus.NativeMethodInfoPtr_Focus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00004D38 File Offset: 0x00002F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255976, XrefRangeEnd = 1255988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnFocus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetFocus.NativeMethodInfoPtr_UnFocus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00004D6C File Offset: 0x00002F6C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetFocus()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetFocus>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetFocus.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002747 File Offset: 0x00000947
		public SetFocus(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00004DA8 File Offset: 0x00002FA8
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x00002750 File Offset: 0x00000950
		public unsafe GameObject Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetFocus.NativeFieldInfoPtr_Target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetFocus.NativeFieldInfoPtr_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr_Target;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_Focus_Public_Void_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_UnFocus_Public_Void_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

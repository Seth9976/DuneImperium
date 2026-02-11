using System;
using dwd.core.input.context;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace zen.src.menus
{
	// Token: 0x02000054 RID: 84
	public class ConnectivityIcon : MonoBehaviour
	{
		// Token: 0x0600045E RID: 1118 RVA: 0x0001DB24 File Offset: 0x0001BD24
		// Note: this type is marked as 'beforefieldinit'.
		static ConnectivityIcon()
		{
			Il2CppClassPointerStore<ConnectivityIcon>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.menus", "ConnectivityIcon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConnectivityIcon>.NativeClassPtr);
			ConnectivityIcon.NativeFieldInfoPtr_Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectivityIcon>.NativeClassPtr, "Animator");
			ConnectivityIcon.NativeFieldInfoPtr_GamepadInputBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectivityIcon>.NativeClassPtr, "GamepadInputBlocker");
			ConnectivityIcon.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectivityIcon>.NativeClassPtr, 100663855);
			ConnectivityIcon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectivityIcon>.NativeClassPtr, 100663856);
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0001DBA4 File Offset: 0x0001BDA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 985957, RefRangeEnd = 985958, XrefRangeStart = 985951, XrefRangeEnd = 985957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newVal;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectivityIcon.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0001DBE4 File Offset: 0x0001BDE4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConnectivityIcon()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConnectivityIcon>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectivityIcon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00003FF0 File Offset: 0x000021F0
		public ConnectivityIcon(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x0001DC20 File Offset: 0x0001BE20
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x00003FF9 File Offset: 0x000021F9
		public unsafe Animator Animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectivityIcon.NativeFieldInfoPtr_Animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectivityIcon.NativeFieldInfoPtr_Animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x0001DC50 File Offset: 0x0001BE50
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x00004018 File Offset: 0x00002218
		public unsafe CreateHeirarchicalInputContext GamepadInputBlocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectivityIcon.NativeFieldInfoPtr_GamepadInputBlocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreateHeirarchicalInputContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectivityIcon.NativeFieldInfoPtr_GamepadInputBlocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeFieldInfoPtr_Animator;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeFieldInfoPtr_GamepadInputBlocker;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

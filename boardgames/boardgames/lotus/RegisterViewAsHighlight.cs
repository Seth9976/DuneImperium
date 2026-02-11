using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace lotus
{
	// Token: 0x020000C6 RID: 198
	public class RegisterViewAsHighlight : MonoBehaviour
	{
		// Token: 0x060009CC RID: 2508 RVA: 0x00030648 File Offset: 0x0002E848
		// Note: this type is marked as 'beforefieldinit'.
		static RegisterViewAsHighlight()
		{
			Il2CppClassPointerStore<RegisterViewAsHighlight>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "RegisterViewAsHighlight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterViewAsHighlight>.NativeClassPtr);
			RegisterViewAsHighlight.NativeFieldInfoPtr_viewKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterViewAsHighlight>.NativeClassPtr, "viewKey");
			RegisterViewAsHighlight.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterViewAsHighlight>.NativeClassPtr, 100664894);
			RegisterViewAsHighlight.NativeMethodInfoPtr_onSpawn_Private_Void_PoolableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterViewAsHighlight>.NativeClassPtr, 100664895);
			RegisterViewAsHighlight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterViewAsHighlight>.NativeClassPtr, 100664896);
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x000306C8 File Offset: 0x0002E8C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993271, XrefRangeEnd = 993284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterViewAsHighlight.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x000306FC File Offset: 0x0002E8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993284, XrefRangeEnd = 993298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onSpawn(PoolableItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterViewAsHighlight.NativeMethodInfoPtr_onSpawn_Private_Void_PoolableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00030740 File Offset: 0x0002E940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993298, XrefRangeEnd = 993302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegisterViewAsHighlight()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterViewAsHighlight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterViewAsHighlight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x0000670D File Offset: 0x0000490D
		public RegisterViewAsHighlight(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x0003077C File Offset: 0x0002E97C
		// (set) Token: 0x060009D2 RID: 2514 RVA: 0x00006716 File Offset: 0x00004916
		public unsafe string viewKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterViewAsHighlight.NativeFieldInfoPtr_viewKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterViewAsHighlight.NativeFieldInfoPtr_viewKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeFieldInfoPtr_viewKey;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeMethodInfoPtr_onSpawn_Private_Void_PoolableItem_0;

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

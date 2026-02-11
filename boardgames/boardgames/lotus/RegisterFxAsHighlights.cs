using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace lotus
{
	// Token: 0x020000C5 RID: 197
	public class RegisterFxAsHighlights : MonoBehaviour
	{
		// Token: 0x060009C5 RID: 2501 RVA: 0x000304D8 File Offset: 0x0002E6D8
		// Note: this type is marked as 'beforefieldinit'.
		static RegisterFxAsHighlights()
		{
			Il2CppClassPointerStore<RegisterFxAsHighlights>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "RegisterFxAsHighlights");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterFxAsHighlights>.NativeClassPtr);
			RegisterFxAsHighlights.NativeFieldInfoPtr_highlights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterFxAsHighlights>.NativeClassPtr, "highlights");
			RegisterFxAsHighlights.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterFxAsHighlights>.NativeClassPtr, 100664891);
			RegisterFxAsHighlights.NativeMethodInfoPtr_onSpawn_Protected_Virtual_New_Void_PoolableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterFxAsHighlights>.NativeClassPtr, 100664892);
			RegisterFxAsHighlights.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterFxAsHighlights>.NativeClassPtr, 100664893);
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00030558 File Offset: 0x0002E758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993241, XrefRangeEnd = 993263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterFxAsHighlights.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x0003058C File Offset: 0x0002E78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993263, XrefRangeEnd = 993271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void onSpawn(PoolableItem pi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegisterFxAsHighlights.NativeMethodInfoPtr_onSpawn_Protected_Virtual_New_Void_PoolableItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x000305DC File Offset: 0x0002E7DC
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegisterFxAsHighlights()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterFxAsHighlights>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterFxAsHighlights.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x000066E5 File Offset: 0x000048E5
		public RegisterFxAsHighlights(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x00030618 File Offset: 0x0002E818
		// (set) Token: 0x060009CB RID: 2507 RVA: 0x000066EE File Offset: 0x000048EE
		public unsafe FXHelper highlights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterFxAsHighlights.NativeFieldInfoPtr_highlights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FXHelper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterFxAsHighlights.NativeFieldInfoPtr_highlights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeFieldInfoPtr_highlights;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000608 RID: 1544
		private static readonly IntPtr NativeMethodInfoPtr_onSpawn_Protected_Virtual_New_Void_PoolableItem_0;

		// Token: 0x04000609 RID: 1545
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

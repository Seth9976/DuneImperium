using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001F7 RID: 503
	public class WormHasActiveChildrenValidator : MonoBehaviour
	{
		// Token: 0x0600163E RID: 5694 RVA: 0x0005BA98 File Offset: 0x00059C98
		// Note: this type is marked as 'beforefieldinit'.
		static WormHasActiveChildrenValidator()
		{
			Il2CppClassPointerStore<WormHasActiveChildrenValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormHasActiveChildrenValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormHasActiveChildrenValidator>.NativeClassPtr);
			WormHasActiveChildrenValidator.NativeFieldInfoPtr_transformToWatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHasActiveChildrenValidator>.NativeClassPtr, "transformToWatch");
			WormHasActiveChildrenValidator.NativeFieldInfoPtr__Valid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHasActiveChildrenValidator>.NativeClassPtr, "<Valid>k__BackingField");
			WormHasActiveChildrenValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHasActiveChildrenValidator>.NativeClassPtr, 100666379);
			WormHasActiveChildrenValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHasActiveChildrenValidator>.NativeClassPtr, 100666380);
			WormHasActiveChildrenValidator.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHasActiveChildrenValidator>.NativeClassPtr, 100666381);
			WormHasActiveChildrenValidator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHasActiveChildrenValidator>.NativeClassPtr, 100666382);
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x0600163F RID: 5695 RVA: 0x0005BB40 File Offset: 0x00059D40
		// (set) Token: 0x06001640 RID: 5696 RVA: 0x0005BB7C File Offset: 0x00059D7C
		public unsafe virtual bool Valid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHasActiveChildrenValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 287297, RefRangeEnd = 287316, XrefRangeStart = 287297, XrefRangeEnd = 287316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHasActiveChildrenValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x0005BBBC File Offset: 0x00059DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716256, XrefRangeEnd = 716261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHasActiveChildrenValidator.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x0005BBF0 File Offset: 0x00059DF0
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormHasActiveChildrenValidator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormHasActiveChildrenValidator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHasActiveChildrenValidator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x0000D68B File Offset: 0x0000B88B
		public WormHasActiveChildrenValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06001644 RID: 5700 RVA: 0x0005BC2C File Offset: 0x00059E2C
		// (set) Token: 0x06001645 RID: 5701 RVA: 0x0000D694 File Offset: 0x0000B894
		public unsafe Transform transformToWatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHasActiveChildrenValidator.NativeFieldInfoPtr_transformToWatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHasActiveChildrenValidator.NativeFieldInfoPtr_transformToWatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06001646 RID: 5702 RVA: 0x0005BC5C File Offset: 0x00059E5C
		// (set) Token: 0x06001647 RID: 5703 RVA: 0x0000D6B3 File Offset: 0x0000B8B3
		public unsafe bool _Valid_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHasActiveChildrenValidator.NativeFieldInfoPtr__Valid_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHasActiveChildrenValidator.NativeFieldInfoPtr__Valid_k__BackingField)) = value;
			}
		}

		// Token: 0x04000CE8 RID: 3304
		private static readonly IntPtr NativeFieldInfoPtr_transformToWatch;

		// Token: 0x04000CE9 RID: 3305
		private static readonly IntPtr NativeFieldInfoPtr__Valid_k__BackingField;

		// Token: 0x04000CEA RID: 3306
		private static readonly IntPtr NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000CEB RID: 3307
		private static readonly IntPtr NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000CEC RID: 3308
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000CED RID: 3309
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

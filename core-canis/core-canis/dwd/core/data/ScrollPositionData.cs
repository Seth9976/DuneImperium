using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.data
{
	// Token: 0x020001CA RID: 458
	public class ScrollPositionData : DataComponent
	{
		// Token: 0x06001966 RID: 6502 RVA: 0x00078C28 File Offset: 0x00076E28
		// Note: this type is marked as 'beforefieldinit'.
		static ScrollPositionData()
		{
			Il2CppClassPointerStore<ScrollPositionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data", "ScrollPositionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollPositionData>.NativeClassPtr);
			ScrollPositionData.NativeFieldInfoPtr_shouldRestoreScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollPositionData>.NativeClassPtr, "shouldRestoreScroll");
			ScrollPositionData.NativeFieldInfoPtr__ShouldRestoreScroll_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollPositionData>.NativeClassPtr, "<ShouldRestoreScroll>k__BackingField");
			ScrollPositionData.NativeMethodInfoPtr_get_ShouldRestoreScroll_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollPositionData>.NativeClassPtr, 100667333);
			ScrollPositionData.NativeMethodInfoPtr_set_ShouldRestoreScroll_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollPositionData>.NativeClassPtr, 100667334);
			ScrollPositionData.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollPositionData>.NativeClassPtr, 100667335);
			ScrollPositionData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollPositionData>.NativeClassPtr, 100667336);
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06001967 RID: 6503 RVA: 0x00078CD0 File Offset: 0x00076ED0
		// (set) Token: 0x06001968 RID: 6504 RVA: 0x00078D0C File Offset: 0x00076F0C
		public unsafe bool ShouldRestoreScroll
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollPositionData.NativeMethodInfoPtr_get_ShouldRestoreScroll_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollPositionData.NativeMethodInfoPtr_set_ShouldRestoreScroll_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x00078D4C File Offset: 0x00076F4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 881326, RefRangeEnd = 881327, XrefRangeStart = 881324, XrefRangeEnd = 881326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScrollPositionData(bool restore)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollPositionData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref restore;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollPositionData.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x00078D94 File Offset: 0x00076F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 881327, XrefRangeEnd = 881333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollPositionData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x0000B24F File Offset: 0x0000944F
		public ScrollPositionData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x0600196C RID: 6508 RVA: 0x00078DD8 File Offset: 0x00076FD8
		// (set) Token: 0x0600196D RID: 6509 RVA: 0x0000B258 File Offset: 0x00009458
		public unsafe bool shouldRestoreScroll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollPositionData.NativeFieldInfoPtr_shouldRestoreScroll);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollPositionData.NativeFieldInfoPtr_shouldRestoreScroll)) = value;
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x0600196E RID: 6510 RVA: 0x00078E00 File Offset: 0x00077000
		// (set) Token: 0x0600196F RID: 6511 RVA: 0x0000B273 File Offset: 0x00009473
		public unsafe bool _ShouldRestoreScroll_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollPositionData.NativeFieldInfoPtr__ShouldRestoreScroll_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollPositionData.NativeFieldInfoPtr__ShouldRestoreScroll_k__BackingField)) = value;
			}
		}

		// Token: 0x040011D9 RID: 4569
		private static readonly IntPtr NativeFieldInfoPtr_shouldRestoreScroll;

		// Token: 0x040011DA RID: 4570
		private static readonly IntPtr NativeFieldInfoPtr__ShouldRestoreScroll_k__BackingField;

		// Token: 0x040011DB RID: 4571
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldRestoreScroll_Public_get_Boolean_0;

		// Token: 0x040011DC RID: 4572
		private static readonly IntPtr NativeMethodInfoPtr_set_ShouldRestoreScroll_Private_set_Void_Boolean_0;

		// Token: 0x040011DD RID: 4573
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x040011DE RID: 4574
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}

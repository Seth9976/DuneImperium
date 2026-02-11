using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace zen.src.match.monobehaviours
{
	// Token: 0x02000076 RID: 118
	public class ToggleColor : MonoBehaviour
	{
		// Token: 0x06000626 RID: 1574 RVA: 0x00023F8C File Offset: 0x0002218C
		// Note: this type is marked as 'beforefieldinit'.
		static ToggleColor()
		{
			Il2CppClassPointerStore<ToggleColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.match.monobehaviours", "ToggleColor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleColor>.NativeClassPtr);
			ToggleColor.NativeFieldInfoPtr_ActiveColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleColor>.NativeClassPtr, "ActiveColor");
			ToggleColor.NativeFieldInfoPtr_InactiveColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleColor>.NativeClassPtr, "InactiveColor");
			ToggleColor.NativeFieldInfoPtr_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleColor>.NativeClassPtr, "toggle");
			ToggleColor.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleColor>.NativeClassPtr, 100664264);
			ToggleColor.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleColor>.NativeClassPtr, 100664265);
			ToggleColor.NativeMethodInfoPtr_UpdateColor_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleColor>.NativeClassPtr, 100664266);
			ToggleColor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleColor>.NativeClassPtr, 100664267);
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00024048 File Offset: 0x00022248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988443, XrefRangeEnd = 988458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleColor.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x0002407C File Offset: 0x0002227C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988458, XrefRangeEnd = 988468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleColor.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x000240B0 File Offset: 0x000222B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988468, XrefRangeEnd = 988470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateColor(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref active;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleColor.NativeMethodInfoPtr_UpdateColor_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x000240F0 File Offset: 0x000222F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988470, XrefRangeEnd = 988471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToggleColor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleColor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleColor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00004CC7 File Offset: 0x00002EC7
		public ToggleColor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x0002412C File Offset: 0x0002232C
		// (set) Token: 0x0600062D RID: 1581 RVA: 0x00004CD0 File Offset: 0x00002ED0
		public unsafe Color ActiveColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleColor.NativeFieldInfoPtr_ActiveColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleColor.NativeFieldInfoPtr_ActiveColor)) = value;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x00024154 File Offset: 0x00022354
		// (set) Token: 0x0600062F RID: 1583 RVA: 0x00004CEB File Offset: 0x00002EEB
		public unsafe Color InactiveColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleColor.NativeFieldInfoPtr_InactiveColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleColor.NativeFieldInfoPtr_InactiveColor)) = value;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x0002417C File Offset: 0x0002237C
		// (set) Token: 0x06000631 RID: 1585 RVA: 0x00004D06 File Offset: 0x00002F06
		public unsafe Toggle toggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleColor.NativeFieldInfoPtr_toggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleColor.NativeFieldInfoPtr_toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeFieldInfoPtr_ActiveColor;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeFieldInfoPtr_InactiveColor;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeFieldInfoPtr_toggle;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeMethodInfoPtr_UpdateColor_Private_Void_Boolean_0;

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

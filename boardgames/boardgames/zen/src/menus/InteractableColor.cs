using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace zen.src.menus
{
	// Token: 0x0200005B RID: 91
	public class InteractableColor : MonoBehaviour
	{
		// Token: 0x060004B4 RID: 1204 RVA: 0x0001ED60 File Offset: 0x0001CF60
		// Note: this type is marked as 'beforefieldinit'.
		static InteractableColor()
		{
			Il2CppClassPointerStore<InteractableColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.menus", "InteractableColor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractableColor>.NativeClassPtr);
			InteractableColor.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableColor>.NativeClassPtr, "button");
			InteractableColor.NativeFieldInfoPtr_interactableColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableColor>.NativeClassPtr, "interactableColor");
			InteractableColor.NativeFieldInfoPtr_uninteractableColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableColor>.NativeClassPtr, "uninteractableColor");
			InteractableColor.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableColor>.NativeClassPtr, "image");
			InteractableColor.NativeFieldInfoPtr_cachedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableColor>.NativeClassPtr, "cachedValue");
			InteractableColor.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableColor>.NativeClassPtr, 100663943);
			InteractableColor.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableColor>.NativeClassPtr, 100663944);
			InteractableColor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableColor>.NativeClassPtr, 100663945);
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0001EE30 File Offset: 0x0001D030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986311, XrefRangeEnd = 986315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableColor.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x0001EE64 File Offset: 0x0001D064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986315, XrefRangeEnd = 986316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableColor.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x0001EE98 File Offset: 0x0001D098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986316, XrefRangeEnd = 986317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InteractableColor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractableColor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableColor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00004287 File Offset: 0x00002487
		public InteractableColor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x0001EED4 File Offset: 0x0001D0D4
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x00004290 File Offset: 0x00002490
		public unsafe Button button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableColor.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableColor.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x0001EF04 File Offset: 0x0001D104
		// (set) Token: 0x060004BC RID: 1212 RVA: 0x000042AF File Offset: 0x000024AF
		public unsafe Color interactableColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableColor.NativeFieldInfoPtr_interactableColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableColor.NativeFieldInfoPtr_interactableColor)) = value;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x0001EF2C File Offset: 0x0001D12C
		// (set) Token: 0x060004BE RID: 1214 RVA: 0x000042CA File Offset: 0x000024CA
		public unsafe Color uninteractableColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableColor.NativeFieldInfoPtr_uninteractableColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableColor.NativeFieldInfoPtr_uninteractableColor)) = value;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x0001EF54 File Offset: 0x0001D154
		// (set) Token: 0x060004C0 RID: 1216 RVA: 0x000042E5 File Offset: 0x000024E5
		public unsafe Image image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableColor.NativeFieldInfoPtr_image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableColor.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x0001EF84 File Offset: 0x0001D184
		// (set) Token: 0x060004C2 RID: 1218 RVA: 0x00004304 File Offset: 0x00002504
		public unsafe bool cachedValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableColor.NativeFieldInfoPtr_cachedValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableColor.NativeFieldInfoPtr_cachedValue)) = value;
			}
		}

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeFieldInfoPtr_interactableColor;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeFieldInfoPtr_uninteractableColor;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeFieldInfoPtr_image;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeFieldInfoPtr_cachedValue;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

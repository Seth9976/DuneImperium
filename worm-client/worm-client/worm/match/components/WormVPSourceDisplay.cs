using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x0200021E RID: 542
	public class WormVPSourceDisplay : MonoBehaviour
	{
		// Token: 0x060017C3 RID: 6083 RVA: 0x00060204 File Offset: 0x0005E404
		// Note: this type is marked as 'beforefieldinit'.
		static WormVPSourceDisplay()
		{
			Il2CppClassPointerStore<WormVPSourceDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormVPSourceDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormVPSourceDisplay>.NativeClassPtr);
			WormVPSourceDisplay.NativeFieldInfoPtr_sourceText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVPSourceDisplay>.NativeClassPtr, "sourceText");
			WormVPSourceDisplay.NativeFieldInfoPtr_countText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVPSourceDisplay>.NativeClassPtr, "countText");
			WormVPSourceDisplay.NativeFieldInfoPtr_vpIconString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVPSourceDisplay>.NativeClassPtr, "vpIconString");
			WormVPSourceDisplay.NativeMethodInfoPtr_Initialize_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVPSourceDisplay>.NativeClassPtr, 100666592);
			WormVPSourceDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVPSourceDisplay>.NativeClassPtr, 100666593);
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x00060298 File Offset: 0x0005E498
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 717727, RefRangeEnd = 717728, XrefRangeStart = 717707, XrefRangeEnd = 717727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(string source, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVPSourceDisplay.NativeMethodInfoPtr_Initialize_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x000602E8 File Offset: 0x0005E4E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717728, XrefRangeEnd = 717732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormVPSourceDisplay()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormVPSourceDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVPSourceDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017C6 RID: 6086 RVA: 0x0000E2FA File Offset: 0x0000C4FA
		public WormVPSourceDisplay(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x060017C7 RID: 6087 RVA: 0x00060324 File Offset: 0x0005E524
		// (set) Token: 0x060017C8 RID: 6088 RVA: 0x0000E303 File Offset: 0x0000C503
		public unsafe TMP_Text sourceText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVPSourceDisplay.NativeFieldInfoPtr_sourceText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVPSourceDisplay.NativeFieldInfoPtr_sourceText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x060017C9 RID: 6089 RVA: 0x00060354 File Offset: 0x0005E554
		// (set) Token: 0x060017CA RID: 6090 RVA: 0x0000E322 File Offset: 0x0000C522
		public unsafe TMP_Text countText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVPSourceDisplay.NativeFieldInfoPtr_countText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVPSourceDisplay.NativeFieldInfoPtr_countText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x060017CB RID: 6091 RVA: 0x00060384 File Offset: 0x0005E584
		// (set) Token: 0x060017CC RID: 6092 RVA: 0x0000E341 File Offset: 0x0000C541
		public unsafe string vpIconString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVPSourceDisplay.NativeFieldInfoPtr_vpIconString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVPSourceDisplay.NativeFieldInfoPtr_vpIconString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000DC4 RID: 3524
		private static readonly IntPtr NativeFieldInfoPtr_sourceText;

		// Token: 0x04000DC5 RID: 3525
		private static readonly IntPtr NativeFieldInfoPtr_countText;

		// Token: 0x04000DC6 RID: 3526
		private static readonly IntPtr NativeFieldInfoPtr_vpIconString;

		// Token: 0x04000DC7 RID: 3527
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_String_Int32_0;

		// Token: 0x04000DC8 RID: 3528
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

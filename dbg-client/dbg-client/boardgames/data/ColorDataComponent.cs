using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.data
{
	// Token: 0x02000182 RID: 386
	public class ColorDataComponent : VersionedDataComponent
	{
		// Token: 0x060010E0 RID: 4320 RVA: 0x00052D64 File Offset: 0x00050F64
		// Note: this type is marked as 'beforefieldinit'.
		static ColorDataComponent()
		{
			Il2CppClassPointerStore<ColorDataComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.data", "ColorDataComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorDataComponent>.NativeClassPtr);
			ColorDataComponent.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorDataComponent>.NativeClassPtr, "color");
			ColorDataComponent.NativeMethodInfoPtr_get_Color_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorDataComponent>.NativeClassPtr, 100665657);
			ColorDataComponent.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorDataComponent>.NativeClassPtr, 100665658);
			ColorDataComponent.NativeMethodInfoPtr_UpdateColor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorDataComponent>.NativeClassPtr, 100665659);
			ColorDataComponent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorDataComponent>.NativeClassPtr, 100665660);
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x060010E1 RID: 4321 RVA: 0x00052DF8 File Offset: 0x00050FF8
		public unsafe string Color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorDataComponent.NativeMethodInfoPtr_get_Color_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x00052E30 File Offset: 0x00051030
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 504779, RefRangeEnd = 504807, XrefRangeStart = 504779, XrefRangeEnd = 504807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorDataComponent(string color)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorDataComponent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorDataComponent.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x00052E7C File Offset: 0x0005107C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 514283, RefRangeEnd = 514296, XrefRangeStart = 514283, XrefRangeEnd = 514296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateColor(string color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorDataComponent.NativeMethodInfoPtr_UpdateColor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x00052EC0 File Offset: 0x000510C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514333, XrefRangeEnd = 514336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorDataComponent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x0000A23F File Offset: 0x0000843F
		public ColorDataComponent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x060010E6 RID: 4326 RVA: 0x00052F04 File Offset: 0x00051104
		// (set) Token: 0x060010E7 RID: 4327 RVA: 0x0000A248 File Offset: 0x00008448
		public unsafe string color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorDataComponent.NativeFieldInfoPtr_color);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorDataComponent.NativeFieldInfoPtr_color), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000A44 RID: 2628
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x04000A45 RID: 2629
		private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_String_0;

		// Token: 0x04000A46 RID: 2630
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000A47 RID: 2631
		private static readonly IntPtr NativeMethodInfoPtr_UpdateColor_Public_Void_String_0;

		// Token: 0x04000A48 RID: 2632
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001FD RID: 509
	public sealed class Image : ValueType
	{
		// Token: 0x0600196F RID: 6511 RVA: 0x0007B380 File Offset: 0x00079580
		// Note: this type is marked as 'beforefieldinit'.
		static Image()
		{
			Il2CppClassPointerStore<Image>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "Image");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Image>.NativeClassPtr);
			Image.NativeFieldInfoPtr_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "Width");
			Image.NativeFieldInfoPtr_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "Height");
			Image.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "Data");
			Image.NativeMethodInfoPtr_GetPixel_Public_Color_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100667929);
			Image.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100667930);
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x0007B414 File Offset: 0x00079614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951844, XrefRangeEnd = 951845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color GetPixel(int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_GetPixel_Public_Color_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x0007B470 File Offset: 0x00079670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951845, XrefRangeEnd = 951856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x00008429 File Offset: 0x00006629
		public Image(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001973 RID: 6515 RVA: 0x00008432 File Offset: 0x00006632
		public Image()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Image>.NativeClassPtr))
		{
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06001974 RID: 6516 RVA: 0x0007B4AC File Offset: 0x000796AC
		// (set) Token: 0x06001975 RID: 6517 RVA: 0x00008444 File Offset: 0x00006644
		public unsafe uint Width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_Width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_Width)) = value;
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06001976 RID: 6518 RVA: 0x0007B4D4 File Offset: 0x000796D4
		// (set) Token: 0x06001977 RID: 6519 RVA: 0x0000845F File Offset: 0x0000665F
		public unsafe uint Height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_Height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_Height)) = value;
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06001978 RID: 6520 RVA: 0x0007B4FC File Offset: 0x000796FC
		// (set) Token: 0x06001979 RID: 6521 RVA: 0x0000847A File Offset: 0x0000667A
		public unsafe Il2CppStructArray<byte> Data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_Data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_Data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001EA7 RID: 7847
		private static readonly IntPtr NativeFieldInfoPtr_Width;

		// Token: 0x04001EA8 RID: 7848
		private static readonly IntPtr NativeFieldInfoPtr_Height;

		// Token: 0x04001EA9 RID: 7849
		private static readonly IntPtr NativeFieldInfoPtr_Data;

		// Token: 0x04001EAA RID: 7850
		private static readonly IntPtr NativeMethodInfoPtr_GetPixel_Public_Color_Int32_Int32_0;

		// Token: 0x04001EAB RID: 7851
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}

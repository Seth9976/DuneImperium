using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;
using UnityEngine;

namespace Unity.Profiling
{
	// Token: 0x0200001F RID: 31
	public sealed class DebugScreenCapture : ValueType
	{
		// Token: 0x060000F8 RID: 248 RVA: 0x000190C0 File Offset: 0x000172C0
		// Note: this type is marked as 'beforefieldinit'.
		static DebugScreenCapture()
		{
			Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling", "DebugScreenCapture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr);
			DebugScreenCapture.NativeFieldInfoPtr__RawImageDataReference_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, "<RawImageDataReference>k__BackingField");
			DebugScreenCapture.NativeFieldInfoPtr__ImageFormat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, "<ImageFormat>k__BackingField");
			DebugScreenCapture.NativeFieldInfoPtr__Width_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, "<Width>k__BackingField");
			DebugScreenCapture.NativeFieldInfoPtr__Height_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, "<Height>k__BackingField");
			DebugScreenCapture.NativeMethodInfoPtr_set_RawImageDataReference_Public_set_Void_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, 100663396);
			DebugScreenCapture.NativeMethodInfoPtr_set_ImageFormat_Public_set_Void_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, 100663397);
			DebugScreenCapture.NativeMethodInfoPtr_set_Width_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, 100663398);
			DebugScreenCapture.NativeMethodInfoPtr_set_Height_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, 100663399);
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00002804 File Offset: 0x00000A04
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x00019190 File Offset: 0x00017390
		public unsafe Unity.Collections.NativeArray<byte> RawImageDataReference
		{
			get
			{
				return this._RawImageDataReference_k__BackingField;
			}
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 557179, RefRangeEnd = 557192, XrefRangeStart = 557179, XrefRangeEnd = 557192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugScreenCapture.NativeMethodInfoPtr_set_RawImageDataReference_Public_set_Void_NativeArray_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000108 RID: 264 RVA: 0x0000280C File Offset: 0x00000A0C
		// (set) Token: 0x060000FA RID: 250 RVA: 0x000191DC File Offset: 0x000173DC
		public unsafe global::UnityEngine.TextureFormat ImageFormat
		{
			get
			{
				return this._ImageFormat_k__BackingField;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugScreenCapture.NativeMethodInfoPtr_set_ImageFormat_Public_set_Void_TextureFormat_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00002814 File Offset: 0x00000A14
		// (set) Token: 0x060000FB RID: 251 RVA: 0x00019220 File Offset: 0x00017420
		public unsafe int Width
		{
			get
			{
				return this._Width_k__BackingField;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 310312, RefRangeEnd = 310318, XrefRangeStart = 310312, XrefRangeEnd = 310318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugScreenCapture.NativeMethodInfoPtr_set_Width_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600010A RID: 266 RVA: 0x0000281C File Offset: 0x00000A1C
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00019264 File Offset: 0x00017464
		public unsafe int Height
		{
			get
			{
				return this._Height_k__BackingField;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 311421, RefRangeEnd = 311423, XrefRangeStart = 311421, XrefRangeEnd = 311423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugScreenCapture.NativeMethodInfoPtr_set_Height_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000276A File Offset: 0x0000096A
		public DebugScreenCapture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002773 File Offset: 0x00000973
		public DebugScreenCapture()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr))
		{
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000FF RID: 255 RVA: 0x000192A8 File Offset: 0x000174A8
		// (set) Token: 0x06000100 RID: 256 RVA: 0x00002785 File Offset: 0x00000985
		public Unity.Collections.NativeArray<byte> _RawImageDataReference_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__RawImageDataReference_k__BackingField);
				return new Unity.Collections.NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<byte>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__RawImageDataReference_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<byte>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000101 RID: 257 RVA: 0x000192D8 File Offset: 0x000174D8
		// (set) Token: 0x06000102 RID: 258 RVA: 0x000027B3 File Offset: 0x000009B3
		public unsafe global::UnityEngine.TextureFormat _ImageFormat_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__ImageFormat_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__ImageFormat_k__BackingField)) = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00019300 File Offset: 0x00017500
		// (set) Token: 0x06000104 RID: 260 RVA: 0x000027CE File Offset: 0x000009CE
		public unsafe int _Width_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__Width_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__Width_k__BackingField)) = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00019328 File Offset: 0x00017528
		// (set) Token: 0x06000106 RID: 262 RVA: 0x000027E9 File Offset: 0x000009E9
		public unsafe int _Height_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__Height_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__Height_k__BackingField)) = value;
			}
		}

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeFieldInfoPtr__RawImageDataReference_k__BackingField;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeFieldInfoPtr__ImageFormat_k__BackingField;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeFieldInfoPtr__Width_k__BackingField;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeFieldInfoPtr__Height_k__BackingField;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_set_RawImageDataReference_Public_set_Void_NativeArray_1_Byte_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_set_ImageFormat_Public_set_Void_TextureFormat_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_set_Width_Public_set_Void_Int32_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_set_Height_Public_set_Void_Int32_0;
	}
}

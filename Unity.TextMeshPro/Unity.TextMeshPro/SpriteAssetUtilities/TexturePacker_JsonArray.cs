using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace TMPro.SpriteAssetUtilities
{
	// Token: 0x02000075 RID: 117
	public class TexturePacker_JsonArray : global::Il2CppSystem.Object
	{
		// Token: 0x06000E7C RID: 3708 RVA: 0x00008CC6 File Offset: 0x00006EC6
		// Note: this type is marked as 'beforefieldinit'.
		static TexturePacker_JsonArray()
		{
			Il2CppClassPointerStore<TexturePacker_JsonArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro.SpriteAssetUtilities", "TexturePacker_JsonArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TexturePacker_JsonArray>.NativeClassPtr);
			TexturePacker_JsonArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TexturePacker_JsonArray>.NativeClassPtr, 100664913);
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x0003AB54 File Offset: 0x00038D54
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TexturePacker_JsonArray()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TexturePacker_JsonArray>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TexturePacker_JsonArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00008CFF File Offset: 0x00006EFF
		public TexturePacker_JsonArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B7C RID: 2940
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000B4 RID: 180
		[Serializable]
		[StructLayout(2)]
		public struct SpriteFrame
		{
			// Token: 0x0600102F RID: 4143 RVA: 0x0003F8B0 File Offset: 0x0003DAB0
			// Note: this type is marked as 'beforefieldinit'.
			static SpriteFrame()
			{
				Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteFrame>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TexturePacker_JsonArray>.NativeClassPtr, "SpriteFrame");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteFrame>.NativeClassPtr);
				TexturePacker_JsonArray.SpriteFrame.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteFrame>.NativeClassPtr, "x");
				TexturePacker_JsonArray.SpriteFrame.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteFrame>.NativeClassPtr, "y");
				TexturePacker_JsonArray.SpriteFrame.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteFrame>.NativeClassPtr, "w");
				TexturePacker_JsonArray.SpriteFrame.NativeFieldInfoPtr_h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteFrame>.NativeClassPtr, "h");
				TexturePacker_JsonArray.SpriteFrame.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteFrame>.NativeClassPtr, 100664914);
			}

			// Token: 0x06001030 RID: 4144 RVA: 0x0003F940 File Offset: 0x0003DB40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050607, XrefRangeEnd = 1050638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TexturePacker_JsonArray.SpriteFrame.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06001031 RID: 4145 RVA: 0x00009BB4 File Offset: 0x00007DB4
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteFrame>.NativeClassPtr, ref this));
			}

			// Token: 0x04000CAA RID: 3242
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04000CAB RID: 3243
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x04000CAC RID: 3244
			private static readonly IntPtr NativeFieldInfoPtr_w;

			// Token: 0x04000CAD RID: 3245
			private static readonly IntPtr NativeFieldInfoPtr_h;

			// Token: 0x04000CAE RID: 3246
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x04000CAF RID: 3247
			[FieldOffset(0)]
			public float x;

			// Token: 0x04000CB0 RID: 3248
			[FieldOffset(4)]
			public float y;

			// Token: 0x04000CB1 RID: 3249
			[FieldOffset(8)]
			public float w;

			// Token: 0x04000CB2 RID: 3250
			[FieldOffset(12)]
			public float h;
		}

		// Token: 0x020000B5 RID: 181
		[Serializable]
		[StructLayout(2)]
		public struct SpriteSize
		{
			// Token: 0x06001032 RID: 4146 RVA: 0x0003F96C File Offset: 0x0003DB6C
			// Note: this type is marked as 'beforefieldinit'.
			static SpriteSize()
			{
				Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteSize>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TexturePacker_JsonArray>.NativeClassPtr, "SpriteSize");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteSize>.NativeClassPtr);
				TexturePacker_JsonArray.SpriteSize.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteSize>.NativeClassPtr, "w");
				TexturePacker_JsonArray.SpriteSize.NativeFieldInfoPtr_h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteSize>.NativeClassPtr, "h");
				TexturePacker_JsonArray.SpriteSize.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteSize>.NativeClassPtr, 100664915);
			}

			// Token: 0x06001033 RID: 4147 RVA: 0x0003F9D4 File Offset: 0x0003DBD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050638, XrefRangeEnd = 1050648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TexturePacker_JsonArray.SpriteSize.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06001034 RID: 4148 RVA: 0x00009BC6 File Offset: 0x00007DC6
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteSize>.NativeClassPtr, ref this));
			}

			// Token: 0x04000CB3 RID: 3251
			private static readonly IntPtr NativeFieldInfoPtr_w;

			// Token: 0x04000CB4 RID: 3252
			private static readonly IntPtr NativeFieldInfoPtr_h;

			// Token: 0x04000CB5 RID: 3253
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x04000CB6 RID: 3254
			[FieldOffset(0)]
			public float w;

			// Token: 0x04000CB7 RID: 3255
			[FieldOffset(4)]
			public float h;
		}

		// Token: 0x020000B6 RID: 182
		[Serializable]
		public sealed class Frame : ValueType
		{
			// Token: 0x06001035 RID: 4149 RVA: 0x0003FA00 File Offset: 0x0003DC00
			// Note: this type is marked as 'beforefieldinit'.
			static Frame()
			{
				Il2CppClassPointerStore<TexturePacker_JsonArray.Frame>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TexturePacker_JsonArray>.NativeClassPtr, "Frame");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TexturePacker_JsonArray.Frame>.NativeClassPtr);
				TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_filename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.Frame>.NativeClassPtr, "filename");
				TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.Frame>.NativeClassPtr, "frame");
				TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_rotated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.Frame>.NativeClassPtr, "rotated");
				TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_trimmed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.Frame>.NativeClassPtr, "trimmed");
				TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_spriteSourceSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.Frame>.NativeClassPtr, "spriteSourceSize");
				TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_sourceSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.Frame>.NativeClassPtr, "sourceSize");
				TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_pivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.Frame>.NativeClassPtr, "pivot");
			}

			// Token: 0x06001036 RID: 4150 RVA: 0x00009BD8 File Offset: 0x00007DD8
			public Frame(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001037 RID: 4151 RVA: 0x00009BE1 File Offset: 0x00007DE1
			public Frame()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TexturePacker_JsonArray.Frame>.NativeClassPtr))
			{
			}

			// Token: 0x170005DA RID: 1498
			// (get) Token: 0x06001038 RID: 4152 RVA: 0x0003FAB8 File Offset: 0x0003DCB8
			// (set) Token: 0x06001039 RID: 4153 RVA: 0x00009BF3 File Offset: 0x00007DF3
			public unsafe string filename
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_filename);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_filename), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170005DB RID: 1499
			// (get) Token: 0x0600103A RID: 4154 RVA: 0x0003FAE0 File Offset: 0x0003DCE0
			// (set) Token: 0x0600103B RID: 4155 RVA: 0x00009C12 File Offset: 0x00007E12
			public unsafe TexturePacker_JsonArray.SpriteFrame frame
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_frame);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_frame)) = value;
				}
			}

			// Token: 0x170005DC RID: 1500
			// (get) Token: 0x0600103C RID: 4156 RVA: 0x0003FB08 File Offset: 0x0003DD08
			// (set) Token: 0x0600103D RID: 4157 RVA: 0x00009C2D File Offset: 0x00007E2D
			public unsafe bool rotated
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_rotated);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_rotated)) = value;
				}
			}

			// Token: 0x170005DD RID: 1501
			// (get) Token: 0x0600103E RID: 4158 RVA: 0x0003FB30 File Offset: 0x0003DD30
			// (set) Token: 0x0600103F RID: 4159 RVA: 0x00009C48 File Offset: 0x00007E48
			public unsafe bool trimmed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_trimmed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_trimmed)) = value;
				}
			}

			// Token: 0x170005DE RID: 1502
			// (get) Token: 0x06001040 RID: 4160 RVA: 0x0003FB58 File Offset: 0x0003DD58
			// (set) Token: 0x06001041 RID: 4161 RVA: 0x00009C63 File Offset: 0x00007E63
			public unsafe TexturePacker_JsonArray.SpriteFrame spriteSourceSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_spriteSourceSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_spriteSourceSize)) = value;
				}
			}

			// Token: 0x170005DF RID: 1503
			// (get) Token: 0x06001042 RID: 4162 RVA: 0x0003FB80 File Offset: 0x0003DD80
			// (set) Token: 0x06001043 RID: 4163 RVA: 0x00009C7E File Offset: 0x00007E7E
			public unsafe TexturePacker_JsonArray.SpriteSize sourceSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_sourceSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_sourceSize)) = value;
				}
			}

			// Token: 0x170005E0 RID: 1504
			// (get) Token: 0x06001044 RID: 4164 RVA: 0x0003FBA8 File Offset: 0x0003DDA8
			// (set) Token: 0x06001045 RID: 4165 RVA: 0x00009C99 File Offset: 0x00007E99
			public unsafe Vector2 pivot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_pivot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Frame.NativeFieldInfoPtr_pivot)) = value;
				}
			}

			// Token: 0x04000CB8 RID: 3256
			private static readonly IntPtr NativeFieldInfoPtr_filename;

			// Token: 0x04000CB9 RID: 3257
			private static readonly IntPtr NativeFieldInfoPtr_frame;

			// Token: 0x04000CBA RID: 3258
			private static readonly IntPtr NativeFieldInfoPtr_rotated;

			// Token: 0x04000CBB RID: 3259
			private static readonly IntPtr NativeFieldInfoPtr_trimmed;

			// Token: 0x04000CBC RID: 3260
			private static readonly IntPtr NativeFieldInfoPtr_spriteSourceSize;

			// Token: 0x04000CBD RID: 3261
			private static readonly IntPtr NativeFieldInfoPtr_sourceSize;

			// Token: 0x04000CBE RID: 3262
			private static readonly IntPtr NativeFieldInfoPtr_pivot;
		}

		// Token: 0x020000B7 RID: 183
		[Serializable]
		public sealed class Meta : ValueType
		{
			// Token: 0x06001046 RID: 4166 RVA: 0x0003FBD0 File Offset: 0x0003DDD0
			// Note: this type is marked as 'beforefieldinit'.
			static Meta()
			{
				Il2CppClassPointerStore<TexturePacker_JsonArray.Meta>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TexturePacker_JsonArray>.NativeClassPtr, "Meta");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TexturePacker_JsonArray.Meta>.NativeClassPtr);
				TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_app = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.Meta>.NativeClassPtr, "app");
				TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.Meta>.NativeClassPtr, "version");
				TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.Meta>.NativeClassPtr, "image");
				TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.Meta>.NativeClassPtr, "format");
				TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.Meta>.NativeClassPtr, "size");
				TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.Meta>.NativeClassPtr, "scale");
				TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_smartupdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.Meta>.NativeClassPtr, "smartupdate");
			}

			// Token: 0x06001047 RID: 4167 RVA: 0x00009CB4 File Offset: 0x00007EB4
			public Meta(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001048 RID: 4168 RVA: 0x00009CBD File Offset: 0x00007EBD
			public Meta()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TexturePacker_JsonArray.Meta>.NativeClassPtr))
			{
			}

			// Token: 0x170005E1 RID: 1505
			// (get) Token: 0x06001049 RID: 4169 RVA: 0x0003FC88 File Offset: 0x0003DE88
			// (set) Token: 0x0600104A RID: 4170 RVA: 0x00009CCF File Offset: 0x00007ECF
			public unsafe string app
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_app);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_app), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170005E2 RID: 1506
			// (get) Token: 0x0600104B RID: 4171 RVA: 0x0003FCB0 File Offset: 0x0003DEB0
			// (set) Token: 0x0600104C RID: 4172 RVA: 0x00009CEE File Offset: 0x00007EEE
			public unsafe string version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_version);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_version), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170005E3 RID: 1507
			// (get) Token: 0x0600104D RID: 4173 RVA: 0x0003FCD8 File Offset: 0x0003DED8
			// (set) Token: 0x0600104E RID: 4174 RVA: 0x00009D0D File Offset: 0x00007F0D
			public unsafe string image
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_image);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_image), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170005E4 RID: 1508
			// (get) Token: 0x0600104F RID: 4175 RVA: 0x0003FD00 File Offset: 0x0003DF00
			// (set) Token: 0x06001050 RID: 4176 RVA: 0x00009D2C File Offset: 0x00007F2C
			public unsafe string format
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_format);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_format), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170005E5 RID: 1509
			// (get) Token: 0x06001051 RID: 4177 RVA: 0x0003FD28 File Offset: 0x0003DF28
			// (set) Token: 0x06001052 RID: 4178 RVA: 0x00009D4B File Offset: 0x00007F4B
			public unsafe TexturePacker_JsonArray.SpriteSize size
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_size);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_size)) = value;
				}
			}

			// Token: 0x170005E6 RID: 1510
			// (get) Token: 0x06001053 RID: 4179 RVA: 0x0003FD50 File Offset: 0x0003DF50
			// (set) Token: 0x06001054 RID: 4180 RVA: 0x00009D66 File Offset: 0x00007F66
			public unsafe float scale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_scale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_scale)) = value;
				}
			}

			// Token: 0x170005E7 RID: 1511
			// (get) Token: 0x06001055 RID: 4181 RVA: 0x0003FD78 File Offset: 0x0003DF78
			// (set) Token: 0x06001056 RID: 4182 RVA: 0x00009D81 File Offset: 0x00007F81
			public unsafe string smartupdate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_smartupdate);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.Meta.NativeFieldInfoPtr_smartupdate), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000CBF RID: 3263
			private static readonly IntPtr NativeFieldInfoPtr_app;

			// Token: 0x04000CC0 RID: 3264
			private static readonly IntPtr NativeFieldInfoPtr_version;

			// Token: 0x04000CC1 RID: 3265
			private static readonly IntPtr NativeFieldInfoPtr_image;

			// Token: 0x04000CC2 RID: 3266
			private static readonly IntPtr NativeFieldInfoPtr_format;

			// Token: 0x04000CC3 RID: 3267
			private static readonly IntPtr NativeFieldInfoPtr_size;

			// Token: 0x04000CC4 RID: 3268
			private static readonly IntPtr NativeFieldInfoPtr_scale;

			// Token: 0x04000CC5 RID: 3269
			private static readonly IntPtr NativeFieldInfoPtr_smartupdate;
		}

		// Token: 0x020000B8 RID: 184
		[Serializable]
		public class SpriteDataObject : global::Il2CppSystem.Object
		{
			// Token: 0x06001057 RID: 4183 RVA: 0x0003FDA0 File Offset: 0x0003DFA0
			// Note: this type is marked as 'beforefieldinit'.
			static SpriteDataObject()
			{
				Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteDataObject>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TexturePacker_JsonArray>.NativeClassPtr, "SpriteDataObject");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteDataObject>.NativeClassPtr);
				TexturePacker_JsonArray.SpriteDataObject.NativeFieldInfoPtr_frames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteDataObject>.NativeClassPtr, "frames");
				TexturePacker_JsonArray.SpriteDataObject.NativeFieldInfoPtr_meta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteDataObject>.NativeClassPtr, "meta");
				TexturePacker_JsonArray.SpriteDataObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteDataObject>.NativeClassPtr, 100664916);
			}

			// Token: 0x06001058 RID: 4184 RVA: 0x0003FE08 File Offset: 0x0003E008
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SpriteDataObject()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TexturePacker_JsonArray.SpriteDataObject>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TexturePacker_JsonArray.SpriteDataObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001059 RID: 4185 RVA: 0x00009DA0 File Offset: 0x00007FA0
			public SpriteDataObject(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005E8 RID: 1512
			// (get) Token: 0x0600105A RID: 4186 RVA: 0x0003FE44 File Offset: 0x0003E044
			// (set) Token: 0x0600105B RID: 4187 RVA: 0x00009DA9 File Offset: 0x00007FA9
			public unsafe List<TexturePacker_JsonArray.Frame> frames
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.SpriteDataObject.NativeFieldInfoPtr_frames);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TexturePacker_JsonArray.Frame>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.SpriteDataObject.NativeFieldInfoPtr_frames), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005E9 RID: 1513
			// (get) Token: 0x0600105C RID: 4188 RVA: 0x0003FE74 File Offset: 0x0003E074
			// (set) Token: 0x0600105D RID: 4189 RVA: 0x00009DC8 File Offset: 0x00007FC8
			public TexturePacker_JsonArray.Meta meta
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.SpriteDataObject.NativeFieldInfoPtr_meta);
					return new TexturePacker_JsonArray.Meta(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TexturePacker_JsonArray.Meta>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePacker_JsonArray.SpriteDataObject.NativeFieldInfoPtr_meta), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TexturePacker_JsonArray.Meta>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000CC6 RID: 3270
			private static readonly IntPtr NativeFieldInfoPtr_frames;

			// Token: 0x04000CC7 RID: 3271
			private static readonly IntPtr NativeFieldInfoPtr_meta;

			// Token: 0x04000CC8 RID: 3272
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

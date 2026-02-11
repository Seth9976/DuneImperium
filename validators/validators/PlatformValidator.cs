using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace validators
{
	// Token: 0x02000015 RID: 21
	public class PlatformValidator : MonoBehaviour
	{
		// Token: 0x0600009B RID: 155 RVA: 0x0000463C File Offset: 0x0000283C
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformValidator()
		{
			Il2CppClassPointerStore<PlatformValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("validators.dll", "validators", "PlatformValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformValidator>.NativeClassPtr);
			PlatformValidator.NativeFieldInfoPtr_Mobile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformValidator>.NativeClassPtr, "Mobile");
			PlatformValidator.NativeFieldInfoPtr_Desktop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformValidator>.NativeClassPtr, "Desktop");
			PlatformValidator.NativeFieldInfoPtr_NintendoSwitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformValidator>.NativeClassPtr, "NintendoSwitch");
			PlatformValidator.NativeFieldInfoPtr_Playstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformValidator>.NativeClassPtr, "Playstation");
			PlatformValidator.NativeFieldInfoPtr_XBOX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformValidator>.NativeClassPtr, "XBOX");
			PlatformValidator.NativeFieldInfoPtr_Editor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformValidator>.NativeClassPtr, "Editor");
			PlatformValidator.NativeFieldInfoPtr__Valid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformValidator>.NativeClassPtr, "<Valid>k__BackingField");
			PlatformValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformValidator>.NativeClassPtr, 100663362);
			PlatformValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformValidator>.NativeClassPtr, 100663363);
			PlatformValidator.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformValidator>.NativeClassPtr, 100663364);
			PlatformValidator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformValidator>.NativeClassPtr, 100663365);
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00004748 File Offset: 0x00002948
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00004784 File Offset: 0x00002984
		public unsafe virtual bool Valid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000047C4 File Offset: 0x000029C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267717, XrefRangeEnd = 1267721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformValidator.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000047F8 File Offset: 0x000029F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267721, XrefRangeEnd = 1267722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformValidator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformValidator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformValidator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002476 File Offset: 0x00000676
		public PlatformValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00004834 File Offset: 0x00002A34
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x0000247F File Offset: 0x0000067F
		public unsafe bool Mobile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformValidator.NativeFieldInfoPtr_Mobile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformValidator.NativeFieldInfoPtr_Mobile)) = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x0000485C File Offset: 0x00002A5C
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x0000249A File Offset: 0x0000069A
		public unsafe bool Desktop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformValidator.NativeFieldInfoPtr_Desktop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformValidator.NativeFieldInfoPtr_Desktop)) = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00004884 File Offset: 0x00002A84
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x000024B5 File Offset: 0x000006B5
		public unsafe bool NintendoSwitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformValidator.NativeFieldInfoPtr_NintendoSwitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformValidator.NativeFieldInfoPtr_NintendoSwitch)) = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x000048AC File Offset: 0x00002AAC
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x000024D0 File Offset: 0x000006D0
		public unsafe bool Playstation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformValidator.NativeFieldInfoPtr_Playstation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformValidator.NativeFieldInfoPtr_Playstation)) = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x000048D4 File Offset: 0x00002AD4
		// (set) Token: 0x060000AA RID: 170 RVA: 0x000024EB File Offset: 0x000006EB
		public unsafe bool XBOX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformValidator.NativeFieldInfoPtr_XBOX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformValidator.NativeFieldInfoPtr_XBOX)) = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000AB RID: 171 RVA: 0x000048FC File Offset: 0x00002AFC
		// (set) Token: 0x060000AC RID: 172 RVA: 0x00002506 File Offset: 0x00000706
		public unsafe bool Editor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformValidator.NativeFieldInfoPtr_Editor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformValidator.NativeFieldInfoPtr_Editor)) = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00004924 File Offset: 0x00002B24
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00002521 File Offset: 0x00000721
		public unsafe bool _Valid_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformValidator.NativeFieldInfoPtr__Valid_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformValidator.NativeFieldInfoPtr__Valid_k__BackingField)) = value;
			}
		}

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeFieldInfoPtr_Mobile;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeFieldInfoPtr_Desktop;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr_NintendoSwitch;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr_Playstation;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr_XBOX;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeFieldInfoPtr_Editor;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeFieldInfoPtr__Valid_k__BackingField;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

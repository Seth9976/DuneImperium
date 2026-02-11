using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace CanisData.generation.builders
{
	// Token: 0x0200002D RID: 45
	public class ScriptBuilder : Object
	{
		// Token: 0x060001B1 RID: 433 RVA: 0x00009E00 File Offset: 0x00008000
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptBuilder()
		{
			Il2CppClassPointerStore<ScriptBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("CanisData.dll", "CanisData.generation.builders", "ScriptBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptBuilder>.NativeClassPtr);
			ScriptBuilder.NativeFieldInfoPtr__Identifier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptBuilder>.NativeClassPtr, "<Identifier>k__BackingField");
			ScriptBuilder.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptBuilder>.NativeClassPtr, "<Name>k__BackingField");
			ScriptBuilder.NativeMethodInfoPtr_get_Identifier_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptBuilder>.NativeClassPtr, 100663521);
			ScriptBuilder.NativeMethodInfoPtr_set_Identifier_Public_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptBuilder>.NativeClassPtr, 100663522);
			ScriptBuilder.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptBuilder>.NativeClassPtr, 100663523);
			ScriptBuilder.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptBuilder>.NativeClassPtr, 100663524);
			ScriptBuilder.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptBuilder>.NativeClassPtr, 100663525);
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x00009EBC File Offset: 0x000080BC
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x00009EF8 File Offset: 0x000080F8
		public unsafe Guid Identifier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptBuilder.NativeMethodInfoPtr_get_Identifier_Public_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptBuilder.NativeMethodInfoPtr_set_Identifier_Public_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00009F38 File Offset: 0x00008138
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00009F70 File Offset: 0x00008170
		public unsafe string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptBuilder.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptBuilder.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00009FB4 File Offset: 0x000081B4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptBuilder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptBuilder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptBuilder.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002CF4 File Offset: 0x00000EF4
		public ScriptBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00009FF0 File Offset: 0x000081F0
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x00002CFD File Offset: 0x00000EFD
		public unsafe Guid _Identifier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptBuilder.NativeFieldInfoPtr__Identifier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptBuilder.NativeFieldInfoPtr__Identifier_k__BackingField)) = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001BA RID: 442 RVA: 0x0000A018 File Offset: 0x00008218
		// (set) Token: 0x060001BB RID: 443 RVA: 0x00002D18 File Offset: 0x00000F18
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptBuilder.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptBuilder.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeFieldInfoPtr__Identifier_k__BackingField;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr_get_Identifier_Public_get_Guid_0;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr_set_Identifier_Public_set_Void_Guid_0;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

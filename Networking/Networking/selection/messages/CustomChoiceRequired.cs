using System;
using Canis.utils.ids;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Networking.selection.messages
{
	// Token: 0x0200007E RID: 126
	public class CustomChoiceRequired : SelectionMessage
	{
		// Token: 0x0600042A RID: 1066 RVA: 0x000110CC File Offset: 0x0000F2CC
		// Note: this type is marked as 'beforefieldinit'.
		static CustomChoiceRequired()
		{
			Il2CppClassPointerStore<CustomChoiceRequired>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.messages", "CustomChoiceRequired");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomChoiceRequired>.NativeClassPtr);
			CustomChoiceRequired.NativeFieldInfoPtr_SortType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceRequired>.NativeClassPtr, "SortType");
			CustomChoiceRequired.NativeFieldInfoPtr_Buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceRequired>.NativeClassPtr, "Buttons");
			CustomChoiceRequired.NativeFieldInfoPtr_SourceEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceRequired>.NativeClassPtr, "SourceEntity");
			CustomChoiceRequired.NativeFieldInfoPtr_Kind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceRequired>.NativeClassPtr, "Kind");
			CustomChoiceRequired.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceRequired>.NativeClassPtr, 100663564);
			CustomChoiceRequired.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceRequired>.NativeClassPtr, 100663565);
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00011174 File Offset: 0x0000F374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194500, XrefRangeEnd = 1194530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomChoiceRequired.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x000111B8 File Offset: 0x0000F3B8
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomChoiceRequired()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomChoiceRequired>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceRequired.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00004901 File Offset: 0x00002B01
		public CustomChoiceRequired(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x000111F4 File Offset: 0x0000F3F4
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x0000490A File Offset: 0x00002B0A
		public unsafe string SortType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceRequired.NativeFieldInfoPtr_SortType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceRequired.NativeFieldInfoPtr_SortType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x0001121C File Offset: 0x0000F41C
		// (set) Token: 0x06000431 RID: 1073 RVA: 0x00004929 File Offset: 0x00002B29
		public unsafe Il2CppReferenceArray<LocalizableText> Buttons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceRequired.NativeFieldInfoPtr_Buttons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LocalizableText>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceRequired.NativeFieldInfoPtr_Buttons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x0001124C File Offset: 0x0000F44C
		// (set) Token: 0x06000433 RID: 1075 RVA: 0x00004948 File Offset: 0x00002B48
		public unsafe EntityID SourceEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceRequired.NativeFieldInfoPtr_SourceEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceRequired.NativeFieldInfoPtr_SourceEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x0001127C File Offset: 0x0000F47C
		// (set) Token: 0x06000435 RID: 1077 RVA: 0x00004967 File Offset: 0x00002B67
		public unsafe string Kind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceRequired.NativeFieldInfoPtr_Kind);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceRequired.NativeFieldInfoPtr_Kind), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeFieldInfoPtr_SortType;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeFieldInfoPtr_Buttons;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeFieldInfoPtr_SourceEntity;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeFieldInfoPtr_Kind;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000C9 RID: 201
		[ObfuscatedName("Networking.selection.messages.CustomChoiceRequired+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000684 RID: 1668 RVA: 0x00017064 File Offset: 0x00015264
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CustomChoiceRequired.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomChoiceRequired>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomChoiceRequired.__c>.NativeClassPtr);
				CustomChoiceRequired.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceRequired.__c>.NativeClassPtr, "<>9");
				CustomChoiceRequired.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceRequired.__c>.NativeClassPtr, "<>9__4_0");
				CustomChoiceRequired.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceRequired.__c>.NativeClassPtr, 100663567);
				CustomChoiceRequired.__c.NativeMethodInfoPtr__ToString_b__4_0_Internal_String_LocalizableText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceRequired.__c>.NativeClassPtr, 100663568);
			}

			// Token: 0x06000685 RID: 1669 RVA: 0x000170E0 File Offset: 0x000152E0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomChoiceRequired.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceRequired.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000686 RID: 1670 RVA: 0x0001711C File Offset: 0x0001531C
			[CallerCount(0)]
			public unsafe string _ToString_b__4_0(LocalizableText x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceRequired.__c.NativeMethodInfoPtr__ToString_b__4_0_Internal_String_LocalizableText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000687 RID: 1671 RVA: 0x000060B6 File Offset: 0x000042B6
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001E2 RID: 482
			// (get) Token: 0x06000688 RID: 1672 RVA: 0x00017164 File Offset: 0x00015364
			// (set) Token: 0x06000689 RID: 1673 RVA: 0x000060BF File Offset: 0x000042BF
			public unsafe static CustomChoiceRequired.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CustomChoiceRequired.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomChoiceRequired.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CustomChoiceRequired.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001E3 RID: 483
			// (get) Token: 0x0600068A RID: 1674 RVA: 0x0001718C File Offset: 0x0001538C
			// (set) Token: 0x0600068B RID: 1675 RVA: 0x000060D1 File Offset: 0x000042D1
			public unsafe static Func<LocalizableText, string> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CustomChoiceRequired.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<LocalizableText, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CustomChoiceRequired.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000362 RID: 866
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000363 RID: 867
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04000364 RID: 868
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000365 RID: 869
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__4_0_Internal_String_LocalizableText_0;
		}
	}
}

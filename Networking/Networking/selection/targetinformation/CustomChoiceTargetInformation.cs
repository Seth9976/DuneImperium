using System;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Networking.selection.targetinformation
{
	// Token: 0x02000068 RID: 104
	public class CustomChoiceTargetInformation : TargetInformation
	{
		// Token: 0x06000361 RID: 865 RVA: 0x0000EA1C File Offset: 0x0000CC1C
		// Note: this type is marked as 'beforefieldinit'.
		static CustomChoiceTargetInformation()
		{
			Il2CppClassPointerStore<CustomChoiceTargetInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.targetinformation", "CustomChoiceTargetInformation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomChoiceTargetInformation>.NativeClassPtr);
			CustomChoiceTargetInformation.NativeFieldInfoPtr_SortType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceTargetInformation>.NativeClassPtr, "SortType");
			CustomChoiceTargetInformation.NativeFieldInfoPtr_Choices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceTargetInformation>.NativeClassPtr, "Choices");
			CustomChoiceTargetInformation.NativeFieldInfoPtr_Titles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceTargetInformation>.NativeClassPtr, "Titles");
			CustomChoiceTargetInformation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceTargetInformation>.NativeClassPtr, 100663481);
			CustomChoiceTargetInformation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceTargetInformation>.NativeClassPtr, 100663482);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000EAB0 File Offset: 0x0000CCB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194183, XrefRangeEnd = 1194210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomChoiceTargetInformation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000EAF4 File Offset: 0x0000CCF4
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 487155, RefRangeEnd = 487190, XrefRangeStart = 487155, XrefRangeEnd = 487190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomChoiceTargetInformation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomChoiceTargetInformation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceTargetInformation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000364 RID: 868 RVA: 0x000042D2 File Offset: 0x000024D2
		public CustomChoiceTargetInformation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000365 RID: 869 RVA: 0x0000EB30 File Offset: 0x0000CD30
		// (set) Token: 0x06000366 RID: 870 RVA: 0x000042DB File Offset: 0x000024DB
		public unsafe string SortType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceTargetInformation.NativeFieldInfoPtr_SortType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceTargetInformation.NativeFieldInfoPtr_SortType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000367 RID: 871 RVA: 0x0000EB58 File Offset: 0x0000CD58
		// (set) Token: 0x06000368 RID: 872 RVA: 0x000042FA File Offset: 0x000024FA
		public unsafe Il2CppReferenceArray<LocalizableText> Choices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceTargetInformation.NativeFieldInfoPtr_Choices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LocalizableText>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceTargetInformation.NativeFieldInfoPtr_Choices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000369 RID: 873 RVA: 0x0000EB88 File Offset: 0x0000CD88
		// (set) Token: 0x0600036A RID: 874 RVA: 0x00004319 File Offset: 0x00002519
		public unsafe Il2CppReferenceArray<LocalizableText> Titles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceTargetInformation.NativeFieldInfoPtr_Titles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LocalizableText>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceTargetInformation.NativeFieldInfoPtr_Titles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeFieldInfoPtr_SortType;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeFieldInfoPtr_Choices;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeFieldInfoPtr_Titles;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000C4 RID: 196
		[ObfuscatedName("Networking.selection.targetinformation.CustomChoiceTargetInformation+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000661 RID: 1633 RVA: 0x00016A74 File Offset: 0x00014C74
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CustomChoiceTargetInformation.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomChoiceTargetInformation>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomChoiceTargetInformation.__c>.NativeClassPtr);
				CustomChoiceTargetInformation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceTargetInformation.__c>.NativeClassPtr, "<>9");
				CustomChoiceTargetInformation.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceTargetInformation.__c>.NativeClassPtr, "<>9__3_0");
				CustomChoiceTargetInformation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceTargetInformation.__c>.NativeClassPtr, 100663484);
				CustomChoiceTargetInformation.__c.NativeMethodInfoPtr__ToString_b__3_0_Internal_String_LocalizableText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceTargetInformation.__c>.NativeClassPtr, 100663485);
			}

			// Token: 0x06000662 RID: 1634 RVA: 0x00016AF0 File Offset: 0x00014CF0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomChoiceTargetInformation.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceTargetInformation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000663 RID: 1635 RVA: 0x00016B2C File Offset: 0x00014D2C
			[CallerCount(0)]
			public unsafe string _ToString_b__3_0(LocalizableText _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceTargetInformation.__c.NativeMethodInfoPtr__ToString_b__3_0_Internal_String_LocalizableText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000664 RID: 1636 RVA: 0x00005FD0 File Offset: 0x000041D0
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001DA RID: 474
			// (get) Token: 0x06000665 RID: 1637 RVA: 0x00016B74 File Offset: 0x00014D74
			// (set) Token: 0x06000666 RID: 1638 RVA: 0x00005FD9 File Offset: 0x000041D9
			public unsafe static CustomChoiceTargetInformation.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CustomChoiceTargetInformation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomChoiceTargetInformation.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CustomChoiceTargetInformation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001DB RID: 475
			// (get) Token: 0x06000667 RID: 1639 RVA: 0x00016B9C File Offset: 0x00014D9C
			// (set) Token: 0x06000668 RID: 1640 RVA: 0x00005FEB File Offset: 0x000041EB
			public unsafe static Func<LocalizableText, string> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CustomChoiceTargetInformation.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<LocalizableText, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CustomChoiceTargetInformation.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000351 RID: 849
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000352 RID: 850
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04000353 RID: 851
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000354 RID: 852
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__3_0_Internal_String_LocalizableText_0;
		}
	}
}

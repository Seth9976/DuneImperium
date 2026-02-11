using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Globalization;

namespace UnityEngine.UIElements
{
	// Token: 0x020001FA RID: 506
	public class UxmlIntAttributeDescription : TypedUxmlAttributeDescription<int>
	{
		// Token: 0x060027B1 RID: 10161 RVA: 0x000AEBB0 File Offset: 0x000ACDB0
		// Note: this type is marked as 'beforefieldinit'.
		static UxmlIntAttributeDescription()
		{
			Il2CppClassPointerStore<UxmlIntAttributeDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UxmlIntAttributeDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlIntAttributeDescription>.NativeClassPtr);
			UxmlIntAttributeDescription.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlIntAttributeDescription>.NativeClassPtr, 100669263);
			UxmlIntAttributeDescription.NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_Int32_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlIntAttributeDescription>.NativeClassPtr, 100669264);
			UxmlIntAttributeDescription.NativeMethodInfoPtr_TryGetValueFromBag_Public_Boolean_IUxmlAttributes_CreationContext_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlIntAttributeDescription>.NativeClassPtr, 100669265);
			UxmlIntAttributeDescription.NativeMethodInfoPtr_ConvertValueToInt_Private_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlIntAttributeDescription>.NativeClassPtr, 100669266);
		}

		// Token: 0x060027B2 RID: 10162 RVA: 0x000AEC30 File Offset: 0x000ACE30
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 343485, RefRangeEnd = 343511, XrefRangeStart = 343475, XrefRangeEnd = 343485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UxmlIntAttributeDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlIntAttributeDescription>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlIntAttributeDescription.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027B3 RID: 10163 RVA: 0x000AEC6C File Offset: 0x000ACE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343511, XrefRangeEnd = 343530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bag);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UxmlIntAttributeDescription.NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_Int32_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027B4 RID: 10164 RVA: 0x000AECDC File Offset: 0x000ACEDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 343549, RefRangeEnd = 343551, XrefRangeStart = 343530, XrefRangeEnd = 343549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bag);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlIntAttributeDescription.NativeMethodInfoPtr_TryGetValueFromBag_Public_Boolean_IUxmlAttributes_CreationContext_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027B5 RID: 10165 RVA: 0x000AED50 File Offset: 0x000ACF50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343551, XrefRangeEnd = 343552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ConvertValueToInt(string v, int defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(v);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlIntAttributeDescription.NativeMethodInfoPtr_ConvertValueToInt_Private_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027B6 RID: 10166 RVA: 0x000101CE File Offset: 0x0000E3CE
		public UxmlIntAttributeDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x060027B7 RID: 10167 RVA: 0x000AEDA0 File Offset: 0x000ACFA0
		public override string defaultValueAsString
		{
			get
			{
				return base.defaultValue.ToString(CultureInfo.InvariantCulture.NumberFormat);
			}
		}

		// Token: 0x04001C38 RID: 7224
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001C39 RID: 7225
		private static readonly IntPtr NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_Int32_IUxmlAttributes_CreationContext_0;

		// Token: 0x04001C3A RID: 7226
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValueFromBag_Public_Boolean_IUxmlAttributes_CreationContext_byref_Int32_0;

		// Token: 0x04001C3B RID: 7227
		private static readonly IntPtr NativeMethodInfoPtr_ConvertValueToInt_Private_Static_Int32_String_Int32_0;

		// Token: 0x02000509 RID: 1289
		[ObfuscatedName("UnityEngine.UIElements.UxmlIntAttributeDescription+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003FC3 RID: 16323 RVA: 0x000FDD3C File Offset: 0x000FBF3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UxmlIntAttributeDescription.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UxmlIntAttributeDescription>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlIntAttributeDescription.__c>.NativeClassPtr);
				UxmlIntAttributeDescription.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlIntAttributeDescription.__c>.NativeClassPtr, "<>9");
				UxmlIntAttributeDescription.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlIntAttributeDescription.__c>.NativeClassPtr, "<>9__3_0");
				UxmlIntAttributeDescription.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlIntAttributeDescription.__c>.NativeClassPtr, "<>9__4_0");
				UxmlIntAttributeDescription.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlIntAttributeDescription.__c>.NativeClassPtr, 100669268);
				UxmlIntAttributeDescription.__c.NativeMethodInfoPtr__GetValueFromBag_b__3_0_Internal_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlIntAttributeDescription.__c>.NativeClassPtr, 100669269);
				UxmlIntAttributeDescription.__c.NativeMethodInfoPtr__TryGetValueFromBag_b__4_0_Internal_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlIntAttributeDescription.__c>.NativeClassPtr, 100669270);
			}

			// Token: 0x06003FC4 RID: 16324 RVA: 0x000FDDE0 File Offset: 0x000FBFE0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlIntAttributeDescription.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlIntAttributeDescription.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003FC5 RID: 16325 RVA: 0x000FDE1C File Offset: 0x000FC01C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343474, XrefRangeEnd = 343475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetValueFromBag_b__3_0(string s, int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlIntAttributeDescription.__c.NativeMethodInfoPtr__GetValueFromBag_b__3_0_Internal_Int32_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003FC6 RID: 16326 RVA: 0x000FDE78 File Offset: 0x000FC078
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _TryGetValueFromBag_b__4_0(string s, int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlIntAttributeDescription.__c.NativeMethodInfoPtr__TryGetValueFromBag_b__4_0_Internal_Int32_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003FC7 RID: 16327 RVA: 0x0001ABD0 File Offset: 0x00018DD0
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001319 RID: 4889
			// (get) Token: 0x06003FC8 RID: 16328 RVA: 0x000FDED4 File Offset: 0x000FC0D4
			// (set) Token: 0x06003FC9 RID: 16329 RVA: 0x0001ABD9 File Offset: 0x00018DD9
			public unsafe static UxmlIntAttributeDescription.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UxmlIntAttributeDescription.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlIntAttributeDescription.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UxmlIntAttributeDescription.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700131A RID: 4890
			// (get) Token: 0x06003FCA RID: 16330 RVA: 0x000FDEFC File Offset: 0x000FC0FC
			// (set) Token: 0x06003FCB RID: 16331 RVA: 0x0001ABEB File Offset: 0x00018DEB
			public unsafe static Func<string, int, int> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UxmlIntAttributeDescription.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UxmlIntAttributeDescription.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700131B RID: 4891
			// (get) Token: 0x06003FCC RID: 16332 RVA: 0x000FDF24 File Offset: 0x000FC124
			// (set) Token: 0x06003FCD RID: 16333 RVA: 0x0001ABFD File Offset: 0x00018DFD
			public unsafe static Func<string, int, int> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UxmlIntAttributeDescription.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UxmlIntAttributeDescription.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D05 RID: 11525
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002D06 RID: 11526
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04002D07 RID: 11527
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04002D08 RID: 11528
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D09 RID: 11529
			private static readonly IntPtr NativeMethodInfoPtr__GetValueFromBag_b__3_0_Internal_Int32_String_Int32_0;

			// Token: 0x04002D0A RID: 11530
			private static readonly IntPtr NativeMethodInfoPtr__TryGetValueFromBag_b__4_0_Internal_Int32_String_Int32_0;
		}

		// Token: 0x0200050A RID: 1290
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
